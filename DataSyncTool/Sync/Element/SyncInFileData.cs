using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using DataEntities.Config;
using DataEntities.Contact.Agency;
using DataEntities.Contact.Client;
using DataEntities.Element.Files;
using DataSyncTool.Common;
using DataSyncTool.Log;
using DataSyncTool.PC.Model;
using DataSyncTool.Sync.Base;
using DevExpress.Xpo;

namespace DataSyncTool.Sync.Element
{
    public class SyncInFileData : SyncData<InFile, RECEIVINGLOG>
    {
        public SyncInFileData(object dataIPSPIndex) : base(dataIPSPIndex)
        {
        }

        public override RECEIVINGLOG GetExistDataPC(InFile dataIPSP)
        {
            if (dataIPSP.dt_ReceiveDate < new DateTime(1900, 1, 1))
            {
                SyncResultInfoSet.AddWarning(InfoString.ToSkipInfo("收文日", dataIPSP.n_FileID,
                    dataIPSP.sMainCaseSerial + "----" + dataIPSP.s_Name));
                return null;
            }
            if (string.IsNullOrWhiteSpace(dataIPSP.s_Name))
            {
                SyncResultInfoSet.AddWarning(InfoString.ToSkipInfo("文件名", dataIPSP.n_FileID, dataIPSP.sMainCaseSerial));
                return null;
            }
            if (string.IsNullOrWhiteSpace(dataIPSP.sCaseName))
            {
                SyncResultInfoSet.AddWarning(InfoString.ToSkipInfo("案件", dataIPSP.n_FileID, dataIPSP.s_Name));
                return null;
            }
            var sCondition = $"RECEIVED = to_date('{dataIPSP.dt_ReceiveDate:yyyy/MM/dd}','yyyy/MM/dd') and OURNO = '{dataIPSP.sMainCaseSerial}' and COMMENTS like '%{dataIPSP.s_Name}%'";
            var existInFile = new PC.BLL.RECEIVINGLOG().GetModelList(sCondition);
            IsExistDataPC = existInFile.Count > 0;
            SyncResultInfoSet.AddInfo(InfoString.ToSyncInfo("来文", IsExistDataPC.Value, dataIPSP.n_FileID, dataIPSP.sMainCaseSerial + " " + dataIPSP.s_Name),
                dataIPSP.ClassInfo.TableName, typeof(RECEIVINGLOG).Name);
            return existInFile.Count > 0 ? existInFile[0] : null;
        }

        public override void ConvertToDataPC(RECEIVINGLOG dataPC, InFile dataIPSP)
        {
            dataPC.PID = DateTime.Now.ToString("yyyyMMdd_HHmmss_ffffff_0");
            dataPC.ISSUEDATE = dataIPSP.dt_SendDate;
            dataPC.RECEIVED = dataIPSP.dt_ReceiveDate;
            var nDealerId = dataIPSP.FileConfirm.FirstOrDefault(c => c.s_DistributeType == "D")?.n_ConfirmorID;
            if (nDealerId > 0)
                dataPC.HANDLER = dataIPSP.Session.GetObjectByKey<CodeEmployee>(nDealerId)?.s_InternalCode;
            if (dataIPSP.s_ClientGov == "O")
            {
                if (dataIPSP.n_GovOfficeID > 0)
                {
                    dataPC.SENDER = dataIPSP.Session.GetObjectByKey<CodeOfficial>(dataIPSP.n_GovOfficeID)?.s_Name;
                }
                else if (dataIPSP.n_AgencyOfficeID > 0)
                {
                    dataPC.SENDERID = dataIPSP.Session.GetObjectByKey<Agency>(dataIPSP.n_AgencyOfficeID)?.s_Name;
                }
            }
            else if (dataIPSP.s_ClientGov == "C")
            {
                dataPC.SENDERID = dataIPSP.TheClient?.s_ClientCode;
                dataPC.SENDER = dataIPSP.TheClient?.s_Name;

            }
            dataPC.OURNO = dataIPSP.TheMainCase?.s_CaseSerial;
            dataPC.APPNO = dataIPSP.TheMainCase?.s_AppNo;
            dataPC.CLIENTNO = dataIPSP.TheFileClient?.s_ClientCode;
            dataPC.CONTENT = "other";
            dataPC.COPIES = 1M;
            dataPC.PAGES = 0;
            switch (dataIPSP.s_SendMethod)
            {
                case "来函":
                    dataPC.RECEIVEDBY = "Mail";
                    break;
                case "传真":
                    dataPC.RECEIVEDBY = "Fax";
                    break;
                case "电子邮件":
                    dataPC.RECEIVEDBY = "Email";
                    break;
                case "电话":
                    dataPC.RECEIVEDBY = "Fornotice";
                    break;
                case "电子文件":
                    dataPC.RECEIVEDBY = "ClientSys";
                    break;
                default:
                    dataPC.RECEIVEDBY = "";
                    break;
            }

            dataPC.COMMENTS = dataIPSP.s_Name + "\r\n" + dataIPSP.s_Note;
            dataPC.STATUS = "P";

            FillDefaultValue();
            if (!IsExistDataPC.HasValue) return;
            if (IsExistDataPC.Value)
            {
                new PC.BLL.RECEIVINGLOG().Update(dataPC);
            }
            else
            {
                new PC.BLL.RECEIVINGLOG().Add(dataPC);
                if (string.IsNullOrWhiteSpace(dataIPSP.s_FilePathName)) return;
                var sSourceFilePath = Path.Combine(ConfigHelper.GetConfigString("SourceFilePath"), dataIPSP.s_FilePathName);
                if (!File.Exists(sSourceFilePath))
                    return;
                var sFileName = Regex.Match(dataIPSP.s_Abstact, @"(?<=\[\[\[).*(?=\]\]\])").Value;
                if (string.IsNullOrWhiteSpace(sFileName))
                    return;
                var sBusiness = dataIPSP.TheMainCase?.GetBusinessTypeName();
                var sCaseType = "";
                if (sBusiness.Contains("PCT国际"))
                {
                    sCaseType = "Drop-International";
                }
                else if (sBusiness.Contains("香港"))
                {
                    sCaseType = "Drop-HK";
                }
                else if (sBusiness.Contains("国内"))
                {
                    sCaseType = "Drop-CN";
                }
                else if (sBusiness.Contains("国外"))
                {
                    sCaseType = "Drop-International";
                }
                else
                {
                    sCaseType = "Drop-Others";
                }
                var sTargetFile = $@"{ConfigHelper.GetConfigString("TargetFilePath")}\{sCaseType}\{(dataIPSP.s_ClientGov == "O" ? "From_Client" : "From_Office")}\{sFileName}{Path.GetExtension(dataIPSP.s_FilePathName)}";
                if (!Directory.Exists(Path.GetDirectoryName(sTargetFile)))
                    Directory.CreateDirectory(Path.GetDirectoryName(sTargetFile));
                File.Copy(sSourceFilePath, sTargetFile, true);
            }
        }
    }
}
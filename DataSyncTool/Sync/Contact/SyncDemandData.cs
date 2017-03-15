using System;
using System.Collections;
using System.Data.OracleClient;
using System.Linq;
using DataEntities.Contact.Client;
using DataEntities.Contact.Demand;
using DataSyncTool.DBUtility;
using DataSyncTool.Log;
using DataSyncTool.PC.Model;
using DataSyncTool.Sync.Base;

namespace DataSyncTool.Sync.Contact
{
    public class SyncDemandData : SyncData<Demand, GENERAL_INSTRUCTION>
    {
        private Hashtable htDemandType;
        public SyncDemandData(object dataIPSPIndex) : base(dataIPSPIndex)
        {
            htDemandType = CommonFunction.GetRelatesType();
        }

        public override GENERAL_INSTRUCTION GetExistDataPC(Demand dataIPSP)
        {
            var sCode = GetCode(dataIPSP);
            var sCondition = $"CONTENT_CN =:p AND CLIENT_NO = '{sCode}'";
            var pid = new PC.BLL.GENERAL_INSTRUCTION().GetSingle(sCondition, dataIPSP.s_Description ?? string.Empty);
            if (pid == null) return null;
            IsExistDataPC = true;
            var instruction = new PC.BLL.GENERAL_INSTRUCTION().GetModel(pid.ToString());
            SyncResultInfoSet.AddInfo(InfoString.ToSyncInfo("要求", IsExistDataPC.Value, dataIPSP.n_ID, sCode + " " + dataIPSP.s_Description),
                dataIPSP.ClassInfo.TableName, typeof(GENERAL_INSTRUCTION).Name);
            return instruction;
        }


        public override void ConvertToDataPC(GENERAL_INSTRUCTION dataPC, Demand dataIPSP)
        {
            var sCode = GetCode(dataIPSP);
            dataPC.PID = DateTime.Now.ToString("yyyyMMdd_HHmmss_ffffff");
            if (string.IsNullOrWhiteSpace(sCode))
            {
                SyncResultInfoSet.AddWarning(InfoString.ToSkipInfo("代码", dataIPSP.n_ID, sCode + " " + dataIPSP.s_Description));
                return;
            }
            dataPC.CLIENT_NO = sCode;
            if (dataIPSP.dt_ReceiptDate <= new DateTime(1900, 1, 1))
            {
                SyncResultInfoSet.AddWarning(InfoString.ToSkipInfo("收到日", dataIPSP.n_ID, sCode + " " + dataIPSP.s_Description));
                return;
            }
            dataPC.RECEIVED = dataIPSP.dt_ReceiptDate;
            if (string.IsNullOrWhiteSpace(dataIPSP.s_ReceiptMethod))
            {
                SyncResultInfoSet.AddWarning(InfoString.ToSkipInfo("收到方式", dataIPSP.n_ID, sCode + " " + dataIPSP.s_Description));
                return;
            }
            if (dataIPSP.s_ReceiptMethod.ToLower().Contains("fax") || dataIPSP.s_ReceiptMethod.ToLower().Contains("传真"))
                dataPC.RECEIVED_BY = "fax";
            else if (dataIPSP.s_ReceiptMethod.ToLower().Contains("mail") || dataIPSP.s_ReceiptMethod.ToLower().Contains("信"))
                dataPC.RECEIVED_BY = "mail";
            else if (dataIPSP.s_ReceiptMethod.ToLower().Contains("email") || dataIPSP.s_ReceiptMethod.ToLower().Contains("邮件") || dataIPSP.s_ReceiptMethod.ToLower().Contains("邮箱"))
                dataPC.RECEIVED_BY = "email";
            else
                dataPC.RECEIVED_BY = "other";

            dataPC.RELATES_TO = htDemandType.ContainsKey(dataIPSP.s_Title) ? htDemandType[dataIPSP.s_Title].ToString() : "other";

            dataPC.CONTENT_CN = dataIPSP.s_Description;
            dataPC.INSTRUCTOR = dataIPSP.s_Assignor;
            dataPC.STATUS = "valid";
            //dataPC.EXPIRE_DATE
            //dataPC.COMMENTS

            FillDefaultValue();
            if (!IsExistDataPC.HasValue) return;
            if (IsExistDataPC.Value)
            {
                new PC.BLL.GENERAL_INSTRUCTION().Update(dataPC);
            }
            else
            {
                new PC.BLL.GENERAL_INSTRUCTION().Add(dataPC);
            }
        }

        private static string GetCode(Demand dataIPSP)
        {
            var sCode = string.Empty;
            if (dataIPSP.TheClient != null)
                sCode = dataIPSP.TheClient.s_ClientCode;
            else if (dataIPSP.TheApplicant != null)
                sCode = dataIPSP.TheApplicant.s_AppCode;
            else if (dataIPSP.TheAgency != null)
                sCode = dataIPSP.TheAgency.s_Code;
            return sCode;
        }
    }
}
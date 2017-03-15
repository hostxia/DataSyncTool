using System;
using System.Linq;
using DataEntities.Case;
using DataEntities.Case.Patents;
using DataEntities.Config;
using DataEntities.Contact.Client;
using DataEntities.Contact.Demand;
using DataEntities.Element.Fee;
using DataEntities.Element.Files;
using DataSyncTool.Log;
using DataSyncTool.PC.Model;
using DataSyncTool.Sync.Base;
using DevExpress.Xpo;

namespace DataSyncTool.Sync.Case
{
    public class SyncPatentHKData : SyncData<HongKongApplication, EX_HKCASE>
    {
        public SyncPatentHKData(object dataIPSPIndex) : base(dataIPSPIndex)
        {
        }

        public override EX_HKCASE GetExistDataPC(HongKongApplication dataIPSP)
        {
            if (string.IsNullOrWhiteSpace(dataIPSP.s_CaseSerial))
            {
                SyncResultInfoSet.AddWarning($"{dataIPSP.n_CaseID}未填写我方卷号，跳过导入。");
                IsExistDataPC = null;
                return null;
            }
            var existPatent = new PC.BLL.EX_HKCASE().GetModel(dataIPSP.s_CaseSerial);
            IsExistDataPC = existPatent != null;
            SyncResultInfoSet.AddInfo(
                InfoString.ToSyncInfo("香港专利", IsExistDataPC.Value, dataIPSP.n_CaseID, dataIPSP.s_CaseSerial),
                dataIPSP.ClassInfo.TableName, typeof(EX_HKCASE).Name);
            return existPatent;
        }

        public override void ConvertToDataPC(EX_HKCASE dataPC, HongKongApplication dataIPSP)
        {
            dataPC.HK_APP_REF = dataIPSP.s_CaseSerial;
            dataPC.HK_APP_NO = dataIPSP.TheLawInfo.s_AppNo;
            dataPC.HK_PUB_NO = dataIPSP.TheLawInfo.s_PubNo;
            dataPC.HK_REG1_DATE = dataIPSP.dt_1stRegisterDate ?? DateTime.MinValue;
            dataPC.HK_PUB1_DATE = dataIPSP.dt_1stPublish ?? DateTime.MinValue;
            dataPC.MAINTENANCE_DUEDATE = dataIPSP.dt_RemindShldDate ?? DateTime.MinValue;
            dataPC.HK_REG2_DATE = dataIPSP.dt_2ndRegisterDate ?? DateTime.MinValue;
            //dataPC.NEXT_RENEWAL_DUEDATE//年费期限
            //dataPC.CN_APP_REF//母案卷号
            //dataPC.CN_APP_NO//母案申请号
            //dataPC.CN_APP_DATE//母案申请日
            //dataPC.P4_SENDING_DATE//P4寄出日
            dataPC.FIRST_AGENCY_REPORT = dataIPSP.dt_1stAgentReport ?? DateTime.MinValue;
            //dataPC.TO_PUB//转公开
            //dataPC.P5_SENDING_DATE//P5寄出日
            dataPC.SECOND_AGENCY_REPORT = dataIPSP.dt_2ndAgentReport ?? DateTime.MinValue;
            //dataPC.TO_GRANT//转授权
            dataPC.COMMENTS = dataIPSP.Memos.Cast<CaseMemo>()
                .Aggregate(string.Empty, (s, m) => s + "\r\n" + m.s_Memo + "\r\n");
            dataPC.CLIENT_REF = dataIPSP.s_ClientSerial;
            dataPC.CLIENT = dataIPSP.TheClient?.s_ClientCode;
            dataPC.HK_ANNO_NO = dataIPSP.TheLawInfo.s_IssuedPubNo;
            //dataPC.HK_GAZETTE//第二步公告日
            //dataPC.PARENT_COUNTRY//母案国家
            dataPC.RECEIVED = dataIPSP.dt_UndertakeDate;
            if (CommonFunction.UnActiveCaseStatus.Contains(dataIPSP.s_CaseStatus))
                dataPC.ABANDON = "Y";
            dataPC.PRIORITY = dataIPSP.dt_EarlistPriorityDate;
            dataPC.SENDADDRESS = dataIPSP.TheClient?.ClientAddress.Cast<ClientAddress>()
                    .FirstOrDefault(a => a.s_Type != null && a.s_Type.Contains("M"))?.s_Street;
            //dataPC.ADDRCHECK//认为正确
            dataPC.APPLICANT = dataIPSP.s_ApplicantsNativeName;

            FillDefaultValue();
            if (!IsExistDataPC.HasValue) return;
            if (IsExistDataPC.Value)
                new PC.BLL.EX_HKCASE().Update(dataPC);
            else
                new PC.BLL.EX_HKCASE().Add(dataPC);
        }
    }
}
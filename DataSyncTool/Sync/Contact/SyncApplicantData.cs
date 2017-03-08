using System.Linq;
using DataEntities.Contact.Applicant;
using DataEntities.Contact.Demand;
using DataSyncTool.PC.Model;
using DataSyncTool.Sync.Base;
using DevExpress.Xpo;

namespace DataSyncTool.Sync.Contact
{
    public class SyncApplicantData : SyncData<Applicant, CLIENTDB>
    {
        public override CLIENTDB GetExistDataPC(Applicant dataIPSP)
        {
            if (string.IsNullOrWhiteSpace(dataIPSP.s_AppCode))
            {
                SyncResultInfoSet.AddWarning($"{dataIPSP.n_AppID}未填写申请人代码，跳过导入。");
                IsExistDataPC = null;
                return null;
            }
            var existClient = new PC.BLL.CLIENTDB().GetModel(dataIPSP.s_AppCode);
            IsExistDataPC = existClient != null;
            return existClient;
        }

        public override void ConvertToDataPC(CLIENTDB dataPC, Applicant dataIPSP)
        {
            dataPC.CLIENTID = dataIPSP.s_AppCode;
            dataPC.CLIENTNAME = dataIPSP.s_NativeName;
            dataPC.CLIENTCNAME = dataIPSP.s_Name;
            dataPC.BILLALIAS = dataIPSP.s_AccountName;
            dataPC.BILLING_CONTACT = dataIPSP.ApplicantAddress.Cast<ApplicantAddress>().FirstOrDefault(a => a.s_Type.Contains("B"))?.s_Street;
            dataPC.MAILING_ADDR = dataIPSP.ApplicantAddress.Cast<ApplicantAddress>().FirstOrDefault(a => a.s_Type.Contains("M"))?.s_Street;
            dataPC.MAILING_CONTACT = dataIPSP.ApplicantAddress.Cast<ApplicantAddress>().FirstOrDefault(a => a.s_Type.Contains("M"))?.s_TitleAddress;
            dataPC.PT_GENERAL_INSTR = dataIPSP.Demands.Cast<Demand>().Aggregate(string.Empty, (s, d) => s + "\r\n" + d.s_Title + "\r\n" + d.s_Description + "\r\n");
            dataPC.PT_APPN_COPY = 0;
            dataPC.PT_BILL_COPY = 0;

            //if (!IsExistDataPC.HasValue) return;
            //if (IsExistDataPC.Value)
            //{
            //    new PC.BLL.CLIENTDB().Update(dataPC);
            //}
            //else
            //{
            //    new PC.BLL.CLIENTDB().Add(dataPC);
            //}
        }
    }
}
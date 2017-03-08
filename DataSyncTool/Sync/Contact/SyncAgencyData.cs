using System.Linq;
using DataSyncTool.DBIPS4_Import;
using DataSyncTool.PC.Model;
using DataSyncTool.Sync.Base;
using DevExpress.Xpo;

namespace DataSyncTool.Sync.Contact
{
    public class SyncAgencyData : SyncData<TCstmr_CoopAgency, CLIENTDB>
    {
        public override CLIENTDB GetExistDataPC(TCstmr_CoopAgency dataIPSP)
        {
            if (string.IsNullOrWhiteSpace(dataIPSP.s_Code))
            {
                SyncResultInfoSet.AddWarning($"{dataIPSP.n_AgencyID}未填写代理机构代码，跳过导入。");
                IsExistDataPC = null;
                return null;
            }
            var existClient = new PC.BLL.CLIENTDB().GetModel(dataIPSP.s_Code);
            IsExistDataPC = existClient != null;
            return existClient;
        }

        public override void ConvertToDataPC(CLIENTDB dataPC, TCstmr_CoopAgency dataIPSP)
        {
            dataPC.CLIENTID = dataIPSP.s_Code;
            dataPC.CLIENTNAME = dataIPSP.s_NativeName;
            dataPC.CLIENTCNAME = dataIPSP.s_Name;
            dataPC.BILLALIAS = dataIPSP.s_BeneficiaryName;
            dataPC.BILLING_CONTACT = dataIPSP.TCstmr_AgencyAddresss.FirstOrDefault(a => a.s_Type.Contains("B"))?.s_Street;
            dataPC.MAILING_ADDR = dataIPSP.TCstmr_AgencyAddresss.FirstOrDefault(a => a.s_Type.Contains("M"))?.s_Street;
            dataPC.MAILING_CONTACT = dataIPSP.TCstmr_AgencyAddresss.FirstOrDefault(a => a.s_Type.Contains("M"))?.s_IsMailingAddress;
            dataPC.PT_GENERAL_INSTR =
                new XPQuery<T_Demand>(new UnitOfWork()).Where(d => d.n_AgencyID != null && d.n_AgencyID.n_AgencyID == dataIPSP.n_AgencyID).ToList()
                    .Aggregate(string.Empty, (s, d) => s + "\r\n" + d.s_Title + "\r\n" + d.s_Description + "\r\n");
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
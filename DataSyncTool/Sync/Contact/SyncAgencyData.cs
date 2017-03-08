using System.Linq;
using DataEntities.Contact.Agency;
using DataSyncTool.PC.Model;
using DataSyncTool.Sync.Base;

namespace DataSyncTool.Sync.Contact
{
    public class SyncAgencyData : SyncData<Agency, CLIENTDB>
    {
        public override CLIENTDB GetExistDataPC(Agency dataIPSP)
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

        public override void ConvertToDataPC(CLIENTDB dataPC, Agency dataIPSP)
        {
            dataPC.CLIENTID = dataIPSP.s_Code;
            dataPC.CLIENTNAME = dataIPSP.s_NativeName;
            dataPC.CLIENTCNAME = dataIPSP.s_Name;
            dataPC.BILLALIAS = dataIPSP.s_BeneficiaryName;
            dataPC.BILLING_CONTACT =
                dataIPSP.AgencyAddresses.Cast<AgencyAddress>().FirstOrDefault(a => a.s_Type.Contains("B"))?.s_Street;
            dataPC.MAILING_ADDR =
                dataIPSP.AgencyAddresses.Cast<AgencyAddress>().FirstOrDefault(a => a.s_Type.Contains("M"))?.s_Street;
            dataPC.MAILING_CONTACT =
                dataIPSP.AgencyAddresses.Cast<AgencyAddress>()
                    .FirstOrDefault(a => a.s_Type.Contains("M"))?.s_IsMailingAddress;
            dataPC.PT_GENERAL_INSTR = dataIPSP.Demands.Aggregate(string.Empty,
                (s, d) => s + "\r\n" + d.s_Title + "\r\n" + d.s_Description + "\r\n");
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
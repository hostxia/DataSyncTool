using System.Linq;
using DataEntities.Contact.Agency;
using DataSyncTool.Log;
using DataSyncTool.PC.Model;
using DataSyncTool.Sync.Base;

namespace DataSyncTool.Sync.Contact
{
    public class SyncAgencyData : SyncData<Agency, CLIENTDB>
    {
        public SyncAgencyData(object dataIPSPIndex) : base(dataIPSPIndex)
        {
        }

        public override CLIENTDB GetExistDataPC(Agency dataIPSP)
        {
            if (string.IsNullOrWhiteSpace(dataIPSP.s_Code))
            {
                SyncResultInfoSet.AddWarning($"{dataIPSP.n_AgencyID}未填写代理机构代码，跳过导入。");
                IsExistDataPC = null;
                return null;
            }
            var existAgency = new PC.BLL.CLIENTDB().GetModel(dataIPSP.s_Code);
            IsExistDataPC = existAgency != null;
            SyncResultInfoSet.AddInfo(
                InfoString.ToSyncInfo("代理机构", IsExistDataPC.Value, dataIPSP.n_AgencyID, dataIPSP.s_Code),
                dataIPSP.ClassInfo.TableName, typeof(CLIENTDB).Name);
            return existAgency;
        }

        public override void ConvertToDataPC(CLIENTDB dataPC, Agency dataIPSP)
        {
            dataPC.CLIENTID = dataIPSP.s_Code;
            dataPC.CLIENTNAME = dataIPSP.s_NativeName;
            dataPC.CLIENTCNAME = dataIPSP.s_Name;
            //dataPC.BILLALIAS = dataIPSP.s_BeneficiaryName;
            dataPC.BILLING_CONTACT =
                dataIPSP.AgencyAddress.Cast<AgencyAddress>().FirstOrDefault(a => a.s_Type.Contains("B"))?.s_Street;
            dataPC.MAILING_ADDR =
                dataIPSP.AgencyAddress.Cast<AgencyAddress>().FirstOrDefault(a => a.s_Type.Contains("M"))?.s_Street;
            //dataPC.MAILING_CONTACT =
            //    dataIPSP.AgencyAddress.Cast<AgencyAddress>()
            //        .FirstOrDefault(a => a.s_Type.Contains("M"))?.s_IsMailingAddress;
            dataPC.PT_GENERAL_INSTR = dataIPSP.s_Notes;
            dataPC.PT_APPN_COPY = 0;
            dataPC.PT_BILL_COPY = 0;
            FillDefaultValue();
            if (!IsExistDataPC.HasValue) return;
            if (IsExistDataPC.Value)
            {
                new PC.BLL.CLIENTDB().Update(dataPC);
            }
            else
            {
                new PC.BLL.CLIENTDB().Add(dataPC);
            }
        }
    }
}
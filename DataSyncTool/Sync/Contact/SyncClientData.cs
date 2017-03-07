using System.Linq;
using DataSyncTool.DBIPS4_Import;
using DataSyncTool.PC.Model;
using DataSyncTool.Sync.Base;
using DevExpress.Xpo;

namespace DataSyncTool.Sync.Contact
{
    public class SyncClientData : SyncData<TCstmr_Client, CLIENTDB>
    {
        public override CLIENTDB GetExistDataPC(TCstmr_Client dataIPSP)
        {
            if (string.IsNullOrWhiteSpace(dataIPSP.s_ClientCode))
            {
                SyncResultInfoSet.AddWarning($"{dataIPSP.n_ClientID}未填写客户代码，跳过导入。");
                IsExistDataPC = null;
                return null;
            }
            var existClient = new PC.BLL.CLIENTDB().GetModel(dataIPSP.s_ClientCode);
            IsExistDataPC = existClient != null;
            return existClient;
        }

        public override void ConvertToDataPC(CLIENTDB dataPC, TCstmr_Client dataIPSP)
        {
            dataPC.CLIENTID = dataIPSP.s_ClientCode;
            dataPC.CLIENTNAME = dataIPSP.s_NativeName;
            dataPC.CLIENTCNAME = dataIPSP.s_Name;
            dataPC.BILLALIAS = dataIPSP.s_AccountName;

            var contact = dataIPSP.TCstmr_ClientContacts.FirstOrDefault(c => c.TCstmr_ClientConAddresss.Any(a => a.s_Type.Contains("B")));
            dataPC.BILLING_CONTACT = contact?.s_LastName + contact?.s_FirstName;
            dataPC.MAILING_ADDR = dataIPSP.TCstmr_ClientAddresss.FirstOrDefault(a => a.s_Type.Contains("M"))?.s_Street;

            var contactMailing = dataIPSP.TCstmr_ClientContacts.FirstOrDefault(c => c.TCstmr_ClientConAddresss.Any(a => a.s_Type.Contains("M")));
            dataPC.MAILING_CONTACT = contactMailing?.s_LastName + contactMailing?.s_FirstName;
            dataPC.PT_GENERAL_INSTR =
                new XPQuery<T_Demand>(new UnitOfWork()).Where(d => d.n_ClientID != null && d.n_ClientID.n_ClientID == dataIPSP.n_ClientID).ToList()
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
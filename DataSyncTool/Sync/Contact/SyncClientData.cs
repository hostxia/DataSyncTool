using System.Linq;
using DataEntities.Contact.Client;
using DataSyncTool.Log;
using DataSyncTool.PC.Model;
using DataSyncTool.Sync.Base;

namespace DataSyncTool.Sync.Contact
{
    public class SyncClientData : SyncData<Client, CLIENTDB>
    {
        public SyncClientData(object dataIPSPIndex) : base(dataIPSPIndex)
        {
        }

        public override CLIENTDB GetExistDataPC(Client dataIPSP)
        {
            if (string.IsNullOrWhiteSpace(dataIPSP.s_ClientCode))
            {
                SyncResultInfoSet.AddWarning($"{dataIPSP.n_ClientID}未填写客户代码，跳过导入。");
                IsExistDataPC = null;
                return null;
            }
            var existClient = new PC.BLL.CLIENTDB().GetModel(dataIPSP.s_ClientCode);
            IsExistDataPC = existClient != null;
            SyncResultInfoSet.AddInfo(InfoString.ToSyncInfo("客户", IsExistDataPC.Value, dataIPSP.n_ClientID, dataIPSP.s_ClientCode),
                dataIPSP.ClassInfo.TableName, typeof(CLIENTDB).Name);
            return existClient;
        }

        public override void ConvertToDataPC(CLIENTDB dataPC, Client dataIPSP)
        {
            dataPC.CLIENTID = dataIPSP.s_ClientCode;
            dataPC.CLIENTNAME = dataIPSP.s_NativeName;
            dataPC.CLIENTCNAME = dataIPSP.s_Name;
            //dataPC.BILLALIAS = dataIPSP.s_AccountName;王蕊说不更新，苏文静也说不用更新
            dataPC.BILLING_CONTACT =
                dataIPSP.ClientAddress.Cast<ClientAddress>()
                    .FirstOrDefault(a => a.s_Type != null && a.s_Type.Contains("B"))?.s_TitleAddress;
            dataPC.MAILING_ADDR =
                dataIPSP.ClientAddress.Cast<ClientAddress>()
                    .FirstOrDefault(a => a.s_Type != null && a.s_Type.Contains("M"))?.s_Street;
            dataPC.MAILING_CONTACT =
                dataIPSP.ClientAddress.Cast<ClientAddress>()
                    .FirstOrDefault(a => a.s_Type != null && a.s_Type.Contains("M"))?.s_TitleAddress;
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
using System.Collections.Generic;
using System.Linq;
using DataEntities.Contact.Client;
using DataSyncTool.Common;
using DataSyncTool.PC.Model;
using DataSyncTool.Sync.Base;
using DevExpress.Xpo;

namespace DataSyncTool.Sync.Contact
{
    public class SyncClientList : SyncList<Client, CLIENTDB>
    {
        public override List<SyncData<Client, CLIENTDB>> GetListSyncData()
        {
            SyncResultInfoSet?.AddInfo("筛选需同步的客户数据...");
            return
                new XPQuery<Client>(new UnitOfWork()).Where(
                        c =>
                            c.dt_CreateDate >= ConfigHelper.BeginDate && c.dt_CreateDate < ConfigHelper.NextDate ||
                            c.dt_EditDate >= ConfigHelper.BeginDate && c.dt_EditDate < ConfigHelper.NextDate)
                    .Select(c => c.n_ClientID)
                    .ToList()
                    .Select(c => new SyncClientData(c) { SyncResultInfoSet = SyncResultInfoSet })
                    .Cast<SyncData<Client, CLIENTDB>>()
                    .ToList();
        }

        public override List<SyncData<Client, CLIENTDB>> GetListRelatedData()
        {
            return new List<SyncData<Client, CLIENTDB>>();
        }
    }
}
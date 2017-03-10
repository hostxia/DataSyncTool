using System.Collections.Generic;
using System.Linq;
using DataEntities.Contact.Agency;
using DataSyncTool.Common;
using DataSyncTool.PC.Model;
using DataSyncTool.Sync.Base;
using DevExpress.Xpo;

namespace DataSyncTool.Sync.Contact
{
    public class SyncAgencyList : SyncList<Agency, CLIENTDB>
    {
        public override List<SyncData<Agency, CLIENTDB>> GetListSyncData()
        {
            SyncResultInfoSet?.AddInfo("筛选需同步的代理机构数据...");
            return new XPQuery<Agency>(new UnitOfWork()).Where(
                    c =>
                        c.dt_CreateDate >= ConfigHelper.BeginDate && c.dt_CreateDate < ConfigHelper.NextDate ||
                        c.dt_EditDate >= ConfigHelper.BeginDate && c.dt_EditDate < ConfigHelper.NextDate)
                .Select(c => c.n_AgencyID)
                .ToList()
                .Select(c => new SyncAgencyData(c) { SyncResultInfoSet = SyncResultInfoSet })
                .Cast<SyncData<Agency, CLIENTDB>>()
                .ToList();
        }

        public override List<SyncData<Agency, CLIENTDB>> GetListRelatedData()
        {
            return new List<SyncData<Agency, CLIENTDB>>();
        }
    }
}
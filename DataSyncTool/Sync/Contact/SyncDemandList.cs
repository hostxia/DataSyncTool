using System.Collections.Generic;
using System.Linq;
using DataEntities.Contact.Demand;
using DataSyncTool.Common;
using DataSyncTool.PC.Model;
using DataSyncTool.Sync.Base;
using DevExpress.Xpo;

namespace DataSyncTool.Sync.Contact
{
    public class SyncDemandList : SyncList<Demand, GENERAL_INSTRUCTION>
    {
        public override List<SyncData<Demand, GENERAL_INSTRUCTION>> GetListSyncData()
        {
            SyncResultInfoSet?.AddInfo("筛选需同步的要求数据...");
            return
                new XPQuery<Demand>(new UnitOfWork()).Where(
                        c =>
                            (c.dt_CreateDate >= ConfigHelper.BeginDate && c.dt_CreateDate < ConfigHelper.NextDate ||
                             c.dt_EditDate >= ConfigHelper.BeginDate && c.dt_EditDate < ConfigHelper.NextDate) &&
                            (c.TheClient != null || c.TheApplicant != null || c.TheAgency != null))
                    .Select(c => c.n_ID)
                    .ToList()
                    .Select(c => new SyncDemandData(c) { SyncResultInfoSet = SyncResultInfoSet })
                    .Cast<SyncData<Demand, GENERAL_INSTRUCTION>>()
                    .ToList();
        }

        public override List<SyncData<Demand, GENERAL_INSTRUCTION>> GetListRelatedData()
        {
            return new List<SyncData<Demand, GENERAL_INSTRUCTION>>();
        }
    }
}
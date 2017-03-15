using System.Collections.Generic;
using System.Linq;
using DataEntities.Element.Files;
using DataEntities.TaskFlowData;
using DataSyncTool.Common;
using DataSyncTool.PC.Model;
using DataSyncTool.Sync.Base;
using DevExpress.Xpo;

namespace DataSyncTool.Sync.Element
{
    public class SyncOAList : SyncList<TFTaskChain, GENERALALERT>
    {
        public override List<SyncData<TFTaskChain, GENERALALERT>> GetListSyncData()
        {
            SyncResultInfoSet?.AddInfo("筛选需同步的OA数据...");
            return
                new XPQuery<TFTask>(new UnitOfWork()).Where(
                        c =>
                            c.dt_CreateTime >= ConfigHelper.BeginDate && c.dt_CreateTime < ConfigHelper.NextDate ||
                            c.dt_EditTime >= ConfigHelper.BeginDate && c.dt_EditTime < ConfigHelper.NextDate ||
                            c.dt_FinishTime >= ConfigHelper.BeginDate && c.dt_FinishTime < ConfigHelper.NextDate).ToList()
                    .Select(c => c.GetTheTaskChain().g_ID).Distinct()
                    .ToList()
                    .Select(c => new SyncOAData(c) { SyncResultInfoSet = SyncResultInfoSet })
                    .Cast<SyncData<TFTaskChain, GENERALALERT>>()
                    .ToList();
        }

        public override List<SyncData<TFTaskChain, GENERALALERT>> GetListRelatedData()
        {
            return new List<SyncData<TFTaskChain, GENERALALERT>>();
        }
    }
}
using System.Collections.Generic;
using System.Linq;
using DataEntities.Case.Patents;
using DataSyncTool.Common;
using DataSyncTool.PC.Model;
using DataSyncTool.Sync.Base;
using DevExpress.Xpo;

namespace DataSyncTool.Sync.Case
{
    public class SyncPatentAbroadList : SyncList<ExtendedPatent, FCASE>
    {
        public override List<SyncData<ExtendedPatent, FCASE>> GetListSyncData()
        {
            SyncResultInfoSet?.AddInfo("筛选需同步的国外专利数据...");
            return
                new XPQuery<ExtendedPatent>(new UnitOfWork()).Where(
                        c =>
                            (c.dt_CreateDate >= ConfigHelper.BeginDate && c.dt_CreateDate < ConfigHelper.NextDate ||
                             c.dt_EditDate >= ConfigHelper.BeginDate && c.dt_EditDate < ConfigHelper.NextDate) &&
                            (c.s_FlowDirection == "IO" || c.s_FlowDirection == "OO")).Select(c => c.n_CaseID).ToList()
                    .Select(i => new SyncPatentAbroadData(i) { SyncResultInfoSet = SyncResultInfoSet }).Cast<SyncData<ExtendedPatent, FCASE>>()
                    .ToList();
        }

        public override List<SyncData<ExtendedPatent, FCASE>> GetListRelatedData()
        {
            return new List<SyncData<ExtendedPatent, FCASE>>();
        }
    }
}
using System.Collections.Generic;
using System.Linq;
using DataEntities.Case.Patents;
using DataEntities.Config;
using DataSyncTool.Common;
using DataSyncTool.PC.Model;
using DataSyncTool.Sync.Base;
using DevExpress.Xpo;

namespace DataSyncTool.Sync.Case
{
    public class SyncPatentList : SyncList<ExtendedPatent, PATENTCASE>
    {
        public override List<SyncData<ExtendedPatent, PATENTCASE>> GetListSyncData()
        {
            SyncResultInfoSet?.AddInfo("筛选需同步的国内专利数据...");
            return
                new XPQuery<ExtendedPatent>(new UnitOfWork()).Where(
                        c =>
                            (c.dt_CreateDate >= ConfigHelper.BeginDate && c.dt_CreateDate < ConfigHelper.NextDate ||
                             c.dt_EditDate >= ConfigHelper.BeginDate && c.dt_EditDate < ConfigHelper.NextDate) &&
                            GetPatentBusinessType().Contains(c.n_BusinessTypeID)).Select(c => c.n_CaseID).ToList()
                    .Select(i => new SyncPatentData(i) { SyncResultInfoSet = SyncResultInfoSet })
                    .Cast<SyncData<ExtendedPatent, PATENTCASE>>()
                    .ToList();
        }

        public override List<SyncData<ExtendedPatent, PATENTCASE>> GetListRelatedData()
        {
            return new List<SyncData<ExtendedPatent, PATENTCASE>>();
        }

        private static List<int> GetPatentBusinessType()
        {
            return new XPQuery<CodeBusinessType>(new UnitOfWork()).Where(b => new[] { "UM", "PU", "ID", "IN", "PI", "AF" }.Contains(b.s_Code)).Select(b => b.n_ID).ToList();
        }
    }
}
using System.Collections.Generic;
using System.Linq;
using DataEntities.Case.Patents;
using DataSyncTool.Common;
using DataSyncTool.PC.Model;
using DataSyncTool.Sync.Base;
using DevExpress.Xpo;

namespace DataSyncTool.Sync.Case
{
    public class SyncPatentHKList : SyncList<HongKongApplication, EX_HKCASE>
    {
        public override List<SyncData<HongKongApplication, EX_HKCASE>> GetListSyncData()
        {
            SyncResultInfoSet?.AddInfo("筛选需同步的香港专利数据...");
            return
                new XPQuery<HongKongApplication>(new UnitOfWork()).Where(
                        c =>
                            c.dt_CreateDate >= ConfigHelper.BeginDate && c.dt_CreateDate < ConfigHelper.NextDate ||
                            c.dt_EditDate >= ConfigHelper.BeginDate && c.dt_EditDate < ConfigHelper.NextDate).Select(c => c.n_CaseID).ToList()
                    .Select(i => new SyncPatentHKData(i) { SyncResultInfoSet = SyncResultInfoSet })
                    .Cast<SyncData<HongKongApplication, EX_HKCASE>>()
                    .ToList();
        }

        public override List<SyncData<HongKongApplication, EX_HKCASE>> GetListRelatedData()
        {
            return new List<SyncData<HongKongApplication, EX_HKCASE>>();
        }
    }
}
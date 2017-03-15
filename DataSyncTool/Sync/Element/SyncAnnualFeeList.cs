using System.Collections.Generic;
using System.Linq;
using DataEntities.Case.Patents;
using DataEntities.Contact.Client;
using DataEntities.Element.Files;
using DataSyncTool.Common;
using DataSyncTool.PC.Model;
using DataSyncTool.Sync.Base;
using DevExpress.Xpo;

namespace DataSyncTool.Sync.Element
{
    public class SyncAnnualFeeList : SyncList<AnnualFee, GENERALALERT>
    {
        public override List<SyncData<AnnualFee, GENERALALERT>> GetListSyncData()
        {
            SyncResultInfoSet?.AddInfo("筛选需同步的年费数据...");
            return
                new XPQuery<AnnualFee>(new UnitOfWork()).Where(
                        c =>
                            c.dt_CreateDate >= ConfigHelper.BeginDate && c.dt_CreateDate < ConfigHelper.NextDate ||
                            c.dt_EditDate >= ConfigHelper.BeginDate && c.dt_EditDate < ConfigHelper.NextDate || c.dt_OfficialPayDate >= ConfigHelper.BeginDate && c.dt_OfficialPayDate < ConfigHelper.NextDate)
                    .Select(c => c.n_AnnualFeeID)
                    .ToList()
                    .Select(c => new SyncAnnualFeeData(c) { SyncResultInfoSet = SyncResultInfoSet })
                    .Cast<SyncData<AnnualFee, GENERALALERT>>()
                    .ToList();
        }

        public override List<SyncData<AnnualFee, GENERALALERT>> GetListRelatedData()
        {
            return new List<SyncData<AnnualFee, GENERALALERT>>();
        }
    }
}
using System.Collections.Generic;
using System.Linq;
using DataEntities.Case.Patents;
using DataSyncTool.Common;
using DataSyncTool.PC.Model;
using DataSyncTool.Sync.Base;
using DevExpress.Data.Filtering;
using DevExpress.Xpo;

namespace DataSyncTool.Sync.Case
{
    public class SyncPatentList : SyncList<ExtendedPatent, PATENTCASE>
    {
        public override List<SyncData<ExtendedPatent, PATENTCASE>> GetListSyncData()
        {
            //var sCondition = $"dt_CreateDate Between (#{ConfigHelper.BeginDate}#, #{ConfigHelper.NextDate}#) Or dt_EditDate Between (#{ConfigHelper.BeginDate}#, #{ConfigHelper.NextDate}#)";
            //SyncResultInfoSet?.AddInfo("筛选需同步的国内专利数据...", typeof(ExtendedPatent).Name, string.Empty, $"查询条件：{sCondition}");
            return
                new XPQuery<ExtendedPatent>(new UnitOfWork()).Where(c => c.dt_CreateDate >= ConfigHelper.BeginDate && c.dt_CreateDate < ConfigHelper.NextDate || c.dt_EditDate >= ConfigHelper.BeginDate && c.dt_EditDate < ConfigHelper.NextDate).Select(c => c.n_CaseID).ToList()
                    .Select(i => new SyncPatentData { DataIPSPIndex = i, SyncResultInfoSet = SyncResultInfoSet })
                    .Cast<SyncData<ExtendedPatent, PATENTCASE>>()
                    .ToList();
        }

        public override List<SyncData<ExtendedPatent, PATENTCASE>> GetListRelatedData()
        {
            return new List<SyncData<ExtendedPatent, PATENTCASE>>();
        }
    }
}
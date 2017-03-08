using System.Collections.Generic;
using System.Linq;
using DataSyncTool.Common;
using DataSyncTool.DBIPS4_Import;
using DataSyncTool.PC.Model;
using DataSyncTool.Sync.Base;
using DevExpress.Data.Filtering;
using DevExpress.Xpo;

namespace DataSyncTool.Sync.Case
{
    public class SyncPatentList : SyncList<TPCase_Patent, PATENTCASE>
    {
        public override List<SyncData<TPCase_Patent, PATENTCASE>> GetListSyncData()
        {
            var sCondition = $"dt_CreateDate Between (#{ConfigHelper.BeginDate}#, #{ConfigHelper.NextDate}#) Or dt_EditDate Between (#{ConfigHelper.BeginDate}#, #{ConfigHelper.NextDate}#)";
            SyncResultInfoSet?.AddInfo("筛选需同步的国内专利数据...", typeof(TPCase_Patent).Name, string.Empty, $"查询条件：{sCondition}");
            return
                new XPCollection<TPCase_Patent>(CriteriaOperator.Parse(sCondition))
                    .Select(c => new SyncPatentData { DataIPSP = c, SyncResultInfoSet = SyncResultInfoSet })
                    .Cast<SyncData<TPCase_Patent, PATENTCASE>>()
                    .ToList();
        }

        public override List<SyncData<TPCase_Patent, PATENTCASE>> GetListRelatedData()
        {
            return new List<SyncData<TPCase_Patent, PATENTCASE>>();
        }
    }
}
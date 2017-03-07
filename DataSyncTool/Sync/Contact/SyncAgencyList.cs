using System.Collections.Generic;
using System.Linq;
using DataSyncTool.Common;
using DataSyncTool.DBIPS4_Import;
using DataSyncTool.PC.Model;
using DataSyncTool.Sync.Base;
using DevExpress.Data.Filtering;
using DevExpress.Xpo;

namespace DataSyncTool.Sync.Contact
{
    public class SyncAgencyList : SyncList<TCstmr_CoopAgency, CLIENTDB>
    {
        public override List<SyncData<TCstmr_CoopAgency, CLIENTDB>> GetListSyncData()
        {
            var sCondition = $"dt_CreateDate Between (#{ConfigHelper.BeginDate}#, #{ConfigHelper.NextDate}#) Or dt_EditDate Between (#{ConfigHelper.BeginDate}#, #{ConfigHelper.NextDate}#)";
            SyncResultInfoSet?.AddInfo("筛选需同步的代理机构数据...", typeof(TCstmr_CoopAgency).Name, string.Empty, $"查询条件：{sCondition}");
            return
                new XPCollection<TCstmr_CoopAgency>(CriteriaOperator.Parse(sCondition))
                    .Select(c => new SyncAgencyData() { DataIPSP = c, SyncResultInfoSet = SyncResultInfoSet })
                    .Cast<SyncData<TCstmr_CoopAgency, CLIENTDB>>()
                    .ToList();
        }

        public override List<SyncData<TCstmr_CoopAgency, CLIENTDB>> GetListRelatedData()
        {
            return new List<SyncData<TCstmr_CoopAgency, CLIENTDB>>();
        }
    }
}
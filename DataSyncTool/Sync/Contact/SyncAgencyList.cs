using System.Collections.Generic;
using System.Linq;
using DataEntities.Contact.Agency;
using DataSyncTool.Common;
using DataSyncTool.PC.Model;
using DataSyncTool.Sync.Base;
using DevExpress.Data.Filtering;
using DevExpress.Xpo;

namespace DataSyncTool.Sync.Contact
{
    public class SyncAgencyList : SyncList<Agency, CLIENTDB>
    {
        public override List<SyncData<Agency, CLIENTDB>> GetListSyncData()
        {
            var sCondition = $"dt_CreateDate Between (#{ConfigHelper.BeginDate}#, #{ConfigHelper.NextDate}#) Or dt_EditDate Between (#{ConfigHelper.BeginDate}#, #{ConfigHelper.NextDate}#)";
            SyncResultInfoSet?.AddInfo("筛选需同步的代理机构数据...", typeof(Agency).Name, string.Empty, $"查询条件：{sCondition}");
            return
                new XPCollection<Agency>(CriteriaOperator.Parse(sCondition))
                    .Select(c => new SyncAgencyData() { DataIPSP = c, SyncResultInfoSet = SyncResultInfoSet })
                    .Cast<SyncData<Agency, CLIENTDB>>()
                    .ToList();
        }

        public override List<SyncData<Agency, CLIENTDB>> GetListRelatedData()
        {
            return new List<SyncData<Agency, CLIENTDB>>();
        }
    }
}
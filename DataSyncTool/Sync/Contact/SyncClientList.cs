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
    public class SyncClientList : SyncList<TCstmr_Client, CLIENTDB>
    {
        public override List<SyncData<TCstmr_Client, CLIENTDB>> GetListSyncData()
        {
            var sCondition = $"dt_CreateDate Between (#{ConfigHelper.BeginDate}#, #{ConfigHelper.NextDate}#) Or dt_EditDate Between (#{ConfigHelper.BeginDate}#, #{ConfigHelper.NextDate}#)";
            SyncResultInfoSet?.AddInfo("筛选需同步的客户数据...", typeof(TCstmr_Client).Name, string.Empty, $"查询条件：{sCondition}");
            return
                new XPCollection<TCstmr_Client>(CriteriaOperator.Parse(sCondition))
                    .Select(c => new SyncClientData { DataIPSP = c, SyncResultInfoSet = SyncResultInfoSet })
                    .Cast<SyncData<TCstmr_Client, CLIENTDB>>()
                    .ToList();
        }

        public override List<SyncData<TCstmr_Client, CLIENTDB>> GetListRelatedData()
        {
            return new List<SyncData<TCstmr_Client, CLIENTDB>>();
        }
    }
}
using System.Collections.Generic;
using System.Linq;
using DataEntities.Contact.Client;
using DataSyncTool.Common;
using DataSyncTool.PC.Model;
using DataSyncTool.Sync.Base;
using DevExpress.Data.Filtering;
using DevExpress.Xpo;

namespace DataSyncTool.Sync.Contact
{
    public class SyncClientList : SyncList<Client, CLIENTDB>
    {
        public override List<SyncData<Client, CLIENTDB>> GetListSyncData()
        {
            var sCondition = $"dt_CreateDate Between (#{ConfigHelper.BeginDate}#, #{ConfigHelper.NextDate}#) Or dt_EditDate Between (#{ConfigHelper.BeginDate}#, #{ConfigHelper.NextDate}#)";
            SyncResultInfoSet?.AddInfo("筛选需同步的客户数据...", typeof(Client).Name, string.Empty, $"查询条件：{sCondition}");
            return
                new XPCollection<Client>(CriteriaOperator.Parse(sCondition))
                    .Select(c => new SyncClientData { DataIPSP = c, SyncResultInfoSet = SyncResultInfoSet })
                    .Cast<SyncData<Client, CLIENTDB>>()
                    .ToList();
        }

        public override List<SyncData<Client, CLIENTDB>> GetListRelatedData()
        {
            return new List<SyncData<Client, CLIENTDB>>();
        }
    }
}
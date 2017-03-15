using System.Collections.Generic;
using System.Linq;
using DataEntities.Case;
using DataEntities.Contact.Client;
using DataSyncTool.Common;
using DataSyncTool.PC.Model;
using DataSyncTool.Sync.Base;
using DevExpress.Xpo;

namespace DataSyncTool.Sync.Case
{
    public class SyncCustomFieldList : SyncList<CustomField, CASEOTHERINFO>
    {
        public override List<SyncData<CustomField, CASEOTHERINFO>> GetListSyncData()
        {
            SyncResultInfoSet?.AddInfo("筛选需同步的自定义属性数据...");
            return
                new XPQuery<BasicCase>(new UnitOfWork()).Where(
                        c => c.dt_CreateDate >= ConfigHelper.BeginDate && c.dt_CreateDate < ConfigHelper.NextDate ||
                            c.dt_EditDate >= ConfigHelper.BeginDate && c.dt_EditDate < ConfigHelper.NextDate).ToList()
                    .SelectMany(c => c.CustomFields.Cast<CustomField>().Select(d => d.n_ID).ToList())
                    .ToList()
                    .Select(c => new SyncCustomFieldData(c) { SyncResultInfoSet = SyncResultInfoSet })
                    .Cast<SyncData<CustomField, CASEOTHERINFO>>()
                    .ToList();
        }

        public override List<SyncData<CustomField, CASEOTHERINFO>> GetListRelatedData()
        {
            return new List<SyncData<CustomField, CASEOTHERINFO>>();
        }
    }
}
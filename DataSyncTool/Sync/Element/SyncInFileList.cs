using System.Collections.Generic;
using System.Linq;
using DataEntities.Element.Files;
using DataSyncTool.Common;
using DataSyncTool.PC.Model;
using DataSyncTool.Sync.Base;
using DevExpress.Xpo;

namespace DataSyncTool.Sync.Element
{
    public class SyncInFileList : SyncList<InFile, RECEIVINGLOG>
    {
        public override List<SyncData<InFile, RECEIVINGLOG>> GetListSyncData()
        {
            SyncResultInfoSet?.AddInfo("筛选需同步的来文数据...");
            return
                new XPQuery<InFile>(new UnitOfWork()).Where(
                        c =>
                            c.dt_CreateDate >= ConfigHelper.BeginDate && c.dt_CreateDate < ConfigHelper.NextDate ||
                            c.dt_EditDate >= ConfigHelper.BeginDate && c.dt_EditDate < ConfigHelper.NextDate)
                    .Select(c => c.n_FileID)
                    .ToList()
                    .Select(c => new SyncInFileData(c) { SyncResultInfoSet = SyncResultInfoSet })
                    .Cast<SyncData<InFile, RECEIVINGLOG>>()
                    .ToList();
        }

        public override List<SyncData<InFile, RECEIVINGLOG>> GetListRelatedData()
        {
            return new List<SyncData<InFile, RECEIVINGLOG>>();
        }
    }
}
using System.Collections.Generic;
using System.Linq;
using DataSyncTool.Log;
using DevExpress.Xpo;

namespace DataSyncTool.Sync.Base
{
    public abstract class SyncList<TSource, TTarget> : List<SyncData<TSource, TTarget>>
        where TSource : XPLiteObject, new()
        where TTarget : class, new()
    {
        public bool IsRelatedData { get; set; }

        public SyncResultInfoSet SyncResultInfoSet { get; set; }

        public abstract List<SyncData<TSource, TTarget>> GetListSyncData();

        public abstract List<SyncData<TSource, TTarget>> GetListRelatedData();

        public virtual void DataSync()
        {
            if (IsRelatedData)
            {
                AddRange(GetListRelatedData());
            }
            else
            {
                AddRange(GetListSyncData());
            }
            SyncResultInfoSet?.AddInfo("同步数据...", typeof(TSource).Name, typeof(TTarget).Name);
            ForEach(d =>
            {
                d.SaveDataPC();
            });
            SyncResultInfoSet?.AddInfo("数据同步完成！", typeof(TSource).Name, typeof(TTarget).Name);
        }
    }
}
using System;
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
            ForEach(d =>
            {
                try
                {
                    d.SaveDataPC();
                }
                catch (Exception e)
                {
                    SyncResultInfoSet.AddError(e.ToString());
                }

            });
        }
    }
}
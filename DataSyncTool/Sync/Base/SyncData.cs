using DataSyncTool.Log;
using DevExpress.Xpo;

namespace DataSyncTool.Sync.Base
{
    public abstract class SyncData<TSource, TTarget>
        where TSource : XPLiteObject, new()
        where TTarget : class, new()
    {
        public SyncResultInfoSet SyncResultInfoSet { get; set; }

        public bool? IsExistDataPC { get; set; }

        public TSource DataIPSP { get; set; }

        public TTarget DataPC { get; set; }

        public abstract TTarget GetExistDataPC(TSource dataIPSP);

        public abstract void ConvertToDataPC(TTarget dataPC, TSource dataIPSP);

        public virtual TTarget SaveDataPC()
        {
            DataPC = GetExistDataPC(DataIPSP) ?? new TTarget();
            if (!IsExistDataPC.HasValue)
                return null;
            var sInfo =
                $"{(IsExistDataPC.Value ? "更新" : "添加")}：{typeof(TSource).Name} - {DataIPSP.ClassInfo.KeyProperty.GetValue(DataIPSP)}";
            SyncResultInfoSet?.AddInfo(sInfo, typeof(TSource).Name, typeof(TTarget).Name);
            ConvertToDataPC(DataPC, DataIPSP);
            return DataPC;
        }
    }
}
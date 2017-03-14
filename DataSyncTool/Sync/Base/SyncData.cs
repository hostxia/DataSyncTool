using System;
using DataSyncTool.Log;
using DevExpress.Xpo;

namespace DataSyncTool.Sync.Base
{
    public abstract class SyncData<TSource, TTarget>
        where TSource : XPLiteObject, new()
        where TTarget : class, new()
    {
        protected SyncData(object dataIPSPIndex)
        {
            DataIPSPIndex = dataIPSPIndex;
        }
        public SyncResultInfoSet SyncResultInfoSet { get; set; }

        public bool? IsExistDataPC { get; set; }

        public object DataIPSPIndex { get; set; }

        public TTarget DataPC { get; set; }

        public abstract TTarget GetExistDataPC(TSource dataIPSP);

        public abstract void ConvertToDataPC(TTarget dataPC, TSource dataIPSP);

        public virtual TTarget SaveDataPC()
        {
            using (var unitOfWork = new UnitOfWork())
            {
                var dataIPSP = unitOfWork.GetObjectByKey<TSource>(DataIPSPIndex);
                DataPC = GetExistDataPC(dataIPSP) ?? new TTarget();
                if (!IsExistDataPC.HasValue)
                    return null;
                ConvertToDataPC(DataPC, dataIPSP);
                unitOfWork.Dispose();
            }
            return DataPC;

        }

        public void FillDefaultValue()
        {
            FillDefaultValue(DataPC);
        }

        public void FillDefaultValue(object objData)
        {
            foreach (var property in objData.GetType().GetProperties())
            {
                if (property.PropertyType != typeof(string)) continue;
                if (property.GetValue(objData) != null) continue;
                property.SetValue(objData, string.Empty);
                property.SetValue(objData, property.GetValue(objData).ToString().Replace("'", "''"));
            }

        }
    }
}
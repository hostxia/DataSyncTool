using System;
using DataEntities.TaskFlowBase;
using DevExpress.Xpo;

namespace DataEntities.TaskFlowData
{
    [Persistent("TF_TaskCycleConfig")]
    public class TFTaskCycleConfig : XPLiteObjectUser
    {
        Guid fg_ID;
        [Key(false)]
        public Guid g_ID
        {
            get { return fg_ID; }
            set { SetPropertyValue<Guid>("g_ID", ref fg_ID, value); }
        }

        Guid fg_TaskChainGuid;
        public Guid g_TaskChainGuid
        {
            get { return fg_TaskChainGuid; }
            set { SetPropertyValue<Guid>("g_TaskChainGuid", ref fg_TaskChainGuid, value); }
        }

        string fs_CyclePara;
        [Size(200)]
        public string s_CyclePara
        {
            get { return fs_CyclePara; }
            set { SetPropertyValue<string>("s_CyclePara", ref fs_CyclePara, value); }
        }

        DateTime fdt_BaseDate;
        [NullValue(typeof(DateTime), "0001/1/1 0:00:00")]
        public DateTime dt_BaseDate
        {
            get { return fdt_BaseDate; }
            set { SetPropertyValue<DateTime>("dt_BaseDate", ref fdt_BaseDate, value); }
        }

        int fn_AdvanceDays;
        public int n_AdvanceDays
        {
            get { return fn_AdvanceDays; }
            set { SetPropertyValue<int>("n_AdvanceDays", ref fn_AdvanceDays, value); }
        }

        string fs_IsChanged;
        [Size(1)]
        public string s_IsChanged
        {
            get { return fs_IsChanged; }
            set { SetPropertyValue<string>("s_IsChanged", ref fs_IsChanged, value); }
        }

        DateTime fdt_OriginalBaseDate;
        [NullValue(typeof(DateTime), "0001/1/1 0:00:00")]
            public DateTime dt_OriginalBaseDate
        {
            get { return fdt_OriginalBaseDate; }
            set { SetPropertyValue<DateTime>("dt_OriginalBaseDate", ref fdt_OriginalBaseDate, value); }
        }

        public TFTaskCycleConfig(Session session) : base(session) { }
    }
}

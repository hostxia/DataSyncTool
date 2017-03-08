using System;
using DataEntities.TaskFlowBase;
using DevExpress.Xpo;

namespace DataEntities.TaskFlowData
{
    [Persistent("TF_TaskCheck")]
    public class TFTaskCheck : XPLiteObjectUser
    {
        Guid fg_ID;
        [Key(false)]
        public Guid g_ID
        {
            get { return fg_ID; }
            set { SetPropertyValue<Guid>("g_ID", ref fg_ID, value); }
        }

        Guid? fg_TaskID;
        public Guid? g_TaskID
        {
            get { return fg_TaskID; }
            set { SetPropertyValue<Guid?>("g_TaskID", ref fg_TaskID, value); }
        }

        int? fn_Sequence;
        public int? n_Sequence
        {
            get { return fn_Sequence; }
            set { SetPropertyValue<int?>("n_Sequence", ref fn_Sequence, value); }
        }

        Guid? fg_CheckTaskID;
        public Guid? g_CheckTaskID
        {
            get { return fg_CheckTaskID; }
            set { SetPropertyValue<Guid?>("g_CheckTaskID", ref fg_CheckTaskID, value); }
        }

        string fs_CheckReselt;
        [Size(1)]
        public string s_CheckReselt
        {
            get { return fs_CheckReselt; }
            set { SetPropertyValue<string>("s_CheckReselt", ref fs_CheckReselt, value); }
        }

        string fs_CheckReason;
        [Size(1000)]
        public string s_CheckReason
        {
            get { return fs_CheckReason; }
            set { SetPropertyValue<string>("s_CheckReason", ref fs_CheckReason, value); }
        }

        int? fn_Checker;
        public int? n_Checker
        {
            get { return fn_Checker; }
            set { SetPropertyValue<int?>("n_Checker", ref fn_Checker, value); }
        }

        DateTime? fdt_CheckTime;
        public DateTime? dt_CheckTime
        {
            get { return fdt_CheckTime; }
            set { SetPropertyValue<DateTime?>("dt_CheckTime", ref fdt_CheckTime, value); }
        }

        #region Method
        public TFTask GetTask()
        {
            return TheUow.GetObjectByKey<TFTask>(g_TaskID);
        }
        public TFTask GetCheckTask()
        {
            return TheUow.GetObjectByKey<TFTask>(g_CheckTaskID);
        }
        #endregion

        public TFTaskCheck(Session session) : base(session) { }
    }
}

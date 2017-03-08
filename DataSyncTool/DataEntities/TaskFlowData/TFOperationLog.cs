using System;
using DataEntities.TaskFlowBase;
using DevExpress.Xpo;

namespace DataEntities.TaskFlowData
{
    [Persistent("TF_OperationLog")]
    public class TFOperationLog : XPLiteObjectUser
    {
        Guid fg_ID;
        [Key(true)]
        public Guid g_ID
        {
            get { return fg_ID; }
            set { SetPropertyValue<Guid>("g_ID", ref fg_ID, value); }
        }

        Guid fg_TaskChainGuid;
        [NullValue(typeof(Guid), "00000000-0000-0000-0000-000000000000")]
        public Guid g_TaskChainGuid
        {
            get { return fg_TaskChainGuid; }
            set { SetPropertyValue<Guid>("g_TaskChainGuid", ref fg_TaskChainGuid, value); }
        }

        Guid fg_TaskGuid;
        [NullValue(typeof(Guid), "00000000-0000-0000-0000-000000000000")]
        public Guid g_TaskGuid
        {
            get { return fg_TaskGuid; }
            set { SetPropertyValue<Guid>("g_TaskGuid", ref fg_TaskGuid, value); }
        }

        string fs_CodeNodeCode;
        [Size(21)]
        public string s_CodeNodeCode
        {
            get { return fs_CodeNodeCode; }
            set { SetPropertyValue<string>("s_CodeNodeCode", ref fs_CodeNodeCode, value); }
        }

        string fs_TaskName;
        [Size(100)]
        public string s_TaskName
        {
            get { return fs_TaskName; }
            set { SetPropertyValue<string>("s_TaskName", ref fs_TaskName, value); }
        }

        string fs_OperationType;
        [Size(50)]
        public string s_OperationType
        {
            get { return fs_OperationType; }
            set { SetPropertyValue<string>("s_OperationType", ref fs_OperationType, value); }
        }

        string fs_StateBefore;
        [Size(1)]
        public string s_StateBefore
        {
            get { return fs_StateBefore; }
            set { SetPropertyValue<string>("s_StateBefore", ref fs_StateBefore, value); }
        }

        string fs_StateAfter;
        [Size(1)]
        public string s_StateAfter
        {
            get { return fs_StateAfter; }
            set { SetPropertyValue<string>("s_StateAfter", ref fs_StateAfter, value); }
        }

        string fs_Reason;
        [Size(1000)]
        public string s_Reason
        {
            get { return fs_Reason; }
            set { SetPropertyValue<string>("s_Reason", ref fs_Reason, value); }
        }

        int? fn_Creator;
        public int? n_Creator
        {
            get { return fn_Creator; }
            set { SetPropertyValue<int?>("n_Creator", ref fn_Creator, value); }
        }

        DateTime fdt_CreateTime;
        [NullValue(typeof(DateTime), "0001/1/1 0:00:00")]
        public DateTime dt_CreateTime
        {
            get { return fdt_CreateTime; }
            set { SetPropertyValue<DateTime>("dt_CreateTime", ref fdt_CreateTime, value); }
        }

        public TFOperationLog(Session session) : base(session) { }   
    }

}
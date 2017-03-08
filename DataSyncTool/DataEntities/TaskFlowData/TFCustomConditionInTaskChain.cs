using System;
using DataEntities.TaskFlowBase;
using DevExpress.Xpo;

namespace DataEntities.TaskFlowData
{
    [Persistent("TF_CustomConditionInTaskChain")]
    public class TFCustomConditionInTaskChain : XPLiteObjectUser
    {
        Guid fg_ID;
        [Key(false)]
        public Guid g_ID
        {
            get { return fg_ID; }
            set { SetPropertyValue<Guid>("g_ID", ref fg_ID, value); }
        }

        int fn_CustomConditionID;
        public int n_CustomConditionID
        {
            get { return fn_CustomConditionID; }
            set { SetPropertyValue<int>("n_CustomConditionID", ref fn_CustomConditionID, value); }
        }

        Guid fg_TaskChainID;
        public Guid g_TaskChainID
        {
            get { return fg_TaskChainID; }
            set { SetPropertyValue<Guid>("g_TaskChainID", ref fg_TaskChainID, value); }
        }

        string fs_Values;
        [Size(500)]
        public string s_Values
        {
            get { return fs_Values; }
            set { SetPropertyValue<string>("s_Values", ref fs_Values, value); }
        }

        public TFCustomConditionInTaskChain(Session session) : base(session) { }
    }
}

using System;
using DataEntities.TaskFlowBase;
using DataEntities.TaskFlowConfig;
using DevExpress.Xpo;

namespace DataEntities.TaskFlowData
{
    [Persistent("TF_ActionInTask")]
    public class TFActionInTask : XPLiteObjectUser
    {
        Guid fg_ID;
        [Key(false)]
        public Guid g_ID
        {
            get { return fg_ID; }
            set { SetPropertyValue<Guid>("g_ID", ref fg_ID, value); }
        }

        Guid fg_TaskID;
        public Guid g_TaskID
        {
            get { return fg_TaskID; }
            set { SetPropertyValue<Guid>("g_TaskID", ref fg_TaskID, value); }
        }

        int fn_CodeActionID;
        public int n_CodeActionID
        {
            get { return fn_CodeActionID; }
            set { SetPropertyValue<int>("n_CodeActionID", ref fn_CodeActionID, value); }
        }

        string fs_Name;
        [Size(100)]
        public string s_Name
        {
            get { return fs_Name; }
            set { SetPropertyValue<string>("s_Name", ref fs_Name, value); }
        }

        string fs_ParamIn;
        [Size(50)]
        public string s_ParamIn
        {
            get { return fs_ParamIn; }
            set { SetPropertyValue<string>("s_ParamIn", ref fs_ParamIn, value); }
        }

        int fn_Sequence;
        public int n_Sequence
        {
            get { return fn_Sequence; }
            set { SetPropertyValue<int>("n_Sequence", ref fn_Sequence, value); }
        }

        #region Method
        public TFCodeAction GetCodeAction()
        {
            return TheUow.GetObjectByKey<TFCodeAction>(n_CodeActionID);
        }
        public TFTask GetTask()
        {
            return TheUow.GetObjectByKey<TFTask>(g_TaskID);
        }
        #endregion

        public TFActionInTask(Session session) : base(session) { }
    }
}

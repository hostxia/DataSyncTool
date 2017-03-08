using System;
using DataEntities.TaskFlowBase;
using DataEntities.TaskFlowConfig;
using DevExpress.Xpo;

namespace DataEntities.TaskFlowData
{
    [Persistent("TF_TaskParameter")]
    public class TFTaskParameter : XPLiteObjectUser
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

        Guid? fg_TaskChainID;
        public Guid? g_TaskChainID
        {
            get { return fg_TaskChainID; }
            set { SetPropertyValue<Guid?>("g_TaskChainID", ref fg_TaskChainID, value); }
        }

        int? fn_CodeActionID;
        public int? n_CodeActionID
        {
            get { return fn_CodeActionID; }
            set { SetPropertyValue<int?>("n_CodeActionID", ref fn_CodeActionID, value); }
        }

        string fs_ParaType;
        [Size(100)]
        public string s_ParaType
        {
            get { return fs_ParaType; }
            set { SetPropertyValue<string>("s_ParaType", ref fs_ParaType, value); }
        }

        string fs_ParaValue;
        [Size(1000)]
        public string s_ParaValue
        {
            get { return fs_ParaValue; }
            set { SetPropertyValue<string>("s_ParaValue", ref fs_ParaValue, value); }
        }

        #region Method
        public TFTask GetTask()
        {
            return TheUow.GetObjectByKey<TFTask>(g_TaskID);
        }
        public TFTaskChain GetTaskChain()
        {
            return TheUow.GetObjectByKey<TFTaskChain>(g_TaskChainID);
        }
        public TFCodeAction GetCodeAction()
        {
            return TheUow.GetObjectByKey<TFCodeAction>(n_CodeActionID);
        }
        #endregion

        public TFTaskParameter(Session session) : base(session) { }
    }
}
using System;
using DataEntities.TaskFlowBase;
using DataEntities.TaskFlowConfig;
using DevExpress.Xpo;

namespace DataEntities.TaskFlowData
{
    [Persistent("TF_DemandTypeInTask")]
    public class TFDemandTypeInTask : XPLiteObjectUser
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

        int fn_CodeDemandTypeID;
        public int n_CodeDemandTypeID
        {
            get { return fn_CodeDemandTypeID; }
            set { SetPropertyValue<int>("n_CodeDemandTypeID", ref fn_CodeDemandTypeID, value); }
        }

        #region Method
        public TFCodeDemandType GetCodeAction()
        {
            return TheUow.GetObjectByKey<TFCodeDemandType>(n_CodeDemandTypeID);
        }
        public TFTask GetTask()
        {
            return TheUow.GetObjectByKey<TFTask>(g_TaskID);
        }
        #endregion

        public TFDemandTypeInTask(Session session) : base(session) { }
    }
}

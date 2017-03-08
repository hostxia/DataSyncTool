using System;
using DataEntities.TaskFlowBase;
using DevExpress.Xpo;

namespace DataEntities.TaskFlowConfig
{
    [Persistent("TFCode_DemandTypeInCodeTask")]
    public class TFCodeDemandTypeInCodeTask : XPLiteObjectUser
    {
        int fn_ID;
        [Key(true)]
        public int n_ID
        {
            get { return fn_ID; }
            set { SetPropertyValue<int>("n_ID", ref fn_ID, value); }
        }

        Guid fg_CodeTaskGuid;
        public Guid g_CodeTaskGuid
        {
            get { return fg_CodeTaskGuid; }
            set { SetPropertyValue<Guid>("g_CodeTaskGuid", ref fg_CodeTaskGuid, value); }
        }

        int fn_CodeDemandTypeID;
        public int n_CodeDemandTypeID
        {
            get { return fn_CodeDemandTypeID; }
            set { SetPropertyValue<int>("n_CodeDemandTypeID", ref fn_CodeDemandTypeID, value); }
        }

        #region Method

        public TFCodeDemandType GetTheCodeDemandType()
        {
            return TheUow.GetObjectByKey<TFCodeDemandType>(n_CodeDemandTypeID);
        }

        #endregion

        public TFCodeDemandTypeInCodeTask(Session session) : base(session) { }
    }
}

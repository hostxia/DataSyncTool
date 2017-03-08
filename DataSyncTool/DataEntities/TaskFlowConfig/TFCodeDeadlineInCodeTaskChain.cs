using System;
using DataEntities.TaskFlowBase;
using DevExpress.Xpo;

namespace DataEntities.TaskFlowConfig
{
    [Persistent("TFCode_DeadlineInCodeTaskChain")]
    public class TFCodeDeadlineInCodeTaskChain : XPLiteObjectUser
    {
        Guid fg_ID;
        [Key(false)]
        public Guid g_ID
        {
            get { return fg_ID; }
            set { SetPropertyValue<Guid>("g_ID", ref fg_ID, value); }
        }

        Guid fg_CodeTaskChainGuid;
        public Guid g_CodeTaskChainGuid
        {
            get { return fg_CodeTaskChainGuid; }
            set { SetPropertyValue<Guid>("g_CodeTaskChainGuid", ref fg_CodeTaskChainGuid, value); }
        }

        Guid fg_CodeDeadlineID;
        public Guid g_CodeDeadlineID
        {
            get { return fg_CodeDeadlineID; }
            set { SetPropertyValue<Guid>("g_CodeDeadlineID", ref fg_CodeDeadlineID, value); }
        }

        #region Method

        public TFCodeDeadline GetTheCodeDeadline()
        {
            return TheUow.GetObjectByKey<TFCodeDeadline>(g_CodeDeadlineID);
        }

        public TFCodeTaskChain GetTheCodeTaskChain()
        {
            return TheUow.GetObjectByKey<TFCodeTaskChain>(g_CodeTaskChainGuid);
        }

        #endregion

        public TFCodeDeadlineInCodeTaskChain(Session session) : base(session) { }
    }
}
using System;
using DataEntities.TaskFlowBase;
using DevExpress.Xpo;

namespace DataEntities.TaskFlowConfig
{
    [Persistent("TFCode_DeadlineInCodeTask")]
    public class TFCodeDeadlineInCodeTask : XPLiteObjectUser
    {
        Guid fg_ID;
        [Key(false)]
        public Guid g_ID
        {
            get { return fg_ID; }
            set { SetPropertyValue<Guid>("g_ID", ref fg_ID, value); }
        }

        Guid fg_CodeTaskGuid;
        public Guid g_CodeTaskGuid
        {
            get { return fg_CodeTaskGuid; }
            set { SetPropertyValue<Guid>("g_CodeTaskGuid", ref fg_CodeTaskGuid, value); }
        }

        Guid fg_CodeDeadlineID;
        public Guid g_CodeDeadlineID
        {
            get { return fg_CodeDeadlineID; }
            set { SetPropertyValue<Guid>("g_CodeDeadlineID", ref fg_CodeDeadlineID, value); }
        }

        string fs_UpdateTime;
        [Size(1)]
        public string s_UpdateTime
        {
            get { return fs_UpdateTime; }
            set { SetPropertyValue<string>("s_UpdateTime", ref fs_UpdateTime, value); }
        }

        #region Method

        public TFCodeDeadline GetTheCodeDeadline()
        {
            return TheUow.GetObjectByKey<TFCodeDeadline>(g_CodeDeadlineID);
        }

        #endregion

        public TFCodeDeadlineInCodeTask(Session session) : base(session) { }

        public TFCodeDeadlineInCodeTask(Guid guid) : this(new UnitOfWork())
        {
            g_ID = guid;
        }
    }
}
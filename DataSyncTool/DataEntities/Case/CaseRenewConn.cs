using System;
using DevExpress.Xpo;

namespace DataEntities.Case
{
    [Persistent("TCase_CaseRenewConn")]
    public class CaseRenewConn : XPLiteObject
    {
        public CaseRenewConn(Session session)
            : base(session)
        {
        }

        public CaseRenewConn()
            : base(Session.DefaultSession)
        {
        }

        private int fn_ID;
        [Key(true)]
        public int n_ID
        {
            get { return fn_ID; }
            set { SetPropertyValue<int>("n_ID", ref fn_ID, value); }
        }

        private int fn_OrigCaseID;
        public int n_OrigCaseID
        {
            get { return fn_OrigCaseID; }
            set { SetPropertyValue<int>("n_OrigCaseID", ref fn_OrigCaseID, value); }
        }

        private int fn_NewCaseID;
        public int n_NewCaseID
        {
            get { return fn_NewCaseID; }
            set { SetPropertyValue<int>("n_NewCaseID", ref fn_NewCaseID, value); }
        }

        private Guid fg_TaskGuid;
        public Guid g_TaskGuid
        {
            get { return fg_TaskGuid; }
            set { SetPropertyValue<Guid>("g_TaskGuid", ref fg_TaskGuid, value); }
        }
    }
}

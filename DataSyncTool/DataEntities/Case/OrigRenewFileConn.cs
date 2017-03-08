using System;
using DataEntities.Element.Files;
using DevExpress.Xpo;

namespace DataEntities.Case
{
    [Persistent("TCase_OrigRenewFileConn")]
    public class OrigRenewFileConn : XPLiteObject
    {
        public OrigRenewFileConn(Session session)
            : base(session)
        {
        }

        public OrigRenewFileConn()
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

        private int fn_OrigFileID;
        public int n_OrigFileID
        {
            get { return fn_OrigFileID; }
            set { SetPropertyValue<int>("n_OrigFileID", ref fn_OrigFileID, value); }
        }

        private BaseFile theNewFile;
        [Persistent("n_NewFileID")]
        [Association("FileConn-NewFile", typeof(BaseFile))]
        public BaseFile TheNewFile
        {
            get { return theNewFile; }
            set { SetPropertyValue("n_NewFileID", ref theNewFile, value); }
        }

        private Guid fg_TaskGuid;
        public Guid g_TaskGuid
        {
            get { return fg_TaskGuid; }
            set { SetPropertyValue<Guid>("g_TaskGuid", ref fg_TaskGuid, value); }
        }
    }
}

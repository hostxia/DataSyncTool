using DevExpress.Xpo;

namespace DataEntities.Config
{
    [Persistent("TCode_CaseRelative")]
    public class CodeCaseRelative : XPLiteObject
    {
        private int fn_ID;
        private string fs_IPType;
        private string fs_MasterName;
        private string fs_RelateName;
        private string fs_SlaveName;

        public CodeCaseRelative(Session session)
            : base(session)
        {
        }

        public CodeCaseRelative()
            : base(Session.DefaultSession)
        {
        }

        [Key(true)]
        public int n_ID
        {
            get { return fn_ID; }
            set { SetPropertyValue<int>("n_ID", ref fn_ID, value); }
        }

        public string s_IPType
        {
            get { return fs_IPType; }
            set { SetPropertyValue("s_IPType", ref fs_IPType, value); }
        }

        public string s_RelateName
        {
            get { return fs_RelateName; }
            set { SetPropertyValue("s_RelateName", ref fs_RelateName, value); }
        }

        public string s_MasterName
        {
            get { return fs_MasterName; }
            set { SetPropertyValue("s_MasterName", ref fs_MasterName, value); }
        }

        public string s_SlaveName
        {
            get { return fs_SlaveName; }
            set { SetPropertyValue("s_SlaveName", ref fs_SlaveName, value); }
        }
    }
}
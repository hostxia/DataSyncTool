using DevExpress.Xpo;

namespace DataEntities.Config
{
    [Persistent("TCode_EmailServer")]
    public class CodeEmailServer : XPLiteObject
    {
        private int fn_ID;
        private int fn_Port;
        private string fs_Default;
        private string fs_Email;
        private string fs_Password;

        private string fs_Server;
        private string fs_UserName;

        public CodeEmailServer(Session session) : base(session)
        {
        }

        public CodeEmailServer() : base(Session.DefaultSession)
        {
        }

        [Key(true)]
        public int n_ID
        {
            get { return fn_ID; }
            set { SetPropertyValue<int>("n_ID", ref fn_ID, value); }
        }

        public string s_Server
        {
            get { return fs_Server; }
            set { SetPropertyValue("s_Server", ref fs_Server, value); }
        }

        public string s_Email
        {
            get { return fs_Email; }
            set { SetPropertyValue("s_Email", ref fs_Email, value); }
        }

        public int n_Port
        {
            get { return fn_Port; }
            set { SetPropertyValue<int>("n_Port", ref fn_Port, value); }
        }

        public string s_UserName
        {
            get { return fs_UserName; }
            set { SetPropertyValue("s_UserName", ref fs_UserName, value); }
        }

        public string s_Password
        {
            get { return fs_Password; }
            set { SetPropertyValue("s_Password", ref fs_Password, value); }
        }

        [Size(1)]
        public string s_Default
        {
            get { return fs_Default; }
            set { SetPropertyValue("s_Default", ref fs_Default, value); }
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}
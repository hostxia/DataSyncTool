using DevExpress.Xpo;

namespace DataEntities.Config
{
    [Persistent("TCode_ProxyServer")]
    public class CodeProxyServer : XPLiteObject
    {
        private int fn_ID;
        private string fs_Domain;
        private string fs_IfProxy;
        private string fs_Password;
        private string fs_Portr;

        private string fs_ProxyServer;
        private string fs_UserName;

        public CodeProxyServer(Session session) : base(session)
        {
        }

        public CodeProxyServer() : base(Session.DefaultSession)
        {
        }

        [Key(true)]
        public int n_ID
        {
            get { return fn_ID; }
            set { SetPropertyValue<int>("n_ID", ref fn_ID, value); }
        }

        [Size(50)]
        public string s_ProxyServer
        {
            get { return fs_ProxyServer; }
            set { SetPropertyValue("s_ProxyServer", ref fs_ProxyServer, value); }
        }

        [Size(10)]
        public string s_Port
        {
            get { return fs_Portr; }
            set { SetPropertyValue("s_Port", ref fs_Portr, value); }
        }

        [Size(500)]
        public string s_UserName
        {
            get { return fs_UserName; }
            set { SetPropertyValue("s_UserName", ref fs_UserName, value); }
        }

        [Size(500)]
        public string s_Password
        {
            get { return fs_Password; }
            set { SetPropertyValue("s_Password", ref fs_Password, value); }
        }

        [Size(100)]
        public string s_Domain
        {
            get { return fs_Domain; }
            set { SetPropertyValue("s_Domain", ref fs_Domain, value); }
        }

        [Size(100)]
        public string s_IfProxy
        {
            get { return fs_IfProxy; }
            set { SetPropertyValue("s_IfProxy", ref fs_IfProxy, value); }
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}
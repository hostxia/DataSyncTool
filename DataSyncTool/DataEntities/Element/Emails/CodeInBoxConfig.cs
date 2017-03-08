using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataEntities.Element.Emails
{
    [Persistent("TCode_InBoxConfig")]
    public class CodeInBoxConfig : XPLiteObject
    {
        public CodeInBoxConfig(Session session)
            : base(session)
        {
        }

        private int fn_ID;
        private string fs_Server;
        private string fs_UserName;
        private string fs_Passport;
        private int fn_Port;
        private int fn_Sendee;
        private string fs_Distributor;
        private string fs_DistributorName;

        public CodeInBoxConfig()
            : base(Session.DefaultSession)
        {
        }

        [Key(true)]
        public int n_ID
        {
            get { return fn_ID; }
            set { SetPropertyValue<int>("n_ID", ref fn_ID, value); }
        }

        [Size(100)]
        public string s_Server
        {
            get { return fs_Server; }
            set { SetPropertyValue("s_Server", ref fs_Server, value); }
        }

        [Size(100)]
        public string s_UserName
        {
            get { return fs_UserName; }
            set { SetPropertyValue("s_UserName", ref fs_UserName, value); }
        }

        [Size(100)]
        public string s_Passport
        {
            get { return fs_Passport; }
            set { SetPropertyValue("s_Passport", ref fs_Passport, value); }
        }

        public int n_Port
        {
            get { return fn_Port; }
            set { SetPropertyValue<int>("n_Port", ref fn_Port, value); }
        }

        public int n_Sendee
        {
            get { return fn_Sendee; }
            set { SetPropertyValue<int>("n_Sendee", ref fn_Sendee, value); }
        }

        [Size(500)]
        public string s_Distributor
        {
            get { return fs_Distributor; }
            set { SetPropertyValue("s_Distributor", ref fs_Distributor, value); }
        }

        [Size(500)]
        public string s_DistributorName
        {
            get { return fs_DistributorName; }
            set { SetPropertyValue("s_DistributorName", ref fs_DistributorName, value); }
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}

using DataEntities.Case;
using DataEntities.Contact.Agency;
using DataEntities.Contact.Client;
using DataEntities.Contact.Introducer;
using DevExpress.Xpo;
using Applicant = DataEntities.Contact.Applicant.Applicant;

namespace DataEntities.Config
{
    [Persistent("TCode_SecurityLevelConfig")]
    public class CodeSecurityLevelConfig : XPLiteObject
    {
        private int fn_ID;
        private int fn_SecurityLevel;
        private string fs_Describe;

        private string fs_Name;

        public CodeSecurityLevelConfig(Session session) : base(session)
        {
        }

        public CodeSecurityLevelConfig() : base(Session.DefaultSession)
        {
        }

        [Key(true)]
        public int n_ID
        {
            get { return fn_ID; }
            set { SetPropertyValue<int>("n_ID", ref fn_ID, value); }
        }

        [Size(50)]
        public string s_Name
        {
            get { return fs_Name; }
            set { SetPropertyValue("s_Name", ref fs_Name, value); }
        }

        public int n_SecurityLevel
        {
            get { return fn_SecurityLevel; }
            set { SetPropertyValue<int>("n_SecurityLevel", ref fn_SecurityLevel, value); }
        }

        [Size(500)]
        public string s_Describe
        {
            get { return fs_Describe; }
            set { SetPropertyValue("s_Describe", ref fs_Describe, value); }
        }

        [Aggregated, Association("SecurityLevel-Cases", typeof (BasicCase))]
        public XPCollection Cases
        {
            get { return GetCollection("Cases"); }
        }

        [Aggregated, Association("SecurityLevel-Employees", typeof (CodeEmployee))]
        public XPCollection CodeEmployees
        {
            get { return GetCollection("CodeEmployees"); }
        }

        [Aggregated, Association("SecurityLevel-Clients", typeof (Client))]
        public XPCollection Clients
        {
            get { return GetCollection("Clients"); }
        }

        [Aggregated, Association("SecurityLevel-Introducers", typeof (Introducer))]
        public XPCollection Introducers
        {
            get { return GetCollection("Introducers"); }
        }

        [Aggregated, Association("SecurityLevel-Agencys", typeof (Agency))]
        public XPCollection Agencys
        {
            get { return GetCollection("Agencys"); }
        }

        [Aggregated, Association("SecurityLevel-Applicants", typeof (Applicant))]
        public XPCollection Applicants
        {
            get { return GetCollection("Applicants"); }
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}
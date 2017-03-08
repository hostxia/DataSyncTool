using DevExpress.Xpo;

namespace DataEntities.Case.Patents
{
    [Persistent("TPCase_PCTICountry")]
    public class PCTICountry : XPLiteObject
    {
        private CasePCTI fn_CaseID;

        private int fn_Country;
        private int fn_ID;

        private string fs_Require;

        public PCTICountry(Session session) : base(session)
        {
        }

        public PCTICountry() : base(Session.DefaultSession)
        {
        }

        [Key(true)]
        public int n_ID
        {
            get { return fn_ID; }
            set { SetPropertyValue<int>("n_ID", ref fn_ID, value); }
        }

        [Association("PCTIntl-PCTICountrires")]
        [Persistent("n_CaseID")]
        public CasePCTI ThePatent
        {
            get { return fn_CaseID; }
            set { SetPropertyValue("n_CaseID", ref fn_CaseID, value); }
        }

        public int n_Country
        {
            get { return fn_Country; }
            set { SetPropertyValue<int>("n_Country", ref fn_Country, value); }
        }

        [Size(800)]
        public string s_Require
        {
            get { return fs_Require; }
            set { SetPropertyValue("s_Require", ref fs_Require, value); }
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}
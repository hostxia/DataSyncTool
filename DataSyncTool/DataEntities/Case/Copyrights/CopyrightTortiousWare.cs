using DevExpress.Xpo;

namespace DataEntities.Case.Copyrights
{
    [Persistent("TCCase_TortiousWare")]
    public class CopyrightTortiousWare : XPLiteObject
    {
        private BasicCopyright copyright;
        private int fn_ID;
        private string fs_HSCode;
        private string fs_Note;
        private string fs_WareName;

        public CopyrightTortiousWare(Session session) : base(session)
        {
        }

        public CopyrightTortiousWare() : base(Session.DefaultSession)
        {
        }

        [Key(true)]
        public int n_ID
        {
            get { return fn_ID; }
            set { SetPropertyValue<int>("n_ID", ref fn_ID, value); }
        }

        [Persistent("n_CaseID")]
        [Association("Copyright-TortiousWare")]
        public BasicCopyright Copyright
        {
            get { return copyright; }
            set { SetPropertyValue("n_CaseID", ref copyright, value); }
        }

        [Size(300)]
        public string s_WareName
        {
            get { return fs_WareName; }
            set { SetPropertyValue("s_WareName", ref fs_WareName, value); }
        }

        [Size(30)]
        public string s_HSCode
        {
            get { return fs_HSCode; }
            set { SetPropertyValue("s_HSCode", ref fs_HSCode, value); }
        }

        [Size(600)]
        public string s_Note
        {
            get { return fs_Note; }
            set { SetPropertyValue("s_Note", ref fs_Note, value); }
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}
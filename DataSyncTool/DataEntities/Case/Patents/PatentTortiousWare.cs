using DevExpress.Xpo;

namespace DataEntities.Case.Patents
{
    [Persistent("TPCase_TortiousWare")]
    public class PatentTortiousWare : XPLiteObject
    {
        private int fn_ID;
        private string fs_HSCode;
        private string fs_Note;
        private string fs_WareName;

        private CasePatentCustomMemo patent;

        public PatentTortiousWare(Session session) : base(session)
        {
        }

        public PatentTortiousWare() : base(Session.DefaultSession)
        {
        }

        [Key(true)]
        public int n_ID
        {
            get { return fn_ID; }
            set { SetPropertyValue<int>("n_ID", ref fn_ID, value); }
        }

        [Persistent("n_CaseID")]
        [Association("CustomMemo-Tortious")]
        public CasePatentCustomMemo Patent
        {
            get { return patent; }
            set { SetPropertyValue("n_CaseID", ref patent, value); }
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
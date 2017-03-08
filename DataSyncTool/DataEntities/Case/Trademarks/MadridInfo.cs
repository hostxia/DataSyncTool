using DevExpress.Xpo;

namespace DataEntities.Case.Trademarks
{
    [Persistent("TTCase_MadridInfo")]
    public class MadridInfo : XPLiteObject
    {
        private int fn_ID;

        private int fn_MadAppCaseID;

        private string fs_IsAllCountry;

        private string fs_IsAllGoods;

        private string fs_Notes;
        private ExtendedTrademark trademark;

        public MadridInfo(Session session) : base(session)
        {
        }

        public MadridInfo() : base(Session.DefaultSession)
        {
        }

        [Key(true)]
        public int n_ID
        {
            get { return fn_ID; }
            set { SetPropertyValue<int>("n_ID", ref fn_ID, value); }
        }

        [Association("Trademark-MadridInfo")]
        [Persistent("n_CaseID")]
        public ExtendedTrademark Trademark
        {
            get { return trademark; }
            set { SetPropertyValue("n_CaseID", ref trademark, value); }
        }

        public int n_MadAppCaseID
        {
            get { return fn_MadAppCaseID; }
            set { SetPropertyValue<int>("n_MadAppCaseID", ref fn_MadAppCaseID, value); }
        }

        [Size(1)]
        public string s_IsAllCountry
        {
            get { return fs_IsAllCountry; }
            set { SetPropertyValue("s_IsAllCountry", ref fs_IsAllCountry, value); }
        }

        [Size(1)]
        public string s_IsAllGoods
        {
            get { return fs_IsAllGoods; }
            set { SetPropertyValue("s_IsAllGoods", ref fs_IsAllGoods, value); }
        }

        [Size(800)]
        public string s_Notes
        {
            get { return fs_Notes; }
            set { SetPropertyValue("s_Notes", ref fs_Notes, value); }
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}
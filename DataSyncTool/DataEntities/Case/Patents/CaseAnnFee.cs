using DevExpress.Xpo;

namespace DataEntities.Case.Patents
{
    [MapInheritance(MapInheritanceType.OwnTable)]
    [Persistent("TPCase_AnnFeeInfo")]
    public class CaseAnnFee : ExtendedPatent
    {
        private int fn_AlarmMonths;
        private int fn_DiscYears;
        private int fn_FstPayYear;
        private int fn_LastPayYear;
        private decimal fn_OfficialDiscount;
        private string fs_OfficialDiscStyle;
        private int fn_CountPayYear;

        public CaseAnnFee(Session session) : base(session)
        {
        }

        public CaseAnnFee() : base(Session.DefaultSession)
        {
        }

        [Size(1)]
        public string s_OfficialDiscStyle
        {
            get { return fs_OfficialDiscStyle; }
            set { SetPropertyValue("s_OfficialDiscStyle", ref fs_OfficialDiscStyle, value); }
        }

        public decimal n_OfficialDiscount
        {
            get { return fn_OfficialDiscount; }
            set { SetPropertyValue<decimal>("n_OfficialDiscount", ref fn_OfficialDiscount, value); }
        }

        public int n_DiscYears
        {
            get { return fn_DiscYears; }
            set { SetPropertyValue<int>("n_DiscYears", ref fn_DiscYears, value); }
        }

        public int n_FstPayYear
        {
            get { return fn_FstPayYear; }
            set { SetPropertyValue<int>("dt_FstPayYear", ref fn_FstPayYear, value); }
        }

        public int n_LastPayYear
        {
            get { return fn_LastPayYear; }
            set { SetPropertyValue<int>("dt_LastPayYear", ref fn_LastPayYear, value); }
        }

        public int n_AlarmMonths
        {
            get { return fn_AlarmMonths; }
            set { SetPropertyValue<int>("n_AlarmMonths", ref fn_AlarmMonths, value); }
        }

        public int n_CountPayYear
        {
            get { return fn_CountPayYear; }
            set { SetPropertyValue<int>("n_CountPayYear", ref fn_CountPayYear, value); }
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}
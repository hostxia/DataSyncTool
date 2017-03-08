using DevExpress.Xpo;

namespace DataEntities.Case.Patents
{
    [Persistent("TPCase_AnnFeeStage")]
    public class AnnFeeStage : XPLiteObject
    {
        private int fn_AlarmMonths;
        private int fn_CaseID;
        private int fn_ChargeCurrency;
        private int fn_DiscYears;
        //private decimal fn_FeeDiscount;
        //private decimal fn_FixAFee;
        //private decimal fn_FixFee;
        private int fn_FstPayYear;
        private int fn_ID;
        private int fn_LastPayYear;
        private int fn_OfficialCurrency;
        private decimal fn_OfficialDiscount;
       // private string fs_FeeMode;
        private string fs_Notes;
        private string fs_OfficialDiscStyle;
        private string fs_PayMode;
        private string fs_StatusInit;
        private string fs_StatusOrder;
        private int fn_CountPayYear;

        public AnnFeeStage(Session session) : base(session)
        {
        }

        public AnnFeeStage() : base(Session.DefaultSession)
        {
        }

        [Key(true)]
        public int n_ID
        {
            get { return fn_ID; }
            set { SetPropertyValue<int>("n_ID", ref fn_ID, value); }
        }

        public int n_CaseID
        {
            get { return fn_CaseID; }
            set { SetPropertyValue<int>("n_CaseID", ref fn_CaseID, value); }
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

        public int n_CountPayYear
        {
            get { return fn_CountPayYear; }
            set { SetPropertyValue<int>("n_CountPayYear", ref fn_CountPayYear, value); }
        }

        public int n_FstPayYear
        {
            get { return fn_FstPayYear; }
            set { SetPropertyValue<int>("n_FstPayYear", ref fn_FstPayYear, value); }
        }

        public int n_LastPayYear
        {
            get { return fn_LastPayYear; }
            set { SetPropertyValue<int>("n_LastPayYear", ref fn_LastPayYear, value); }
        }

        public int n_AlarmMonths
        {
            get { return fn_AlarmMonths; }
            set { SetPropertyValue<int>("n_AlarmMonths", ref fn_AlarmMonths, value); }
        }

        [Size(800)]
        public string s_Notes
        {
            get { return fs_Notes; }
            set { SetPropertyValue("s_Notes", ref fs_Notes, value); }
        }

        [Size(2)]
        public string s_PayMode
        {
            get { return fs_PayMode; }
            set { SetPropertyValue("s_PayMode", ref fs_PayMode, value); }
        }

        [Size(10)]
        public string s_StatusOrder
        {
            get { return fs_StatusOrder; }
            set { SetPropertyValue("s_StatusOrder", ref fs_StatusOrder, value); }
        }

        [Size(10)]
        public string s_StatusInit
        {
            get { return fs_StatusInit; }
            set { SetPropertyValue("s_StatusInit", ref fs_StatusInit, value); }
        }

        public int n_ChargeCurrency
        {
            get { return fn_ChargeCurrency; }
            set { SetPropertyValue<int>("n_ChargeCurrency", ref fn_ChargeCurrency, value); }
        }

        public int n_OfficialCurrency
        {
            get { return fn_OfficialCurrency; }
            set { SetPropertyValue<int>("n_OfficialCurrency", ref fn_OfficialCurrency, value); }
        }

        //[Size(1)]
        //public string s_FeeMode
        //{
        //    get { return fs_FeeMode; }
        //    set { SetPropertyValue("s_FeeMode", ref fs_FeeMode, value); }
        //}

        //public decimal n_FeeDiscount
        //{
        //    get { return fn_FeeDiscount; }
        //    set { SetPropertyValue<decimal>("n_FeeDiscount", ref fn_FeeDiscount, value); }
        //}

        //public decimal n_FixAFee
        //{
        //    get { return fn_FixAFee; }
        //    set { SetPropertyValue<decimal>("n_FixAFee", ref fn_FixAFee, value); }
        //}

        //public decimal n_FixFee
        //{
        //    get { return fn_FixFee; }
        //    set { SetPropertyValue<decimal>("n_FixFee", ref fn_FixFee, value); }
        //}

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}
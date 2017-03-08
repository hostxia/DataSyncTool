using System;
using DevExpress.Xpo;

namespace DataEntities.Config
{
    [Persistent("TCode_AnnualFee")]
    public class CodeAnnualFee : XPLiteObject
    {
        private DateTime fdt_CreateDate;
        private DateTime fdt_EditDate;
        private int fn_ID;
        private int fn_Months;
        private int fn_OfficialCurrency;
        private decimal fn_OfficialFee;
        private int fn_PatentType;

        private int fn_RegCountry;
        private decimal fn_YearNo;
        private string fs_InitialDateType;
        private string fs_Notes;

        public CodeAnnualFee(Session session) : base(session)
        {
        }

        public CodeAnnualFee() : base(Session.DefaultSession)
        {
        }

        [Key(true)]
        public int n_ID
        {
            get { return fn_ID; }
            set { SetPropertyValue<int>("n_ID", ref fn_ID, value); }
        }

        public int n_RegCountry
        {
            get { return fn_RegCountry; }
            set { SetPropertyValue<int>("n_RegCountry", ref fn_RegCountry, value); }
        }

        public int n_PatentType
        {
            get { return fn_PatentType; }
            set { SetPropertyValue<int>("n_PatentType", ref fn_PatentType, value); }
        }

        public decimal n_YearNo
        {
            get { return fn_YearNo; }
            set { SetPropertyValue<decimal>("n_YearNo", ref fn_YearNo, value); }
        }

        public string YearNo
        {
            get { return  fn_YearNo.ToString().Replace(".0000", ""); }
        }

        public decimal n_OfficialFee
        {
            get { return fn_OfficialFee; }
            set { SetPropertyValue<decimal>("n_OfficialFee", ref fn_OfficialFee, value); }
        }

        public int n_OfficialCurrency
        {
            get { return fn_OfficialCurrency; }
            set { SetPropertyValue<int>("n_OfficialCurrency", ref fn_OfficialCurrency, value); }
        }

        //string fs_UnitPrice;
        //[Size(1)]
        //public string s_UnitPrice
        //{
        //    get { return fs_UnitPrice; }
        //    set { SetPropertyValue<string>("s_UnitPrice", ref fs_UnitPrice, value); }
        //}
        //string fs_Unit;
        //[Size(50)]
        //public string s_Unit
        //{
        //    get { return fs_Unit; }
        //    set { SetPropertyValue<string>("s_Unit", ref fs_Unit, value); }
        //}
        //int fn_ExceedUnit;
        //public int n_ExceedUnit
        //{
        //    get { return fn_ExceedUnit; }
        //    set { SetPropertyValue<int>("n_ExceedUnit", ref fn_ExceedUnit, value); }
        //}
        //decimal fn_ExceedUnitFee;
        //public decimal n_ExceedUnitFee
        //{
        //    get { return fn_ExceedUnitFee; }
        //    set { SetPropertyValue<decimal>("n_ExceedUnitFee", ref fn_ExceedUnitFee, value); }
        //}

        [Size(1)]
        public string s_InitialDateType
        {
            get { return fs_InitialDateType; }
            set { SetPropertyValue("s_InitialDateType", ref fs_InitialDateType, value); }
        }

        //string fs_DueDateType;
        //[Size(1)]
        //public string s_DueDateType
        //{
        //    get { return fs_DueDateType; }
        //    set { SetPropertyValue<string>("s_DueDateType", ref fs_DueDateType, value); }
        //}

        public int n_Months
        {
            get { return fn_Months; }
            set { SetPropertyValue<int>("n_Months", ref fn_Months, value); }
        }

        [Size(800)]
        public string s_Notes
        {
            get { return fs_Notes; }
            set { SetPropertyValue("s_Notes", ref fs_Notes, value); }
        }

        public DateTime dt_CreateDate
        {
            get { return fdt_CreateDate; }
            set { SetPropertyValue<DateTime>("dt_CreateDate", ref fdt_CreateDate, value); }
        }

        public DateTime dt_EditDate
        {
            get { return fdt_EditDate; }
            set { SetPropertyValue<DateTime>("dt_EditDate", ref fdt_EditDate, value); }
        }

        [Aggregated, Association("AnnualFeeItems", typeof (CodeAnnualFeeItem))]
        public XPCollection AnnualFeeItems
        {
            get { return GetCollection("AnnualFeeItems"); }
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}
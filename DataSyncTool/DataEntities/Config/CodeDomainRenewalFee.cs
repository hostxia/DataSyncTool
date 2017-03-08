using System;
using DevExpress.Xpo;

namespace DataEntities.Config
{
    [Persistent("TCode_DRenewalFee")]
    public class CodeDomainRenewalFee : XPLiteObject
    {
        private DateTime fdt_CreateDate;
        private DateTime fdt_EditDate;
        private int fn_ID;
        private int fn_OfficialCurrency;
        private decimal fn_OfficialFee;

        private int fn_RegCountry;
        private int fn_RenewalYear;
        private string fs_InitialDateType;
        private string fs_Notes;

        public CodeDomainRenewalFee(Session session) : base(session)
        {
        }

        public CodeDomainRenewalFee() : base(Session.DefaultSession)
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

        public int n_RenewalYear
        {
            get { return fn_RenewalYear; }
            set { SetPropertyValue<int>("n_RenewalYear", ref fn_RenewalYear, value); }
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

        [Aggregated, Association("DomainRenewalFeeItems", typeof (CodeDomainRenewalFeeItem))]
        public XPCollection DomainRenewalFeeItems
        {
            get { return GetCollection("DomainRenewalFeeItems"); }
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}
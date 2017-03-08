using System;
using DataEntities.Element.Fee;
using DevExpress.Xpo;

namespace DataEntities.Config
{
    [Persistent("TCode_Fee")]
    public class CodeFee : XPLiteObject
    {
        private DateTime fdt_CreateDate;
        private DateTime fdt_EditDate;
        private int fn_Day;
        private decimal fn_ExceedUnit;
        private decimal fn_EveryUnitCount;
        private decimal fn_ExceedUnitFee;
        private int fn_ID;
        private int fn_Month;
        private int fn_OfficialCurrency;
        private decimal fn_OfficialFee;
        //private int fn_ProcessID;
        private string fs_RegCountry;
       // private string fs_AFeeDisc;
        //private string fs_AutoFee;
        private string fs_AutoFeeType;
        private string fs_TranslationFee;
        private string fs_AutoPayDate;
        //private string fs_Business;
       // private string fs_CodeCameFileID;
        private string fs_DayAndMonthSequence;
        private string fs_FeeRegion;
       // private string fs_IsForElectricOnline;
        private string fs_IsForPayableBill;
        private string fs_IsSystem;

        private string fs_MasterType;
        private string fs_Name;
        private string fs_Notes;
        private string fs_OFeeDisc;
        private string fs_OfficalFlag;
        private string fs_OfficialName;
        private string fs_OtherName;
        private string fs_FeeType;

        private string fs_TApplyType;
        private string fs_TimeType;
        private string fs_Unit;
        private string fs_UnitPrice;

        public CodeFee(Session session) : base(session)
        {
        }

        public CodeFee() : base(Session.DefaultSession)
        {
        }

        [Key(true)]
        public int n_ID
        {
            get { return fn_ID; }
            set { SetPropertyValue<int>("n_ID", ref fn_ID, value); }
        }

        [Size(1)]
        public string s_IPType
        {
            get { return fs_MasterType; }
            set { SetPropertyValue("s_IPType", ref fs_MasterType, value); }
        }

        [Size(1)]
        public string s_TApplyType
        {
            get { return fs_TApplyType; }
            set { SetPropertyValue("s_TApplyType", ref fs_TApplyType, value); }
        }

        [Size(2000)]
        public string s_RegCountry
        {
            get { return fs_RegCountry; }
            set { SetPropertyValue<string>("s_RegCountry", ref fs_RegCountry, value); }
        }

        //[Size(500)]
        //public string s_Business
        //{
        //    get { return fs_Business; }
        //    set { SetPropertyValue("s_Business", ref fs_Business, value); }
        //}

        //[Size(500)]
        //public string s_PTCType
        //{
        //    get { return fs_PTCType; }
        //    set { SetPropertyValue("s_PTCType", ref fs_PTCType, value); }
        //}

        public string s_FeeType
        {
            get { return fs_FeeType; }
            set { SetPropertyValue<string>("s_FeeType", ref fs_FeeType, value); }
        }

        [Size(500)]
        public string s_Name
        {
            get { return fs_Name; }
            set { SetPropertyValue("s_Name", ref fs_Name, value); }
        }

        [Size(500)]
        public string s_OtherName
        {
            get { return fs_OtherName; }
            set { SetPropertyValue("s_OtherName", ref fs_OtherName, value); }
        }

        [Size(500)]
        public string s_OfficialName
        {
            get { return fs_OfficialName; }
            set { SetPropertyValue("s_OfficialName", ref fs_OfficialName, value); }
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

        //[Size(1)]
        //public string s_AFeeDisc
        //{
        //    get { return fs_AFeeDisc; }
        //    set { SetPropertyValue("s_AFeeDisc", ref fs_AFeeDisc, value); }
        //}

        [Size(1)]
        public string s_OFeeDisc
        {
            get { return fs_OFeeDisc; }
            set { SetPropertyValue("s_OFeeDisc", ref fs_OFeeDisc, value); }
        }

        [Size(1)]
        public string s_UnitPrice
        {
            get { return fs_UnitPrice; }
            set { SetPropertyValue("s_UnitPrice", ref fs_UnitPrice, value); }
        }

        [Size(50)]
        public string s_Unit
        {
            get { return fs_Unit; }
            set { SetPropertyValue("s_Unit", ref fs_Unit, value); }
        }

        /// <summary>
        ///     �����ٵ�λ�󣬶���ӷ�
        /// </summary>
        public decimal n_ExceedUnit
        {
            get { return fn_ExceedUnit; }
            set { SetPropertyValue<decimal>("n_ExceedUnit", ref fn_ExceedUnit, value); }
        }
        /// <summary>
        ///     �����ٵ�λ�󣬶���ӷ�
        /// </summary>
        public decimal n_EveryUnitCount
        {
            get { return fn_EveryUnitCount; }
            set { SetPropertyValue<decimal>("n_EveryUnitCount", ref fn_EveryUnitCount, value); }
        }
        /// <summary>
        ///     �������֣�ÿ��λ�ɷѶ���
        /// </summary>
        public decimal n_ExceedUnitFee
        {
            get { return fn_ExceedUnitFee; }
            set { SetPropertyValue<decimal>("n_ExceedUnitFee", ref fn_ExceedUnitFee, value); }
        }

        [Size(800)]
        public string s_Notes
        {
            get { return fs_Notes; }
            set { SetPropertyValue("s_Notes", ref fs_Notes, value); }
        }

        [Size(1)]
        public string s_IsSystem
        {
            get { return fs_IsSystem; }
            set { SetPropertyValue("s_IsSystem", ref fs_IsSystem, value); }
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

        [Aggregated, Association("FeeItems")]
        public XPCollection<CodeFeeItem> FeeItems
        {
            get { return GetCollection<CodeFeeItem>("FeeItems"); }
        }

        [NonPersistent]
        public bool Check { get; set; }

        public decimal AgentFee
        {
            get
            {
                return FeeItems.Count > 0
                    ? ((CodeFeeItem) FeeItems[0]).n_ChargeAFee
                    : 0;
            }
        }


        public decimal CFee
        {
            get
            {
                decimal dValue = 0;
                foreach (CodeFeeItem codeFeeItem in FeeItems)
                {
                    if (codeFeeItem == null) continue;
                    dValue = dValue + codeFeeItem.n_ChargeOFee;
                }
                return dValue;
            }
        }

        //[Size(200)]
        //public string s_CodeCameFileID
        //{
        //    get { return fs_CodeCameFileID; }
        //    set { SetPropertyValue("s_CodeCameFileID", ref fs_CodeCameFileID, value); }
        //}

        [Size(200)]
        public string s_AutoFeeType
        {
            get { return fs_AutoFeeType; }
            set { SetPropertyValue("s_AutoFeeType", ref fs_AutoFeeType, value); }
        }

        public string s_TimeType
        {
            get { return fs_TimeType; }
            set { SetPropertyValue("n_TimeType", ref fs_TimeType, value); }
        }

        public int n_Month
        {
            get { return fn_Month; }
            set { SetPropertyValue<int>("n_Month", ref fn_Month, value); }
        }

        public int n_Day
        {
            get { return fn_Day; }
            set { SetPropertyValue<int>("n_Day", ref fn_Day, value); }
        }

        //[Size(1)]
        //public string s_AutoFee
        //{
        //    get { return fs_AutoFee; }
        //    set { SetPropertyValue("s_AutoFee", ref fs_AutoFee, value); }
        //}
        [Size(1)]
        public string s_TranslationFee
        {
            get { return fs_TranslationFee; }
            set { SetPropertyValue("s_TranslationFee", ref fs_TranslationFee, value); }
        }
        [Size(1)]
        public string s_DayAndMonthSequence
        {
            get { return fs_DayAndMonthSequence; }
            set { SetPropertyValue("s_DayAndMonthSequence", ref fs_DayAndMonthSequence, value); }
        }

        [Size(1)]
        public string s_AutoPayDate
        {
            get { return fs_AutoPayDate; }
            set { SetPropertyValue("s_AutoPayDate", ref fs_AutoPayDate, value); }
        }

        [Size(50)]
        public string s_OfficalFlag
        {
            get { return fs_OfficalFlag; }
            set { SetPropertyValue("s_OfficalFlag", ref fs_OfficalFlag, value); }
        }

        [Size(1)]
        public string s_FeeRegion
        {
            get { return fs_FeeRegion; }
            set { SetPropertyValue("s_FeeRegion", ref fs_FeeRegion, value); }
        }

        //[Size(1)]
        //public string s_IsForElectricOnline
        //{
        //    get { return fs_IsForElectricOnline; }
        //    set { SetPropertyValue("s_IsForElectricOnline", ref fs_IsForElectricOnline, value); }
        //}


        [Size(1)]
        public string s_IsForPayableBill
        {
            get { return fs_IsForPayableBill; }
            set { SetPropertyValue("s_IsForPayableBill", ref fs_IsForPayableBill, value); }
        }
        //[Aggregated, Association("CodeFee-CodeTaskFees")]
        //public XPCollection<OldTFCodeTaskFee> CodeTaskFees
        //{
        //    get { return GetCollection<OldTFCodeTaskFee>("CodeTaskFees"); }
        //}
        //[Aggregated, Association("CodeFee-Fee")]
        //public XPCollection<Fee> Fees
        //{
        //    get { return GetCollection<Fee>("Fees"); }
        //}
        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}
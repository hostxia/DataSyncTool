using System;
using DataEntities.Case;
using DataEntities.Case.DomainNames;
using DataEntities.Case.Patents;
using DataEntities.Case.Trademarks;
using DataEntities.Element.Fee;
using DataEntities.Element.TimeSheet;
using DataEntities.Finance.Accounting;
using DevExpress.Data.Filtering;
using DevExpress.Xpo;

namespace DataEntities.Finance.Bill
{
    [Persistent("T_BillList")]
    public class BillList : XPLiteObject
    {
        private readonly XPDelayedProperty fn_AttrFee = new XPDelayedProperty();
        private readonly XPDelayedProperty fn_OFee = new XPDelayedProperty();
        private readonly XPDelayedProperty fn_OtherFee = new XPDelayedProperty();
        private readonly XPDelayedProperty fn_Sequence = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_FeeName = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_FeeNotes = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_Status = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_Type = new XPDelayedProperty();
        private BasicCase _theCase;
        private Bill bill;
        private DateTime fdt_AppDate = DateTime.MinValue;
        private decimal fn_AttrFeeTaxRate;
        private decimal fn_DisbFeeTaxRate;
        private decimal fn_DiscountAttrFeeRate;
        private decimal fn_DiscountOtherFeeRate;
        private int fn_ID;
        private decimal fn_OrginalAttrFee;
        private decimal fn_OrignalOtherFee;
        private int fn_SourceID;
        private string fs_AppNo = string.Empty;
        private string fs_Applicant = string.Empty;
        private string fs_CaseName = string.Empty;
        private string fs_CaseSerial = string.Empty;

        public BillList(Session session)
            : base(session)
        {
        }

        public BillList()
            : base(Session.DefaultSession)
        {
        }

        [Key(true)]
        public int n_ID
        {
            get { return fn_ID; }
            set { SetPropertyValue<int>("n_ID", ref fn_ID, value); }
        }

        [Persistent("n_BillID")]
        [Association("Bill-BillList")]
        public Bill TheBill
        {
            get { return bill; }
            set { SetPropertyValue("n_BillID", ref bill, value); }
        }

        //int fn_BillID;
        //public int n_BillID
        //{
        //    get { return fn_BillID; }
        //    set { SetPropertyValue<int>("n_BillID", ref fn_BillID, value); }
        //}

        [Delayed("fs_Type")]
        [Size(1)]
        public string s_Type
        {
            get { return (string)fs_Type.Value; }
            set { fs_Type.Value = value; }
        }

        //int fn_FeeCodeID;
        //public int n_FeeCodeID
        //{
        //    get { return fn_FeeCodeID; }
        //    set { SetPropertyValue<int>("n_FeeCodeID", ref fn_FeeCodeID, value); }
        //}

        public int n_SourceID
        {
            get { return fn_SourceID; }
            set { SetPropertyValue<int>("n_SourceID", ref fn_SourceID, value); }
        }

        [Delayed("fn_OFee")]
        public decimal n_OFee
        {
            get
            {
                if (fn_OFee.Value == null)
                {
                    return -1;
                }
                return (decimal)fn_OFee.Value;
            }
            set { fn_OFee.Value = value; }
        }

        [Delayed("fn_AttrFee")]
        public decimal n_AttrFee
        {
            get
            {
                if (fn_AttrFee.Value == null)
                {
                    return -1;
                }
                return (decimal)fn_AttrFee.Value;
            }
            set { fn_AttrFee.Value = value; }
        }

        [Delayed("fn_OtherFee")]
        public decimal n_OtherFee
        {
            get
            {
                if (fn_OtherFee.Value == null)
                {
                    return -1;
                }
                return (decimal)fn_OtherFee.Value;
            }
            set { fn_OtherFee.Value = value; }
        }

        [Delayed("fs_Status")]
        [Size(1)]
        public string s_Status
        {
            get { return (string)fs_Status.Value; }
            set { fs_Status.Value = value; }
        }

        [Delayed("fn_Sequence")]
        public int n_Sequence
        {
            get
            {
                if (fn_Sequence.Value == null)
                {
                    return -1;
                }
                return (int)fn_Sequence.Value;
            }
            set { fn_Sequence.Value = value; }
        }

        [Delayed("fs_FeeName")]
        [Size(200)]
        public string s_FeeName
        {
            get { return (string)fs_FeeName.Value; }
            set { fs_FeeName.Value = value; }
        }

        [Delayed("fs_FeeNotes")]
        [Size(1000)]
        public string s_FeeNotes
        {
            get { return (string)fs_FeeNotes.Value; }
            set { fs_FeeNotes.Value = value; }
        }

        [Delayed, NonPersistent]
        public BasicCase TheCase
        {
            get
            {
                if (_theCase != null)
                {
                    return _theCase;
                }
                return CalcCase();
            }
            set { _theCase = value; }
        }

        [NonPersistent]
        public string s_CaseSerial
        {
            get
            {
                if (fs_CaseSerial != string.Empty)
                {
                    return fs_CaseSerial;
                }
                return CalcCaseSerial();
            }
            set { fs_CaseSerial = value; }
        }

        [NonPersistent]
        public string s_CaseName
        {
            get
            {
                if (fs_CaseName != string.Empty)
                {
                    return fs_CaseName;
                }
                return CalcCaseName();
            }
            set { fs_CaseName = value; }
        }

        [NonPersistent]
        public string s_Applicant
        {
            get
            {
                if (fs_Applicant != string.Empty)
                {
                    return fs_Applicant;
                }
                return CalcApplicant();
            }
            set { fs_Applicant = value; }
        }

        [NonPersistent]
        public string s_AppNo
        {
            get
            {
                if (fs_AppNo != string.Empty)
                {
                    return fs_AppNo;
                }
                return GetAppNo();
            }
            set { fs_AppNo = value; }
        }

        [NonPersistent]
        public DateTime dt_AppDate
        {
            get
            {
                if (fdt_AppDate != DateTime.MinValue)
                {
                    return fdt_AppDate;
                }
                return GetAppDate();
            }
            set { fdt_AppDate = value; }
        }


        [NonPersistent]
        public decimal n_TotalFee
        {
            get
            {
                return
                    Math.Round(
                        ((fn_OFee.Value == null ? 0 : (decimal)fn_OFee.Value) +
                         (fn_AttrFee.Value == null ? 0 : (decimal)fn_AttrFee.Value) +
                         (fn_OtherFee.Value == null ? 0 : (decimal)fn_OtherFee.Value)), 2)
                    + Math.Round(
                        (n_AttrFeeTaxRate == -1 || n_AttrFeeTaxRate == 0
                            ? 0
                            : (n_AttrFee * n_AttrFeeTaxRate / 100)), 2)
                    + Math.Round(
                        (n_DisbFeeTaxRate == -1 || n_DisbFeeTaxRate == 0
                            ? 0
                            : (n_OtherFee * n_DisbFeeTaxRate / 100)), 2);
            }
        }

        //[Aggregated, Association("BillList-Payment")]
        //public XPCollection<Payment> Payments
        //{
        //    get { return GetCollection<Payment>("Payments"); }
        //}

        [Aggregated, Association("BillList-BillListPay")]
        public XPCollection<BillListPay> BillListPayInfo
        {
            get { return GetCollection<BillListPay>("BillListPayInfo"); }
        }

        public decimal n_AttrFeeTaxRate
        {
            get { return fn_AttrFeeTaxRate; }
            set { SetPropertyValue<decimal>("n_AttrFeeTaxRate", ref fn_AttrFeeTaxRate, value); }
        }

        public decimal n_OrginalAttrFee
        {
            get { return fn_OrginalAttrFee; }
            set { SetPropertyValue<decimal>("n_OrginalAttrFee", ref fn_OrginalAttrFee, value); }
        }

        public decimal n_OrignalOtherFee
        {
            get { return fn_OrignalOtherFee; }
            set { SetPropertyValue<decimal>("n_OrignalOtherFee", ref fn_OrignalOtherFee, value); }
        }

        public decimal n_DiscountAttrFeeRate
        {
            get { return fn_DiscountAttrFeeRate; }
            set { SetPropertyValue<decimal>("n_DiscountAttrFeeRate", ref fn_DiscountAttrFeeRate, value); }
        }

        public decimal n_DiscountOtherFeeRate
        {
            get { return fn_DiscountOtherFeeRate; }
            set { SetPropertyValue<decimal>("n_DiscountOtherFeeRate", ref fn_DiscountOtherFeeRate, value); }
        }


        public decimal n_DisbFeeTaxRate
        {
            get { return fn_DisbFeeTaxRate; }
            set { SetPropertyValue<decimal>("n_DisbFeeTaxRate", ref fn_DisbFeeTaxRate, value); }
        }

        /// <summary>
        ///     计算账单项的我方文号
        ///     Coder： Sum(2010-11-3)
        /// </summary>
        /// <returns></returns>
        private string CalcCaseSerial()
        {
            string sCaseSerial = string.Empty;
            if (fn_SourceID == -1 || fn_SourceID == 0)
                return sCaseSerial;
            using (var uow = new UnitOfWork())
            {
                switch (fs_Type.Value.ToString())
                {
                    case "F":
                        var fee = uow.GetObjectByKey<Fee>(fn_SourceID);
                        if (fee != null)
                        {
                            XPCollection<FeeInCase> xpcFeeInCase = fee.FeeInCases;
                            xpcFeeInCase.Filter = CriteriaOperator.Parse("IsMainCase = 'Y'");
                            if (xpcFeeInCase.Count > 0)
                            {
                                var feeInCase =
                                    ((FeeInCase)xpcFeeInCase[0]);
                                if (feeInCase.TheCase != null)
                                    sCaseSerial = feeInCase.TheCase.s_CaseSerial;
                            }
                        }
                        break;
                    case "W":
                        var timeSheet = uow.GetObjectByKey<TimeSheet>(fn_SourceID);
                        if (timeSheet != null)
                        {
                            XPCollection xpcTimeSheetInCases = timeSheet.TimeSheetInCases;
                            xpcTimeSheetInCases.Filter = CriteriaOperator.Parse("IsMainCase = 'Y'");
                            if (xpcTimeSheetInCases.Count > 0)
                            {
                                var timeSheetInCase =
                                    ((TimeSheetInCase)xpcTimeSheetInCases[0]);
                                if (timeSheetInCase.TheCase != null)
                                    sCaseSerial = timeSheetInCase.TheCase.s_CaseSerial;
                            }
                        }
                        break;
                    case "P":
                        var annualFee = uow.GetObjectByKey<AnnualFee>(fn_SourceID);
                        if (annualFee != null && annualFee.TheBasicPatent != null)
                            sCaseSerial = annualFee.TheBasicPatent.s_CaseSerial;
                        break;
                    case "T":
                        var tmRenewalFee = uow.GetObjectByKey<TMRenewalFee>(fn_SourceID);
                        if (tmRenewalFee != null && tmRenewalFee.TheCaseRenewal != null)
                            sCaseSerial = tmRenewalFee.TheCaseRenewal.s_CaseSerial;
                        break;
                    case "D":
                        var dnRenewalFee = uow.GetObjectByKey<DNRenewalFee>(fn_SourceID);
                        if (dnRenewalFee != null && dnRenewalFee.TheBasicDomain != null)
                            sCaseSerial = dnRenewalFee.TheBasicDomain.s_CaseSerial;
                        break;
                }
            }
            return sCaseSerial;
        }

        private string CalcCaseName()
        {
            string sCaseName = string.Empty;
            if (fn_SourceID == -1 || fn_SourceID == 0)
                return sCaseName;
            using (var uow = new UnitOfWork())
            {
                switch (fs_Type.Value.ToString())
                {
                    case "F":
                        var fee = uow.GetObjectByKey<Fee>(fn_SourceID);
                        if (fee != null)
                        {
                            XPCollection<FeeInCase> xpcFeeInCase = fee.FeeInCases;
                            xpcFeeInCase.Filter = CriteriaOperator.Parse("IsMainCase = 'Y'");
                            if (xpcFeeInCase.Count > 0)
                            {
                                var feeInCase =
                                    ((FeeInCase)xpcFeeInCase[0]);
                                if (feeInCase.TheCase != null)
                                    sCaseName = feeInCase.TheCase.s_CaseName;
                            }
                        }
                        break;
                    case "W":
                        var timeSheet = uow.GetObjectByKey<TimeSheet>(fn_SourceID);
                        if (timeSheet != null)
                        {
                            XPCollection xpcTimeSheetInCases = timeSheet.TimeSheetInCases;
                            xpcTimeSheetInCases.Filter = CriteriaOperator.Parse("IsMainCase = 'Y'");
                            if (xpcTimeSheetInCases.Count > 0)
                            {
                                var timeSheetInCase =
                                    ((TimeSheetInCase)xpcTimeSheetInCases[0]);
                                if (timeSheetInCase.TheCase != null)
                                    sCaseName = timeSheetInCase.TheCase.s_CaseName;
                            }
                        }
                        break;
                    case "P":
                        var annualFee = uow.GetObjectByKey<AnnualFee>(fn_SourceID);
                        if (annualFee != null && annualFee.TheBasicPatent != null)
                            sCaseName = annualFee.TheBasicPatent.s_CaseName;
                        break;
                    case "T":
                        var tmRenewalFee = uow.GetObjectByKey<TMRenewalFee>(fn_SourceID);
                        if (tmRenewalFee != null && tmRenewalFee.TheCaseRenewal != null)
                            sCaseName = tmRenewalFee.TheCaseRenewal.s_CaseName;
                        break;
                    case "D":
                        var dnRenewalFee = uow.GetObjectByKey<DNRenewalFee>(fn_SourceID);
                        if (dnRenewalFee != null && dnRenewalFee.TheBasicDomain != null)
                            sCaseName = dnRenewalFee.TheBasicDomain.s_CaseName;
                        break;
                }
            }
            return sCaseName;
        }

        private string CalcApplicant()
        {
            string sApplicant = string.Empty;
            if (fn_SourceID == -1 || fn_SourceID == 0)
                return sApplicant;
            using (var uow = new UnitOfWork())
            {
                switch (fs_Type.Value.ToString())
                {
                    case "F":
                        var fee = uow.GetObjectByKey<Fee>(fn_SourceID);
                        if (fee != null)
                        {
                            XPCollection<FeeInCase> xpcFeeInCase = fee.FeeInCases;
                            xpcFeeInCase.Filter = CriteriaOperator.Parse("IsMainCase = 'Y'");
                            if (xpcFeeInCase.Count > 0)
                            {
                                var feeInCase =
                                    ((FeeInCase)xpcFeeInCase[0]);
                                if (feeInCase.TheCase != null)
                                    sApplicant = feeInCase.TheCase.FstApplicant.s_Name;
                            }
                        }
                        break;
                    case "W":
                        var timeSheet = uow.GetObjectByKey<TimeSheet>(fn_SourceID);
                        if (timeSheet != null)
                        {
                            XPCollection xpcTimeSheetInCases = timeSheet.TimeSheetInCases;
                            xpcTimeSheetInCases.Filter = CriteriaOperator.Parse("IsMainCase = 'Y'");
                            if (xpcTimeSheetInCases.Count > 0)
                            {
                                var timeSheetInCase =
                                    ((TimeSheetInCase)xpcTimeSheetInCases[0]);
                                if (timeSheetInCase.TheCase != null)
                                    sApplicant = timeSheetInCase.TheCase.FstApplicant.s_Name;
                            }
                        }
                        break;
                    case "P":
                        var annualFee = uow.GetObjectByKey<AnnualFee>(fn_SourceID);
                        if (annualFee != null && annualFee.TheBasicPatent != null)
                            sApplicant = annualFee.TheBasicPatent.FstApplicant.s_Name;
                        break;
                    case "T":
                        var tmRenewalFee = uow.GetObjectByKey<TMRenewalFee>(fn_SourceID);
                        if (tmRenewalFee != null && tmRenewalFee.TheCaseRenewal != null)
                            sApplicant = tmRenewalFee.TheCaseRenewal.FstApplicant.s_Name;
                        break;
                    case "D":
                        var dnRenewalFee = uow.GetObjectByKey<DNRenewalFee>(fn_SourceID);
                        if (dnRenewalFee != null && dnRenewalFee.TheBasicDomain != null)
                            sApplicant = dnRenewalFee.TheBasicDomain.FstApplicant.s_Name;
                        break;
                }
            }
            return sApplicant;
        }

        /// <summary>
        ///     计算账单项的我方文号
        ///     Coder： Sum(2010-11-3)
        /// </summary>
        /// <returns></returns>
        private string GetAppNo()
        {
            string sAppNo = string.Empty;
            if (fn_SourceID == -1 || fn_SourceID == 0)
                return sAppNo;
            using (var uow = new UnitOfWork())
            {
                switch (fs_Type.Value.ToString())
                {
                    case "F":
                        var fee = uow.GetObjectByKey<Fee>(fn_SourceID);
                        if (fee != null)
                        {
                            XPCollection<FeeInCase> xpcFeeInCase = fee.FeeInCases;
                            xpcFeeInCase.Filter = CriteriaOperator.Parse("IsMainCase = 'Y'");
                            if (xpcFeeInCase.Count > 0)
                            {
                                var feeInCase =
                                    ((FeeInCase)xpcFeeInCase[0]);
                                var extendedPatent = feeInCase.TheCase as ExtendedPatent;
                                if (extendedPatent != null && extendedPatent.TheLawInfo != null)
                                    sAppNo = extendedPatent.TheLawInfo.s_AppNo;
                                var extendedTrademark = feeInCase.TheCase as ExtendedTrademark;
                                if (extendedTrademark != null && extendedTrademark.TheLawInfo != null)
                                    sAppNo = extendedTrademark.TheLawInfo.s_AppNo;
                            }
                        }
                        break;
                    case "W":
                        var timeSheet = uow.GetObjectByKey<TimeSheet>(fn_SourceID);
                        if (timeSheet != null)
                        {
                            XPCollection xpcTimeSheetInCases = timeSheet.TimeSheetInCases;
                            xpcTimeSheetInCases.Filter = CriteriaOperator.Parse("IsMainCase = 'Y'");
                            if (xpcTimeSheetInCases.Count > 0)
                            {
                                var timeSheetInCase =
                                    ((TimeSheetInCase)xpcTimeSheetInCases[0]);
                                var extendedPatent = timeSheetInCase.TheCase as ExtendedPatent;
                                if (extendedPatent != null && extendedPatent.TheLawInfo != null)
                                    sAppNo = extendedPatent.TheLawInfo.s_AppNo;
                                var extendedTrademark = timeSheetInCase.TheCase as ExtendedTrademark;
                                if (extendedTrademark != null && extendedTrademark.TheLawInfo != null)
                                    sAppNo = extendedTrademark.TheLawInfo.s_AppNo;
                            }
                        }
                        break;
                    case "P":
                        var annualFee = uow.GetObjectByKey<AnnualFee>(fn_SourceID);
                        if (annualFee != null && annualFee.TheBasicPatent != null &&
                            annualFee.TheBasicPatent.TheLawInfo != null)
                            sAppNo = annualFee.TheBasicPatent.TheLawInfo.s_AppNo;
                        break;
                    case "T":
                        var tmRenewalFee = uow.GetObjectByKey<TMRenewalFee>(fn_SourceID);
                        if (tmRenewalFee != null && tmRenewalFee.TheCaseRenewal != null &&
                            tmRenewalFee.TheCaseRenewal.TheLawInfo != null)
                            sAppNo = tmRenewalFee.TheCaseRenewal.TheLawInfo.s_AppNo;
                        break;
                    case "D":
                        var dnRenewalFee = uow.GetObjectByKey<DNRenewalFee>(fn_SourceID);
                        if (dnRenewalFee != null && dnRenewalFee.TheBasicDomain != null)
                            sAppNo = string.Empty;
                        break;
                }
            }
            return sAppNo;
        }

        private DateTime GetAppDate()
        {
            DateTime dtAppDate = DateTime.MinValue;
            if (fn_SourceID == -1 || fn_SourceID == 0)
                return dtAppDate;
            using (var uow = new UnitOfWork())
            {
                switch (fs_Type.Value.ToString())
                {
                    case "F":
                        var fee = uow.GetObjectByKey<Fee>(fn_SourceID);
                        if (fee != null)
                        {
                            XPCollection<FeeInCase> xpcFeeInCase = fee.FeeInCases;
                            xpcFeeInCase.Filter = CriteriaOperator.Parse("IsMainCase = 'Y'");
                            if (xpcFeeInCase.Count > 0)
                            {
                                var feeInCase =
                                    ((FeeInCase)xpcFeeInCase[0]);
                                var extendedPatent = feeInCase.TheCase as ExtendedPatent;
                                if (extendedPatent != null && extendedPatent.TheLawInfo != null)
                                    dtAppDate = extendedPatent.TheLawInfo.dt_AppDate;
                                var extendedTrademark = feeInCase.TheCase as ExtendedTrademark;
                                if (extendedTrademark != null && extendedTrademark.TheLawInfo != null)
                                    dtAppDate = extendedTrademark.TheLawInfo.dt_AppDate;
                            }
                        }
                        break;
                    case "W":
                        var timeSheet = uow.GetObjectByKey<TimeSheet>(fn_SourceID);
                        if (timeSheet != null)
                        {
                            XPCollection xpcTimeSheetInCases = timeSheet.TimeSheetInCases;
                            xpcTimeSheetInCases.Filter = CriteriaOperator.Parse("IsMainCase = 'Y'");
                            if (xpcTimeSheetInCases.Count > 0)
                            {
                                var timeSheetInCase =
                                    ((TimeSheetInCase)xpcTimeSheetInCases[0]);
                                var extendedPatent = timeSheetInCase.TheCase as ExtendedPatent;
                                if (extendedPatent != null && extendedPatent.TheLawInfo != null)
                                    dtAppDate = extendedPatent.TheLawInfo.dt_AppDate;
                                var extendedTrademark = timeSheetInCase.TheCase as ExtendedTrademark;
                                if (extendedTrademark != null && extendedTrademark.TheLawInfo != null)
                                    dtAppDate = extendedTrademark.TheLawInfo.dt_AppDate;
                            }
                        }
                        break;
                    case "P":
                        var annualFee = uow.GetObjectByKey<AnnualFee>(fn_SourceID);
                        if (annualFee != null && annualFee.TheBasicPatent != null &&
                            annualFee.TheBasicPatent.TheLawInfo != null)
                            dtAppDate = annualFee.TheBasicPatent.TheLawInfo.dt_AppDate;
                        break;
                    case "T":
                        var tmRenewalFee = uow.GetObjectByKey<TMRenewalFee>(fn_SourceID);
                        if (tmRenewalFee != null && tmRenewalFee.TheCaseRenewal != null &&
                            tmRenewalFee.TheCaseRenewal.TheLawInfo != null)
                            dtAppDate = tmRenewalFee.TheCaseRenewal.TheLawInfo.dt_AppDate;
                        break;
                    case "D":
                        var dnRenewalFee = uow.GetObjectByKey<DNRenewalFee>(fn_SourceID);
                        if (dnRenewalFee != null && dnRenewalFee.TheBasicDomain != null)
                            dtAppDate = DateTime.MinValue;
                        break;
                }
            }
            return dtAppDate;
        }

        /// <summary>
        ///     计算账单项的案件
        ///     Coder： Sum(2010-11-3)
        /// </summary>
        /// <returns></returns>
        private BasicCase CalcCase()
        {
            BasicCase _basicCase = null;
            if (fn_SourceID == -1 || fn_SourceID == 0)
                return _basicCase;
            var uow = new UnitOfWork();
            switch (fs_Type.Value.ToString())
            {
                case "F":
                    var fee = uow.GetObjectByKey<Fee>(fn_SourceID);
                    if (fee != null)
                    {
                        XPCollection<FeeInCase> xpcFeeInCase = fee.FeeInCases;
                        xpcFeeInCase.Filter = CriteriaOperator.Parse("IsMainCase = 'Y'");
                        if (xpcFeeInCase.Count > 0)
                        {
                            var feeInCase =
                                ((FeeInCase)xpcFeeInCase[0]);
                            if (feeInCase.TheCase != null)
                                _basicCase = feeInCase.TheCase;
                        }
                    }
                    break;
                case "W":
                    var timeSheet = uow.GetObjectByKey<TimeSheet>(fn_SourceID);
                    if (timeSheet != null)
                    {
                        XPCollection xpcTimeSheetInCases = timeSheet.TimeSheetInCases;
                        xpcTimeSheetInCases.Filter = CriteriaOperator.Parse("IsMainCase = 'Y'");
                        if (xpcTimeSheetInCases.Count > 0)
                        {
                            var timeSheetInCase =
                                ((TimeSheetInCase)xpcTimeSheetInCases[0]);
                            if (timeSheetInCase.TheCase != null)
                                _basicCase = timeSheetInCase.TheCase;
                        }
                    }
                    break;
                case "P":
                    var annualFee = uow.GetObjectByKey<AnnualFee>(fn_SourceID);
                    if (annualFee != null && annualFee.TheBasicPatent != null)
                        _basicCase = annualFee.TheBasicPatent;
                    break;
                case "T":
                    var tmRenewalFee = uow.GetObjectByKey<TMRenewalFee>(fn_SourceID);
                    if (tmRenewalFee != null && tmRenewalFee.TheCaseRenewal != null)
                        _basicCase = tmRenewalFee.TheCaseRenewal;
                    break;
                case "D":
                    var dnRenewalFee = uow.GetObjectByKey<DNRenewalFee>(fn_SourceID);
                    if (dnRenewalFee != null && dnRenewalFee.TheBasicDomain != null)
                        _basicCase = dnRenewalFee.TheBasicDomain;
                    break;
            }
            return _basicCase;
        }

        /// <summary>
        /// 全部申请人英文名称
        /// </summary>
        private string fs_EnApplicants = string.Empty;
        [NonPersistent]
        public string s_EnApplicants
        {
            get
            {
                if (fs_EnApplicants != string.Empty)
                {
                    return fs_EnApplicants;
                }
                else
                {
                    return CalcENApplicants();
                }
            }
            set { fs_EnApplicants = value; }
        }

        private string CalcENApplicants()
        {
            string sApplicant = string.Empty;
            if (fn_SourceID == -1 || fn_SourceID == 0)
                return sApplicant;
            using (UnitOfWork uow = new UnitOfWork())
            {
                switch (fs_Type.Value.ToString())
                {
                    case "F":
                        Fee fee = uow.GetObjectByKey<Fee>(fn_SourceID);
                        if (fee != null)
                        {
                            XPCollection<FeeInCase> xpcFeeInCase = fee.FeeInCases;
                            xpcFeeInCase.Filter = CriteriaOperator.Parse("IsMainCase = 'Y'");
                            if (xpcFeeInCase.Count > 0)
                            {
                                var feeInCase =
                               ((FeeInCase)xpcFeeInCase[0]);
                                if (feeInCase.TheCase != null)
                                    sApplicant = feeInCase.TheCase.s_ApplicantsNativeName;
                            }
                        }
                        break;
                    case "W":
                        TimeSheet timeSheet = uow.GetObjectByKey<TimeSheet>(fn_SourceID);
                        if (timeSheet != null)
                        {
                            XPCollection xpcTimeSheetInCases = timeSheet.TimeSheetInCases;
                            xpcTimeSheetInCases.Filter = CriteriaOperator.Parse("IsMainCase = 'Y'");
                            if (xpcTimeSheetInCases.Count > 0)
                            {
                                TimeSheetInCase timeSheetInCase =
                                     ((TimeSheetInCase)xpcTimeSheetInCases[0]);
                                if (timeSheetInCase.TheCase != null)
                                    sApplicant = timeSheetInCase.TheCase.s_ApplicantsNativeName;
                            }
                        }
                        break;
                    case "P":
                        AnnualFee annualFee = uow.GetObjectByKey<AnnualFee>(fn_SourceID);
                        if (annualFee != null && annualFee.TheBasicPatent != null)
                            sApplicant = annualFee.TheBasicPatent.s_ApplicantsNativeName;
                        break;
                    case "T":
                        TMRenewalFee tmRenewalFee = uow.GetObjectByKey<TMRenewalFee>(fn_SourceID);
                        if (tmRenewalFee != null && tmRenewalFee.TheCaseRenewal != null)
                            sApplicant = tmRenewalFee.TheCaseRenewal.s_ApplicantsNativeName;
                        break;
                    case "D":
                        DNRenewalFee dnRenewalFee = uow.GetObjectByKey<DNRenewalFee>(fn_SourceID);
                        if (dnRenewalFee != null && dnRenewalFee.TheBasicDomain != null)
                            sApplicant = dnRenewalFee.TheBasicDomain.s_ApplicantsNativeName;
                        break;
                }
            }
            return sApplicant;
        }

        int fn_PreferentialPolicyID;
        public int n_PreferentialPolicyID
        {
            get { return fn_PreferentialPolicyID; }
            set { SetPropertyValue<int>("n_PreferentialPolicyID", ref fn_PreferentialPolicyID, value); }
        }
        decimal fn_moreUnitCount;
        public decimal n_moreUnitCount
        {
            get { return fn_moreUnitCount; }
            set { SetPropertyValue<decimal>("n_moreUnitCount", ref fn_moreUnitCount, value); }
        }
        [NonPersistent]
        public bool bCalculate { get; set; }

        [NonPersistent]
        public string s_PolicyName { get; set; }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}
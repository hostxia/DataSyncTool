using System;
using System.Text;
using DataEntities.Case;
using DataEntities.Case.Patents;
using DataEntities.Case.Trademarks;
using DataEntities.Config;
using DataEntities.Element.Files;
using DataEntities.Element.Tasks;
using DataEntities.Finance.Bill;
using DataEntities.Properties;
using DevExpress.Data.Filtering;
using DevExpress.Xpo;

namespace DataEntities.Element.Fee
{
    [Persistent("T_Fee")]
    public class Fee : XPLiteObject
    {
        private DateTime fdt_AppDate;
        private DateTime fdt_AskDate;
        private DateTime fdt_ChargePayDate;
        private DateTime fdt_ChargeShldPayDate;
        private DateTime fdt_CreateDate;
        private DateTime fdt_EditDate;
        private DateTime fdt_OfficialPayDate;
        private DateTime fdt_OfficialShldPayDate;
        private DateTime fdt_PayDate;
        private DateTime fdt_ReceiptDate;
        private int fn_Asker;
        private bool fn_BonusCalced;
        private decimal fn_ChargeAFee;
        private int fn_ChargeCurrency;
        private decimal fn_ChargeOFee;
        private decimal fn_ChargeTFee;
        private int fn_ExchangeCurrency;
        private int fn_ExpenseID;
        private int fn_FBillListID;
        private int fn_FeeCodeID;
        private int fn_FeeID;
        private int fn_MainCaseID;
        private int fn_OfficialCurrency;
        private decimal fn_OfficialDiscount;
        private decimal fn_OfficialFee;
        private int fn_PayFeeListID;
        private int fn_Payer;
        private decimal fn_Rate;
        private int fn_Receipter;
        private int fn_CreatorID;
        private string fs_BonusFeeType;
        private string fs_ChargeFeeName;
        private string fs_ChargeNativeName;
        private string fs_Creator;
        private string fs_Editor;
        private string fs_InvoiceNum;
        private string fs_IsActive;
        
        private string fs_OfficialDiscMark;
        private string fs_OfficialDiscStyle;
        private string fs_OfficialFeeName;
        private string fs_OfficialNativeName;
        private string fs_OfficialReceiptPath;
        private string fs_PayMode;
        private string fs_ProcessMark;
        private string fs_ProcessNote;
        private string fs_ReceiptNo;
        private string fs_Status;
        private string fs_StatusOrder;
        private Decimal fn_moreUnitCount;
        private decimal fn_OriTransLateCount;
        private string fs_feeBeyondItemUnit;
        private decimal fn_ChargeDiscountAFeeRate;
        private decimal fn_OriAgencyFee;
        private string fs_TransLateFeeDiscountType;
        private string fs_CheckStatus;
        private int fn_Checker;
        private DateTime fdt_CheckDate;
        private string fs_Notes;
        private string fs_ElecPayer;
        private string fs_ChargingNotes;
        private string fs_ChargingCheckStatus;
        private int fn_ChargingChecker;
        private DateTime fdt_ChargingCheckDate;

        public Fee(Session session)
            : base(session)
        {
        }

        public Fee()
            : base(Session.DefaultSession)
        {
        }

        [Key(true)]
        public int n_FeeID
        {
            get { return fn_FeeID; }
            set { SetPropertyValue<int>("n_FeeID", ref fn_FeeID, value); }
        }

        public int n_FeeCodeID
        {
            get { return fn_FeeCodeID; }
            set { SetPropertyValue<int>("n_FeeCodeID", ref fn_FeeCodeID, value); }
        }

        public int n_MainCaseID
        {
            get { return fn_MainCaseID; }
            set { SetPropertyValue<int>("n_MainCaseID", ref fn_MainCaseID, value); }
        }
        public decimal n_moreUnitCount
        {
            get { return fn_moreUnitCount; }
            set { SetPropertyValue<decimal>("n_moreUnitCount", ref fn_moreUnitCount, value); }
        }
        public decimal n_OriTransLateCount
        {
            get { return fn_OriTransLateCount; }
            set { SetPropertyValue<decimal>("n_OriTransLateCount", ref fn_OriTransLateCount, value); }
        }
        [Size(10)]
        public string s_feeBeyondItemUnit
        {
            get { return fs_feeBeyondItemUnit; }
            set { SetPropertyValue<string>("s_feeBeyondItemUnit", ref fs_feeBeyondItemUnit, value); }
        }
        public string s_TransLateFeeDiscountType
        {
            get { return fs_TransLateFeeDiscountType; }
            set { SetPropertyValue<string>("s_TransLateFeeDiscountType", ref fs_TransLateFeeDiscountType, value); }
        }
        public decimal n_ChargeDiscountAFeeRate
        {
            get { return fn_ChargeDiscountAFeeRate; }
            set { SetPropertyValue<decimal>("n_ChargeDiscountAFeeRate", ref fn_ChargeDiscountAFeeRate, value); }
        }
        //string fs_FeeName;
        //[Size(200)]
        //public string s_FeeName
        //{
        //    get { return fs_FeeName; }
        //    set { SetPropertyValue<string>("s_FeeName", ref fs_FeeName, value); }
        //}

        [Size(500)]
        public string s_ChargeFeeName
        {
            get { return fs_ChargeFeeName; }
            set { SetPropertyValue("s_ChargeFeeName", ref fs_ChargeFeeName, value); }
        }

        [Size(500)]
        public string s_ChargeNativeName
        {
            get { return fs_ChargeNativeName; }
            set { SetPropertyValue("s_ChargeFeeName", ref fs_ChargeNativeName, value); }
        }

        [Size(500)]
        public string s_OfficialFeeName
        {
            get { return fs_OfficialFeeName; }
            set { SetPropertyValue("s_OfficialFeeName", ref fs_OfficialFeeName, value); }
        }

        [Size(500)]
        public string s_OfficialNativeName
        {
            get { return fs_OfficialNativeName; }
            set { SetPropertyValue("s_OfficialNativeName", ref fs_OfficialNativeName, value); }
        }
        
        [Size(50)]
        public string s_Status
        {
            get { return fs_Status; }
            set { SetPropertyValue("s_Status", ref fs_Status, value); }
        }

        [Size(2)]
        public string s_PayMode
        {
            get { return fs_PayMode; }
            set { SetPropertyValue("s_PayMode", ref fs_PayMode, value); }
        }

        [Size(50)]
        public string s_StatusOrder
        {
            get { return fs_StatusOrder; }
            set { SetPropertyValue("s_StatusOrder", ref fs_StatusOrder, value); }
        }

        public int n_ChargeCurrency
        {
            get { return fn_ChargeCurrency; }
            set { SetPropertyValue<int>("n_ChargeCurrency", ref fn_ChargeCurrency, value); }
        }

        public decimal n_ChargeOFee
        {
            get { return fn_ChargeOFee; }
            set { SetPropertyValue<decimal>("n_ChargeOFee", ref fn_ChargeOFee, value); }
        }

        public decimal n_ChargeAFee
        {
            get { return fn_ChargeAFee; }
            set { SetPropertyValue<decimal>("n_ChargeAFee", ref fn_ChargeAFee, value); }
        }
        public decimal n_OriAgencyFee
        {
            get { return fn_OriAgencyFee; }
            set { SetPropertyValue<decimal>("n_OriAgencyFee", ref fn_OriAgencyFee, value); }
        }

        public decimal n_ChargeTFee
        {
            get { return fn_ChargeTFee; }
            set { SetPropertyValue<decimal>("n_ChargeTFee", ref fn_ChargeTFee, value); }
        }

        public DateTime dt_ChargeShldPayDate
        {
            get { return fdt_ChargeShldPayDate; }
            set { SetPropertyValue<DateTime>("dt_ChargeShldPayDate", ref fdt_ChargeShldPayDate, value); }
        }

        public DateTime dt_ChargePayDate
        {
            get { return fdt_ChargePayDate; }
            set { SetPropertyValue<DateTime>("dt_ChargePayDate", ref fdt_ChargePayDate, value); }
        }

        public int n_OfficialCurrency
        {
            get { return fn_OfficialCurrency; }
            set { SetPropertyValue<int>("n_OfficialCurrency", ref fn_OfficialCurrency, value); }
        }

        public decimal n_OfficialFee
        {
            get { return fn_OfficialFee; }
            set { SetPropertyValue<decimal>("n_OfficialFee", ref fn_OfficialFee, value); }
        }

        [Size(1)]
        public string s_OfficialDiscMark
        {
            get { return fs_OfficialDiscMark; }
            set { SetPropertyValue("s_OfficialDiscMark", ref fs_OfficialDiscMark, value); }
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

        public DateTime dt_OfficialShldPayDate
        {
            get { return fdt_OfficialShldPayDate; }
            set { SetPropertyValue<DateTime>("dt_OfficialShldPayDate", ref fdt_OfficialShldPayDate, value); }
        }

        public DateTime dt_OfficialPayDate
        {
            get { return fdt_OfficialPayDate; }
            set { SetPropertyValue<DateTime>("dt_OfficialPayDate", ref fdt_OfficialPayDate, value); }
        }

        [Size(500)]
        public string s_OfficialReceiptPath
        {
            get { return fs_OfficialReceiptPath; }
            set { SetPropertyValue("s_OfficialReceiptPath", ref fs_OfficialReceiptPath, value); }
        }

        public int n_PayFeeListID
        {
            get { return fn_PayFeeListID; }
            set { SetPropertyValue<int>("n_PayFeeListID", ref fn_PayFeeListID, value); }
        }

        [Size(50)]
        public string s_InvoiceNum
        {
            get { return fs_InvoiceNum; }
            set { SetPropertyValue("s_InvoiceNum", ref fs_InvoiceNum, value); }
        }

        public decimal n_Rate
        {
            get { return fn_Rate; }
            set { SetPropertyValue<decimal>("n_Rate", ref fn_Rate, value); }
        }

        [Size(1)]
        public string s_IsActive
        {
            get { return fs_IsActive; }
            set { SetPropertyValue("s_IsActive", ref fs_IsActive, value); }
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

        public int n_CreatorID
        {
            get { return fn_CreatorID; }
            set { SetPropertyValue<int>("n_CreatorID", ref fn_CreatorID, value); }
        }

        [Size(50)]
        public string s_Creator
        {
            get { return fs_Creator; }
            set { SetPropertyValue("s_Creator", ref fs_Creator, value); }
        }

        [Size(50)]
        public string s_Editor
        {
            get { return fs_Editor; }
            set { SetPropertyValue("s_Editor", ref fs_Editor, value); }
        }

        public int n_ExchangeCurrency
        {
            get { return fn_ExchangeCurrency; }
            set { SetPropertyValue<int>("n_ExchangeCurrency", ref fn_ExchangeCurrency, value); }
        }

        //string fs_ContactName;
        //[Size(300)]
        //public string s_ContactName
        //{
        //    get { return fs_ContactName; }
        //    set { SetPropertyValue<string>("s_ContactName", ref fs_ContactName, value); }
        //}

        [Size(10)]
        public string s_ProcessMark
        {
            get { return fs_ProcessMark; }
            set { SetPropertyValue("s_ProcessMark", ref fs_ProcessMark, value); }
        }

        public int n_Asker
        {
            get { return fn_Asker; }
            set { SetPropertyValue<int>("n_Asker", ref fn_Asker, value); }
        }

        public DateTime dt_AskDate
        {
            get { return fdt_AskDate; }
            set { SetPropertyValue<DateTime>("dt_AskDate", ref fdt_AskDate, value); }
        }


        public int n_Payer
        {
            get { return fn_Payer; }
            set { SetPropertyValue<int>("n_Payer", ref fn_Payer, value); }
        }

        public DateTime dt_PayDate
        {
            get { return fdt_PayDate; }
            set { SetPropertyValue<DateTime>("dt_PayDate", ref fdt_PayDate, value); }
        }

        public int n_Receipter
        {
            get { return fn_Receipter; }
            set { SetPropertyValue<int>("n_Receipter", ref fn_Receipter, value); }
        }

        public DateTime dt_ReceiptDate
        {
            get { return fdt_ReceiptDate; }
            set { SetPropertyValue<DateTime>("dt_ReceiptDate", ref fdt_ReceiptDate, value); }
        }

        [Size(200)]
        public string s_ReceiptNo
        {
            get { return fs_ReceiptNo; }
            set { SetPropertyValue("s_ReceiptNo", ref fs_ReceiptNo, value); }
        }

        public DateTime dt_AppDate
        {
            get { return fdt_AppDate; }
            set { SetPropertyValue<DateTime>("dt_AppDate", ref fdt_AppDate, value); }
        }

        [Size(800)]
        public string s_ProcessNote
        {
            get { return fs_ProcessNote; }
            set { SetPropertyValue("s_ProcessNote", ref fs_ProcessNote, value); }
        }

        public bool n_BonusCalced
        {
            get { return fn_BonusCalced; }
            set { SetPropertyValue("n_BonusCalced", ref fn_BonusCalced, value); }
        }

        public int n_ExpenseID
        {
            get { return fn_ExpenseID; }
            set { SetPropertyValue<int>("n_ExpenseID", ref fn_ExpenseID, value); }
        }

        [Size(1)]
        public string s_BonusFeeType
        {
            get { return fs_BonusFeeType; }
            set { SetPropertyValue("s_BonusFeeType", ref fs_BonusFeeType, value); }
        }

        public string s_ElecPayer
        {
            get { return fs_ElecPayer; }
            set { SetPropertyValue("s_ElecPayer", ref fs_ElecPayer, value); }
        }

        private string fs_ReviewStatus;
        [Size(2)]
        public string s_ReviewStatus
        {
            get { return fs_ReviewStatus; }
            set { SetPropertyValue("s_ReviewStatus", ref fs_ReviewStatus, value); }
        }

        private Bill bill;
        [Persistent("n_BillID")]
        [Association("Bill-Fee")]
        public Bill TheBill
        {
            get { return bill; }
            set { SetPropertyValue<Bill>("n_BillID", ref bill, value); }
        }

        [NonPersistent]
        public string s_FeePaymentStatus
        {
            get
            {
                if (string.IsNullOrEmpty(s_Status))
                {
                    return string.Empty;
                }
                return s_Status[2].ToString();
            }
            set
            {
                if (!string.IsNullOrEmpty(s_Status) && value != null)
                {
                    s_Status = s_Status.Substring(0, 2) + value + s_Status.Substring(3);
                }
            }
        }

        public string FeePaymentStatus
        {
            get
            {
                if (s_FeePaymentStatus == "X")
                    return "不缴费";
                if (s_FeePaymentStatus == "N")
                    return "未缴费";
                if (s_FeePaymentStatus == "R")
                    return "已回执";
                if (s_FeePaymentStatus == "F")
                    return "已缴费";
                return "";
            }
        }

        public string FeeReceivedStatus
        {
            get
            {
                if (s_FeeReceivedStatus == "X")
                    return "不到款";
                if (s_FeeReceivedStatus == "N")
                    return "未到款";
                if (s_FeeReceivedStatus == "H")
                    return "准到款";
                if (s_FeeReceivedStatus == "P")
                    return "部分到款";
                if (s_FeeReceivedStatus == "F")
                    return "已到款";
                return "";
            }
        }

        [NonPersistent]
        public string s_FeeReceivedStatus
        {
            get
            {
                if (string.IsNullOrEmpty(s_Status))
                {
                    return string.Empty;
                }
                return s_Status[4].ToString();
            }
            set
            {
                if (!string.IsNullOrEmpty(s_Status) && value != null)
                {
                    s_Status = s_Status.Length == 5 ? s_Status : "NNNNN";
                    s_Status = s_Status.Substring(0, 4) + value;
                }
            }
        }

        [NonPersistent]
        public string s_Billstatus
        {
            get
            {
                if (string.IsNullOrEmpty(s_Status))
                {
                    return string.Empty;
                }
                return s_Status[3].ToString();
            }
            set
            {
                if (!string.IsNullOrEmpty(s_Status) && value != null)
                {
                    s_Status = s_Status.Substring(0, 3) + value + s_Status.Substring(4);
                }
            }
        }

        public string Billstatus
        {
            get
            {
                if (s_Billstatus == "X")
                    return "不发账单";
                if (s_Billstatus == "N")
                    return "未入账单";
                if (s_Billstatus == "F")
                    return "已入账单";
                return "";
            }
        }

        public string IntroducerName
        {
            get
            {
                return TheFirstCase == null || TheFirstCase.TheIntroducer == null ? "" : TheFirstCase.TheIntroducer.Name;
            }
        }

        public BasicCase TheFirstCase
        {
            get
            {
                FeeInCases.Filter = CriteriaOperator.Parse("IsMainCase = 'Y'");
                if (FeeInCases.Count > 0)
                {
                    FeeInCases.Filter = CriteriaOperator.Parse("1 = 1");
                    return ((FeeInCase)FeeInCases[0]).TheCase;
                }
                FeeInCases.Filter = CriteriaOperator.Parse("1 = 1");
                return null;
            }
        }

        /// <summary>
        ///     获取主相关案件的我方文号
        /// </summary>
        public string sMainCaseSerial
        {
            get
            {
                if (FeeInCases.Count >= 1)
                {
                    FeeInCase feeInCase = null;
                    FeeInCases.Filter = CriteriaOperator.Parse("IsMainCase = 'Y'");
                    if (FeeInCases.Count > 0)
                    {
                        feeInCase = (FeeInCase)FeeInCases[0];
                    }
                    FeeInCases.Filter = CriteriaOperator.Parse("1 = 1");
                    if (feeInCase == null) return "";
                    return feeInCase.TheCase.s_CaseSerial;
                }
                return "";
            }
        }

        [Delayed]
        public string FirstAttorney
        {
            get
            {
                if (FeeInCases.Count >= 1)
                {
                    FeeInCase feeInCase = null;
                    FeeInCases.Filter = CriteriaOperator.Parse("IsMainCase = 'Y'");
                    if (FeeInCases.Count > 0)
                    {
                        feeInCase = (FeeInCase)FeeInCases[0];
                    }
                    FeeInCases.Filter = CriteriaOperator.Parse("1 = 1");
                    if (feeInCase == null) return "";
                    using (var tempUow = new UnitOfWork())
                    {
                        var codeEmployee =
                            tempUow.GetObjectByKey<CodeEmployee>(feeInCase.TheCase.n_FirstAttorney);
                        return codeEmployee == null ? "" : codeEmployee.s_Name;
                    }
                }
                return "";
            }
        }

        public Process TheProcess
        {
            get
            {
                //if (FeeInCases.Count > 0)
                //{
                //    return ((FeeInCase)FeeInCases[0]).TheProcess;
                //}
                //else
                //{
                //    return null;
                //}

                if (FeeInCases.Count >= 1)
                {
                    FeeInCase feeInCase = null;
                    FeeInCases.Filter = CriteriaOperator.Parse("IsMainCase = 'Y'");
                    if (FeeInCases.Count > 0)
                    {
                        feeInCase = (FeeInCase)FeeInCases[0];
                    }
                    FeeInCases.Filter = CriteriaOperator.Parse("1 = 1");
                    if (feeInCase == null) return null;
                    if (feeInCase.TheProcess != null)
                    {
                        return feeInCase.TheProcess;
                    }
                }
                return null;
            }
        }

        
        public int n_FBillListID
        {
            get { return fn_FBillListID; }
            set { SetPropertyValue<int>("n_FBillListID", ref fn_FBillListID, value); }
        }

        /// <summary>
        ///     文件的对应的案件的案件名称
        /// </summary>
        public string sCaseName
        {
            get
            {
                //if (FeeInCases.Count >= 1)
                //{
                //    StringBuilder sTmp = new StringBuilder();
                //    FeeInCase feeInCase = (FeeInCase)FeeInCases[0];
                //    sTmp.Append(feeInCase.TheCase.s_CaseName);
                //    if (FeeInCases.Count > 1)
                //    {
                //        sTmp.Append("...");
                //    }
                //    return sTmp.ToString();
                //}
                //else
                //{
                //    return "";
                //}

                if (FeeInCases.Count >= 1)
                {
                    FeeInCase feeInCase = null;
                    FeeInCases.Filter = CriteriaOperator.Parse("IsMainCase = 'Y'");
                    if (FeeInCases.Count > 0)
                    {
                        feeInCase = (FeeInCase)FeeInCases[0];
                    }
                    FeeInCases.Filter = CriteriaOperator.Parse("1 = 1");
                    if (feeInCase == null) return "";
                    var sTmp = new StringBuilder();
                    sTmp.Append(feeInCase.TheCase.s_CaseName);
                    if (FeeInCases.Count > 1)
                    {
                        sTmp.Append("...");
                    }
                    return sTmp.ToString();
                }
                return "";
            }
        }

        /// <summary>
        ///     案件文号
        /// </summary>
        public string sCaseSerials
        {
            get
            {
                //StringBuilder sTmp = new StringBuilder();
                //foreach (FeeInCase feeInCase in FeeInCases)
                //{
                //    sTmp.Append(feeInCase.TheCase.s_CaseSerial);
                //    sTmp.Append(";");
                //}
                //return sTmp.ToString();
                if (FeeInCases.Count >= 1)
                {
                    FeeInCase feeInCase = null;
                    FeeInCases.Filter = CriteriaOperator.Parse("IsMainCase = 'Y'");
                    if (FeeInCases.Count > 0)
                    {
                        feeInCase = (FeeInCase)FeeInCases[0];
                    }
                    FeeInCases.Filter = CriteriaOperator.Parse("1 = 1");
                    if (feeInCase == null) return "";
                    return feeInCase.TheCase.s_CaseSerial;
                }
                return "";
            }
        }

        public string sAppNo
        {
            get
            {
                if (FeeInCases.Count >= 1)
                {
                    FeeInCase feeInCase = null;
                    FeeInCases.Filter = CriteriaOperator.Parse("IsMainCase = 'Y'");
                    if (FeeInCases.Count > 0)
                    {
                        feeInCase = (FeeInCase)FeeInCases[0];
                    }
                    FeeInCases.Filter = CriteriaOperator.Parse("1 = 1");
                    if (feeInCase == null) return "";
                    if ((feeInCase.TheCase as ExtendedPatent) == null) return "";
                    return (feeInCase.TheCase as ExtendedPatent).TheLawInfo.s_AppNo;
                }
                return "";
            }
        }

        [NonPersistent]
        public bool Check { get; set; }

        [NonPersistent]
        public bool IsOfficialFee { get; set; }

        [NonPersistent]
        public string FeeCheckStatus
        {
            get
            {
                if (s_CheckStatus == "A")
                {
                    return "审核通过";
                }
                else if (s_CheckStatus == "D")
                {
                    return "审核未通过";
                }
                return "未审核";
            }
        }

        //此字段只是用于PA导入数据
        [NonPersistent]
        public string PA_FeeID { get; set; }

        [Aggregated, Association("Fee-FeeInCases")]
        public XPCollection<FeeInCase> FeeInCases
        {
            get { return GetCollection<FeeInCase>("FeeInCases"); }
        }

        [Aggregated, Association("Fee-FeeTranslator")]
        public XPCollection<FeeTranslator> FeeTranslators
        {
            get { return GetCollection<FeeTranslator>("FeeTranslators"); }
        }

        [Association("Task-Fee", typeof(Task))]
        public XPCollection Tasks
        {
            get { return GetCollection("Tasks"); }
        }

        [Association("Task-ChargingFee", typeof(Task))]
        public XPCollection ChargingFeeTasks
        {
            get { return GetCollection("ChargingFeeTasks"); }
        }

        [Aggregated, Association("Fee-SubmitListInFee", typeof(SubmitListInFee))]
        public XPCollection SubmitListInFees
        {
            get { return GetCollection("SubmitListInFees"); }
        }

        [Association("Fee-Tasks", typeof(Task))]
        public XPCollection GetTasks
        {
            get { return GetCollection("GetTasks"); }
        }

        [Aggregated, Association("Fee-FeeInWorkItem")]
        public XPCollection<FeeInWorkItem> FeeInWorkItems
        {
            get { return GetCollection<FeeInWorkItem>("FeeInWorkItems"); }
        }

        //private CodeFee ttCodeFee;
        //[Persistent("n_FeeCodeID"), Association("CodeFee-Fee")]
        //public CodeFee TheCodeFee
        //{
        //    get { return ttCodeFee; }
        //    set { SetPropertyValue<CodeFee>("n_FeeCodeID", ref ttCodeFee, value); }
        //}
        public string FeeOrder
        {
            get
            {
                char sValue = string.IsNullOrEmpty(s_PayMode) ? 'M' : s_PayMode[0];
                switch (sValue)
                {
                    case 'A':
                        return Resource.Column_Text_Pay_First;
                    case 'B':
                        return Resource.Column_Text_Charge_First;
                        ;
                    case 'C':
                        return Resource.Column_Text_Client;
                }
                return string.Empty;
            }
        }

        //public new void Save()
        //{
        //    base.Save();
        //    if (TheMainCase != null)
        //    {
        //        if (TheMainCase.ClientContacts.Count == 0) return;
        //        using (UnitOfWork tempUow = new UnitOfWork())
        //        {
        //            s_ContactName = string.Empty;
        //            foreach (ClientContact contact in TheMainCase.ClientContacts)
        //            {
        //                Contacts.Client.ClientContact con =
        //                        tempUow.GetObjectByKey<Contacts.Client.ClientContact>(contact.n_ContactID);
        //                if (con != null)
        //                {
        //                    s_ContactName += con.ContactName + ",";
        //                }
        //            }
        //            s_ContactName = s_ContactName.TrimEnd(',');
        //        }
        //    }
        //    base.Save();
        //}

        public int CaseCount
        {
            get { return FeeInCases.Count; }
        }

        public string RequestStatus
        {
            get { return string.IsNullOrEmpty(s_ProcessMark) ? "" : s_ProcessMark[0].ToString(); }
        }

        public string CheckStatus
        {
            get { return string.IsNullOrEmpty(s_ProcessMark) ? "" : s_ProcessMark[1].ToString(); }
        }

        public string PayStatus
        {
            get { return string.IsNullOrEmpty(s_ProcessMark) ? "" : s_ProcessMark[2].ToString(); }
        }

        [Size(1)]
        public string s_CheckStatus
        {
            get { return (string.IsNullOrEmpty(fs_CheckStatus) || string.Equals(fs_CheckStatus, "0")) ? "U" : fs_CheckStatus; }
            set { SetPropertyValue("s_CheckStatus", ref fs_CheckStatus, value); }
        }

        [Size(1)]
        public string s_ChargingCheckStatus
        {
            get { return (string.IsNullOrEmpty(fs_ChargingCheckStatus) || string.Equals(fs_ChargingCheckStatus, "0")) ? "U" : fs_ChargingCheckStatus; }
            set { SetPropertyValue("s_ChargingCheckStatus", ref fs_ChargingCheckStatus, value); }
        }

        public int n_Checker
        {
            get { return fn_Checker; }
            set { SetPropertyValue<int>("n_Checker", ref fn_Checker, value); }
        }

        public int n_ChargingChecker
        {
            get { return fn_ChargingChecker; }
            set { SetPropertyValue<int>("n_ChargingChecker", ref fn_ChargingChecker, value); }
        }

        public DateTime dt_CheckDate
        {
            get { return fdt_CheckDate; }
            set { SetPropertyValue<DateTime>("dt_CheckDate", ref fdt_CheckDate, value); }
        }

        public DateTime dt_ChargingCheckDate
        {
            get { return fdt_ChargingCheckDate; }
            set { SetPropertyValue<DateTime>("dt_ChargingCheckDate", ref fdt_ChargingCheckDate, value); }
        }

        [Size(800)]
        public string s_Notes
        {
            get { return fs_Notes; }
            set { SetPropertyValue("s_Notes", ref fs_Notes, value); }
        }

        [Size(800)]
        public string s_ChargingNotes
        {
            get { return fs_ChargingNotes; }
            set { SetPropertyValue("s_ChargingNotes", ref fs_ChargingNotes, value); }
        }

        #region 高级查询所用的特殊字段

        /// <summary>
        ///     来文的主案件，高级查询使用
        /// </summary>
        public BasicCase TheMainCase
        {
            get
            {
                foreach (FeeInCase feeInCase in FeeInCases)
                {
                    if (feeInCase == null) continue;
                    if (feeInCase.IsMainCase == "Y") return feeInCase.TheCase;
                }
                return null;
            }
        }

        /// <summary>
        ///     申请号，高级查询使用
        /// </summary>
        public string CaseAppNo
        {
            get
            {
                if ((TheMainCase as ExtendedPatent) != null) return (TheMainCase as ExtendedPatent).TheLawInfo.s_AppNo;
                if ((TheMainCase as ExtendedTrademark) != null)
                    return (TheMainCase as ExtendedTrademark).TheLawInfo.s_AppNo;
                return string.Empty;
            }
        }

        #endregion

        #region 触发器字段

        private int fn_PatentTypeID;
        private string fs_AppNo;
        private string fs_Applicants;
        private string fs_Attorney;
        private string fs_CaseSerial;
        private string fs_ClientContacts;
        private string fs_Introducer;

        [Size(50)]
        public string s_CaseSerial
        {
            get { return fs_CaseSerial; }
            set { SetPropertyValue("s_CaseSerial", ref fs_CaseSerial, value); }
        }

        [Size(50)]
        public string s_AppNo
        {
            get { return fs_AppNo; }
            set { SetPropertyValue("s_AppNo", ref fs_AppNo, value); }
        }

        [Size(1000)]
        public string s_ClientContacts
        {
            get { return fs_ClientContacts; }
            set { SetPropertyValue("s_ClientContacts", ref fs_ClientContacts, value); }
        }

        [Size(1000)]
        public string s_Applicants
        {
            get { return fs_Applicants; }
            set { SetPropertyValue("s_Applicants", ref fs_Applicants, value); }
        }

        [Size(1000)]
        public string s_Introducer
        {
            get { return fs_Introducer; }
            set { SetPropertyValue("s_Introducer", ref fs_Introducer, value); }
        }

        [Size(1000)]
        public string s_Attorney
        {
            get { return fs_Attorney; }
            set { SetPropertyValue("s_Attorney", ref fs_Attorney, value); }
        }

        public int n_PatentTypeID
        {
            get { return fn_PatentTypeID; }
            set { SetPropertyValue<int>("n_PatentTypeID", ref fn_PatentTypeID, value); }
        }

        #endregion

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}
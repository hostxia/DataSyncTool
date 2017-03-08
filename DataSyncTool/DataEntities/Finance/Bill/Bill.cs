using System;
using System.Linq;
using DataEntities.Case.Patents;
using DataEntities.Config;
using DataEntities.Config.Check.Info;
using DataEntities.Contact.Client;
using DataEntities.Element.Fee;
using DataEntities.Element.Tasks;
using DataEntities.Finance.Accounting;
using DataEntities.Finance.ClaimMoney;
using DevExpress.Xpo;

namespace DataEntities.Finance.Bill
{
    [Persistent("T_Bill")]
    public class Bill : XPLiteObject
    {
        private readonly XPDelayedProperty fdt_ConfirmDate = new XPDelayedProperty();
        private readonly XPDelayedProperty fdt_SendOutDate = new XPDelayedProperty();
        private readonly XPDelayedProperty fdt_CreateDate = new XPDelayedProperty();
        private readonly XPDelayedProperty fdt_EditDate = new XPDelayedProperty();
        private readonly XPDelayedProperty fdt_ShldPayDate = new XPDelayedProperty();
        private readonly XPDelayedProperty fn_BillCurrency = new XPDelayedProperty();
        private readonly XPDelayedProperty fn_Country = new XPDelayedProperty();
        private readonly XPDelayedProperty fn_ExchangeCurrency = new XPDelayedProperty();
        private readonly XPDelayedProperty fn_FlowNum = new XPDelayedProperty();
        private readonly XPDelayedProperty fn_InvoiceTemplate = new XPDelayedProperty();
        private readonly XPDelayedProperty fn_Rate = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_AppNo = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_BillNum = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_BillTo = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_BillToName = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_BillType = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_CaseSerial = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_City = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_FilePath = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_InvoiceNum = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_Reason = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_ShowZero = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_State = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_Status = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_Street = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_Email = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_ZipCode = new XPDelayedProperty();
        private Client client;
        private int fn_BillID;
        private int fn_LatestCheckInfoID;
        private string fs_Creator;
        private string fs_Editor;
        private int fn_RemindCount;
        private string fs_CheckStatus;
        private int fn_Checker;
        private DateTime fdt_CheckDate;
        private string fs_Notes;
        private DateTime fdt_RecentRemindDate;

        public Bill(Session session)
            : base(session)
        {
        }

        public Bill()
            : base(Session.DefaultSession)
        {
        }

        [Key(true)]
        public int n_BillID
        {
            get { return fn_BillID; }
            set { SetPropertyValue<int>("n_BillID", ref fn_BillID, value); }
        }

        [Delayed("fs_BillType")]
        [Size(1)]
        public string s_BillType //用12345代表PTDCO
        {
            get { return (string)fs_BillType.Value; }
            set { fs_BillType.Value = value; }
        }

        [Size(50)]
        public string s_InvoiceNum
        {
            get { return (string)fs_InvoiceNum.Value; }
            set { fs_InvoiceNum.Value = value; }
        }

        [Size(50)]
        public string s_CaseSerial
        {
            get { return (string)fs_CaseSerial.Value; }
            set { fs_CaseSerial.Value = value; }
        }

        [Size(100)]
        public string s_AppNo
        {
            get { return (string)fs_AppNo.Value; }
            set { fs_AppNo.Value = value; }
        }

        [Size(1)]
        public string s_CheckStatus
        {
            get { return (string.IsNullOrEmpty(fs_CheckStatus) || string.Equals(fs_CheckStatus, "0")) ? "U" : fs_CheckStatus; }
            set { SetPropertyValue("s_CheckStatus", ref fs_CheckStatus, value); }
        }

        public int n_Checker
        {
            get { return fn_Checker; }
            set { SetPropertyValue<int>("n_Checker", ref fn_Checker, value); }
        }


        public DateTime dt_CheckDate
        {
            get { return fdt_CheckDate; }
            set { SetPropertyValue<DateTime>("dt_CheckDate", ref fdt_CheckDate, value); }
        }

        [Size(800)]
        public string s_Notes
        {
            get { return fs_Notes; }
            set { SetPropertyValue("s_Notes", ref fs_Notes, value); }
        }

        [Delayed("fs_BillNum")]
        [Size(50)]
        public string s_BillNum
        {
            get { return (string)fs_BillNum.Value; }
            set { fs_BillNum.Value = value; }
        }

        [Delayed("fn_FlowNum")]
        public int n_FlowNum
        {
            get
            {
                if (fn_FlowNum.Value == null)
                {
                    return -1;
                }
                return (int)fn_FlowNum.Value;
            }
            set { fn_FlowNum.Value = value; }
        }

        [Delayed("fs_Status")]
        [Size(1)]
        public string s_Status
        {
            get { return (string)fs_Status.Value; }
            set { fs_Status.Value = value; }
        }

        [Delayed("fdt_ShldPayDate")]
        public DateTime dt_ShldPayDate
        {
            get
            {
                if (fdt_ShldPayDate.Value == null)
                {
                    return DateTime.MinValue;
                }
                return (DateTime)fdt_ShldPayDate.Value;
            }
            set { fdt_ShldPayDate.Value = value; }
        }

        [Delayed("fdt_SendOutDate")]
        public DateTime dt_SendOutDate
        {
            get
            {
                if (fdt_SendOutDate.Value == null)
                {
                    return DateTime.MinValue;
                }
                return (DateTime)fdt_SendOutDate.Value;
            }
            set { fdt_SendOutDate.Value = value; }
        }

        [Delayed("fdt_ConfirmDate")]
        public DateTime dt_ConfirmDate
        {
            get
            {
                if (fdt_ConfirmDate.Value == null)
                {
                    return DateTime.MinValue;
                }
                return (DateTime)fdt_ConfirmDate.Value;
            }
            set { fdt_ConfirmDate.Value = value; }
        }

        [Persistent("n_ClientID")]
        [Association("Client-Bills")]
        public Client TheClient
        {
            get { return client; }
            set { SetPropertyValue("n_ClientID", ref client, value); }
        }

        [Delayed("fs_Reason")]
        [Size(800)]
        public string s_Reason
        {
            get { return (string)fs_Reason.Value; }
            set { fs_Reason.Value = value; }
        }

        [Delayed("fs_BillTo")]
        [Size(1)]
        public string s_BillTo
        {
            get { return (string)fs_BillTo.Value; }
            set { fs_BillTo.Value = value; }
        }

        [Delayed("fs_BillToName")]
        [Size(300)]
        public string s_BillToName
        {
            get { return (string)fs_BillToName.Value; }
            set { fs_BillToName.Value = value; }
        }

        [Delayed("fs_Email")]
        [Size(300)]
        public string s_Email
        {
            get { return (string)fs_Email.Value; }
            set { fs_Email.Value = value; }
        }

        [Delayed("fs_Street")]
        [Size(300)]
        public string s_Street
        {
            get { return (string)fs_Street.Value; }
            set { fs_Street.Value = value; }
        }

        [Delayed("fs_City")]
        public string s_City
        {
            get { return (string)fs_City.Value; }
            set { fs_City.Value = value; }
        }

        [Delayed("fs_State")]
        public string s_State
        {
            get { return (string)fs_State.Value; }
            set { fs_State.Value = value; }
        }

        [Delayed("fn_Country")]
        public int n_Country
        {
            get
            {
                if (fn_Country.Value == null)
                {
                    return -1;
                }
                return (int)fn_Country.Value;
            }
            set { fn_Country.Value = value; }
        }

        [Delayed("fs_ZipCode")]
        [Size(50)]
        public string s_ZipCode
        {
            get { return (string)fs_ZipCode.Value; }
            set { fs_ZipCode.Value = value; }
        }

        [Delayed("fs_ShowZero")]
        [Size(50)]
        public string s_ShowZero
        {
            get { return (string)fs_ShowZero.Value; }
            set { fs_ShowZero.Value = value; }
        }

        [Delayed("fn_InvoiceTemplate")]
        public int n_InvoiceTemplate
        {
            get
            {
                if (fn_InvoiceTemplate.Value == null)
                {
                    return -1;
                }
                return (int)fn_InvoiceTemplate.Value;
            }
            set { fn_InvoiceTemplate.Value = value; }
        }

        [Delayed("fn_BillCurrency")]
        public int n_BillCurrency
        {
            get
            {
                if (fn_BillCurrency.Value == null)
                {
                    return -1;
                }
                return (int)fn_BillCurrency.Value;
            }
            set { fn_BillCurrency.Value = value; }
        }

        private XPDelayedProperty fn_BillCurrency2 = new XPDelayedProperty();
        [Delayed("fn_BillCurrency2")]
        public int n_BillCurrency2
        {
            get
            {
                if (fn_BillCurrency2.Value == null)
                {
                    return -1;
                }
                return (int)fn_BillCurrency2.Value;
            }
            set { fn_BillCurrency2.Value = value; }
        }

        private XPDelayedProperty fn_Rate2 = new XPDelayedProperty();
        [Delayed("fn_Rate2")]
        public decimal n_Rate2
        {
            get
            {
                if (fn_Rate2.Value == null)
                {
                    return -1;
                }
                return (decimal)fn_Rate2.Value;
            }
            set { fn_Rate2.Value = value; }
        }

        [Delayed("fn_Rate")]
        public decimal n_Rate
        {
            get
            {
                if (fn_Rate.Value == null)
                {
                    return -1;
                }
                return (decimal)fn_Rate.Value;
            }
            set { fn_Rate.Value = value; }
        }

        [Delayed("fn_ExchangeCurrency")]
        public int n_ExchangeCurrency
        {
            get
            {
                if (fn_ExchangeCurrency.Value == null)
                {
                    return -1;
                }
                return (int)fn_ExchangeCurrency.Value;
            }
            set { fn_ExchangeCurrency.Value = value; }
        }

        [Delayed("fs_FilePath")]
        [Size(500)]
        public string s_FilePath
        {
            get { return (string)fs_FilePath.Value; }
            set { fs_FilePath.Value = value; }
        }

        [Delayed("fdt_CreateDate")]
        public DateTime dt_CreateDate
        {
            get
            {
                if (fdt_CreateDate.Value == null)
                {
                    return DateTime.MinValue;
                }
                return (DateTime)fdt_CreateDate.Value;
            }
            set { fdt_CreateDate.Value = value; }
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

        public int n_RemindCount
        {
            get { return fn_RemindCount; }
            set { SetPropertyValue("n_RemindCount", ref fn_RemindCount, value); }
        }

        public DateTime dt_RecentRemindDate
        {
            get { return fdt_RecentRemindDate; }
            set { SetPropertyValue<DateTime>("dt_RecentRemindDate", ref fdt_RecentRemindDate, value); }
        }

        [Delayed("fdt_EditDate")]
        public DateTime dt_EditDate
        {
            get
            {
                if (fdt_EditDate.Value == null)
                {
                    return DateTime.MinValue;
                }
                return (DateTime)fdt_EditDate.Value;
            }
            set { fdt_EditDate.Value = value; }
        }

        private XPDelayedProperty fdt_BillDate = new XPDelayedProperty();
        [Delayed("fdt_BillDate")]
        public DateTime dt_BillDate
        {
            get
            {
                if (fdt_BillDate.Value == null)
                {
                    return DateTime.MinValue;
                }
                return (DateTime)fdt_BillDate.Value;
            }
            set { fdt_BillDate.Value = value; }
        }
        public int n_LatestCheckInfoID
        {
            get { return fn_LatestCheckInfoID; }
            set { SetPropertyValue<int>("n_LatestCheckInfoID", ref fn_LatestCheckInfoID, value); }
        }

        [NonPersistent]
        public string sFileExtension
        {
            get
            {
                if (s_FilePath == null)
                    return "";
                if (s_FilePath.Substring(s_FilePath.LastIndexOf('.') + 1).ToUpper() == "DOC")
                {
                    return "DOCX";
                }
                return s_FilePath.Substring(s_FilePath.LastIndexOf('.') + 1).ToUpper();
            }
        }

        [Aggregated, Association("Bill-BillChecks")]
        public XPCollection<BillChecks> BillChecks
        {
            get { return GetCollection<BillChecks>("BillChecks"); }
        }

        [Aggregated, Association("Bill-BillList")]
        public XPCollection<BillList> BillList
        {
            get { return GetCollection<BillList>("BillList"); }
        }

        [Aggregated, Association("Bill-BillRemindHistory")]
        public XPCollection<BillRemindHistory> BillRemindHistories
        {
            get { return GetCollection<BillRemindHistory>("BillRemindHistories"); }
        }

        [Aggregated, Association("Bill-Payment")]
        public XPCollection<Payment> Payments
        {
            get { return GetCollection<Payment>("Payments"); }
        }

        [Aggregated, Association("Bill-ClaimMoneyItem")]
        public XPCollection<ClaimMoneyItem> ClaimMoneyItems
        {
            get { return GetCollection<ClaimMoneyItem>("ClaimMoneyItems"); }
        }

        [NonPersistent]
        public int nRemindCount
        {
            get { return BillRemindHistories.Count; }
        }

        [NonPersistent]
        public DateTime dtRecentRemindTime
        {
            get
            {
                return BillRemindHistories.Count > 0
                    ? BillRemindHistories.OrderByDescending(r => r.n_ID).First().dt_RemindTime
                    : DateTime.MinValue;
            }
        }

        [NonPersistent]
        public decimal FeeSum
        {
            get
            {
                decimal feeSum = 0;
                foreach (BillList billListItem in BillList)
                {
                    feeSum = feeSum + billListItem.n_AttrFee + billListItem.n_OFee + billListItem.n_OtherFee;
                }
                return feeSum;
            }
        }


        [NonPersistent]
        public string CaseSerials
        {
            get
            {
                return BillList.Cast<BillList>().Select(t => t.s_CaseSerial).ToList().Distinct().ToList().Aggregate("",
                    (s, t) => s + t + ";").
                    TrimEnd(';');
            }
        }

        [NonPersistent]
        public string sPABillId { get; set; }

        [Association("Bill-Tasks", typeof(Task))]
        public XPCollection GetTasks
        {
            get { return GetCollection("GetTasks"); }
        }

        [Aggregated, Association("Bill-BillPay", typeof(BillPay))]
        public XPCollection BillPays
        {
            get { return GetCollection("BillPays"); }
        }

        [Association("Bill-AnnualFee", typeof(AnnualFee))]
        public XPCollection<AnnualFee> GetAnnualFees
        {
            get { return GetCollection<AnnualFee>("GetAnnualFees"); }
        }


        public decimal BillAccount
        {
            get
            {
                decimal account = 0;
                foreach (BillList billList in BillList)
                {
                    if (billList == null) continue;
                    account += billList.n_TotalFee;
                }
                return account;
            }
        }

        #region 高级查询所用的特殊字段

        /*太慢了，用不了。。。。。。。。。。。*/
        //public string CaseSerial
        //{
        //    get
        //    {
        //        string sSerail = string.Empty;
        //        using (UnitOfWork tempUow = new UnitOfWork())
        //        {
        //            foreach (BillList billList in BillList)
        //            {
        //                if (billList == null) continue;
        //                switch (billList.s_Type)
        //                {
        //                    case "F":
        //                        {
        //                            XPCollection xpc = new XPCollection(tempUow, typeof(Fee.Fee))
        //                                                   {
        //                                                       Criteria = CriteriaOperator.Parse("n_FeeID = ?", billList.n_SourceID)
        //                                                   };
        //                            foreach (Fee.Fee fee in xpc)
        //                            {
        //                                if (fee == null) continue;
        //                                sSerail += fee.TheMainCase.s_CaseSerial + " ";
        //                            }
        //                        }
        //                        break;
        //                    case "W":
        //                        {
        //                            XPCollection xpc = new XPCollection(tempUow, typeof(TimeSheet.TimeSheet))
        //                                                   {
        //                                                       Criteria = CriteriaOperator.Parse("n_TimesheetID = ?", billList.n_SourceID)
        //                                                   };

        //                            foreach (TimeSheet.TimeSheet timeSheet in xpc)
        //                            {
        //                                if (timeSheet == null) continue;
        //                                sSerail += timeSheet.TheMainCase.s_CaseSerial + " ";
        //                            }
        //                        }
        //                        break;
        //                    case "P":
        //                        {
        //                            XPCollection xpc = new XPCollection(tempUow, typeof(AnnualFee))
        //                                                    {
        //                                                        Criteria = CriteriaOperator.Parse("n_AnnualFeeID = ?", billList.n_SourceID)
        //                                                    };
        //                            foreach (AnnualFee annualFee in xpc)
        //                            {
        //                                if (annualFee == null) continue;
        //                                sSerail += annualFee.TheBasicPatent.s_CaseSerial + " ";
        //                            }
        //                        }
        //                        break;
        //                    case "T":
        //                        {
        //                            XPCollection xpc = new XPCollection(tempUow, typeof(TMRenewalFee))
        //                                                   {
        //                                                       Criteria = CriteriaOperator.Parse("n_TRenewalFeeID = ?", billList.n_SourceID)
        //                                                   };
        //                            foreach (TMRenewalFee tmRenewalFee in xpc)
        //                            {
        //                                if (tmRenewalFee == null) continue;
        //                                sSerail += tmRenewalFee.TheCaseRenewal.s_CaseSerial + " ";
        //                            }
        //                        }
        //                        break;
        //                    case "D":
        //                        {
        //                            XPCollection xpc = new XPCollection(tempUow, typeof(DNRenewalFee))
        //                                                   {
        //                                                       Criteria = CriteriaOperator.Parse("n_DRenewalFeeID = ?", billList.n_SourceID)
        //                                                   };
        //                            foreach (DNRenewalFee dnRenewalFee in xpc)
        //                            {
        //                                if (dnRenewalFee == null) continue;
        //                                sSerail += dnRenewalFee.TheBasicDomain.s_CaseSerial + " ";
        //                            }
        //                        }
        //                        break;
        //                }
        //            }
        //        }
        //        return sSerail;
        //    }
        //}

        #endregion

        #region 触发器字段

        private decimal fn_FeeSum;

        public decimal n_FeeSum
        {
            get { return fn_FeeSum; }
            set { SetPropertyValue<decimal>("n_FeeSum", ref fn_FeeSum, value); }
        }

        #endregion

        /// <summary>
        ///  获取国家名称
        ///  XCB(2014-11-27)
        /// </summary>
        public string GetCountryName()
        {
            if (n_Country != 0)
            {
                using (var tempUow = new UnitOfWork())
                {
                    var country = tempUow.GetObjectByKey<CodeCountry>(n_Country);
                    return country == null ? "" : country.s_Name;
                }
            }
            return "";
        }

        /// <summary>
        /// 获取客户名称
        ///  XCB(2014-11-27)
        /// </summary>
        /// <returns></returns>
        public string GetClientName()
        {
            if (client != null)
            {
                return client.s_Name;
            }
            return "";
        }

        int fn_PreferentialCombineID;
        public int n_PreferentialCombineID
        {
            get { return fn_PreferentialCombineID; }
            set { SetPropertyValue<int>("n_PreferentialCombineID", ref fn_PreferentialCombineID, value); }
        }

        [NonPersistent]
        public bool b_Selected { get; set; }

        string fs_Flag;
        [Size(1)]
        public string s_Flag
        {
            get { return fs_Flag; }
            set { SetPropertyValue<string>("s_Flag", ref fs_Flag, value); }
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}
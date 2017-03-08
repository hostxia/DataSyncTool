using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DataEntities.Finance.Bill;
using DevExpress.Xpo;
using DevExpress.Xpo.DB;

namespace DataEntities.Case.Patents
{
    [Persistent("T_AnnualFee")]
    public class AnnualFee : XPLiteObject
    {
        private BasicPatent basicPatent;
        private DateTime fdt_AlarmDate;
        private DateTime fdt_ChargePayDate;
        private DateTime fdt_ChargeShldPayDate;
        private DateTime fdt_CreateDate;
        private DateTime fdt_EditDate;
        private DateTime fdt_OfficialPayDate;
        private DateTime fdt_OfficialShldPayDate;
        private int fn_AnnualFeeID;
        private decimal fn_ChargeAFee;
        private int fn_ChargeCurrency;
        private decimal fn_ChargeOFee;
        private decimal fn_ChargeTFee;
        private int fn_ExchangeCurrency;
        private int fn_OfficialCurrency;
        private decimal fn_OfficialDiscount;
        private decimal fn_OfficialFee;
        private decimal fn_OfficialLateFee;
        private int fn_PayFeeListID;
        private decimal fn_Rate;
        private decimal fn_YearNo;
        private string fs_Active;
        private string fs_Creator;
        private string fs_Editor;
        private string fs_InvoiceNum;
        private string fs_IsOfficialDisc;
        private string fs_Notes;
        private string fs_OfficialDiscStyle;
        private string fs_OfficialReceiptPath;
        private string fs_PayMode;
        private string fs_Priority;
        private string fs_Status;
        private string fs_StatusOrder;
        private string fs_ElecPayer;
        private int fn_AssignAnnualFeeHandler;
        private int fn_AssignBillHandler;
        private int fn_ReportStatus;
        private int fn_FeeApprovalStatus;
        private string fs_BillApprovalStatus;


        private string fs_CheckStatus;
        private int fn_Checker;
        private DateTime fdt_CheckDate;
        private string fs_ApprovalNotes;

        //updated by ck at 20160628
        //增加回执号
        private string fs_ReceiptNo;
        private DateTime fdt_ReceiptDate;

        //updated by ck at 20160701
        //增加年费锁定人
        private int fn_OperatorID;


        public AnnualFee(Session session)
            : base(session)
        {
        }

        public AnnualFee()
            : base(Session.DefaultSession)
        {
        }

        [Key(true)]
        public int n_AnnualFeeID
        {
            get { return fn_AnnualFeeID; }
            set { SetPropertyValue<int>("n_AnnualFeeID", ref fn_AnnualFeeID, value); }
        }

        //int fn_CaseID;
        //public int n_CaseID
        //{
        //    get { return fn_CaseID; }
        //    set { SetPropertyValue<int>("n_CaseID", ref fn_CaseID, value); }
        //}

        [Persistent("n_CaseID")]
        [Association("BasicPatent-AnnualFees")]
        public BasicPatent TheBasicPatent
        {
            get { return basicPatent; }
            set { SetPropertyValue("n_CaseID", ref basicPatent, value); }
        }

        public decimal n_YearNo
        {
            get { return fn_YearNo; }
            set { SetPropertyValue<decimal>("n_YearNo", ref fn_YearNo, value); }
        }

        [Size(10)]
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

        public decimal n_OfficialLateFee
        {
            get { return fn_OfficialLateFee; }
            set { SetPropertyValue<decimal>("n_OfficialLateFee", ref fn_OfficialLateFee, value); }
        }

        [Size(1)]
        public string s_IsOfficialDisc
        {
            get { return fs_IsOfficialDisc; }
            set { SetPropertyValue("s_IsOfficialDisc", ref fs_IsOfficialDisc, value); }
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

        [Size(800)]
        public string s_Notes
        {
            get { return fs_Notes; }
            set { SetPropertyValue("s_Notes", ref fs_Notes, value); }
        }

        public DateTime dt_AlarmDate
        {
            get { return fdt_AlarmDate; }
            set { SetPropertyValue<DateTime>("dt_AlarmDate", ref fdt_AlarmDate, value); }
        }

        public decimal n_Rate
        {
            get { return fn_Rate; }
            set { SetPropertyValue<decimal>("n_Rate", ref fn_Rate, value); }
        }

        [Size(1)]
        public string s_IsActive
        {
            get { return fs_Active; }
            set { SetPropertyValue("s_IsActive", ref fs_Active, value); }
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

        public string s_InvoiceNum
        {
            get { return fs_InvoiceNum; }
            set { SetPropertyValue("s_InvoiceNum", ref fs_InvoiceNum, value); }
        }

        public int n_ExchangeCurrency
        {
            get { return fn_ExchangeCurrency; }
            set { SetPropertyValue<int>("n_ExchangeCurrency", ref fn_ExchangeCurrency, value); }
        }

        public string s_ElecPayer
        {
            get { return fs_ElecPayer; }
            set { SetPropertyValue("s_ElecPayer", ref fs_ElecPayer, value); }
        }

        public int n_AssignAnnualFeeHandler
        {
            get { return fn_AssignAnnualFeeHandler; }
            set { SetPropertyValue<int>("n_AssignAnnualFeeHandler", ref fn_AssignAnnualFeeHandler, value); }
        }

        public int n_AssignBillHandler
        {
            get { return fn_AssignBillHandler; }
            set { SetPropertyValue<int>("n_AssignBillHandler", ref fn_AssignBillHandler, value); }
        }


        public int n_ReportStatus
        {
            get { return fn_ReportStatus; }
            set { SetPropertyValue<int>("n_ReportStatus", ref fn_ReportStatus, value); }
        }

        public int n_FeeApprovalStatus
        {
            get { return fn_FeeApprovalStatus; }
            set { SetPropertyValue<int>("n_FeeApprovalStatus", ref fn_FeeApprovalStatus, value); }
        }

        public string s_BillApprovalStatus
        {
            get { return fs_BillApprovalStatus; }
            set { SetPropertyValue("s_BillApprovalStatus", ref fs_BillApprovalStatus, value); }
        }

        [Size(1)]
        public string s_CheckStatus
        {
            get { return fs_CheckStatus; }
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
        public string s_ApprovalNotes
        {
            get { return fs_ApprovalNotes; }
            set { SetPropertyValue("s_ApprovalNotes", ref fs_ApprovalNotes, value); }
        }

        [Size(200)]
        public string s_ReceiptNo
        {
            get { return fs_ReceiptNo; }
            set { SetPropertyValue("s_ReceiptNo", ref fs_ReceiptNo, value); }
        }

        public DateTime dt_ReceiptDate
        {
            get { return fdt_ReceiptDate; }
            set { SetPropertyValue<DateTime>("dt_ReceiptDate", ref fdt_ReceiptDate, value); }
        }

        public int n_OperatorID
        {
            get { return fn_OperatorID; }
            set { SetPropertyValue<int>("n_OperatorID", ref fn_OperatorID, value); }
        }


        [Size(1)]
        public string s_Priority
        {
            get { return fs_Priority; }
            set { SetPropertyValue("s_Priority", ref fs_Priority, value); }
        }
        private Bill bill;
        [Persistent("n_BillID")]
        [Association("Bill-AnnualFee")]
        public Bill TheBill
        {
            get { return bill; }
            set { SetPropertyValue<Bill>("n_BillID", ref bill, value); }
        }
        [NonPersistent]
        public string s_FeeReceivedStatus // 收费状态
        {
            get { return string.IsNullOrEmpty(s_Status) ? string.Empty : s_Status[4].ToString(); }
            set
            {
                if (!string.IsNullOrEmpty(s_Status) && value != null)
                {
                    s_Status = s_Status.Substring(0, 4) + value;
                }
            }
        }

        [NonPersistent]
        public string s_NotifyStatus // 通知状态
        {
            get { return string.IsNullOrEmpty(s_Status) ? string.Empty : s_Status[0].ToString(); }
            set
            {
                if (!string.IsNullOrEmpty(s_Status) && value != null)
                {
                    s_Status = value + s_Status.Substring(1);
                }
            }
        }

        [NonPersistent]
        public string s_ConfirmStatus // 确认状态
        {
            get { return string.IsNullOrEmpty(s_Status) ? string.Empty : s_Status[1].ToString(); }
            set
            {
                if (!string.IsNullOrEmpty(s_Status) && value != null)
                {
                    s_Status = s_Status.Substring(0, 1) + value + s_Status.Substring(2);
                }
            }
        }

        [NonPersistent]
        public string s_FeePaymentStatus // 缴费状态
        {
            get { return string.IsNullOrEmpty(s_Status) ? string.Empty : s_Status[2].ToString(); }
            set
            {
                if (!string.IsNullOrEmpty(s_Status) && value != null)
                {
                    s_Status = s_Status.Substring(0, 2) + value + s_Status.Substring(3);
                }
            }
        }

        [NonPersistent]
        public string s_Billstatus // 账单状态
        {
            get { return string.IsNullOrEmpty(s_Status) ? string.Empty : s_Status[3].ToString(); }
            set
            {
                if (!string.IsNullOrEmpty(s_Status) && value != null)
                {
                    s_Status = s_Status.Substring(0, 3) + value + s_Status.Substring(4);
                }
            }
        }

        [NonPersistent]
        public string s_FirstCaseAttorney //案件第一处理人
        {
            get
            {
                if (TheBasicPatent.CaseAttorneys.Count == 0) return "";
                TheBasicPatent.CaseAttorneys.Sorting =
                    new SortingCollection(new SortProperty("n_Sequence", SortingDirection.Ascending));
                var caseAttorney = TheBasicPatent.CaseAttorneys[0] as CaseAttorney;
                if (caseAttorney == null) return "";
                return caseAttorney.TheAttorney.s_Name;
            }
        }

        [NonPersistent]
        public string s_FirstInventor //案件第一发明人
        {
            get
            {
                var extendedPatent = TheBasicPatent as ExtendedPatent;
                if (extendedPatent == null) return "";
                Inventor inventor = extendedPatent.Get1stInventor();
                if (inventor == null) return "";
                return inventor.s_Name;
            }
        }

        /// <summary>
        ///     收费的小计
        /// </summary>
        public decimal sChargeTotal
        {
            get { return Math.Round(n_ChargeOFee + n_ChargeAFee + n_ChargeTFee, 2); }
        }

        /// <summary>
        ///     判断文件是是什么类型的文件
        ///     coder:zhangjiechen(2010-09-06)
        /// </summary>
        public string sFile
        {
            get
            {
                if (!string.IsNullOrEmpty(s_OfficialReceiptPath))
                {
                    string sExtension = Path.GetExtension(s_OfficialReceiptPath);
                    if (string.IsNullOrEmpty(sExtension)) return "nofile";
                    string sExtensionWithOutPoint = sExtension.TrimStart('.');
                    switch (sExtensionWithOutPoint.ToLower())
                    {
                        case "doc":
                        case "docx":
                            return "word";
                        case "xls":
                        case "xlsx":
                            return "excel";
                        case "txt":
                            return "txt";
                        case "pdf":
                            return "pdf";
                        case "msg":
                        case "eml":
                            return "mail";
                        default:
                            return "other";
                    }
                }
                return "nofile";
            }
        }

        [NonPersistent]
        public bool Check { get; set; }

        //此字段只是用于PA导入数据
        [NonPersistent]
        public string PA_AnnualFeeID { get; set; }

        #region 撰写年费通知函所用到的临时字段

        /// <summary>
        ///     官费和代理费（合计）
        /// </summary>
        [NonPersistent]
        public decimal nChargeTotal
        {
            get { return Math.Round(n_ChargeOFee + n_ChargeAFee, 2); }
        }

        /// <summary>
        ///     序号
        /// </summary>
        [NonPersistent]
        public int nOrder { get; set; }

        /// <summary>
        ///     回复期限
        /// </summary>
        [NonPersistent]
        public DateTime dtRequestDate { get; set; }

        #endregion

        public string GetYearNo()
        {
            return "第" + Convert.ToInt16(n_YearNo) + "年度";
        }

        public string GetYearNoEN()
        {
            return Convert.ToInt16(n_YearNo) + "th";
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }

        public new void Save()
        {
            if ((TheBasicPatent as CaseAnnFee) == null &&
                TheBasicPatent.AnnualFees.Cast<AnnualFee>().Where(t => t.n_AnnualFeeID > 0).Count() == 0 &&
                n_AnnualFeeID == 0)
            {
                string sFilePath = Application.StartupPath + "\\Config\\DefaultLoadConfig.ini";
                string sSetion = "Language";
                string sKey = "Language";
                string missValue = "zh-CN";
                var sLanguage = new StringBuilder(100);
                //APIFunctions.GetPrivateProfileString(sSetion, sKey, missValue, sLanguage, 100,
                    //sFilePath);
                if (sLanguage.ToString() == string.Empty) sLanguage.Append(missValue);

                TheBasicPatent.s_CaseStatus = sLanguage.ToString() == "zh-CN" ? "已进入年费阶段" : "Annuity Phase";
            }
            base.Save();
        }
    }
}
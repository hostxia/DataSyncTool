using System;
using System.IO;
using DataEntities.Finance.Bill;
using DevExpress.Xpo;

namespace DataEntities.Case.Trademarks
{
    [Persistent("T_TMRenewalFee")]
    public class TMRenewalFee : XPLiteObject
    {
        private BasicTrademark caseRenewal;
        private DateTime fdt_AlarmDate;
        private DateTime fdt_ChargePayDate;
        private DateTime fdt_ChargeShldPayDate;
        private DateTime fdt_Consign;
        private DateTime fdt_CreateDate;
        private DateTime fdt_EditDate;
        private DateTime fdt_Effective;
        private DateTime fdt_End;
        private DateTime fdt_NextRenewal;
        private DateTime fdt_OfficialPayDate;
        private DateTime fdt_OfficialShldPayDate;
        private DateTime fdt_Publish;
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
        private int fn_TRenewalFeeID;
        private string fs_Creator;
        private string fs_Editor;
        private string fs_InvoiceNum;
        private string fs_IsActive;
        private string fs_IsOfficialDisc;
        private string fs_Notes;
        private string fs_OfficialDiscStyle;
        private string fs_OfficialReceiptPath;
        private string fs_PayMode;
        private string fs_PubIssue;
        private string fs_PubNum;
        private string fs_PubVol;
        private string fs_RenewalFilePath;
        private string fs_RenewalStatus;
        private string fs_Status;
        private string fs_StatusOrder;

        public TMRenewalFee(Session session) : base(session)
        {
        }

        public TMRenewalFee() : base(Session.DefaultSession)
        {
        }

        [Key(true)]
        public int n_TRenewalFeeID
        {
            get { return fn_TRenewalFeeID; }
            set { SetPropertyValue<int>("n_TRenewalFeeID", ref fn_TRenewalFeeID, value); }
        }

        //int fn_CaseID;
        //public int n_CaseID
        //{
        //    get { return fn_CaseID; }
        //    set { SetPropertyValue<int>("n_CaseID", ref fn_CaseID, value); }
        //}

        [Persistent("n_CaseID")]
        [Association("ExtendedTrademark-TMRenewalFee")]
        public BasicTrademark TheCaseRenewal
        {
            get { return caseRenewal; }
            set { SetPropertyValue("n_CaseID", ref caseRenewal, value); }
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

        [Size(50)]
        public string s_InvoiceNum
        {
            get { return fs_InvoiceNum; }
            set { SetPropertyValue("s_InvoiceNum", ref fs_InvoiceNum, value); }
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

        public DateTime dt_Consign
        {
            get { return fdt_Consign; }
            set { SetPropertyValue<DateTime>("dt_Consign", ref fdt_Consign, value); }
        }

        public DateTime dt_Publish
        {
            get { return fdt_Publish; }
            set { SetPropertyValue<DateTime>("dt_Publish", ref fdt_Publish, value); }
        }

        [Size(50)]
        public string s_PubIssue
        {
            get { return fs_PubIssue; }
            set { SetPropertyValue("s_PubIssue", ref fs_PubIssue, value); }
        }

        [Size(50)]
        public string s_PubNum
        {
            get { return fs_PubNum; }
            set { SetPropertyValue("s_PubNum", ref fs_PubNum, value); }
        }

        [Size(50)]
        public string s_PubVol
        {
            get { return fs_PubVol; }
            set { SetPropertyValue("s_PubVol", ref fs_PubVol, value); }
        }

        [Size(500)]
        public string s_RenewalFilePath
        {
            get { return fs_RenewalFilePath; }
            set { SetPropertyValue("s_RenewalFilePath", ref fs_RenewalFilePath, value); }
        }

        public DateTime dt_Effective
        {
            get { return fdt_Effective; }
            set { SetPropertyValue<DateTime>("dt_Effective", ref fdt_Effective, value); }
        }

        public DateTime dt_End
        {
            get { return fdt_End; }
            set { SetPropertyValue<DateTime>("dt_End", ref fdt_End, value); }
        }

        public DateTime dt_NextRenewal
        {
            get { return fdt_NextRenewal; }
            set { SetPropertyValue<DateTime>("dt_NextRenewal", ref fdt_NextRenewal, value); }
        }

        [Size(50)]
        public string s_RenewalStatus
        {
            get { return fs_RenewalStatus; }
            set { SetPropertyValue("s_RenewalStatus", ref fs_RenewalStatus, value); }
        }

        public int n_ExchangeCurrency
        {
            get { return fn_ExchangeCurrency; }
            set { SetPropertyValue<int>("n_ExchangeCurrency", ref fn_ExchangeCurrency, value); }
        }
        private Bill bill;
        [Persistent("n_BillID")]
        [Association("Bill-TMRenewalFee")]
        public Bill TheBill
        {
            get { return bill; }
            set { SetPropertyValue<Bill>("n_BillID", ref bill, value); }
        }
        [NonPersistent]
        public string s_NotifyStatus // ֪ͨ״̬
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
        public string s_FeeReceivedStatus // �շ�״̬
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
        public string s_FeePaymentStatus // �ɷ�״̬
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
        public string s_Billstatus // �˵�״̬
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

        /// <summary>
        ///     �շѵ�С��
        /// </summary>
        public decimal sChargeTotal
        {
            get { return Math.Round(n_ChargeOFee + n_ChargeAFee + n_ChargeTFee, 2); }
        }

        /// <summary>
        ///     �ٷѺʹ���ѣ��ϼƣ�
        /// </summary>
        [NonPersistent]
        public decimal nChargeTotal
        {
            get { return Math.Round(n_ChargeOFee + n_ChargeAFee, 2); }
        }

        /// <summary>
        ///     �ж��ļ�����ʲô���͵��ļ�
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

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using DataEntities.Config.Check.Config;
using DataEntities.Config.Check.Info;
using DataEntities.Contact.Agency;
using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using System.IO;

namespace DataEntities.Element.Fee
{
    [Persistent("T_AbroadBill")]
    public class AbroadBill : XPLiteObject
    {
        private ABillHedge aBillHedge;
        private APayment aPayment;
        private Agency agency;
        private DateTime fdt_Billing;
        private DateTime fdt_CreateDate;
        private DateTime fdt_EditDate;
        private DateTime fdt_PayDate;
        private DateTime fdt_ReceiveBill;
        private DateTime fdt_ShldPayDate;
        private int fn_BillID;
        private int fn_CurrencyID;
        private decimal fn_FeePayed;
        private int fn_LatestCheckInfoID;
        private string fs_Creator;
        private string fs_Editor;
        private string fs_FilePath;
        private string fs_Lock;
        private string fs_Locker;
        private string fs_Note;
        private string fs_OppID;
        private string fs_PayMark;
        private string fs_Payer;
        private string fs_Reason;

        private string fs_CheckStatus;
        private int fn_Checker;
        private DateTime fdt_CheckDate;
        private string fs_Notes;

        public AbroadBill(Session session)
            : base(session)
        {
        }

        public AbroadBill()
            : base(Session.DefaultSession)
        {
        }

        [Key(true)]
        public int n_BillID
        {
            get { return fn_BillID; }
            set { SetPropertyValue<int>("n_BillID", ref fn_BillID, value); }
        }


        //int _fnVendorID;
        //public int n_VendorID
        //{
        //    get { return _fnVendorID; }
        //    set { SetPropertyValue<int>("n_VendorID", ref _fnVendorID, value); }
        //}

        //int fn_APaymentID;
        //public int n_APaymentID
        //{
        //    get { return fn_APaymentID; }
        //    set { SetPropertyValue<int>("n_APaymentID", ref fn_APaymentID, value); }
        //}

        [Persistent("n_HedgeID"), Association("ABillHedge-AbroadBills")]
        public ABillHedge TheABillHedge
        {
            get { return aBillHedge; }
            set { SetPropertyValue("n_HedgeID", ref aBillHedge, value); }
        }

        [Persistent("n_VendorID"), Association("Agency-AbroadBills")]
        public Agency TheAgency
        {
            get { return agency; }
            set { SetPropertyValue("n_VendorID", ref agency, value); }
        }

        //int fn_PayListID;
        //public int n_PayListID
        //{
        //    get { return fn_PayListID; }
        //    set { SetPropertyValue<int>("n_PayListID", ref fn_PayListID, value); }
        //}

        [Persistent("n_PayListID"), Association("APayment-AbroadBills")]
        public APayment TheAPayment
        {
            get { return aPayment; }
            set { SetPropertyValue("n_PayListID", ref aPayment, value); }
        }

        [Size(50)]
        public string s_OppID
        {
            get { return fs_OppID; }
            set { SetPropertyValue("s_OppID", ref fs_OppID, value); }
        }

        [Size(200)]
        public string s_Reason
        {
            get { return fs_Reason; }
            set { SetPropertyValue("s_Reason", ref fs_Reason, value); }
        }

        public DateTime dt_ShldPayDate
        {
            get { return fdt_ShldPayDate; }
            set { SetPropertyValue<DateTime>("dt_ShldPayDate", ref fdt_ShldPayDate, value); }
        }

        public int n_CurrencyID
        {
            get { return fn_CurrencyID; }
            set { SetPropertyValue<int>("n_CurrencyID", ref fn_CurrencyID, value); }
        }

        public DateTime dt_ReceiveBill
        {
            get { return fdt_ReceiveBill; }
            set { SetPropertyValue<DateTime>("dt_ReceiveBill", ref fdt_ReceiveBill, value); }
        }

        [Size(1)]
        public string s_PayMark
        {
            get { return fs_PayMark; }
            set { SetPropertyValue("s_PayMark", ref fs_PayMark, value); }
        }

        [Size(20)]
        public string s_Payer
        {
            get { return fs_Payer; }
            set { SetPropertyValue("s_Payer", ref fs_Payer, value); }
        }

        public DateTime dt_PayDate
        {
            get { return fdt_PayDate; }
            set { SetPropertyValue<DateTime>("dt_PayDate", ref fdt_PayDate, value); }
        }

        public decimal n_FeePayed
        {
            get { return fn_FeePayed; }
            set { SetPropertyValue<decimal>("n_FeePayed", ref fn_FeePayed, value); }
        }

        public DateTime dt_Billing
        {
            get { return fdt_Billing; }
            set { SetPropertyValue<DateTime>("dt_Billing", ref fdt_Billing, value); }
        }

        [Size(300)]
        public string s_Note
        {
            get { return fs_Note; }
            set { SetPropertyValue("s_Note", ref fs_Note, value); }
        }

        [Size(150)]
        public string s_FilePath
        {
            get { return fs_FilePath; }
            set { SetPropertyValue("s_FilePath", ref fs_FilePath, value); }
        }

        [Size(1)]
        public string s_Lock
        {
            get { return fs_Lock; }
            set { SetPropertyValue("s_Lock", ref fs_Lock, value); }
        }

        [Size(20)]
        public string s_Locker
        {
            get { return fs_Locker; }
            set { SetPropertyValue("s_Locker", ref fs_Locker, value); }
        }

        [Size(50)]
        public string s_Creator
        {
            get { return fs_Creator; }
            set { SetPropertyValue("s_Creator", ref fs_Creator, value); }
        }

        [Size(20)]
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

        public int n_LatestCheckInfoID
        {
            get { return fn_LatestCheckInfoID; }
            set { SetPropertyValue<int>("n_LatestCheckInfoID", ref fn_LatestCheckInfoID, value); }
        }

        [Aggregated, Association("AbroadBill-AbroadBillList", typeof(AbroadBillList))]
        public XPCollection AbroadBillListRelateA
        {
            get { return GetCollection("AbroadBillListRelateA"); }
        }

        [Aggregated, Association("AbroadBill-AbroadBillChecks")]
        public XPCollection<AbroadBillChecks> AbroadBillChecks
        {
            get { return GetCollection<AbroadBillChecks>("AbroadBillChecks"); }
        }
      
        
        /// <summary>
        ///     获取模块审核状态排序的最大值（最大值默认为审核通过）
        /// </summary>
        [Delayed]
        public int MaxSeqID
        {
            get
            {
                var tempUow = new UnitOfWork();
                var codeModuleCheck =
                    tempUow.FindObject<CodeModuleCheck>(CriteriaOperator.Parse("s_Module = ? ", "AbroadBill"));
                CodeModuleCheckStatuses re =
                    codeModuleCheck.CodeModuleCheckStatuses.OrderBy(s => s.n_Seq).Skip(1).FirstOrDefault();
                if (re != null)
                    return re.n_ID;
                return -1;
            }
        }

        /// <summary>
        ///     官费金额小计
        /// </summary>
        public decimal FeeSub
        {
            get { return Math.Round(AbroadBillListRelateA.Cast<AbroadBillList>().Sum(s => s.n_Fee), 2); }
        }

        /// <summary>
        ///     代理费金额小计
        /// </summary>
        public decimal AFeeSub
        {
            get { return Math.Round(AbroadBillListRelateA.Cast<AbroadBillList>().Sum(s => s.n_AFee), 2); }
        }

        /// <summary>
        ///     其他费金额小计
        /// </summary>
        public decimal TFeeSub
        {
            get { return Math.Round(AbroadBillListRelateA.Cast<AbroadBillList>().Sum(s => s.n_TFee), 2); }
        }

        /// <summary>
        ///     合计
        /// </summary>
        public decimal FeeSubTotal
        {
            get
            {
                return Math.Round(AbroadBillListRelateA.Cast<AbroadBillList>().Sum(s => s.n_Fee + s.n_AFee + s.n_TFee),
                    2);
            }
        }

        /// <summary>
        ///     客户名称
        /// </summary>
        public string sClientName
        {
            get
            {
                var abroadBillList = new List<string>();
                var listAbroadBillList = new List<AbroadBillList>();
                AbroadBillListRelateA.Cast<AbroadBillList>().Where(bill => bill.TheCase != null && bill.TheCase.TheClient != null).ToList().ForEach(b =>
                {
                    if (!abroadBillList.Contains(b.TheCase.TheClient.s_Name))
                    {
                        abroadBillList.Add(b.TheCase.TheClient.s_Name);
                        listAbroadBillList.Add(b);
                    }
                });
                return listAbroadBillList.Aggregate("",
                    (s, y) => y.TheCase != null && y.TheCase.TheClient != null ? s + y.TheCase.TheClient.s_Name + "," : s + "").TrimEnd(',');
            }
        }

        /// <summary>
        ///     我方文号
        /// </summary>
        public string sCaseSerial
        {
            get
            {
                var abroadBillList = new List<string>();
                var listAbroadBillList = new List<AbroadBillList>();
                AbroadBillListRelateA.Cast<AbroadBillList>().Where(bill => bill.TheCase != null).ToList().ForEach(b =>
               {
                   if (!abroadBillList.Contains(b.TheCase.s_CaseSerial))
                   {
                       abroadBillList.Add(b.TheCase.s_CaseSerial);
                       listAbroadBillList.Add(b);
                   }
               });
                return listAbroadBillList.Aggregate("",
                   (s, y) => y.TheCase != null ? s + y.TheCase.s_CaseSerial + "," : s + "").TrimEnd(',');
            }
        }
        public string sFileExtension
        {
            get
            {
                if (!string.IsNullOrEmpty(s_FilePath))
                {
                    string sExtension = Path.GetExtension(s_FilePath);
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
        public string s_OldFilePath { get; set; }


        [Size(1)]
        public string s_CheckStatus
        {
            get { return string.IsNullOrEmpty(fs_CheckStatus) ? "U" : fs_CheckStatus; }
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
    
        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}
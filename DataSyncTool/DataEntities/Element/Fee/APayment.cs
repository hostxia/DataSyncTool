using System;
using DevExpress.Xpo;

namespace DataEntities.Element.Fee
{
    [Persistent("T_ABillPayment")]
    public class APayment : XPLiteObject
    {
        private DateTime fdt_CreateDate;
        private DateTime fdt_EditDate;
        private DateTime fdt_PayDate;
        private DateTime fdt_ReReceiptDate;
        private int fn_CurrencyID;
        private decimal fn_ExRate;
        private int fn_ExchangeCurrency;
        private int fn_PayListID;
        private decimal fn_PaySum;
        private string fs_Creator;
        private string fs_Dealer;
        private string fs_Editor;
        private string fs_Lock;
        private string fs_Locker;
        private string fs_Note;
        private string fs_PayBillNo;
        private string fs_ReReceiptContent;
        private string fs_Register;
        private string fs_RegisterNo;

        public APayment(Session session) : base(session)
        {
        }

        public APayment() : base(Session.DefaultSession)
        {
        }

        [Key(true)]
        public int n_PayListID
        {
            get { return fn_PayListID; }
            set { SetPropertyValue<int>("n_PayListID", ref fn_PayListID, value); }
        }

        public DateTime dt_PayDate
        {
            get { return fdt_PayDate; }
            set { SetPropertyValue<DateTime>("dt_PayDate", ref fdt_PayDate, value); }
        }

        public decimal n_PaySum
        {
            get { return fn_PaySum; }
            set { SetPropertyValue<decimal>("n_PaySum", ref fn_PaySum, value); }
        }

        [Size(20)]
        public string s_PayBillNo
        {
            get { return fs_PayBillNo; }
            set { SetPropertyValue("s_PayBillNo", ref fs_PayBillNo, value); }
        }

        public int n_CurrencyID
        {
            get { return fn_CurrencyID; }
            set { SetPropertyValue<int>("n_CurrencyID", ref fn_CurrencyID, value); }
        }

        public int n_ExchangeCurrency
        {
            get { return fn_ExchangeCurrency; }
            set { SetPropertyValue<int>("n_ExchangeCurrency", ref fn_ExchangeCurrency, value); }
        }

        public decimal n_ExRate
        {
            get { return fn_ExRate; }
            set { SetPropertyValue<decimal>("n_ExRate", ref fn_ExRate, value); }
        }

        [Size(20)]
        public string s_Dealer
        {
            get { return fs_Dealer; }
            set { SetPropertyValue("s_Dealer", ref fs_Dealer, value); }
        }

        [Size(500)]
        public string s_Note
        {
            get { return fs_Note; }
            set { SetPropertyValue("s_Note", ref fs_Note, value); }
        }

        [Size(500)]
        public string s_ReReceiptContent
        {
            get { return fs_ReReceiptContent; }
            set { SetPropertyValue("s_ReReceiptContent", ref fs_ReReceiptContent, value); }
        }

        public DateTime dt_ReReceiptDate
        {
            get { return fdt_ReReceiptDate; }
            set { SetPropertyValue<DateTime>("dt_ReReceiptDate", ref fdt_ReReceiptDate, value); }
        }

        [Size(20)]
        public string s_Register
        {
            get { return fs_Register; }
            set { SetPropertyValue("s_Register", ref fs_Register, value); }
        }


        [Size(20)]
        public string s_RegisterNo
        {
            get { return fs_RegisterNo; }
            set { SetPropertyValue("s_RegisterNo", ref fs_RegisterNo, value); }
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

        [Size(20)]
        public string s_Editor
        {
            get { return fs_Editor; }
            set { SetPropertyValue("s_Editor", ref fs_Editor, value); }
        }

        [Size(50)]
        public string s_Creator
        {
            get { return fs_Creator; }
            set { SetPropertyValue("s_Creator", ref fs_Creator, value); }
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

        [Association("APayment-AbroadBills", typeof (AbroadBill))]
        public XPCollection AbroadBills
        {
            get { return GetCollection("AbroadBills"); }
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}
using System;
using DevExpress.Xpo;

namespace DataEntities.Finance.Accounting
{
    [Persistent("TTB_Deposit")]
    public class Deposit : XPLiteObject
    {
        private DateTime fdt_CreateDate;
        private DateTime fdt_Date;
        private DateTime fdt_EditDate;
        private int fn_DepositID;
        private decimal fn_Money;
        private string fs_Account;
        private string fs_Bank;

        private string fs_Class;
        private string fs_Creator;
        private string fs_Editor;
        private string fs_Note;
        private string fs_SheetNo;

        public Deposit(Session session) : base(session)
        {
        }

        public Deposit() : base(Session.DefaultSession)
        {
        }

        [Key(true)]
        public int n_DepositID
        {
            get { return fn_DepositID; }
            set { SetPropertyValue<int>("n_DepositID", ref fn_DepositID, value); }
        }

        [Size(1)]
        public string s_Class
        {
            get { return fs_Class; }
            set { SetPropertyValue("s_Class", ref fs_Class, value); }
        }

        public DateTime dt_Date
        {
            get { return fdt_Date; }
            set { SetPropertyValue<DateTime>("dt_Date", ref fdt_Date, value); }
        }

        public decimal n_Money
        {
            get { return fn_Money; }
            set { SetPropertyValue<decimal>("n_Money", ref fn_Money, value); }
        }

        public string s_SheetNo
        {
            get { return fs_SheetNo; }
            set { SetPropertyValue("s_SheetNo", ref fs_SheetNo, value); }
        }

        [Size(100)]
        public string s_Bank
        {
            get { return fs_Bank; }
            set { SetPropertyValue("s_Bank", ref fs_Bank, value); }
        }

        [Size(30)]
        public string s_Account
        {
            get { return fs_Account; }
            set { SetPropertyValue("s_Account", ref fs_Account, value); }
        }

        public DateTime dt_CreateDate
        {
            get { return fdt_CreateDate; }
            set { SetPropertyValue<DateTime>("dt_CreateDate", ref fdt_CreateDate, value); }
        }

        [Size(20)]
        public string s_Creator
        {
            get { return fs_Creator; }
            set { SetPropertyValue("s_Creator", ref fs_Creator, value); }
        }

        public DateTime dt_EditDate
        {
            get { return fdt_EditDate; }
            set { SetPropertyValue<DateTime>("dt_EditDate", ref fdt_EditDate, value); }
        }

        [Size(20)]
        public string s_Editor
        {
            get { return fs_Editor; }
            set { SetPropertyValue("s_Editor", ref fs_Editor, value); }
        }

        [Size(300)]
        public string s_Note
        {
            get { return fs_Note; }
            set { SetPropertyValue("s_Note", ref fs_Note, value); }
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}
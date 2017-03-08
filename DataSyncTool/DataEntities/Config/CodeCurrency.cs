using System;
using DevExpress.Xpo;

namespace DataEntities.Config
{
    [Persistent("TCode_Currency")]
    public class CodeCurrency : XPLiteObject
    {
        private DateTime fdt_CreateDate;
        private DateTime fdt_EditDate;
        private int fn_ID;
        private decimal fn_Rate;

        private string fs_CurrencyCode;

        private string fs_Name;

        private string fs_OtherName;

        public CodeCurrency(Session session) : base(session)
        {
        }

        public CodeCurrency() : base(Session.DefaultSession)
        {
        }

        [Key(true)]
        public int n_ID
        {
            get { return fn_ID; }
            set { SetPropertyValue<int>("n_ID", ref fn_ID, value); }
        }

        [Size(8)]
        public string s_CurrencyCode
        {
            get { return fs_CurrencyCode; }
            set { SetPropertyValue("s_CurrencyCode", ref fs_CurrencyCode, value); }
        }

        [Size(50)]
        public string s_Name
        {
            get { return fs_Name; }
            set { SetPropertyValue("s_Name", ref fs_Name, value); }
        }

        [Size(50)]
        public string s_OtherName
        {
            get { return fs_OtherName; }
            set { SetPropertyValue("s_OtherName", ref fs_OtherName, value); }
        }

        public decimal n_Rate
        {
            get { return fn_Rate; }
            set { SetPropertyValue<decimal>("n_Rate", ref fn_Rate, value); }
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

        private string fs_Notes;
        [Size(500)]
        public string s_Notes
        {
            get { return fs_Notes; }
            set { SetPropertyValue("s_Notes", ref fs_Notes, value); }
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}
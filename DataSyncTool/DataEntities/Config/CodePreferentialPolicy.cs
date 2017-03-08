using System;
using DevExpress.Xpo;

namespace DataEntities.Config
{
    [Persistent("TCode_PreferentialPolicy")]
    public class CodePreferentialPolicy : XPLiteObject
    {
        private int fn_ID;
        private string fs_IPType;
        private string fs_PTCType;
        private string fs_Name;
        private string fs_PreferentialPolicyType;
        private int fn_PreferentialPolicySubType;
        private string fs_PreferentialPolicySubType;
        private string fs_DiscountType;
        private decimal fn_Discount;
        private int fn_Currency;
        private string fs_Notes;
        private string fs_Creator;
        private DateTime fdt_CreateDate;
        private string fs_Editor;
        private DateTime fdt_EditDate;

        public CodePreferentialPolicy(Session session)
            : base(session)
        {
        }

        public CodePreferentialPolicy()
            : base(Session.DefaultSession)
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
            get { return fs_IPType; }
            set { SetPropertyValue("s_IPType", ref fs_IPType, value); }
        }

        [Size(500)]
        public string s_Name
        {
            get { return fs_Name; }
            set { SetPropertyValue("s_Name", ref fs_Name, value); }
        }

        [Size(1)]
        public string s_PreferentialPolicyType
        {
            get { return fs_PreferentialPolicyType; }
            set { SetPropertyValue("s_PreferentialPolicyType", ref fs_PreferentialPolicyType, value); }
        }

        public int n_PreferentialPolicySubType
        {
            get { return fn_PreferentialPolicySubType; }
            set { SetPropertyValue("n_PreferentialPolicySubType", ref fn_PreferentialPolicySubType, value); }
        }

        [Size(200)]
        public string s_PreferentialPolicySubType
        {
            get { return fs_PreferentialPolicySubType; }
            set { SetPropertyValue("s_PreferentialPolicySubType", ref fs_PreferentialPolicySubType, value); }
        }

        [Size(1)]
        public string s_DiscountType
        {
            get { return fs_DiscountType; }
            set { SetPropertyValue("s_DiscountType", ref fs_DiscountType, value); }
        }

        public decimal n_Discount
        {
            get { return fn_Discount; }
            set { SetPropertyValue<decimal>("n_Discount", ref fn_Discount, value); }
        }

        public int n_Currency
        {
            get { return fn_Currency; }
            set { SetPropertyValue<int>("n_Currency", ref fn_Currency, value); }
        }

        [Size(1000)]
        public string s_Notes
        {
            get { return fs_Notes; }
            set { SetPropertyValue("s_Notes", ref fs_Notes, value); }
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

        [Size(50)]
        public string s_Editor
        {
            get { return fs_Editor; }
            set { SetPropertyValue("s_Editor", ref fs_Editor, value); }
        }

        public DateTime dt_EditDate
        {
            get { return fdt_EditDate; }
            set { SetPropertyValue<DateTime>("dt_EditDate", ref fdt_EditDate, value); }
        }

        public string PreferentialPolicySubType
        {
            get { return fs_PreferentialPolicyType + fn_PreferentialPolicySubType; }
        }

        public string Discount
        {
            get { return fs_DiscountType == "P" ? (fn_Discount * 100).ToString("############0.00") + "%" : fn_Discount.ToString("############0.00"); }
        }
    }
}
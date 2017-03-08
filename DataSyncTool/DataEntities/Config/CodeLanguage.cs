using System;
using DevExpress.Xpo;

namespace DataEntities.Config
{
    [Persistent("TCode_Language")]
    public class CodeLanguage : XPLiteObject
    {
        private DateTime fdt_CreateDate;
        private DateTime fdt_EditDate;
        private int fn_ID;

        private string fs_LanguageCode;

        private string fs_Name;

        private string fs_OtherName;

        public CodeLanguage(Session session) : base(session)
        {
        }

        public CodeLanguage() : base(Session.DefaultSession)
        {
        }

        [Key(true)]
        public int n_ID
        {
            get { return fn_ID; }
            set { SetPropertyValue<int>("n_ID", ref fn_ID, value); }
        }

        [Size(6)]
        public string s_LanguageCode
        {
            get { return fs_LanguageCode; }
            set { SetPropertyValue("s_LanguageCode", ref fs_LanguageCode, value); }
        }

        [Size(40)]
        public string s_Name
        {
            get { return fs_Name; }
            set { SetPropertyValue("s_Name", ref fs_Name, value); }
        }

        [Size(40)]
        public string s_OtherName
        {
            get { return fs_OtherName; }
            set { SetPropertyValue("s_OtherName", ref fs_OtherName, value); }
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

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}
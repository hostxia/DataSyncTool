using System;
using DevExpress.Xpo;

namespace DataEntities.Config
{
    [Persistent("TCode_ProcessCustomField")]
    public class CodeProcessCustomField : XPLiteObject
    {
        private CodeProcess codeProcess;
        private DateTime fdt_CreateDate;
        private DateTime fdt_EditDate;
        private int fn_ID;
        private string fs_Content;
        private string fs_CustomFieldName;
        private string fs_IsActive;
        private string fs_Type;

        public CodeProcessCustomField(Session session) : base(session)
        {
        }

        public CodeProcessCustomField() : base(Session.DefaultSession)
        {
        }

        [Key(true)]
        public int n_ID
        {
            get { return fn_ID; }
            set { SetPropertyValue<int>("n_ID", ref fn_ID, value); }
        }

        [Association("CodeProcessCustomField")]
        [Persistent("n_ProcessID")]
        public CodeProcess CodeProcess
        {
            get { return codeProcess; }
            set { SetPropertyValue("n_ProcessID", ref codeProcess, value); }
        }

        [Size(200)]
        public string s_CustomFieldName
        {
            get { return fs_CustomFieldName; }
            set { SetPropertyValue("s_CustomFieldName", ref fs_CustomFieldName, value); }
        }

        [Size(50)]
        public string s_Type
        {
            get { return fs_Type; }
            set { SetPropertyValue("s_Type", ref fs_Type, value); }
        }

        [Size(1000)]
        public string s_Content
        {
            get { return fs_Content; }
            set { SetPropertyValue("s_Content", ref fs_Content, value); }
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

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}
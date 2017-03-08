using System;
using DevExpress.Xpo;

namespace DataEntities.Config
{
    [Persistent("TCode_BillTemplate")]
    public class CodeBillTemplate : XPLiteObject
    {
        private DateTime fdt_CreateDate;
        private DateTime fdt_EditDate;
        private int fn_ID;

        private int fn_Language;
        private string fs_FilePathName;

        private string fs_Name;
        private string fs_Notes;

        private string fs_OtherName;
        private string fs_Procedure;

        public CodeBillTemplate(Session session)
            : base(session)
        {
        }

        public CodeBillTemplate()
            : base(Session.DefaultSession)
        {
        }

        [Key(true)]
        public int n_ID
        {
            get { return fn_ID; }
            set { SetPropertyValue<int>("n_ID", ref fn_ID, value); }
        }

        public int n_Language
        {
            get { return fn_Language; }
            set { SetPropertyValue<int>("n_Language", ref fn_Language, value); }
        }

        [Size(200)]
        public string s_Name
        {
            get { return fs_Name; }
            set { SetPropertyValue("s_Name", ref fs_Name, value); }
        }

        [Size(200)]
        public string s_OtherName
        {
            get { return fs_OtherName; }
            set { SetPropertyValue("s_OtherName", ref fs_OtherName, value); }
        }

        [Size(500)]
        public string s_FilePathName
        {
            get { return fs_FilePathName; }
            set { SetPropertyValue("s_FilePathName", ref fs_FilePathName, value); }
        }

        [Size(800)]
        public string s_Notes
        {
            get { return fs_Notes; }
            set { SetPropertyValue("s_Notes", ref fs_Notes, value); }
        }

        [Size(200)]
        public string s_Procedure
        {
            get { return fs_Procedure; }
            set { SetPropertyValue("s_Procedure", ref fs_Procedure, value); }
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

        [Aggregated, Association("CodeBillTemplate_Columns", typeof(CodeBillTemplateColumn))]
        public XPCollection CodeBillTemplateColumns
        {
            get { return GetCollection("CodeBillTemplateColumns"); }
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}
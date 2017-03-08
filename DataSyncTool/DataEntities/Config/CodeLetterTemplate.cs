using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.Xpo;

namespace DataEntities.Config
{
    [Persistent("TCode_LetterTemplate")]
    public class CodeLetterTemplate : XPLiteObject
    {
        private DateTime fdt_CreateDate;
        private DateTime fdt_EditDate;
        private int fn_ID;
        private int fn_LanguageID;
        private string fs_FilePathName;
        private string fs_Name;
        private string fs_Notes;
        private string fs_OfficialCode;
        private string fs_OtherName;

        [Key(true)]
        public int n_ID
        {
            get { return fn_ID; }
            set { SetPropertyValue<int>("n_ID", ref fn_ID, value); }
        }

        public int n_LanguageID
        {
            get { return fn_LanguageID; }
            set { SetPropertyValue<int>("n_LanguageID", ref fn_LanguageID, value); }
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

        [Size(50)]
        public string s_OfficialCode
        {
            get { return fs_OfficialCode; }
            set { SetPropertyValue("s_OfficialCode", ref fs_OfficialCode, value); }
        }

        [Size(1000)]
        public string s_Notes
        {
            get { return fs_Notes; }
            set { SetPropertyValue("s_Notes", ref fs_Notes, value); }
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

        //[Aggregated, Association("LetterTemplate-CycleConfig", typeof(CodeCycleConfig))]
        //public XPCollection CodeCycleConfigs
        //{
        //    get { return GetCollection("CodeCycleConfigs"); }
        //}

        [Aggregated, Association("CodeLetterTemplate_Columns", typeof(CodeLetterTemplateColumn))]
        public XPCollection CodeLetterTemplateColumns
        {
            get { return GetCollection("CodeLetterTemplateColumns"); }
        }


        public CodeLetterTemplate(Session session)
            : base(session)
        {
        }

        public CodeLetterTemplate()
            : base(Session.DefaultSession)
        {
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}

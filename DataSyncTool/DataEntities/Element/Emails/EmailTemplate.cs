using System;
using DataEntities.Config;
using DevExpress.Xpo;

namespace DataEntities.Element.Emails
{
    [Persistent("TCode_EmailTemplate")]
    public class EmailTemplate : XPLiteObject
    {
        private DateTime fdt_CreateDate;
        private DateTime fdt_EditDate;
        private int fn_CodeEmailServerID;
        private int fn_ID;
        private string fs_FilePathName;
        private string fs_Name;
        private string fs_Notes;
        private string fs_Subject;

        private string fs_TemplateType;
        private string fs_Type;

        public EmailTemplate(Session session)
            : base(session)
        {
        }

        public EmailTemplate()
            : base(Session.DefaultSession)
        {
        }

        [Key(true)]
        public int n_ID
        {
            get { return fn_ID; }
            set { SetPropertyValue<int>("n_ID", ref fn_ID, value); }
        }

        [Size(50)]
        public string s_TemplateType
        {
            get { return fs_TemplateType; }
            set { SetPropertyValue("s_TemplateType", ref fs_TemplateType, value); }
        }

        private string fs_CaseType;
        [Size(5)]
        public string s_CaseType
        {
            get { return fs_CaseType; }
            set { SetPropertyValue("s_CaseType", ref fs_CaseType, value); }
        }


        public int n_CodeEmailServerID
        {
            get { return fn_CodeEmailServerID; }
            set { SetPropertyValue<int>("n_CodeEmailServerID", ref fn_CodeEmailServerID, value); }
        }

        [Size(5)]
        public string s_Type
        {
            get { return fs_Type; }
            set { SetPropertyValue("s_Type", ref fs_Type, value); }
        }

        [Size(200)]
        public string s_Name
        {
            get { return fs_Name; }
            set { SetPropertyValue("s_Name", ref fs_Name, value); }
        }

        [Size(500)]
        public string s_Subject
        {
            get { return fs_Subject; }
            set { SetPropertyValue("s_Subject", ref fs_Subject, value); }
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

        private int fn_LanguageID;
        public int n_LanguageID
        {
            get { return fn_LanguageID; }
            set { SetPropertyValue<int>("n_LanguageID", ref fn_LanguageID, value); }
        }


        private string fs_Default;
        [Size(2)]
        public string s_Default
        {
            get { return fs_Default; }
            set { SetPropertyValue("s_Default", ref fs_Default, value); }
        }
        //[Aggregated, Association("EmailTemplate-CycleConfig", typeof(CodeCycleConfig))]
        //public XPCollection CodeCycleConfigs
        //{
        //    get { return GetCollection("CodeCycleConfigs"); }
        //}

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}
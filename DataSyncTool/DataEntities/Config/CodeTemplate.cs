using System;
using System.ComponentModel;
using DevExpress.Xpo;

namespace DataEntities.Config
{
    [Persistent("TCode_Template")]
    public class CodeTemplate : XPLiteObject
    {
        private DateTime fdt_CreateDate;
        private DateTime fdt_EditDate;
        private int fn_ID;
        private int fn_Language;
        private int fn_RegCountry;
        private string fs_Business;
        private string fs_ExportType;
        private string fs_FilePathName;
        private string fs_IsSystemDefine;

        private string fs_MasterType;
        private string fs_Name;
        private string fs_NameSpace;
        private string fs_NeedInFile;
        private string fs_Notes;
        private string fs_OfficialCode;
        private string fs_OfficialName;
        private string fs_OtherName;
        private string fs_PTCType;
        private string fs_ProcessID;

        private string fs_TApplyType;

        private string fs_TemplateType;

        public CodeTemplate(Session session)
            : base(session)
        {
        }

        public CodeTemplate()
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
            get { return fs_MasterType; }
            set { SetPropertyValue("s_IPType", ref fs_MasterType, value); }
        }

        public string s_TApplyType
        {
            get { return fs_TApplyType; }
            set { SetPropertyValue("s_TApplyType", ref fs_TApplyType, value); }
        }

        [Size(1)]
        public string s_TemplateType
        {
            get { return fs_TemplateType; }
            set { SetPropertyValue("s_TemplateType", ref fs_TemplateType, value); }
        }

        public int n_RegCountry
        {
            get { return fn_RegCountry; }
            set { SetPropertyValue<int>("n_RegCountry", ref fn_RegCountry, value); }
        }

        [Size(500)]
        public string s_Business
        {
            get { return fs_Business; }
            set { SetPropertyValue("s_Business", ref fs_Business, value); }
        }

        [Size(500)]
        public string s_PTCType
        {
            get { return fs_PTCType; }
            set { SetPropertyValue("s_PTCType", ref fs_PTCType, value); }
        }

        [Size(500)]
        public string s_ProcessID
        {
            get { return fs_ProcessID; }
            set { SetPropertyValue("s_ProcessID", ref fs_ProcessID, value); }
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

        [Size(50)]
        public string s_OfficialCode
        {
            get { return fs_OfficialCode; }
            set { SetPropertyValue("s_OfficialCode", ref fs_OfficialCode, value); }
        }

        [Size(50)]
        public string s_NameSpace
        {
            get { return fs_NameSpace; }
            set { SetPropertyValue("s_NameSpace", ref fs_NameSpace, value); }
        }

        [Size(1), DefaultValue("Y")]
        public string s_NeedInFile
        {
            get { return fs_NeedInFile; }
            set { SetPropertyValue("s_NeedInFile", ref fs_NeedInFile, value); }
        }

        [Size(1)]
        public string s_IsSystemDefine
        {
            get { return fs_IsSystemDefine; }
            set { SetPropertyValue("s_IsSystemDefine", ref fs_IsSystemDefine, value); }
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

        [Size(1)]
        public string s_ExportType
        {
            get { return fs_ExportType; }
            set { SetPropertyValue("s_ExportType", ref fs_ExportType, value); }
        }

        [Size(100)]
        public string s_OfficialName
        {
            get { return fs_OfficialName; }
            set { SetPropertyValue("s_OfficialName", ref fs_OfficialName, value); }
        }

        [NonPersistent]
        public bool Check { get; set; }

        [Aggregated, Association("Template-CodeSplitDocuments")]
        public XPCollection<CodeSplitDocument> CodeSplitDocuments
        {
            get { return GetCollection<CodeSplitDocument>("CodeSplitDocuments"); }
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}
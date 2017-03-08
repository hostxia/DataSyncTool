using System;
using DevExpress.Xpo;

namespace DataEntities.Config
{
    [Persistent("TCode_CameFile")]
    public class CodeCameFile : XPLiteObject
    {
        private DateTime fdt_CreateDate;
        private DateTime fdt_EditDate;
        private int fn_ID;
        private int fn_ProcessID;
        private int fn_RegCountry;
        private string fs_FileCode;
        private string fs_FileFrom;
        private string fs_FileType;
        private string fs_IsSystem;

        private string fs_MasterType;
        private string fs_Name;
        private string fs_Notes;
        private string fs_OfficialCode;
        private string fs_OfficialName;
        private string fs_OtherName;
        private string fs_TApplyType;

        public CodeCameFile(Session session)
            : base(session)
        {
        }

        public CodeCameFile()
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

        [Size(50)]
        public string s_FileType
        {
            get { return fs_FileType; }
            set { SetPropertyValue("s_FileType", ref fs_FileType, value); }
        }

        [Size(2)]
        public string s_FileCode
        {
            get { return fs_FileCode; }
            set { SetPropertyValue("s_FileCode", ref fs_FileCode, value); }
        }

        [Size(1)]
        public string s_FileFrom
        {
            get { return fs_FileFrom; }
            set { SetPropertyValue("s_FileFrom", ref fs_FileFrom, value); }
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

        public int n_ProcessID
        {
            get { return fn_ProcessID; }
            set { SetPropertyValue<int>("n_ProcessID", ref fn_ProcessID, value); }
        }

        public int n_RegCountry
        {
            get { return fn_RegCountry; }
            set { SetPropertyValue<int>("n_RegCountry", ref fn_RegCountry, value); }
        }

        public string s_TApplyType
        {
            get { return fs_TApplyType; }
            set { SetPropertyValue("s_TApplyType", ref fs_TApplyType, value); }
        }

        [Size(800)]
        public string s_Notes
        {
            get { return fs_Notes; }
            set { SetPropertyValue("s_Notes", ref fs_Notes, value); }
        }

        [Size(1)]
        public string s_IsSystem
        {
            get { return fs_IsSystem; }
            set { SetPropertyValue("s_IsSystem", ref fs_IsSystem, value); }
        }

        [Size(50)]
        public string s_OfficialCode
        {
            get { return fs_OfficialCode; }
            set { SetPropertyValue("s_OfficialCode", ref fs_OfficialCode, value); }
        }

        [Size(100)]
        public string s_OfficialName
        {
            get { return fs_OfficialName; }
            set { SetPropertyValue("s_OfficialName", ref fs_OfficialName, value); }
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

        [Aggregated, Association("CodeCameFile-SysTaskInCameFile", typeof(CodeSysTaskInFile))]
        public XPCollection SysTaskInCameFile
        {
            get { return GetCollection("SysTaskInCameFile"); }
        }


        //[Aggregated, Association("CodeCameFile-TaskChainInCameFile")]
        //public XPCollection<OldTFCodeTaskChainInCameFile> CodeTaskChainInCameFiles
        //{
        //    get { return GetCollection<OldTFCodeTaskChainInCameFile>("CodeTaskChainInCameFiles"); }
        //}

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}
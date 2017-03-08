using System;
using DevExpress.Xpo;

namespace DataEntities.Config
{
    [Persistent("TCode_PTCType")]
    public class CodePTCType : XPLiteObject
    {
        private DateTime fdt_CreateDate;
        private DateTime fdt_EditDate;
        private int fn_ID;
        private string fs_Code;
        private string fs_IsSystem;

        private string fs_MasterType;
        private string fs_Name;
        private string fs_Notes;
        private string fs_OtherName;
        private string fs_RegularName;

        public CodePTCType(Session session) : base(session)
        {
        }

        public CodePTCType() : base(Session.DefaultSession)
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

        [Size(1)]
        public string s_Code
        {
            get { return fs_Code; }
            set { SetPropertyValue("s_Code", ref fs_Code, value); }
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

        public string s_RegularName
        {
            get { return fs_RegularName; }
            set { SetPropertyValue("s_RegularName", ref fs_RegularName, value); }
        }

        public string s_IsSystem
        {
            get { return fs_IsSystem; }
            set { SetPropertyValue("s_IsSystem", ref fs_IsSystem, value); }
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}
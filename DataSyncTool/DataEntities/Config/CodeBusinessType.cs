using System;
using DevExpress.Xpo;
using Infralution.Localization;

namespace DataEntities.Config
{
    [Persistent("TCode_BusinessType")]
    public class CodeBusinessType : XPLiteObject
    {
        private DateTime fdt_CreateDate;
        private DateTime fdt_EditDate;
        private int fn_ID;
        private string fs_Code;
        private string fs_IsActive;
        private string fs_IsSystemDefine;

        private string fs_MasterType;
        private string fs_Name;
        private string fs_Notes;
        private string fs_OtherName;
        private string fs_RegularName;

        private string fs_Type;

        public CodeBusinessType(Session session) : base(session)
        {
        }

        public CodeBusinessType() : base(Session.DefaultSession)
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
        public string s_Type
        {
            get { return fs_Type; }
            set { SetPropertyValue("s_Type", ref fs_Type, value); }
        }

        [Size(2)]
        public string s_Code
        {
            get { return fs_Code; }
            set { SetPropertyValue("s_Code", ref fs_Code, value); }
        }

        public string s_RegularName
        {
            get { return fs_RegularName; }
            set { SetPropertyValue("s_RegularName ", ref fs_RegularName, value); }
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

        public string s_IsSystemDefine
        {
            get { return fs_IsSystemDefine; }
            set { SetPropertyValue("s_IsSystemDefine", ref fs_IsSystemDefine, value); }
        }

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

        public string AllTypeName
        {
            get
            {
                switch (CultureManager.ApplicationUICulture.Name)
                {
                    case "en-US":
                    {
                        switch (fs_MasterType)
                        {
                            case "P":
                                return "(Patent)" + fs_Name;
                            case "T":
                                return "(Trademark)" + fs_Name;
                            case "C":
                                return "(Copyright)" + fs_Name;
                            case "D":
                                return "(Domain)" + fs_Name;
                            case "O":
                                return "(OtherCase)" + fs_Name;
                        }
                        return "";
                    }
                    default:
                    {
                        switch (fs_MasterType)
                        {
                            case "P":
                                return "(专利)" + fs_Name;
                            case "T":
                                return "(商标)" + fs_Name;
                            case "C":
                                return "(版权)" + fs_Name;
                            case "D":
                                return "(域名)" + fs_Name;
                            case "O":
                                return "(其他)" + fs_Name;
                        }
                        return "";
                    }
                }
            }
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}
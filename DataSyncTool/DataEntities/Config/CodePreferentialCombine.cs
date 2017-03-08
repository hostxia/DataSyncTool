using System;
using DevExpress.Xpo;

namespace DataEntities.Config
{
    [Persistent("TCode_PreferentialCombine")]
    public class CodePreferentialCombine : XPLiteObject
    {
        private int fn_ID;
        private string fs_IPType;
        private string fs_Name;
        private string fs_Notes;
        private string fs_Creator;
        private DateTime fdt_CreateDate;
        private string fs_Editor;
        private DateTime fdt_EditDate;

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

        [Aggregated, Association("PreferentialCombine-PolicyInCombine")]
        public XPCollection<CodePreferentialPolicyInCombine> PolicyInCombines
        {
            get { return GetCollection<CodePreferentialPolicyInCombine>("PolicyInCombines"); }
        }

        public CodePreferentialCombine(Session session)
            : base(session)
        {
        }

        public CodePreferentialCombine()
            : base(Session.DefaultSession)
        {
        }
    }
}
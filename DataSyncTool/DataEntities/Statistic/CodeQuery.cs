using System;
using DevExpress.Xpo;

namespace DataEntities.Statistic
{
    [Persistent("T_CodeQuery")]
    public class CodeQuery : XPLiteObject
    {
        private int fn_ID;
        private string fs_Name;
        private string fs_Note;
        private byte[] fbyte_QuerySQL;
        private string fs_IsSystem;
        private string fs_Editor;
        private DateTime fdt_EditDate;

        [Key(true)]
        public int n_ID
        {
            get { return fn_ID; }
            set { SetPropertyValue<int>("n_ID", ref fn_ID, value); }
        }

        [Size(200)]
        public string s_Name
        {
            get { return fs_Name; }
            set { SetPropertyValue("s_Name", ref fs_Name, value); }
        }

        [Size(500)]
        public string s_Note
        {
            get { return fs_Note; }
            set { SetPropertyValue("s_Note", ref fs_Note, value); }
        }

        public byte[] byte_QuerySQL
        {
            get { return fbyte_QuerySQL; }
            set { SetPropertyValue("byte_QuerySQL", ref fbyte_QuerySQL, value); }
        }

        [Size(50)]
        public string s_IsSystem
        {
            get { return fs_IsSystem; }
            set { SetPropertyValue("s_IsSystem", ref fs_IsSystem, value); }
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

        [Aggregated, Association("CodeQuery-UserQuerys")]
        public XPCollection<UserQuery> UserQuerys
        {
            get { return GetCollection<UserQuery>("UserQuerys"); }
        }

        [Aggregated, Association("CodeQuery-RoleQuerys")]
        public XPCollection<RoleQuery> RoleQuerys
        {
            get { return GetCollection<RoleQuery>("RoleQuerys"); }
        }

        [Aggregated, Association("CodeQuery-QueryInFolders")]
        public XPCollection<QueryInFolder> QueryInFolders
        {
            get { return GetCollection<QueryInFolder>("QueryInFolders"); }
        }

        public CodeQuery(Session session)
            : base(session)
        {
        }

        public CodeQuery()
            : base(Session.DefaultSession)
        {
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}
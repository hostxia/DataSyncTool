using System;
using DevExpress.Xpo;

namespace DataEntities.Config
{
    [Persistent("TCode_SearchTask")]
    public class CodeSearchTask : XPLiteObject
    {
        private int fn_ID;
        private string fs_Name;
        private string fs_Condition;
        private int fn_Sequence;
        private string fs_Description;
        private string fs_IsSystem;
        private string fs_Active;
        private DateTime fdt_CreateDate;
        private DateTime fdt_EditDate;

        public CodeSearchTask(Session session)
            : base(session)
        {
        }

        public CodeSearchTask()
            : base(Session.DefaultSession)
        {
        }

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

        [Size(1000)]
        public string s_Condition
        {
            get { return fs_Condition; }
            set { SetPropertyValue("s_Condition", ref fs_Condition, value); }
        }

        [Size(1)]
        public string s_IsSystem
        {
            get { return fs_IsSystem; }
            set { SetPropertyValue("s_IsSystem", ref fs_IsSystem, value); }
        }
        
        [Size(1)]
        public string s_Active
        {
            get { return fs_Active; }
            set { SetPropertyValue("s_Active", ref fs_Active, value); }
        }

        public int n_Sequence
        {
            get { return fn_Sequence; }
            set { SetPropertyValue<int>("n_Sequence", ref fn_Sequence, value); }
        }

        [Size(800)]
        public string s_Description
        {
            get { return fs_Description; }
            set { SetPropertyValue("s_Description", ref fs_Description, value); }
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

        [Aggregated, Association("CodeSearchTask-SearchTaskRights")]
        public XPCollection<CodeSearchTaskRights> SearchTaskRights
        {
            get { return GetCollection<CodeSearchTaskRights>("SearchTaskRights"); }
        }
    }
}

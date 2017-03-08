using DevExpress.Xpo;

namespace DataEntities.Config.Right
{
    [Persistent("T_Right")]
    public class Right : XPLiteObject
    {
        private int fn_ParentID;
        private int fn_RightID;
        private string fs_CodeName;
        private string fs_Description;
        private string fs_FromModule;

        private string fs_RightName;

        public Right(Session session) : base(session)
        {
        }

        public Right() : base(Session.DefaultSession)
        {
        }

        [Key(true)]
        public int n_RightID
        {
            get { return fn_RightID; }
            set { SetPropertyValue<int>("n_RightID", ref fn_RightID, value); }
        }

        [Size(50)]
        public string s_RightName
        {
            get { return fs_RightName; }
            set { SetPropertyValue("s_RightName", ref fs_RightName, value); }
        }

        public int n_ParentID
        {
            get { return fn_ParentID; }
            set { SetPropertyValue<int>("n_ParentID", ref fn_ParentID, value); }
        }

        public string s_Description
        {
            get { return fs_Description; }
            set { SetPropertyValue("s_Description", ref fs_Description, value); }
        }

        public string s_CodeName
        {
            get { return fs_CodeName; }
            set { SetPropertyValue("s_CodeName", ref fs_CodeName, value); }
        }

        public string s_FromModule
        {
            get { return fs_FromModule; }
            set { SetPropertyValue("s_FromModule", ref fs_FromModule, value); }
        }

        [Aggregated, Association("Right-RoleRights", typeof (RoleRights))]
        public XPCollection RoleRights
        {
            get { return GetCollection("RoleRights"); }
        }

        [Aggregated, Association("Right-UserRights", typeof (UserRights))]
        public XPCollection UserRights
        {
            get { return GetCollection("UserRights"); }
        }
        [NonPersistent]
        public bool Check
        {
            get;
            set;
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}
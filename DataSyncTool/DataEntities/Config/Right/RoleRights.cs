using DevExpress.Xpo;

namespace DataEntities.Config.Right
{
    [Persistent("T_RoleRights")]
    public class RoleRights : XPLiteObject
    {
        private Right _right;
        private Role _role;
        private int fn_ID;

        public RoleRights(Session session) : base(session)
        {
        }

        public RoleRights() : base(Session.DefaultSession)
        {
        }

        [Key(true)]
        public int n_ID
        {
            get { return fn_ID; }
            set { SetPropertyValue<int>("n_ID", ref fn_ID, value); }
        }

        [Association("Role-RoleRights")]
        [Persistent("n_RoleID")]
        public Role TheRole
        {
            get { return _role; }
            set { SetPropertyValue("n_RoleID", ref _role, value); }
        }

        //int fn_RoleID;
        //public int n_RoleID
        //{
        //    get { return fn_RoleID; }
        //    set { SetPropertyValue<int>("n_RoleID", ref fn_RoleID, value); }
        //}

        [Association("Right-RoleRights")]
        [Persistent("n_RightID")]
        public Right TheRight
        {
            get { return _right; }
            set { SetPropertyValue("n_RightID", ref _right, value); }
        }

        //int fn_RightID;
        //public int n_RightID
        //{
        //    get { return fn_RightID; }
        //    set { SetPropertyValue<int>("n_RightID", ref fn_RightID, value); }
        //}

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}
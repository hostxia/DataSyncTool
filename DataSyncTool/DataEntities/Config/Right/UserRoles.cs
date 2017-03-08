using DevExpress.Xpo;

namespace DataEntities.Config.Right
{
    [Persistent("T_UserRoles")]
    public class UserRoles : XPLiteObject
    {
        private Role _role;
        private CodeEmployee codeEmployee;
        private int fn_ID;

        public UserRoles(Session session) : base(session)
        {
        }

        public UserRoles() : base(Session.DefaultSession)
        {
        }

        [Key(true)]
        public int n_ID
        {
            get { return fn_ID; }
            set { SetPropertyValue<int>("n_ID", ref fn_ID, value); }
        }

        [Association("User-UserRoles")]
        [Persistent("n_UserID")]
        public CodeEmployee TheEmployee
        {
            get { return codeEmployee; }
            set { SetPropertyValue("n_UserID", ref codeEmployee, value); }
        }

        //int fn_UserID;
        //public int n_UserID
        //{
        //    get { return fn_UserID; }
        //    set { SetPropertyValue<int>("n_UserID", ref fn_UserID, value); }
        //}

        [Association("Role-UserRoles")]
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

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}
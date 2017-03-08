using DevExpress.Xpo;

namespace DataEntities.Config.Right
{
    [Persistent("T_UserRights")]
    public class UserRights : XPLiteObject
    {
        private Right _right;
        private CodeEmployee codeEmployee;
        private int fn_ID;

        public UserRights(Session session) : base(session)
        {
        }

        public UserRights() : base(Session.DefaultSession)
        {
        }

        [Key(true)]
        public int n_ID
        {
            get { return fn_ID; }
            set { SetPropertyValue<int>("n_ID", ref fn_ID, value); }
        }

        [Association("User-UserRights")]
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

        [Association("Right-UserRights")]
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
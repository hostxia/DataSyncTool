using DevExpress.Xpo;

namespace DataEntities.Config.Right
{
    [Persistent("T_UserDepartment")]
    public class UserDepartment : XPLiteObject
    {
        private CodeEmployee codeEmployee;

        private Department department;
        private int fn_ID;

        public UserDepartment(Session session) : base(session)
        {
        }

        public UserDepartment() : base(Session.DefaultSession)
        {
        }

        [Key(true)]
        public int n_ID
        {
            get { return fn_ID; }
            set { SetPropertyValue<int>("n_ID", ref fn_ID, value); }
        }

        [Association("User-UserDepartments")]
        [Persistent("n_UserID")]
        public CodeEmployee TheEmployee
        {
            get { return codeEmployee; }
            set { SetPropertyValue("n_UserID", ref codeEmployee, value); }
        }

        [Association("Department-UserDepartments")]
        [Persistent("n_DepartmentID")]
        public Department TheDepartment
        {
            get { return department; }
            set { SetPropertyValue("n_DepartmentID", ref department, value); }
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}
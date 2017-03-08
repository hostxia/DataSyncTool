using DataEntities.Config;
using DevExpress.Xpo;

namespace DataEntities.Case
{
    [Persistent("T_UserCaseInConsole")]
    public class UserCaseInConsole : XPLiteObject
    {
        private BasicCase basicCase;

        //int fn_CaseID;
        //public int n_CaseID
        //{
        //    get { return fn_CaseID; }
        //    set { SetPropertyValue<int>("n_CaseID", ref fn_CaseID, value); }
        //}
        private CodeEmployee codeEmployee;
        private int fn_ID;

        //int fn_EmployeeID;
        //public int n_EmployeeID
        //{
        //    get { return fn_EmployeeID; }
        //    set { SetPropertyValue<int>("n_EmployeeID", ref fn_EmployeeID, value); }
        //}
        public UserCaseInConsole(Session session) : base(session)
        {
        }

        public UserCaseInConsole() : base(Session.DefaultSession)
        {
        }

        [Key(true)]
        public int n_ID
        {
            get { return fn_ID; }
            set { SetPropertyValue<int>("n_ID", ref fn_ID, value); }
        }

        [Association("Case-UserInConsole")]
        [Persistent("n_CaseID")]
        public BasicCase TheCase
        {
            get { return basicCase; }
            set { SetPropertyValue("n_CaseID", ref basicCase, value); }
        }

        [Association("User-UserInConsole")]
        [Persistent("n_EmployeeID")]
        public CodeEmployee TheEmployee
        {
            get { return codeEmployee; }
            set { SetPropertyValue("n_EmployeeID", ref codeEmployee, value); }
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}
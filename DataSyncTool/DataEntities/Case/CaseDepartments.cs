using DataEntities.Config.Right;
using DevExpress.Xpo;

namespace DataEntities.Case
{
    [Persistent("TCase_Department")]
    public class CaseDepartment : XPLiteObject
    {
        private BasicCase basicCase;

        private Department department;
        private int fn_ID;

        public CaseDepartment(Session session) : base(session)
        {
        }

        public CaseDepartment() : base(Session.DefaultSession)
        {
        }

        [Key(true)]
        public int n_ID
        {
            get { return fn_ID; }
            set { SetPropertyValue<int>("n_ID", ref fn_ID, value); }
        }

        [Association("Case-CaseDepartments")]
        [Persistent("n_CaseID")]
        public BasicCase TheCase
        {
            get { return basicCase; }
            set { SetPropertyValue("n_CaseID", ref basicCase, value); }
        }

        [Association("Department-CaseDepartments")]
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
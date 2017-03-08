using DevExpress.Xpo;

namespace DataEntities.Config
{
    [Persistent("TCode_SearchTaskRights")]
    public class CodeSearchTaskRights : XPLiteObject
    {
        private CodeEmployee employee;
        private CodeSearchTask searchTaskCondition;
        private int fn_ID;
        private int fn_Sequence;

        [Key(true)]
        public int n_ID
        {
            get { return fn_ID; }
            set { SetPropertyValue<int>("n_ID", ref fn_ID, value); }
        }

        public int n_Sequence
        {
            get { return fn_Sequence; }
            set { SetPropertyValue<int>("n_Sequence", ref fn_Sequence, value); }
        }

        [Association("CodeSearchTask-SearchTaskRights")]
        [Persistent("n_SearchTaskID")]
        public CodeSearchTask SearchTaskCondition
        {
            get { return searchTaskCondition; }
            set { SetPropertyValue("n_SearchTaskID", ref searchTaskCondition, value); }
        }

        [Association("CodeEmployee-SearchTaskRights")]
        [Persistent("n_EmployeeID")]
        public CodeEmployee Employee
        {
            get { return employee; }
            set { SetPropertyValue("n_EmployeeID", ref employee, value); }
        }

        public CodeSearchTaskRights(Session session) : base(session) { }
    }
}

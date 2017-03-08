using DataEntities.Case;
using DevExpress.Xpo;

namespace DataEntities.Element.Fee
{
    [Persistent("T_ExpenseInCase")]
    public class ExpenseInCase : XPLiteObject
    {
        private BasicCase basicCase;
        private Expense expense;
        private int fn_ID;
        private string fs_IsMainCase;
        private Process process;

        public ExpenseInCase(Session session) : base(session)
        {
        }

        public ExpenseInCase() : base(Session.DefaultSession)
        {
        }

        [Key(true)]
        public int n_ID
        {
            get { return fn_ID; }
            set { SetPropertyValue<int>("n_ID", ref fn_ID, value); }
        }

        [Persistent("n_ExpenseID")]
        [Association("Expense-ExpenseInCases")]
        public Expense TheExpense
        {
            get { return expense; }
            set { SetPropertyValue("n_ExpenseID", ref expense, value); }
        }

        [Persistent("n_CaseID")]
        [Association("Case-ExpenseInCases")]
        public BasicCase TheCase
        {
            get { return basicCase; }
            set { SetPropertyValue("n_CaseID", ref basicCase, value); }
        }

        [Persistent("n_ProcessID")]
        [Association("Process-ExpenseInCases")]
        public Process TheProcess
        {
            get { return process; }
            set { SetPropertyValue("n_ProcessID", ref process, value); }
        }

        [Size(1)]
        public string s_IsMainCase
        {
            get { return fs_IsMainCase; }
            set { SetPropertyValue("s_IsMainCase", ref fs_IsMainCase, value); }
        }

        [NonPersistent]
        public bool Check { get; set; }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}
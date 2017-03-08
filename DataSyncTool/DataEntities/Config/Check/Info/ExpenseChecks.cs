using DataEntities.Element.Fee;
using DevExpress.Xpo;

namespace DataEntities.Config.Check.Info
{
    [Persistent(@"T_ExpenseChecks")]
    public class ExpenseChecks : XPLiteObject
    {
        private CheckFlow checkFlow;
        private Expense expense;
        private int fn_ID;

        public ExpenseChecks(Session session) : base(session)
        {
        }

        public ExpenseChecks() : base(Session.DefaultSession)
        {
        }

        [Key(true)]
        public int n_ID
        {
            get { return fn_ID; }
            set { SetPropertyValue<int>("n_ID", ref fn_ID, value); }
        }

        [Persistent("n_ExpenseID"), Association("Expense-ExpenseChecks")]
        public Expense TheExpense
        {
            get { return expense; }
            set { SetPropertyValue("n_ExpenseID", ref expense, value); }
        }

        [Persistent("n_CheckFlowID"), Association("CheckFlow-ExpenseChecks")]
        public CheckFlow TheCheckFlow
        {
            get { return checkFlow; }
            set { SetPropertyValue("n_CheckFlowID", ref checkFlow, value); }
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}
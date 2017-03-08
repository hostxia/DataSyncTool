using DataEntities.Finance.Bill;
using DevExpress.Xpo;

namespace DataEntities.Config.Check.Info
{
    [Persistent(@"T_BillChecks")]
    public class BillChecks : XPLiteObject
    {
        private Bill bill;

        private CheckFlow checkFlow;
        private int fn_ID;

        public BillChecks(Session session) : base(session)
        {
        }

        public BillChecks() : base(Session.DefaultSession)
        {
        }

        [Key(true)]
        public int n_ID
        {
            get { return fn_ID; }
            set { SetPropertyValue<int>("n_ID", ref fn_ID, value); }
        }

        [Persistent("n_BillID"), Association("Bill-BillChecks")]
        public Bill TheBill
        {
            get { return bill; }
            set { SetPropertyValue("n_BillID", ref bill, value); }
        }

        [Persistent("n_CheckFlowID"), Association("CheckFlow-BillChecks")]
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
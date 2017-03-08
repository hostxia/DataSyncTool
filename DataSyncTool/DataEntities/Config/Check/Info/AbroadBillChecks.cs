using DataEntities.Element.Fee;
using DevExpress.Xpo;

namespace DataEntities.Config.Check.Info
{
    [Persistent(@"T_AbroadBillChecks")]
    public class AbroadBillChecks : XPLiteObject
    {
        private AbroadBill abroadBill;

        private CheckFlow checkFlow;
        private int fn_ID;

        public AbroadBillChecks(Session session) : base(session)
        {
        }

        public AbroadBillChecks() : base(Session.DefaultSession)
        {
        }

        [Key(true)]
        public int n_ID
        {
            get { return fn_ID; }
            set { SetPropertyValue<int>("n_ID", ref fn_ID, value); }
        }

        [Persistent("n_BillID"), Association("AbroadBill-AbroadBillChecks")]
        public AbroadBill TheAbroadBill
        {
            get { return abroadBill; }
            set { SetPropertyValue("n_BillID", ref abroadBill, value); }
        }

        [Persistent("n_CheckFlowID"), Association("CheckFlow-AbroadBillChecks")]
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
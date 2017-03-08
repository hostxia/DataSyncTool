using DevExpress.Xpo;

namespace DataEntities.Finance.Bill
{
    [Persistent("T_BillTemp")]
    public class BillTemp : XPLiteObject
    {
        private int fn_BillID;
        private int fn_ID;

        public BillTemp(Session session) : base(session)
        {
        }

        public BillTemp() : base(Session.DefaultSession)
        {
        }

        [Key(true)]
        public int n_ID
        {
            get { return fn_ID; }
            set { SetPropertyValue<int>("n_ID", ref fn_ID, value); }
        }

        public int n_BillID
        {
            get { return fn_BillID; }
            set { SetPropertyValue<int>("n_BillID", ref fn_BillID, value); }
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}
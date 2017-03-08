using DevExpress.Xpo;
namespace DataEntities.Finance.ClaimMoney
{
    [Persistent("T_ClaimMoneyItem")]
    public class ClaimMoneyItem : XPLiteObject
    {
        private int fn_BillID;
        private int fn_ID;
        private int fn_ClaimMoneyID;

        [Key(true)]
        public int n_ID
        {
            get { return fn_ID; }
            set { SetPropertyValue<int>("n_ID", ref fn_ID, value); }
        }

        //public int n_BillID
        //{
        //    get { return fn_BillID; }
        //    set { SetPropertyValue<int>("n_BillID", ref fn_BillID, value); }
        //}
        private DataEntities.Finance.Bill.Bill _bill;
        [Persistent("n_BillID"), Association("Bill-ClaimMoneyItem")]
        public DataEntities.Finance.Bill.Bill TheBill
        {
            get { return _bill; }
            set { SetPropertyValue("n_BillID", ref _bill, value); }
        }

        //public int n_ClaimMoneyID
        //{
        //    get { return fn_ClaimMoneyID; }
        //    set { SetPropertyValue<int>("n_ClaimMoneyID", ref fn_ClaimMoneyID, value); }
        //}
        private ClaimMoney _claimMoney;
        [Persistent("n_ClaimMoneyID"), Association("ClaimMoney-ClaimMoneyItem")]
        public ClaimMoney TheClaimMoney
        {
            get { return _claimMoney; }
            set { SetPropertyValue("n_ClaimMoneyID", ref _claimMoney, value); }
        }

        public ClaimMoneyItem(Session session) : base(session) { }
        public ClaimMoneyItem() : base(Session.DefaultSession) { }
    }
}

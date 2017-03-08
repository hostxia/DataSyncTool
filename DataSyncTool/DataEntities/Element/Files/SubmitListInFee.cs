using DevExpress.Xpo;

namespace DataEntities.Element.Files
{
    [Persistent("T_ListInFee")]
    public class SubmitListInFee : XPLiteObject
    {
        private int fn_ID;

        private Fee.Fee theFee;
        private BaseFile theFile;

        public SubmitListInFee(Session session) : base(session)
        {
        }

        public SubmitListInFee() : base(Session.DefaultSession)
        {
        }

        [Key(true)]
        public int n_ID
        {
            get { return fn_ID; }
            set { SetPropertyValue<int>("n_ID", ref fn_ID, value); }
        }

        [Persistent("n_ListID")]
        [Association("File-SubmitListInFee")]
        public BaseFile TheFile
        {
            get { return theFile; }
            set { SetPropertyValue("n_ListID", ref theFile, value); }
        }

        [Persistent("n_FeeID")]
        [Association("Fee-SubmitListInFee")]
        public Fee.Fee TheFee
        {
            get { return theFee; }
            set { SetPropertyValue("n_FeeID", ref theFee, value); }
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}
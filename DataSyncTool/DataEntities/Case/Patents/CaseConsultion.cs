using DevExpress.Xpo;

namespace DataEntities.Case.Patents
{
    [MapInheritance(MapInheritanceType.OwnTable)]
    [Persistent("TPCase_ConsultInfo")]
    public class CaseConsultion : ExtendedPatent
    {
        //int fn_ID;
        //[Key(true)]
        //public int n_ID
        //{
        //    get { return fn_ID; }
        //    set { SetPropertyValue<int>("n_ID", ref fn_ID, value); }
        //}
        //Patent fn_CaseID;
        //[Association("Patent-ConsultInfo")]
        //[Persistent("n_CaseID")]
        //public Patent Patent
        //{
        //    get { return fn_CaseID; }
        //    set { SetPropertyValue<Patent>("n_CaseID", ref fn_CaseID, value); }
        //}

        private int fn_ConsultType;
        private int fn_Currency;
        private decimal fn_QuotedPrice;
        private string fs_Content;

        private string fs_Title;

        public CaseConsultion(Session session) : base(session)
        {
        }

        public CaseConsultion() : base(Session.DefaultSession)
        {
        }

        public int n_ConsultType
        {
            get { return fn_ConsultType; }
            set { SetPropertyValue<int>("n_ConsultType", ref fn_ConsultType, value); }
        }

        [Size(200)]
        public string s_Title
        {
            get { return fs_Title; }
            set { SetPropertyValue("s_Title", ref fs_Title, value); }
        }

        [Size(1000)]
        public string s_Content
        {
            get { return fs_Content; }
            set { SetPropertyValue("s_Content", ref fs_Content, value); }
        }

        public decimal n_QuotedPrice
        {
            get { return fn_QuotedPrice; }
            set { SetPropertyValue<decimal>("n_QuotedPrice", ref fn_QuotedPrice, value); }
        }

        public int n_Currency
        {
            get { return fn_Currency; }
            set { SetPropertyValue<int>("n_Currency", ref fn_Currency, value); }
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}
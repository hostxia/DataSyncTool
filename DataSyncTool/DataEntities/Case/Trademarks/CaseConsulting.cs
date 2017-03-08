using DevExpress.Xpo;

namespace DataEntities.Case.Trademarks
{
    [MapInheritance(MapInheritanceType.OwnTable)]
    [Persistent("TTCase_ConsultInfo")]
    public class CaseConsulting : ExtendedTrademark
    {
        private readonly XPDelayedProperty fn_ConsultType = new XPDelayedProperty();
        private readonly XPDelayedProperty fn_Currency = new XPDelayedProperty();
        private readonly XPDelayedProperty fn_QuotedPrice = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_Content = new XPDelayedProperty();

        private readonly XPDelayedProperty fs_Title = new XPDelayedProperty();

        public CaseConsulting(Session session) : base(session)
        {
        }

        public CaseConsulting() : base(Session.DefaultSession)
        {
        }

        [Delayed("fn_ConsultType")]
        public int n_ConsultType
        {
            get
            {
                if (fn_ConsultType.Value == null)
                {
                    return -1;
                }
                return (int) fn_ConsultType.Value;
            }
            set { fn_ConsultType.Value = value; }
        }

        [Delayed("fs_Title")]
        [Size(200)]
        public string s_Title
        {
            get { return (string) fs_Title.Value; }
            set { fs_Title.Value = value; }
        }

        [Delayed("fs_Content")]
        [Size(1000)]
        public string s_Content
        {
            get { return (string) fs_Content.Value; }
            set { fs_Content.Value = value; }
        }

        [Delayed("fn_QuotedPrice")]
        public decimal n_QuotedPrice
        {
            get
            {
                if (fn_QuotedPrice.Value == null)
                {
                    return -1;
                }
                return (decimal) fn_QuotedPrice.Value;
            }
            set { fn_QuotedPrice.Value = value; }
        }

        [Delayed("fn_Currency")]
        public int n_Currency
        {
            get
            {
                if (fn_Currency.Value == null)
                {
                    return -1;
                }
                return (int) fn_Currency.Value;
            }
            set { fn_Currency.Value = value; }
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}
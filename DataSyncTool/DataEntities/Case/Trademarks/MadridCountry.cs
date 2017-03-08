using DataEntities.Config;
using DevExpress.Xpo;

namespace DataEntities.Case.Trademarks
{
    [Persistent("TTCase_MadridCountry")]
    public class MadridCountry : XPLiteObject
    {
        private readonly XPDelayedProperty fn_DisignatedCountry = new XPDelayedProperty();
        private readonly XPDelayedProperty fn_TrademarkClass = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_IndividualSpecify = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_LawStatus = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_NewCaseID = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_Notes = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_TrademarkItem = new XPDelayedProperty();
        private int fn_ID;

        private ExtendedTrademark trademark;

        public MadridCountry(Session session) : base(session)
        {
        }

        public MadridCountry() : base(Session.DefaultSession)
        {
        }

        [Key(true)]
        public int n_ID
        {
            get { return fn_ID; }
            set { SetPropertyValue<int>("n_ID", ref fn_ID, value); }
        }

        [Association("Trademark-MadridCountries")]
        [Persistent("n_CaseID")]
        public ExtendedTrademark TheTrademark
        {
            get { return trademark; }
            set { SetPropertyValue("n_CaseID", ref trademark, value); }
        }

        [Delayed("fn_DisignatedCountry")]
        public int n_DisignatedCountry
        {
            get
            {
                if (fn_DisignatedCountry.Value == null)
                {
                    return -1;
                }
                return (int) fn_DisignatedCountry.Value;
            }
            set { fn_DisignatedCountry.Value = value; }
        }

        [Delayed("fn_TrademarkClass")]
        [Size(200)]
        public string n_TrademarkClass
        {
            get { return (string) fn_TrademarkClass.Value; }
            set { fn_TrademarkClass.Value = value; }
        }

        [Delayed("fs_IndividualSpecify")]
        [Size(1)]
        public string s_IndividualSpecify
        {
            get { return (string) fs_IndividualSpecify.Value; }
            set { fs_IndividualSpecify.Value = value; }
        }

        [Delayed("fs_TrademarkItem")]
        [Size(SizeAttribute.Unlimited)]
        public string s_TrademarkItem
        {
            get { return (string) fs_TrademarkItem.Value; }
            set { fs_TrademarkItem.Value = value; }
        }

        [Delayed("fs_LawStatus")]
        [Size(40)]
        public string s_LawStatus
        {
            get { return (string) fs_LawStatus.Value; }
            set { fs_LawStatus.Value = value; }
        }

        [Delayed("fs_Notes")]
        [Size(800)]
        public string s_Notes
        {
            get { return (string) fs_Notes.Value; }
            set { fs_Notes.Value = value; }
        }

        [Delayed("fs_NewCaseID")]
        [Size(500)]
        public string s_NewCaseID
        {
            get { return (string) fs_NewCaseID.Value; }
            set { fs_NewCaseID.Value = value; }
        }

        public CodeCountry Country
        {
            get
            {
                using (var tempUow = new UnitOfWork())
                {
                    var country = tempUow.GetObjectByKey<CodeCountry>(n_DisignatedCountry);
                    return country;
                }
            }
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}
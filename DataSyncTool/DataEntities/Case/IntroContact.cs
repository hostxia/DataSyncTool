using DevExpress.Xpo;

namespace DataEntities.Case
{
    [Persistent("TCase_IntroContact")]
    public class IntroContact : XPLiteObject
    {
        private readonly XPDelayedProperty fn_ContactID = new XPDelayedProperty();
        private readonly XPDelayedProperty fn_Sequence = new XPDelayedProperty();
        private BasicCase basicCase;
        private int fn_ID;

        public IntroContact(Session session) : base(session)
        {
        }

        public IntroContact() : base(Session.DefaultSession)
        {
        }

        [Key(true)]
        public int n_ID
        {
            get { return fn_ID; }
            set { SetPropertyValue<int>("n_ID", ref fn_ID, value); }
        }

        [Association("Case-IntroContact")]
        [Persistent("n_CaseID")]
        public BasicCase BasicCase
        {
            get { return basicCase; }
            set { SetPropertyValue("n_CaseID", ref basicCase, value); }
        }

        [Delayed("fn_Sequence")]
        public int n_Sequence
        {
            get
            {
                if (fn_Sequence.Value == null)
                {
                    return -1;
                }
                return (int) fn_Sequence.Value;
            }
            set { fn_Sequence.Value = value; }
        }

        [Delayed("fn_ContactID")]
        public int n_ContactID
        {
            get
            {
                if (fn_ContactID.Value == null)
                {
                    return -1;
                }
                return (int) fn_ContactID.Value;
            }
            set { fn_ContactID.Value = value; }
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}
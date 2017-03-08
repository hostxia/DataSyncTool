using DevExpress.Xpo;

namespace DataEntities.Case
{
    [Persistent("TCase_FormPage")]
    public class FormPage : XPLiteObject
    {
        private readonly XPDelayedProperty fs_XMLValue = new XPDelayedProperty();
        private BasicCase basicCase;
        private int fn_ID;

        public FormPage(Session session) : base(session)
        {
        }

        public FormPage() : base(Session.DefaultSession)
        {
        }

        [Key(true)]
        public int n_ID
        {
            get { return fn_ID; }
            set { SetPropertyValue<int>("n_ID", ref fn_ID, value); }
        }

        [Association("Case-FormPages")]
        [Persistent("n_CaseID")]
        public BasicCase BasicCase
        {
            get { return basicCase; }
            set { SetPropertyValue("n_CaseID", ref basicCase, value); }
        }

        [Delayed("fs_XMLValue")]
        [Size(SizeAttribute.Unlimited)]
        public string s_XMLValue
        {
            get { return (string) fs_XMLValue.Value; }
            set { fs_XMLValue.Value = value; }
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}
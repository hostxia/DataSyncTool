using DevExpress.Xpo;

namespace DataEntities.Config
{
    [Persistent("TCode_PreferentialPolicyInCombine")]
    public class CodePreferentialPolicyInCombine : XPLiteObject
    {
        private int fn_ID;
        private int fn_Sequence;
        private CodePreferentialCombine codePreferentialCombine;
        private int fn_PreferentialPolicyID;

        [Key(true)]
        public int n_ID
        {
            get { return fn_ID; }
            set { SetPropertyValue<int>("n_ID", ref fn_ID, value); }
        }

        public int n_Sequence
        {
            get { return fn_Sequence; }
            set { SetPropertyValue<int>("n_Sequence", ref fn_Sequence, value); }
        }

        [Persistent("n_CodePreferentialCombineID"), Association("PreferentialCombine-PolicyInCombine")]
        public CodePreferentialCombine TheCodePreferentialCombine
        {
            get { return codePreferentialCombine; }
            set { SetPropertyValue("n_CodePreferentialCombineID", ref codePreferentialCombine, value); }
        }

        public int n_PreferentialPolicyID
        {
            get { return fn_PreferentialPolicyID; }
            set { SetPropertyValue<int>("n_PreferentialPolicyID", ref fn_PreferentialPolicyID, value); }
        }

        public CodePreferentialPolicyInCombine(Session session)
            : base(session)
        {
        }

        public CodePreferentialPolicyInCombine()
            : base(Session.DefaultSession)
        {
        }
    }
}
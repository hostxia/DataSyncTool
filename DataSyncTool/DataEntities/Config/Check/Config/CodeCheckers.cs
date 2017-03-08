using DevExpress.Xpo;

namespace DataEntities.Config.Check.Config
{
    [Persistent(@"TCode_Checkers")]
    public class CodeCheckers : XPLiteObject
    {
        private CodeModuleCheck codeModuleCheck;

        private int fn_CheckerID;
        private int fn_ID;

        public CodeCheckers(Session session) : base(session)
        {
        }

        public CodeCheckers() : base(Session.DefaultSession)
        {
        }

        [Key(true)]
        public int n_ID
        {
            get { return fn_ID; }
            set { SetPropertyValue<int>("n_ID", ref fn_ID, value); }
        }

        [Persistent("n_ModuleCheckID"), Association("CodeModuleCheck-CodeCheckers")]
        public CodeModuleCheck TheCodeModuleCheck
        {
            get { return codeModuleCheck; }
            set { SetPropertyValue("n_ModuleCheckID", ref codeModuleCheck, value); }
        }

        public int n_CheckerID
        {
            get { return fn_CheckerID; }
            set { SetPropertyValue<int>("n_CheckerID", ref fn_CheckerID, value); }
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}
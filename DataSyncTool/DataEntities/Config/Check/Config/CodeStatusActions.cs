using DevExpress.Xpo;

namespace DataEntities.Config.Check.Config
{
    [Persistent(@"TCode_StatusActions")]
    public class CodeStatusActions : XPLiteObject
    {
        private CodeCheckActions codeCheckActions;
        private CodeModuleCheckStatuses codeModuleCheckStatuses;
        private bool fn_CurUserEffective;
        private int fn_ID;

        public CodeStatusActions(Session session) : base(session)
        {
        }

        public CodeStatusActions() : base(Session.DefaultSession)
        {
        }

        [Key(true)]
        public int n_ID
        {
            get { return fn_ID; }
            set { SetPropertyValue<int>("n_ID", ref fn_ID, value); }
        }

        [Persistent("n_ModuleCheckStatusID"), Association("CodeModuleCheckStatus-CodeStatusActions")]
        public CodeModuleCheckStatuses TheCodeModuleCheckStatus
        {
            get { return codeModuleCheckStatuses; }
            set { SetPropertyValue("n_ModuleCheckStatusID", ref codeModuleCheckStatuses, value); }
        }

        [Persistent("n_CheckActionID"), Association("CodeStatusAction-CodeStatusActions")]
        public CodeCheckActions TheCheckAction
        {
            get { return codeCheckActions; }
            set { SetPropertyValue("n_CheckActionID", ref codeCheckActions, value); }
        }

        public bool n_CurUserEffective
        {
            get { return fn_CurUserEffective; }
            set { SetPropertyValue("n_CurUserEffective", ref fn_CurUserEffective, value); }
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}
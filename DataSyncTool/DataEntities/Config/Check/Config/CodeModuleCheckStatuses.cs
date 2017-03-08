using DevExpress.Xpo;

namespace DataEntities.Config.Check.Config
{
    [Persistent(@"TCode_ModuleCheckStatuses")]
    public class CodeModuleCheckStatuses : XPLiteObject
    {
        private CodeCheckStatuses codeCheckStatuses;
        private CodeModuleCheck codeModuleCheck;
        private int fn_ID;
        private int fn_Seq;

        public CodeModuleCheckStatuses(Session session) : base(session)
        {
        }

        public CodeModuleCheckStatuses() : base(Session.DefaultSession)
        {
        }

        [Key(true)]
        public int n_ID
        {
            get { return fn_ID; }
            set { SetPropertyValue<int>("n_ID", ref fn_ID, value); }
        }

        [Persistent("n_StatusCodeID"), Association("CodeCheckStatus-CodeModuleCheckStatuses")]
        public CodeCheckStatuses TheCodeCheckStatus
        {
            get { return codeCheckStatuses; }
            set { SetPropertyValue("n_StatusCodeID", ref codeCheckStatuses, value); }
        }

        [NonPersistent]
        public string CodeCheckStatusName
        {
            get { return TheCodeCheckStatus == null ? string.Empty : TheCodeCheckStatus.s_Name; }
        }

        [Persistent("n_ModuleCheckID"), Association("CodeModuleCheck-CodeModuleCheckStatuses")]
        public CodeModuleCheck TheCodeModuleCheck
        {
            get { return codeModuleCheck; }
            set { SetPropertyValue("n_ModuleCheckID", ref codeModuleCheck, value); }
        }

        public int n_Seq
        {
            get { return fn_Seq; }
            set { SetPropertyValue<int>("n_Seq", ref fn_Seq, value); }
        }

        [Aggregated, Association("CodeModuleCheckStatus-CodeStatusActions")]
        public XPCollection<CodeStatusActions> CodeStatusActions
        {
            get { return GetCollection<CodeStatusActions>("CodeStatusActions"); }
        }

        [NonPersistent]
        public bool nEmailRemindCheck { get; set; }

        [NonPersistent]
        public bool nEmailCC { get; set; }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}
using DevExpress.Xpo;

namespace DataEntities.Config.Check.Config
{
    [Persistent(@"TCode_ModuleCheck")]
    public class CodeModuleCheck : XPLiteObject
    {
        private bool fn_Enable;
        private int fn_ID;

        private string fs_Module;

        public CodeModuleCheck(Session session) : base(session)
        {
        }

        public CodeModuleCheck() : base(Session.DefaultSession)
        {
        }

        [Key(true)]
        public int n_ID
        {
            get { return fn_ID; }
            set { SetPropertyValue<int>("n_ID", ref fn_ID, value); }
        }

        [Size(50)]
        public string s_Module
        {
            get { return fs_Module; }
            set { SetPropertyValue("s_Module", ref fs_Module, value); }
        }

        public bool n_Enable
        {
            get { return fn_Enable; }
            set { SetPropertyValue("n_Enable", ref fn_Enable, value); }
        }

        [Aggregated, Association("CodeModuleCheck-CodeCheckers")]
        public XPCollection<CodeCheckers> CodeCheckers
        {
            get { return GetCollection<CodeCheckers>("CodeCheckers"); }
        }

        [Aggregated, Association("CodeModuleCheck-CodeModuleCheckStatuses")]
        public XPCollection<CodeModuleCheckStatuses> CodeModuleCheckStatuses
        {
            get { return GetCollection<CodeModuleCheckStatuses>("CodeModuleCheckStatuses"); }
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}
using DevExpress.Xpo;

namespace DataEntities.Config.Check.Config
{
    [Persistent(@"TCode_CheckStatuses")]
    public class CodeCheckStatuses : XPLiteObject
    {
        private int fn_ID;

        private string fs_Name;

        public CodeCheckStatuses(Session session) : base(session)
        {
        }

        public CodeCheckStatuses() : base(Session.DefaultSession)
        {
        }

        [Key(true)]
        public int n_ID
        {
            get { return fn_ID; }
            set { SetPropertyValue<int>("n_ID", ref fn_ID, value); }
        }

        [Size(50)]
        public string s_Name
        {
            get { return fs_Name; }
            set { SetPropertyValue("s_Name", ref fs_Name, value); }
        }

        [Aggregated, Association("CodeCheckStatus-CodeModuleCheckStatuses")]
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
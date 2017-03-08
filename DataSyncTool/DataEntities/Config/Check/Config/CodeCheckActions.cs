using DevExpress.Xpo;

namespace DataEntities.Config.Check.Config
{
    [Persistent(@"TCode_CheckActions")]
    public class CodeCheckActions : XPLiteObject
    {
        private int fn_ID;

        private string fs_ActionName;

        private string fs_ControlCode;
        private string fs_Module;

        public CodeCheckActions(Session session) : base(session)
        {
        }

        public CodeCheckActions() : base(Session.DefaultSession)
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

        [Size(50)]
        public string s_ActionName
        {
            get { return fs_ActionName; }
            set { SetPropertyValue("s_ActionName", ref fs_ActionName, value); }
        }

        [Size(20)]
        public string s_ControlCode
        {
            get { return fs_ControlCode; }
            set { SetPropertyValue("s_ControlCode", ref fs_ControlCode, value); }
        }

        [Aggregated, Association("CodeStatusAction-CodeStatusActions")]
        public XPCollection<CodeStatusActions> CodeStatusActions
        {
            get { return GetCollection<CodeStatusActions>("CodeStatusActions"); }
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}
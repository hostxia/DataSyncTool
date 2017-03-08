using DevExpress.Xpo;

namespace DataEntities.Config
{
    [Persistent("TCode_OtherTemplate")]
    public class CodeOtherTemplate : XPLiteObject
    {
        private int fn_ID;

        private string fs_DisplayName;

        private string fs_FileName;

        private string fs_Type;

        public CodeOtherTemplate(Session session) : base(session)
        {
        }

        public CodeOtherTemplate() : base(Session.DefaultSession)
        {
        }

        [Key(true)]
        public int n_ID
        {
            get { return fn_ID; }
            set { SetPropertyValue<int>("n_ID", ref fn_ID, value); }
        }

        [Size(200)]
        public string s_DisplayName
        {
            get { return fs_DisplayName; }
            set { SetPropertyValue("s_DisplayName", ref fs_DisplayName, value); }
        }

        [Size(500)]
        public string s_FileName
        {
            get { return fs_FileName; }
            set { SetPropertyValue("s_FileName", ref fs_FileName, value); }
        }

        [Size(20)]
        public string s_Type
        {
            get { return fs_Type; }
            set { SetPropertyValue("s_Type", ref fs_Type, value); }
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}
using DevExpress.Xpo;

namespace DataEntities.Config
{
    [Persistent("TCode_SplitDocument")]
    public class CodeSplitDocument : XPLiteObject
    {
        private int fn_SplitID;
        private string fs_IPType;
        private string fs_Type;
        private string fs_Name;
        private int fn_TemplateID;
        private int fn_Sequence;
        private CodeTemplate codeTemplate;

        [Key(true)]
        public int n_SplitID
        {
            get { return fn_SplitID; }
            set { SetPropertyValue<int>("n_SplitID", ref fn_SplitID, value); }
        }

        [Size(1)]
        public string s_IPType
        {
            get { return fs_IPType; }
            set { SetPropertyValue("s_IPType", ref fs_IPType, value); }
        }

        [Size(50)]
        public string s_Type
        {
            get { return fs_Type; }
            set { SetPropertyValue("s_Type", ref fs_Type, value); }
        }

        [Size(200)]
        public string s_Name
        {
            get { return fs_Name; }
            set { SetPropertyValue("s_Name", ref fs_Name, value); }
        }

        [Persistent("n_TemplateID"), Association("Template-CodeSplitDocuments")]
        public CodeTemplate TheCodeTemplate
        {
            get { return codeTemplate; }
            set { SetPropertyValue("n_TemplateID", ref codeTemplate, value); }
        }

        public int n_Sequence
        {
            get { return fn_Sequence; }
            set { SetPropertyValue<int>("n_Sequence", ref fn_Sequence, value); }
        }

        [NonPersistent]
        public int n_StartPage { get; set; }

        [NonPersistent]
        public int n_EndPage { get; set; }

        [NonPersistent]
        public string s_FilePath { get; set; }

        [NonPersistent]
        public string s_TempDocFilePath { get; set; }

        public CodeSplitDocument(Session session)
            : base(session)
        {
        }

        public CodeSplitDocument()
            : base(Session.DefaultSession)
        {
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}
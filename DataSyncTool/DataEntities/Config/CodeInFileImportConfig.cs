using DevExpress.Xpo;

namespace DataEntities.Config
{
    [Persistent("TCode_InFileImportConfig")]
    public class CodeInFileImportConfig : XPLiteObject
    {
        private int fn_CaseMethod;
        private int fn_ConfigID;
        private int fn_Delimiter;
        private int fn_FileMethod;
        private int fn_FileNameRule;
        private int fn_FileType;

        private string fs_ConfigName;
        private string fs_ImportedFileName;

        public CodeInFileImportConfig(Session session) : base(session)
        {
        }

        public CodeInFileImportConfig() : base(Session.DefaultSession)
        {
        }

        [Key(true)]
        public int n_ConfigID
        {
            get { return fn_ConfigID; }
            set { SetPropertyValue<int>("n_ConfigID", ref fn_ConfigID, value); }
        }

        [Size(50)]
        public string s_ConfigName
        {
            get { return fs_ConfigName; }
            set { SetPropertyValue("s_ConfigName", ref fs_ConfigName, value); }
        }

        public int n_FileNameRule
        {
            get { return fn_FileNameRule; }
            set { SetPropertyValue<int>("n_FileNameRule", ref fn_FileNameRule, value); }
        }

        public int n_Delimiter
        {
            get { return fn_Delimiter; }
            set { SetPropertyValue<int>("n_Delimiter", ref fn_Delimiter, value); }
        }

        public int n_FileType
        {
            get { return fn_FileType; }
            set { SetPropertyValue<int>("n_FileType", ref fn_FileType, value); }
        }

        [Size(50)]
        public string s_ImportedFileName
        {
            get { return fs_ImportedFileName; }
            set { SetPropertyValue("s_ImportedFileName", ref fs_ImportedFileName, value); }
        }

        public int n_CaseMethod
        {
            get { return fn_CaseMethod; }
            set { SetPropertyValue<int>("n_CaseMethod", ref fn_CaseMethod, value); }
        }

        public int n_FileMethod
        {
            get { return fn_FileMethod; }
            set { SetPropertyValue<int>("n_FileMethod", ref fn_FileMethod, value); }
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}
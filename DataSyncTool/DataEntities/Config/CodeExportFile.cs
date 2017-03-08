using DevExpress.Xpo;

namespace DataEntities.Config
{
    [Persistent("TCode_ExportFile")]
    public class CodeExportFile : XPLiteObject
    {
        int fn_ID;
        [Key(true)]
        public int n_ID
        {
            get { return fn_ID; }
            set { SetPropertyValue<int>("n_ID", ref fn_ID, value); }
        }

        string fs_ByCase;
        [Size(1)]
        public string s_ByCase
        {
            get { return fs_ByCase; }
            set { SetPropertyValue<string>("s_ByCase", ref fs_ByCase, value); }
        }

        string fs_FolderName;
        [Size(50)]
        public string s_FolderName
        {
            get { return fs_FolderName; }
            set { SetPropertyValue<string>("s_FolderName", ref fs_FolderName, value); }
        }

        string fs_Element0;
        [Size(50)]
        public string s_Element0
        {
            get { return fs_Element0; }
            set { SetPropertyValue<string>("s_Element0", ref fs_Element0, value); }
        }

        string fs_Description0;
        [Size(50)]
        public string s_Description0
        {
            get { return fs_Description0; }
            set { SetPropertyValue<string>("s_Description0", ref fs_Description0, value); }
        }

        string fs_Element1;
        [Size(50)]
        public string s_Element1
        {
            get { return fs_Element1; }
            set { SetPropertyValue<string>("s_Element1", ref fs_Element1, value); }
        }

        string fs_Description1;
        [Size(50)]
        public string s_Description1
        {
            get { return fs_Description1; }
            set { SetPropertyValue<string>("s_Description1", ref fs_Description1, value); }
        }

        string fs_Element2;
        [Size(50)]
        public string s_Element2
        {
            get { return fs_Element2; }
            set { SetPropertyValue<string>("s_Element2", ref fs_Element2, value); }
        }

        string fs_Description2;
        [Size(50)]
        public string s_Description2
        {
            get { return fs_Description2; }
            set { SetPropertyValue<string>("s_Description2", ref fs_Description2, value); }
        }

        string fs_Element3;
        [Size(50)]
        public string s_Element3
        {
            get { return fs_Element3; }
            set { SetPropertyValue<string>("s_Element3", ref fs_Element3, value); }
        }

        string fs_Description3;
        [Size(50)]
        public string s_Description3
        {
            get { return fs_Description3; }
            set { SetPropertyValue<string>("s_Description3", ref fs_Description3, value); }
        }

        string fs_Element4;
        [Size(50)]
        public string s_Element4
        {
            get { return fs_Element4; }
            set { SetPropertyValue<string>("s_Element4", ref fs_Element4, value); }
        }

        string fs_Description4;
        [Size(50)]
        public string s_Description4
        {
            get { return fs_Description4; }
            set { SetPropertyValue<string>("s_Description4", ref fs_Description4, value); }
        }

        string fs_Element5;
        [Size(50)]
        public string s_Element5
        {
            get { return fs_Element5; }
            set { SetPropertyValue<string>("s_Element5", ref fs_Element5, value); }
        }

        string fs_Description5;
        [Size(50)]
        public string s_Description5
        {
            get { return fs_Description5; }
            set { SetPropertyValue<string>("s_Description5", ref fs_Description5, value); }
        }

        string fs_Element6;
        [Size(50)]
        public string s_Element6
        {
            get { return fs_Element6; }
            set { SetPropertyValue<string>("s_Element6", ref fs_Element6, value); }
        }

        string fs_Description6;
        [Size(50)]
        public string s_Description6
        {
            get { return fs_Description6; }
            set { SetPropertyValue<string>("s_Description6", ref fs_Description6, value); }
        }

        string fs_Element7;
        [Size(50)]
        public string s_Element7
        {
            get { return fs_Element7; }
            set { SetPropertyValue<string>("s_Element7", ref fs_Element7, value); }
        }

        string fs_Description7;
        [Size(50)]
        public string s_Description7
        {
            get { return fs_Description7; }
            set { SetPropertyValue<string>("s_Description7", ref fs_Description7, value); }
        }
  
        public CodeExportFile(Session session) : base(session)
        {
        }

        public CodeExportFile() : base(Session.DefaultSession)
        {
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}
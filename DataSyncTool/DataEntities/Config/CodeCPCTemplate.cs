using DevExpress.Xpo;

namespace DataEntities.Config
{
    [Persistent("TCode_CPCTemplate")]
    public class CodeCPCTemplate : XPLiteObject
    {
        private int fn_ID;

        private string fs_Code;
        private string fs_ImpotFileType;
        private string fs_IsCanCoding;
        private string fs_IsCanImport;

        private string fs_ListXmlType;
        private string fs_NeedCameOFile;

        public CodeCPCTemplate(Session session) : base(session)
        {
        }

        public CodeCPCTemplate() : base(Session.DefaultSession)
        {
        }

        [Key(true)]
        public int n_ID
        {
            get { return fn_ID; }
            set { SetPropertyValue<int>("n_ID", ref fn_ID, value); }
        }

        [Size(10)]
        public string s_Code
        {
            get { return fs_Code; }
            set { SetPropertyValue("s_Code", ref fs_Code, value); }
        }

        [Size(1)]
        public string s_ListXmlType
        {
            get { return fs_ListXmlType; }
            set { SetPropertyValue("s_ListXmlType", ref fs_ListXmlType, value); }
        }

        [Size(1)]
        public string s_IsCanCoding
        {
            get { return fs_IsCanCoding; }
            set { SetPropertyValue("s_IsCanCoding", ref fs_IsCanCoding, value); }
        }

        [Size(1)]
        public string s_IsCanImport
        {
            get { return fs_IsCanImport; }
            set { SetPropertyValue("s_IsCanImport", ref fs_IsCanImport, value); }
        }

        [Size(50)]
        public string s_ImpotFileType
        {
            get { return fs_ImpotFileType; }
            set { SetPropertyValue("s_ImpotFileType", ref fs_ImpotFileType, value); }
        }

        [Size(1)]
        public string s_NeedCameOFile
        {
            get { return fs_NeedCameOFile; }
            set { SetPropertyValue("s_NeedCameOFile", ref fs_NeedCameOFile, value); }
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}
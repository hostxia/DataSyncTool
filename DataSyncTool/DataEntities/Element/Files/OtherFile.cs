using DevExpress.Xpo;

namespace DataEntities.Element.Files
{
    [MapInheritance(MapInheritanceType.OwnTable)]
    [Persistent("T_OtherFiles")]
    public class OtherFile : BaseFile
    {
        private int fn_CheckedOutBy;
        private string fs_CheckedOut;
        private string fs_CheckedOutPath;
        private string fs_Version;
        private string fs_FileStatus;

        public OtherFile(Session session) : base(session)
        {
        }

        public OtherFile() : base(Session.DefaultSession)
        {
        }

        [Size(20)]
        public string s_Version
        {
            get { return fs_Version; }
            set { SetPropertyValue("s_Version", ref fs_Version, value); }
        }

        [Size(1)]
        public string s_CheckedOut
        {
            get { return fs_CheckedOut; }
            set { SetPropertyValue("s_CheckedOut", ref fs_CheckedOut, value); }
        }

        public int n_CheckedOutBy
        {
            get { return fn_CheckedOutBy; }
            set { SetPropertyValue<int>("n_CheckedOutBy", ref fn_CheckedOutBy, value); }
        }

        [Size(500)]
        public string s_CheckedOutPath
        {
            get { return fs_CheckedOutPath; }
            set { SetPropertyValue("s_CheckedOutPath", ref fs_CheckedOutPath, value); }
        }

        [Size(1)]
        public string s_FileStatus
        {
            get { return fs_FileStatus; }
            set { SetPropertyValue("s_FileStatus", ref fs_FileStatus, value); }
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}
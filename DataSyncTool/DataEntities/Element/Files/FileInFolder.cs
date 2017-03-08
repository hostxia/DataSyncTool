using DevExpress.Xpo;

namespace DataEntities.Element.Files
{
    [Persistent("T_FileInFolder")]
    public class FileInFolder : XPLiteObject
    {
        private BaseFile _theFile;
        private FileFolder _theFolder;
        private int fn_ID;

        public FileInFolder(Session session) : base(session)
        {
        }

        public FileInFolder() : base(Session.DefaultSession)
        {
        }

        [Key(true)]
        public int n_ID
        {
            get { return fn_ID; }
            set { SetPropertyValue<int>("n_ID", ref fn_ID, value); }
        }

        [Persistent("n_FolderID")]
        [Association("Folder-FileInFolders")]
        public FileFolder TheFolder
        {
            get { return _theFolder; }
            set { SetPropertyValue("n_FolderID", ref _theFolder, value); }
        }

        [Persistent("n_FileID")]
        [Association("File-FileInFolders")]
        public BaseFile TheFile
        {
            get { return _theFile; }
            set { SetPropertyValue("n_FileID", ref _theFile, value); }
        }


        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}
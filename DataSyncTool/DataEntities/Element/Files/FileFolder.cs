using DataEntities.Config;
using DevExpress.Xpo;

namespace DataEntities.Element.Files
{
    [Persistent("T_FileFolder")]
    public class FileFolder : XPLiteObject
    {
        /* 实体自己可以和自己建立关联。通过这种关联，可以得到某个foulder的父目录和子目录集合。
         * 例如 aFolder.ParentFolder; aFolder.SubFolders.
         * 在这个实体中没有采用这个方案。因为需要用folderid 去关联 fileinfolder 表。实现文件和目录之间的关联建立，并能查询。
         */
        //[Aggregated, Association("Folder-SubFolders", typeof(FileFolder))] 
        //public XPCollection SubFolders
        //{
        //    get { return GetCollection("SubFolders"); }
        //}

        private CodeEmployee codeEmployee;
        private int fn_FolderID;
        private int fn_UpperFolderID;
        private string fs_FolderCategory;


        private string fs_FolderName;

        public FileFolder(Session session) : base(session)
        {
        }

        public FileFolder() : base(Session.DefaultSession)
        {
        }

        [Key(true)]
        public int n_FolderID
        {
            get { return fn_FolderID; }
            set { SetPropertyValue<int>("n_FolderID", ref fn_FolderID, value); }
        }

        [Size(10)]
        [Persistent("s_FolderName")]
        public string s_FolderName
        {
            get { return fs_FolderName; }
            set { SetPropertyValue("s_FolderName", ref fs_FolderName, value); }
        }

        //private FileFolder theParentFolder;
        //[Persistent("n_UpperFolderID")]
        //[Association("Folder-SubFolders")]
        //public FileFolder TheParentFolder
        //{
        //    get { return theParentFolder; }
        //    set { SetPropertyValue<FileFolder>("n_UpperFolderID", ref theParentFolder, value); }
        //}

        [Persistent("n_UpperFolderID")]
        public int n_UpperFolderID
        {
            get { return fn_UpperFolderID; }
            set { SetPropertyValue<int>("n_UpperFolderID", ref fn_UpperFolderID, value); }
        }


        [Size(10)]
        [Persistent("s_FolderCategory")]
        public string s_FolderCategory
        {
            get { return fs_FolderCategory; }
            set { SetPropertyValue("s_FolderCategory", ref fs_FolderCategory, value); }
        }

        [Association("User-UserFoders")]
        [Persistent("n_UserID")]
        public CodeEmployee TheEmployee
        {
            get { return codeEmployee; }
            set { SetPropertyValue("n_UserID", ref codeEmployee, value); }
        }

        [Aggregated, Association("Folder-FileInFolders", typeof (FileInFolder))]
        public XPCollection FileInFolders
        {
            get { return GetCollection("FileInFolders"); }
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}
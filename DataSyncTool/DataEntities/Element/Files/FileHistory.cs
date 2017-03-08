using System;
using DevExpress.Xpo;

namespace DataEntities.Element.Files
{
    [Persistent("T_FileHistory")]
    public class FileHistory : XPLiteObject
    {
        private BaseFile fbaseFile;
        private DateTime fdt_CheckedInDate;
        private int fn_CheckedOutBy;
        private int fn_ID;
        private string fs_FilePathName;
        private string fs_Notes;
        private string fs_Version;

        public FileHistory(Session session) : base(session)
        {
        }

        public FileHistory() : base(Session.DefaultSession)
        {
        }

        [Key(true)]
        public int n_ID
        {
            get { return fn_ID; }
            set { SetPropertyValue<int>("n_ID", ref fn_ID, value); }
        }

        [Association("BaseFile-FileHistory")]
        [Persistent("n_FileID")]
        public BaseFile baseFile
        {
            get { return fbaseFile; }
            set { SetPropertyValue("n_FileID", ref fbaseFile, value); }
        }

        [Size(20)]
        public string s_Version
        {
            get { return fs_Version; }
            set { SetPropertyValue("s_Version", ref fs_Version, value); }
        }

        public int n_CheckedOutBy
        {
            get { return fn_CheckedOutBy; }
            set { SetPropertyValue<int>("n_CheckedOutBy", ref fn_CheckedOutBy, value); }
        }

        public DateTime dt_CheckedInDate
        {
            get { return fdt_CheckedInDate; }
            set { SetPropertyValue<DateTime>("dt_CheckedInDate", ref fdt_CheckedInDate, value); }
        }

        [Size(300)]
        public string s_Notes
        {
            get { return fs_Notes; }
            set { SetPropertyValue("s_Notes", ref fs_Notes, value); }
        }

        [Size(500)]
        public string s_FilePathName
        {
            get { return fs_FilePathName; }
            set { SetPropertyValue("s_FilePathName", ref fs_FilePathName, value); }
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}
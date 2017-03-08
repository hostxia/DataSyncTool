using System;
using DevExpress.Xpo;

namespace DataEntities.Element.Files
{
    [Persistent("T_LawItem")]
    public class LawItem : XPLiteObject
    {
        private int fn_ID;
        private string fs_Code;
        private string fs_FilePath;
        private string fs_Creator;
        private DateTime fdt_CreateDate;
        private InFile inFile;

        [Key(true)]
        public int n_ID
        {
            get { return fn_ID; }
            set { SetPropertyValue<int>("n_ID", ref fn_ID, value); }
        }

        [Size(50)]
        public string s_Code
        {
            get { return fs_Code; }
            set { SetPropertyValue("s_Code", ref fs_Code, value); }
        }

        [Size(500)]
        public string s_FilePath
        {
            get { return fs_FilePath; }
            set { SetPropertyValue("s_FilePath", ref fs_FilePath, value); }
        }

        [Size(50)]
        public string s_Creator
        {
            get { return fs_Creator; }
            set { SetPropertyValue("s_Creator", ref fs_Creator, value); }
        }

        public DateTime dt_CreateDate
        {
            get { return fdt_CreateDate; }
            set { SetPropertyValue<DateTime>("dt_CreateDate", ref fdt_CreateDate, value); }
        }

        [Persistent("n_FileID"), Association("InFile-LawItems")]
        public InFile TheInFile
        {
            get { return inFile; }
            set { SetPropertyValue("n_FileID", ref inFile, value); }
        }

        [Aggregated, Association("LawItem-LawItemParas")]
        public XPCollection<LawItemPara> LawItemParas
        {
            get { return GetCollection<LawItemPara>("LawItemParas"); }
        }

        public LawItem(Session session)
            : base(session)
        {
        }

        public LawItem()
            : base(Session.DefaultSession)
        {
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}
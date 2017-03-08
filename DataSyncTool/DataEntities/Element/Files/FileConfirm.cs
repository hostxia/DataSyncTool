using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataEntities.Config;
using DevExpress.Xpo;

namespace DataEntities.Element.Files
{
    [Persistent("T_FileConfirm")]
    public class FileConfirm : XPLiteObject
    {
        int fn_ID;
        [Key(true)]
        public int n_ID
        {
            get { return fn_ID; }
            set { SetPropertyValue<int>("n_ID", ref fn_ID, value); }
        }

        private InFile inFile;
        [Persistent("n_FilesID"), Association("InFile-FileConfirms")]
        public InFile TheInFile
        {
            get { return inFile; }
            set { SetPropertyValue("n_FilesID", ref inFile, value); }
        }

        int fn_DistributerID;
        public int n_DistributerID
        {
            get { return fn_DistributerID; }
            set { SetPropertyValue<int>("n_DistributerID", ref fn_DistributerID, value); }
        }

        int fn_ConfirmorID;
        public int n_ConfirmorID
        {
            get { return fn_ConfirmorID; }
            set { SetPropertyValue<int>("n_ConfirmorID", ref fn_ConfirmorID, value); }
        }
        
        string fs_Status;
        [Size(2)]
        public string s_Status
        {
            get { return fs_Status; }
            set { SetPropertyValue<string>("s_Status", ref fs_Status, value); }
        }

        DateTime fdt_ConfirmDate;
        public DateTime dt_ConfirmDate
        {
            get { return fdt_ConfirmDate; }
            set { SetPropertyValue<DateTime>("dt_ConfirmDate", ref fdt_ConfirmDate, value); }
        }

        string fs_Complete;
        [Size(2)]
        public string s_Complete
        {
            get { return fs_Complete; }
            set { SetPropertyValue<string>("s_Complete", ref fs_Complete, value); }
        }

        private string fs_DistributeType;
        [Size(2)]
        public string s_DistributeType
        {
            get { return fs_DistributeType; }
            set { SetPropertyValue<string>("s_DistributeType", ref fs_DistributeType, value); }
        }

        /// <summary>
        ///     保存新建时候的临时字段
        /// </summary>
        [NonPersistent]
        public string sStatus
        {
            get
            {
                return (s_Status == "Y") ? "已确收" : "未确收";
            }
        }
        [Aggregated, Association("File-FileConfirmOpinion")]
        public XPCollection<FileConfirmOpinion> FileConfirmOpinions
        {
            get { return GetCollection<FileConfirmOpinion>("FileConfirmOpinions"); }
        }
        public FileConfirm(Session session) : base(session) { }
        public FileConfirm() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }

        public string Opinion
        {
            get { return string.Join(",", FileConfirmOpinions.Where(p => p.TheConfirmOpinion != null).Select(f => f.TheConfirmOpinion.n_ID)); }
        }
    }
}

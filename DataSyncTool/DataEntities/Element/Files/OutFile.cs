using System;
using System.IO;
using DataEntities.Config.Check.Info;
using DataEntities.Contact.Agency;
using DataEntities.Contact.Client;
using DataEntities.Element.Tasks;
using DataEntities.Finance.ClaimMoney;
using DevExpress.Xpo;

namespace DataEntities.Element.Files
{
    [MapInheritance(MapInheritanceType.OwnTable)]
    [Persistent("T_OutFiles")]
    public class OutFile : BaseFile
    {
        private Agency agency;
        private Client client;
        private string fS_Version;
        private DateTime fdt_StatusDate;
        private DateTime fdt_SubmitDate;
        private DateTime fdt_SubmitDueDate;
        private DateTime fdt_WriteDate;
        private int fn_CheckedOutBy;
        private int fn_Count;
        private int fn_GovOfficeID;
        private int fn_LatestCheckInfoID;
        private int fn_PageNum;
        private int fn_PrintNum;
        private int fn_ReFileID;
        private int fn_SubmiterID;
        private int fn_WriterID;

        private string fs_CheckedOut;
        private string fs_CheckedOutPath;
        private string fs_ElectronicCode;
        private string fs_FileStatus;
        private string fs_FileType;
        private string fs_OfficialCode;

        public OutFile(Session session) : base(session)
        {
        }

        public OutFile() : base(Session.DefaultSession)
        {
        }

        [Size(20)]
        public string s_Version
        {
            get { return fS_Version; }
            set { SetPropertyValue("s_Version", ref fS_Version, value); }
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

        [Association("Agency-OutFile")]
        [Persistent("n_AgencyID")]
        public Agency TheAgency
        {
            get { return agency; }
            set { SetPropertyValue("n_AgencyID", ref agency, value); }
        }

        public int n_GovOfficeID
        {
            get { return fn_GovOfficeID; }
            set { SetPropertyValue<int>("n_GovOfficeID", ref fn_GovOfficeID, value); }
        }

        [Size(1)]
        public string s_FileStatus
        {
            get { return fs_FileStatus; }
            set { SetPropertyValue("s_FileStatus", ref fs_FileStatus, value); }
        }

        public DateTime dt_StatusDate
        {
            get { return fdt_StatusDate; }
            set { SetPropertyValue<DateTime>("dt_StatusDate", ref fdt_StatusDate, value); }
        }

        public DateTime dt_WriteDate
        {
            get { return fdt_WriteDate; }
            set { SetPropertyValue<DateTime>("dt_WriteDate", ref fdt_WriteDate, value); }
        }

        public int n_WriterID
        {
            get { return fn_WriterID; }
            set { SetPropertyValue<int>("n_WriterID", ref fn_WriterID, value); }
        }

        public DateTime dt_SubmitDate
        {
            get { return fdt_SubmitDate; }
            set { SetPropertyValue<DateTime>("dt_SubmitDate", ref fdt_SubmitDate, value); }
        }

        public int n_SubmiterID
        {
            get { return fn_SubmiterID; }
            set { SetPropertyValue<int>("n_SubmiterID", ref fn_SubmiterID, value); }
        }

        public DateTime dt_SubmitDueDate
        {
            get { return fdt_SubmitDueDate; }
            set { SetPropertyValue<DateTime>("dt_SubmitDueDate", ref fdt_SubmitDueDate, value); }
        }

        [Size(50)]
        public string s_OfficialCode
        {
            get { return fs_OfficialCode; }
            set { SetPropertyValue("s_OfficialCode", ref fs_OfficialCode, value); }
        }

        [Size(20)]
        public string s_ElectronicCode
        {
            get { return fs_ElectronicCode; }
            set { SetPropertyValue("s_ElectronicCode", ref fs_ElectronicCode, value); }
        }

        public int n_PrintNum
        {
            get { return fn_PrintNum; }
            set { SetPropertyValue<int>("n_PrintNum", ref fn_PrintNum, value); }
        }

        public int n_PageNum
        {
            get { return fn_PageNum; }
            set { SetPropertyValue<int>("n_PageNum", ref fn_PageNum, value); }
        }

        public int n_ReFileID
        {
            get { return fn_ReFileID; }
            set { SetPropertyValue<int>("n_ReFileID", ref fn_ReFileID, value); }
        }

        public int n_Count
        {
            get { return fn_Count; }
            set { SetPropertyValue<int>("n_Count", ref fn_Count, value); }
        }

        public string s_FileType
        {
            get { return fs_FileType; }
            set { SetPropertyValue("s_FileType", ref fs_FileType, value); }
        }
        
        public int n_LatestCheckInfoID
        {
            get { return fn_LatestCheckInfoID; }
            set { SetPropertyValue<int>("n_LatestCheckInfoID", ref fn_LatestCheckInfoID, value); }
        }

        /// <summary>
        ///     提醒用户提交文件的强度标识
        /// </summary>
        public int Warning
        {
            get
            {
                if (DateTime.Now > dt_SubmitDueDate)
                {
                    return 0; //过期
                }
                if (DateTime.Now.AddDays(-2) > dt_SubmitDueDate) //todo
                {
                    return 2; //严重过期
                }
                if (DateTime.Now.AddDays(-5) > dt_SubmitDueDate)
                {
                    return 1; //进入警告
                }
                //if (ServerDate.ValidateDateTime(dt_ReceiveDate) == "")
                //{
                //    return 3; //未登回执
                //}
                return -1;
            }
        }

        /// <summary>
        ///     签出的状态
        /// </summary>
        [NonPersistent]
        public string CheckOutStatus
        {
            get
            {
                if (string.IsNullOrEmpty(s_FilePathName) ||
                    string.IsNullOrEmpty(Path.GetExtension(s_FilePathName)))
                {
                    return "None"; //新建文件或者没有电子件时，就不需要显示文件状态和文件版本了。
                }

                if (s_CheckedOut == null || s_CheckedOut.ToUpper() == "N")
                {
                    return "N";
                }
                if (s_CheckedOut.ToUpper() == "Y")
                {
                    return "Y";
                }
                return "None";
            }
        }

        [NonPersistent]
        public bool b_Select { get; set; }

        [NonPersistent]
        public string s_TempPdfPath { get; set; }

        [Association("Outfile-Tasks", typeof (Task))]
        public XPCollection GetTasks
        {
            get { return GetCollection("GetTasks"); }
        }

        [Association("Task-OutFile", typeof (Task))]
        public XPCollection Tasks
        {
            get { return GetCollection("Tasks"); }
        }

        [Aggregated, Association("File-SubmitListInFile", typeof (SubmitListInFile))]
        public XPCollection FileInSubmitList
        {
            get { return GetCollection("FileInSubmitList"); }
        }

        [Aggregated, Association("OutFile-OutFileChecks")]
        public XPCollection<OutFileChecks> OutFileChecks
        {
            get { return GetCollection<OutFileChecks>("OutFileChecks"); }
        }

        [Aggregated, Association("OutFile-ClaimMoney", typeof(ClaimMoney))]
        public XPCollection ClaimMoneys
        {
            get { return GetCollection("ClaimMoneys"); }
        }

        [Aggregated, Association("EmailOutFile-ClaimMoney", typeof(ClaimMoney))]
        public XPCollection ClaimMoneyEmails
        {
            get { return GetCollection("ClaimMoneyEmails"); }
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}
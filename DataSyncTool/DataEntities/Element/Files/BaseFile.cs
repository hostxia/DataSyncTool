using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using DataEntities.Case;
using DataEntities.Case.Patents;
using DataEntities.Case.Trademarks;
using DataEntities.Config;
using DataEntities.Contact.Client;
using DataEntities.Properties;
using DataEntities.TaskFlowData;
using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using LawInfo = DataEntities.Case.Patents.LawInfo;

namespace DataEntities.Element.Files
{
    [Persistent("T_MainFiles")]
    public class BaseFile : XPLiteObject
    {
        private DateTime fdt_CreateDate;
        private DateTime fdt_EditDate;
        private DateTime fdt_ReceiveDate;
        private DateTime fdt_SendDate;
        private int fn_FileID;
        private int fn_MainCaseID;
        private int fn_ProcessID;
        private int fn_CreatorID;
        private int fn_TemplateID;
        private string fs_Abstact;
        private string fs_ClientGov;
        private string fs_Creator;
        private string fs_Editor;
        private string fs_FilePathName;
        private string fs_IOType;
        private string fs_IsActive;
        private string fs_Name;
        private string fs_Status;
        private string fs_SendMethod;
        private int fn_FlowNum;
        private string fs_InfileFlowNum;
        private string fs_IsNewCaseInFile;
        private int fn_NumCount;
        private int fn_PicCount;
        private string fs_IPType;

        public BaseFile(Session session)
            : base(session)
        {
        }

        public BaseFile()
            : base(Session.DefaultSession)
        {
        }

        [Key(true)]
        public int n_FileID
        {
            get { return fn_FileID; }
            set { SetPropertyValue<int>("n_FileID", ref fn_FileID, value); }
        }

        [Size(1)]
        public string s_IPType
        {
            get { return fs_IPType; }
            set { SetPropertyValue("s_IPType", ref fs_IPType, value); }
        }

        [Size(50)]
        public string s_SendMethod
        {
            get { return fs_SendMethod; }
            set { SetPropertyValue("s_SendMethod", ref fs_SendMethod, value); }
        }
        public int n_FlowNum
        {
            get { return fn_FlowNum; }
            set { SetPropertyValue<int>("n_FlowNum", ref fn_FlowNum, value); }
        }
        public string s_InfileFlowNum
        {
            get { return fs_InfileFlowNum; }
            set { SetPropertyValue("s_InfileFlowNum", ref fs_InfileFlowNum, value); }
        }
        [Size(400)]
        public string s_Name
        {
            get { return fs_Name; }
            set { SetPropertyValue("s_Name", ref fs_Name, value); }
        }

        private string fs_NameForeign;
        [Size(400)]
        public string s_NameForeign
        {
            get { return fs_NameForeign; }
            set { SetPropertyValue("s_NameForeign", ref fs_NameForeign, value); }
        }
        public string s_Status
        {
            get { return fs_Status; }
            set { SetPropertyValue("s_Status", ref fs_Status, value); }
        }
        [Size(200)]
        public string s_Abstact
        {
            get { return fs_Abstact; }
            set { SetPropertyValue("s_Abstact", ref fs_Abstact, value); }
        }

        [Size(500)]
        public string s_FilePathName
        {
            get { return fs_FilePathName; }
            set { SetPropertyValue("s_FilePathName", ref fs_FilePathName, value); }
        }


        [Size(10)]
        [Persistent("s_IOType")]
        public string s_IOType
        {
            get { return fs_IOType; }
            set { SetPropertyValue("s_IOType", ref fs_IOType, value); }
        }

        public string IOType
        {
            get
            {
                if (string.IsNullOrEmpty(fs_IOType))
                {
                    return "";
                }

                if (fs_IOType.ToUpper() == "I")
                {
                    return Resource.FileIOType_In;
                }
                if (fs_IOType.ToUpper() == "O")
                {
                    return Resource.FileIOType_Out;
                }
                return Resource.FileIOType_Other;
            }
        }


        [Size(10)]
        [Persistent("s_ClientGov")]
        public string s_ClientGov
        {
            get { return fs_ClientGov; }
            set { SetPropertyValue("s_ClientGov", ref fs_ClientGov, value); }
        }

        public string ClientGov
        {
            get
            {
                if (string.IsNullOrEmpty(fs_ClientGov))
                {
                    return "";
                }

                if (fs_ClientGov.ToUpper() == "C")
                {
                    return Resource.FileClientGov_Client;
                }
                if (fs_ClientGov.ToUpper() == "O")
                {
                    return Resource.FileClientGov_Officical;
                }
                return Resource.FileClientGov_Other;
            }
        }
        public string s_IsNewCaseInFile
        {
            get { return fs_IsNewCaseInFile; }
            set { SetPropertyValue("s_IsNewCaseInFile", ref fs_IsNewCaseInFile, value); }
        }
        public int n_MainCaseID
        {
            get { return fn_MainCaseID; }
            set { SetPropertyValue<int>("n_MainCaseID", ref fn_MainCaseID, value); }
        }

        public int n_ProcessID
        {
            get { return fn_ProcessID; }
            set { SetPropertyValue<int>("n_ProcessID", ref fn_ProcessID, value); }
        }

        public int n_CreatorID
        {
            get { return fn_CreatorID; }
            set { SetPropertyValue<int>("n_CreatorID", ref fn_CreatorID, value); }
        }

        public DateTime dt_SendDate
        {
            get { return fdt_SendDate; }
            set { SetPropertyValue<DateTime>("dt_SendDate", ref fdt_SendDate, value); }
        }

        public DateTime dt_ReceiveDate
        {
            get { return fdt_ReceiveDate; }
            set { SetPropertyValue<DateTime>("dt_ReceiveDate", ref fdt_ReceiveDate, value); }
        }

        public DateTime dt_CreateDate
        {
            get { return fdt_CreateDate; }
            set { SetPropertyValue<DateTime>("dt_CreateDate", ref fdt_CreateDate, value); }
        }

        public DateTime dt_EditDate
        {
            get { return fdt_EditDate; }
            set { SetPropertyValue<DateTime>("dt_EditDate", ref fdt_EditDate, value); }
        }

        [Size(50)]
        public string s_Creator
        {
            get { return fs_Creator; }
            set { SetPropertyValue("s_Creator", ref fs_Creator, value); }
        }

        [Size(50)]
        public string s_Editor
        {
            get { return fs_Editor; }
            set { SetPropertyValue("s_Editor", ref fs_Editor, value); }
        }

        public int n_TemplateID
        {
            get { return fn_TemplateID; }
            set { SetPropertyValue<int>("n_TemplateID", ref fn_TemplateID, value); }
        }

        [Size(1)]
        [Persistent("s_IsActive")]
        public string s_IsActive
        {
            get { return fs_IsActive; }
            set { SetPropertyValue("s_IsActive", ref fs_IsActive, value); }
        }

        public string IsActive
        {
            get
            {
                if (string.IsNullOrEmpty(fs_IsActive))
                {
                    return "";
                }

                if (fs_IsActive.ToUpper() == "Y")
                {
                    return Resource.FileActive_Active;
                }
                return Resource.FileActive_NotActive;
            }
        }

        private string fs_ClientType;
        [Size(1)]
        public string s_ClientType
        {
            get { return fs_ClientType; }
            set { SetPropertyValue("s_ClientType", ref fs_ClientType, value); }
        }

        public int CaseCount
        {
            get { return FileInCases.Count; }
        }

        [Aggregated, Association("File-FileInCases")]
        public XPCollection<FileInCase> FileInCases
        {
            get { return GetCollection<FileInCase>("FileInCases"); }
        }

        [Aggregated, Association("FileConn-NewFile")]
        public XPCollection<OrigRenewFileConn> OrigNewFileConns
        {
            get { return GetCollection<OrigRenewFileConn>("OrigNewFileConns"); }
        }

        [Aggregated, Association("File-FileInFolders", typeof(FileInFolder))]
        public XPCollection FileInFolders
        {
            get { return GetCollection("FileInFolders"); }
        }

        [Aggregated, Association("File-SubmitListInFee", typeof(SubmitListInFee))]
        public XPCollection SubmitListInFees
        {
            get { return GetCollection("SubmitListInFees"); }
        }
        /// <summary>
        ///     保存新建时候的临时字段
        /// </summary>
        [NonPersistent]
        public string sStatus
        {
            get
            {
                if (s_Status == "Y")
                {
                    return "已确收";

                }
                else if (s_Status == "P")
                {
                    return "部分确收";
                }
                else
                {
                    return "未确收";
                }
            }
        }
        [Delayed]
        public int GetMainCaseID
        {
            get
            {
                if (FileInCases.Count >= 1)
                {
                    FileInCase fileInCase = null;
                    FileInCases.Filter = CriteriaOperator.Parse("s_IsMainCase = 'Y'");
                    if (FileInCases.Count > 0)
                    {
                        fileInCase = (FileInCase)FileInCases[0];
                    }
                    FileInCases.Filter = CriteriaOperator.Parse("1 = 1");
                    if (fileInCase == null || fileInCase.TheCase == null) return 0;
                    return fileInCase.TheCase.n_CaseID;
                }
                return 0;
            }
        }

        /// <summary>
        ///     获取主相关案件的案件名称
        /// </summary>
        /// \
        [Delayed]
        public string sMainCaseName
        {
            get
            {
                if (FileInCases.Count >= 1)
                {
                    FileInCase fileInCase = null;
                    FileInCases.Filter = CriteriaOperator.Parse("s_IsMainCase = 'Y'");
                    if (FileInCases.Count > 0)
                    {
                        fileInCase = (FileInCase)FileInCases[0];
                    }
                    FileInCases.Filter = CriteriaOperator.Parse("1 = 1");
                    if (fileInCase == null || fileInCase.TheCase == null) return "";
                    return fileInCase.TheCase.s_CaseName;
                }
                return "";
            }
        }

        /// <summary>
        ///     获取主相关案件的我方文号
        /// </summary>
        [Delayed]
        public string sMainCaseSerial
        {
            get
            {
                if (FileInCases.Count >= 1)
                {
                    FileInCase fileInCase = null;
                    FileInCases.Filter = CriteriaOperator.Parse("s_IsMainCase = 'Y'");
                    if (FileInCases.Count > 0)
                    {
                        fileInCase = (FileInCase)FileInCases[0];
                    }
                    FileInCases.Filter = CriteriaOperator.Parse("1 = 1");
                    if (fileInCase == null) return "";
                    if (fileInCase.TheCase == null) return "";
                    return fileInCase.TheCase.s_CaseSerial;
                }
                return "";
            }
        }

        /// <summary>
        ///     获取主相关案件的官方名称
        /// </summary>
        [Delayed]
        public int sMainCaseOfficeName
        {
            get
            {
                if (FileInCases.Count >= 1)
                {
                    FileInCase fileInCase = null;
                    FileInCases.Filter = CriteriaOperator.Parse("s_IsMainCase = 'Y'");
                    if (FileInCases.Count > 0)
                    {
                        fileInCase = (FileInCase)FileInCases[0];
                    }
                    FileInCases.Filter = CriteriaOperator.Parse("1 = 1");
                    if (fileInCase == null) return 0;
                    if (fileInCase.TheCase == null) return 0;
                    return fileInCase.TheCase.n_OfficeID;
                }
                return 0;
            }
        }

        /// <summary>
        ///     获取主相关案件的对方文号
        /// </summary>
        [Delayed]
        public string sMainCaseClientSerial
        {
            get
            {
                if (FileInCases.Count >= 1)
                {
                    FileInCase fileInCase = null;
                    FileInCases.Filter = CriteriaOperator.Parse("s_IsMainCase = 'Y'");
                    if (FileInCases.Count > 0)
                    {
                        fileInCase = (FileInCase)FileInCases[0];
                    }
                    FileInCases.Filter = CriteriaOperator.Parse("1 = 1");
                    if (fileInCase == null) return "";
                    if (fileInCase.TheCase == null) return "";
                    return fileInCase.TheCase.s_ClientSerial;
                }
                return "";
            }
        }

        /// <summary>
        ///     文件的对应的案件的案件名称
        /// </summary>
        [Delayed]
        public string sCaseName
        {
            get
            {
                if (FileInCases.Count >= 1)
                {
                    FileInCase fileInCase = null;
                    FileInCases.Filter = CriteriaOperator.Parse("s_IsMainCase = 'Y'");
                    if (FileInCases.Count > 0)
                    {
                        fileInCase = (FileInCase)FileInCases[0];
                    }
                    FileInCases.Filter = CriteriaOperator.Parse("1 = 1");
                    if (fileInCase == null) return "";
                    var sTmp = new StringBuilder();
                    sTmp.Append(fileInCase.TheCase == null ? string.Empty : fileInCase.TheCase.s_CaseName);
                    if (FileInCases.Count > 1)
                    {
                        sTmp.Append("...");
                    }
                    return sTmp.ToString();
                }
                return "";
            }
        }

        /// <summary>
        ///     文件的对应的案件的客户名称
        /// </summary>
        [Delayed]
        public string sClientName
        {
            get
            {
                if (FileInCases.Count >= 1)
                {
                    var sTmp = new StringBuilder();
                    var fileInCase = (FileInCase)FileInCases[0];
                    if (fileInCase.TheCase != null && fileInCase.TheCase.TheClient != null)
                    {
                        sTmp.Append(fileInCase.TheCase.TheClient.s_Name);
                        if (FileInCases.Count > 1)
                        {
                            sTmp.Append("...");
                        }
                    }
                    return sTmp.ToString();
                }
                return "";
            }
        }

        /// <summary>
        ///     案件文号
        /// </summary>
        [Delayed]
        public string sCaseSerials
        {
            get
            {
                if (FileInCases.Count >= 1)
                {
                    FileInCase fileInCase = null;
                    FileInCases.Filter = CriteriaOperator.Parse("s_IsMainCase = 'Y'");
                    if (FileInCases.Count > 0)
                    {
                        fileInCase = (FileInCase)FileInCases[0];
                    }
                    FileInCases.Filter = CriteriaOperator.Parse("1 = 1");
                    if (fileInCase == null || fileInCase.TheCase == null) return "";
                    return fileInCase.TheCase.s_CaseSerial;
                }
                return "";
            }
        }

        [Delayed]
        public string AppNo
        {
            get
            {
                if (FileInCases.Count >= 1)
                {
                    FileInCase fileInCase = null;
                    FileInCases.Filter = CriteriaOperator.Parse("s_IsMainCase = 'Y'");
                    if (FileInCases.Count > 0)
                    {
                        fileInCase = (FileInCase)FileInCases[0];
                    }
                    FileInCases.Filter = CriteriaOperator.Parse("1 = 1");
                    if (fileInCase == null || fileInCase.TheCase == null) return "";
                    if (fileInCase.TheCase.s_IPType == "P")
                    {
                        LawInfo lawInfo = ((ExtendedPatent)fileInCase.TheCase).TheLawInfo;
                        return lawInfo == null ? string.Empty : lawInfo.s_AppNo;
                    }
                    if (fileInCase.TheCase.s_IPType == "T")
                    {
                        Case.Trademarks.LawInfo lawInfo = ((ExtendedTrademark)fileInCase.TheCase).TheLawInfo;
                        return lawInfo == null ? string.Empty : lawInfo.s_AppNo;
                    }
                }
                return "";
            }
        }

        /// <summary>
        ///     案件的程序
        ///     coder:zhangjiechen(2010-8-4)
        /// </summary>
        [Delayed]
        public string sCaseProcess
        {
            get
            {
                string sReturn = "";
                if (FileInCases.Count >= 1)
                {
                    FileInCase fileInCase = null;
                    FileInCases.Filter = CriteriaOperator.Parse("s_IsMainCase = 'Y'");
                    if (FileInCases.Count > 0)
                    {
                        fileInCase = (FileInCase)FileInCases[0];
                    }
                    FileInCases.Filter = CriteriaOperator.Parse("1 = 1");
                    if (fileInCase == null) return sReturn;
                    if (fileInCase.TheProcess != null)
                    {
                        CodeProcess codeProcess = fileInCase.TheProcess.TheCodeProcess;
                        if (codeProcess != null)
                        {
                            sReturn = codeProcess.s_Name;
                        }
                    }
                }
                return sReturn;
            }
        }

        /// <summary>
        ///     判断文件是是什么类型的文件
        ///     coder:zhangjiechen(2010-09-06)
        /// </summary>
        public string sFile
        {
            get
            {
                if (!string.IsNullOrEmpty(s_FilePathName))
                {
                    string sExtension = Path.GetExtension(s_FilePathName);
                    if (string.IsNullOrEmpty(sExtension)) return "nofile";
                    string sExtensionWithOutPoint = sExtension.TrimStart('.');
                    switch (sExtensionWithOutPoint.ToLower())
                    {
                        case "doc":
                        case "docx":
                            return "word";
                        case "xls":
                        case "xlsx":
                            return "excel";
                        case "txt":
                            return "txt";
                        case "pdf":
                            return "pdf";
                        case "msg":
                        case "eml":
                            return "mail";
                        default:
                            return "other";
                    }
                }
                return "nofile";
            }
        }

        private string fs_ManualCreateChain;
        [Size(1)]
        public string s_ManualCreateChain
        {
            get { return fs_ManualCreateChain; }
            set { SetPropertyValue("s_ManualCreateChain", ref fs_ManualCreateChain, value); }
        }

        /// <summary>
        ///     临时字段 存放文件的路径（文件被拖拽进软件时候文件的路径）
        ///     coder:zhangjiechen(2010-09-06)
        /// </summary>
        [NonPersistent]
        public string sDragFilePath { get; set; }

        [NonPersistent]
        public bool Check { get; set; }

        [Aggregated, Association("BaseFile-FileHistory", typeof(FileHistory))]
        public XPCollection FileHistorys
        {
            get { return GetCollection("FileHistorys"); }
        }


        #region 邮件相关

        private string fs_From;
        [Size(1000)]
        public string s_From
        {
            get { return fs_From; }
            set { SetPropertyValue("s_From", ref fs_From, value); }
        }

        private string fs_To;
        [Size(3000)]
        public string s_To
        {
            get { return fs_To; }
            set { SetPropertyValue("s_To", ref fs_To, value); }
        }

        private string fs_Cc;
        [Size(3000)]
        public string s_Cc
        {
            get { return fs_Cc; }
            set { SetPropertyValue("s_Cc", ref fs_Cc, value); }
        }

        private string fs_Bc;
        [Size(3000)]
        public string s_Bc
        {
            get { return fs_Bc; }
            set { SetPropertyValue("s_Bc", ref fs_Bc, value); }
        }

        private Client client;
        [Association("Client-BaseFile")]
        [Persistent("n_ClientID")]
        public Client TheClient
        {
            get { return client; }
            set { SetPropertyValue("n_ClientID", ref client, value); }
        }

        private Contact.Applicant.Applicant applicant;
        [Association("Applicant-BaseFile")]
        [Persistent("n_ApplicantID")]
        public Contact.Applicant.Applicant TheApplicant
        {
            get { return applicant; }
            set { SetPropertyValue("n_ApplicantID", ref applicant, value); }
        }


        private Client fileCLient;
        [Association("FileCLient-ClientFile")]
        [Persistent("n_FileClientID")]
        public Client TheFileClient
        {
            get { return fileCLient; }
            set { SetPropertyValue("n_FileClientID", ref fileCLient, value); }
        }

        private Contact.Applicant.Applicant fileApplicant;
        [Association("FileApplicant-ApplicantFile")]
        [Persistent("n_FileApplicantID")]
        public Contact.Applicant.Applicant TheFileApplicant
        {
            get { return fileApplicant; }
            set { SetPropertyValue("n_FileApplicantID", ref fileApplicant, value); }
        }
        #endregion

        #region 触发器字段

        private DateTime fdt_AppDate;
        private DateTime fdt_PubDate;
        private string fs_AppNo;
        private string fs_Applicants;
        private string fs_Attorney;
        private string fs_CaseSerial;
        private string fs_Introducer;
        private string fs_Inventors;
        private string fs_PubNo;

        [Size(50)]
        public string s_CaseSerial
        {
            get { return fs_CaseSerial; }
            set { SetPropertyValue("s_CaseSerial", ref fs_CaseSerial, value); }
        }

        [Size(50)]
        public string s_AppNo
        {
            get { return fs_AppNo; }
            set { SetPropertyValue("s_AppNo", ref fs_AppNo, value); }
        }

        public DateTime dt_AppDate
        {
            get { return fdt_AppDate; }
            set { SetPropertyValue<DateTime>("dt_AppDate", ref fdt_AppDate, value); }
        }

        [Size(50)]
        public string s_PubNo
        {
            get { return fs_PubNo; }
            set { SetPropertyValue("s_PubNo", ref fs_PubNo, value); }
        }

        public DateTime dt_PubDate
        {
            get { return fdt_PubDate; }
            set { SetPropertyValue<DateTime>("dt_PubDate", ref fdt_PubDate, value); }
        }

        [Size(1000)]
        public string s_Applicants
        {
            get { return fs_Applicants; }
            set { SetPropertyValue("s_Applicants", ref fs_Applicants, value); }
        }

        [Size(1000)]
        public string s_Introducer
        {
            get { return fs_Introducer; }
            set { SetPropertyValue("s_Introducer", ref fs_Introducer, value); }
        }

        [Size(1000)]
        public string s_Inventors
        {
            get { return fs_Inventors; }
            set { SetPropertyValue("s_Inventors", ref fs_Inventors, value); }
        }

        [Size(1000)]
        public string s_Attorney
        {
            get { return fs_Attorney; }
            set { SetPropertyValue("s_Attorney", ref fs_Attorney, value); }
        }

        #endregion

        #region 方法

        ///// ############################################
        ///// <summary>
        /////     获取撰写收文日期中文格式，带年月日
        /////     coder: Kevin Wang(2010-10-12)
        ///// </summary>
        ///// <returns>收文日期</returns>
        //public string GetReceiveDateCN()
        //{
        //    return ServerDate.GetDateInCNFormat(dt_SendDate);
        //}

        ///// ############################################
        ///// <summary>
        /////     获取撰写收文日期外文格式，带年月日
        /////     coder: Kevin Wang(2010-10-12)
        ///// </summary>
        ///// <returns>收文日期</returns>
        //public string GetReceiveDateEN()
        //{
        //    return ServerDate.GetDateInENFormat(dt_SendDate);
        //}

        ///// ############################################
        ///// <summary>
        /////     获取撰写收文日期中文格式，带年月日
        /////     coder: Kevin Wang(2010-10-12)
        ///// </summary>
        ///// <returns>收文日期</returns>
        //public string GetReceiveDateCN1()
        //{
        //    return ServerDate.GetDateInCNFormat(dt_ReceiveDate);
        //}

        ///// ############################################
        ///// <summary>
        /////     获取撰写收文日期外文格式，带年月日
        /////     coder: Kevin Wang(2010-10-12)
        ///// </summary>
        ///// <returns>收文日期</returns>
        //public string GetReceiveDateEN1()
        //{
        //    return ServerDate.GetDateInENFormat(dt_ReceiveDate);
        //}

        ///// ############################################
        ///// <summary>
        /////     获取撰写发文日期中文格式，带年月日
        /////     coder: Kevin Wang(2010-10-12)
        ///// </summary>
        ///// <returns>发文日期</returns>
        //public string GetSendDateCN()
        //{
        //    return ServerDate.GetDateInCNFormat(dt_SendDate);
        //}

        ///// ############################################
        ///// <summary>
        /////     获取撰写发文日期外文格式，带年月日
        /////     coder: Kevin Wang(2010-10-12)
        ///// </summary>
        ///// <returns>发文日期</returns>
        //public string GetSendDateEN()
        //{
        //    return ServerDate.GetDateInENFormat(dt_SendDate);
        //}

        #endregion

        #region 高级查询所用的特殊字段

        /// <summary>
        ///     来文的主案件，高级查询使用
        /// </summary>
        [Delayed]
        public BasicCase TheMainCase
        {
            get
            {
                return (from FileInCase fileInCase in FileInCases
                        where fileInCase != null
                        where fileInCase.s_IsMainCase == "Y"
                        select fileInCase.TheCase).FirstOrDefault();
                return null;
            }
        }

        [Delayed]
        public Process TheMainProcess
        {
            get
            {
                return (from FileInCase fileInCase in FileInCases
                        where fileInCase != null
                        where fileInCase.s_IsMainCase == "Y"
                        select fileInCase.TheProcess).FirstOrDefault();
            }
        }

        /// <summary>
        ///     申请号，高级查询使用
        /// </summary>
        [Delayed]
        public string CaseAppNo
        {
            get
            {
                if ((TheMainCase as ExtendedPatent) != null) return (TheMainCase as ExtendedPatent).TheLawInfo.s_AppNo;
                return (TheMainCase as ExtendedTrademark) != null
                    ? (TheMainCase as ExtendedTrademark).TheLawInfo.s_AppNo
                    : string.Empty;
            }
        }

        #endregion

        public List<TFTaskChain> GetRelateTaskChains()
        {
            var uow = new UnitOfWork();
            var list = new XPCollection<TFTaskChain>(uow, CriteriaOperator.Parse("s_RelatedObjectType='CameFileOfficial' AND n_RelatedObjectID = ?", n_FileID)).ToList();
            return list;
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }

        #region Common Method For Update

        protected List<ConmonFunctionForUpdate.MonitorField> _listBeMonitorField;
        protected XPLiteObject _xplCopyOfObject;

        protected override void OnLoaded()
        {
            base.OnLoaded();
            _listBeMonitorField = new List<ConmonFunctionForUpdate.MonitorField>
            {
                new ConmonFunctionForUpdate.MonitorField{MonitorType = ConmonFunctionForUpdate.EnumMonitorType.Deadline,FieldName = "dt_TransmitDate",CodeNameSpace = "DataEntities.Element.Files.InFile",CodeFieldName = "dt_TransmitDate"},
                new ConmonFunctionForUpdate.MonitorField{MonitorType = ConmonFunctionForUpdate.EnumMonitorType.Deadline,FieldName = "dt_GetCertificatedate",CodeNameSpace = "DataEntities.Element.Files.InFile",CodeFieldName = "dt_GetCertificatedate"},
                new ConmonFunctionForUpdate.MonitorField{MonitorType = ConmonFunctionForUpdate.EnumMonitorType.Deadline,FieldName = "dt_ReceiveDate",CodeNameSpace = "DataEntities.Element.Files.BaseFile",CodeFieldName = "dt_ReceiveDate"},
                new ConmonFunctionForUpdate.MonitorField{MonitorType = ConmonFunctionForUpdate.EnumMonitorType.Deadline,FieldName = "dt_SendDate",CodeNameSpace = "DataEntities.Element.Files.BaseFile",CodeFieldName = "dt_SendDate"},
                new ConmonFunctionForUpdate.MonitorField{MonitorType = ConmonFunctionForUpdate.EnumMonitorType.Deadline,FieldName = "dt_CreateDate",CodeNameSpace = "DataEntities.Element.Files.BaseFile",CodeFieldName = "dt_CreateDate"},
                new ConmonFunctionForUpdate.MonitorField{MonitorType = ConmonFunctionForUpdate.EnumMonitorType.RelatedInfo,FieldName = "s_Name",CodeNameSpace = "DataEntities.Element.Files.BaseFile",CodeFieldName = "s_Name"},
            };
            var type = this.GetType();
            _xplCopyOfObject = Activator.CreateInstance(type, new[] { new UnitOfWork() }) as XPLiteObject;
            ConmonFunctionForUpdate.CopyDataEntityFileds(this, _xplCopyOfObject, _listBeMonitorField);
        }

        protected override void OnSaved()
        {
            base.OnSaved();
            if (Session.IsNewObject(this)) return;
            ConmonFunctionForUpdate.CompareDataEntityFiledsForDeadline(this, _xplCopyOfObject, _listBeMonitorField);
            ConmonFunctionForUpdate.CompareDataEntityFiledsForRelatedInfo(this, _xplCopyOfObject, _listBeMonitorField);
        }

        #endregion
    }
}
using System;
using System.IO;
using DataEntities.Config;
using DataEntities.Properties;
using DevExpress.Xpo;

namespace DataEntities.Contact.Demand
{
    [Persistent("T_Demand")]
    public class Demand : XPLiteObject
    {
        private DateTime fdt_CreateDate;
        private DateTime fdt_EditDate;
        private DateTime fdt_ReceiptDate;
        private int fn_ID;
        private int fn_ObjectID;
        private int fn_Sequence;
        private int fn_SysDemandID;
        private string fs_Creator;
        private string fs_Description;
        private string fs_Editor;
        private string fs_IPType;

        private string fs_ModuleType;
        private string fs_Title;
        private string fs_ReceiptMethod;
        private int fn_DemandType;
        private string fs_DemandPosition;
        private CodeDemand CodeDemands;
        private string fs_Assignor;
        private int fn_CodeDemandTypeID;
        private string fs_FilePath;
        private string fs_SysDemand;
        private int fn_SysOftenDemand;
        private string fs_SourceModuleType;
        private int fn_SourceID;
        private Client.Client theClient;
        private Applicant.Applicant theApplicant;
        private Agency.Agency theAgency;
        private Case.BasicCase theCase;
        private Demand SourceDemand;
        public Demand(Session session)
            : base(session)
        {
        }

        public Demand()
            : base(Session.DefaultSession)
        {
        }

        [Key(true)]
        public int n_ID
        {
            get { return fn_ID; }
            set { SetPropertyValue<int>("n_ID", ref fn_ID, value); }
        }

        [Size(20)]
        public string s_ModuleType
        {
            get { return fs_ModuleType; }
            set { SetPropertyValue("s_ModuleType", ref fs_ModuleType, value); }
        }

        public int n_ObjectID
        {
            get { return fn_ObjectID; }
            set { SetPropertyValue<int>("n_ObjectID", ref fn_ObjectID, value); }
        }
        public int n_CodeDemandTypeID
        {
            get { return fn_CodeDemandTypeID; }
            set { SetPropertyValue<int>("n_CodeDemandTypeID", ref fn_CodeDemandTypeID, value); }
        }

        [Association("Client-Demands")]
        [Persistent("n_ClientID")]
        public Client.Client TheClient
        {
            get { return theClient; }
            set { SetPropertyValue("n_ClientID", ref theClient, value); }
        }

        [Association("Applicant-Demands")]
        [Persistent("n_ApplicantID")]
        public Applicant.Applicant TheApplicant
        {
            get { return theApplicant; }
            set { SetPropertyValue("n_ApplicantID", ref theApplicant, value); }
        }

        [Association("Agency-Demands")]
        [Persistent("n_AgencyID")]
        public Agency.Agency TheAgency
        {
            get { return theAgency; }
            set { SetPropertyValue("n_AgencyID", ref theAgency, value); }
        }

        [Association("Case-Demands")]
        [Persistent("n_CaseID")]
        public Case.BasicCase TheCase
        {
            get { return theCase; }
            set { SetPropertyValue("n_CaseID", ref theCase, value); }
        }

        public int n_SysDemandID
        {
            get { return fn_SysDemandID; }
            set { SetPropertyValue<int>("n_SysDemandID", ref fn_SysDemandID, value); }
        }
        [Size(100)]
        public string s_ReceiptMethod
        {
            get { return fs_ReceiptMethod; }
            set { SetPropertyValue("s_ReceiptMethod", ref fs_ReceiptMethod, value); }
        }
        [Size(100)]
        public string s_Assignor
        {
            get { return fs_Assignor; }
            set { SetPropertyValue("s_Assignor", ref fs_Assignor, value); }
        }
        [Size(200)]
        public string s_Title
        {
            get { return fs_Title; }
            set { SetPropertyValue("s_Title", ref fs_Title, value); }
        }

        [Size(500)]
        public string s_Description
        {
            get { return fs_Description; }
            set { SetPropertyValue("s_Description", ref fs_Description, value); }
        }

        public int n_Sequence
        {
            get { return fn_Sequence; }
            set { SetPropertyValue<int>("n_Sequence", ref fn_Sequence, value); }
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

        [Size(50)]
        public string s_Editor
        {
            get { return fs_Editor; }
            set { SetPropertyValue("s_Editor", ref fs_Editor, value); }
        }

        public DateTime dt_ReceiptDate
        {
            get { return fdt_ReceiptDate; }
            set { SetPropertyValue<DateTime>("dt_ReceiptDate", ref fdt_ReceiptDate, value); }
        }

        public DateTime dt_EditDate
        {
            get { return fdt_EditDate; }
            set { SetPropertyValue<DateTime>("dt_EditDate", ref fdt_EditDate, value); }
        }

        public int n_DemandType
        {
            get { return fn_DemandType; }
            set { SetPropertyValue<int>("n_DemandType", ref fn_DemandType, value); }
        }

        [Size(100)]
        public string s_DemandPosition
        {
            get { return (TheCodeDemand == null) ? fs_DemandPosition : (TheCodeDemand.TheCodeDemandType != null ? TheCodeDemand.TheCodeDemandType.s_CodeDemandPosition : fs_DemandPosition); }
            set { fs_DemandPosition = value; }
        }


        [Size(500)]
        public string s_FilePath
        {
            get { return fs_FilePath; }
            set { SetPropertyValue("s_FilePath", ref fs_FilePath, value); }
        }

        public int n_SysOftenDemand
        {
            get { return fn_SysOftenDemand; }
            set { SetPropertyValue<int>("n_SysOftenDemand", ref fn_SysOftenDemand, value); }
        }

        /// <summary>
        ///     判断文件是是什么类型的文件
        ///     coder:zhangjiechen(2010-09-06)
        /// </summary>
        public string sFile
        {
            get
            {
                if (!string.IsNullOrEmpty(s_FilePath))
                {
                    string sExtension = Path.GetExtension(s_FilePath);
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

        [Association("CodeDemand-Demand")]
        [Persistent("n_CodeDemandID")]
        public CodeDemand TheCodeDemand
        {
            get { return CodeDemands; }
            set { SetPropertyValue("n_CodeDemandID", ref CodeDemands, value); }
        }

        [NonPersistent]
        public Guid GUID { get; set; }

        [NonPersistent, Delayed]
        public string sClientName
        {
            get
            {
                return TheClient == null ? string.Empty : theClient.s_Name;
            }
        }

        [NonPersistent, Delayed]
        public string sApplicantName
        {
            get
            {
                return TheApplicant == null ? string.Empty : TheApplicant.s_Name;
            }
        }
        [NonPersistent, Delayed]
        public string sObjName
        {
            get
            {
                //if (n_ObjectID == -1) return "";
                //using (var uow = new UnitOfWork())
                {
                    switch (s_ModuleType)
                    {
                        case "Client":
                            {
                                if (TheClient != null && TheApplicant != null)
                                {
                                    return Resource.ClientApplicantDemand;
                                }
                                else if (TheClient != null && TheApplicant == null)
                                {
                                    return Resource.ClientDemand;
                                }
                                return string.Empty;
                            }
                        case "Applicant":
                            {
                                if (TheApplicant != null && TheClient != null)
                                {
                                    return Resource.ApplicantClientDemand;
                                }
                                else if (TheApplicant != null && TheClient == null)
                                {
                                    return Resource.ApplicationDemand;
                                }
                                return string.Empty;
                            }
                        case "Case":
                            {
                                return Resource.CaseDemand;
                            }
                        case "Agency":
                            {
                                return Resource.AgencyDemand;
                            }
                        default:
                            return "";
                    }
                }
            }
        }
        [NonPersistent, Delayed]
        public string sNotCaseObjCode
        {
            get
            {
                if (n_SourceID == 0) return "";

                using (var uow = new UnitOfWork())
                {

                    var xpc = new XPCollection(uow, typeof(Demand))
                   {
                       Criteria = DevExpress.Data.Filtering.CriteriaOperator.Parse("n_ID = ? ", n_SourceID)
                   };
                    if (xpc.Count == 0 || (xpc[0] as Demand) == null) return "";
                    switch (s_SourceModuleType)
                    {
                        case "Client":
                        case "RelatedClient":
                            {

                                return (xpc[0] as Demand).TheClient != null ? (xpc[0] as Demand).TheClient.s_ClientCode : "";
                            }
                        case "Applicant":
                            {
                                return (xpc[0] as Demand).TheApplicant != null ? (xpc[0] as Demand).TheApplicant.s_AppCode : "";
                            }
                        case "ClientAppliant":
                            {
                                return "";
                            }
                        case "Agency":
                            {
                                return (xpc[0] as Demand).TheAgency != null ? (xpc[0] as Demand).TheAgency.s_Code : "";
                            }
                        default:
                            return "";
                    }
                }
            }
        }
        [NonPersistent, Delayed]
        public string sNotCaseObjName
        {
            get
            {
                switch (s_SourceModuleType)
                {
                    case "Client":
                        {
                            return Resource.ClientDemand;
                        }
                    case "Applicant":
                        {
                            return Resource.ApplicationDemand;
                        }
                    case "ClientAppliant":
                        {
                            return Resource.ClientApplicantDemand;
                        }
                    case "Agency":
                        {
                            return Resource.AboardAngecy;
                        }
                    case "RelatedClient":
                        {
                            return Resource.RelatedClient;
                        }
                    default:
                        return "";
                }

            }
        }
        [NonPersistent]
        public bool Check
        {
            get;
            set;
        }

        [Size(20)]
        public string s_IPType
        {
            get { return fs_IPType; }
            set { SetPropertyValue("s_IPType", ref fs_IPType, value); }
        }
        public string s_SysDemand
        {
            get { return fs_SysDemand; }
            set { SetPropertyValue("s_SysDemand", ref fs_SysDemand, value); }
        }

        string fs_Process;
        [Size(500)]
        public string s_Process
        {
            get { return fs_Process; }
            set { SetPropertyValue<string>("s_Process", ref fs_Process, value); }
        }

        string fs_BussinessType;
        [Size(500)]
        public string s_BussinessType
        {
            get { return fs_BussinessType; }
            set { SetPropertyValue<string>("s_BussinessType", ref fs_BussinessType, value); }
        }

        [Size(20)]
        public string s_SourceModuleType
        {
            get { return fs_SourceModuleType; }
            set { SetPropertyValue("s_SourceModuleType", ref fs_SourceModuleType, value); }
        }

        public int n_SourceID
        {
            get { return fn_SourceID; }
            set { SetPropertyValue<int>("n_SourceID", ref fn_SourceID, value); }
        }


        [NonPersistent]
        public bool IsEditDataChanged
        {
            get;
            set;
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}
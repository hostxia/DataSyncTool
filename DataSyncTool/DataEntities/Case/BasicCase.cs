using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using DataEntities.Case.Patents;
using DataEntities.Case.Trademarks;
using DataEntities.Config;
using DataEntities.Contact.Agency;
using DataEntities.Contact.Client;
using DataEntities.Contact.ContactMemo;
using DataEntities.Contact.Demand;
using DataEntities.Contact.Introducer;
using DataEntities.Element.Emails;
using DataEntities.Element.Fee;
using DataEntities.Element.Files;
using DataEntities.Element.Monitor;
using DataEntities.Element.Tasks;
using DataEntities.Element.TimeSheet;
using DataEntities.Finance.Contract;
using DataEntities.TaskFlowData;
using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using DevExpress.Xpo.DB;

namespace DataEntities.Case
{
    [Persistent("TCase_Base")]
    public partial class BasicCase : XPLiteObject
    {
        private readonly XPDelayedProperty fn_AppCountry = new XPDelayedProperty();
        private readonly XPDelayedProperty fn_BusinessTypeID = new XPDelayedProperty();
        private readonly XPDelayedProperty fn_DepartmentID = new XPDelayedProperty();
        private readonly XPDelayedProperty fn_FirstAttorney = new XPDelayedProperty();
        private readonly XPDelayedProperty fn_FlowNum = new XPDelayedProperty();
        private readonly XPDelayedProperty fn_OfficeID = new XPDelayedProperty();
        private readonly XPDelayedProperty fn_RegCountry = new XPDelayedProperty();
        private readonly XPDelayedProperty fn_SecondAttorney = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_CaseName = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_CaseSerial = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_ClientSerial = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_IPType = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_ArchiveStatus = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_ArchivePosition = new XPDelayedProperty();
        private readonly XPDelayedProperty fn_BorrowTimes = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_PayerBillToName = new XPDelayedProperty();
        private readonly XPDelayedProperty fn_PayerCountry = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_PayerState = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_PayerCity = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_PayerStreet = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_PayerZipCode = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_PayerEmail = new XPDelayedProperty();

        private Agency agencyTo;
        private Client client;
        private DateTime fdt_CreateDate;
        private DateTime fdt_EditDate;
        private DateTime fdt_ShldSbmtDate;
        private DateTime fdt_SendCheckDate;
        private DateTime fdt_SubmitDate;
        private DateTime fdt_SubmittedDate;
        private DateTime fdt_UndertakeDate;
        private int fn_CaseID;
        private int fn_ChargeCurrency;
        private int fn_EndProcess;
        //private decimal fn_FeeDiscount;
        //private decimal fn_FixAFee;
        //private decimal fn_FixFee;
        private decimal fn_IntroPer;
        private int fn_OfficialCurrency;
        private int fn_ProcessID;
        private CodeSecurityLevelConfig fn_SecurityLevelID;
        private int fn_StartProcessID;
        private string fs_AppNo;
        private string fs_CaseNativeName;
        private string fs_CaseStatus;
        private string fs_CoopAgencyToNo;
        private string fs_Creator;
        private string fs_CurrentOperator;
        private string fs_CustomField1;
        private string fs_CustomField10;
        private string fs_CustomField2;
        private string fs_CustomField3;
        private string fs_CustomField4;
        private string fs_CustomField5;
        private string fs_CustomField6;
        private string fs_CustomField7;
        private string fs_CustomField8;
        private string fs_CustomField9;
        private string fs_Editor;
        private string fs_FeeStatusInit;
        private string fs_FeeStatusOrder;
        private string fs_FlowDirection;
        private string fs_InConsole;
        private string fs_IntroSerial;
        private string fs_IsRegOnline;
        private string fs_OtherName;
        private string fs_ClientCName;
        private string fs_PayMode;
        private string fs_ProcessMark;
        private string fs_SerialLocation;
        private string fs_SubmitStatus;
        private string fs_TotalSerial;
        private string fs_ElecPayer;
        private Introducer introducer;
        private Contract tContract;
        private string fs_PriceDesc;

        [Key(true)]
        public int n_CaseID
        {
            get { return fn_CaseID; }
            set { SetPropertyValue<int>("n_CaseID", ref fn_CaseID, value); }
        }

        [Size(1)]
        [Delayed("fs_IPType")]
        public string s_IPType
        {
            get { return (string)fs_IPType.Value; }
            set { fs_IPType.Value = value; }
        }

        [Size(50)]
        [Delayed("fs_CaseSerial")]
        public string s_CaseSerial
        {
            get { return (string)fs_CaseSerial.Value; }
            set { fs_CaseSerial.Value = value; }
        }
        [Size(8000)]
        public string s_PriceDesc
        {
            get { return fs_PriceDesc; }
            set { SetPropertyValue("s_PriceDesc", ref fs_PriceDesc, value); }
        }
        [Size(500)]
        public string s_AppNo
        {
            get { return fs_AppNo; }
            set { SetPropertyValue("s_AppNo", ref fs_AppNo, value); }
        }
        public string s_ElecPayer
        {
            get { return fs_ElecPayer; }
            set { SetPropertyValue("s_ElecPayer", ref fs_ElecPayer, value); }
        }
        [Delayed("fn_FlowNum")]
        public int n_FlowNum
        {
            get
            {
                if (fn_FlowNum.Value == null)
                {
                    return -1;
                }
                return (int)fn_FlowNum.Value;
            }
            set { fn_FlowNum.Value = value; }
        }

        [Size(500)]
        [Delayed("fs_CaseName")]
        public string s_CaseName
        {
            get { return (string)fs_CaseName.Value; }
            set { fs_CaseName.Value = value; }
        }

        private string fs_IsTempCase;
        [Size(2)]
        public string s_IsTempCase
        {
            get { return fs_IsTempCase; }
            set { SetPropertyValue("s_IsTempCase", ref fs_IsTempCase, value); }
        }

        private string fs_IsMiddleCase;
        [Size(2)]
        public string s_IsMiddleCase
        {
            get { return fs_IsMiddleCase; }
            set { SetPropertyValue("s_IsMiddleCase", ref fs_IsMiddleCase, value); }
        }

        private string fs_ManualCreateChain;
        [Size(1)]
        public string s_ManualCreateChain
        {
            get { return fs_ManualCreateChain; }
            set { SetPropertyValue("s_ManualCreateChain", ref fs_ManualCreateChain, value); }
        }

        [Size(500)]
        public string s_CaseNativeName
        {
            get { return fs_CaseNativeName; }
            set { SetPropertyValue("s_CaseNativeName", ref fs_CaseNativeName, value); }
        }

        [Size(500)]
        public string s_CaseOtherName
        {
            get { return fs_OtherName; }
            set { SetPropertyValue("s_CaseOtherName", ref fs_OtherName, value); }
        }
        [Size(500)]
        public string s_ClientCName
        {
            get { return fs_ClientCName; }
            set { SetPropertyValue("s_ClientCName", ref fs_ClientCName, value); }
        }
        [Delayed("fn_BusinessTypeID")]
        public int n_BusinessTypeID
        {
            get
            {
                if (fn_BusinessTypeID.Value == null)
                {
                    return -1;
                }
                return (int)fn_BusinessTypeID.Value;
            }
            set { fn_BusinessTypeID.Value = value; }
        }

        [Size(2)]
        public string s_FlowDirection
        {
            get { return fs_FlowDirection; }
            set { SetPropertyValue("s_Flow", ref fs_FlowDirection, value); }
        }

        [Delayed("fn_FirstAttorney")]
        public int n_FirstAttorney
        {
            get
            {
                if (fn_FirstAttorney.Value == null)
                {
                    return -1;
                }
                return (int)fn_FirstAttorney.Value;
            }
            set { fn_FirstAttorney.Value = value; }
        }

        [Size(10)]
        public string s_ProcessMark
        {
            get { return fs_ProcessMark; }
            set { SetPropertyValue("s_ProcessMark", ref fs_ProcessMark, value); }
        }

        [Delayed("fn_SecondAttorney")]
        public int n_SecondAttorney
        {
            get
            {
                if (fn_SecondAttorney.Value == null)
                {
                    return -1;
                }
                return (int)fn_SecondAttorney.Value;
            }
            set { fn_SecondAttorney.Value = value; }
        }

        [Delayed("fn_OfficeID")]
        public int n_OfficeID
        {
            get
            {
                if (fn_OfficeID.Value == null)
                {
                    return -1;
                }
                return (int)fn_OfficeID.Value;
            }
            set { fn_OfficeID.Value = value; }
        }

        [Delayed("fn_RegCountry")]
        public int n_RegCountry
        {
            get
            {
                if (fn_RegCountry.Value == null)
                {
                    return -1;
                }
                return (int)fn_RegCountry.Value;
            }
            set { fn_RegCountry.Value = value; }
        }

        [Delayed("fn_AppCountry")]
        public int n_AppCountry
        {
            get
            {
                if (fn_AppCountry.Value == null)
                {
                    return -1;
                }
                return (int)fn_AppCountry.Value;
            }
            set { fn_AppCountry.Value = value; }
        }

        [NonPersistent]
        public string sIsTempCase
        {
            get { return s_IsTempCase == "Y" ? "未提交" : "已提交"; }
        }
        [Size(50)]
        public string s_CoopAgencyToNo
        {
            get { return fs_CoopAgencyToNo; }
            set { SetPropertyValue("s_CoopAgencyToNo", ref fs_CoopAgencyToNo, value); }
        }

        [Association("Contract-Cases")]
        [Persistent("n_ContractID")]
        public Contract TContract
        {
            get { return tContract; }
            set { SetPropertyValue("n_ContractID", ref tContract, value); }
        }

        [Association("Client-BasicCases")]
        [Persistent("n_ClientID")]
        public Client TheClient
        {
            get { return client; }
            set { SetPropertyValue("n_ClientID", ref client, value); }
        }

        [Delayed("fs_ClientSerial")]
        [Size(500)]
        public string s_ClientSerial
        {
            get { return (string)fs_ClientSerial.Value; }
            set { fs_ClientSerial.Value = value; }
        }

        [Association("AgencyTo-BasicCasesTo")]
        [Persistent("n_CoopAgencyToID")]
        public Agency TheAgencyTo
        {
            get { return agencyTo; }
            set { SetPropertyValue("n_CoopAgencyToID", ref agencyTo, value); }
        }

        [Association("Introducer-BasicCases")]
        [Persistent("n_IntroID")]
        public Introducer TheIntroducer
        {
            get { return introducer; }
            set { SetPropertyValue("n_IntroID", ref introducer, value); }
        }

        [Size(50)]
        public string s_IntroSerial
        {
            get { return fs_IntroSerial; }
            set { SetPropertyValue("s_IntroSerial", ref fs_IntroSerial, value); }
        }

        public DateTime dt_UndertakeDate
        {
            get { return fdt_UndertakeDate; }
            set { SetPropertyValue<DateTime>("dt_UndertakeDate", ref fdt_UndertakeDate, value); }
        }

        public DateTime dt_ShldSbmtDate
        {
            get { return fdt_ShldSbmtDate; }
            set { SetPropertyValue<DateTime>("dt_ShldSbmtDate", ref fdt_ShldSbmtDate, value); }
        }
        public DateTime dt_SubmitDate
        {
            get { return fdt_SubmitDate; }
            set { SetPropertyValue<DateTime>("dt_SubmitDate", ref fdt_SubmitDate, value); }
        }

        [Size(50)]
        public string s_CaseStatus
        {
            get { return fs_CaseStatus; }
            set { SetPropertyValue("s_CaseStatus", ref fs_CaseStatus, value); }
        }

        //public decimal n_FeeDiscount
        //{
        //    get { return fn_FeeDiscount; }
        //    set { SetPropertyValue<decimal>("n_FeeDiscount", ref fn_FeeDiscount, value); }
        //}

        //public decimal n_FixAFee
        //{
        //    get { return fn_FixAFee; }
        //    set { SetPropertyValue<decimal>("n_FixAFee", ref fn_FixAFee, value); }
        //}

        //public decimal n_FixFee
        //{
        //    get { return fn_FixFee; }
        //    set { SetPropertyValue<decimal>("n_FixFee", ref fn_FixFee, value); }
        //}

        [Size(2)]
        public string s_PayMode
        {
            get { return fs_PayMode; }
            set { SetPropertyValue("s_PayMode", ref fs_PayMode, value); }
        }

        [Size(10)]
        public string s_FeeStatusOrder
        {
            get { return fs_FeeStatusOrder; }
            set { SetPropertyValue("s_FeeStatusOrder", ref fs_FeeStatusOrder, value); }
        }

        [Size(10)]
        public string s_FeeStatusInit
        {
            get { return fs_FeeStatusInit; }
            set { SetPropertyValue("s_FeeStatusInit", ref fs_FeeStatusInit, value); }
        }

        public int n_ChargeCurrency
        {
            get { return fn_ChargeCurrency; }
            set { SetPropertyValue<int>("n_ChargeCurrency", ref fn_ChargeCurrency, value); }
        }

        public int n_OfficialCurrency
        {
            get { return fn_OfficialCurrency; }
            set { SetPropertyValue<int>("n_OfficialCurrency", ref fn_OfficialCurrency, value); }
        }

        [Size(1)]
        public string s_IsRegOnline
        {
            get { return fs_IsRegOnline; }
            set { SetPropertyValue("s_IsRegOnline", ref fs_IsRegOnline, value); }
        }

        [Size(20)]
        public string s_TotalSerial
        {
            get { return fs_TotalSerial; }
            set { SetPropertyValue("s_TotalSerial", ref fs_TotalSerial, value); }
        }

        [Size(20)]
        public string s_SerialLocation
        {
            get { return fs_SerialLocation; }
            set { SetPropertyValue("s_SerialLocation", ref fs_SerialLocation, value); }
        }

        [Size(1)]
        public string s_InConsole
        {
            get { return fs_InConsole; }
            set { SetPropertyValue("s_InConsole", ref fs_InConsole, value); }
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

        [Size(50)]
        public string s_CurrentOperator
        {
            get { return fs_CurrentOperator; }
            set { SetPropertyValue("s_CurrentOperator", ref fs_CurrentOperator, value); }
        }

        public decimal n_IntroPer
        {
            get { return fn_IntroPer; }
            set { SetPropertyValue<decimal>("n_IntroPer", ref fn_IntroPer, value); }
        }

        public DateTime dt_SubmittedDate
        {
            get { return fdt_SubmittedDate; }
            set { SetPropertyValue<DateTime>("dt_SubmittedDate", ref fdt_SubmittedDate, value); }
        }

        public string s_CustomField1
        {
            get { return fs_CustomField1; }
            set { SetPropertyValue("fs_CustomField1", ref fs_CustomField1, value); }
        }

        public string s_CustomField2
        {
            get { return fs_CustomField2; }
            set { SetPropertyValue("fs_CustomField2", ref fs_CustomField2, value); }
        }

        public string s_CustomField3
        {
            get { return fs_CustomField3; }
            set { SetPropertyValue("fs_CustomField3", ref fs_CustomField3, value); }
        }

        public string s_CustomField4
        {
            get { return fs_CustomField4; }
            set { SetPropertyValue("fs_CustomField4", ref fs_CustomField4, value); }
        }

        public string s_CustomField5
        {
            get { return fs_CustomField5; }
            set { SetPropertyValue("fs_CustomField5", ref fs_CustomField5, value); }
        }

        public string s_CustomField6
        {
            get { return fs_CustomField6; }
            set { SetPropertyValue("fs_CustomField6", ref fs_CustomField6, value); }
        }

        public string s_CustomField7
        {
            get { return fs_CustomField7; }
            set { SetPropertyValue("fs_CustomField7", ref fs_CustomField7, value); }
        }

        public string s_CustomField8
        {
            get { return fs_CustomField7; }
            set { SetPropertyValue("fs_CustomField8", ref fs_CustomField8, value); }
        }

        public string s_CustomField9
        {
            get { return fs_CustomField9; }
            set { SetPropertyValue("fs_CustomField9", ref fs_CustomField9, value); }
        }

        public string s_CustomField10
        {
            get { return fs_CustomField10; }
            set { SetPropertyValue("fs_CustomField10", ref fs_CustomField10, value); }
        }

        public string s_SubmitStatus
        {
            get { return fs_SubmitStatus; }
            set { SetPropertyValue("s_SubmitStatus", ref fs_SubmitStatus, value); }
        }

        public int fn_CutRateID;
        public int n_CutRateID
        {
            get { return fn_CutRateID; }
            set { SetPropertyValue<int>("n_CutRateID", ref fn_CutRateID, value); }
        }

        //public new void Save()
        //{
        //    base.Save();
        //    XPCollection feeInCaseXpc = new XPCollection(Session, typeof(FeeInCase))
        //    {
        //        Criteria = CriteriaOperator.Parse("TheCase.n_CaseID = ? ", n_CaseID)
        //    };
        //    foreach (FeeInCase feeInCase in feeInCaseXpc)
        //    {
        //        if (feeInCase == null || feeInCase.TheFee == null) continue;
        //        feeInCase.TheFee.Save();
        //    }
        //}

        [Aggregated, Association("BasicCase-FileInCases", typeof(FileInCase))]
        public XPCollection FileInCases
        {
            get { return GetCollection("FileInCases"); }
        }

        [Aggregated, Association("Case-StatusHistory")]
        public XPCollection<StatusHistory> StatusHistories
        {
            get { return GetCollection<StatusHistory>("StatusHistories"); }
        }

        [Aggregated, Association("Case-ArchivesHistory")]
        public XPCollection<ArchivesHistory> ArchivesHistory
        {
            get { return GetCollection<ArchivesHistory>("ArchivesHistory"); }
        }

        [Aggregated, Association("Case-ClientContact", typeof(ClientContact))]
        public XPCollection ClientContacts
        {
            get { return GetCollection("ClientContacts"); }
        }

        [Aggregated, Association("Case-Contact", typeof(CaseContact))]
        public XPCollection Contacts
        {
            get { return GetCollection("Contacts"); }
        }

        [Aggregated, Association("Case-CaseClients", typeof(CaseClients))]
        public XPCollection CaseClients
        {
            get { return GetCollection("CaseClients"); }
        }

        [Aggregated, Association("Case-IntroContact", typeof(IntroContact))]
        public XPCollection IntroContacts
        {
            get { return GetCollection("IntroContacts"); }
        }

        [Aggregated, Association("Case-ToAgencyContact", typeof(ToAgencyContact))]
        public XPCollection ToAgencyContacts
        {
            get { return GetCollection("ToAgencyContacts"); }
        }

        [Aggregated, Association("Case-Applicants", typeof(Applicant))]
        public XPCollection Applicants
        {
            get { return GetCollection("Applicants"); }
        }

        [Aggregated, Association("Case-Memos", typeof(CaseMemo))]
        public XPCollection Memos
        {
            get { return GetCollection("Memos"); }
        }

        [Aggregated, Association("Case-Processes")]
        public XPCollection<Process> Processes
        {
            get { return GetCollection<Process>("Processes"); }
        }

        [Aggregated, Association("Case-CustomFields", typeof(CustomField))]
        public XPCollection CustomFields
        {
            get { return GetCollection("CustomFields"); }
        }

        [Aggregated, Association("Case-FormPages", typeof(FormPage))]
        public XPCollection FormPages
        {
            get { return GetCollection("FormPages"); }
        }

        [Aggregated, Association("Case-MonitorInCases", typeof(MonitorInCase))]
        public XPCollection MonitorInCases
        {
            get { return GetCollection("MonitorInCases"); }
        }

        [Aggregated, Association("Case-TaskInCases", typeof(TaskInCase))]
        public XPCollection TaskInCases
        {
            get { return GetCollection("TaskInCases"); }
        }


        [Aggregated, Association("Case-FeeInCases", typeof(FeeInCase))]
        public XPCollection FeeInCases
        {
            get { return GetCollection("FeeInCases"); }
        }

        [Aggregated, Association("Case-TimeSheet", typeof(TimeSheetInCase))]
        public XPCollection TimeSheetInCases
        {
            get { return GetCollection("TimeSheetInCases"); }
        }

        [Aggregated, Association("Case-ExpenseInCases", typeof(ExpenseInCase))]
        public XPCollection ExpenseInCases
        {
            get { return GetCollection("ExpenseInCases"); }
        }

        [Aggregated, Association("Case-UserInConsole", typeof(UserCaseInConsole))]
        public XPCollection UserCaseInConsoles
        {
            get { return GetCollection("UserCaseInConsoles"); }
        }

        [Aggregated, Association("Case-CaseDepartments", typeof(CaseDepartment))]
        public XPCollection CaseDepartments
        {
            get { return GetCollection("CaseDepartments"); }
        }

        [Aggregated, Association("Case-CaseAttorney", typeof(CaseAttorney))]
        public XPCollection CaseAttorneys
        {
            get { return GetCollection("CaseAttorneys"); }
        }

        [Aggregated, Association("BasicCase-AbroadBillLists", typeof(AbroadBillList))]
        public XPCollection AbroadBillListsRelateCase
        {
            get { return GetCollection("AbroadBillListsRelateCase"); }
        }

        [Association("BasicCase-ContactMemo", typeof(ContactMemo))]
        public XPCollection ContactMemos
        {
            get { return GetCollection("ContactMemos"); }
        }

        public Applicant FstApplicant
        {
            get
            {
                foreach (Applicant applicant in Applicants)
                {
                    if (applicant.s_IsDelegacy == "Y")
                    {
                        return applicant;
                    }
                }
                return new Applicant();
            }
        }

        [Delayed("fn_DepartmentID")]
        public int n_DepartmentID
        {
            get
            {
                if (fn_DepartmentID.Value == null)
                {
                    return -1;
                }
                return (int)fn_DepartmentID.Value;
            }
            set { fn_DepartmentID.Value = value; }
        }

        public string AppNo
        {
            get
            {
                if (s_IPType == "P" && (this as ExtendedPatent) != null && (this as ExtendedPatent).TheLawInfo != null)
                    return (this as ExtendedPatent).TheLawInfo.s_AppNo;
                if (s_IPType == "T" && (this as ExtendedTrademark) != null &&
                    (this as ExtendedTrademark).TheLawInfo != null)
                    return (this as ExtendedTrademark).TheLawInfo.s_AppNo;
                return string.Empty;
            }
        }
        public DateTime dt_AppDate
        {
            get
            {
                if (s_IPType == "P" && (this as ExtendedPatent) != null && (this as ExtendedPatent).TheLawInfo != null)
                    return (this as ExtendedPatent).TheLawInfo.dt_AppDate;
                if (s_IPType == "T" && (this as ExtendedTrademark) != null &&
                    (this as ExtendedTrademark).TheLawInfo != null)
                    return (this as ExtendedTrademark).TheLawInfo.dt_AppDate;
                return DateTime.MinValue;
            }
        }
        public string AcceptNo
        {
            get
            {
                if (s_IPType == "T" && (this as ExtendedTrademark) != null &&
                    (this as ExtendedTrademark).TheLawInfo != null)
                    return (this as ExtendedTrademark).TheLawInfo.s_AcceptNO;
                return string.Empty;
            }
        }

        public int n_ProcessID
        {
            get { return fn_ProcessID; }
            set { SetPropertyValue<int>("n_ProcessID", ref fn_ProcessID, value); }
        }

        private int fn_CreatorID;
        public int n_CreatorID
        {
            get { return fn_CreatorID; }
            set { SetPropertyValue<int>("n_CreatorID", ref fn_CreatorID, value); }
        }
        public int n_StartProcessID
        {
            get { return fn_StartProcessID; }
            set { SetPropertyValue<int>("n_StartProcessID", ref fn_StartProcessID, value); }
        }

        //[Aggregated, Association("CaseBasicInfo-TaskChain")]
        //public XPCollection<OldTFTaskChain> TaskChains
        //{
        //    get { return GetCollection<OldTFTaskChain>("TaskChains"); }
        //}

        [NonPersistent]
        public List<Demand> listDemand { get; set; } //案件要求集合

        [NonPersistent]
        public bool SCheck { get; set; } //变更案件联系人用

        [NonPersistent]
        public bool LockCheck { get; set; } //解锁案件用
        [NonPersistent]
        public string s_CaseRelation { get; set; }
        [NonPersistent]
        public string s_MasterSlaveRelation { get; set; }
        [NonPersistent]
        public string s_RelationCaseNotes { get; set; }
        //int fn_SecurityLevelID;//密级
        //public int n_SecurityLevelID
        //{
        //    get { return fn_SecurityLevelID; }
        //    set { SetPropertyValue<int>("n_SecurityLevelID", ref fn_SecurityLevelID, value); }
        //}

        int fn_PreferentialCombineID;
        public int n_PreferentialCombineID
        {
            get { return fn_PreferentialCombineID; }
            set { SetPropertyValue<int>("n_PreferentialCombineID", ref fn_PreferentialCombineID, value); }
        }

        [Association("SecurityLevel-Cases")]
        [Persistent("n_SecurityLevelID")]
        public CodeSecurityLevelConfig TheSecurityLevel
        {
            get { return fn_SecurityLevelID; }
            set { SetPropertyValue("n_SecurityLevelID", ref fn_SecurityLevelID, value); }
        }

        [Association("Case-Demands", typeof(Demand))]
        public XPCollection Demands
        {
            get { return GetCollection("Demands"); }
        }

        #region 案件自定义属性冗余字段
        string fs_RelatedUserIDs;
        [Size(1000)]
        public string s_RelatedUserIDs
        {
            get { return fs_RelatedUserIDs; }
            set { SetPropertyValue<string>("s_RelatedUserIDs", ref fs_RelatedUserIDs, value); }
        }
        public object CustomerField1
        {
            get
            {
                CodeCaseCustomField codeCaseCustomField =
                    new XPCollection<CodeCaseCustomField>(new UnitOfWork(),
                        CriteriaOperator.Parse("s_IPType = ? And s_IsActive = ?", fs_IPType.Value, "Y"),
                        new SortProperty("n_ID", SortingDirection.Ascending)).FirstOrDefault();
                if (codeCaseCustomField == null)
                    return null;
                CustomField customField =
                    CustomFields.Cast<CustomField>().FirstOrDefault(c => c.n_FieldCodeID == codeCaseCustomField.n_ID);
                if (customField == null)
                    return null;
                if (codeCaseCustomField.s_Type == "DateTime")
                {
                    ;
                    DateTime dt;
                    if (DateTime.TryParse(customField.s_Value, out dt))
                        return dt;
                    return null;
                }
                if (codeCaseCustomField.s_Type == "Numeric")
                {
                    decimal ide;
                    if (decimal.TryParse(customField.s_Value, out ide))
                        return ide;
                    return null;
                }
                return customField.s_Value;
            }
        }

        public object CustomerField2
        {
            get
            {
                var codeCaseCustomFields = new XPCollection<CodeCaseCustomField>(new UnitOfWork(),
                    CriteriaOperator.Parse("s_IPType = ? And s_IsActive = ?", fs_IPType.Value, "Y"),
                    new SortProperty("n_ID", SortingDirection.Ascending));
                if (codeCaseCustomFields.Count < 2)
                    return null;
                CustomField customField =
                    CustomFields.Cast<CustomField>()
                        .FirstOrDefault(c => c.n_FieldCodeID == codeCaseCustomFields[1].n_ID);
                if (customField == null)
                    return null;
                if (codeCaseCustomFields[1].s_Type == "DateTime")
                {
                    DateTime dt;
                    if (DateTime.TryParse(customField.s_Value, out dt))
                        return dt;
                    return null;
                }
                if (codeCaseCustomFields[1].s_Type == "Numeric")
                {
                    decimal ide;
                    if (decimal.TryParse(customField.s_Value, out ide))
                        return ide;
                    return null;
                }
                return customField.s_Value;
            }
        }

        public object CustomerField3
        {
            get
            {
                var codeCaseCustomFields = new XPCollection<CodeCaseCustomField>(new UnitOfWork(),
                    CriteriaOperator.Parse("s_IPType = ? And s_IsActive = ?", fs_IPType.Value, "Y"),
                    new SortProperty("n_ID", SortingDirection.Ascending));
                if (codeCaseCustomFields.Count < 3)
                    return null;
                CustomField customField =
                    CustomFields.Cast<CustomField>()
                        .FirstOrDefault(c => c.n_FieldCodeID == codeCaseCustomFields[2].n_ID);
                if (customField == null)
                    return null;
                if (codeCaseCustomFields[2].s_Type == "DateTime")
                {
                    DateTime dt;
                    if (DateTime.TryParse(customField.s_Value, out dt))
                        return dt;
                    return null;
                }
                if (codeCaseCustomFields[2].s_Type == "Numeric")
                {
                    decimal ide;
                    if (decimal.TryParse(customField.s_Value, out ide))
                        return ide;
                    return null;
                }
                return customField.s_Value;
            }
        }

        public object CustomerField4
        {
            get
            {
                var codeCaseCustomFields = new XPCollection<CodeCaseCustomField>(new UnitOfWork(),
                    CriteriaOperator.Parse("s_IPType = ? And s_IsActive = ?", fs_IPType.Value, "Y"),
                    new SortProperty("n_ID", SortingDirection.Ascending));
                if (codeCaseCustomFields.Count < 4)
                    return null;
                CustomField customField =
                    CustomFields.Cast<CustomField>()
                        .FirstOrDefault(c => c.n_FieldCodeID == codeCaseCustomFields[3].n_ID);
                if (customField == null)
                    return null;
                if (codeCaseCustomFields[3].s_Type == "DateTime")
                {
                    DateTime dt;
                    if (DateTime.TryParse(customField.s_Value, out dt))
                        return dt;
                    return null;
                }
                if (codeCaseCustomFields[3].s_Type == "Numeric")
                {
                    decimal ide;
                    if (decimal.TryParse(customField.s_Value, out ide))
                        return ide;
                    return null;
                }
                return customField.s_Value;
            }
        }

        public object CustomerField5
        {
            get
            {
                var codeCaseCustomFields = new XPCollection<CodeCaseCustomField>(new UnitOfWork(),
                    CriteriaOperator.Parse("s_IPType = ? And s_IsActive = ?", fs_IPType.Value, "Y"),
                    new SortProperty("n_ID", SortingDirection.Ascending));
                if (codeCaseCustomFields.Count < 5)
                    return null;
                CustomField customField =
                    CustomFields.Cast<CustomField>()
                        .FirstOrDefault(c => c.n_FieldCodeID == codeCaseCustomFields[4].n_ID);
                if (customField == null)
                    return null;
                if (codeCaseCustomFields[4].s_Type == "DateTime")
                {
                    DateTime dt;
                    if (DateTime.TryParse(customField.s_Value, out dt))
                        return dt;
                    return null;
                }
                if (codeCaseCustomFields[4].s_Type == "Numeric")
                {
                    decimal ide;
                    if (decimal.TryParse(customField.s_Value, out ide))
                        return ide;
                    return null;
                }
                return customField.s_Value;
            }
        }

        public object CustomerField6
        {
            get
            {
                var codeCaseCustomFields = new XPCollection<CodeCaseCustomField>(new UnitOfWork(),
                    CriteriaOperator.Parse("s_IPType = ? And s_IsActive = ?", fs_IPType.Value, "Y"),
                    new SortProperty("n_ID", SortingDirection.Ascending));
                if (codeCaseCustomFields.Count < 6)
                    return null;
                CustomField customField =
                    CustomFields.Cast<CustomField>()
                        .FirstOrDefault(c => c.n_FieldCodeID == codeCaseCustomFields[5].n_ID);
                if (customField == null)
                    return null;
                if (codeCaseCustomFields[5].s_Type == "DateTime")
                {
                    DateTime dt;
                    if (DateTime.TryParse(customField.s_Value, out dt))
                        return dt;
                    return null;
                }
                if (codeCaseCustomFields[5].s_Type == "Numeric")
                {
                    decimal ide;
                    if (decimal.TryParse(customField.s_Value, out ide))
                        return ide;
                    return null;
                }
                return customField.s_Value;
            }
        }

        public object CustomerField7
        {
            get
            {
                var codeCaseCustomFields = new XPCollection<CodeCaseCustomField>(new UnitOfWork(),
                    CriteriaOperator.Parse("s_IPType = ? And s_IsActive = ?", fs_IPType.Value, "Y"),
                    new SortProperty("n_ID", SortingDirection.Ascending));
                if (codeCaseCustomFields.Count < 7)
                    return null;
                CustomField customField =
                    CustomFields.Cast<CustomField>()
                        .FirstOrDefault(c => c.n_FieldCodeID == codeCaseCustomFields[6].n_ID);
                if (customField == null)
                    return null;
                if (codeCaseCustomFields[6].s_Type == "DateTime")
                {
                    DateTime dt;
                    if (DateTime.TryParse(customField.s_Value, out dt))
                        return dt;
                    return null;
                }
                if (codeCaseCustomFields[6].s_Type == "Numeric")
                {
                    decimal ide;
                    if (decimal.TryParse(customField.s_Value, out ide))
                        return ide;
                    return null;
                }
                return customField.s_Value;
            }
        }

        public object CustomerField8
        {
            get
            {
                var codeCaseCustomFields = new XPCollection<CodeCaseCustomField>(new UnitOfWork(),
                    CriteriaOperator.Parse("s_IPType = ? And s_IsActive = ?", fs_IPType.Value, "Y"),
                    new SortProperty("n_ID", SortingDirection.Ascending));
                if (codeCaseCustomFields.Count < 8)
                    return null;
                CustomField customField =
                    CustomFields.Cast<CustomField>()
                        .FirstOrDefault(c => c.n_FieldCodeID == codeCaseCustomFields[7].n_ID);
                if (customField == null)
                    return null;
                if (codeCaseCustomFields[7].s_Type == "DateTime")
                {
                    DateTime dt;
                    if (DateTime.TryParse(customField.s_Value, out dt))
                        return dt;
                    return null;
                }
                if (codeCaseCustomFields[7].s_Type == "Numeric")
                {
                    decimal ide;
                    if (decimal.TryParse(customField.s_Value, out ide))
                        return ide;
                    return null;
                }
                return customField.s_Value;
            }
        }

        public object CustomerField9
        {
            get
            {
                var codeCaseCustomFields = new XPCollection<CodeCaseCustomField>(new UnitOfWork(),
                    CriteriaOperator.Parse("s_IPType = ? And s_IsActive = ?", fs_IPType.Value, "Y"),
                    new SortProperty("n_ID", SortingDirection.Ascending));
                if (codeCaseCustomFields.Count < 9)
                    return null;
                CustomField customField =
                    CustomFields.Cast<CustomField>()
                        .FirstOrDefault(c => c.n_FieldCodeID == codeCaseCustomFields[8].n_ID);
                if (customField == null)
                    return null;
                if (codeCaseCustomFields[8].s_Type == "DateTime")
                {
                    DateTime dt;
                    if (DateTime.TryParse(customField.s_Value, out dt))
                        return dt;
                    return null;
                }
                if (codeCaseCustomFields[8].s_Type == "Numeric")
                {
                    decimal ide;
                    if (decimal.TryParse(customField.s_Value, out ide))
                        return ide;
                    return null;
                }
                return customField.s_Value;
            }
        }

        public object CustomerField10
        {
            get
            {
                var codeCaseCustomFields = new XPCollection<CodeCaseCustomField>(new UnitOfWork(),
                    CriteriaOperator.Parse("s_IPType = ? And s_IsActive = ?", fs_IPType.Value, "Y"),
                    new SortProperty("n_ID", SortingDirection.Ascending));
                if (codeCaseCustomFields.Count < 10)
                    return null;
                CustomField customField =
                    CustomFields.Cast<CustomField>()
                        .FirstOrDefault(c => c.n_FieldCodeID == codeCaseCustomFields[9].n_ID);
                if (customField == null)
                    return null;
                if (codeCaseCustomFields[9].s_Type == "DateTime")
                {
                    DateTime dt;
                    if (DateTime.TryParse(customField.s_Value, out dt))
                        return dt;
                    return null;
                }
                if (codeCaseCustomFields[9].s_Type == "Numeric")
                {
                    decimal ide;
                    if (decimal.TryParse(customField.s_Value, out ide))
                        return ide;
                    return null;
                }
                return customField.s_Value;
            }
        }

        #endregion

        #region 高级查询所用的特殊字段

        /// <summary>
        ///     起始程序，高级查询使用
        /// </summary>
        public Process StartProcess
        {
            get
            {
                //Processes.Sorting = new SortingCollection(new SortProperty("n_OrderNum", SortingDirection.Ascending));
                //return Processes.Count == 0 ? null : Processes[0] as Process;
                var proXpc = new XPCollection(new UnitOfWork(), typeof(Process))
                {
                    Criteria = CriteriaOperator.Parse("BasicCase.n_CaseID = ? ", n_CaseID),
                    Sorting = new SortingCollection(new SortProperty("n_OrderNum", SortingDirection.Ascending))
                };
                if (proXpc.Count == 0)
                {
                    return Processes.Cast<Process>().OrderBy(p => p.n_OrderNum).FirstOrDefault();
                }
                return proXpc[0] as Process;
            }
        }

        [NonPersistent]
        public Process CurrentProcess { get; set; } //当前案件阶段
        ///// <summary>
        /////     当前程序，高级查询使用
        ///// </summary>
        //public Process CurrentProcess
        //{
        //    get
        //    {
        //        ////Processes.Reload();
        //        ////Processes.Filter = CriteriaOperator.Parse(" ");
        //        ////Processes.Sorting = new SortingCollection(new SortProperty("n_OrderNum", SortingDirection.Descending));
        //        ////Process pro = Processes.Count == 0 ? null : Processes[0] as Process;
        //        ////Processes.Filter = CriteriaOperator.Parse("1 = 1 ");
        //        ////return pro;
        //        //using (var tempUow = new UnitOfWork())
        //        //{
        //        //    var proXpc = new XPCollection(tempUow, typeof(Process))
        //        //    {
        //        //        Criteria = CriteriaOperator.Parse("BasicCase.n_CaseID = ? AND s_Status <> 'U' ", n_CaseID),
        //        //        Sorting = new SortingCollection(new SortProperty("n_OrderNum", SortingDirection.Descending))
        //        //    };
        //        //    return proXpc.Count == 0 ? null : proXpc[0] as Process;
        //        //}

        //    };
        //    set {  };
        //}

        /// <summary>
        ///     当前程序，高级查询使用
        /// </summary>
        public DateTime CurrentProcessStartDate
        {
            get
            {
                //Processes.Reload();
                //Processes.Filter = CriteriaOperator.Parse(" ");
                //Processes.Sorting = new SortingCollection(new SortProperty("n_OrderNum", SortingDirection.Descending));
                //Process pro = Processes.Count == 0 ? null : Processes[0] as Process;
                //Processes.Filter = CriteriaOperator.Parse("1 = 1 ");
                //return pro;
                using (var tempUow = new UnitOfWork())
                {
                    var proXpc = new XPCollection(tempUow, typeof(Process))
                    {
                        Criteria = CriteriaOperator.Parse("BasicCase.n_CaseID = ? AND s_Status <> 'U' ", n_CaseID),
                        Sorting = new SortingCollection(new SortProperty("n_OrderNum", SortingDirection.Descending))
                    };
                    return proXpc.Count == 0 ? DateTime.MinValue : ((Process)proXpc[0]).dt_StartDate;
                }
            }
        }

        /// <summary>
        ///     申请人，高级查询使用
        /// </summary>
        public string ApplicantName
        {
            get
            {
                string sName = string.Empty;
                foreach (Applicant applicant in Applicants)
                {
                    if (applicant == null) continue;
                    sName += applicant.s_Name + " ";
                }
                return sName;
            }
        }

        /// <summary>
        ///     申请人地址，高级查询使用
        /// </summary>
        public string ApplicantAddress
        {
            get
            {
                string sAdd = string.Empty;
                using (var tempUow = new UnitOfWork())
                {
                    foreach (Applicant applicant in Applicants)
                    {
                        if (applicant == null) continue;
                        sAdd += (tempUow.GetObjectByKey<CodeCountry>(applicant.n_Country) == null
                            ? string.Empty
                            : tempUow.GetObjectByKey<CodeCountry>(applicant.n_Country).s_Name) + " " +
                                applicant.s_State + " " + applicant.s_City + " " + applicant.s_Street + " ";
                    }
                }
                return sAdd;
            }
        }

        #endregion

        #region 触发器字段

        private string fs_Applicants;
        private string fs_ClientContacts;
        private string fs_Dealers;

        private string fs_DealersID;

        [Size(1000)]
        public string s_Applicants
        {
            get { return fs_Applicants; }
            set { SetPropertyValue("s_Applicants", ref fs_Applicants, value); }
        }

        string fs_ApplicantsNativeName;
        [Size(1000)]
        public string s_ApplicantsNativeName
        {
            get { return fs_ApplicantsNativeName; }
            set { SetPropertyValue<string>("s_ApplicantsNativeName", ref fs_ApplicantsNativeName, value); }
        }

        [Size(1000)]
        public string s_DealersID
        {
            get { return fs_DealersID; }
            set { SetPropertyValue("s_DealersID", ref fs_DealersID, value); }
        }

        [Size(1000)]
        public string s_Dealers
        {
            get { return fs_Dealers; }
            set { SetPropertyValue("s_Dealers", ref fs_Dealers, value); }
        }

        [Size(1000)]
        public string s_ClientContacts
        {
            get { return fs_ClientContacts; }
            set { SetPropertyValue("s_ClientContacts", ref fs_ClientContacts, value); }
        }

        #endregion

        #region 档案管理

        [Size(1), Delayed("fs_ArchiveStatus")]
        public string s_ArchiveStatus
        {
            get { return fs_ArchiveStatus.Value == null ? "I" : (string)fs_ArchiveStatus.Value; }
            set { fs_ArchiveStatus.Value = value; }
        }

        [Size(100), Delayed("fs_ArchivePosition")]
        public string s_ArchivePosition
        {
            get { return fs_ArchivePosition.Value == null ? "I" : (string)fs_ArchivePosition.Value; }
            set { fs_ArchivePosition.Value = value; }
        }

        [Delayed("fn_BorrowTimes")]
        public int n_BorrowTimes
        {
            get { return fn_BorrowTimes.Value == null ? 0 : (int)fn_BorrowTimes.Value; }
            set { fn_BorrowTimes.Value = value; }
        }

        #endregion

        #region 付款人信息
        [Delayed("fs_PayerBillToName")]
        [Size(300)]
        public string s_PayerBillToName
        {
            get { return (string)fs_PayerBillToName.Value; }
            set { fs_PayerBillToName.Value = value; }
        }


        [Delayed("fs_PayerStreet")]
        [Size(300)]
        public string s_PayerStreet
        {
            get { return (string)fs_PayerStreet.Value; }
            set { fs_PayerStreet.Value = value; }
        }

        [Delayed("fs_PayerCity")]
        public string s_PayerCity
        {
            get { return (string)fs_PayerCity.Value; }
            set { fs_PayerCity.Value = value; }
        }

        [Delayed("fs_PayerState")]
        public string s_PayerState
        {
            get { return (string)fs_PayerState.Value; }
            set { fs_PayerState.Value = value; }
        }

        [Delayed("fn_PayerCountry")]
        public int n_PayerCountry
        {
            get
            {
                if (fn_PayerCountry.Value == null)
                {
                    return -1;
                }
                return (int)fn_PayerCountry.Value;
            }
            set { fn_PayerCountry.Value = value; }
        }

        [Delayed("fs_PayerZipCode")]
        [Size(50)]
        public string s_PayerZipCode
        {
            get { return (string)fs_PayerZipCode.Value; }
            set { fs_PayerZipCode.Value = value; }
        }

        [Delayed("fs_PayerEmail")]
        [Size(100)]
        public string s_PayerEmail
        {
            get { return (string)fs_PayerEmail.Value; }
            set { fs_PayerEmail.Value = value; }
        }

        #endregion

        #region method
        /// <summary>
        /// 获取此案件相关联的任务链s
        /// </summary>
        /// <returns></returns>
        public List<TFTaskChain> GetRelateTaskChains()
        {
            var uow = new UnitOfWork();
            var lstFileIds = new XPCollection<FileInCase>(uow, CriteriaOperator.Parse("TheCase.n_CaseID = ?", n_CaseID)).Where(f => f.TheFile != null).Select(f => f.TheFile.n_FileID).ToList();
            List<TFTaskChain> lst;
            if (lstFileIds.Count > 0)
            {
                lst = new XPCollection<TFTaskChain>(uow, CriteriaOperator.Parse(string.Format("(s_RelatedObjectType='Case' AND n_RelatedObjectID = ?) OR (s_RelatedObjectType='CameFileOfficial' AND n_RelatedObjectID in ({0}))", string.Join(",", lstFileIds.ToArray())), n_CaseID)).ToList();
            }
            else
            {
                lst = new XPCollection<TFTaskChain>(uow, CriteriaOperator.Parse("s_RelatedObjectType='Case' AND n_RelatedObjectID = ?", n_CaseID)).ToList();
            }
            return lst;
        }
        #endregion

        #region 地址

        public string GetCaseFirstOfficeAddress()
        {
            var caseContact = this.Contacts.Cast<CaseContact>().OrderBy(f => f.n_Sequence).FirstOrDefault(c => c.ContactAddress1Type.Contains("O") || c.ContactAddress2Type.Contains("O") || c.ContactAddress2Type.Contains("O"));
            if (caseContact == null) return string.Empty;
            if (caseContact.ContactAddress1Type.Contains("O")) return caseContact.ContactAddress1;
            if (caseContact.ContactAddress2Type.Contains("O")) return caseContact.ContactAddress2;
            if (caseContact.ContactAddress3Type.Contains("O")) return caseContact.ContactAddress3;
            return string.Empty;
        }

        public string GetCaseFirstOfficeAddressEN()
        {
            var caseContact = this.Contacts.Cast<CaseContact>().OrderBy(f => f.n_Sequence).FirstOrDefault(c => c.ContactAddress1Type.Contains("O") || c.ContactAddress2Type.Contains("O") || c.ContactAddress2Type.Contains("O"));
            if (caseContact == null) return string.Empty;
            if (caseContact.ContactAddress1Type.Contains("O")) return caseContact.ContactAddress1EN;
            if (caseContact.ContactAddress2Type.Contains("O")) return caseContact.ContactAddress2EN;
            if (caseContact.ContactAddress3Type.Contains("O")) return caseContact.ContactAddress3EN;
            return string.Empty;
        }

        public string GetCaseFirstOfficeAddressStreet()
        {
            var caseContact = this.Contacts.Cast<CaseContact>().OrderBy(f => f.n_Sequence).FirstOrDefault(c => c.ContactAddress1Type.Contains("O") || c.ContactAddress2Type.Contains("O") || c.ContactAddress2Type.Contains("O"));
            if (caseContact == null) return string.Empty;
            if (caseContact.ContactAddress1Type.Contains("O")) return caseContact.ContactAddress1Street;
            if (caseContact.ContactAddress2Type.Contains("O")) return caseContact.ContactAddress2Street;
            if (caseContact.ContactAddress3Type.Contains("O")) return caseContact.ContactAddress3Street;
            return string.Empty;
        }

        public string GetCaseFirstOfficeAddressZipCode()
        {
            var caseContact = this.Contacts.Cast<CaseContact>().OrderBy(f => f.n_Sequence).FirstOrDefault(c => c.ContactAddress1Type.Contains("O") || c.ContactAddress2Type.Contains("O") || c.ContactAddress2Type.Contains("O"));
            if (caseContact == null) return string.Empty;
            if (caseContact.ContactAddress1Type.Contains("O")) return caseContact.ContactAddress1ZipCode;
            if (caseContact.ContactAddress2Type.Contains("O")) return caseContact.ContactAddress2ZipCode;
            if (caseContact.ContactAddress3Type.Contains("O")) return caseContact.ContactAddress3ZipCode;
            return string.Empty;
        }

        public string GetCaseFirstOfficeENAddress()
        {
            var caseContact = this.Contacts.Cast<CaseContact>().OrderBy(f => f.n_Sequence).FirstOrDefault(c => c.ContactAddress1Type.Contains("E") || c.ContactAddress2Type.Contains("E") || c.ContactAddress2Type.Contains("E"));
            if (caseContact == null) return string.Empty;
            if (caseContact.ContactAddress1Type.Contains("E")) return caseContact.ContactAddress1;
            if (caseContact.ContactAddress2Type.Contains("E")) return caseContact.ContactAddress2;
            if (caseContact.ContactAddress3Type.Contains("E")) return caseContact.ContactAddress3;
            return string.Empty;
        }

        public string GetCaseFirstOfficeENAddressEN()
        {
            var caseContact = this.Contacts.Cast<CaseContact>().OrderBy(f => f.n_Sequence).FirstOrDefault(c => c.ContactAddress1Type.Contains("E") || c.ContactAddress2Type.Contains("E") || c.ContactAddress2Type.Contains("E"));
            if (caseContact == null) return string.Empty;
            if (caseContact.ContactAddress1Type.Contains("E")) return caseContact.ContactAddress1EN;
            if (caseContact.ContactAddress2Type.Contains("E")) return caseContact.ContactAddress2EN;
            if (caseContact.ContactAddress3Type.Contains("E")) return caseContact.ContactAddress3EN;
            return string.Empty;
        }

        public string GetCaseFirstOfficeENAddressStreet()
        {
            var caseContact = this.Contacts.Cast<CaseContact>().OrderBy(f => f.n_Sequence).FirstOrDefault(c => c.ContactAddress1Type.Contains("E") || c.ContactAddress2Type.Contains("E") || c.ContactAddress2Type.Contains("E"));
            if (caseContact == null) return string.Empty;
            if (caseContact.ContactAddress1Type.Contains("E")) return caseContact.ContactAddress1Street;
            if (caseContact.ContactAddress2Type.Contains("E")) return caseContact.ContactAddress2Street;
            if (caseContact.ContactAddress3Type.Contains("E")) return caseContact.ContactAddress3Street;
            return string.Empty;
        }

        public string GetCaseFirstOfficeENAddressZipCode()
        {
            var caseContact = this.Contacts.Cast<CaseContact>().OrderBy(f => f.n_Sequence).FirstOrDefault(c => c.ContactAddress1Type.Contains("E") || c.ContactAddress2Type.Contains("E") || c.ContactAddress2Type.Contains("E"));
            if (caseContact == null) return string.Empty;
            if (caseContact.ContactAddress1Type.Contains("E")) return caseContact.ContactAddress1ZipCode;
            if (caseContact.ContactAddress2Type.Contains("E")) return caseContact.ContactAddress2ZipCode;
            if (caseContact.ContactAddress3Type.Contains("E")) return caseContact.ContactAddress3ZipCode;
            return string.Empty;
        }

        public string GetCaseFirstBillAddress()
        {
            var caseContact = this.Contacts.Cast<CaseContact>().OrderBy(f => f.n_Sequence).FirstOrDefault(c => c.ContactAddress1Type.Contains("B") || c.ContactAddress2Type.Contains("B") || c.ContactAddress2Type.Contains("B"));
            if (caseContact == null) return string.Empty;
            if (caseContact.ContactAddress1Type.Contains("B")) return caseContact.ContactAddress1;
            if (caseContact.ContactAddress2Type.Contains("B")) return caseContact.ContactAddress2;
            if (caseContact.ContactAddress3Type.Contains("B")) return caseContact.ContactAddress3;
            return string.Empty;
        }

        public string GetCaseFirstBillAddressEN()
        {
            var caseContact = this.Contacts.Cast<CaseContact>().OrderBy(f => f.n_Sequence).FirstOrDefault(c => c.ContactAddress1Type.Contains("B") || c.ContactAddress2Type.Contains("B") || c.ContactAddress2Type.Contains("B"));
            if (caseContact == null) return string.Empty;
            if (caseContact.ContactAddress1Type.Contains("B")) return caseContact.ContactAddress1EN;
            if (caseContact.ContactAddress2Type.Contains("B")) return caseContact.ContactAddress2EN;
            if (caseContact.ContactAddress3Type.Contains("B")) return caseContact.ContactAddress3EN;
            return string.Empty;
        }

        public string GetCaseFirstBillAddressStreet()
        {
            var caseContact = this.Contacts.Cast<CaseContact>().OrderBy(f => f.n_Sequence).FirstOrDefault(c => c.ContactAddress1Type.Contains("B") || c.ContactAddress2Type.Contains("B") || c.ContactAddress2Type.Contains("B"));
            if (caseContact == null) return string.Empty;
            if (caseContact.ContactAddress1Type.Contains("B")) return caseContact.ContactAddress1Street;
            if (caseContact.ContactAddress2Type.Contains("B")) return caseContact.ContactAddress2Street;
            if (caseContact.ContactAddress3Type.Contains("B")) return caseContact.ContactAddress3Street;
            return string.Empty;
        }

        public string GetCaseFirstBillAddressZipCode()
        {
            var caseContact = this.Contacts.Cast<CaseContact>().OrderBy(f => f.n_Sequence).FirstOrDefault(c => c.ContactAddress1Type.Contains("B") || c.ContactAddress2Type.Contains("B") || c.ContactAddress2Type.Contains("B"));
            if (caseContact == null) return string.Empty;
            if (caseContact.ContactAddress1Type.Contains("B")) return caseContact.ContactAddress1ZipCode;
            if (caseContact.ContactAddress2Type.Contains("B")) return caseContact.ContactAddress2ZipCode;
            if (caseContact.ContactAddress3Type.Contains("B")) return caseContact.ContactAddress3ZipCode;
            return string.Empty;
        }

        public string GetCaseFirstMailAddress()
        {
            var caseContact = this.Contacts.Cast<CaseContact>().OrderBy(f => f.n_Sequence).FirstOrDefault(c => c.ContactAddress1Type.Contains("M") || c.ContactAddress2Type.Contains("M") || c.ContactAddress2Type.Contains("M"));
            if (caseContact == null) return string.Empty;
            if (caseContact.ContactAddress1Type.Contains("M")) return caseContact.ContactAddress1;
            if (caseContact.ContactAddress2Type.Contains("M")) return caseContact.ContactAddress2;
            if (caseContact.ContactAddress3Type.Contains("M")) return caseContact.ContactAddress3;
            return string.Empty;
        }

        public string GetCaseFirstMailAddressEN()
        {
            var caseContact = this.Contacts.Cast<CaseContact>().OrderBy(f => f.n_Sequence).FirstOrDefault(c => c.ContactAddress1Type.Contains("M") || c.ContactAddress2Type.Contains("M") || c.ContactAddress2Type.Contains("M"));
            if (caseContact == null) return string.Empty;
            if (caseContact.ContactAddress1Type.Contains("M")) return caseContact.ContactAddress1EN;
            if (caseContact.ContactAddress2Type.Contains("M")) return caseContact.ContactAddress2EN;
            if (caseContact.ContactAddress3Type.Contains("M")) return caseContact.ContactAddress3EN;
            return string.Empty;
        }

        public string GetCaseFirstMailAddressStreet()
        {
            var caseContact = this.Contacts.Cast<CaseContact>().OrderBy(f => f.n_Sequence).FirstOrDefault(c => c.ContactAddress1Type.Contains("M") || c.ContactAddress2Type.Contains("M") || c.ContactAddress2Type.Contains("M"));
            if (caseContact == null) return string.Empty;
            if (caseContact.ContactAddress1Type.Contains("M")) return caseContact.ContactAddress1Street;
            if (caseContact.ContactAddress2Type.Contains("M")) return caseContact.ContactAddress2Street;
            if (caseContact.ContactAddress3Type.Contains("M")) return caseContact.ContactAddress3Street;
            return string.Empty;
        }

        public string GetCaseFirstMailAddressZipCode()
        {
            var caseContact = this.Contacts.Cast<CaseContact>().OrderBy(f => f.n_Sequence).FirstOrDefault(c => c.ContactAddress1Type.Contains("M") || c.ContactAddress2Type.Contains("M") || c.ContactAddress2Type.Contains("M"));
            if (caseContact == null) return string.Empty;
            if (caseContact.ContactAddress1Type.Contains("M")) return caseContact.ContactAddress1ZipCode;
            if (caseContact.ContactAddress2Type.Contains("M")) return caseContact.ContactAddress2ZipCode;
            if (caseContact.ContactAddress3Type.Contains("M")) return caseContact.ContactAddress3ZipCode;
            return string.Empty;
        }

        #endregion

        #region 案件联系人

        public string GetCaseFirstContactName()
        {
            var caseContact = this.Contacts.Cast<CaseContact>().OrderBy(f => f.n_Sequence).FirstOrDefault();
            if (caseContact == null) return string.Empty;
            return caseContact.ContactName;
        }

        public string GetCaseFirstContactLastName()
        {
            var caseContact = this.Contacts.Cast<CaseContact>().OrderBy(f => f.n_Sequence).FirstOrDefault();
            if (caseContact == null) return string.Empty;
            return caseContact.ContactLastName;
        }

        public string GetCaseFirstContactFirstName()
        {
            var caseContact = this.Contacts.Cast<CaseContact>().OrderBy(f => f.n_Sequence).FirstOrDefault();
            if (caseContact == null) return string.Empty;
            return caseContact.ContactFirstName;
        }

        public string GetCaseFirstContactPrefix()
        {
            var caseContact = this.Contacts.Cast<CaseContact>().OrderBy(f => f.n_Sequence).FirstOrDefault();
            if (caseContact == null) return string.Empty;
            return caseContact.ContactPrefix;
        }

        public string GetCaseFirstContactEmail()
        {
            var caseContact = this.Contacts.Cast<CaseContact>().OrderBy(f => f.n_Sequence).FirstOrDefault();
            if (caseContact == null) return string.Empty;
            return caseContact.ContactEmail;
        }

        public string GetCaseFirstContactPhone()
        {
            var caseContact = this.Contacts.Cast<CaseContact>().OrderBy(f => f.n_Sequence).FirstOrDefault();
            if (caseContact == null) return string.Empty;
            return caseContact.ContactPhone;
        }

        public string GetCaseFirstContactFax()
        {
            var caseContact = this.Contacts.Cast<CaseContact>().OrderBy(f => f.n_Sequence).FirstOrDefault();
            if (caseContact == null) return string.Empty;
            return caseContact.ContactFax;
        }

        public string GetCaseFirstContactMobile()
        {
            var caseContact = this.Contacts.Cast<CaseContact>().OrderBy(f => f.n_Sequence).FirstOrDefault();
            if (caseContact == null) return string.Empty;
            return caseContact.ContactMobile;
        }

        public string GetCaseFirstContactAddress1()
        {
            var caseContact = this.Contacts.Cast<CaseContact>().OrderBy(f => f.n_Sequence).FirstOrDefault();
            if (caseContact == null) return string.Empty;
            return caseContact.ContactAddress1;
        }

        public string GetCaseFirstContactAddress1EN()
        {
            var caseContact = this.Contacts.Cast<CaseContact>().OrderBy(f => f.n_Sequence).FirstOrDefault();
            if (caseContact == null) return string.Empty;
            return caseContact.ContactAddress1EN;
        }

        public string GetCaseFirstContactAddress1Street()
        {
            var caseContact = this.Contacts.Cast<CaseContact>().OrderBy(f => f.n_Sequence).FirstOrDefault();
            if (caseContact == null) return string.Empty;
            return caseContact.ContactAddress1Street;
        }

        public string GetCaseFirstContactAddress1ZipCode()
        {
            var caseContact = this.Contacts.Cast<CaseContact>().OrderBy(f => f.n_Sequence).FirstOrDefault();
            if (caseContact == null) return string.Empty;
            return caseContact.ContactAddress1ZipCode;
        }

        public string GetCaseFirstContactAddress2()
        {
            var caseContact = this.Contacts.Cast<CaseContact>().OrderBy(f => f.n_Sequence).FirstOrDefault();
            if (caseContact == null) return string.Empty;
            return caseContact.ContactAddress2;
        }

        public string GetCaseFirstContactAddress2EN()
        {
            var caseContact = this.Contacts.Cast<CaseContact>().OrderBy(f => f.n_Sequence).FirstOrDefault();
            if (caseContact == null) return string.Empty;
            return caseContact.ContactAddress2EN;
        }

        public string GetCaseFirstContactAddress2Street()
        {
            var caseContact = this.Contacts.Cast<CaseContact>().OrderBy(f => f.n_Sequence).FirstOrDefault();
            if (caseContact == null) return string.Empty;
            return caseContact.ContactAddress2Street;
        }

        public string GetCaseFirstContactAddress2ZipCode()
        {
            var caseContact = this.Contacts.Cast<CaseContact>().OrderBy(f => f.n_Sequence).FirstOrDefault();
            if (caseContact == null) return string.Empty;
            return caseContact.ContactAddress2ZipCode;
        }

        public string GetCaseFirstContactAddress3()
        {
            var caseContact = this.Contacts.Cast<CaseContact>().OrderBy(f => f.n_Sequence).FirstOrDefault();
            if (caseContact == null) return string.Empty;
            return caseContact.ContactAddress3;
        }

        public string GetCaseFirstContactAddress3EN()
        {
            var caseContact = this.Contacts.Cast<CaseContact>().OrderBy(f => f.n_Sequence).FirstOrDefault();
            if (caseContact == null) return string.Empty;
            return caseContact.ContactAddress3EN;
        }

        public string GetCaseFirstContactAddress3Street()
        {
            var caseContact = this.Contacts.Cast<CaseContact>().OrderBy(f => f.n_Sequence).FirstOrDefault();
            if (caseContact == null) return string.Empty;
            return caseContact.ContactAddress3Street;
        }

        public string GetCaseFirstContactAddress3ZipCode()
        {
            var caseContact = this.Contacts.Cast<CaseContact>().OrderBy(f => f.n_Sequence).FirstOrDefault();
            if (caseContact == null) return string.Empty;
            return caseContact.ContactAddress3ZipCode;
        }

        public string GetCaseSpecificContactName(string sIdentity)
        {
            var caseContact = this.Contacts.Cast<CaseContact>().OrderBy(f => f.n_Sequence).FirstOrDefault(c => c.s_Identity == sIdentity);
            if (caseContact == null) return string.Empty;
            return caseContact.ContactName;
        }

        public string GetCaseSpecificContactLastName(string sIdentity)
        {
            var caseContact = this.Contacts.Cast<CaseContact>().OrderBy(f => f.n_Sequence).FirstOrDefault(c => c.s_Identity == sIdentity);
            if (caseContact == null) return string.Empty;
            return caseContact.ContactLastName;
        }

        public string GetCaseSpecificContactFirstName(string sIdentity)
        {
            var caseContact = this.Contacts.Cast<CaseContact>().OrderBy(f => f.n_Sequence).FirstOrDefault(c => c.s_Identity == sIdentity);
            if (caseContact == null) return string.Empty;
            return caseContact.ContactFirstName;
        }

        public string GetCaseSpecificContactPrefix(string sIdentity)
        {
            var caseContact = this.Contacts.Cast<CaseContact>().OrderBy(f => f.n_Sequence).FirstOrDefault(c => c.s_Identity == sIdentity);
            if (caseContact == null) return string.Empty;
            return caseContact.ContactPrefix;
        }

        public string GetCaseSpecificContactEmail(string sIdentity)
        {
            var caseContact = this.Contacts.Cast<CaseContact>().OrderBy(f => f.n_Sequence).FirstOrDefault(c => c.s_Identity == sIdentity);
            if (caseContact == null) return string.Empty;
            return caseContact.ContactEmail;
        }

        public string GetCaseSpecificContactPhone(string sIdentity)
        {
            var caseContact = this.Contacts.Cast<CaseContact>().OrderBy(f => f.n_Sequence).FirstOrDefault(c => c.s_Identity == sIdentity);
            if (caseContact == null) return string.Empty;
            return caseContact.ContactPhone;
        }

        public string GetCaseSpecificContactFax(string sIdentity)
        {
            var caseContact = this.Contacts.Cast<CaseContact>().OrderBy(f => f.n_Sequence).FirstOrDefault(c => c.s_Identity == sIdentity);
            if (caseContact == null) return string.Empty;
            return caseContact.ContactFax;
        }

        public string GetCaseSpecificContactMobile(string sIdentity)
        {
            var caseContact = this.Contacts.Cast<CaseContact>().OrderBy(f => f.n_Sequence).FirstOrDefault(c => c.s_Identity == sIdentity);
            if (caseContact == null) return string.Empty;
            return caseContact.ContactMobile;
        }

        public string GetCaseSpecificContactAddress1(string sIdentity)
        {
            var caseContact = this.Contacts.Cast<CaseContact>().OrderBy(f => f.n_Sequence).FirstOrDefault(c => c.s_Identity == sIdentity);
            if (caseContact == null) return string.Empty;
            return caseContact.ContactAddress1;
        }

        public string GetCaseSpecificContactAddress1EN(string sIdentity)
        {
            var caseContact = this.Contacts.Cast<CaseContact>().OrderBy(f => f.n_Sequence).FirstOrDefault(c => c.s_Identity == sIdentity);
            if (caseContact == null) return string.Empty;
            return caseContact.ContactAddress1EN;
        }

        public string GetCaseSpecificContactAddress1Street(string sIdentity)
        {
            var caseContact = this.Contacts.Cast<CaseContact>().OrderBy(f => f.n_Sequence).FirstOrDefault(c => c.s_Identity == sIdentity);
            if (caseContact == null) return string.Empty;
            return caseContact.ContactAddress1Street;
        }

        public string GetCaseSpecificContactAddress1ZipCode(string sIdentity)
        {
            var caseContact = this.Contacts.Cast<CaseContact>().OrderBy(f => f.n_Sequence).FirstOrDefault(c => c.s_Identity == sIdentity);
            if (caseContact == null) return string.Empty;
            return caseContact.ContactAddress1ZipCode;
        }

        public string GetCaseSpecificContactAddress2(string sIdentity)
        {
            var caseContact = this.Contacts.Cast<CaseContact>().OrderBy(f => f.n_Sequence).FirstOrDefault(c => c.s_Identity == sIdentity);
            if (caseContact == null) return string.Empty;
            return caseContact.ContactAddress2;
        }

        public string GetCaseSpecificContactAddress2EN(string sIdentity)
        {
            var caseContact = this.Contacts.Cast<CaseContact>().OrderBy(f => f.n_Sequence).FirstOrDefault(c => c.s_Identity == sIdentity);
            if (caseContact == null) return string.Empty;
            return caseContact.ContactAddress2EN;
        }

        public string GetCaseSpecificContactAddress2Street(string sIdentity)
        {
            var caseContact = this.Contacts.Cast<CaseContact>().OrderBy(f => f.n_Sequence).FirstOrDefault(c => c.s_Identity == sIdentity);
            if (caseContact == null) return string.Empty;
            return caseContact.ContactAddress2Street;
        }

        public string GetCaseSpecificContactAddress2ZipCode(string sIdentity)
        {
            var caseContact = this.Contacts.Cast<CaseContact>().OrderBy(f => f.n_Sequence).FirstOrDefault(c => c.s_Identity == sIdentity);
            if (caseContact == null) return string.Empty;
            return caseContact.ContactAddress2ZipCode;
        }

        public string GetCaseSpecificContactAddress3(string sIdentity)
        {
            var caseContact = this.Contacts.Cast<CaseContact>().OrderBy(f => f.n_Sequence).FirstOrDefault(c => c.s_Identity == sIdentity);
            if (caseContact == null) return string.Empty;
            return caseContact.ContactAddress3;
        }

        public string GetCaseSpecificContactAddress3EN(string sIdentity)
        {
            var caseContact = this.Contacts.Cast<CaseContact>().OrderBy(f => f.n_Sequence).FirstOrDefault(c => c.s_Identity == sIdentity);
            if (caseContact == null) return string.Empty;
            return caseContact.ContactAddress3EN;
        }

        public string GetCaseSpecificContactAddress3Street(string sIdentity)
        {
            var caseContact = this.Contacts.Cast<CaseContact>().OrderBy(f => f.n_Sequence).FirstOrDefault(c => c.s_Identity == sIdentity);
            if (caseContact == null) return string.Empty;
            return caseContact.ContactAddress3Street;
        }

        public string GetCaseSpecificContactAddress3ZipCode(string sIdentity)
        {
            var caseContact = this.Contacts.Cast<CaseContact>().OrderBy(f => f.n_Sequence).FirstOrDefault(c => c.s_Identity == sIdentity);
            if (caseContact == null) return string.Empty;
            return caseContact.ContactAddress3ZipCode;
        }

        #endregion

        public BasicCase(Session session) : base(session) { }
        public BasicCase() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }

        #region Common Method For Update

        private DateTime fdt_EarlistPriorityDate;
        [NonPersistent]
        public DateTime dt_EarlistPriorityDate
        {
            get { return fdt_EarlistPriorityDate; }
            set { SetPropertyValue<DateTime>("dt_EarlistPriorityDate", ref fdt_EarlistPriorityDate, value); }
        }

        public DateTime GetEarlistPriorityDate()
        {
            var dtEarlistPriorityDate = DateTime.MinValue;
            var patent = this as ExtendedPatent;
            if (patent != null)
            {
                var firstPriority = patent.Priorities.Cast<DataEntities.Case.Patents.Priority>().OrderBy(p => p.dt_PDate).FirstOrDefault();
                if (firstPriority != null) dtEarlistPriorityDate = firstPriority.dt_PDate;
            }
            var trademark = this as ExtendedTrademark;
            if (trademark != null)
            {
                var firstPriority = trademark.Priorities.Cast<DataEntities.Case.Trademarks.Priority>().OrderBy(p => p.dt_PDate).FirstOrDefault();
                if (firstPriority != null) dtEarlistPriorityDate = firstPriority.dt_PDate;
            }
            return dtEarlistPriorityDate;
        }

        private DateTime fdt_AppDateOrEarlyPriorityDate;
        [NonPersistent]
        public DateTime dt_AppDateOrEarlyPriorityDate
        {
            get { return fdt_AppDateOrEarlyPriorityDate; }
            set { SetPropertyValue<DateTime>("dt_AppDateOrEarlyPriorityDate", ref fdt_AppDateOrEarlyPriorityDate, value); }
        }

        public DateTime GetAppDateOrEarlyPriorityDate()
        {
            var result = GetEarlistPriorityDate();
            if (result != DateTime.MinValue) return result;
            var patent = this as ExtendedPatent;
            if (patent != null)
            {
                if (patent.TheLawInfo != null)
                {
                    result = this is CasePCTI ? patent.TheLawInfo.dt_PCTAppDate : patent.TheLawInfo.dt_AppDate;
                }
            }
            var trademark = this as ExtendedTrademark;
            if (trademark != null)
            {
                if (trademark.TheLawInfo != null)
                {
                    result = trademark.TheLawInfo.dt_AppDate;
                }
            }
            return result;
        }

        private DateTime fdt_PatentDivRequestSubmitDate;
        [NonPersistent]
        public DateTime dt_PatentDivRequestSubmitDate
        {
            get { return fdt_PatentDivRequestSubmitDate; }
            set { SetPropertyValue<DateTime>("dt_PatentDivRequestSubmitDate", ref fdt_PatentDivRequestSubmitDate, value); }
        }

        public DateTime GetPatentDivRequestSubmitDate()
        {
            var patent = this as ExtendedPatent;
            if (patent == null || patent.TheLawInfo == null) return DateTime.MinValue;
            var dtDivRequestSubmitDate = patent.TheLawInfo.dt_AppDate;
            var dtEarlistPriorityDate = GetEarlistPriorityDate();
            var dtDivSubmitDate = patent.dt_DivSubmitDate;

            if (dtEarlistPriorityDate < dtDivRequestSubmitDate) dtDivRequestSubmitDate = dtEarlistPriorityDate;
            if (dtDivRequestSubmitDate == DateTime.MinValue) return dtDivRequestSubmitDate;
            dtDivRequestSubmitDate = dtDivRequestSubmitDate.AddYears(3);
            if (dtDivSubmitDate != DateTime.MinValue)
            {
                dtDivSubmitDate = dtDivSubmitDate.AddMonths(2);
                if (dtDivSubmitDate > dtDivRequestSubmitDate) dtDivRequestSubmitDate = dtDivSubmitDate;
            }
            return dtDivRequestSubmitDate;
        }

        protected List<ConmonFunctionForUpdate.MonitorField> _listBeMonitorField;
        protected XPLiteObject _xplCopyOfObject;

        protected override void OnLoaded()
        {
            base.OnLoaded();
            dt_EarlistPriorityDate = GetEarlistPriorityDate();
            dt_AppDateOrEarlyPriorityDate = GetAppDateOrEarlyPriorityDate();
            dt_PatentDivRequestSubmitDate = GetPatentDivRequestSubmitDate();
            _listBeMonitorField = new List<ConmonFunctionForUpdate.MonitorField>
            {
                new ConmonFunctionForUpdate.MonitorField{MonitorType = ConmonFunctionForUpdate.EnumMonitorType.Deadline,FieldName = "dt_CreateDate",CodeNameSpace = "DataEntities.Case.BasicCase",CodeFieldName = "dt_CreateDate"},
                new ConmonFunctionForUpdate.MonitorField{MonitorType = ConmonFunctionForUpdate.EnumMonitorType.Deadline,FieldName = "dt_UndertakeDate",CodeNameSpace = "DataEntities.Case.BasicCase",CodeFieldName = "dt_UndertakeDate"},
                new ConmonFunctionForUpdate.MonitorField{MonitorType = ConmonFunctionForUpdate.EnumMonitorType.Deadline,FieldName = "dt_ShldSbmtDate",CodeNameSpace = "DataEntities.Case.BasicCase",CodeFieldName = "dt_ShldSbmtDate"},
                new ConmonFunctionForUpdate.MonitorField{MonitorType = ConmonFunctionForUpdate.EnumMonitorType.Deadline,FieldName = "dt_SubmitDate",CodeNameSpace = "DataEntities.Case.BasicCase",CodeFieldName = "dt_SubmitDate"},
                new ConmonFunctionForUpdate.MonitorField{MonitorType = ConmonFunctionForUpdate.EnumMonitorType.Deadline,FieldName = "dt_RequestSubmitDate",CodeNameSpace = "DataEntities.Case.Patents.BasicPatent",CodeFieldName = "dt_RequestSubmitDate"},
                new ConmonFunctionForUpdate.MonitorField{MonitorType = ConmonFunctionForUpdate.EnumMonitorType.Deadline,FieldName = "dt_DivSubmitDate",CodeNameSpace = "DataEntities.Case.Patents.BasicPatent",CodeFieldName = "dt_DivSubmitDate"},
                new ConmonFunctionForUpdate.MonitorField{MonitorType = ConmonFunctionForUpdate.EnumMonitorType.Deadline,FieldName = "dt_OrigAppDate",CodeNameSpace = "DataEntities.Case.Patents.BasicPatent",CodeFieldName = "dt_OrigAppDate"},
                new ConmonFunctionForUpdate.MonitorField{MonitorType = ConmonFunctionForUpdate.EnumMonitorType.Deadline,FieldName = "dt_1stRegisterDate",CodeNameSpace = "DataEntities.Case.Patents.HongKongApplication",CodeFieldName = "dt_1stRegisterDate"},
                new ConmonFunctionForUpdate.MonitorField{MonitorType = ConmonFunctionForUpdate.EnumMonitorType.Deadline,FieldName = "dt_2ndRegisterDate",CodeNameSpace = "DataEntities.Case.Patents.HongKongApplication",CodeFieldName = "dt_2ndRegisterDate"},
                new ConmonFunctionForUpdate.MonitorField{MonitorType = ConmonFunctionForUpdate.EnumMonitorType.Deadline,FieldName = "dt_EarlistPriorityDate",CodeNameSpace = "DataEntities.Case.Patents.BasicPatent",CodeFieldName = "dt_EarlistPriorityDate"},
                new ConmonFunctionForUpdate.MonitorField{MonitorType = ConmonFunctionForUpdate.EnumMonitorType.Deadline,FieldName = "dt_EarlistPriorityDate",CodeNameSpace = "DataEntities.Case.Trademarks.BasicTrademark",CodeFieldName = "dt_EarlistPriorityDate"},
                new ConmonFunctionForUpdate.MonitorField{MonitorType = ConmonFunctionForUpdate.EnumMonitorType.Deadline,FieldName = "dt_AppDateOrEarlyPriorityDate",CodeNameSpace = "DataEntities.Case.Patents.BasicPatent",CodeFieldName = "dt_AppDateOrEarlyPriorityDate"},
                new ConmonFunctionForUpdate.MonitorField{MonitorType = ConmonFunctionForUpdate.EnumMonitorType.Deadline,FieldName = "dt_AppDateOrEarlyPriorityDate",CodeNameSpace = "DataEntities.Case.Trademarks.BasicTrademark",CodeFieldName = "dt_AppDateOrEarlyPriorityDate"},
                new ConmonFunctionForUpdate.MonitorField{MonitorType = ConmonFunctionForUpdate.EnumMonitorType.Deadline,FieldName = "dt_PatentDivRequestSubmitDate",CodeNameSpace = "DataEntities.Case.Patents.BasicPatent",CodeFieldName = "dt_PatentDivRequestSubmitDate"},
                new ConmonFunctionForUpdate.MonitorField{MonitorType = ConmonFunctionForUpdate.EnumMonitorType.RelatedInfo,FieldName = "s_CaseSerial",CodeNameSpace = "DataEntities.Case.BasicCase",CodeFieldName = "s_CaseSerial"},
                new ConmonFunctionForUpdate.MonitorField{MonitorType = ConmonFunctionForUpdate.EnumMonitorType.RelatedInfo,FieldName = "s_CaseName",CodeNameSpace = "DataEntities.Case.BasicCase",CodeFieldName = "s_CaseName"},
            };
            var type = this.GetType();
            _xplCopyOfObject = Activator.CreateInstance(type, new[] { new UnitOfWork() }) as XPLiteObject;
            ConmonFunctionForUpdate.CopyDataEntityFileds(this, _xplCopyOfObject, _listBeMonitorField);
        }

        protected override void OnSaved()
        {
            base.OnSaved();
            if (Session.IsNewObject(this)) return;
            dt_EarlistPriorityDate = GetEarlistPriorityDate();
            dt_AppDateOrEarlyPriorityDate = GetAppDateOrEarlyPriorityDate();
            dt_PatentDivRequestSubmitDate = GetPatentDivRequestSubmitDate();
            ConmonFunctionForUpdate.CompareDataEntityFiledsForDeadline(this, _xplCopyOfObject, _listBeMonitorField);
            ConmonFunctionForUpdate.CompareDataEntityFiledsForRelatedInfo(this, _xplCopyOfObject, _listBeMonitorField);
        }

        #endregion
    }
}
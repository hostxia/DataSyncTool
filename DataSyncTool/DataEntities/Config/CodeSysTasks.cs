using System;
using DataEntities.Properties;
using DevExpress.Xpo;

namespace DataEntities.Config
{
    [Persistent("TCode_SysTasks")]
    public class CodeSysTasks : XPLiteObject
    {
        private readonly XPDelayedProperty fn_EmployeeID = new XPDelayedProperty();
        private DateTime fdt_CreateDate;
        private DateTime fdt_EditDate;
        private int fn_AlarmDays;
        private int fn_AlarmMonths;
        private int fn_ClientDeadDays;
        private int fn_ClientDeadMonths;
        private int fn_ID;
        private int fn_InterDeadDays;
        private int fn_InterDeadMonths;
        private int fn_OfficialDeadDays;
        private int fn_OfficialDeadMonths;
        private int fn_ProcessID;
        private int fn_RegCountry;
        private string fs_AlarmCalcOrder;
        private string fs_AutoFinished;
        private string fs_AutoSendEmail;
        private string fs_BaseField;
        private string fs_Business;
        private string fs_Category;
        private string fs_ChangeDateSendEmail;
        private string fs_ClientDeadCalcOrder;
        private string fs_ClientDeadM;
        private string fs_InterDeadCalcOrder;
        private string fs_InterDeadM;
        private string fs_IsActive;
        private string fs_IsSystem;

        private string fs_MasterType;
        private string fs_OfficialDeadCalcOrder;
        private string fs_OfficialDeadM;
        private string fs_OtherName;
        private string fs_PTCType;
        private string fs_Priority;
        private string fs_RelatedElement;
        private string fs_RelatedElementStatus;
        private string fs_Relationer;
        private string fs_SysTaskCode;
        private string fs_SysTaskType;

        private string fs_TApplyType;
        private string fs_TaskDesc;
        private string fs_TaskName;
        private string fs_TaskType;

        public CodeSysTasks(Session session) : base(session)
        {
        }

        public CodeSysTasks() : base(Session.DefaultSession)
        {
        }

        [Key(true)]
        public int n_ID
        {
            get { return fn_ID; }
            set { SetPropertyValue<int>("n_ID", ref fn_ID, value); }
        }

        [Size(1)]
        public string s_IPType
        {
            get { return fs_MasterType; }
            set { SetPropertyValue("s_IPType", ref fs_MasterType, value); }
        }

        /// <summary>
        ///     “商标”，可配置此字段。S：单一国家申请； M：马德里申请
        /// </summary>
        [Size(1)]
        public string s_TApplyType
        {
            get { return fs_TApplyType; }
            set { SetPropertyValue("s_TApplyType", ref fs_TApplyType, value); }
        }

        public int n_RegCountry
        {
            get { return fn_RegCountry; }
            set { SetPropertyValue<int>("n_RegCountry", ref fn_RegCountry, value); }
        }

        [Size(8)]
        public string s_SysTaskCode
        {
            get { return fs_SysTaskCode; }
            set { SetPropertyValue("s_SysTaskCode", ref fs_SysTaskCode, value); }
        }

        [Size(300)]
        public string s_TaskName
        {
            get { return fs_TaskName; }
            set { SetPropertyValue("s_TaskName", ref fs_TaskName, value); }
        }

        [Size(200)]
        public string s_Relationer
        {
            get { return fs_Relationer; }
            set { SetPropertyValue("s_Relationer", ref fs_Relationer, value); }
        }

        [Size(300)]
        public string s_OtherName
        {
            get { return fs_OtherName; }
            set { SetPropertyValue("s_OtherName", ref fs_OtherName, value); }
        }

        [Size(600)]
        public string s_TaskDesc
        {
            get { return fs_TaskDesc; }
            set { SetPropertyValue("s_TaskDesc", ref fs_TaskDesc, value); }
        }

        [Size(500)]
        public string s_Business
        {
            get { return fs_Business; }
            set { SetPropertyValue("s_Business", ref fs_Business, value); }
        }

        [Size(500)]
        public string s_PTCType
        {
            get { return fs_PTCType; }
            set { SetPropertyValue("s_PTCType", ref fs_PTCType, value); }
        }

        public int n_ProcessID
        {
            get { return fn_ProcessID; }
            set { SetPropertyValue<int>("n_ProcessID", ref fn_ProcessID, value); }
        }

        [Size(1)]
        public string s_IsActive
        {
            get { return fs_IsActive; }
            set { SetPropertyValue("s_IsActive", ref fs_IsActive, value); }
        }

        [Size(300)]
        public string s_BaseField
        {
            get { return fs_BaseField; }
            set { SetPropertyValue("s_BaseField", ref fs_BaseField, value); }
        }

        public int n_AlarmDays
        {
            get { return fn_AlarmDays; }
            set { SetPropertyValue<int>("n_AlarmDays", ref fn_AlarmDays, value); }
        }

        public int n_AlarmMonths
        {
            get { return fn_AlarmMonths; }
            set { SetPropertyValue<int>("n_AlarmMonths", ref fn_AlarmMonths, value); }
        }

        [Size(2)]
        public string s_AlarmCalcOrder
        {
            get { return fs_AlarmCalcOrder; }
            set { SetPropertyValue("s_AlarmCalcOrder", ref fs_AlarmCalcOrder, value); }
        }

        public int n_OfficialDeadDays
        {
            get { return fn_OfficialDeadDays; }
            set { SetPropertyValue<int>("n_OfficialDeadDays", ref fn_OfficialDeadDays, value); }
        }

        public int n_OfficialDeadMonths
        {
            get { return fn_OfficialDeadMonths; }
            set { SetPropertyValue<int>("n_OfficialDeadMonths", ref fn_OfficialDeadMonths, value); }
        }

        [Size(2)]
        public string s_OfficialDeadCalcOrder
        {
            get { return fs_OfficialDeadCalcOrder; }
            set { SetPropertyValue("s_OfficialDeadCalcOrder", ref fs_OfficialDeadCalcOrder, value); }
        }


        [Size(30)]
        public string s_Category
        {
            get { return fs_Category; }
            set { SetPropertyValue("s_Category", ref fs_Category, value); }
        }

        [Size(1)]
        public string s_OfficialDeadM
        {
            get { return fs_OfficialDeadM; }
            set { SetPropertyValue("s_OfficialDeadM", ref fs_OfficialDeadM, value); }
        }

        [Size(1)]
        public string s_ClientDeadM
        {
            get { return fs_ClientDeadM; }
            set { SetPropertyValue("s_ClientDeadM", ref fs_ClientDeadM, value); }
        }

        [Size(1)]
        public string s_InterDeadM
        {
            get { return fs_InterDeadM; }
            set { SetPropertyValue("s_InterDeadM", ref fs_InterDeadM, value); }
        }

        public int n_ClientDeadDays
        {
            get { return fn_ClientDeadDays; }
            set { SetPropertyValue<int>("n_ClientDeadDays", ref fn_ClientDeadDays, value); }
        }

        public int n_ClientDeadMonths
        {
            get { return fn_ClientDeadMonths; }
            set { SetPropertyValue<int>("n_ClientDeadMonths", ref fn_ClientDeadMonths, value); }
        }

        [Size(2)]
        public string s_ClientDeadCalcOrder
        {
            get { return fs_ClientDeadCalcOrder; }
            set { SetPropertyValue("s_ClientDeadCalcOrder", ref fs_ClientDeadCalcOrder, value); }
        }

        public int n_InterDeadDays
        {
            get { return fn_InterDeadDays; }
            set { SetPropertyValue<int>("n_InterDeadDays", ref fn_InterDeadDays, value); }
        }

        public int n_InterDeadMonths
        {
            get { return fn_InterDeadMonths; }
            set { SetPropertyValue<int>("n_InterDeadMonths", ref fn_InterDeadMonths, value); }
        }

        [Size(2)]
        public string s_InterDeadCalcOrder
        {
            get { return fs_InterDeadCalcOrder; }
            set { SetPropertyValue("s_InterDeadCalcOrder", ref fs_InterDeadCalcOrder, value); }
        }

        [Size(50)]
        public string s_TaskType
        {
            get { return fs_TaskType; }
            set { SetPropertyValue("s_TaskType", ref fs_TaskType, value); }
        }

        [Size(1)]
        public string s_SysTaskType
        {
            get { return fs_SysTaskType; }
            set { SetPropertyValue("s_SysTaskType", ref fs_SysTaskType, value); }
        }

        [Size(1)]
        public string s_AutoSendEmail
        {
            get { return fs_AutoSendEmail; }
            set { SetPropertyValue("s_AutoSendEmail", ref fs_AutoSendEmail, value); }
        }

        [Size(1)]
        public string s_Priority
        {
            get { return fs_Priority; }
            set { SetPropertyValue("s_Priority", ref fs_Priority, value); }
        }

        [Delayed("fn_EmployeeID")]
        public int n_EmployeeID
        {
            get
            {
                if (fn_EmployeeID.Value == null)
                {
                    return -1;
                }
                return (int) fn_EmployeeID.Value;
            }
            set { fn_EmployeeID.Value = value; }
        }

        [Size(1)]
        public string s_IsSystem
        {
            get { return fs_IsSystem; }
            set { SetPropertyValue("s_IsSystem", ref fs_IsSystem, value); }
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


        [Size(1)]
        public string s_ChangeDateSendEmail
        {
            get { return fs_ChangeDateSendEmail; }
            set { SetPropertyValue("s_ChangeDateSendEmail", ref fs_ChangeDateSendEmail, value); }
        }

        [Size(1)]
        public string s_RelatedElement
        {
            get { return fs_RelatedElement; }
            set { SetPropertyValue("s_RelatedElement", ref fs_RelatedElement, value); }
        }

        [Size(50)]
        public string s_RelatedElementStatus
        {
            get { return fs_RelatedElementStatus; }
            set { SetPropertyValue("s_RelatedElementStatus", ref fs_RelatedElementStatus, value); }
        }

        [Size(1)]
        public string s_AutoFinished
        {
            get { return fs_AutoFinished; }
            set { SetPropertyValue("s_AutoFinished", ref fs_AutoFinished, value); }
        }

        [Aggregated, Association("CodeSysTask-CodeSysTaskCondition", typeof (CodeSysTasksCondition))]
        public XPCollection CodeSysTasksConditions
        {
            get { return GetCollection("CodeSysTasksConditions"); }
        }

        [Aggregated, Association("CodeSysTask-CodeCameFileInTask", typeof (CodeSysTaskInFile))]
        public XPCollection CodeCameFileInTasks
        {
            get { return GetCollection("CodeCameFileInTasks"); }
        }

        [Aggregated, Association("CodeSysTask-CodeSysTasksDemandCondition", typeof (CodeSysTasksDemandCondition))]
        public XPCollection CodeSysTasksDemandConditions
        {
            get { return GetCollection("CodeSysTasksDemandConditions"); }
        }

        [NonPersistent]
        public bool Check { get; set; }

        public string sClientBaseDateString
        {
            get
            {
                if (fs_ClientDeadM != "Y")
                    return string.Empty;
                if (fs_ClientDeadCalcOrder == "DM")
                    return string.Format("+{0}{1} +{2}{3}", fn_ClientDeadDays, Resource.Day, fn_ClientDeadMonths,
                        Resource.Month);
                if (fs_ClientDeadCalcOrder == "MD")
                    return string.Format("+{0}{1} +{2}{3}", fn_ClientDeadMonths, Resource.Month, fn_ClientDeadDays,
                        Resource.Day);
                return string.Empty;
            }
        }

        public string sOfficialBaseDateString
        {
            get
            {
                if (fs_OfficialDeadM != "Y")
                    return string.Empty;
                if (fs_OfficialDeadCalcOrder == "DM")
                    return string.Format("+{0}{1} +{2}{3}", fn_OfficialDeadDays, Resource.Day, fn_OfficialDeadMonths,
                        Resource.Month);
                if (fs_OfficialDeadCalcOrder == "MD")
                    return string.Format("+{0}{1} +{2}{3}", fn_OfficialDeadMonths, Resource.Month, fn_OfficialDeadDays,
                        Resource.Day);
                return string.Empty;
            }
        }

        public string sInterBaseDateString
        {
            get
            {
                if (fs_InterDeadM != "Y")
                    return string.Empty;
                if (fs_InterDeadCalcOrder == "DM")
                    return string.Format("+{0}{1} +{2}{3}", fn_InterDeadDays, Resource.Day, fn_InterDeadMonths,
                        Resource.Month);
                if (fs_InterDeadCalcOrder == "MD")
                    return string.Format("+{0}{1} +{2}{3}", fn_InterDeadMonths, Resource.Month, fn_InterDeadDays,
                        Resource.Day);
                return string.Empty;
            }
        }

        public string sAlarmDateString
        {
            get
            {
                if (fs_AlarmCalcOrder == "DM")
                    return string.Format("-{0}{1} -{2}{3}", fn_AlarmDays, Resource.Day, fn_AlarmMonths, Resource.Month);
                if (fs_AlarmCalcOrder == "MD")
                    return string.Format("-{0}{1} -{2}{3}", fn_AlarmMonths, Resource.Month, fn_AlarmDays, Resource.Day);
                return string.Empty;
            }
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}
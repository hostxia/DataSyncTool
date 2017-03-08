using System;
using DataEntities.Config;
using DataEntities.Element.Emails;
using DataEntities.Element.Fee;
using DataEntities.Element.Files;
using DataEntities.Element.Monitor;
using DataEntities.Element.Tasks;
using DataEntities.Element.TimeSheet;
using DevExpress.Xpo;

namespace DataEntities.Case
{
    [Persistent("TCase_Process")]
    public class Process : XPLiteObject
    {
        private readonly XPDelayedProperty fdt_EndDate = new XPDelayedProperty();
        private readonly XPDelayedProperty fdt_StartDate = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_Notes = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_Status = new XPDelayedProperty();
        private BasicCase basicCase;
        private CodeProcess codeProcess;
        private decimal fn_EMaxTimeValue;
        private decimal fn_EMinTimeValue;
        private int fn_ID;
        private int fn_OrderNum;
        private int fn_ParentID;
        private string fs_AllowRepeat;
        private string fs_BaseDate;
        private string fs_EMaxTimeUnit;
        private string fs_EMinTimeUnit;
        private string fs_ProcessName;

        public Process(Session session) : base(session)
        {
        }

        public Process() : base(Session.DefaultSession)
        {
        }

        [Key(true)]
        public int n_ID
        {
            get { return fn_ID; }
            set { SetPropertyValue<int>("n_ID", ref fn_ID, value); }
        }

        [Association("Case-Processes")]
        [Persistent("n_CaseID")]
        public BasicCase BasicCase
        {
            get { return basicCase; }
            set { SetPropertyValue("n_CaseID", ref basicCase, value); }
        }

        public int n_OrderNum
        {
            get { return fn_OrderNum; }
            set { SetPropertyValue<int>("n_OrderNum", ref fn_OrderNum, value); }
        }

        public int n_ParentID
        {
            get { return fn_ParentID; }
            set { SetPropertyValue<int>("n_ParentID", ref fn_ParentID, value); }
        }

        [Size(50)]
        public string s_ProcessName
        {
            get { return fs_ProcessName; }
            set { SetPropertyValue("s_ProcessName", ref fs_ProcessName, value); }
        }

        public decimal n_EMinTimeValue
        {
            get { return fn_EMinTimeValue; }
            set { SetPropertyValue<decimal>("n_EMinTimeValue", ref fn_EMinTimeValue, value); }
        }

        [Size(5)]
        public string s_EMinTimeUnit
        {
            get { return fs_EMinTimeUnit; }
            set { SetPropertyValue("s_EMinTimeUnit", ref fs_EMinTimeUnit, value); }
        }

        public decimal n_EMaxTimeValue
        {
            get { return fn_EMaxTimeValue; }
            set { SetPropertyValue<decimal>("n_EMaxTimeValue", ref fn_EMaxTimeValue, value); }
        }

        [Size(5)]
        public string s_EMaxTimeUnit
        {
            get { return fs_EMaxTimeUnit; }
            set { SetPropertyValue("s_EMaxTimeUnit", ref fs_EMaxTimeUnit, value); }
        }

        [Size(1)]
        public string s_AllowRepeat
        {
            get { return fs_AllowRepeat; }
            set { SetPropertyValue("s_AllowRepeat", ref fs_AllowRepeat, value); }
        }

        public string s_BaseDate
        {
            get { return fs_BaseDate; }
            set { SetPropertyValue("s_BaseDate", ref fs_BaseDate, value); }
        }

        [Persistent("n_ProcessCodeID")]
        [Association("CodeProcess-Processes")]
        public CodeProcess TheCodeProcess
        {
            get { return codeProcess; }
            set { SetPropertyValue("n_ProcessCodeID", ref codeProcess, value); }
        }

        public string sName
        {
            get
            {
                if (TheCodeProcess != null)
                    return TheCodeProcess.s_Name;
                return string.Empty;
            }
        }

        [Delayed("fdt_StartDate")]
        public DateTime dt_StartDate
        {
            get
            {
                if (fdt_StartDate.Value == null)
                {
                    return DateTime.MinValue;
                }
                return (DateTime) fdt_StartDate.Value;
            }
            set { fdt_StartDate.Value = value; }
        }

        [Delayed("fdt_EndDate")]
        public DateTime dt_EndDate
        {
            get
            {
                if (fdt_EndDate.Value == null)
                {
                    return DateTime.MinValue;
                }
                return (DateTime) fdt_EndDate.Value;
            }
            set { fdt_EndDate.Value = value; }
        }

        [Delayed("fs_Status")]
        [Size(1)]
        public string s_Status
        {
            get { return (string) fs_Status.Value; }
            set { fs_Status.Value = value; }
        }

        [Delayed("fs_Notes")]
        [Size(800)]
        public string s_Notes
        {
            get { return (string) fs_Notes.Value; }
            set { fs_Notes.Value = value; }
        }

        [NonPersistent]
        public string sProcessName
        {
            get
            {
                if (!string.IsNullOrEmpty(s_ProcessName))
                {
                    return s_ProcessName;
                }
                if (codeProcess == null)
                {
                    return string.Empty;
                }
                return codeProcess.s_Name;
            }
        }

        [Aggregated, Association("Process-CustomFields", typeof (ProcessCustomField))]
        public XPCollection ProcessCustomFields
        {
            get { return GetCollection("ProcessCustomFields"); }
        }

        [Association("Process-FileInCases", typeof (FileInCase))]
        public XPCollection FileInCases
        {
            get { return GetCollection("FileInCases"); }
        }

        [Association("Process-MonitorInCases", typeof (MonitorInCase))]
        public XPCollection MonitorInCases
        {
            get { return GetCollection("MonitorInCases"); }
        }

        [Association("Process-TaskInCases", typeof (TaskInCase))]
        public XPCollection TaskInCases
        {
            get { return GetCollection("TaskInCases"); }
        }

        [Association("Process-FeeInCases", typeof (FeeInCase))]
        public XPCollection FeeInCases
        {
            get { return GetCollection("FeeInCases"); }
        }

        [Association("Process-TimeSheet", typeof (TimeSheetInCase))]
        public XPCollection TimeSheetInCases
        {
            get { return GetCollection("TimeSheetInCases"); }
        }

        [Association("Process-ExpenseInCases", typeof (ExpenseInCase))]
        public XPCollection ExpenseInCases
        {
            get { return GetCollection("ExpenseInCases"); }
        }

        //此字段只是用于PA导入数据
        [NonPersistent]
        public string PA_ProcessID { get; set; }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}
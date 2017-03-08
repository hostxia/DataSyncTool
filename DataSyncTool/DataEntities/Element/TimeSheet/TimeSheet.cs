using System;
using System.Text;
using DataEntities.Case;
using DataEntities.Finance.Bill;
using DevExpress.Data.Filtering;
using DevExpress.Xpo;

namespace DataEntities.Element.TimeSheet
{
    [Persistent("T_Timesheet")]
    public class TimeSheet : XPLiteObject
    {
        private DateTime fdt_CreateDate;
        private DateTime fdt_EditDate;
        private int fn_ChargeCurrency;
        private int fn_ExchangeCurrency;
        private int fn_MainCaseID;
        private decimal fn_Rate;
        private int fn_TimesheetID;
        private int fn_CreatorID;
        private string fs_Creator;
        private string fs_Editor;
        private string fs_Invoiced;
        private string fs_IsActive;
        private string fs_Notes;
        private string fs_Paid;
        private string fs_Status;
        private string fs_CheckStatus;

        private string fs_Task;

        public TimeSheet(Session session)
            : base(session)
        {
        }

        public TimeSheet()
            : base(Session.DefaultSession)
        {
        }

        [Key(true)]
        public int n_TimesheetID
        {
            get { return fn_TimesheetID; }
            set { SetPropertyValue<int>("n_TimesheetID", ref fn_TimesheetID, value); }
        }

        [Size(200)]
        public string s_Task
        {
            get { return fs_Task; }
            set { SetPropertyValue("s_Task", ref fs_Task, value); }
        }

        [Size(1)]
        public string s_Status
        {
            get { return fs_Status; }
            set { SetPropertyValue("s_Status", ref fs_Status, value); }
        }

        [Size(1)]
        public string s_Invoiced
        {
            get { return fs_Invoiced; }
            set { SetPropertyValue("s_Invoiced", ref fs_Invoiced, value); }
        }

        [Size(1)]
        public string s_Paid
        {
            get { return fs_Paid; }
            set { SetPropertyValue("s_Paid", ref fs_Paid, value); }
        }

        public int n_ChargeCurrency
        {
            get { return fn_ChargeCurrency; }
            set { SetPropertyValue<int>("n_ChargeCurrency", ref fn_ChargeCurrency, value); }
        }

        public decimal n_Rate
        {
            get { return fn_Rate; }
            set { SetPropertyValue<decimal>("n_Rate", ref fn_Rate, value); }
        }

        public int n_ExchangeCurrency
        {
            get { return fn_ExchangeCurrency; }
            set { SetPropertyValue<int>("n_ExchangeCurrency", ref fn_ExchangeCurrency, value); }
        }

        [Size(800)]
        public string s_Notes
        {
            get { return fs_Notes; }
            set { SetPropertyValue("s_Notes", ref fs_Notes, value); }
        }

        [Size(1)]
        public string s_IsActive
        {
            get { return fs_IsActive; }
            set { SetPropertyValue("s_IsActive", ref fs_IsActive, value); }
        }

        public int n_CreatorID
        {
            get { return fn_CreatorID; }
            set { SetPropertyValue<int>("n_CreatorID", ref fn_CreatorID, value); }
        }

        [Size(50)]
        public string s_Creator
        {
            get { return fs_Creator; }
            set { SetPropertyValue("s_Creator", ref fs_Creator, value); }
        }

        public int n_MainCaseID
        {
            get { return fn_MainCaseID; }
            set { SetPropertyValue<int>("n_MainCaseID", ref fn_MainCaseID, value); }
        }

        [Size(50)]
        public string s_Editor
        {
            get { return fs_Editor; }
            set { SetPropertyValue("s_Editor", ref fs_Editor, value); }
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

        private Bill bill;
        [Persistent("n_BillID")]
        [Association("Bill-TimeSheet")]
        public Bill TheBill
        {
            get { return bill; }
            set { SetPropertyValue<Bill>("n_BillID", ref bill, value); }
        }
        public BasicCase TheFirstCase
        {
            get
            {
                if (TimeSheetInCases.Count > 0)
                {
                    return ((TimeSheetInCase)TimeSheetInCases[0]).TheCase;
                }
                return null;
            }
        }

        public BasicCase TheMainCase
        {
            get
            {
                foreach (TimeSheetInCase timeSheetInCase in TimeSheetInCases)
                {
                    if (timeSheetInCase == null) continue;
                    if (timeSheetInCase.IsMainCase == "Y") return timeSheetInCase.TheCase;
                }
                return null;
            }
        }

        /// <summary>
        ///     对应的案件的案件名称
        /// </summary>
        public string sCaseName
        {
            get
            {
                //if (TimeSheetInCases.Count >= 1)
                //{
                //    StringBuilder sTmp = new StringBuilder();
                //    TimeSheetInCase taskInCase = (TimeSheetInCase)TimeSheetInCases[0];
                //    if (taskInCase.TheCase == null) return string.Empty;
                //    sTmp.Append(taskInCase.TheCase.s_CaseName);
                //    if (TimeSheetInCases.Count > 1)
                //    {
                //        sTmp.Append("...");
                //    }
                //    return sTmp.ToString();
                //}
                //else
                //{
                //    return "";
                //}

                if (TimeSheetInCases.Count >= 1)
                {
                    TimeSheetInCase timeSheetInCase = null;
                    TimeSheetInCases.Filter = CriteriaOperator.Parse("IsMainCase = 'Y'");
                    if (TimeSheetInCases.Count > 0)
                    {
                        timeSheetInCase = (TimeSheetInCase)TimeSheetInCases[0];
                    }
                    TimeSheetInCases.Filter = CriteriaOperator.Parse("1 = 1");
                    if (timeSheetInCase == null) return "";
                    var sTmp = new StringBuilder();
                    sTmp.Append(timeSheetInCase.TheCase.s_CaseName);
                    if (TimeSheetInCases.Count > 1)
                    {
                        sTmp.Append("...");
                    }
                    return sTmp.ToString();
                }
                return "";
            }
        }

        public Process TheProcess
        {
            get
            {
                //if (TimeSheetInCases.Count > 0)
                //{
                //    return ((TimeSheetInCase)TimeSheetInCases[0]).TheProcess;
                //}
                //else
                //{
                //    return null;
                //}

                if (TimeSheetInCases.Count >= 1)
                {
                    TimeSheetInCase taskInCase = null;
                    TimeSheetInCases.Filter = CriteriaOperator.Parse("IsMainCase = 'Y'");
                    if (TimeSheetInCases.Count > 0)
                    {
                        taskInCase = (TimeSheetInCase)TimeSheetInCases[0];
                    }
                    TimeSheetInCases.Filter = CriteriaOperator.Parse("1 = 1");
                    if (taskInCase == null) return null;
                    if (taskInCase.TheProcess != null)
                    {
                        using (var tempUow = new UnitOfWork())
                        {
                            return taskInCase.TheProcess;
                        }
                    }
                }
                return null;
            }
        }

        /// <summary>
        ///     案件文号
        /// </summary>
        public string sCaseSerials
        {
            get
            {
                //StringBuilder sTmp = new StringBuilder();
                //foreach (TimeSheetInCase taskInCase in TimeSheetInCases)
                //{
                //    if (taskInCase.TheCase == null) continue;
                //    sTmp.Append(taskInCase.TheCase.s_CaseSerial);
                //    sTmp.Append(";");
                //}
                //return sTmp.ToString();

                if (TimeSheetInCases.Count >= 1)
                {
                    TimeSheetInCase taskInCase = null;
                    TimeSheetInCases.Filter = CriteriaOperator.Parse("IsMainCase = 'Y'");
                    if (TimeSheetInCases.Count > 0)
                    {
                        taskInCase = (TimeSheetInCase)TimeSheetInCases[0];
                    }
                    TimeSheetInCases.Filter = CriteriaOperator.Parse("1 = 1");
                    if (taskInCase == null) return "";
                    return taskInCase.TheCase.s_CaseSerial;
                }
                return "";
            }
        }

        public decimal iTimeSheetTotalFee
        {
            get
            {
                decimal iTotalFee = 0;
                foreach (TimeSheetItems timeSheetItem in TimeSheetItems)
                {
                    iTotalFee += timeSheetItem.n_TotalPaid;
                }
                return iTotalFee;
            }
        }

        [Aggregated, Association("TimeSheet-InCase", typeof(TimeSheetInCase))]
        public XPCollection TimeSheetInCases
        {
            get { return GetCollection(("TimeSheetInCases")); }
        }

        [Aggregated, Association("TimeSheet-Items", typeof(TimeSheetItems))]
        public XPCollection TimeSheetItems
        {
            get { return GetCollection("TimeSheetItems"); }
        }

        public int CaseCount
        {
            get { return TimeSheetInCases.Count; }
        }

        [NonPersistent]
        public bool Check { get; set; }

        #region 触发器字段

        private string fs_CaseName;
        private string fs_CaseSerial;

        [Size(50)]
        public string s_CaseSerial
        {
            get { return fs_CaseSerial; }
            set { SetPropertyValue("s_CaseSerial", ref fs_CaseSerial, value); }
        }

        [Size(100)]
        public string s_CaseName
        {
            get { return fs_CaseName; }
            set { SetPropertyValue("s_CaseName", ref fs_CaseName, value); }
        }

        #endregion

        [Size(1)]
        public string s_CheckStatus
        {
            get { return string.IsNullOrEmpty(fs_CheckStatus) ? "U" : fs_CheckStatus; }
            set { SetPropertyValue("s_CheckStatus", ref fs_CheckStatus, value); }
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}
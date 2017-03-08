using System;
using System.Text;
using DataEntities.Case;
using DataEntities.Case.Patents;
using DataEntities.Case.Trademarks;
using DataEntities.Config;
using DataEntities.Config.Check.Info;
using DataEntities.Element.Files;
using DataEntities.Finance.Bill;
using DataEntities.Properties;
using DevExpress.Data.Filtering;
using DevExpress.Xpo;

namespace DataEntities.Element.Tasks
{
    [Persistent("T_Task")]
    public class Task : XPLiteObject
    {
        private readonly XPDelayedProperty fdt_AlarmDate = new XPDelayedProperty();
        private readonly XPDelayedProperty fdt_ClientDeadline = new XPDelayedProperty();
        private readonly XPDelayedProperty fdt_CreateDate = new XPDelayedProperty();
        private readonly XPDelayedProperty fdt_Deadline = new XPDelayedProperty();
        private readonly XPDelayedProperty fdt_EditDate = new XPDelayedProperty();
        private readonly XPDelayedProperty fdt_InterDeadline = new XPDelayedProperty();
        private readonly XPDelayedProperty fdt_OfficialDeadline = new XPDelayedProperty();
        private readonly XPDelayedProperty fdt_StatusDate = new XPDelayedProperty();
        private readonly XPDelayedProperty fn_EmployeeID = new XPDelayedProperty();
        private readonly XPDelayedProperty fn_SysTaskCodeID = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_IsActive = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_Level = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_Status = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_TaskDetail = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_TaskName = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_TaskResult = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_TaskToEmail = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_TaskType = new XPDelayedProperty();
        private Bill Bill;
        private Fee.Fee Fee;
        private int fn_AuthorID;
        private int fn_CurCheckerID;
        private int fn_LatestCheckInfoID;
        private int fn_MainCaseID;
        private int fn_ModuleCheckStatusID;
        private int fn_TaskID;
        private string fs_Category;
        private string fs_Country;
        private string fs_Creator;
        private string fs_Editor;
        private string fs_InRecycle;
        private InFile inFile;
        private OutFile outFile;

        public Task(Session session) : base(session)
        {
        }

        public Task() : base(Session.DefaultSession)
        {
        }

        [Key(true)]
        public int n_TaskID
        {
            get { return fn_TaskID; }
            set { SetPropertyValue<int>("n_TaskID", ref fn_TaskID, value); }
        }

        [Size(50)]
        [Delayed("fs_TaskType")]
        public string s_TaskType
        {
            get { return (string) fs_TaskType.Value; }
            set { fs_TaskType.Value = value; }
        }

        [Delayed("fn_SysTaskCodeID")]
        public int n_SysTaskCodeID
        {
            get
            {
                if (fn_SysTaskCodeID.Value == null)
                {
                    return -1;
                }
                return (int) fn_SysTaskCodeID.Value;
            }
            set { fn_SysTaskCodeID.Value = value; }
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

        [Size(300)]
        [Delayed("fs_TaskToEmail")]
        public string s_TaskToEmail
        {
            get { return (string) fs_TaskToEmail.Value; }
            set { fs_TaskToEmail.Value = value; }
        }

        [Delayed("fs_Level")]
        public string s_Level
        {
            get { return (string) fs_Level.Value; }
            set { fs_Level.Value = value; }
        }

        public string Level
        {
            get
            {
                if (fs_Level.Value != null)
                {
                    if (fs_Level.Value.ToString() == "H")
                        return Resource.High;
                    if (fs_Level.Value.ToString() == "M")
                        return Resource.Middle;
                    if (fs_Level.Value.ToString() == "L")
                        return Resource.Low;
                    return "";
                }
                return "";
            }
        }

        public string s_Country
        {
            get { return fs_Country; }
            set { SetPropertyValue("s_Country", ref fs_Country, value); }
        }

        [Size(300)]
        [Delayed("fs_TaskName")]
        public string s_TaskName
        {
            get { return (string) fs_TaskName.Value; }
            set { fs_TaskName.Value = value; }
        }

        [Size(800)]
        [Delayed("fs_TaskDetail")]
        public string s_TaskDetail
        {
            get { return (string) fs_TaskDetail.Value; }
            set { fs_TaskDetail.Value = value; }
        }

        [Size(500)]
        [Delayed("fs_TaskResult")]
        public string s_TaskResult
        {
            get { return (string) fs_TaskResult.Value; }
            set { fs_TaskResult.Value = value; }
        }

        public DateTime dt_AlarmDate
        {
            get
            {
                if (fdt_AlarmDate.Value == null)
                {
                    return DateTime.MinValue;
                }
                return (DateTime) fdt_AlarmDate.Value;
            }
            set { fdt_AlarmDate.Value = value; }
        }

        public DateTime dt_InterDeadline
        {
            get
            {
                if (fdt_InterDeadline.Value == null)
                {
                    return DateTime.MinValue;
                }
                return (DateTime) fdt_InterDeadline.Value;
            }
            set { fdt_InterDeadline.Value = value; }
        }

        public DateTime dt_ClientDeadline
        {
            get
            {
                if (fdt_ClientDeadline.Value == null)
                {
                    return DateTime.MinValue;
                }
                return (DateTime) fdt_ClientDeadline.Value;
            }
            set { fdt_ClientDeadline.Value = value; }
        }

        public DateTime dt_OfficialDeadline
        {
            get
            {
                if (fdt_OfficialDeadline.Value == null)
                {
                    return DateTime.MinValue;
                }
                return (DateTime) fdt_OfficialDeadline.Value;
            }
            set { fdt_OfficialDeadline.Value = value; }
        }

        public DateTime dt_Deadline
        {
            get
            {
                if (fdt_Deadline.Value == null)
                {
                    return DateTime.MinValue;
                }
                return (DateTime) fdt_Deadline.Value;
            }
            set { fdt_Deadline.Value = value; }
        }

        [Size(1)]
        public string s_Status
        {
            get { return (string) fs_Status.Value; }
            set { fs_Status.Value = value; }
        }

        public string Status
        {
            get
            {
                if (fs_Status.Value != null)
                {
                    if (fs_Status.Value.ToString() == "U")
                        return Resource.Undeal;
                    if (fs_Status.Value.ToString() == "W")
                        return Resource.Dealing;
                    if (fs_Status.Value.ToString() == "A")
                        return Resource.TaskInvalid;
                    if (fs_Status.Value.ToString() == "F")
                        return Resource.TaskFinish;
                    return "";
                }
                return "";
            }
        }

        public DateTime dt_StatusDate
        {
            get
            {
                if (fdt_StatusDate.Value == null)
                {
                    return DateTime.MinValue;
                }
                return (DateTime) fdt_StatusDate.Value;
            }
            set { fdt_StatusDate.Value = value; }
        }

        [Delayed]
        public string FirstAttorney
        {
            get
            {
                if (TaskInCases.Count >= 1)
                {
                    TaskInCase taskInCase = null;
                    TaskInCases.Filter = CriteriaOperator.Parse("IsMainCase = 'Y'");
                    if (TaskInCases.Count > 0)
                    {
                        taskInCase = (TaskInCase) TaskInCases[0];
                    }
                    TaskInCases.Filter = CriteriaOperator.Parse("1 = 1");
                    if (taskInCase == null) return "";
                    using (var tempUow = new UnitOfWork())
                    {
                        var codeEmployee =
                            tempUow.GetObjectByKey<CodeEmployee>(taskInCase.TheCase.n_FirstAttorney);
                        return codeEmployee == null ? "" : codeEmployee.s_Name;
                    }
                }
                return "";
            }
        }

        [Persistent("n_FileID")]
        [Association("File-Tasks")]
        public InFile TheInFile
        {
            get { return inFile; }
            set { SetPropertyValue("n_FileID", ref inFile, value); }
        }

        [Persistent("n_OutFileID")]
        [Association("Outfile-Tasks")]
        public OutFile TheOutFile
        {
            get { return outFile; }
            set { SetPropertyValue("n_OutFileID", ref outFile, value); }
        }

        [Persistent("n_FeeID")]
        [Association("Fee-Tasks")]
        public Fee.Fee TheFee
        {
            get { return Fee; }
            set { SetPropertyValue("n_FeeID", ref Fee, value); }
        }

        [Persistent("n_BillID")]
        [Association("Bill-Tasks")]
        public Bill TheBill
        {
            get { return Bill; }
            set { SetPropertyValue("n_BillID", ref Bill, value); }
        }

        [Size(1)]
        public string s_IsActive
        {
            get { return (string) fs_IsActive.Value; }
            set { fs_IsActive.Value = value; }
        }

        public string IsActive
        {
            get
            {
                if (fs_IsActive.Value != null)
                {
                    if (fs_IsActive.Value.ToString() == "Y")
                        return Resource.UnClose;
                    if (fs_IsActive.Value.ToString() == "N")
                        return Resource.Close;
                    return "";
                }
                return "";
            }
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

        [Size(1)]
        public string s_InRecycle
        {
            get { return fs_InRecycle; }
            set { SetPropertyValue("s_InRecycle", ref fs_InRecycle, value); }
        }

        public DateTime dt_CreateDate
        {
            get
            {
                if (fdt_CreateDate.Value == null)
                {
                    return DateTime.MinValue;
                }
                return (DateTime) fdt_CreateDate.Value;
            }
            set { fdt_CreateDate.Value = value; }
        }

        public DateTime dt_EditDate
        {
            get
            {
                if (fdt_EditDate.Value == null)
                {
                    return DateTime.MinValue;
                }
                return (DateTime) fdt_EditDate.Value;
            }
            set { fdt_EditDate.Value = value; }
        }

        public int n_ModuleCheckStatusID
        {
            get { return fn_ModuleCheckStatusID; }
            set { SetPropertyValue<int>("n_ModuleCheckStatusID", ref fn_ModuleCheckStatusID, value); }
        }

        public int n_LatestCheckInfoID
        {
            get { return fn_LatestCheckInfoID; }
            set { SetPropertyValue<int>("n_LatestCheckInfoID", ref fn_LatestCheckInfoID, value); }
        }

        public int n_AuthorID
        {
            get { return fn_AuthorID; }
            set { SetPropertyValue<int>("n_AuthorID", ref fn_AuthorID, value); }
        }

        public int n_CurCheckerID
        {
            get { return fn_CurCheckerID; }
            set { SetPropertyValue<int>("n_CurCheckerID", ref fn_CurCheckerID, value); }
        }

        public int n_MainCaseID
        {
            get { return fn_MainCaseID; }
            set { SetPropertyValue<int>("n_MainCaseID", ref fn_MainCaseID, value); }
        }

        [Size(30)]
        public string s_Category
        {
            get { return fs_Category; }
            set { SetPropertyValue("s_Category", ref fs_Category, value); }
        }

        //public string GetCategoy
        //{
        //    get
        //    {

        //    }
        //}


        [Aggregated, Association("Task-TaskChecks")]
        public XPCollection<TaskChecks> TaskChecks
        {
            get { return GetCollection<TaskChecks>("TaskChecks"); }
        }

        public BasicCase TheFirstCase
        {
            get
            {
                if (TaskInCases.Count > 0)
                {
                    return ((TaskInCase) TaskInCases[0]).TheCase;
                }
                return null;
            }
        }

        public Process TheProcess
        {
            get
            {
                //if (TaskInCases.Count > 0)
                //{
                //    return ((TaskInCase)TaskInCases[0]).TheProcess;
                //}
                //else
                //{
                //    return null;
                //}

                if (TaskInCases.Count >= 1)
                {
                    TaskInCase taskInCase = null;
                    TaskInCases.Filter = CriteriaOperator.Parse("IsMainCase = 'Y'");
                    if (TaskInCases.Count > 0)
                    {
                        taskInCase = (TaskInCase) TaskInCases[0];
                    }
                    TaskInCases.Filter = CriteriaOperator.Parse("1 = 1");
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
        ///     文件的对应的案件的案件名称
        /// </summary>
        public string sCaseName
        {
            get
            {
                //if (TaskInCases.Count >= 1)
                //{
                //    StringBuilder sTmp = new StringBuilder();
                //    TaskInCase taskInCase = (TaskInCase)TaskInCases[0];
                //    if (taskInCase.TheCase == null) return string.Empty;
                //    sTmp.Append(taskInCase.TheCase.s_CaseName);
                //    if (TaskInCases.Count > 1)
                //    {
                //        sTmp.Append("...");
                //    }
                //    return sTmp.ToString();
                //}
                //else
                //{
                //    return "";
                //}


                if (TaskInCases.Count >= 1)
                {
                    TaskInCase taskInCase = null;
                    TaskInCases.Filter = CriteriaOperator.Parse("IsMainCase = 'Y'");
                    if (TaskInCases.Count > 0)
                    {
                        taskInCase = (TaskInCase) TaskInCases[0];
                    }
                    TaskInCases.Filter = CriteriaOperator.Parse("1 = 1");
                    if (taskInCase == null) return "";
                    var sTmp = new StringBuilder();
                    sTmp.Append(taskInCase.TheCase.s_CaseName);
                    if (TaskInCases.Count > 1)
                    {
                        sTmp.Append("...");
                    }
                    return sTmp.ToString();
                }
                return "";
            }
        }

        public int GetMainCaseID
        {
            get
            {
                if (TaskInCases.Count >= 1)
                {
                    TaskInCase taskInCase = null;
                    TaskInCases.Filter = CriteriaOperator.Parse("IsMainCase = 'Y'");
                    if (TaskInCases.Count > 0)
                    {
                        taskInCase = (TaskInCase) TaskInCases[0];
                    }
                    TaskInCases.Filter = CriteriaOperator.Parse("1 = 1");
                    if (taskInCase == null) return 0;
                    return taskInCase.TheCase.n_CaseID;
                }
                return 0;
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
                //foreach (TaskInCase taskInCase in TaskInCases)
                //{
                //    if (taskInCase.TheCase == null) continue;
                //    sTmp.Append(taskInCase.TheCase.s_CaseSerial);
                //    sTmp.Append(";");
                //}
                //return sTmp.ToString();

                if (TaskInCases.Count >= 1)
                {
                    TaskInCase taskInCase = null;
                    TaskInCases.Filter = CriteriaOperator.Parse("IsMainCase = 'Y'");
                    if (TaskInCases.Count > 0)
                    {
                        taskInCase = (TaskInCase) TaskInCases[0];
                    }
                    TaskInCases.Filter = CriteriaOperator.Parse("1 = 1");
                    if (taskInCase == null) return "";
                    return taskInCase.TheCase.s_CaseSerial;
                }
                return "";
            }
        }

        [Aggregated, Association("Task-TaskInCases", typeof (TaskInCase))]
        public XPCollection TaskInCases
        {
            get { return GetCollection("TaskInCases"); }
        }

        //[Aggregated, Association("Task-TaskRelatedItemss", typeof(TaskRelatedItems))]
        //public XPCollection TaskRelatedItemss
        //{
        //    get { return GetCollection("TaskRelatedItemss"); }
        //}

        [Association("Task-OutFile", typeof (OutFile))]
        public XPCollection OutFiles
        {
            get { return GetCollection("OutFiles"); }
        }

        [Association("Task-Fee", typeof (Fee.Fee))]
        public XPCollection Fees
        {
            get { return GetCollection("Fees"); }
        }

        [Aggregated, Association("Task-TaskRelations", typeof (TaskRelation))]
        public XPCollection TaskRelations
        {
            get { return GetCollection("TaskRelations"); }
        }

        [Aggregated, Association("Task-SubTaskRelations", typeof (TaskRelation))]
        public XPCollection SubTaskRelations
        {
            get { return GetCollection("SubTaskRelations"); }
        }

        [Association("Task-ChargingFee", typeof (Fee.Fee))]
        public XPCollection ChargingFees
        {
            get { return GetCollection("ChargingFees"); }
        }

        [NonPersistent]
        public bool Check { get; set; }

        [NonPersistent]
        public bool IsUpdateTask { get; set; }

        public int CaseCount
        {
            get { return TaskInCases.Count; }
        }

        [NonPersistent]
        public string CC { get; set; }

        #region 触发器字段

        private string fs_AppNo;
        private string fs_Applicants;
        private string fs_Attorney;
        private string fs_CaseSerial;
        private string fs_Introducer;

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
        public string s_Attorney
        {
            get { return fs_Attorney; }
            set { SetPropertyValue("s_Attorney", ref fs_Attorney, value); }
        }

        #endregion

        #region 高级查询所用的特殊字段

        /// <summary>
        ///     来文的主案件，高级查询使用
        /// </summary>
        public BasicCase TheMainCase
        {
            get
            {
                foreach (TaskInCase taskInCase in TaskInCases)
                {
                    if (taskInCase == null) continue;
                    if (taskInCase.IsMainCase == "Y") return taskInCase.TheCase;
                }
                return null;
            }
        }

        /// <summary>
        ///     申请号，高级查询使用
        /// </summary>
        public string CaseAppNo
        {
            get
            {
                if ((TheMainCase as ExtendedPatent) != null) return (TheMainCase as ExtendedPatent).TheLawInfo.s_AppNo;
                if ((TheMainCase as ExtendedTrademark) != null)
                    return (TheMainCase as ExtendedTrademark).TheLawInfo.s_AppNo;
                return string.Empty;
            }
        }

        #endregion

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}
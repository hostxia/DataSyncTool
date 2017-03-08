using System;
using System.Collections.Generic;
using System.Linq;
using DataEntities.Case;
using DataEntities.Remind;
using DataEntities.TaskFlowBase;
using DataEntities.TaskFlowConfig;
using DevExpress.Data.Filtering;
using DevExpress.Xpo;

namespace DataEntities.TaskFlowData
{
    [Persistent("TF_Task")]
    public class TFTask : XPLiteObjectUser
    {
        Guid fg_ID;
        [Key(true)]
        public Guid g_ID
        {
            get { return fg_ID; }
            set { SetPropertyValue<Guid>("g_ID", ref fg_ID, value); }
        }

        int fn_Num;
        public int n_Num
        {
            get
            {
                if (fn_Num > 0) return fn_Num;
                var sNum = TheUow.ExecuteQuery(string.Format(@"SELECT n_Num FROM dbo.TF_Task WHERE g_ID = '{0}'", g_ID)).ResultSet[0].Rows.Select(r => r.Values[0]).FirstOrDefault();
                fn_Num = sNum == null ? 0 : Convert.ToInt32(sNum);
                return fn_Num;
            }
        }

        string fs_Name;
        [Size(100)]
        public string s_Name
        {
            get { return fs_Name; }
            set { SetPropertyValue<string>("s_Name", ref fs_Name, value); }
        }

        string fs_Description;
        [Size(1000)]
        public string s_Description
        {
            get { return fs_Description; }
            set { SetPropertyValue<string>("s_Description", ref fs_Description, value); }
        }

        string fs_Notes;
        [Size(1000)]
        public string s_Notes
        {
            get { return fs_Notes; }
            set { SetPropertyValue<string>("s_Notes", ref fs_Notes, value); }
        }

        int fn_TaskTypeID;
        public int n_TaskTypeID
        {
            get { return fn_TaskTypeID; }
            set { SetPropertyValue<int>("n_TaskTypeID", ref fn_TaskTypeID, value); }
        }

        string fs_State;
        [Size(1)]
        public string s_State
        {
            get { return fs_State; }
            set { SetPropertyValue<string>("s_State", ref fs_State, value); }
        }

        string fs_ReadState;
        [Size(1)]
        public string s_ReadState
        {
            get { return fs_ReadState; }
            set { SetPropertyValue<string>("s_ReadState", ref fs_ReadState, value); }
        }

        int? fn_Level;
        public int? n_Level
        {
            get { return fn_Level; }
            set { SetPropertyValue<int?>("n_Level", ref fn_Level, value); }
        }

        int fn_UrgencyID;
        [NullValue(default(int))]
        public int n_UrgencyID
        {
            get { return fn_UrgencyID; }
            set { SetPropertyValue<int>("n_UrgencyID", ref fn_UrgencyID, value); }
        }

        int fn_ExecutorID;
        [NullValue(default(int))]
        public int n_ExecutorID
        {
            get { return fn_ExecutorID; }
            set { SetPropertyValue<int>("n_ExecutorID", ref fn_ExecutorID, value); }
        }

        int fn_ExecutePositionID;
        [NullValue(default(int))]
        public int n_ExecutePositionID
        {
            get { return fn_ExecutePositionID; }
            set { SetPropertyValue<int>("n_ExecutePositionID", ref fn_ExecutePositionID, value); }
        }

        int? fn_MentorID;
        public int? n_MentorID
        {
            get { return fn_MentorID; }
            set { SetPropertyValue<int?>("n_MentorID", ref fn_MentorID, value); }
        }

        DateTime fdt_StartDate;
        [NullValue(typeof(DateTime), "0001/1/1 0:00:00")]
        public DateTime dt_StartDate
        {
            get { return fdt_StartDate; }
            set { SetPropertyValue<DateTime>("dt_StartDate", ref fdt_StartDate, value); }
        }

        DateTime fdt_EndDate;
        [NullValue(typeof(DateTime), "0001/1/1 0:00:00")]
        public DateTime dt_EndDate
        {
            get { return fdt_EndDate; }
            set { SetPropertyValue<DateTime>("dt_EndDate", ref fdt_EndDate, value); }
        }

        int fn_Finisher;
        [NullValue(default(int))]
        public int n_Finisher
        {
            get { return fn_Finisher; }
            set { SetPropertyValue<int>("n_Finisher", ref fn_Finisher, value); }
        }

        DateTime fdt_FinishTime;
        [NullValue(typeof(DateTime), "0001/1/1 0:00:00")]
        public DateTime dt_FinishTime
        {
            get { return fdt_FinishTime; }
            set { SetPropertyValue<DateTime>("dt_FinishTime", ref fdt_FinishTime, value); }
        }

        int? fn_Creator;
        public int? n_Creator
        {
            get { return fn_Creator; }
            set { SetPropertyValue<int?>("n_Creator", ref fn_Creator, value); }
        }

        DateTime fdt_CreateTime;
        [NullValue(typeof(DateTime), "0001/1/1 0:00:00")]
        public DateTime dt_CreateTime
        {
            get { return fdt_CreateTime; }
            set { SetPropertyValue<DateTime>("dt_CreateTime", ref fdt_CreateTime, value); }
        }

        int? fn_Editor;
        public int? n_Editor
        {
            get { return fn_Editor; }
            set { SetPropertyValue<int?>("n_Editor", ref fn_Editor, value); }
        }

        DateTime fdt_EditTime;
        [NullValue(typeof(DateTime), "0001/1/1 0:00:00")]
        public DateTime dt_EditTime
        {
            get { return fdt_EditTime; }
            set { SetPropertyValue<DateTime>("dt_EditTime", ref fdt_EditTime, value); }
        }

        Guid fg_TaskCycleConfigGuid;
        [NullValue(typeof(Guid), "00000000-0000-0000-0000-000000000000")]
        public Guid g_TaskCycleConfigGuid
        {
            get { return fg_TaskCycleConfigGuid; }
            set { SetPropertyValue<Guid>("g_TaskCycleConfigGuid", ref fg_TaskCycleConfigGuid, value); }
        }

        int fn_Operator;
        [NullValue(default(int))]
        public int n_Operator
        {
            get { return fn_Operator; }
            set { SetPropertyValue<int>("n_Operator", ref fn_Operator, value); }
        }

        string fs_ManualUpdateDeadline;
        [Size(1)]
        public string s_ManualUpdateDeadline
        {
            get { return fs_ManualUpdateDeadline; }
            set { SetPropertyValue<string>("s_ManualUpdateDeadline", ref fs_ManualUpdateDeadline, value); }
        }

        #region Method

        public TFNode GetTheBelongNode()
        {
            return TheUow.FindObject<TFNode>(CriteriaOperator.Parse("g_OwnTaskGuid = ?", g_ID));
        }

        public TFTaskChain GetTheTaskChain()
        {
            return GetTheBelongNode().GetTheTaskChain();
        }

        public BasicCase GetRelatedCase()
        {
            return GetTheTaskChain().GetRelatedCase();
        }

        public int GetRelatedCaseID()
        {
            return GetTheTaskChain().GetRelateCaseID();
        }

        public TFCodeTaskUrgency GetTheTaskUrgency()
        {
            return TheUow.GetObjectByKey<TFCodeTaskUrgency>(n_UrgencyID);
        }

        public TFTaskCycleConfig GetTheTaskCycleConfig()
        {
            return TheUow.FindObject<TFTaskCycleConfig>(CriteriaOperator.Parse("g_ID = ?", g_TaskCycleConfigGuid));
        }

        public List<TFActionInTask> GetListCodeActionInTasks()
        {
            var xpcActionInTasks = new XPCollection<TFActionInTask>(TheUow, CriteriaOperator.Parse("g_TaskID = ?", g_ID));
            return xpcActionInTasks.ToList();
        }

        public List<TFDemandTypeInTask> GetListDemandTypeInTasks()
        {
            var xpcDemandTypeInTasks = new XPCollection<TFDemandTypeInTask>(TheUow, CriteriaOperator.Parse("g_TaskID = ?", g_ID));
            return xpcDemandTypeInTasks.ToList();
        }

        public List<TFTaskParameter> GetListTaskParameters(string paramType = null)
        {
            var xpcTaskParameters = string.IsNullOrWhiteSpace(paramType)
                ? new XPCollection<TFTaskParameter>(TheUow, CriteriaOperator.Parse("g_TaskID = ?", g_ID))
                : new XPCollection<TFTaskParameter>(TheUow, CriteriaOperator.Parse("g_TaskID = ? and s_ParaType= ?", g_ID, paramType));
            return xpcTaskParameters.ToList();
        }

        public List<TFTaskParameter> GetListTaskChainParameters(string paramType)
        {
            var chain = GetTheTaskChain();
            if (chain == null) return new List<TFTaskParameter>();
            return new XPCollection<TFTaskParameter>(TheUow, CriteriaOperator.Parse("g_TaskChainID = ? and s_ParaType= ?", chain.g_ID, paramType)).ToList();
        }

        public List<TFTaskCheck> GetListItselfTaskChecks()
        {
            var xpcTaskChecks = new XPCollection<TFTaskCheck>(TheUow, CriteriaOperator.Parse("g_CheckTaskID = ?", g_ID));
            return xpcTaskChecks.ToList();
        }

        public List<TFTaskCheck> GetListOthersTaskChecks()
        {
            var xpcTaskChecks = new XPCollection<TFTaskCheck>(TheUow, CriteriaOperator.Parse("g_TaskID = ?", g_ID));
            return xpcTaskChecks.ToList();
        }

        public List<TRRemind> GetListTaskReminds()
        {
            var xpcReminds = new XPCollection<TRRemind>(TheUow, CriteriaOperator.Parse("s_TriggerType = ? And s_TriggerID = ?", "Task", g_ID.ToString())).ToList();
            return xpcReminds.ToList();
        }

        public List<TFWorkItemInTaskChain> GetListWorkItemInTaskChains()
        {
            return new XPCollection<TFWorkItemInTaskChain>(TheUow, CriteriaOperator.Parse("g_TaskGuid = ?", g_ID)).ToList();
        }

        #endregion

        public TFTask(Session session) : base(session) { }
    }
}
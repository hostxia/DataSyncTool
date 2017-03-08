using System;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using DataEntities.Remind;
using DataEntities.TaskFlowBase;
using DataEntities.TaskFlowConfig;
using DevExpress.Data.Filtering;
using DevExpress.Xpo;

namespace DataEntities.TaskFlowConfig
{
    [Persistent("TFCode_Task")]
    public class TFCodeTask : XPLiteObjectUser
    {
        Guid fg_ID;
        [Key(false)]
        public Guid g_ID
        {
            get { return fg_ID; }
            set { SetPropertyValue<Guid>("g_ID", ref fg_ID, value); }
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

        int? fn_TaskTypeID;
        public int? n_TaskTypeID
        {
            get { return fn_TaskTypeID; }
            set { SetPropertyValue<int?>("n_TaskTypeID", ref fn_TaskTypeID, value); }
        }

        int? fn_DemandTypeID;
        public int? n_DemandTypeID
        {
            get { return fn_DemandTypeID; }
            set { SetPropertyValue<int?>("n_DemandTypeID", ref fn_DemandTypeID, value); }
        }

        int? fn_Level;
        public int? n_Level
        {
            get { return fn_Level; }
            set { SetPropertyValue<int?>("n_Level", ref fn_Level, value); }
        }

        string fs_ExecutorType;
        [Size(1)]
        public string s_ExecutorType
        {
            get { return fs_ExecutorType; }
            set { SetPropertyValue<string>("s_ExecutorType", ref fs_ExecutorType, value); }
        }

        string fs_ExecutorValue;
        [Size(500)]
        public string s_ExecutorValue
        {
            get { return fs_ExecutorValue; }
            set { SetPropertyValue<string>("s_ExecutorValue", ref fs_ExecutorValue, value); }
        }

        string fs_FinishCondition;
        [Size(2000)]
        public string s_FinishCondition
        {
            get { return fs_FinishCondition; }
            set { SetPropertyValue<string>("s_FinishCondition", ref fs_FinishCondition, value); }
        }

        #region 任务期限相关字段

        string fs_StartDateCalcRule;
        [Size(50)]
        public string s_StartDateCalcRule
        {
            get { return fs_StartDateCalcRule; }
            set { SetPropertyValue<string>("s_StartDateCalcRule", ref fs_StartDateCalcRule, value); }
        }

        string fs_StartDateTaskCode;
        [Size(21)]
        public string s_StartDateTaskCode
        {
            get { return fs_StartDateTaskCode; }
            set { SetPropertyValue<string>("s_StartDateTaskCode", ref fs_StartDateTaskCode, value); }
        }

        string fs_StartDateTaskDateType;
        [Size(50)]
        public string s_StartDateTaskDateType
        {
            get { return fs_StartDateTaskDateType; }
            set { SetPropertyValue<string>("s_StartDateTaskDateType", ref fs_StartDateTaskDateType, value); }
        }

        Guid fg_StartCodeDeadlineGuid;
        public Guid g_StartCodeDeadlineGuid
        {
            get { return fg_StartCodeDeadlineGuid; }
            set { SetPropertyValue<Guid>("g_StartCodeDeadlineGuid", ref fg_StartCodeDeadlineGuid, value); }
        }

        int fn_StartDateValue1;
        public int n_StartDateValue1
        {
            get { return fn_StartDateValue1; }
            set { SetPropertyValue<int>("n_StartDateValue1", ref fn_StartDateValue1, value); }
        }

        string fs_StartDateType1;
        [Size(50)]
        public string s_StartDateType1
        {
            get { return fs_StartDateType1; }
            set { SetPropertyValue<string>("s_StartDateType1", ref fs_StartDateType1, value); }
        }

        int fn_StartDateValue2;
        public int n_StartDateValue2
        {
            get { return fn_StartDateValue2; }
            set { SetPropertyValue<int>("n_StartDateValue2", ref fn_StartDateValue2, value); }
        }

        string fs_StartDateType2;
        [Size(50)]
        public string s_StartDateType2
        {
            get { return fs_StartDateType2; }
            set { SetPropertyValue<string>("s_StartDateType2", ref fs_StartDateType2, value); }
        }

        string fs_EndDateCalcRule;
        [Size(50)]
        public string s_EndDateCalcRule
        {
            get { return fs_EndDateCalcRule; }
            set { SetPropertyValue<string>("s_EndDateCalcRule", ref fs_EndDateCalcRule, value); }
        }

        string fs_EndDateTaskCode;
        [Size(21)]
        public string s_EndDateTaskCode
        {
            get { return fs_EndDateTaskCode; }
            set { SetPropertyValue<string>("s_EndDateTaskCode", ref fs_EndDateTaskCode, value); }
        }

        string fs_EndDateTaskDateType;
        [Size(50)]
        public string s_EndDateTaskDateType
        {
            get { return fs_EndDateTaskDateType; }
            set { SetPropertyValue<string>("s_EndDateTaskDateType", ref fs_EndDateTaskDateType, value); }
        }

        Guid fg_EndCodeDeadlineGuid;
        public Guid g_EndCodeDeadlineGuid
        {
            get { return fg_EndCodeDeadlineGuid; }
            set { SetPropertyValue<Guid>("g_EndCodeDeadlineGuid", ref fg_EndCodeDeadlineGuid, value); }
        }

        int fn_EndDateValue1;
        public int n_EndDateValue1
        {
            get { return fn_EndDateValue1; }
            set { SetPropertyValue<int>("n_EndDateValue1", ref fn_EndDateValue1, value); }
        }

        string fs_EndDateType1;
        [Size(50)]
        public string s_EndDateType1
        {
            get { return fs_EndDateType1; }
            set { SetPropertyValue<string>("s_EndDateType1", ref fs_EndDateType1, value); }
        }

        int fn_EndDateValue2;
        public int n_EndDateValue2
        {
            get { return fn_EndDateValue2; }
            set { SetPropertyValue<int>("n_EndDateValue2", ref fn_EndDateValue2, value); }
        }

        string fs_EndDateType2;
        [Size(50)]
        public string s_EndDateType2
        {
            get { return fs_EndDateType2; }
            set { SetPropertyValue<string>("s_EndDateType2", ref fs_EndDateType2, value); }
        }

        Guid fg_EndFinallyCodeDeadlineGuid;
        public Guid g_EndFinallyCodeDeadlineGuid
        {
            get { return fg_EndFinallyCodeDeadlineGuid; }
            set { SetPropertyValue<Guid>("g_EndFinallyCodeDeadlineGuid", ref fg_EndFinallyCodeDeadlineGuid, value); }
        }

        #endregion

        #region Method

        public TFCodeNode GetTheBelongCodeNode()
        {
            return TheUow.FindObject<TFCodeNode>(CriteriaOperator.Parse("g_OwnCodeTaskGuid = ?", g_ID));
        }

        public TFCodeTaskChain GetTheCodeTaskChain()
        {
            return GetTheBelongCodeNode().GetTheCodeTaskChain();
        }

        public List<TFCodeActionInCodeTask> GetListCodeActionInCodeTasks()
        {
            var xpcCodeActionInCodeTasks = new XPCollection<TFCodeActionInCodeTask>(TheUow, CriteriaOperator.Parse("g_CodeTaskGuid = ?", g_ID));
            return xpcCodeActionInCodeTasks.ToList();
        }

        public List<TFCodeAction> GetListCodeActions()
        {
            List<TFCodeAction> list = GetListCodeActionInCodeTasks().Select(s => s.GetTheCodeAction()).ToList();
            return list.Where(a => a != null).ToList();
        }

        public List<TFCodeDemandTypeInCodeTask> GetListCodeDemandTypeInCodeTasks()
        {
            var xpcCodeDemandTypeInCodeTasks = new XPCollection<TFCodeDemandTypeInCodeTask>(TheUow, CriteriaOperator.Parse("g_CodeTaskGuid = ?", g_ID));
            return xpcCodeDemandTypeInCodeTasks.ToList();
        }

        public List<TFCodeDemandType> GetListCodeDemandTypes()
        {
            List<TFCodeDemandType> list = GetListCodeDemandTypeInCodeTasks().Select(s => s.GetTheCodeDemandType()).ToList();
            return list.Where(d => d != null).ToList();
        }

        public List<TFCodeDeadlineInCodeTask> GetListCodeDeadlineInCodeTasks()
        {
            var xpcCodeDeadlineInCodeTasks = new XPCollection<TFCodeDeadlineInCodeTask>(TheUow, CriteriaOperator.Parse("g_CodeTaskGuid = ?", g_ID));
            return xpcCodeDeadlineInCodeTasks.ToList();
        }

        public List<TFCodeWorkItemInCodeTask> GetListCodeWorkItemInCodeTasks()
        {
            var xpcCodeWorkItemInCodeTask = new XPCollection<TFCodeWorkItemInCodeTask>(TheUow, CriteriaOperator.Parse("g_CodeTaskGuid = ?", g_ID));
            return xpcCodeWorkItemInCodeTask.ToList();
        }

        public List<TFCodeTaskGenerateFee> GetListCodeTaskGenerateFees()
        {
            var xpcCodeTaskGenerateFees = new XPCollection<TFCodeTaskGenerateFee>(TheUow, CriteriaOperator.Parse("g_CodeTaskGuid = ?", g_ID));
            return xpcCodeTaskGenerateFees.ToList();
        }

        public List<TFCodeTaskTriggerTaskChain> GetListCodeTaskTriggerTaskChains()
        {
            var xpcCodeTaskTriggerTaskChains = new XPCollection<TFCodeTaskTriggerTaskChain>(TheUow, CriteriaOperator.Parse("g_CodeTaskGuid = ?", g_ID));
            return xpcCodeTaskTriggerTaskChains.ToList();
        }

        public List<TRCodeRemind> GetListCodeReminds()
        {
            var xpcCodeReminds = new XPCollection<TRCodeRemind>(TheUow, CriteriaOperator.Parse("s_TriggerType = 'Task' And s_TriggerConfigID = ?", g_ID));
            return xpcCodeReminds.ToList();
        }

        public List<TFCodeCaseProcessInCodeTaskChain> GetListCodeCaseProcessInCodeTaskChain()
        {
            var xpcCodeCaseProcessInCodeTaskChain = new XPCollection<TFCodeCaseProcessInCodeTaskChain>(TheUow, CriteriaOperator.Parse("g_CodeTaskGuid = ?", g_ID));
            return xpcCodeCaseProcessInCodeTaskChain.ToList();
        }

        #endregion

        #region Redundant

        public List<TFCodeActionInCodeTask> ListCodeActionInCodeTasks;
        public List<int> ListCodeDemandTypeIDs;
        public List<TFCodeDeadlineInCodeTask> ListCodeDeadlineInCodeTasks;
        public List<TFCodeTaskGenerateFee> ListCodeTaskGenerateFees;
        public List<TFCodeTaskTriggerTaskChain> ListCodeTaskTriggerTaskChains;
        public List<TRCodeRemind> ListCodeReminds;
        public List<TFCodeCaseProcessInCodeTaskChain> ListCodeCaseProcessInCodeTaskChains;
        public List<TFCodeWorkItemInCodeTask> ListCodeWorkItemInCodeTask;
        #endregion

        public TFCodeTask(Session session) : base(session) { }

        public TFCodeTask(Guid guid)
            : this(new UnitOfWork())
        {
            g_ID = guid;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using DataEntities.TaskFlowBase;
using DataEntities.TaskFlowConfig;
using DevExpress.Data.Filtering;
using DevExpress.Xpo;

namespace DataEntities.TaskFlowConfig
{
    [Persistent("TFCode_TaskChain")]
    public class TFCodeTaskChain : XPLiteObjectUser
    {
        Guid fg_ID;
        [Key(false)]
        public Guid g_ID
        {
            get { return fg_ID; }
            set { SetPropertyValue<Guid>("g_ID", ref fg_ID, value); }
        }

        string fs_Code;
        [Size(10)]
        public string s_Code
        {
            get { return fs_Code; }
            set { SetPropertyValue<string>("s_Code", ref fs_Code, value); }
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

        string fs_State;
        [Size(1)]
        public string s_State
        {
            get { return fs_State; }
            set { SetPropertyValue<string>("s_State", ref fs_State, value); }
        }

        int? fn_TaskChainTypeID;
        public int? n_TaskChainTypeID
        {
            get { return fn_TaskChainTypeID; }
            set { SetPropertyValue<int?>("n_TaskChainTypeID", ref fn_TaskChainTypeID, value); }
        }

        string fs_TriggerScope;
        [Size(1)]
        public string s_TriggerScope
        {
            get { return fs_TriggerScope; }
            set { SetPropertyValue<string>("s_TriggerScope", ref fs_TriggerScope, value); }
        }

        string fs_TriggerType;
        [Size(100)]
        public string s_TriggerType
        {
            get { return fs_TriggerType; }
            set { SetPropertyValue<string>("s_TriggerType", ref fs_TriggerType, value); }
        }

        string fs_TriggerCaseIPType;
        [Size(1)]
        public string s_TriggerCaseIPType
        {
            get { return fs_TriggerCaseIPType; }
            set { SetPropertyValue<string>("s_TriggerCaseIPType", ref fs_TriggerCaseIPType, value); }
        }

        string fs_TriggerCameFileIDs;
        [Size(SizeAttribute.Unlimited)]
        public string s_TriggerCameFileIDs
        {
            get { return fs_TriggerCameFileIDs; }
            set { SetPropertyValue<string>("s_TriggerCameFileIDs", ref fs_TriggerCameFileIDs, value); }
        }

        int? fn_Creator;
        public int? n_Creator
        {
            get { return fn_Creator; }
            set { SetPropertyValue<int?>("n_Creator", ref fn_Creator, value); }
        }
        DateTime? fdt_CreateTime;
        public DateTime? dt_CreateTime
        {
            get { return fdt_CreateTime; }
            set { SetPropertyValue<DateTime?>("dt_CreateTime", ref fdt_CreateTime, value); }
        }

        int? fn_Editor;
        public int? n_Editor
        {
            get { return fn_Editor; }
            set { SetPropertyValue<int?>("n_Editor", ref fn_Editor, value); }
        }
        DateTime? fdt_EditTime;
        public DateTime? dt_EditTime
        {
            get { return fdt_EditTime; }
            set { SetPropertyValue<DateTime?>("dt_EditTime", ref fdt_EditTime, value); }
        }

        string fs_FinishCondition;
        [Size(1000)]
        public string s_FinishCondition
        {
            get { return fs_FinishCondition; }
            set { SetPropertyValue<string>("s_FinishCondition", ref fs_FinishCondition, value); }
        }

        #region Method

        public TFCodeTaskChainType GetCodeTaskChainType()
        {
            return TheUow.GetObjectByKey<TFCodeTaskChainType>(n_TaskChainTypeID);
        }

        public TFCodeNode GetTheStartCodeNode()
        {
            return TheUow.FindObject<TFCodeNode>(CriteriaOperator.Parse("g_CodeTaskChainGuid = ? And s_Type = 'S'", g_ID));
        }

        public List<TFCodeNode> GetListCodeNodes()
        {
            var xpcCodeNodes = new XPCollection<TFCodeNode>(TheUow, CriteriaOperator.Parse("g_CodeTaskChainGuid = ?", g_ID));
            return xpcCodeNodes.ToList();
        }

        public List<TFCodeTask> GetlistCodeTasks()
        {
            List<TFCodeTask> list = GetListCodeNodes().Select(s => s.GetTheOwnCodeTask()).ToList();
            return list.Where(t => t != null).ToList();
        }

        public List<TFCodeTaskChain> GetListCodeTaskChains()
        {
            List<TFCodeTaskChain> list = GetListCodeNodes().Select(s => s.GetTheOwnCodeTaskChain()).ToList();
            return list.Where(c => c != null).ToList();
        }

        public List<TFCodeNodeRelation> GetListCodeNodeRelations()
        {
            var xpcCodeNodeRelations = new XPCollection<TFCodeNodeRelation>(TheUow, CriteriaOperator.Parse("g_CodeTaskChainGuid = ?", g_ID));
            return xpcCodeNodeRelations.ToList();
        }

        public List<TFCodeDeadlineInCodeTaskChain> GetListCodeDeadlineInCodeTaskChains()
        {
            var xpcCodeDeadlineInCodeTaskChains = new XPCollection<TFCodeDeadlineInCodeTaskChain>(TheUow, CriteriaOperator.Parse("g_CodeTaskChainGuid = ?", g_ID));
            return xpcCodeDeadlineInCodeTaskChains.ToList();
        }

        public List<TFCodeDeadline> GetListCodeDeadlines()
        {
            var listCodeDeadlineInCodeTaskChains = GetListCodeDeadlineInCodeTaskChains();
            if (listCodeDeadlineInCodeTaskChains.Count == 0) return new List<TFCodeDeadline>();
            return listCodeDeadlineInCodeTaskChains.Select(s => s.GetTheCodeDeadline()).ToList();
        }

        public List<TFCodeWorkItemInCodeTaskChain> GetListCodeWorkItemInCodeTaskChains()
        {
            var xpcCodeWorkItemInCodeTaskChains = new XPCollection<TFCodeWorkItemInCodeTaskChain>(TheUow, CriteriaOperator.Parse("g_CodeTaskChainGuid = ?", g_ID));
            return xpcCodeWorkItemInCodeTaskChains.ToList();
        }

        #endregion

        public TFCodeTaskChain(Session session) : base(session) { }
    }
}
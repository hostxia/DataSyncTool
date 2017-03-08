using System;
using System.Linq;
using DataEntities.TaskFlowBase;
using DataEntities.TaskFlowConfig;
using DevExpress.Data.Filtering;
using DevExpress.Data.PLinq.Helpers;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;

namespace DataEntities.TaskFlowData
{
    [Persistent("TF_Node")]
    public class TFNode : XPLiteObjectUser
    {
        Guid fg_ID;
        [Key(false)]
        public Guid g_ID
        {
            get { return fg_ID; }
            set { SetPropertyValue<Guid>("g_ID", ref fg_ID, value); }
        }

        string fs_CodeNodeCode;
        [Size(21)]
        public string s_CodeNodeCode
        {
            get { return fs_CodeNodeCode; }
            set { SetPropertyValue<string>("s_CodeNodeCode", ref fs_CodeNodeCode, value); }
        }

        Guid fg_TaskChainGuid;
        [NullValue(typeof(Guid), "00000000-0000-0000-0000-000000000000")]
        public Guid g_TaskChainGuid
        {
            get { return fg_TaskChainGuid; }
            set { SetPropertyValue<Guid>("g_TaskChainGuid", ref fg_TaskChainGuid, value); }
        }

        Guid fg_FormerNodeGuid;
        [NullValue(typeof(Guid), "00000000-0000-0000-0000-000000000000")]
        public Guid g_FormerNodeGuid
        {
            get { return fg_FormerNodeGuid; }
            set { SetPropertyValue<Guid>("g_FormerNodeGuid", ref fg_FormerNodeGuid, value); }
        }

        string fs_Mode;
        [Size(1)]
        public string s_Mode
        {
            get { return fs_Mode; }
            set { SetPropertyValue<string>("s_Mode", ref fs_Mode, value); }
        }

        string fs_Type;
        [Size(1)]
        public string s_Type
        {
            get { return fs_Type; }
            set { SetPropertyValue<string>("s_Type", ref fs_Type, value); }
        }

        Guid fg_OwnTaskChainGuid;
        [NullValue(typeof(Guid), "00000000-0000-0000-0000-000000000000")]
        public Guid g_OwnTaskChainGuid
        {
            get { return fg_OwnTaskChainGuid; }
            set { SetPropertyValue<Guid>("g_OwnTaskChainGuid", ref fg_OwnTaskChainGuid, value); }
        }

        Guid fg_OwnTaskGuid;
        [NullValue(typeof(Guid), "00000000-0000-0000-0000-000000000000")]
        public Guid g_OwnTaskGuid
        {
            get { return fg_OwnTaskGuid; }
            set { SetPropertyValue<Guid>("g_OwnTaskGuid", ref fg_OwnTaskGuid, value); }
        }

        #region Method

        public TFCodeNode GetTheCodeNode()
        {
            return string.IsNullOrEmpty(s_CodeNodeCode) ? null : TheUow.FindObject<TFCodeNode>(CriteriaOperator.Parse("s_Code = ?", s_CodeNodeCode));
        }

        public TFCodeNodeRelation GetTheTriggerCodeNodeRelation(TFNode parentNode)
        {
            var parentCodeNode = parentNode.GetTheCodeNode();
            var codeNode = GetTheCodeNode();
            return TheUow.FindObject<TFCodeNodeRelation>(CriteriaOperator.Parse("g_FromNodeGuid = ? And g_ToNodeGuid = ?", parentCodeNode.g_ID, codeNode.g_ID));
        }

        public TFNode GetTheFormerNode()
        {
            return TheUow.FindObject<TFNode>(CriteriaOperator.Parse("g_ID = ?", g_FormerNodeGuid));
        }

        public TFTaskChain GetTheTaskChain()
        {
            return TheUow.GetObjectByKey<TFTaskChain>(g_TaskChainGuid);
        }

        public TFTask GetTheOwnTask()
        {
            return s_Type == "T" ? TheUow.GetObjectByKey<TFTask>(g_OwnTaskGuid) : null;
        }

        public TFTaskChain GetTheOwnTaskChain()
        {
            return s_Type == "C" ? TheUow.GetObjectByKey<TFTaskChain>(g_OwnTaskChainGuid) : null;
        }

        public TFTask GetTheOwnTaskInTransaction()
        {
            return s_Type == "T" ? TheUow.GetObjectsInTransaction(TheUow.GetClassInfo<TFTask>(), CriteriaOperator.Parse("g_ID = ?", g_OwnTaskGuid), false).Cast<TFTask>().FirstOrDefault() : null;
        }

        public TFTaskChain GetTheOwnTaskChainInTransaction()
        {
            return s_Type == "C" ? TheUow.GetObjectsInTransaction(TheUow.GetClassInfo<TFTaskChain>(), CriteriaOperator.Parse("g_ID = ?", g_OwnTaskChainGuid), false).Cast<TFTaskChain>().FirstOrDefault() : null;
        }

        #endregion

        public TFNode(Session session) : base(session) { }
    }
}
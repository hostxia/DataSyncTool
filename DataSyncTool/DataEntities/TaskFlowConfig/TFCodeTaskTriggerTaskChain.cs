using System;
using DataEntities.TaskFlowBase;
using DevExpress.Xpo;

namespace DataEntities.TaskFlowConfig
{
    [Persistent("TFCode_TaskTriggerTaskChain")]
    public class TFCodeTaskTriggerTaskChain : XPLiteObjectUser
    {
        Guid fg_ID;
        [Key(false)]
        public Guid g_ID
        {
            get { return fg_ID; }
            set { SetPropertyValue<Guid>("g_ID", ref fg_ID, value); }
        }

        Guid fg_CodeTaskGuid;
        public Guid g_CodeTaskGuid
        {
            get { return fg_CodeTaskGuid; }
            set { SetPropertyValue<Guid>("g_CodeTaskGuid", ref fg_CodeTaskGuid, value); }
        }

        Guid fg_CodeTaskChainGuid;
        public Guid g_CodeTaskChainGuid
        {
            get { return fg_CodeTaskChainGuid; }
            set { SetPropertyValue<Guid>("g_CodeTaskChainGuid", ref fg_CodeTaskChainGuid, value); }
        }

        string fs_RelatedObjectSource;
        [Size(50)]
        public string s_RelatedObjectSource
        {
            get { return fs_RelatedObjectSource; }
            set { SetPropertyValue<string>("s_RelatedObjectSource", ref fs_RelatedObjectSource, value); }
        }

        string fs_MasterSlaveRelation;
        [Size(2)]
        public string s_MasterSlaveRelation
        {
            get { return fs_MasterSlaveRelation; }
            set { SetPropertyValue<string>("s_MasterSlaveRelation", ref fs_MasterSlaveRelation, value); }
        }

        public string s_ShowMasterSlaveRelation
        {
            get { return fs_RelatedObjectSource + "|" + fs_MasterSlaveRelation; }
        }

        string fs_TriggerTime;
        [Size(1)]
        public string s_TriggerTime
        {
            get { return fs_TriggerTime; }
            set { SetPropertyValue<string>("s_TriggerTime", ref fs_TriggerTime, value); }
        }

        string fs_TriggerCondition;
        [Size(2000)]
        public string s_TriggerCondition
        {
            get { return fs_TriggerCondition; }
            set { SetPropertyValue<string>("s_TriggerCondition", ref fs_TriggerCondition, value); }
        }

        string fs_Repeat;
        [Size(1)]
        public string s_Repeat
        {
            get { return fs_Repeat; }
            set { SetPropertyValue<string>("s_Repeat", ref fs_Repeat, value); }
        }

        #region Method

        public TFCodeTask GetTheCodeTask()
        {
            return TheUow.GetObjectByKey<TFCodeTask>(g_CodeTaskGuid);
        }

        public TFCodeTaskChain GetTheCodeTaskChain()
        {
            return TheUow.GetObjectByKey<TFCodeTaskChain>(g_CodeTaskChainGuid);
        }

        #endregion

        #region Redundant

        [NonPersistent]
        public string s_MasterSlaveRelationDisplay
        {
            get { return fs_RelatedObjectSource + fs_MasterSlaveRelation; }
        }

        [NonPersistent]
        public string s_TriggerConditionDisplay { get; set; }

        #endregion

        public TFCodeTaskTriggerTaskChain(Session session) : base(session) { }

        public TFCodeTaskTriggerTaskChain(Guid guid)
            : this(new UnitOfWork())
        {
            g_ID = guid;
        }
    }
}
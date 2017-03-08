using System;
using DataEntities.TaskFlowBase;
using DevExpress.Xpo;

namespace DataEntities.TaskFlowConfig
{
    [Persistent("TFCode_NodeRelation")]
    public class TFCodeNodeRelation : XPLiteObjectUser
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

        Guid fg_CodeTaskChainGuid;
        public Guid g_CodeTaskChainGuid
        {
            get { return fg_CodeTaskChainGuid; }
            set { SetPropertyValue<Guid>("g_CodeTaskChainGuid", ref fg_CodeTaskChainGuid, value); }
        }

        Guid fg_FromNodeGuid;
        public Guid g_FromNodeGuid
        {
            get { return fg_FromNodeGuid; }
            set { SetPropertyValue<Guid>("g_FromNodeGuid", ref fg_FromNodeGuid, value); }
        }

        Guid fg_ToNodeGuid;
        public Guid g_ToNodeGuid
        {
            get { return fg_ToNodeGuid; }
            set { SetPropertyValue<Guid>("g_ToNodeGuid", ref fg_ToNodeGuid, value); }
        }

        string fs_Condition;
        [Size(2000)]
        public string s_Condition
        {
            get { return fs_Condition; }
            set { SetPropertyValue<string>("s_Condition", ref fs_Condition, value); }
        }

        string fs_Reopen;
        [Size(1)]
        public string s_Reopen
        {
            get { return fs_Reopen; }
            set { SetPropertyValue<string>("s_Reopen", ref fs_Reopen, value); }
        }

        #region Method

        public TFCodeNode GetTheCodeNodeFrom()
        {
            return TheUow.GetObjectByKey<TFCodeNode>(g_FromNodeGuid);
        }

        public TFCodeNode GetTheCodeNodeTo()
        {
            return TheUow.GetObjectByKey<TFCodeNode>(g_ToNodeGuid);
        }

        #endregion

        public TFCodeNodeRelation(Session session) : base(session) { }

        public TFCodeNodeRelation(Guid guid) : this(new UnitOfWork())
        {
            g_ID = guid;
        }
    }
}
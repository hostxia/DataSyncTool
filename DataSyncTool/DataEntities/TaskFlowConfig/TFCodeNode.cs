using System;
using System.Collections.Generic;
using System.Linq;
using DataEntities.TaskFlowBase;
using DevExpress.Data.Filtering;
using DevExpress.Xpo;

namespace DataEntities.TaskFlowConfig
{
    [Persistent("TFCode_Node")]
    public class TFCodeNode : XPLiteObjectUser
    {
        Guid fg_ID;
        [Key(false)]
        public Guid g_ID
        {
            get { return fg_ID; }
            set { SetPropertyValue<Guid>("g_ID", ref fg_ID, value); }
        }

        Guid fg_CodeTaskChainGuid;
        public Guid g_CodeTaskChainGuid
        {
            get { return fg_CodeTaskChainGuid; }
            set { SetPropertyValue<Guid>("g_CodeTaskChainGuid", ref fg_CodeTaskChainGuid, value); }
        }

        string fs_Type;
        [Size(1)]
        public string s_Type
        {
            get { return fs_Type; }
            set { SetPropertyValue<string>("s_Type", ref fs_Type, value); }
        }

        Guid fg_OwnCodeTaskChainGuid;
        [NullValue(typeof(Guid), "00000000-0000-0000-0000-000000000000")]
        public Guid g_OwnCodeTaskChainGuid
        {
            get { return fg_OwnCodeTaskChainGuid; }
            set { SetPropertyValue<Guid>("g_OwnCodeTaskChainGuid", ref fg_OwnCodeTaskChainGuid, value); }
        }

        Guid fg_OwnCodeTaskGuid;
        [NullValue(typeof(Guid), "00000000-0000-0000-0000-000000000000")]
        public Guid g_OwnCodeTaskGuid
        {
            get { return fg_OwnCodeTaskGuid; }
            set { SetPropertyValue<Guid>("g_OwnCodeTaskGuid", ref fg_OwnCodeTaskGuid, value); }
        }

        string fs_PreGenerate;
        [Size(1)]
        public string s_PreGenerate
        {
            get { return fs_PreGenerate; }
            set { SetPropertyValue<string>("s_PreGenerate", ref fs_PreGenerate, value); }
        }

        string fs_PreCondition;
        [Size(2000)]
        public string s_PreCondition
        {
            get { return fs_PreCondition; }
            set { SetPropertyValue<string>("s_PreCondition", ref fs_PreCondition, value); }
        }

        string fs_Code;
        [Size(21)]
        public string s_Code
        {
            get { return fs_Code; }
            set { SetPropertyValue<string>("s_Code", ref fs_Code, value); }
        }

        #region Method

        public TFCodeTaskChain GetTheCodeTaskChain()
        {
            return TheUow.GetObjectByKey<TFCodeTaskChain>(g_CodeTaskChainGuid);
        }

        public TFCodeTask GetTheOwnCodeTask()
        {
            return s_Type == "T" ? TheUow.GetObjectByKey<TFCodeTask>(g_OwnCodeTaskGuid) : null;
        }

        public TFCodeTaskChain GetTheOwnCodeTaskChain()
        {
            return s_Type == "C" ? TheUow.GetObjectByKey<TFCodeTaskChain>(g_OwnCodeTaskChainGuid) : null;
        }

        public List<TFCodeNodeRelation> GetListOutCodeNodeRelations()
        {
            var xpcCodeNodeRelations = new XPCollection<TFCodeNodeRelation>(TheUow, CriteriaOperator.Parse("g_FromNodeGuid = ?", g_ID));
            return xpcCodeNodeRelations.ToList();
        }

        public List<TFCodeNodeRelation> GetListInCodeNodeRelations()
        {
            var xpcCodeNodeRelations = new XPCollection<TFCodeNodeRelation>(TheUow, CriteriaOperator.Parse("g_ToNodeGuid = ?", g_ID));
            return xpcCodeNodeRelations.ToList();
        }

        #endregion

        public TFCodeNode(Session session) : base(session) { }

        public TFCodeNode(Guid guid, string sNodeType) : this(new UnitOfWork())
        {
            g_ID = guid;
            s_Type = sNodeType;
        }
    }
}
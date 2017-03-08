using System;
using DataEntities.TaskFlowBase;
using DevExpress.Data.Filtering;
using DevExpress.Xpo;

namespace DataEntities.TaskFlowConfig
{
    [Persistent("TFCode_WorkItemInCodeTaskChain")]
    public class TFCodeWorkItemInCodeTaskChain : XPLiteObjectUser
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

        int fn_CodeWorkItemID;
        public int n_CodeWorkItemID
        {
            get { return fn_CodeWorkItemID; }
            set { SetPropertyValue<int>("n_CodeWorkItemID", ref fn_CodeWorkItemID, value); }
        }

        string fs_Description;
        [Size(1000)]
        public string s_Description
        {
            get { return fs_Description; }
            set { SetPropertyValue<string>("s_Description", ref fs_Description, value); }
        }

        [NonPersistent]
        public int n_CodeWorkItemIDForType
        {
            get { return fn_CodeWorkItemID; }
            set { SetPropertyValue<int>("n_CodeWorkItemID", ref fn_CodeWorkItemID, value); }
        }

        [NonPersistent]
        public int n_CodeWorkItemIDForUnit
        {
            get { return fn_CodeWorkItemID; }
            set { SetPropertyValue<int>("n_CodeWorkItemID", ref fn_CodeWorkItemID, value); }
        }

        #region Method

        public TFCodeWorkItem GetTheCodeWorkItem()
        {
            return TheUow.FindObject<TFCodeWorkItem>(CriteriaOperator.Parse("n_ID = ?", n_CodeWorkItemID));
        }

        #endregion

        public TFCodeWorkItemInCodeTaskChain(Session session) : base(session) { }

        public TFCodeWorkItemInCodeTaskChain(Guid guid)
            : this(new UnitOfWork())
        {
            g_ID = guid;
        }
    }
}
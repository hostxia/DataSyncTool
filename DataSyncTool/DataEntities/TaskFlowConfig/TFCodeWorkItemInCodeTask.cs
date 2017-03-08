using DataEntities.TaskFlowBase;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataEntities.TaskFlowConfig
{
    [Persistent("TFCode_WorkItemInCodeTaskMap")]
    public class TFCodeWorkItemInCodeTask : XPLiteObjectUser
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

        public TFCodeWorkItemInCodeTask(Session session) : base(session) { }

        public TFCodeWorkItemInCodeTask(Guid guid)
            : this(new UnitOfWork())
        {
            g_ID = guid;
        }
    }
}

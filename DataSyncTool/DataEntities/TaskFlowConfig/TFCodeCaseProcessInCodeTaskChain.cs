using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataEntities.Config;
using DataEntities.TaskFlowBase;
using DevExpress.Xpo;

namespace DataEntities.TaskFlowConfig
{
    [Persistent("TFCode_CaseProcessInCodeTaskChain")]
    public class TFCodeCaseProcessInCodeTaskChain : XPLiteObjectUser
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

        int fn_CodeCaseProcessID;
        public int n_CodeCaseProcessID
        {
            get { return fn_CodeCaseProcessID; }
            set { SetPropertyValue<int>("n_CodeCaseProcessID", ref fn_CodeCaseProcessID, value); }
        }

        int fn_CodeCaseProcessItemID;
        public int n_CodeCaseProcessItemID
        {
            get { return fn_CodeCaseProcessItemID; }
            set { SetPropertyValue<int>("n_CodeCaseProcessItemID", ref fn_CodeCaseProcessItemID, value); }
        }

        string fs_When;
        public string s_When
        {
            get { return fs_When; }
            set { SetPropertyValue<string>("s_When", ref fs_When, value); }
        }

        #region  Redundant
        [NonPersistent]
        public CodeCaseProcess TheCodeCaseProcess { get; set; }

        [NonPersistent]
        public CodeCaseProcessItem TheCodeCaseProcessItem { get; set; }
        #endregion

        public TFCodeCaseProcessInCodeTaskChain(Session session) : base(session) { }

        public TFCodeCaseProcessInCodeTaskChain(Guid guid)
            : this(new UnitOfWork())
        {
            g_ID = guid;
        }
    }
}

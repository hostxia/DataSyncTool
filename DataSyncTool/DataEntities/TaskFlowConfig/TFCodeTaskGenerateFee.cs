using System;
using DataEntities.Config;
using DataEntities.TaskFlowBase;
using DevExpress.Xpo;

namespace DataEntities.TaskFlowConfig
{
    [Persistent("TFCode_TaskGenerateFee")]
    public class TFCodeTaskGenerateFee : XPLiteObjectUser
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

        int fn_CodeFeeID;
        public int n_CodeFeeID
        {
            get { return fn_CodeFeeID; }
            set { SetPropertyValue<int>("n_CodeFeeID", ref fn_CodeFeeID, value); }
        }

        string fs_GenerateTime;
        [Size(1)]
        public string s_GenerateTime
        {
            get { return fs_GenerateTime; }
            set { SetPropertyValue<string>("s_GenerateTime", ref fs_GenerateTime, value); }
        }

        string fs_GenerateCondition;
        [Size(2000)]
        public string s_GenerateCondition
        {
            get { return fs_GenerateCondition; }
            set { SetPropertyValue<string>("s_GenerateCondition", ref fs_GenerateCondition, value); }
        }

        #region Method

        public CodeFee GetTheCodeFee()
        {
            return TheUow.GetObjectByKey<CodeFee>(n_CodeFeeID);
        }

        #endregion

        #region Redundant

        [NonPersistent]
        public string s_GenerateConditionDisplay { get; set; }

        #endregion

        public TFCodeTaskGenerateFee(Session session) : base(session) { }

        public TFCodeTaskGenerateFee(Guid guid) : this(new UnitOfWork())
        {
            g_ID = guid;
        }
    }
}
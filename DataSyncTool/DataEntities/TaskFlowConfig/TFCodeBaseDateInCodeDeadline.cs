using System;
using DataEntities.TaskFlowBase;
using DevExpress.Xpo;

namespace DataEntities.TaskFlowConfig
{
    [Persistent("TFCode_BaseDateInCodeDeadline")]
    public class TFCodeBaseDateInCodeDeadline : XPLiteObjectUser
    {
        int fn_ID;
        [Key(true)]
        public int n_ID
        {
            get { return fn_ID; }
            set { SetPropertyValue<int>("n_ID", ref fn_ID, value); }
        }

        Guid fg_CodeDeadlineID;
        public Guid g_CodeDeadlineID
        {
            get { return fg_CodeDeadlineID; }
            set { SetPropertyValue<Guid>("g_CodeDeadlineID", ref fg_CodeDeadlineID, value); }
        }

        int? fn_CodeBaseDateID;
        public int? n_CodeBaseDateID
        {
            get { return fn_CodeBaseDateID; }
            set { SetPropertyValue<int?>("n_CodeBaseDateID", ref fn_CodeBaseDateID, value); }
        }

        string fs_CalcRule;
        [Size(50)]
        public string s_CalcRule
        {
            get { return fs_CalcRule; }
            set { SetPropertyValue<string>("s_CalcRule", ref fs_CalcRule, value); }
        }

        int fn_Month;
        public int n_Month
        {
            get { return fn_Month; }
            set { SetPropertyValue<int>("n_Month", ref fn_Month, value); }
        }

        int fn_Day;
        public int n_Day
        {
            get { return fn_Day; }
            set { SetPropertyValue<int>("n_Day", ref fn_Day, value); }
        }

        #region Method

        public TFCodeBaseDate GetTheCodeBaseDate()
        {
            return TheUow.GetObjectByKey<TFCodeBaseDate>(n_CodeBaseDateID);
        }

        public TFCodeDeadline GetTheCodeDeadline()
        {
            return TheUow.GetObjectByKey<TFCodeDeadline>(g_CodeDeadlineID);
        }

        #endregion

        public TFCodeBaseDateInCodeDeadline(Session session) : base(session) { }
    }
}

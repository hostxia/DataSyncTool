using System;
using DevExpress.Xpo;

namespace DataEntities.Config.Check.Info
{
    [Persistent(@"T_CheckInfo")]
    public class CheckInfo : XPLiteObject
    {
        private CheckFlow checkFlow;
        private DateTime fdt_CheckTime;
        private int fn_Checker;
        private int fn_ID;
        private string fs_CheckStatus;
        private string fs_Reason;

        public CheckInfo(Session session) : base(session)
        {
        }

        public CheckInfo() : base(Session.DefaultSession)
        {
        }

        [Key(true)]
        public int n_ID
        {
            get { return fn_ID; }
            set { SetPropertyValue<int>("n_ID", ref fn_ID, value); }
        }

        [Persistent("n_CheckFlowID"), Association("CheckFlow-CheckInfos")]
        public CheckFlow TheCheckFlow
        {
            get { return checkFlow; }
            set { SetPropertyValue("n_CheckFlowID", ref checkFlow, value); }
        }

        public int n_Checker
        {
            get { return fn_Checker; }
            set { SetPropertyValue<int>("n_Checker", ref fn_Checker, value); }
        }

        [Size(50)]
        public string s_CheckStatus
        {
            get { return fs_CheckStatus; }
            set { SetPropertyValue("s_CheckStatus", ref fs_CheckStatus, value); }
        }

        [Size(200)]
        public string s_Reason
        {
            get { return fs_Reason; }
            set { SetPropertyValue("s_Reason", ref fs_Reason, value); }
        }

        public DateTime dt_CheckTime
        {
            get { return fdt_CheckTime; }
            set { SetPropertyValue<DateTime>("dt_CheckTime", ref fdt_CheckTime, value); }
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}
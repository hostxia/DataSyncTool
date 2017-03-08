using System;
using DevExpress.Xpo;

namespace DataEntities.Config.Check.Info
{
    [Persistent(@"T_CheckFlow")]
    public class CheckFlow : XPLiteObject
    {
        private DateTime fdt_LimitTime;
        private DateTime fdt_ResultTime;
        private int fn_FlowSeq;
        private int fn_ID;
        private string fs_CheckResult;
        private string fs_FlowName;

        public CheckFlow(Session session) : base(session)
        {
        }

        public CheckFlow() : base(Session.DefaultSession)
        {
        }

        [Key(true)]
        public int n_ID
        {
            get { return fn_ID; }
            set { SetPropertyValue<int>("n_ID", ref fn_ID, value); }
        }

        public int n_FlowSeq
        {
            get { return fn_FlowSeq; }
            set { SetPropertyValue<int>("n_FlowSeq", ref fn_FlowSeq, value); }
        }

        [Size(50)]
        public string s_FlowName
        {
            get { return fs_FlowName; }
            set { SetPropertyValue("s_FlowName", ref fs_FlowName, value); }
        }

        [Size(50)]
        public string s_CheckResult
        {
            get { return fs_CheckResult; }
            set { SetPropertyValue("s_CheckResult", ref fs_CheckResult, value); }
        }

        public DateTime dt_ResultTime
        {
            get { return fdt_ResultTime; }
            set { SetPropertyValue<DateTime>("dt_ResultTime", ref fdt_ResultTime, value); }
        }

        public DateTime dt_LimitTime
        {
            get { return fdt_LimitTime; }
            set { SetPropertyValue<DateTime>("dt_LimitTime", ref fdt_LimitTime, value); }
        }

        [Aggregated, Association("CheckFlow-CheckInfos")]
        public XPCollection<CheckInfo> CheckInfos
        {
            get { return GetCollection<CheckInfo>("CheckInfos"); }
        }

        [Aggregated, Association("CheckFlow-ExpenseChecks")]
        public XPCollection<ExpenseChecks> ExpenseChecks
        {
            get { return GetCollection<ExpenseChecks>("ExpenseChecks"); }
        }

        [Aggregated, Association("CheckFlow-OutFileChecks")]
        public XPCollection<OutFileChecks> OutFileChecks
        {
            get { return GetCollection<OutFileChecks>("OutFileChecks"); }
        }

        [Aggregated, Association("CheckFlow-AbroadBillChecks")]
        public XPCollection<AbroadBillChecks> AbroadBillChecks
        {
            get { return GetCollection<AbroadBillChecks>("AbroadBillChecks"); }
        }

        [Aggregated, Association("CheckFlow-BillChecks")]
        public XPCollection<BillChecks> BillChecks
        {
            get { return GetCollection<BillChecks>("BillChecks"); }
        }

        [Aggregated, Association("CheckFlow-TaskChecks")]
        public XPCollection<TaskChecks> TaskChecks
        {
            get { return GetCollection<TaskChecks>("TaskChecks"); }
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}
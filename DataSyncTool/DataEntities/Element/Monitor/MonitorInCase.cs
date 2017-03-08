using DataEntities.Case;
using DevExpress.Xpo;

namespace DataEntities.Element.Monitor
{
    [Persistent("T_MonitorInCase")]
    public class MonitorInCase : XPLiteObject
    {
        private BasicCase basicCase;
        private int fn_ID;
        private string fs_IsMainCase;

        private Monitor monitor;
        private Process process;

        public MonitorInCase(Session session) : base(session)
        {
        }

        public MonitorInCase() : base(Session.DefaultSession)
        {
        }

        [Key(true)]
        public int n_ID
        {
            get { return fn_ID; }
            set { SetPropertyValue<int>("n_ID", ref fn_ID, value); }
        }

        [Association("Monitor-MonitorInCases")]
        [Persistent("n_MonitorID")]
        public Monitor TheMonitor
        {
            get { return monitor; }
            set { SetPropertyValue("n_MonitorID", ref monitor, value); }
        }

        [Association("Case-MonitorInCases")]
        [Persistent("n_CaseID")]
        public BasicCase TheCase
        {
            get { return basicCase; }
            set { SetPropertyValue("n_CaseID", ref basicCase, value); }
        }

        [Association("Process-MonitorInCases")]
        [Persistent("n_ProcessID")]
        public Process TheProcess
        {
            get { return process; }
            set { SetPropertyValue("n_ProcessID", ref process, value); }
        }

        [Size(1)]
        [Persistent("s_IsMainCase")]
        public string s_IsMainCase
        {
            get { return fs_IsMainCase; }
            set { SetPropertyValue("s_IsMainCase", ref fs_IsMainCase, value); }
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}
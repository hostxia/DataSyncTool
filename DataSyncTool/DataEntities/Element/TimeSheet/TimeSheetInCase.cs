using DataEntities.Case;
using DevExpress.Xpo;

namespace DataEntities.Element.TimeSheet
{
    [Persistent("T_TimeSheetInCase")]
    public class TimeSheetInCase : XPLiteObject
    {
        private BasicCase basicCase;
        private int fn_ID;
        private string fs_IsMainCase;
        private Process process;

        private TimeSheet timeSheet;

        public TimeSheetInCase(Session session) : base(session)
        {
        }

        public TimeSheetInCase() : base(Session.DefaultSession)
        {
        }

        [Key(true)]
        public int n_ID
        {
            get { return fn_ID; }
            set { SetPropertyValue<int>("n_ID", ref fn_ID, value); }
        }

        [Association("TimeSheet-InCase")]
        [Persistent("n_TimesheetID")]
        public TimeSheet Timesheet
        {
            get { return timeSheet; }
            set { SetPropertyValue("n_TimesheetID", ref timeSheet, value); }
        }

        [Association("Case-TimeSheet")]
        [Persistent("n_CaseID")]
        public BasicCase TheCase
        {
            get { return basicCase; }
            set { SetPropertyValue("n_CaseID", ref basicCase, value); }
        }

        [Association("Process-TimeSheet")]
        [Persistent("n_ProcessID")]
        public Process TheProcess
        {
            get { return process; }
            set { SetPropertyValue("n_ProcessID", ref process, value); }
        }

        [Size(1)]
        public string IsMainCase
        {
            get { return fs_IsMainCase; }
            set { SetPropertyValue("s_IsMainCase", ref fs_IsMainCase, value); }
        }

        [NonPersistent]
        public bool Check { get; set; }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}
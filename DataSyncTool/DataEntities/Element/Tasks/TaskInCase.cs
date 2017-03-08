using DataEntities.Case;
using DevExpress.Xpo;

namespace DataEntities.Element.Tasks
{
    [Persistent("T_TaskInCase")]
    public class TaskInCase : XPLiteObject
    {
        private BasicCase basicCase;
        private int fn_ID;
        private string fs_IsMainCase;
        private Process process;

        private Task task;

        public TaskInCase(Session session) : base(session)
        {
        }

        public TaskInCase() : base(Session.DefaultSession)
        {
        }

        [Key(true)]
        public int n_ID
        {
            get { return fn_ID; }
            set { SetPropertyValue<int>("n_ID", ref fn_ID, value); }
        }

        [Persistent("n_TaskID")]
        [Association("Task-TaskInCases")]
        public Task TheTask
        {
            get { return task; }
            set { SetPropertyValue("n_TaskID", ref task, value); }
        }

        [Persistent("n_CaseID")]
        [Association("Case-TaskInCases")]
        public BasicCase TheCase
        {
            get { return basicCase; }
            set { SetPropertyValue("n_CaseID", ref basicCase, value); }
        }

        [Persistent("n_ProcessID")]
        [Association("Process-TaskInCases")]
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

        [NonPersistent]
        public bool DefaultCheck { get; set; }

        //此字段只是用于PA导入数据
        [NonPersistent]
        public string PA_TaskID { get; set; }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}
using DataEntities.Element.Tasks;
using DevExpress.Xpo;

namespace DataEntities.Config.Check.Info
{
    [Persistent(@"T_TaskChecks")]
    public class TaskChecks : XPLiteObject
    {
        private CheckFlow checkFlow;
        private int fn_ID;

        private Task task;

        public TaskChecks(Session session) : base(session)
        {
        }

        public TaskChecks() : base(Session.DefaultSession)
        {
        }

        [Key(true)]
        public int n_ID
        {
            get { return fn_ID; }
            set { SetPropertyValue<int>("n_ID", ref fn_ID, value); }
        }

        [Persistent("n_TaskID"), Association("Task-TaskChecks")]
        public Task TheTask
        {
            get { return task; }
            set { SetPropertyValue("n_TaskID", ref task, value); }
        }

        [Persistent("n_CheckFlowID"), Association("CheckFlow-TaskChecks")]
        public CheckFlow TheCheckFlow
        {
            get { return checkFlow; }
            set { SetPropertyValue("n_CheckFlowID", ref checkFlow, value); }
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}
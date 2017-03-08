using DevExpress.Xpo;

namespace DataEntities.Element.Tasks
{
    [Persistent("T_TaskRelation")]
    public class TaskRelation : XPLiteObject
    {
        private int fn_ID;

        //int fn_TaskID;
        //public int n_TaskID
        //{
        //    get { return fn_TaskID; }
        //    set { SetPropertyValue<int>("n_TaskID", ref fn_TaskID, value); }
        //}

        private Task subtask;
        private Task task;

        //int fn_SubTaskID;
        //public int n_SubTaskID
        //{
        //    get { return fn_SubTaskID; }
        //    set { SetPropertyValue<int>("n_SubTaskID", ref fn_SubTaskID, value); }
        //}
        public TaskRelation(Session session) : base(session)
        {
        }

        public TaskRelation() : base(Session.DefaultSession)
        {
        }

        [Key(true)]
        public int n_ID
        {
            get { return fn_ID; }
            set { SetPropertyValue<int>("n_ID", ref fn_ID, value); }
        }

        [Persistent("n_TaskID")]
        [Association("Task-TaskRelations")]
        public Task TheTask
        {
            get { return task; }
            set { SetPropertyValue("n_TaskID", ref task, value); }
        }

        [Persistent("n_SubTaskID")]
        [Association("Task-SubTaskRelations")]
        public Task TheSubTask
        {
            get { return subtask; }
            set { SetPropertyValue("n_SubTaskID", ref subtask, value); }
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}
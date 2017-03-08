using DevExpress.Xpo;

namespace DataEntities.Config
{
    [Persistent("TCode_SysTasksDemandCondition")]
    public class CodeSysTasksDemandCondition : XPLiteObject
    {
        private CodeDemand codeDemand;
        private CodeSysTasks codeSysTasks;
        private bool fb_Exist;
        private int fn_ID;

        public CodeSysTasksDemandCondition(Session session) : base(session)
        {
        }

        public CodeSysTasksDemandCondition() : base(Session.DefaultSession)
        {
        }

        [Key(true)]
        public int n_ID
        {
            get { return fn_ID; }
            set { SetPropertyValue<int>("n_ID", ref fn_ID, value); }
        }

        [Association("CodeSysTask-CodeSysTasksDemandCondition")]
        [Persistent("n_SysTaskCodeID")]
        public CodeSysTasks TheCodeSysTask
        {
            get { return codeSysTasks; }
            set { SetPropertyValue("n_SysTaskCodeID", ref codeSysTasks, value); }
        }

        [Association("CodeDemand-CodeSysTasksDemandCondition")]
        [Persistent("n_CodeDemandID")]
        public CodeDemand TheCodeDemand
        {
            get { return codeDemand; }
            set { SetPropertyValue("n_CodeDemandID", ref codeDemand, value); }
        }

        public bool b_Exist
        {
            get { return fb_Exist; }
            set { SetPropertyValue("b_Exist", ref fb_Exist, value); }
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}
using DataEntities.Element.Files;
using DevExpress.Xpo;

namespace DataEntities.Config.Check.Info
{
    [Persistent(@"T_OutFileChecks")]
    public class OutFileChecks : XPLiteObject
    {
        private CheckFlow checkFlow;
        private int fn_ID;

        private OutFile outFile;

        public OutFileChecks(Session session) : base(session)
        {
        }

        public OutFileChecks() : base(Session.DefaultSession)
        {
        }

        [Key(true)]
        public int n_ID
        {
            get { return fn_ID; }
            set { SetPropertyValue<int>("n_ID", ref fn_ID, value); }
        }

        [Persistent("n_OutFileID"), Association("OutFile-OutFileChecks")]
        public OutFile TheOutFile
        {
            get { return outFile; }
            set { SetPropertyValue("n_OutFileID", ref outFile, value); }
        }

        [Persistent("n_CheckFlowID"), Association("CheckFlow-OutFileChecks")]
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
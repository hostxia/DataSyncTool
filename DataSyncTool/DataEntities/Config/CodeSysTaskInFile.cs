using DevExpress.Xpo;

namespace DataEntities.Config
{
    [Persistent("TCode_SysTaskInFile")]
    public class CodeSysTaskInFile : XPLiteObject
    {
        private CodeCameFile codeCameFile;
        private CodeSysTasks codeSysTasks;
        private int fn_ID;

        public CodeSysTaskInFile(Session session) : base(session)
        {
        }

        public CodeSysTaskInFile() : base(Session.DefaultSession)
        {
        }

        [Key(true)]
        public int n_ID
        {
            get { return fn_ID; }
            set { SetPropertyValue<int>("n_ID", ref fn_ID, value); }
        }

        [Association("CodeSysTask-CodeCameFileInTask")]
        [Persistent("n_SysTaskCodeID")]
        public CodeSysTasks CodeSysTask
        {
            get { return codeSysTasks; }
            set { SetPropertyValue("n_SysTaskCodeID", ref codeSysTasks, value); }
        }

        [Association("CodeCameFile-SysTaskInCameFile")]
        [Persistent("n_OInfileID")]
        public CodeCameFile CodeCameFile
        {
            get { return codeCameFile; }
            set { SetPropertyValue("n_OInfileID", ref codeCameFile, value); }
        }

        [NonPersistent]
        public bool Check { get; set; }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}
using DevExpress.Xpo;

namespace DataEntities.Config
{
    [Persistent("TCode_CaseProcess")]
    public class CodeCaseProcess : XPLiteObject
    {
        private int fn_BizTypeID;
        private int fn_Country;
        private int fn_ID;
        private string fs_IPType;
        private string fs_IsDefault;
        private string fs_Notes;
        private string fs_PTCType;

        public CodeCaseProcess(Session session) : base(session)
        {
        }

        public CodeCaseProcess() : base(Session.DefaultSession)
        {
        }

        [Key(true)]
        public int n_ID
        {
            get { return fn_ID; }
            set { SetPropertyValue<int>("n_ID", ref fn_ID, value); }
        }

        public int n_BizTypeID
        {
            get { return fn_BizTypeID; }
            set { SetPropertyValue<int>("n_BizTypeID", ref fn_BizTypeID, value); }
        }

        [Size(50)]
        public string s_PTCType
        {
            get { return fs_PTCType; }
            set { SetPropertyValue("s_PTCType", ref fs_PTCType, value); }
        }

        public int n_Country
        {
            get { return fn_Country; }
            set { SetPropertyValue<int>("n_Country", ref fn_Country, value); }
        }

        [Size(1)]
        public string s_IsDefault
        {
            get { return fs_IsDefault; }
            set { SetPropertyValue("s_IsDefault", ref fs_IsDefault, value); }
        }

        [Size(800)]
        public string s_Notes
        {
            get { return fs_Notes; }
            set { SetPropertyValue("s_Notes", ref fs_Notes, value); }
        }

        [Size(1)]
        public string s_IPType
        {
            get { return fs_IPType; }
            set { SetPropertyValue("s_IPType", ref fs_IPType, value); }
        }

        [Aggregated, Association("CodeCaseProcess_Item", typeof (CodeCaseProcessItem))]
        public XPCollection CodeCaseProcessItems
        {
            get { return GetCollection("CodeCaseProcessItems"); }
        }
        //[Aggregated, Association("CodeCaseProcess-CodeTaskChainInCodeCaseProcess")]
        //public XPCollection<OldTFCodeTaskChainInCodeCaseProcess> CodeTaskChainInCodeCaseProcess
        //{
        //    get { return GetCollection<OldTFCodeTaskChainInCodeCaseProcess>("CodeTaskChainInCodeCaseProcess"); }
        //}
        //[Aggregated, Association("CodeCaseProcess-CodeTaskInChainInCodeCaseProcess")]
        //public XPCollection<OldTFCodeTaskFlowInCodeProcess> CodeTaskInChainInCodeCaseProcess
        //{
        //    get { return GetCollection<OldTFCodeTaskFlowInCodeProcess>("CodeTaskInChainInCodeCaseProcess"); }
        //}
        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}
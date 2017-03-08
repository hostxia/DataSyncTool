using DevExpress.Xpo;

namespace DataEntities.Config
{
    [Persistent("TCode_FlowNoRule")]
    public class CodeFlowNoRule : XPLiteObject
    {
        private int fn_FlowNoCount;
        private int fn_ID;
        private int fn_MaxNo;
        private string fs_FlowNoRelate1;
        private string fs_FlowNoRelate2;
        private string fs_FlowNoRule;
        private string fs_FlowNoType;

        private string fs_MasterType;
        private string fs_ResetEachYear;
        private string fs_OneTrademarkOneFlow;

        public CodeFlowNoRule(Session session) : base(session)
        {
        }

        public CodeFlowNoRule() : base(Session.DefaultSession)
        {
        }

        [Key(true)]
        public int n_ID
        {
            get { return fn_ID; }
            set { SetPropertyValue<int>("n_ID", ref fn_ID, value); }
        }

        [Size(1)]
        public string s_IPType
        {
            get { return fs_MasterType; }
            set { SetPropertyValue("s_IPType", ref fs_MasterType, value); }
        }

        [Size(50)]
        public string s_FlowNoRelate1
        {
            get { return fs_FlowNoRelate1; }
            set { SetPropertyValue("s_FlowNoRelate1", ref fs_FlowNoRelate1, value); }
        }

        [Size(50)]
        public string s_FlowNoRelate2
        {
            get { return fs_FlowNoRelate2; }
            set { SetPropertyValue("s_FlowNoRelate2", ref fs_FlowNoRelate2, value); }
        }

        [Size(1)]
        public string s_FlowNoRule
        {
            get { return fs_FlowNoRule; }
            set { SetPropertyValue("s_FlowNoRule", ref fs_FlowNoRule, value); }
        }

        [Size(200)]
        public string s_FlowNoType
        {
            get { return fs_FlowNoType; }
            set { SetPropertyValue("s_FlowNoType", ref fs_FlowNoType, value); }
        }

        public int n_MaxNo
        {
            get { return fn_MaxNo; }
            set { SetPropertyValue<int>("n_MaxNo", ref fn_MaxNo, value); }
        }

        [Size(1)]
        public string s_ResetEachYear
        {
            get { return fs_ResetEachYear; }
            set { SetPropertyValue("s_ResetEachYear", ref fs_ResetEachYear, value); }
        }

        public int n_FlowNoCount
        {
            get { return fn_FlowNoCount; }
            set { SetPropertyValue<int>("n_FlowNoCount", ref fn_FlowNoCount, value); }
        }

        [Size(1)]
        public string s_OneTrademarkOneFlow
        {
            get { return fs_OneTrademarkOneFlow; }
            set { SetPropertyValue("s_OneTrademarkOneFlow", ref fs_OneTrademarkOneFlow, value); }
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}
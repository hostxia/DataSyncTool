using DevExpress.Xpo;

namespace DataEntities.Config
{
    [Persistent("TCode_TrademarkClassRule")]
    public class CodeTrademarkClassRule : XPLiteObject
    {
        private int fn_ID;
        private int fn_ClassMaxCount;
        private string fs_Split;
        private string fs_UnDisplayFlag;

        [Key(true)]
        public int n_ID
        {
            get { return fn_ID; }
            set { SetPropertyValue<int>("n_ID", ref fn_ID, value); }
        }

        public int n_ClassMaxCount
        {
            get { return fn_ClassMaxCount; }
            set { SetPropertyValue<int>("n_ClassMaxCount", ref fn_ClassMaxCount, value); }
        }

        [Size(1)]
        public string s_Split
        {
            get { return fs_Split; }
            set { SetPropertyValue("s_Split", ref fs_Split, value); }
        }

        [Size(10)]
        public string s_UnDisplayFlag
        {
            get { return fs_UnDisplayFlag; }
            set { SetPropertyValue("s_UnDisplayFlag", ref fs_UnDisplayFlag, value); }
        }

        public CodeTrademarkClassRule(Session session)
            : base(session)
        {
        }

        public CodeTrademarkClassRule()
            : base(Session.DefaultSession)
        {
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}
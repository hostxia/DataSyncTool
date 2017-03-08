using DevExpress.Xpo;

namespace DataEntities.Element.Files
{
    [MapInheritance(MapInheritanceType.OwnTable)]
    [Persistent("T_SubmitList")]
    public class TrademarkSubmitList : OutFile
    {
        private decimal fn_CurrBalance;
        private int fn_FlowNum;
        private int fn_SubmiterID;
        private int fn_WriterID;
        private string fs_IsRegOnline;
        private string fs_ListClass;
        private string fs_ListSerial;
        private string fs_ReceiveFilePathName;

        public TrademarkSubmitList(Session session) : base(session)
        {
        }

        public TrademarkSubmitList() : base(Session.DefaultSession)
        {
        }

        [Size(20)]
        public string s_ListSerial
        {
            get { return fs_ListSerial; }
            set { SetPropertyValue("s_ListSerial", ref fs_ListSerial, value); }
        }

        public int n_FlowNum
        {
            get { return fn_FlowNum; }
            set { SetPropertyValue<int>("n_FlowNum", ref fn_FlowNum, value); }
        }

        [Size(1)]
        public string s_ListClass
        {
            get { return fs_ListClass; }
            set { SetPropertyValue("s_ListClass", ref fs_ListClass, value); }
        }

        [Size(1)]
        public string s_IsRegOnline
        {
            get { return fs_IsRegOnline; }
            set { SetPropertyValue("s_IsRegOnline", ref fs_IsRegOnline, value); }
        }

        public decimal n_CurrBalance
        {
            get { return fn_CurrBalance; }
            set { SetPropertyValue<decimal>("n_CurrBalance", ref fn_CurrBalance, value); }
        }

        public int n_WriterID
        {
            get { return fn_WriterID; }
            set { SetPropertyValue<int>("n_WriterID", ref fn_WriterID, value); }
        }

        public int n_SubmiterID
        {
            get { return fn_SubmiterID; }
            set { SetPropertyValue<int>("n_SubmiterID", ref fn_SubmiterID, value); }
        }

        [Size(500)]
        public string s_ReceiveFilePathName
        {
            get { return fs_ReceiveFilePathName; }
            set { SetPropertyValue("s_ReceiveFilePathName", ref fs_ReceiveFilePathName, value); }
        }

        [Aggregated, Association("List-SubmitListInFile", typeof (SubmitListInFile))]
        public XPCollection SubmitListInFiles
        {
            get { return GetCollection("SubmitListInFiles"); }
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}
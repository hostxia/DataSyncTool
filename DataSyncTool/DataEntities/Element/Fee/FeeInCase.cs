using DataEntities.Case;
using DevExpress.Xpo;

namespace DataEntities.Element.Fee
{
    [Persistent("T_FeeInCase")]
    public class FeeInCase : XPLiteObject
    {
        private BasicCase basicCase;
        private Fee fee;
        private int fn_ID;
        private int fn_AnnualFeeID;
        private string fs_IsMainCase;
        private Process process;

        public FeeInCase(Session session) : base(session)
        {
        }

        public FeeInCase() : base(Session.DefaultSession)
        {
        }

        [Key(true)]
        public int n_ID
        {
            get { return fn_ID; }
            set { SetPropertyValue<int>("n_ID", ref fn_ID, value); }
        }

        public int n_AnnualFeeID
        {
            get { return fn_AnnualFeeID; }
            set { SetPropertyValue<int>("n_AnnualFeeID", ref fn_AnnualFeeID, value); }
        }
        

        //int fn_FeeID;
        //public int n_FeeID
        //{
        //    get { return fn_FeeID; }
        //    set { SetPropertyValue<int>("n_FeeID", ref fn_FeeID, value); }
        //}

        [Persistent("n_FeeID")]
        [Association("Fee-FeeInCases")]
        public Fee TheFee
        {
            get { return fee; }
            set { SetPropertyValue("n_FeeID", ref fee, value); }
        }

        //int fn_CaseID;
        //public int n_CaseID
        //{
        //    get { return fn_CaseID; }
        //    set { SetPropertyValue<int>("n_CaseID", ref fn_CaseID, value); }
        //}
        //int fn_ProcessID;
        //public int n_ProcessID
        //{
        //    get { return fn_ProcessID; }
        //    set { SetPropertyValue<int>("n_ProcessID", ref fn_ProcessID, value); }
        //}

        [Persistent("n_CaseID")]
        [Association("Case-FeeInCases")]
        public BasicCase TheCase
        {
            get { return basicCase; }
            set { SetPropertyValue("n_CaseID", ref basicCase, value); }
        }

        [Persistent("n_ProcessID")]
        [Association("Process-FeeInCases")]
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

        //此字段只是用于PA导入数据
        [NonPersistent]
        public string PA_FeeID { get; set; }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}
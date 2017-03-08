using DataEntities.Case;
using DevExpress.Data.Filtering;
using DevExpress.Xpo;

namespace DataEntities.Element.Fee
{
    [Persistent("T_AbroadBillList")]
    public class AbroadBillList : XPLiteObject
    {
        private BasicCase _case;
        private AbroadBill abroadBill;
        private decimal fn_AFee;
        private decimal fn_Fee;
        private int fn_ID;
        private decimal fn_TFee;
        private string fs_FeeName;
        private string fs_PayMark;
    
        public AbroadBillList()
        {
        }

        public AbroadBillList(Session session) : base(session)
        {
        }

        [Key(true)]
        public int n_ID
        {
            get { return fn_ID; }
            set { SetPropertyValue<int>("n_ID", ref fn_ID, value); }
        }

        //int fn_BillID;
        //public int n_BillID
        //{
        //    get { return fn_BillID; }
        //    set { SetPropertyValue<int>("n_BillID", ref fn_BillID, value); }
        //}

        [Persistent("n_BillID"), Association("AbroadBill-AbroadBillList")]
        public AbroadBill TheAbroadBill
        {
            get { return abroadBill; }
            set { SetPropertyValue("n_BillID", ref abroadBill, value); }
        }

        //int fn_CaseID;
        //public int n_CaseID
        //{
        //    get { return fn_CaseID; }
        //    set { SetPropertyValue<int>("n_CaseID", ref fn_CaseID, value); }
        //}

        [Persistent("n_CaseID"), Association("BasicCase-AbroadBillLists")]
        public BasicCase TheCase
        {
            get { return _case; }
            set { SetPropertyValue("n_CaseID", ref _case, value); }
        }

        [Size(100)]
        public string s_FeeName
        {
            get { return fs_FeeName; }
            set { SetPropertyValue("s_FeeName", ref fs_FeeName, value); }
        }

        public decimal n_Fee
        {
            get { return fn_Fee; }
            set { SetPropertyValue<decimal>("n_Fee", ref fn_Fee, value); }
        }

        public decimal n_AFee
        {
            get { return fn_AFee; }
            set { SetPropertyValue<decimal>("n_AFee", ref fn_AFee, value); }
        }

        public decimal n_TFee
        {
            get { return fn_TFee; }
            set { SetPropertyValue<decimal>("n_TFee", ref fn_TFee, value); }
        }

        [Size(1)]
        public string s_PayMark
        {
            get { return fs_PayMark; }
            set { SetPropertyValue("s_PayMark", ref fs_PayMark, value); }
        }

        public string IsHasFeeMark
        {

            get
            {
                var tempUow = new UnitOfWork();
                var fee =
                    tempUow.FindObject<Fee>(CriteriaOperator.Parse("n_FBillListID = ? ", n_ID));
                if (fee == null) return "";
                else
                return fee.FeeReceivedStatus;
            }
        }
         [Size(1)]
        public string s_IsHasFeeStatus
        {
            get {
                var tempUow = new UnitOfWork();
                var fee =
                    tempUow.FindObject<Fee>(CriteriaOperator.Parse("n_FBillListID = ? ", n_ID));
                if (fee == null) return "";
                else
                 return    fee.s_FeeReceivedStatus;
            
            }
           
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}
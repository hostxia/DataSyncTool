using System;
using DataEntities.Finance.Bill;
using DevExpress.Xpo;

namespace DataEntities.Element.Fee
{
    [Persistent("T_Payment")]
    public class Payment : XPLiteObject
    {
        private ABillHedge aBillHedge;
        private Bill bill;
        private DateTime fdt_EditTime;
        private DateTime fdt_PaymentDate;
        private decimal fn_PaymentAmount;
        private int fn_PaymentID;
        private int fn_PaymentUserID;
        private string fs_Editor;

        public Payment(Session session) : base(session)
        {
        }

        public Payment() : base(Session.DefaultSession)
        {
        }

        [Key(true)]
        public int n_PaymentID
        {
            get { return fn_PaymentID; }
            set { SetPropertyValue<int>("n_PaymentID", ref fn_PaymentID, value); }
        }

        //private BillList billList;
        //[Persistent("n_BillListID"), Association("BillList-Payment")]
        //public BillList TheBillList
        //{
        //    get { return billList; }
        //    set { SetPropertyValue<BillList>("n_BillListID", ref billList, value); }
        //}

        [Persistent("n_BillID"), Association("Bill-Payment")]
        public Bill TheBill
        {
            get { return bill; }
            set { SetPropertyValue("n_BillID", ref bill, value); }
        }

        //int fn_ReceiveID;
        //public int n_ReceiveID
        //{
        //    get { return fn_ReceiveID; }
        //    set { SetPropertyValue<int>("n_ReceiveID", ref fn_ReceiveID, value); }
        //}

        //private CameMoney cameMoney;
        //[Persistent("n_ReceiveID"), Association("CameMoney-Payment")]
        //public CameMoney TheCameMoney
        //{
        //    get { return cameMoney; }
        //    set { SetPropertyValue<CameMoney>("n_ReceiveID", ref cameMoney, value); }
        //}
        //int fn_HedgeID;
        //public int n_HedgeID
        //{
        //    get { return fn_HedgeID; }
        //    set { SetPropertyValue<int>("n_HedgeID", ref fn_HedgeID, value); }
        //}

        [Persistent("n_HedgeID"), Association("ABillHedge-Payment")]
        public ABillHedge TheABillHedge
        {
            get { return aBillHedge; }
            set { SetPropertyValue("n_HedgeID", ref aBillHedge, value); }
        }

        public decimal n_PaymentAmount
        {
            get { return fn_PaymentAmount; }
            set { SetPropertyValue<decimal>("n_PaymentAmount", ref fn_PaymentAmount, value); }
        }

        public DateTime dt_PaymentDate
        {
            get { return fdt_PaymentDate; }
            set { SetPropertyValue<DateTime>("dt_PaymentDate", ref fdt_PaymentDate, value); }
        }

        public int n_PaymentUserID
        {
            get { return fn_PaymentUserID; }
            set { SetPropertyValue<int>("n_PaymentUserID", ref fn_PaymentUserID, value); }
        }

        [Size(20)]
        public string s_Editor
        {
            get { return fs_Editor; }
            set { SetPropertyValue("s_Editor", ref fs_Editor, value); }
        }

        public DateTime dt_EditTime
        {
            get { return fdt_EditTime; }
            set { SetPropertyValue<DateTime>("dt_EditTime", ref fdt_EditTime, value); }
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}
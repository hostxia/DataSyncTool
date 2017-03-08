using System;
using DataEntities.Finance.Bill;
using DevExpress.Xpo;

namespace DataEntities.Finance.Accounting
{
    [Persistent("T_BillListPay")]
    public class BillListPay : XPLiteObject
    {
        private BillList billList;
        private BillPay billPay;
        private DateTime fdt_EditTime;
        private DateTime fdt_PaymentDate;
        private int fn_BillListPayID;
        private decimal fn_PaymentAmount;
        private decimal fn_OFee;
        private decimal fn_AttrFee;
        private decimal fn_OrginalAttrFee;
        private decimal fn_OtherFee;
        private int fn_PaymentUserID;
        private string fs_Editor;

        public BillListPay(Session session)
            : base(session)
        {
        }

        public BillListPay()
            : base(Session.DefaultSession)
        {
        }

        [Key(true)]
        public int n_BillListPayID
        {
            get { return fn_BillListPayID; }
            set { SetPropertyValue<int>("n_BillListPayID", ref fn_BillListPayID, value); }
        }

        [Persistent("n_BillPayID")]
        [Association("BillPay-BillListPay")]
        public BillPay TheBillPay
        {
            get { return billPay; }
            set { SetPropertyValue("n_BillPayID", ref billPay, value); }
        }

        [Persistent("n_BillListID"), Association("BillList-BillListPay")]
        public BillList TheBillList
        {
            get { return billList; }
            set { SetPropertyValue("n_BillListID", ref billList, value); }
        }

        public decimal n_PaymentAmount
        {
            get { return fn_PaymentAmount; }
            set { SetPropertyValue<decimal>("n_PaymentAmount", ref fn_PaymentAmount, value); }
        }

        public decimal n_OFee
        {
            get { return fn_OFee; }
            set { SetPropertyValue<decimal>("n_OFee", ref fn_OFee, value); }
        }

        public decimal n_AttrFee
        {
            get { return fn_AttrFee; }
            set { SetPropertyValue<decimal>("n_AttrFee", ref fn_AttrFee, value); }
        }

        public decimal n_OtherFee
        {
            get { return fn_OtherFee; }
            set { SetPropertyValue<decimal>("n_OtherFee", ref fn_OtherFee, value); }
        }

        public decimal n_OrginalAttrFee
        {
            get { return fn_OrginalAttrFee; }
            set { SetPropertyValue<decimal>("n_OrginalAttrFee", ref fn_OrginalAttrFee, value); }
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
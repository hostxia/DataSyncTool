using System;
using DevExpress.Xpo;

namespace DataEntities.Finance.Bill
{
    [Persistent("T_BillRemindHistory")]
    public class BillRemindHistory : XPLiteObject
    {
        private Bill bill;

        //int fn_BillID;
        //public int n_BillID
        //{
        //    get { return fn_BillID; }
        //    set { SetPropertyValue<int>("n_BillID", ref fn_BillID, value); }
        //}
        private DateTime fdt_RemindTime;
        private int fn_ID;

        public BillRemindHistory(Session session) : base(session)
        {
        }

        public BillRemindHistory() : base(Session.DefaultSession)
        {
        }

        [Key(true)]
        public int n_ID
        {
            get { return fn_ID; }
            set { SetPropertyValue<int>("n_ID", ref fn_ID, value); }
        }

        [Persistent("n_BillID"), Association("Bill-BillRemindHistory")]
        public Bill TheBill
        {
            get { return bill; }
            set { SetPropertyValue("n_BillID", ref bill, value); }
        }

        public DateTime dt_RemindTime
        {
            get { return fdt_RemindTime; }
            set { SetPropertyValue<DateTime>("dt_RemindTime", ref fdt_RemindTime, value); }
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}
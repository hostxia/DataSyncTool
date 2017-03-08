using System;
using System.Linq;
using DataEntities.Contact.Agency;
using DataEntities.Contact.Client;
using DevExpress.Xpo;

namespace DataEntities.Element.Fee
{
    [Persistent("T_ABillHedge")]
    public class ABillHedge : XPLiteObject
    {
        private string _IsPutIntoWallet;
        private Agency _agency;
        private Client _client;
        private DateTime fdt_CreateDate;
        private DateTime fdt_EditDate;
        private DateTime fdt_EditTime;
        private DateTime fdt_Hedge;
        private decimal fn_Amount;
        private int fn_CurrencyID;
        private int fn_ID;
        private decimal fs_BalanceAmount;
        private string fs_Creator;
        private string fs_Editor;
        private string fs_HedgeNo;

        public ABillHedge(Session session) : base(session)
        {
        }

        public ABillHedge() : base(Session.DefaultSession)
        {
        }

        [Key(true)]
        public int n_ID
        {
            get { return fn_ID; }
            set { SetPropertyValue<int>("n_ID", ref fn_ID, value); }
        }

        [Persistent("n_AgencyID"), Association("Agency-ABillHedge")]
        public Agency TheAgency
        {
            get { return _agency; }
            set { SetPropertyValue("n_AgencyID", ref _agency, value); }
        }


        //int fn_AgencyID;
        //public int n_AgencyID
        //{
        //    get { return fn_AgencyID; }
        //    set { SetPropertyValue<int>("n_AgencyID", ref fn_AgencyID, value); }
        //}


        //private int fn_ClientID;
        //public int n_ClientID
        //{
        //    get { return fn_ClientID; }
        //    set { SetPropertyValue<int>("n_ClientID", ref fn_ClientID, value); }
        //}

        [Persistent("n_ClientID"), Association("Client-ABillHedge")]
        public Client TheClient
        {
            get { return _client; }
            set { SetPropertyValue("n_ClientID", ref _client, value); }
        }

        [Size(20)]
        public string s_HedgeNo
        {
            get { return fs_HedgeNo; }
            set { SetPropertyValue("s_HedgeNo", ref fs_HedgeNo, value); }
        }

        public DateTime dt_Hedge
        {
            get { return fdt_Hedge; }
            set { SetPropertyValue<DateTime>("dt_Hedge", ref fdt_Hedge, value); }
        }

        public decimal n_Amount
        {
            get { return fn_Amount; }
            set { SetPropertyValue<decimal>("n_Amount", ref fn_Amount, value); }
        }

        public int n_CurrencyID
        {
            get { return fn_CurrencyID; }
            set { SetPropertyValue<int>("n_CurrencyID", ref fn_CurrencyID, value); }
        }

        public decimal s_BalanceAmount
        {
            get { return fs_BalanceAmount; }
            set { SetPropertyValue<decimal>("s_BalanceAmount", ref fs_BalanceAmount, value); }
        }

        [Size(50)]
        public string s_Creator
        {
            get { return fs_Creator; }
            set { SetPropertyValue("s_Creator", ref fs_Creator, value); }
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

        [Size(1)]
        public string IsPutIntoWallet
        {
            get { return _IsPutIntoWallet; }
            set { SetPropertyValue("s_IsPutIntoWallet", ref _IsPutIntoWallet, value); }
        }

        public DateTime dt_CreateDate
        {
            get { return fdt_CreateDate; }
            set { SetPropertyValue<DateTime>("dt_CreateDate", ref fdt_CreateDate, value); }
        }

        public DateTime dt_EditDate
        {
            get { return fdt_EditDate; }
            set { SetPropertyValue<DateTime>("dt_EditDate", ref fdt_EditDate, value); }
        }

        [Association("ABillHedge-AbroadBills"), Delayed]
        public XPCollection<AbroadBill> AbroadBills
        {
            get { return GetCollection<AbroadBill>("AbroadBills"); }
        }

        [Aggregated, Association("ABillHedge-Payment")]
        public XPCollection<Payment> Payments
        {
            get { return GetCollection<Payment>("Payments"); }
        }

        [NonPersistent]
        public decimal BillTatal
        {
            get
            {
                return
                    Math.Round(Payments.Select(p => p.TheBill).Aggregate(Convert.ToDecimal(0), (x, y) => x + y.FeeSum),
                        2);
            }
        }

        [NonPersistent]
        public decimal AbroadBillTatal
        {
            get { return Math.Round(AbroadBills.Aggregate(Convert.ToDecimal(0), (x, y) => x + y.FeeSubTotal), 2); }
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}
using System.Linq;
using DataEntities.Contact.Client;
using DevExpress.Xpo;

namespace DataEntities.Finance.Accounting
{
    [Persistent("T_BillPay")]
    public class BillPay : XPLiteObject
    {
        private readonly XPDelayedProperty fn_PayCurrencyID = new XPDelayedProperty();
        private Bill.Bill bill;
        private CameMoney cameMoney;
        private Client client;
        private int fn_BillPayID;

        public BillPay(Session session)
            : base(session)
        {
        }

        public BillPay()
            : base(Session.DefaultSession)
        {
        }

        [Key(true)]
        public int n_BillPayID
        {
            get { return fn_BillPayID; }
            set { SetPropertyValue<int>("n_BillPayID", ref fn_BillPayID, value); }
        }

        [Persistent("n_CMoneyID")]
        [Association("CameMoney-BillPay")]
        public CameMoney TheCameMoney
        {
            get { return cameMoney; }
            set { SetPropertyValue("n_CMoneyID", ref cameMoney, value); }
        }

        [Persistent("n_ClientID")]
        [Association("Client-BillPay")]
        public Client TheClient
        {
            get { return client; }
            set { SetPropertyValue("n_ClientID", ref client, value); }
        }

        [Persistent("n_BillID"), Association("Bill-BillPay")]
        public Bill.Bill TheBill
        {
            get { return bill; }
            set { SetPropertyValue("n_BillID", ref bill, value); }
        }

        [Aggregated, Association("BillPay-BillListPay")]
        public XPCollection<BillListPay> BillListPayInfo
        {
            get { return GetCollection<BillListPay>("BillListPayInfo"); }
        }

        [Delayed("fn_PayCurrencyID")]
        public int n_PayCurrencyID
        {
            get
            {
                if (fn_PayCurrencyID.Value == null)
                {
                    return 0;
                }
                return (int)fn_PayCurrencyID.Value;
            }
            set { fn_PayCurrencyID.Value = value; }
        }

        public decimal n_PayAmount
        {
            get
            {
                decimal n_TotalPayAmount = 0;
                if (BillListPayInfo.Count > 0)
                {
                    foreach (BillListPay billListPay in BillListPayInfo)
                    {
                        n_TotalPayAmount += billListPay.n_PaymentAmount;
                    }
                }
                return n_TotalPayAmount;
            }
        }
        [NonPersistent]
        public decimal n_PayOFeeAmount//账单明细官费总和
        {
            get
            {
                decimal nTotalPayOFeeAmount = 0;
                if (BillListPayInfo.Count > 0)
                {
                    nTotalPayOFeeAmount += BillListPayInfo.Sum(billListPay => billListPay.n_OFee);
                }
                return nTotalPayOFeeAmount;
            }
        }
        [NonPersistent]
        public decimal n_PayAFeeAmount//账单明细代理费总和
        {
            get
            {
                decimal nTotalPayAFeeAmount = 0;
                if (BillListPayInfo.Count > 0)
                {
                    nTotalPayAFeeAmount += BillListPayInfo.Sum(billListPay => billListPay.n_AttrFee);
                }
                return nTotalPayAFeeAmount;
            }
        }
        [NonPersistent]
        public decimal n_PayOriAFeeAmount//账单明细原始代理费总和
        {
            get
            {
                decimal nTotalPayOriAFeeAmount = 0;
                if (BillListPayInfo.Count > 0)
                {
                    nTotalPayOriAFeeAmount += BillListPayInfo.Sum(billListPay => billListPay.n_OrginalAttrFee);
                }
                return nTotalPayOriAFeeAmount;
            }
        }
        [NonPersistent]
        public decimal n_PayOtherFeeAmount//账单明细原始其他费总和
        {
            get
            {
                decimal nTotalPayOtherFeeAmount = 0;
                if (BillListPayInfo.Count > 0)
                {
                    nTotalPayOtherFeeAmount += BillListPayInfo.Sum(billListPay => billListPay.n_OtherFee);
                }
                return nTotalPayOtherFeeAmount;
            }
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}
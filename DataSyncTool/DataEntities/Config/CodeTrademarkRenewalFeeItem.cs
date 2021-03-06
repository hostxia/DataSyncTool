using DevExpress.Xpo;

namespace DataEntities.Config
{
    [Persistent("TCode_TRenewalFeeItem")]
    public class CodeTrademarkRenewalFeeItem : XPLiteObject
    {
        private CodeTrademarkRenewalFee fTrademarkRenewalFee;
        private decimal fn_ChargeAFee;
        private int fn_ChargeCurrency;
        private decimal fn_ChargeOFee;
        private decimal fn_ChargeUnitFee;
        private int fn_ID;

        public CodeTrademarkRenewalFeeItem(Session session) : base(session)
        {
        }

        public CodeTrademarkRenewalFeeItem() : base(Session.DefaultSession)
        {
        }

        [Key(true)]
        public int n_ID
        {
            get { return fn_ID; }
            set { SetPropertyValue<int>("n_ID", ref fn_ID, value); }
        }

        [Persistent("n_TRenFeeCodeID")]
        [Association("TrademarkRenewalFeeItems")]
        public CodeTrademarkRenewalFee TrademarkRenewalFee
        {
            get { return fTrademarkRenewalFee; }
            set { SetPropertyValue("n_TRenFeeCodeID", ref fTrademarkRenewalFee, value); }
        }

        public int n_ChargeCurrency
        {
            get { return fn_ChargeCurrency; }
            set { SetPropertyValue<int>("n_ChargeCurrency", ref fn_ChargeCurrency, value); }
        }

        public decimal n_ChargeOFee
        {
            get { return fn_ChargeOFee; }
            set { SetPropertyValue<decimal>("n_ChargeOFee", ref fn_ChargeOFee, value); }
        }

        public decimal n_ChargeUnitFee
        {
            get { return fn_ChargeUnitFee; }
            set { SetPropertyValue<decimal>("n_ChargeUnitFee", ref fn_ChargeUnitFee, value); }
        }

        public decimal n_ChargeAFee
        {
            get { return fn_ChargeAFee; }
            set { SetPropertyValue<decimal>("n_ChargeAFee", ref fn_ChargeAFee, value); }
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}
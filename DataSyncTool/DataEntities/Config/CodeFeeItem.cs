using DevExpress.Xpo;

namespace DataEntities.Config
{
    [Persistent("TCode_FeeItem")]
    public class CodeFeeItem : XPLiteObject
    {
        private CodeFee codeFee;
        private decimal fn_ChargeAFee;
        private int fn_ChargeCurrency;
        private decimal fn_ChargeOFee;
        private decimal fn_ChargeUnitFee;
        private decimal fn_AgencyUnitFee;
        private int fn_ID;
        private decimal fn_OtherFee;

        public CodeFeeItem(Session session) : base(session)
        {
        }

        public CodeFeeItem() : base(Session.DefaultSession)
        {
        }

        [Key(true)]
        public int n_ID
        {
            get { return fn_ID; }
            set { SetPropertyValue<int>("n_ID", ref fn_ID, value); }
        }

        [Persistent("n_FeeCodeID"),Association("FeeItems")]
        public CodeFee CodeFee
        {
            get { return codeFee; }
            set { SetPropertyValue("n_FeeCodeID", ref codeFee, value); }
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

        /// <summary>
        ///     �������֣�ÿ��λ�շѶ���
        /// </summary>
        public decimal n_ChargeUnitFee
        {
            get { return fn_ChargeUnitFee; }
            set { SetPropertyValue<decimal>("n_ChargeUnitFee", ref fn_ChargeUnitFee, value); }
        }
        /// <summary>
        ///     �������֣�ÿ��λ�շѶ���
        /// </summary>
        public decimal n_AgencyUnitFee
        {
            get { return fn_AgencyUnitFee; }
            set { SetPropertyValue<decimal>("n_AgencyUnitFee", ref fn_AgencyUnitFee, value); }
        }
        public decimal n_ChargeAFee
        {
            get { return fn_ChargeAFee; }
            set { SetPropertyValue<decimal>("n_ChargeAFee", ref fn_ChargeAFee, value); }
        }

        public decimal n_OtherFee
        {
            get { return fn_OtherFee; }
            set { SetPropertyValue<decimal>("n_OtherFee", ref fn_OtherFee, value); }
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}
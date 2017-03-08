using System;
using DataEntities.Properties;
using DevExpress.Xpo;

namespace DataEntities.Contact.Client
{
    [Persistent("TCstmr_ClientFeePolicy")]
    public class ClientFeePolicy : XPLiteObject
    {
        private Client TCstmrClient;
        private DateTime fdt_EditDate;
        private int fn_ChargeCurrency;
        private int fn_ID;
        private decimal fn_Value;
        private string fs_BusinessType;
       // private string fs_FeeMode;
        private string fs_IPType;
        private string fs_Note;
        private string fs_PTCType;

        public ClientFeePolicy(Session session) : base(session)
        {
        }

        public ClientFeePolicy() : base(Session.DefaultSession)
        {
        }

        [Key(true)]
        public int n_ID
        {
            get { return fn_ID; }
            set { SetPropertyValue<int>("n_ID", ref fn_ID, value); }
        }

        [Association("ClientFeePolicy")]
        [Persistent("n_ClientID")]
        public Client tCstmrClient
        {
            get { return TCstmrClient; }
            set { SetPropertyValue("n_ClientID", ref TCstmrClient, value); }
        }

        //private DataEntities.Contact.Applicant.Applicant TCstmrApplicant;
        //[Association("ApplicantFeePolicy")]
        //[Persistent("n_AppID")]
        //public DataEntities.Contact.Applicant.Applicant tCstmrApplicant
        //{
        //    get { return TCstmrApplicant; }
        //    set { SetPropertyValue("n_AppID", ref TCstmrApplicant, value); }
        //}

        public int n_ChargeCurrency
        {
            get { return fn_ChargeCurrency; }
            set { SetPropertyValue<int>("n_ChargeCurrency", ref fn_ChargeCurrency, value); }
        }

        [Size(50)]
        public string s_IPType
        {
            get { return fs_IPType; }
            set { SetPropertyValue("s_IPType", ref fs_IPType, value); }
        }

        //[Size(1)]
        //public string s_FeeMode
        //{
        //    get { return fs_FeeMode; }
        //    set { SetPropertyValue("s_FeeMode", ref fs_FeeMode, value); }
        //}

        public decimal n_Value
        {
            get { return fn_Value; }
            set { SetPropertyValue<decimal>("n_Value", ref fn_Value, value); }
        }

        [Size(300)]
        public string s_Note
        {
            get { return fs_Note; }
            set { SetPropertyValue("s_Note", ref fs_Note, value); }
        }

        public DateTime dt_EditDate
        {
            get { return fdt_EditDate; }
            set { SetPropertyValue<DateTime>("dt_EditDate", ref fdt_EditDate, value); }
        }

        //public string FeeModeAndValue
        //{
        //    get
        //    {
        //        switch (fs_FeeMode)
        //        {
        //            case "1":
        //                return string.Format(Resource.Agent_Fee_Discount, fn_Value);
        //            case "2":
        //                return string.Format(Resource.Fixed_AFee, fn_Value);
        //            case "3":
        //                return string.Format(Resource.Fixed_Total_Fee, fn_Value);
        //        }
        //        return string.Empty;
        //    }
        //}


        [Size(200)]
        public string s_BusinessType
        {
            get { return fs_BusinessType; }
            set { SetPropertyValue("s_BusinessType", ref fs_BusinessType, value); }
        }

        [Size(50)]
        public string s_PTCType
        {
            get { return fs_PTCType; }
            set { SetPropertyValue("s_PTCType", ref fs_PTCType, value); }
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}
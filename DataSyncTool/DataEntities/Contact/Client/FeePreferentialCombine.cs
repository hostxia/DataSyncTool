using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.Xpo;

namespace DataEntities.Contact.Client
{
    [Persistent("TCstmr_FeePreferentialCombine")]
    public class FeePreferentialCombine : XPLiteObject
    {
        private int fn_ID;
        [Key(true)]
        public int n_ID
        {
            get { return fn_ID; }
            set { SetPropertyValue<int>("n_ID", ref fn_ID, value); }
        }

        private Client TCstmrClient;
        [Association("ClientFeeCombine")]
        [Persistent("n_ClientID")]
        public Client tCstmrClient
        {
            get { return TCstmrClient; }
            set { SetPropertyValue("n_ClientID", ref TCstmrClient, value); }
        }

        private DataEntities.Contact.Applicant.Applicant TCstmrApplicant;
        [Association("ApplicantFeeCombine")]
        [Persistent("n_AppID")]
        public DataEntities.Contact.Applicant.Applicant tCstmrApplicant
        {
            get { return TCstmrApplicant; }
            set { SetPropertyValue("n_AppID", ref TCstmrApplicant, value); }
        }

        //private int fn_AppID;
        //public int n_AppID
        //{
        //    get { return fn_AppID; }
        //    set { SetPropertyValue<int>("n_AppID", ref fn_AppID, value); }
        //}

        //private int fn_ClientID;
        //public int n_ClientID
        //{
        //    get { return fn_ClientID; }
        //    set { SetPropertyValue<int>("n_ClientID", ref fn_ClientID, value); }
        //}

        private string fs_IPType;
        [Size(50)]
        public string s_IPType
        {
            get { return fs_IPType; }
            set { SetPropertyValue("s_IPType", ref fs_IPType, value); }
        }


        private int fn_CombineID;
        public int n_CombineID
        {
            get { return fn_CombineID; }
            set { SetPropertyValue<int>("n_CombineID", ref fn_CombineID, value); }
        }

        public FeePreferentialCombine(Session session)
            : base(session)
        {
        }

        public FeePreferentialCombine()
            : base(Session.DefaultSession)
        {
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}
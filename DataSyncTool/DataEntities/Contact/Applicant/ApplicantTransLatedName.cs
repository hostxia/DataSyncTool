using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.Xpo;

namespace DataEntities.Contact.Applicant
{
    [Persistent("TCstmr_AppTransLatedName")]
    public class ApplicantTransLatedName : XPLiteObject
    {
        private int fn_ID;
        private string fs_AppTransLatedName;
        private string fs_TrustdeedNum;
        private string fs_AppTransLatedNameUse;
        private Applicant TCstmrApplicant;
        public ApplicantTransLatedName(Session session)
            : base(session)
        {
        }

        public ApplicantTransLatedName()
            : base(Session.DefaultSession)
        {
        }
        [Key(true)]
        public int n_ID
        {
            get { return fn_ID; }
            set { SetPropertyValue<int>("n_ID", ref fn_ID, value); }
        }
        
        public string s_AppTransLatedName
        {
            get { return fs_AppTransLatedName; }
            set { SetPropertyValue<string>("s_AppTransLatedName", ref fs_AppTransLatedName, value); }
        }

        public string s_TrustdeedNum
        {
            get { return fs_TrustdeedNum; }
            set { SetPropertyValue<string>("s_TrustdeedNum", ref fs_TrustdeedNum, value); }
        }
        public string s_AppTransLatedNameUse
        {
            get { return fs_AppTransLatedNameUse; }
            set { SetPropertyValue<string>("s_AppTransLatedNameUse", ref fs_AppTransLatedNameUse, value); }
        }
        [Association("AppTransLatedName")]
        [Persistent("n_AppID")]
        public Applicant tCstmrApplicant
        {
            get { return TCstmrApplicant; }
            set { SetPropertyValue("n_AppID", ref TCstmrApplicant, value); }
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}

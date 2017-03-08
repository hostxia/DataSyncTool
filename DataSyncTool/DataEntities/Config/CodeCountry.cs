using System;
using DataEntities.Properties;
using DevExpress.Xpo;

namespace DataEntities.Config
{
    [Persistent("TCode_Country")]
    public class CodeCountry : XPLiteObject
    {
        private DateTime fdt_CreateDate;
        private DateTime fdt_EditDate;
        private int fn_FrequentNo;
        private int fn_ID;

        private string fs_CountryCode;
        private string fs_MadridAgreement;
        private string fs_MadridProtocol;
        private string fs_MultiClass;

        private string fs_Name;

        private string fs_OtherName;
        private string fs_PCTContract;

        public CodeCountry(Session session) : base(session)
        {
        }

        public CodeCountry() : base(Session.DefaultSession)
        {
        }

        [Key(true)]
        public int n_ID
        {
            get { return fn_ID; }
            set { SetPropertyValue<int>("n_ID", ref fn_ID, value); }
        }

        [Size(5)]
        public string s_CountryCode
        {
            get { return fs_CountryCode; }
            set { SetPropertyValue("s_CountryCode", ref fs_CountryCode, value); }
        }

        public string s_Name
        {
            get { return fs_Name; }
            set { SetPropertyValue("s_Name", ref fs_Name, value); }
        }

        public string s_OtherName
        {
            get { return fs_OtherName; }
            set { SetPropertyValue("s_OtherName", ref fs_OtherName, value); }
        }

        [Size(1)]
        public string s_MadridAgreement
        {
            get { return fs_MadridAgreement; }
            set { SetPropertyValue("s_MadridAgreement", ref fs_MadridAgreement, value); }
        }

        [Size(1)]
        public string s_MadridProtocol
        {
            get { return fs_MadridProtocol; }
            set { SetPropertyValue("s_MadridProtocol", ref fs_MadridProtocol, value); }
        }

        [Size(1)]
        public string s_PCTContract
        {
            get { return fs_PCTContract; }
            set { SetPropertyValue("s_PCTContract", ref fs_PCTContract, value); }
        }

        [Size(1)]
        public string s_MultiClass
        {
            get { return fs_MultiClass; }
            set { SetPropertyValue("s_MultiClass", ref fs_MultiClass, value); }
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

        public string CountryType
        {
            get
            {
                string sValue = string.Empty;
                if (s_MadridAgreement == "Y")
                {
                    sValue = Resource.MadridAgreement;
                }
                if (s_MadridProtocol == "Y")
                {
                    sValue = sValue + "," + Resource.MadridProtocol;
                }
                if (sValue.StartsWith(","))
                {
                    sValue = sValue.Substring(1, sValue.Length - 1);
                }
                if (sValue.EndsWith(","))
                {
                    sValue = sValue.Substring(0, sValue.Length - 1);
                }
                return sValue;
            }
        }

        public int n_FrequentNo
        {
            get { return fn_FrequentNo; }
            set { SetPropertyValue<int>("n_FrequentNo", ref fn_FrequentNo, value); }
        }

        [Aggregated, Association("Country-State", typeof (CodeState))]
        public XPCollection States
        {
            get { return GetCollection("States"); }
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}
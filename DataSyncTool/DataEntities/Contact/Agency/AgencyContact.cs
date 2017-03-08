using System;
using System.Linq;
using DataEntities.Config;
using DataEntities.Properties;
using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using Infralution.Localization;

namespace DataEntities.Contact.Agency
{
    [Persistent("TCstmr_AgencyContact")]
    public class AgencyContact : XPLiteObject
    {
        private Agency TCstmrCoopAgency;
        private DateTime fdt_CreateDate;
        private DateTime fdt_EditDate;
        private int fn_ContactID;
        private int fn_Language;
        private int fn_Sequence;
        private string fs_Email;
        private string fs_Facebook;
        private string fs_Fax;
        private string fs_FirstName;
        private string fs_IMAddress;
        private string fs_IPType;
        private string fs_JobTitle;
        private string fs_LastName;
        private string fs_Mobile;
        private string fs_NativeName;
        private string fs_Notes;
        private string fs_OtherName;
        private string fs_Phone;
        private string fs_PreferContact;
        private string fs_Prefix;
        private string fs_Twitter;
        private string fs_Website;
        private string fs_Identity;

        public AgencyContact(Session session)
            : base(session)
        {
        }

        public AgencyContact()
            : base(Session.DefaultSession)
        {
        }

        [Key(true)]
        public int n_ContactID
        {
            get { return fn_ContactID; }
            set { SetPropertyValue<int>("n_ContactID", ref fn_ContactID, value); }
        }

        [Association("AgencyContact")]
        [Persistent("n_AgencyID")]
        public Agency tCstmrCoopAgency
        {
            get { return TCstmrCoopAgency; }
            set { SetPropertyValue("n_AgencyID", ref TCstmrCoopAgency, value); }
        }

        public string s_FirstName
        {
            get { return fs_FirstName; }
            set { SetPropertyValue("s_FirstName", ref fs_FirstName, value); }
        }

        public string s_LastName
        {
            get { return fs_LastName; }
            set { SetPropertyValue("s_LastName", ref fs_LastName, value); }
        }

        public int n_Sequence
        {
            get { return fn_Sequence; }
            set { SetPropertyValue<int>("n_Sequence", ref fn_Sequence, value); }
        }

        [Size(200)]
        public string s_NativeName
        {
            get { return fs_NativeName; }
            set { SetPropertyValue("s_NativeName", ref fs_NativeName, value); }
        }

        [Size(200)]
        public string s_OtherName
        {
            get { return fs_OtherName; }
            set { SetPropertyValue("s_OtherName", ref fs_OtherName, value); }
        }

        public int n_Language
        {
            get { return fn_Language; }

            set { SetPropertyValue<int>("n_Language", ref fn_Language, value); }
        }

        public string LauangeCName
        {
            get
            {
                using (var uow = new UnitOfWork())
                {
                    var xpc = new XPCollection(uow, typeof(CodeLanguage))
                    {
                        Criteria = CriteriaOperator.Parse("n_ID", n_Language)
                    };
                    if (xpc == null || xpc.Count == 0)
                    {
                        return "";
                    }
                    return ((CodeLanguage)xpc[0]).s_Name;
                }
            }
        }

        private string FullName
        {
            get { return fs_FirstName + " " + fs_LastName; }
        }

        private string CNFullName
        {
            get { return fs_LastName + fs_FirstName; }
        }

        public string ContactName
        {
            get
            {
                switch (CultureManager.ApplicationUICulture.Name)
                {
                    case "zh-CN":
                        return CNFullName;
                    case "en-US":
                        return FullName;
                    default:
                        return "";
                }
            }
        }

        public string IPRole
        {
            get
            {
                if (string.IsNullOrEmpty(s_IPType)) return string.Empty;
                string currentIpRole = string.Empty;
                foreach (char str in s_IPType)
                {
                    if (str == ',') continue;
                    switch (str)
                    {
                        case 'P':
                            currentIpRole = currentIpRole + "," + Resource.Patent;
                            continue;
                        case 'T':
                            currentIpRole = currentIpRole + "," + Resource.Trademark;
                            continue;
                        case 'D':
                            currentIpRole = currentIpRole + "," + Resource.Domain;
                            continue;
                        case 'C':
                            currentIpRole = currentIpRole + "," + Resource.Copyright;
                            continue;
                        case 'O':
                            currentIpRole = currentIpRole + "," + Resource.Other;
                            continue;
                        default:
                            continue;
                    }
                }
                if (currentIpRole.StartsWith(","))
                    currentIpRole = currentIpRole.Substring(1, currentIpRole.Length - 1);
                if (currentIpRole.EndsWith(","))
                    currentIpRole = currentIpRole.Substring(0, currentIpRole.Length - 1);
                return currentIpRole;
            }
        }

        [Size(50)]
        public string s_IPType
        {
            get { return fs_IPType; }
            set { SetPropertyValue("s_IPRole", ref fs_IPType, value); }
        }

        public string s_JobTitle
        {
            get { return fs_JobTitle; }
            set { SetPropertyValue("s_JobTitle", ref fs_JobTitle, value); }
        }

        [Size(50)]
        public string s_Identity
        {
            get { return fs_Identity; }
            set { SetPropertyValue("s_Identity", ref fs_Identity, value); }
        }

        [Size(30)]
        public string s_Prefix
        {
            get { return fs_Prefix; }
            set { SetPropertyValue("s_Prefix", ref fs_Prefix, value); }
        }

        public string s_Phone
        {
            get { return fs_Phone; }
            set { SetPropertyValue("s_Phone", ref fs_Phone, value); }
        }

        public string s_Mobile
        {
            get { return fs_Mobile; }
            set { SetPropertyValue("s_Mobile", ref fs_Mobile, value); }
        }

        public string s_Fax
        {
            get { return fs_Fax; }
            set { SetPropertyValue("s_Fax", ref fs_Fax, value); }
        }

        [Size(300)]
        public string s_Email
        {
            get { return fs_Email; }
            set { SetPropertyValue("s_Email", ref fs_Email, value); }
        }

        [Size(300)]
        public string s_Website
        {
            get { return fs_Website; }
            set { SetPropertyValue("s_Website", ref fs_Website, value); }
        }

        public string s_IMAddress
        {
            get { return fs_IMAddress; }
            set { SetPropertyValue("s_IMAddress", ref fs_IMAddress, value); }
        }

        [Size(200)]
        public string s_Facebook
        {
            get { return fs_Facebook; }
            set { SetPropertyValue("s_Facebook", ref fs_Facebook, value); }
        }

        [Size(200)]
        public string s_Twitter
        {
            get { return fs_Twitter; }
            set { SetPropertyValue("s_Twitter", ref fs_Twitter, value); }
        }

        [Size(10)]
        public string s_PreferContact
        {
            get { return fs_PreferContact; }
            set { SetPropertyValue("s_PreferContact", ref fs_PreferContact, value); }
        }

        [Size(800)]
        public string s_Notes
        {
            get { return fs_Notes; }
            set { SetPropertyValue("s_Notes", ref fs_Notes, value); }
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

        [Aggregated, Association("AgencyConAddress", typeof(AgencyContactAddress))]
        public XPCollection AgencyConAddress
        {
            get { return GetCollection("AgencyConAddress"); }
        }

        [NonPersistent]
        public int Sequence { get; set; }

        #region ����

        /// <summary>
        ///     ����
        /// </summary>
        public string sCountry
        {
            get
            {
                string sCountryName = "";
                foreach (
                    AgencyContactAddress address in
                        AgencyConAddress.Cast<AgencyContactAddress>()
                            .Where(address => address.s_Type != null && address.s_Type.ToUpper().IndexOf("O") >= 0))
                {
                    using (var uow = new UnitOfWork())
                    {
                        var xpc = new XPCollection(uow, typeof(CodeCountry))
                        {
                            Criteria = CriteriaOperator.Parse("n_ID =" + address.n_Country)
                        };
                        sCountryName = xpc.Count == 0 ? "" : ((CodeCountry)xpc[0]).s_OtherName;
                    }
                    break;
                }
                return sCountryName;
            }
        }

        /// <summary>
        ///     ��ȡ��ַ���ʱ�
        /// </summary>
        public string sZipCode
        {
            get
            {
                AgencyContactAddress agencyContactAddress =
                    AgencyConAddress.Cast<AgencyContactAddress>()
                        .FirstOrDefault(s => s.s_Type != null && s.s_Type.ToUpper().IndexOf("O") >= 0);
                return agencyContactAddress != null ? agencyContactAddress.s_ZipCode : string.Empty;
            }
        }

        public string Address1Type
        {
            get
            {
                if (AgencyConAddress.Count < 1) return string.Empty;
                return ((AgencyContactAddress)AgencyConAddress[0]).s_Type;
            }
        }

        public string Address1
        {
            get
            {
                if (AgencyConAddress.Count < 1) return string.Empty;
                return GetFullAddress((AgencyContactAddress)AgencyConAddress[0]);
            }
        }

        public string Address1EN
        {
            get
            {
                if (AgencyConAddress.Count < 1) return string.Empty;
                return GetFullAddress((AgencyContactAddress)AgencyConAddress[0], "en-US");
            }
        }

        public string Address1Street
        {
            get
            {
                if (AgencyConAddress.Count < 1) return string.Empty;
                return ((AgencyContactAddress)AgencyConAddress[0]).s_Street;
            }
        }

        public string Address1ZipCode
        {
            get
            {
                if (AgencyConAddress.Count < 1) return string.Empty;
                return ((AgencyContactAddress)AgencyConAddress[0]).s_ZipCode;
            }
        }

        public string Address2Type
        {
            get
            {
                if (AgencyConAddress.Count < 2) return string.Empty;
                return ((AgencyContactAddress)AgencyConAddress[1]).s_Type;
            }
        }

        public string Address2
        {
            get
            {
                if (AgencyConAddress.Count < 2) return string.Empty;
                return GetFullAddress((AgencyContactAddress)AgencyConAddress[1]);
            }
        }

        public string Address2EN
        {
            get
            {
                if (AgencyConAddress.Count < 2) return string.Empty;
                return GetFullAddress((AgencyContactAddress)AgencyConAddress[1], "en-US");
            }
        }

        public string Address2Street
        {
            get
            {
                if (AgencyConAddress.Count < 2) return string.Empty;
                return ((AgencyContactAddress)AgencyConAddress[1]).s_Street;
            }
        }

        public string Address2ZipCode
        {
            get
            {
                if (AgencyConAddress.Count < 2) return string.Empty;
                return ((AgencyContactAddress)AgencyConAddress[1]).s_ZipCode;
            }
        }

        public string Address3Type
        {
            get
            {
                if (AgencyConAddress.Count < 3) return string.Empty;
                return ((AgencyContactAddress)AgencyConAddress[2]).s_Type;
            }
        }

        public string Address3
        {
            get
            {
                if (AgencyConAddress.Count < 3) return string.Empty;
                return GetFullAddress((AgencyContactAddress)AgencyConAddress[2]);
            }
        }

        public string Address3EN
        {
            get
            {
                if (AgencyConAddress.Count < 3) return string.Empty;
                return GetFullAddress((AgencyContactAddress)AgencyConAddress[2], "en-US");
            }
        }

        public string Address3Street
        {
            get
            {
                if (AgencyConAddress.Count < 3) return string.Empty;
                return ((AgencyContactAddress)AgencyConAddress[2]).s_Street;
            }
        }

        public string Address3ZipCode
        {
            get
            {
                if (AgencyConAddress.Count < 3) return string.Empty;
                return ((AgencyContactAddress)AgencyConAddress[2]).s_ZipCode;
            }
        }

        public string GetFullAddress(AgencyContactAddress address, string sLanguage = "zh-CN")
        {
            switch (sLanguage)
            {
                case "zh-CN":
                    using (var tempUow = new UnitOfWork())
                    {
                        var country = tempUow.GetObjectByKey<CodeCountry>(address.n_Country);
                        return (country == null ? "" : country.s_Name) +
                               (string.IsNullOrEmpty(address.s_State) ? "" : address.s_State) +
                               (string.IsNullOrEmpty(address.s_City) ? "" : address.s_City) +
                               (string.IsNullOrEmpty(address.s_StreetAll) ? "" : address.s_StreetAll);
                    }
                case "en-US":
                    using (var tempUow = new UnitOfWork())
                    {
                        var sCountry = "";
                        var country = tempUow.GetObjectByKey<CodeCountry>(address.n_Country);
                        if (country != null) sCountry = string.IsNullOrEmpty(country.s_OtherName) ? country.s_Name : country.s_OtherName;
                        var sState = "";
                        CodeState state = null;
                        if (!string.IsNullOrEmpty(address.s_State))
                        {
                            if (country != null) state = country.States.Cast<CodeState>().FirstOrDefault(f => f.s_StateName == address.s_State);
                            sState = state == null ? address.s_State : (string.IsNullOrEmpty(state.s_OStateName) ? state.s_StateName : state.s_OStateName);
                        }
                        var sCity = "";
                        CodeCity city = null;
                        if (!string.IsNullOrEmpty(address.s_City))
                        {
                            if (state != null) city = state.Cities.Cast<CodeCity>().FirstOrDefault(f => f.s_CityName == address.s_City);
                            sCity = city == null ? address.s_City : (string.IsNullOrEmpty(city.s_OCityName) ? city.s_CityName : city.s_OCityName);
                        }
                        var sFullAddress = address.s_StreetAll;
                        if (!string.IsNullOrEmpty(sCity))
                        {
                            if (!string.IsNullOrEmpty(sFullAddress)) sFullAddress = sFullAddress + ", ";
                            sFullAddress = sFullAddress + sCity;
                        }
                        if (!string.IsNullOrEmpty(sState))
                        {
                            if (!string.IsNullOrEmpty(sFullAddress)) sFullAddress = sFullAddress + ", ";
                            sFullAddress = sFullAddress + sState;
                        }
                        if (!string.IsNullOrEmpty(sCountry))
                        {
                            if (!string.IsNullOrEmpty(sFullAddress)) sFullAddress = sFullAddress + ", ";
                            sFullAddress = sFullAddress + sCountry;
                        }
                        return sFullAddress;
                    }
                default:
                    return "";
            }
        }


        /// #################################################################
        /// <summary>
        ///     ��ȡӢ�İ칫��ַ��
        ///     Kevin Wang(2010-10-25)
        /// </summary>
        /// <returns>Ӣ�İ칫��ַ</returns>
        public string GetOfficeENAddress()
        {
            foreach (AgencyContactAddress appConAddress in AgencyConAddress)
            {
                if (appConAddress.s_Type == null || appConAddress.s_Type.IndexOf("E") < 0) continue;
                return appConAddress.s_Street + ", " + appConAddress.s_City + ", " + appConAddress.s_State;
            }
            return "";
        }

        /// #################################################################
        /// <summary>
        ///     ��ȡ���İ칫��ַ��
        ///     Kevin Wang(2010-10-25)
        /// </summary>
        /// <returns>���İ칫��ַ</returns>
        public string GetOfficeCNAddress()
        {
            foreach (AgencyContactAddress appConAddress in AgencyConAddress)
            {
                if (appConAddress.s_Type == null || appConAddress.s_Type.IndexOf("O") < 0) continue;
                return appConAddress.s_State + " " + appConAddress.s_City + " " + appConAddress.s_Street;
            }

            return "";
        }


        /// #################################################################
        /// <summary>
        ///     ��ȡ��ϵ�˹��� ������ϵ�˵�ͨ�ŵ�ַȥ��ȡ��
        ///     Kevin Wang(2010-08-30)
        /// </summary>
        /// <returns>��ϵ�˵Ĺ���</returns>
        public string GetCountryName()
        {
            string sCountryName = "";
            foreach (AgencyContactAddress address in AgencyConAddress)
            {
                if (address.s_Type != null && address.s_Type.ToUpper().IndexOf("O") >= 0)
                {
                    using (var uow = new UnitOfWork())
                    {
                        var xpc = new XPCollection(uow, typeof(CodeCountry))
                        {
                            Criteria = CriteriaOperator.Parse("n_ID =" + address.n_Country)
                        };
                        if (xpc.Count == 0)
                        {
                            sCountryName = "";
                        }
                        else
                        {
                            sCountryName = ((CodeCountry)xpc[0]).s_Name;
                        }
                    }
                    break;
                }
            }
            return sCountryName;
        }

        /// #################################################################
        /// <summary>
        ///     ��ȡ��ϵ�˹���(��������) ������ϵ�˵�ͨ�ŵ�ַȥ��ȡ��
        ///     Kevin Wang(2010-08-30)
        /// </summary>
        /// <returns>��ϵ�˵Ĺ���</returns>
        public string GetCountryOtherName()
        {
            string sCountryName = "";
            foreach (AgencyContactAddress address in AgencyConAddress)
            {
                if (address.s_Type != null && address.s_Type.ToUpper().IndexOf("O") >= 0)
                {
                    using (var uow = new UnitOfWork())
                    {
                        var xpc = new XPCollection(uow, typeof(CodeCountry))
                        {
                            Criteria = CriteriaOperator.Parse("n_ID =" + address.n_Country)
                        };
                        if (xpc.Count == 0)
                        {
                            sCountryName = "";
                        }
                        else
                        {
                            sCountryName = ((CodeCountry)xpc[0]).s_OtherName;
                        }
                    }
                    break;
                }
            }
            return sCountryName;
        }

        /// #################################################################
        /// <summary>
        ///     ��ȡ��ϵ���ʱ� ������ϵ�˵�ͨ�ŵ�ַȥ��ȡ��
        ///     Kevin Wang(2010-08-30)
        /// </summary>
        /// <returns>��ϵ�˵Ĺ���</returns>
        public string GetOfficeZipCode()
        {
            string sZipCode = "";
            foreach (AgencyContactAddress address in AgencyConAddress)
            {
                if (address.s_Type != null && address.s_Type.ToUpper().IndexOf("O") >= 0)
                {
                    sZipCode = address.s_ZipCode;
                }
            }
            return sZipCode;
        }

        #endregion

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}
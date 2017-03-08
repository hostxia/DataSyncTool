using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DataEntities.Config;
using DataEntities.Properties;
using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using Infralution.Localization;

namespace DataEntities.Contact.Client
{
    [Persistent("TCstmr_ClientContact")]
    public class ClientContact : XPLiteObject
    {
        private Client TCstmrClient;
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
        private string fs_Identity;
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

        public ClientContact(Session session)
            : base(session)
        {
        }

        public ClientContact()
            : base(Session.DefaultSession)
        {
        }

        [Key(true)]
        public int n_ContactID
        {
            get { return fn_ContactID; }
            set { SetPropertyValue<int>("n_ContactID", ref fn_ContactID, value); }
        }

        [Association("ClientContact"), Delayed]
        [Persistent("n_ClientID")]
        public Client tCstmrClient
        {
            get { return TCstmrClient; }
            set { SetPropertyValue("n_ClientID", ref TCstmrClient, value); }
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

        private string FullName
        {
            get { return (fs_FirstName ?? "") + " " + (fs_LastName ?? ""); }
        }

        private string CNFullName
        {
            get { return (fs_LastName ?? "") + (fs_FirstName ?? ""); }
        }

        [Size(200)]
        public string s_NativeName
        {
            get { return fs_NativeName; }
            set { SetPropertyValue("s_NativeName", ref fs_NativeName, value); }
        }

        public int n_Sequence
        {
            get { return fn_Sequence; }
            set { SetPropertyValue<int>("n_Sequence", ref fn_Sequence, value); }
        }

        [Size(200)]
        public string s_OtherName
        {
            get { return fs_OtherName; }
            set { SetPropertyValue("s_OtherName", ref fs_OtherName, value); }
        }

        [Size(50)]
        public string s_IPType
        {
            get { return fs_IPType; }
            set { SetPropertyValue("s_IPType", ref fs_IPType, value); }
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

        public string s_JobTitle
        {
            get { return fs_JobTitle; }
            set { SetPropertyValue("s_JobTitle", ref fs_JobTitle, value); }
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

        [Size(50)]
        public string s_Identity
        {
            get { return fs_Identity; }
            set { SetPropertyValue("s_Identity", ref fs_Identity, value); }
        }

        [Aggregated, Association("ClientConAddress", typeof(ClientContactAddress))]
        public XPCollection ClientConAddress
        {
            get { return GetCollection("ClientConAddress"); }
        }

        [NonPersistent]
        public bool Check { get; set; }

        [NonPersistent]
        public string sFlag { get; set; }

        [NonPersistent]
        public int Sequence { get; set; }

        /// <summary>
        ///     ��ȡ��ַ���ʱ�
        /// </summary>
        public string sZipCode
        {
            get
            {
                ClientContactAddress clientContactAddress =
                    ClientConAddress.Cast<ClientContactAddress>()
                        .FirstOrDefault(s => s.s_Type != null && s.s_Type.ToUpper().IndexOf("O") >= 0);
                return clientContactAddress != null ? clientContactAddress.s_ZipCode : string.Empty;
            }
        }

        /// <summary>
        ///     ����
        /// </summary>
        public string sCountry
        {
            get
            {
                string sCountryName = "";
                foreach (
                    ClientContactAddress address in
                        ClientConAddress.Cast<ClientContactAddress>()
                            .Where(address => address.s_Type != null && address.s_Type.ToUpper().IndexOf("O") >= 0))
                {
                    using (var uow = new UnitOfWork())
                    {
                        var xpc = new XPCollection(uow, typeof(CodeCountry))
                        {
                            Criteria = CriteriaOperator.Parse("n_ID =" + address.n_Country)
                        };
                        sCountryName = xpc.Count == 0 ? "" : ((CodeCountry)xpc[0]).s_Name;
                    }
                    break;
                }
                return sCountryName;
            }
        }

        public string Address1Type
        {
            get
            {
                return ClientConAddress.Count < 1 ? string.Empty : ((ClientContactAddress)ClientConAddress[0]).s_Type;
            }
        }

        public string Address1
        {
            get
            {
                return ClientConAddress.Count < 1 ? string.Empty : GetFullAddress((ClientContactAddress)ClientConAddress[0]);
            }
        }

        public string Address1EN
        {
            get
            {
                return ClientConAddress.Count < 1 ? string.Empty : GetFullAddress((ClientContactAddress)ClientConAddress[0], "en-US");
            }
        }

        public string Address1Street
        {
            get
            {
                return ClientConAddress.Count < 1 ? string.Empty : ((ClientContactAddress)ClientConAddress[0]).s_Street;
            }
        }

        public string Address1ZipCode
        {
            get
            {
                return ClientConAddress.Count < 1 ? string.Empty : ((ClientContactAddress)ClientConAddress[0]).s_ZipCode;
            }
        }

        public string Address2Type
        {
            get
            {
                return ClientConAddress.Count < 2 ? string.Empty : ((ClientContactAddress)ClientConAddress[1]).s_Type;
            }
        }

        public string Address2
        {
            get
            {
                return ClientConAddress.Count < 2 ? string.Empty : GetFullAddress((ClientContactAddress)ClientConAddress[1]);
            }
        }

        public string Address2EN
        {
            get
            {
                return ClientConAddress.Count < 2 ? string.Empty : GetFullAddress((ClientContactAddress)ClientConAddress[1], "en-US");
            }
        }

        public string Address2Street
        {
            get
            {
                return ClientConAddress.Count < 2 ? string.Empty : ((ClientContactAddress)ClientConAddress[1]).s_Street;
            }
        }

        public string Address2ZipCode
        {
            get
            {
                return ClientConAddress.Count < 2 ? string.Empty : ((ClientContactAddress)ClientConAddress[1]).s_ZipCode;
            }
        }

        public String Address3Type
        {
            get
            {
                return ClientConAddress.Count < 3 ? string.Empty : ((ClientContactAddress)ClientConAddress[2]).s_Type;
            }
        }

        public String Address3
        {
            get
            {
                return ClientConAddress.Count < 3 ? string.Empty : GetFullAddress((ClientContactAddress)ClientConAddress[2]);
            }
        }

        public String Address3EN
        {
            get
            {
                return ClientConAddress.Count < 3 ? string.Empty : GetFullAddress((ClientContactAddress)ClientConAddress[2], "en-US");
            }
        }

        public String Address3Street
        {
            get
            {
                return ClientConAddress.Count < 3 ? string.Empty : ((ClientContactAddress)ClientConAddress[2]).s_Street;
            }
        }

        public String Address3ZipCode
        {
            get
            {
                return ClientConAddress.Count < 3 ? string.Empty : ((ClientContactAddress)ClientConAddress[2]).s_ZipCode;
            }
        }

        public string GetFullAddress(ClientContactAddress address, string sLanguage = "zh-CN")
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

        public string Address1All
        {
            get
            {
                if (ClientConAddress.Count < 1) return "";
                var add = ClientConAddress[0] as ClientContactAddress;
                if (add == null) return "";
                switch (CultureManager.ApplicationUICulture.Name)
                {
                    case "zh-CN":
                        {
                            using (var tempUow = new UnitOfWork())
                            {
                                var country = tempUow.GetObjectByKey<CodeCountry>(add.n_Country);
                                return (country == null ? "" : country.s_Name) +
                                       (string.IsNullOrEmpty(add.s_State) ? "" : add.s_State)
                                       + (string.IsNullOrEmpty(add.s_City) ? "" : add.s_City) +
                                       (string.IsNullOrEmpty(add.s_StreetAll) ? "" : add.s_StreetAll);
                            }
                        }
                    case "en-US":
                        {
                            using (var tempUow = new UnitOfWork())
                            {
                                var country = tempUow.GetObjectByKey<CodeCountry>(add.n_Country);
                                return (!string.IsNullOrEmpty(add.s_StreetAll) ? add.s_StreetAll + ", " : "") +
                                       (!string.IsNullOrEmpty(add.s_City) ? add.s_City + ", " : "") +
                                       (!string.IsNullOrEmpty(add.s_State) ? add.s_State + ", " : "") +
                                       (country == null ? "" : country.s_Name);
                            }
                        }
                    default:
                        return "";
                }
            }
        }

        #region �Զ��巽��

        /// #################################################################
        /// <summary>
        ///     ��ȡ��ϵ�����ĵ�ַ
        ///     Kevin Wang(2010-08-30)
        /// </summary>
        /// <returns>��ϵ�˵����ĵ�ַ</returns>
        public string GetOfficeCNAddress()
        {
            foreach (ClientContactAddress address in ClientConAddress)
            {
                if (address.s_Type != null && address.s_Type.ToUpper().IndexOf("O") >= 0)
                {
                    string sFilePath = Application.StartupPath + "\\Config\\DefaultLoadConfig.ini";
                    string sSetion = "Language";
                    string sKey = "Language";
                    string missValue = "zh-CN";
                    var sLanguage = new StringBuilder(100);
                    //APIFunctions.GetPrivateProfileString(sSetion, sKey, missValue, sLanguage, 100,
                    //    sFilePath);

                    return sLanguage.ToString() == "zh-CN"
                        ? address.s_State + " " + address.s_City + " " + address.s_Street
                        : address.s_Street + " " + address.s_City + " " + address.s_State;
                }
            }
            return "";
        }

        /// #################################################################
        /// <summary>
        ///     ��ȡ��ϵ�����İ칫��ַ
        ///     Kevin Wang(2010-08-30)
        /// </summary>
        /// <returns>��ϵ�˵����İ칫��ַ</returns>
        public string GetOfficeENAddress()
        {
            foreach (ClientContactAddress address in ClientConAddress)
            {
                if (address.s_Type != null && address.s_Type.ToUpper().IndexOf("E") >= 0)
                {
                    return (address.s_State + " " + address.s_City + " " + address.s_Street).Trim();
                }
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
            foreach (ClientContactAddress address in ClientConAddress)
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
            foreach (ClientContactAddress address in ClientConAddress)
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
            foreach (ClientContactAddress address in ClientConAddress)
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
using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DataEntities.Case;
using DataEntities.Config;
using DataEntities.Element.Fee;
using DataEntities.Element.Files;
using DataEntities.Properties;
using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using Infralution.Localization;

namespace DataEntities.Contact.Agency
{
    [Persistent("TCstmr_CoopAgency")]
    public class Agency : XPLiteObject
    {
        private DateTime fdt_CreateDate;
        private DateTime fdt_EditDate;
        private DateTime fdt_FirstCaseFromDate;
        private DateTime fdt_FirstCaseToDate;
        private DateTime fdt_LastCaseFromDate;
        private DateTime fdt_LastCaseToDate;
        private int fn_AgencyID;
        private int fn_ClientID;
        private int fn_Language;
        private int fn_PayCurrency;
        private CodeSecurityLevelConfig fn_SecurityLevelID;
        private string fs_Creator;
        private string fs_Credit;
        private string fs_Editor;
        private string fs_Email;
        private string fs_Facebook;
        private string fs_Fax;
        private string fs_IMAddress;
        private string fs_IPType;
        private string fs_Lock;
        private string fs_Locker;
        private string fs_Mobile;

        private string fs_Name;
        private string fs_Code;
        private string fs_NativeName;
        private string fs_Notes;

        private string fs_OtherName;
        private string fs_Phone;
        private string fs_Twitter;
        private string fs_WebSite;

        public Agency(Session session) : base(session)
        {
        }

        public Agency() : base(Session.DefaultSession)
        {
        }

        [Key(true)]
        public int n_AgencyID
        {
            get { return fn_AgencyID; }
            set { SetPropertyValue<int>("n_AgencyID", ref fn_AgencyID, value); }
        }
        [Size(200)]
        public string s_Code
        {
            get { return fs_Code; }
            set { SetPropertyValue("s_Code", ref fs_Code, value); }
        }
        [Size(200)]
        public string s_Name
        {
            get { return fs_Name; }
            set { SetPropertyValue("s_Name", ref fs_Name, value); }
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

        public string LanguageCName
        {
            get
            {
                using (var uow = new UnitOfWork())
                {
                    var xpc = new XPCollection(uow, typeof (CodeLanguage))
                    {
                        Criteria = CriteriaOperator.Parse("n_ID =" + n_Language)
                    };
                    if (xpc == null || xpc.Count == 0)
                    {
                        return string.Empty;
                    }
                    return ((CodeLanguage) xpc[0]).s_Name;
                }
            }
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

        [Size(10)]
        public string s_Credit
        {
            get { return fs_Credit; }
            set { SetPropertyValue("s_Credit", ref fs_Credit, value); }
        }

        public string PayUnit
        {
            get
            {
                using (var uow = new UnitOfWork())
                {
                    var xpc = new XPCollection(uow, typeof (CodeCurrency))
                    {
                        Criteria = CriteriaOperator.Parse("n_ID = " + n_PayCurrency)
                    };
                    if (xpc == null || xpc.Count == 0)
                    {
                        return "";
                    }
                    return ((CodeCurrency) xpc[0]).s_Name;
                }
            }
        }

        [Size(800)]
        public string s_Notes
        {
            get { return fs_Notes; }
            set { SetPropertyValue("s_Notes", ref fs_Notes, value); }
        }

        public int n_ClientID
        {
            get { return fn_ClientID; }
            set { SetPropertyValue<int>("n_ClientID", ref fn_ClientID, value); }
        }

        public int n_PayCurrency
        {
            get { return fn_PayCurrency; }
            set { SetPropertyValue<int>("n_PayCurrency", ref fn_PayCurrency, value); }
        }

        public DateTime dt_FirstCaseFromDate
        {
            get { return fdt_FirstCaseFromDate; }
            set { SetPropertyValue<DateTime>("dt_FirstCaseFromDate", ref fdt_FirstCaseFromDate, value); }
        }

        public DateTime dt_LastCaseFromDate
        {
            get { return fdt_LastCaseFromDate; }
            set { SetPropertyValue<DateTime>("dt_LastCaseFromDate", ref fdt_LastCaseFromDate, value); }
        }

        public DateTime dt_FirstCaseToDate
        {
            get { return fdt_FirstCaseToDate; }
            set { SetPropertyValue<DateTime>("dt_FirstCaseToDate", ref fdt_FirstCaseToDate, value); }
        }

        public DateTime dt_LastCaseToDate
        {
            get { return fdt_LastCaseToDate; }
            set { SetPropertyValue<DateTime>("dt_LastCaseToDate", ref fdt_LastCaseToDate, value); }
        }

        [Size(150)]
        public string s_Phone
        {
            get { return fs_Phone; }
            set { SetPropertyValue("s_Phone", ref fs_Phone, value); }
        }

        [Size(150)]
        public string s_Mobile
        {
            get { return fs_Mobile; }
            set { SetPropertyValue("s_Mobile", ref fs_Mobile, value); }
        }

        [Size(50)]
        public string s_Creator
        {
            get { return fs_Creator; }
            set { SetPropertyValue("s_Creator", ref fs_Creator, value); }
        }

        [Size(50)]
        public string s_Editor
        {
            get { return fs_Editor; }
            set { SetPropertyValue("s_Editor", ref fs_Editor, value); }
        }

        [Size(150)]
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
        public string s_WebSite
        {
            get { return fs_WebSite; }
            set { SetPropertyValue("s_WebSite", ref fs_WebSite, value); }
        }

        public string s_IMAddress
        {
            get { return fs_IMAddress; }
            set { SetPropertyValue("s_IMAddress", ref fs_IMAddress, value); }
        }

        [Size(50)]
        public string s_Facebook
        {
            get { return fs_Facebook; }
            set { SetPropertyValue("s_Facebook", ref fs_Facebook, value); }
        }

        [Size(50)]
        public string s_Twitter
        {
            get { return fs_Twitter; }
            set { SetPropertyValue("s_Twitter", ref fs_Twitter, value); }
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

        [Size(1)]
        public string s_Lock
        {
            get { return fs_Lock; }
            set { SetPropertyValue("s_Lock", ref fs_Lock, value); }
        }

        [Size(20)]
        public string s_Locker
        {
            get { return fs_Locker; }
            set { SetPropertyValue("s_Locker", ref fs_Locker, value); }
        }

        //int fn_SecurityLevelID;//密级
        //public int n_SecurityLevelID
        //{
        //    get { return fn_SecurityLevelID; }
        //    set { SetPropertyValue<int>("n_SecurityLevelID", ref fn_SecurityLevelID, value); }
        //}

        [Association("SecurityLevel-Agencys")]
        [Persistent("n_SecurityLevelID")]
        public CodeSecurityLevelConfig TheSecurityLevel
        {
            get { return fn_SecurityLevelID; }
            set { SetPropertyValue("n_SecurityLevelID", ref fn_SecurityLevelID, value); }
        }

        [Aggregated, Association("AgencyAddress", typeof (AgencyAddress))]
        public XPCollection AgencyAddress
        {
            get { return GetCollection("AgencyAddress"); }
        }
        [Aggregated, Association("Agency-Files", typeof(AgencyFile))]
        public XPCollection AgencyFiles
        {
            get { return GetCollection("AgencyFiles"); }
        }
        [Aggregated, Association("AgencyContact", typeof (AgencyContact))]
        public XPCollection AgencyContact
        {
            get { return GetCollection("AgencyContact"); }
        }

        [Aggregated, Association("AgencyTo-BasicCasesTo", typeof (BasicCase))]
        public XPCollection BasicCasesTo
        {
            get { return GetCollection("BasicCasesTo"); }
        }

        [Aggregated, Association("Agency-AbroadBills", typeof (AbroadBill))]
        public XPCollection AbroadBills
        {
            get { return GetCollection("AbroadBills"); }
        }

        [Aggregated, Association("Agency-ABillHedge", typeof (ABillHedge))]
        public XPCollection ABillHedges
        {
            get { return GetCollection("ABillHedges"); }
        }


        [Aggregated, Association("Agency-OutFile", typeof (OutFile))]
        public XPCollection OutFiles
        {
            get { return GetCollection("OutFiles"); }
        }

        [Aggregated, Association("Agency-Demands")]
        public XPCollection<Demand.Demand> Demands
        {
            get { return GetCollection<Demand.Demand>("Demands"); }
        }

        public string s_AgencyName
        {
            get { return string.IsNullOrEmpty(fs_Name) ? string.Empty : fs_Name; }
        }

        #region 自定义方法

        public string Address1
        {
            get
            {
                if (AgencyAddress.Count < 1) return "";
                var add = AgencyAddress[0] as AgencyAddress;
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

        /// <summary>
        ///     国家
        /// </summary>
        public string sCountry
        {
            get
            {
                string sCountryName = "";
                foreach (
                    AgencyAddress address in
                        AgencyAddress.Cast<AgencyAddress>()
                            .Where(address => address.s_Type != null && address.s_Type.ToUpper().IndexOf("O") >= 0))
                {
                    using (var uow = new UnitOfWork())
                    {
                        var xpc = new XPCollection(uow, typeof (CodeCountry))
                        {
                            Criteria = CriteriaOperator.Parse("n_ID =" + address.n_Country)
                        };
                        sCountryName = xpc.Count == 0 ? "" : ((CodeCountry) xpc[0]).s_Name;
                    }
                    break;
                }
                return sCountryName;
            }
        }

        /// <summary>
        ///     首次来案日
        /// </summary>
        public DateTime FirstCaseFromDate
        {
            get
            {
                using (var uow = new UnitOfWork())
                {
                    var xpc = new XPCollection(uow, typeof (BasicCase))
                    {
                        Criteria = CriteriaOperator.Parse("TheClient.n_ClientID=?", n_ClientID)
                    };
                    return (!xpc.Cast<BasicCase>().Any())
                        ? DateTime.MinValue
                        : xpc.Cast<BasicCase>().Min(c => c.dt_UndertakeDate);
                }
            }
        }

        /// <summary>
        ///     最近来案日
        /// </summary>
        public DateTime LasteCaseFromDate
        {
            get
            {
                using (var uow = new UnitOfWork())
                {
                    var xpc = new XPCollection(uow, typeof (BasicCase))
                    {
                        Criteria = CriteriaOperator.Parse("TheClient.n_ClientID=?", n_ClientID)
                    };
                    return (!xpc.Cast<BasicCase>().Any())
                        ? DateTime.MinValue
                        : xpc.Cast<BasicCase>().Max(c => c.dt_UndertakeDate);
                }
            }
        }

        /// <summary>
        ///     去案总数
        /// </summary>
        public int CaseToDateCount
        {
            get
            {
                using (var uow = new UnitOfWork())
                {
                    var xpc = new XPCollection(uow, typeof (BasicCase))
                    {
                        Criteria = CriteriaOperator.Parse("TheAgencyTo.n_AgencyID=? ", n_AgencyID)
                    };
                    return xpc.Count;
                }
            }
        }

        /// <summary>
        ///     来案总数
        /// </summary>
        public int CaseFromDateCount
        {
            get
            {
                using (var uow = new UnitOfWork())
                {
                    var xpc = new XPCollection(uow, typeof (BasicCase))
                    {
                        Criteria = CriteriaOperator.Parse("TheClient.n_ClientID=? ", n_ClientID)
                    };
                    return xpc.Count;
                }
            }
        }

        /// <summary>
        ///     专利去案件总数
        /// </summary>
        public int PCaseToDateCount
        {
            get
            {
                using (var uow = new UnitOfWork())
                {
                    var xpc = new XPCollection(uow, typeof (BasicCase))
                    {
                        Criteria = CriteriaOperator.Parse("TheAgencyTo.n_AgencyID=? and s_IPType ='P'", n_AgencyID)
                    };
                    return xpc.Count;
                }
            }
        }

        /// <summary>
        ///     专利来案件总数
        /// </summary>
        public int PCaseFromDateCount
        {
            get
            {
                using (var uow = new UnitOfWork())
                {
                    var xpc = new XPCollection(uow, typeof (BasicCase))
                    {
                        Criteria = CriteriaOperator.Parse("TheClient.n_ClientID=? and s_IPType ='P'", n_ClientID)
                    };
                    return xpc.Count;
                }
            }
        }

        /// <summary>
        ///     商标去案件总数
        /// </summary>
        public int TMCaseToDateCount
        {
            get
            {
                using (var uow = new UnitOfWork())
                {
                    var xpc = new XPCollection(uow, typeof (BasicCase))
                    {
                        Criteria = CriteriaOperator.Parse("TheAgencyTo.n_AgencyID=? and s_IPType ='T'", n_AgencyID)
                    };
                    return xpc.Count;
                }
            }
        }

        /// <summary>
        ///     商标来案件总数
        /// </summary>
        public int TMCaseFromDateCount
        {
            get
            {
                using (var uow = new UnitOfWork())
                {
                    var xpc = new XPCollection(uow, typeof (BasicCase))
                    {
                        Criteria = CriteriaOperator.Parse("TheClient.n_ClientID=? and s_IPType ='T'", n_ClientID)
                    };
                    return xpc.Count;
                }
            }
        }


        /// <summary>
        ///     版权去案件总数
        /// </summary>
        public int CCaseToDateCount
        {
            get
            {
                using (var uow = new UnitOfWork())
                {
                    var xpc = new XPCollection(uow, typeof (BasicCase))
                    {
                        Criteria = CriteriaOperator.Parse("TheAgencyTo.n_AgencyID=? and s_IPType ='C'", n_AgencyID)
                    };
                    return xpc.Count;
                }
            }
        }

        /// <summary>
        ///     版权来案件总数
        /// </summary>
        public int CCaseFromDateCount
        {
            get
            {
                using (var uow = new UnitOfWork())
                {
                    var xpc = new XPCollection(uow, typeof (BasicCase))
                    {
                        Criteria = CriteriaOperator.Parse("TheClient.n_ClientID=? and s_IPType ='C'", n_ClientID)
                    };
                    return xpc.Count;
                }
            }
        }

        /// <summary>
        ///     域名去案件总数
        /// </summary>
        public int DCaseToDateCount
        {
            get
            {
                using (var uow = new UnitOfWork())
                {
                    var xpc = new XPCollection(uow, typeof (BasicCase))
                    {
                        Criteria = CriteriaOperator.Parse("TheAgencyTo.n_AgencyID=? and s_IPType ='D'", n_AgencyID)
                    };
                    return xpc.Count;
                }
            }
        }

        /// <summary>
        ///     域名来案件总数
        /// </summary>
        public int DCaseFromDateCount
        {
            get
            {
                using (var uow = new UnitOfWork())
                {
                    var xpc = new XPCollection(uow, typeof (BasicCase))
                    {
                        Criteria = CriteriaOperator.Parse("TheClient.n_ClientID=? and s_IPType ='D'", n_ClientID)
                    };
                    return xpc.Count;
                }
            }
        }

        /// <summary>
        ///     其他去案件总数
        /// </summary>
        public int OCaseToDateCount
        {
            get
            {
                using (var uow = new UnitOfWork())
                {
                    var xpc = new XPCollection(uow, typeof (BasicCase))
                    {
                        Criteria = CriteriaOperator.Parse("TheAgencyTo.n_AgencyID=? and s_IPType ='O'", n_AgencyID)
                    };
                    return xpc.Count;
                }
            }
        }

        /// <summary>
        ///     其他来案件总数
        /// </summary>
        public int OCaseFromDateCount
        {
            get
            {
                using (var uow = new UnitOfWork())
                {
                    var xpc = new XPCollection(uow, typeof (BasicCase))
                    {
                        Criteria = CriteriaOperator.Parse("TheClient.n_ClientID=? and s_IPType ='O'", n_ClientID)
                    };
                    return xpc.Count;
                }
            }
        }

        public string AgencyContactAddress1
        {
            get
            {
                if (AgencyContact.Count < 1) return "";
                var agencyContact = AgencyContact[0] as AgencyContact;
                if (agencyContact != null) return agencyContact.Address1;
                return string.Empty;
            }
        }


        /// #################################################################
        /// <summary>
        ///     获取代理机构的国别
        ///     Kevin Wang(2010-10-12)
        /// </summary>
        /// <returns>国别</returns>
        public string GetAgencyCountry()
        {
            //寻找办公地址.取办公地址的国别
            foreach (AgencyAddress address in AgencyAddress)
            {
                if (address.s_Type == null || address.s_Type.ToUpper().IndexOf("O") < 0) continue;
                using (var uow = new UnitOfWork())
                {
                    var xpc = new XPCollection(uow, typeof (CodeCountry))
                    {
                        Criteria = CriteriaOperator.Parse("n_ID =" + address.n_Country)
                    };
                    return xpc.Count == 0 ? "" : ((CodeCountry) xpc[0]).s_Name;
                }
            }
            return "";
        }

        /// #################################################################
        /// <summary>
        ///     获取代理机构的国别（英文）
        ///     gengxuejiao(2010-10-12)
        /// </summary>
        /// <returns>国别</returns>
        public string GetENAgencyCountry()
        {
            //寻找办公地址.取办公地址的国别
            foreach (AgencyAddress address in AgencyAddress)
            {
                if (address.s_Type == null || address.s_Type.ToUpper().IndexOf("O") < 0) continue;
                using (var uow = new UnitOfWork())
                {
                    var xpc = new XPCollection(uow, typeof (CodeCountry))
                    {
                        Criteria = CriteriaOperator.Parse("n_ID =" + address.n_Country)
                    };
                    return xpc.Count == 0 ? "" : ((CodeCountry) xpc[0]).s_OtherName;
                }
            }
            return "";
        }

        /// #################################################################
        /// <summary>
        ///     获取代理机构的办公地址
        ///     Kevin Wang(2010-10-12)
        /// </summary>
        /// <returns>办公地址</returns>
        public string GetOfficeCNAddress()
        {
            foreach (AgencyAddress address in AgencyAddress)
            {
                if (address.s_Type == null || address.s_Type.ToUpper().IndexOf("O") < 0) continue;
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
            return "";
        }

        /// #################################################################
        /// <summary>
        ///     获取代理机构的英文办公地址
        ///     Kevin Wang(2010-10-12)
        /// </summary>
        /// <returns>英文办公地址</returns>
        public string GetOfficeENAddress()
        {
            foreach (AgencyAddress appAddress in AgencyAddress)
            {
                if (appAddress.s_Type == null || appAddress.s_Type.IndexOf("E") < 0) continue;
                return appAddress.s_Street + ", " + appAddress.s_City + ", " + appAddress.s_State;
            }
            return "";
        }

        /// #################################################################
        /// <summary>
        ///     获取代理机构的办公邮编。 取得到的第一个办公地址
        ///     Kevin Wang(2010-10-11)
        /// </summary>
        /// <returns>代理机构办公邮编</returns>
        public string GetOfficeZipCode()
        {
            foreach (AgencyAddress address in AgencyAddress)
            {
                if (address.s_Type != null && address.s_Type.ToUpper().IndexOf("O") >= 0)
                {
                    return address.s_ZipCode;
                }
            }
            return "";
        }

        #endregion

        #region 高级查询所用的特殊字段

        /// <summary>
        ///     代理机构地址，高级字段使用
        /// </summary>
        public string AgencyAddresses
        {
            get
            {
                string sAdd = string.Empty;
                using (var tempUow = new UnitOfWork())
                {
                    sAdd = AgencyAddress.Cast<AgencyAddress>()
                        .Where(address => address != null)
                        .Aggregate(sAdd,
                            (current, address) =>
                                current +
                                ((tempUow.GetObjectByKey<CodeCountry>(address.n_Country) == null
                                    ? string.Empty
                                    : tempUow.GetObjectByKey<CodeCountry>(address.n_Country).s_Name) + " " +
                                 address.s_State + " " + address.s_City + " " + address.s_StreetAll + " "));
                }
                return sAdd;
            }
        }

        /// <summary>
        ///     代理机构联系人名，高级查询使用
        /// </summary>
        public string AgencyContactFirstName
        {
            get
            {
                string sFirstName = string.Empty;
                foreach (AgencyContact agencyContact in AgencyContact)
                {
                    if (agencyContact == null) continue;
                    sFirstName += agencyContact.s_FirstName + " ";
                }
                return sFirstName;
            }
        }

        /// <summary>
        ///     代理机构联系人姓，高级查询使用
        /// </summary>
        public string AgencyContactLastName
        {
            get
            {
                string sLastName = string.Empty;
                foreach (AgencyContact agencyContact in AgencyContact)
                {
                    if (agencyContact == null) continue;
                    sLastName += agencyContact.s_LastName + " ";
                }
                return sLastName;
            }
        }

        /// <summary>
        ///     代理机构联系人电话，高级查询使用
        /// </summary>
        public string AgencyContactTel
        {
            get
            {
                string sTel = string.Empty;
                foreach (AgencyContact agencyContact in AgencyContact)
                {
                    if (agencyContact == null) continue;
                    sTel += agencyContact.s_Phone + " ";
                }
                return sTel;
            }
        }

        /// <summary>
        ///     代理机构联系人传真，高级查询使用
        /// </summary>
        public string AgencyContactFax
        {
            get
            {
                string sFax = string.Empty;
                foreach (AgencyContact agencyContact in AgencyContact)
                {
                    if (agencyContact == null) continue;
                    sFax += agencyContact.s_Fax + " ";
                }
                return sFax;
            }
        }

        /// <summary>
        ///     代理机构联系人Email，高级查询使用
        /// </summary>
        public string AgencyContactEmail
        {
            get
            {
                string sEmail = string.Empty;
                foreach (AgencyContact agencyContact in AgencyContact)
                {
                    if (agencyContact == null) continue;
                    sEmail += agencyContact.s_Email + " ";
                }
                return sEmail;
            }
        }

        #endregion

        #region 财务信息

        string fs_BeneficiaryBankName;
        [Size(500)]
        public string s_BeneficiaryBankName
        {
            get { return fs_BeneficiaryBankName; }
            set { SetPropertyValue<string>("s_BeneficiaryBankName", ref fs_BeneficiaryBankName, value); }
        }

        string fs_BeneficiaryBankAddress;
        [Size(1000)]
        public string s_BeneficiaryBankAddress
        {
            get { return fs_BeneficiaryBankAddress; }
            set { SetPropertyValue<string>("s_BeneficiaryBankAddress", ref fs_BeneficiaryBankAddress, value); }
        }

        string fs_BeneficiaryName;
        [Size(500)]
        public string s_BeneficiaryName
        {
            get { return fs_BeneficiaryName; }
            set { SetPropertyValue<string>("s_BeneficiaryName", ref fs_BeneficiaryName, value); }
        }

        string fs_BeneficiaryAddress;
        [Size(1000)]
        public string s_BeneficiaryAddress
        {
            get { return fs_BeneficiaryAddress; }
            set { SetPropertyValue<string>("s_BeneficiaryAddress", ref fs_BeneficiaryAddress, value); }
        }

        string fs_BeneficiaryAccountNumber;
        [Size(500)]
        public string s_BeneficiaryAccountNumber
        {
            get { return fs_BeneficiaryAccountNumber; }
            set { SetPropertyValue<string>("s_BeneficiaryAccountNumber", ref fs_BeneficiaryAccountNumber, value); }
        }

        string fs_IBAN;
        [Size(500)]
        public string s_IBAN
        {
            get { return fs_IBAN; }
            set { SetPropertyValue<string>("s_IBAN", ref fs_IBAN, value); }
        }

        string fs_SwiftCode;
        [Size(500)]
        public string s_SwiftCode
        {
            get { return fs_SwiftCode; }
            set { SetPropertyValue<string>("s_SwiftCode", ref fs_SwiftCode, value); }
        }

        string fs_ABA;
        [Size(500)]
        public string s_ABA
        {
            get { return fs_ABA; }
            set { SetPropertyValue<string>("s_ABA", ref fs_ABA, value); }
        }

        #endregion

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}
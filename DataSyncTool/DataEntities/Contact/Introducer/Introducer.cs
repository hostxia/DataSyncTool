using System;
using System.Linq;
using DataEntities.Case;
using DataEntities.Config;
using DataEntities.Properties;
using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using Infralution.Localization;

namespace DataEntities.Contact.Introducer
{
    [Persistent("TCstmr_Introducer")]
    public class Introducer : XPLiteObject
    {
        private DateTime fdt_CreateDate;
        private DateTime fdt_EditDate;
        private DateTime fdt_FirstCaseDate;
        private DateTime fdt_LastCaseDate;
        private Int32 fn_ID;
        private decimal fn_Percent;
        private CodeSecurityLevelConfig fn_SecurityLevelID;
        private string fs_Creator;
        private string fs_Editor;
        private string fs_Email;
        private string fs_Facebook;
        private string fs_Fax;
        private string fs_FirstName;
        private string fs_IMAddress;
        private string fs_IPType;
        private string fs_Initial;
        private string fs_IntroCode;
        private string fs_JobTitle;

        private string fs_LastName;
        private string fs_Lock;
        private string fs_Locker;
        private string fs_Mobile;
        private string fs_NativeName;
        private string fs_Notes;
        private string fs_Phone;
        private string fs_Prefix;
        private string fs_Twitter;
        private string fs_Website;

        public Introducer(Session session) : base(session)
        {
        }

        public Introducer() : base(Session.DefaultSession)
        {
        }

        [Key(true)]
        public Int32 n_ID
        {
            get { return fn_ID; }
            set { SetPropertyValue<Int32>("n_ID", ref fn_ID, value); }
        }

        public string s_LastName
        {
            get { return fs_LastName; }
            set { SetPropertyValue("s_LastName", ref fs_LastName, value); }
        }

        public string s_FirstName
        {
            get { return fs_FirstName; }
            set { SetPropertyValue("s_FirstName", ref fs_FirstName, value); }
        }

        [Size(50)]
        public string s_Initial
        {
            get { return fs_Initial; }
            set { SetPropertyValue("s_Initial", ref fs_Initial, value); }
        }

        private string FullName
        {
            get { return string.Format("{0} {1}", s_FirstName, s_LastName); }
        }

        private string CNFullName
        {
            get { return s_LastName + s_FirstName; }
        }

        public string Name
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

        [Size(30)]
        public string s_Prefix
        {
            get { return fs_Prefix; }
            set { SetPropertyValue("s_Prefix", ref fs_Prefix, value); }
        }

        [Size(200)]
        public string s_NativeName
        {
            get { return fs_NativeName; }
            set { SetPropertyValue("s_NativeName", ref fs_NativeName, value); }
        }

        [Size(20)]
        public string s_IntroCode
        {
            get { return fs_IntroCode; }
            set { SetPropertyValue("s_IntroCode", ref fs_IntroCode, value); }
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

        public string s_JobTitle
        {
            get { return fs_JobTitle; }
            set { SetPropertyValue("s_JobTitle", ref fs_JobTitle, value); }
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

        [Size(800)]
        public string s_Notes
        {
            get { return fs_Notes; }
            set { SetPropertyValue("s_Notes", ref fs_Notes, value); }
        }

        public DateTime dt_FirstCaseDate
        {
            get { return fdt_FirstCaseDate; }
            set { SetPropertyValue<DateTime>("dt_FirstCaseDate", ref fdt_FirstCaseDate, value); }
        }

        public DateTime dt_LastCaseDate
        {
            get { return fdt_LastCaseDate; }
            set { SetPropertyValue<DateTime>("dt_LastCaseDate", ref fdt_LastCaseDate, value); }
        }

        public DateTime dt_CreateDate
        {
            get { return fdt_CreateDate; }
            set { SetPropertyValue<DateTime>("dt_CreateDate", ref fdt_CreateDate, value); }
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

        public decimal n_Percent
        {
            get { return fn_Percent; }
            set { SetPropertyValue<decimal>("n_Percent", ref fn_Percent, value); }
        }

        public string s_Percent
        {
            get
            {
                if (fn_Percent == 0)
                {
                    return "0";
                }

                return Math.Round(n_Percent, 2) + "%";
            }
        }


        public int n_PCount
        {
            get { return BasicCases.Cast<BasicCase>().Count(s => s.s_IPType == "P"); }
        }

        public int n_TCount
        {
            get { return BasicCases.Cast<BasicCase>().Count(s => s.s_IPType == "T"); }
        }

        public int n_DCount
        {
            get { return BasicCases.Cast<BasicCase>().Count(s => s.s_IPType == "D"); }
        }

        public int n_CCount
        {
            get { return BasicCases.Cast<BasicCase>().Count(s => s.s_IPType == "C"); }
        }

        public int n_OCount
        {
            get { return BasicCases.Cast<BasicCase>().Count(s => s.s_IPType == "O"); }
        }

        //int fn_SecurityLevelID;//密级
        //public int n_SecurityLevelID
        //{
        //    get { return fn_SecurityLevelID; }
        //    set { SetPropertyValue<int>("n_SecurityLevelID", ref fn_SecurityLevelID, value); }
        //}

        [Association("SecurityLevel-Introducers")]
        [Persistent("n_SecurityLevelID")]
        public CodeSecurityLevelConfig TheSecurityLevel
        {
            get { return fn_SecurityLevelID; }
            set { SetPropertyValue("n_SecurityLevelID", ref fn_SecurityLevelID, value); }
        }

        [Association("Introducer-Addresses", typeof (IntroAddress)), Aggregated]
        public XPCollection Addresses
        {
            get { return GetCollection("Addresses"); }
        }

        [Association("Introducer-BasicCases", typeof (BasicCase)), Aggregated]
        public XPCollection BasicCases
        {
            get { return GetCollection("BasicCases"); }
        }

        [Aggregated, Association("Introducer-Contacts", typeof (IntroContact))]
        public XPCollection IntroContacts
        {
            get { return GetCollection("IntroContacts"); }
        }

        #region 方法

        public string Address1
        {
            get
            {
                if (Addresses.Count < 1) return "";
                var add = Addresses[0] as IntroAddress;
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

        /// #################################################################
        /// <summary>
        ///     获取英文办公地址。
        ///     Kevin Wang(2010-10-25)
        /// </summary>
        /// <returns>英文办公地址</returns>
        public string GetOfficeENAddress()
        {
            foreach (IntroAddress appConAddress in Addresses)
            {
                if (appConAddress.s_Type == null || appConAddress.s_Type.IndexOf("E") < 0) continue;
                return appConAddress.s_Street + ", " + appConAddress.s_City + ", " + appConAddress.s_State;
            }
            return "";
        }

        /// #################################################################
        /// <summary>
        ///     获取中文办公地址。
        ///     Kevin Wang(2010-10-25)
        /// </summary>
        /// <returns>中文办公地址</returns>
        public string GetOfficeCNAddress()
        {
            foreach (IntroAddress appConAddress in Addresses)
            {
                if (appConAddress.s_Type == null || appConAddress.s_Type.IndexOf("O") < 0) continue;
                return appConAddress.s_State + " " + appConAddress.s_City + " " + appConAddress.s_Street;
            }

            return "";
        }


        /// #################################################################
        /// <summary>
        ///     获取联系人国别 根据联系人的通信地址去获取。
        ///     Kevin Wang(2010-08-30)
        /// </summary>
        /// <returns>联系人的国别</returns>
        public string GetCountryName()
        {
            string sCountryName = "";
            foreach (IntroAddress address in Addresses)
            {
                if (address.s_Type != null && address.s_Type.ToUpper().IndexOf("O") >= 0)
                {
                    using (var uow = new UnitOfWork())
                    {
                        var xpc = new XPCollection(uow, typeof (CodeCountry))
                        {
                            Criteria = CriteriaOperator.Parse("n_ID =" + address.n_Country)
                        };
                        if (xpc.Count == 0)
                        {
                            sCountryName = "";
                        }
                        else
                        {
                            sCountryName = ((CodeCountry) xpc[0]).s_Name;
                        }
                    }
                    break;
                }
            }
            return sCountryName;
        }

        /// #################################################################
        /// <summary>
        ///     获取联系人国别(其他名称) 根据联系人的通信地址去获取。
        ///     Kevin Wang(2010-08-30)
        /// </summary>
        /// <returns>联系人的国别</returns>
        public string GetCountryOtherName()
        {
            string sCountryName = "";
            foreach (IntroAddress address in Addresses)
            {
                if (address.s_Type != null && address.s_Type.ToUpper().IndexOf("O") >= 0)
                {
                    using (var uow = new UnitOfWork())
                    {
                        var xpc = new XPCollection(uow, typeof (CodeCountry))
                        {
                            Criteria = CriteriaOperator.Parse("n_ID =" + address.n_Country)
                        };
                        if (xpc.Count == 0)
                        {
                            sCountryName = "";
                        }
                        else
                        {
                            sCountryName = ((CodeCountry) xpc[0]).s_OtherName;
                        }
                    }
                    break;
                }
            }
            return sCountryName;
        }

        /// #################################################################
        /// <summary>
        ///     获取联系人邮编 根据联系人的通信地址去获取。
        ///     Kevin Wang(2010-08-30)
        /// </summary>
        /// <returns>联系人的国别</returns>
        public string GetOfficeZipCode()
        {
            string sZipCode = "";
            foreach (IntroAddress address in Addresses)
            {
                if (address.s_Type != null && address.s_Type.ToUpper().IndexOf("O") >= 0)
                {
                    sZipCode = address.s_ZipCode;
                }
            }
            return sZipCode;
        }

        #endregion

        #region 高级查询所用的特殊字段

        /// <summary>
        ///     案源人地址，高级查询使用
        /// </summary>
        public string IntroducerAddress
        {
            get
            {
                string sAdd = string.Empty;
                using (var tempUow = new UnitOfWork())
                {
                    foreach (IntroAddress introAddress in Addresses)
                    {
                        if (introAddress == null) continue;
                        sAdd += (tempUow.GetObjectByKey<CodeCountry>(introAddress.n_Country) == null
                            ? string.Empty
                            : tempUow.GetObjectByKey<CodeCountry>(introAddress.n_Country).s_Name) + " " +
                                introAddress.s_State + " " + introAddress.s_City + " " + introAddress.s_Street + " ";
                    }
                }
                return sAdd;
            }
        }

        #endregion

        #region 财务信息

        private string fs_AccountCode;
        private string fs_AccountName;
        private string fs_AccountNo;

        private string fs_BankName;
        private string fs_InvoiceTo;
        private string fs_RegAddress;
        private string fs_RegTel;
        private string fs_TaxCode;

        [Size(200)]
        public string s_AccountName
        {
            get { return fs_AccountName; }
            set { SetPropertyValue("s_AccountName", ref fs_AccountName, value); }
        }

        [Size(200)]
        public string s_BankName
        {
            get { return fs_BankName; }
            set { SetPropertyValue("s_BankName", ref fs_BankName, value); }
        }

        [Size(100)]
        public string s_AccountNo
        {
            get { return fs_AccountNo; }
            set { SetPropertyValue("s_AccountNo", ref fs_AccountNo, value); }
        }

        [Size(40)]
        public string s_AccountCode
        {
            get { return fs_AccountCode; }
            set { SetPropertyValue("s_AccountCode", ref fs_AccountCode, value); }
        }

        [Size(100)]
        public string s_TaxCode
        {
            get { return fs_TaxCode; }
            set { SetPropertyValue("s_TaxCode", ref fs_TaxCode, value); }
        }

        [Size(400)]
        public string s_RegAddress
        {
            get { return fs_RegAddress; }
            set { SetPropertyValue("s_RegAddress", ref fs_RegAddress, value); }
        }

        [Size(100)]
        public string s_RegTel
        {
            get { return fs_RegTel; }
            set { SetPropertyValue("s_RegTel", ref fs_RegTel, value); }
        }

        [Size(200)]
        public string s_InvoiceTo
        {
            get { return fs_InvoiceTo; }
            set { SetPropertyValue("s_InvoiceTo", ref fs_InvoiceTo, value); }
        }

        #endregion

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}
using System;
using System.Linq;
using DataEntities.Case;
using DataEntities.Config;
using DataEntities.Contact.Client;
using DataEntities.Element.Files;
using DataEntities.Properties;
using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using Infralution.Localization;

namespace DataEntities.Contact.Applicant
{
    [Persistent("TCstmr_Applicant")]
    public class Applicant : XPLiteObject
    {
        private DateTime fdt_CreateDate;
        private DateTime fdt_EditDate;
        private int fn_AppID;
        private CodeSecurityLevelConfig fn_SecurityLevelID;
        private string fs_AppCode;
        private string fs_AppType;
        private string fs_PayFeePerson;
        private string fs_Area;
        private string fs_Corporation;
        private string fs_Creator;
        private string fs_Duty;
        private string fs_Editor;
        private string fs_Email;
        private string fs_Facebook;
        private string fs_Fax;
        private string fs_GovName;
        private string fs_HasTrustDeed;
        private string fs_IDName;
        private string fs_IDNumber;
        private string fs_IMAddress;
        private string fs_IPType;
        private string fs_Lock;
        private string fs_Locker;
        private string fs_Mobile;

        private string fs_Name;
        private string fs_NativeName;
        private string fs_Notes;
        private string fs_OtherName;
        private string fs_Phone;
        private string fs_TrustDeedNo;
        private string fs_TrustDeedPath;
        private string fs_Twitter;
        private string fs_Website;
        private int fsn_ClientID;
        private int fn_Country;

        public Applicant(Session session)
            : base(session)
        {

        }

        public Applicant()
            : base(Session.DefaultSession)
        {

        }

        [Key(true)]
        public int n_AppID
        {
            get { return fn_AppID; }
            set { SetPropertyValue<int>("n_AppID", ref fn_AppID, value); }
        }

        [Size(300)]
        public string s_Name
        {
            get { return fs_Name; }
            set { SetPropertyValue("s_Name", ref fs_Name, value); }
        }

        public int n_ClientID
        {
            get { return fsn_ClientID; }
            set { SetPropertyValue<int>("n_ClientID", ref fsn_ClientID, value); }
        }

        [Size(200)]
        public string s_NativeName
        {
            get { return fs_NativeName; }
            set { SetPropertyValue("s_NativeName", ref fs_NativeName, value); }
        }
        public int n_Country
        {
            get { return fn_Country; }
            set { SetPropertyValue<int>("n_Country", ref fn_Country, value); }
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

        [Size(50)]
        public string s_AppType
        {
            get { return fs_AppType; }
            set { SetPropertyValue("s_AppType", ref fs_AppType, value); }
        }
        public string s_PayFeePerson
        {
            get { return fs_PayFeePerson; }
            set { SetPropertyValue("s_PayFeePerson", ref fs_PayFeePerson, value); }
        }
        public string AppType
        {
            get
            {
                switch (s_AppType)
                {
                    case "0":
                        return Resource.AppTypePersonal;
                    case "1":
                        return Resource.AppTypeUnitOrEnterprise;
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
        public string s_IDName
        {
            get { return fs_IDName; }
            set { SetPropertyValue("s_IDName", ref fs_IDName, value); }
        }

        [Size(50)]
        public string s_IDNumber
        {
            get { return fs_IDNumber; }
            set { SetPropertyValue("s_IDNumber", ref fs_IDNumber, value); }
        }

        [Size(20)]
        public string s_AppCode
        {
            get { return fs_AppCode; }
            set { SetPropertyValue("s_AppCode", ref fs_AppCode, value); }
        }

        [Size(1)]
        public string s_HasTrustDeed
        {
            get { return fs_HasTrustDeed; }
            set { SetPropertyValue("s_HasTrustDeed", ref fs_HasTrustDeed, value); }
        }

        [Size(30)]
        public string s_TrustDeedNo
        {
            get { return fs_TrustDeedNo; }
            set { SetPropertyValue("s_TrustDeedNo", ref fs_TrustDeedNo, value); }
        }

        [Size(300)]
        public string s_TrustDeedPath
        {
            get { return fs_TrustDeedPath; }
            set { SetPropertyValue("s_TrustDeedPath", ref fs_TrustDeedPath, value); }
        }

        [Size(100)]
        public string s_Corporation
        {
            get { return fs_Corporation; }
            set { SetPropertyValue("s_Corporation", ref fs_Corporation, value); }
        }

        [Size(100)]
        public string s_Duty
        {
            get { return fs_Duty; }
            set { SetPropertyValue("s_Duty", ref fs_Duty, value); }
        }

        [Size(800)]
        public string s_Notes
        {
            get { return fs_Notes; }
            set { SetPropertyValue("s_Notes", ref fs_Notes, value); }
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

        [Size(100)]
        public string s_Area
        {
            get { return fs_Area; }
            set { SetPropertyValue("s_Area", ref fs_Area, value); }
        }

        [Size(100)]
        public string s_GovName
        {
            get { return fs_GovName; }
            set { SetPropertyValue("s_GovName", ref fs_GovName, value); }
        }

        //int fn_SecurityLevelID;//密级
        //public int n_SecurityLevelID
        //{
        //    get { return fn_SecurityLevelID; }
        //    set { SetPropertyValue<int>("n_SecurityLevelID", ref fn_SecurityLevelID, value); }
        //}

        string fs_FeeMitigationYear;
        [Size(100)]
        public string s_FeeMitigationYear
        {
            get { return fs_FeeMitigationYear; }
            set { SetPropertyValue<string>("s_FeeMitigationYear", ref fs_FeeMitigationYear, value); }
        }

        string fs_FeeMitigationNum;
        [Size(100)]
        public string s_FeeMitigationNum
        {
            get { return fs_FeeMitigationNum; }
            set { SetPropertyValue<string>("s_FeeMitigationNum", ref fs_FeeMitigationNum, value); }
        }

        [Association("SecurityLevel-Applicants")]
        [Persistent("n_SecurityLevelID")]
        public CodeSecurityLevelConfig TheSecurityLevel
        {
            get { return fn_SecurityLevelID; }
            set { SetPropertyValue("n_SecurityLevelID", ref fn_SecurityLevelID, value); }
        }

        [Aggregated, Association("AppAddress", typeof(ApplicantAddress))]
        public XPCollection AppAddress
        {
            get { return GetCollection("AppAddress"); }
        }

        [Aggregated, Association("AppTransLatedName", typeof(ApplicantTransLatedName))]
        public XPCollection AppTransLatedName
        {
            get { return GetCollection("AppTransLatedName"); }
        }
        [Aggregated, Association("AppContact", typeof(ApplicantContact))]
        public XPCollection AppContact
        {
            get { return GetCollection("AppContact"); }
        }

        [Aggregated, Association("Applicant-BaseFile", typeof(BaseFile))]
        public XPCollection<BaseFile> BaseFiles
        {
            get { return GetCollection<BaseFile>("BaseFiles"); }
        }

        [Aggregated, Association("FileApplicant-ApplicantFile", typeof(BaseFile))]
        public XPCollection<BaseFile> ApplicantFiles
        {
            get { return GetCollection<BaseFile>("ApplicantFiles"); }
        }

        [Aggregated, Association("ApplicantFeeCombine", typeof(FeePreferentialCombine))]
        public XPCollection ApplicantFeeCombine
        {
            get { return GetCollection("ApplicantFeeCombine"); }
        }

        [Aggregated, Association("Applicant-Demands")]
        public XPCollection<Demand.Demand> Demands
        {
            get { return GetCollection<Demand.Demand>("Demands"); }
        }

        //[Aggregated, Association("ApplicantFeePolicy", typeof(ClientFeePolicy))]
        //public XPCollection ApplicantFeePolicy
        //{
        //    get { return GetCollection("ApplicantFeePolicy"); }
        //}

        [NonPersistent]
        public ApplicantTransLatedName TheApplicantTransLatedName
        {
            get;
            set;
        }
        //private ApplicantTransLatedName applicantTransLatedName;
        //[Persistent("n_ApplicantTransLatedNameID"), Association("applicant-applicantTransLatedName")]
        //public ApplicantTransLatedName TheCodeCaseProcessItem
        //{
        //    get { return applicantTransLatedName; }
        //    set { SetPropertyValue<ApplicantTransLatedName>("n_ApplicantTransLatedNameID", ref applicantTransLatedName, value); }
        //}
        private int nApplicantTransLatedNameID;
        [NonPersistent]
        public int n_ApplicantTransLatedNameID
        {
            get { return TheApplicantTransLatedName == null ? nApplicantTransLatedNameID : TheApplicantTransLatedName.n_ID; }
            set { nApplicantTransLatedNameID = value; }
        }
        #region 方法

        /// <summary>
        ///     首次来案日
        /// </summary>
        [Delayed]
        public DateTime FirstCaseFromDate
        {
            get
            {
                using (var uow = new UnitOfWork())
                {
                    var xpc = new XPCollection(uow, typeof(BasicCase))
                    {
                        Criteria = CriteriaOperator.Parse("[Applicants][n_ApplicantID =?]", n_AppID)
                    };
                    if (xpc != null && xpc.Count > 0)
                    {
                        return xpc.Cast<BasicCase>().Min(c => c.dt_UndertakeDate);
                    }
                    return DateTime.MinValue;
                }
            }
        }

        /// <summary>
        ///     最近来案日
        /// </summary>
        [Delayed]
        public DateTime LastCaseFromDate
        {
            get
            {
                using (var uow = new UnitOfWork())
                {
                    var xpc = new XPCollection(uow, typeof(BasicCase))
                    {
                        Criteria = CriteriaOperator.Parse("[Applicants][n_ApplicantID =?]", n_AppID)
                    };
                    if (xpc != null && xpc.Count > 0)
                    {
                        return xpc.Cast<BasicCase>().Max(c => c.dt_UndertakeDate);
                    }
                    return DateTime.MinValue;
                }
            }
        }

        /// <summary>
        ///     获取客户的案件数量
        ///     coder:zhangjiechen(2011-8-19)
        /// </summary>
        [NonPersistent]
        public int RelatedCaseCount
        {
            get
            {
                return
                    Convert.ToInt32(new UnitOfWork().Evaluate<BasicCase>(CriteriaOperator.Parse("Count()"),
                        CriteriaOperator.Parse("[Applicants][n_ApplicantID =?]", n_AppID)));
            }
        }

        /// <summary>
        ///     获取客户的案件数量
        ///     coder:zhangjiechen(2011-8-19)
        /// </summary>
        [NonPersistent]
        public int PatentCaseCount
        {
            get
            {
                return
                    Convert.ToInt32(new UnitOfWork().Evaluate<BasicCase>(CriteriaOperator.Parse("Count()"),
                        CriteriaOperator.Parse("[Applicants][n_ApplicantID =?] AND s_IPType ='P'", n_AppID)));
            }
        }

        /// <summary>
        ///     获取客户的案件数量
        ///     coder:zhangjiechen(2011-8-19)
        /// </summary>
        [NonPersistent]
        public int TMCaseCount
        {
            get
            {
                return
                    Convert.ToInt32(new UnitOfWork().Evaluate<BasicCase>(CriteriaOperator.Parse("Count()"),
                        CriteriaOperator.Parse("[Applicants][n_ApplicantID =?] AND s_IPType ='T'", n_AppID)));
            }
        }

        /// <summary>
        ///     获取客户的案件数量
        ///     coder:zhangjiechen(2011-8-19)
        /// </summary>
        [NonPersistent]
        public int CopyrightCaseCount
        {
            get
            {
                return
                    Convert.ToInt32(new UnitOfWork().Evaluate<BasicCase>(CriteriaOperator.Parse("Count()"),
                        CriteriaOperator.Parse("[Applicants][n_ApplicantID =?] AND s_IPType ='C'", n_AppID)));
            }
        }

        /// <summary>
        ///     获取客户的案件数量
        ///     coder:zhangjiechen(2011-8-19)
        /// </summary>
        [NonPersistent]
        public int DomainCaseCount
        {
            get
            {
                return
                    Convert.ToInt32(new UnitOfWork().Evaluate<BasicCase>(CriteriaOperator.Parse("Count()"),
                        CriteriaOperator.Parse("[Applicants][n_ApplicantID =?] AND s_IPType ='D'", n_AppID)));
            }
        }

        /// <summary>
        ///     获取客户的案件数量
        ///     coder:zhangjiechen(2011-8-19)
        /// </summary>
        [NonPersistent]
        public int OtherCaseCount
        {
            get
            {
                return
                    Convert.ToInt32(new UnitOfWork().Evaluate<BasicCase>(CriteriaOperator.Parse("Count()"),
                        CriteriaOperator.Parse("[Applicants][n_ApplicantID =?] AND s_IPType ='O'", n_AppID)));
            }
        }

        /// <summary>
        ///     获取第一地址
        ///     lixin（2013-04-15）
        /// </summary>
        public string Address1
        {
            get
            {
                if (AppAddress.Count < 1) return "";
                var add = AppAddress[0] as ApplicantAddress;
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
        ///     获取申请人的第一办公地址
        ///     Andrew(2013-05-15)
        /// </summary>
        /// <returns>申请人第一办公地址</returns>
        public string FirstOfficeAddress
        {
            get
            {
                if (AppAddress.Count < 1) return "";
                var add = AppAddress[0] as ApplicantAddress;
                if ((add.s_Type == null || add.s_Type.IndexOf("O") < 0) && (AppAddress.Count > 1))
                    add = AppAddress[1] as ApplicantAddress;
                if ((add.s_Type == null || add.s_Type.IndexOf("O") < 0) && (AppAddress.Count > 2))
                    add = AppAddress[2] as ApplicantAddress;
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
        ///     获取第一办公地址邮编
        ///     Andrew（2013-05-15）
        /// </summary>
        public string FirstZipCode
        {
            get
            {
                if (AppAddress.Count < 1) return "";
                var add = AppAddress[0] as ApplicantAddress;
                if (add.s_Type == null || add.s_Type.IndexOf("O") < 0)
                    add = AppAddress[1] as ApplicantAddress;
                if (add.s_Type == null || add.s_Type.IndexOf("O") < 0)
                    add = AppAddress[2] as ApplicantAddress;
                if (add == null) return "";
                using (var tempUow = new UnitOfWork())
                {
                    return add.s_ZipCode;
                }
            }
        }

        /// #################################################################
        /// <summary>
        ///     获取申请人的第一外文办公地址
        ///     Andrew(2013-05-15)
        /// </summary>
        /// <returns>申请人第一外文办公地址</returns>
        public string FirstOfficeAddress_EN
        {
            get
            {
                if (AppAddress.Count < 1) return "";
                var add = AppAddress[0] as ApplicantAddress;
                if ((add.s_Type == null || add.s_Type.IndexOf("E") < 0) && (AppAddress.Count > 1))
                    add = AppAddress[1] as ApplicantAddress;
                if ((add.s_Type == null || add.s_Type.IndexOf("E") < 0) && (AppAddress.Count > 2))
                    add = AppAddress[2] as ApplicantAddress;
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

        /////
        ///// <summary>
        ///// 获取第一外文办公地址邮编
        ///// Andrew（2013-05-15）
        ///// </summary>
        //public string FirstZipCode_EN
        //{
        //    get
        //    {
        //        if (AppAddress.Count < 1) return "";
        //        ApplicantAddress add = AppAddress[0] as ApplicantAddress;
        //        if (add.s_Type == null || add.s_Type.IndexOf("E") < 0)
        //            add = AppAddress[1] as ApplicantAddress;
        //        if (add.s_Type == null || add.s_Type.IndexOf("E") < 0)
        //            add = AppAddress[2] as ApplicantAddress;
        //        if (add == null) return "";
        //        using (UnitOfWork tempUow = new UnitOfWork())
        //        {
        //            return add.s_ZipCode;
        //        }
        //    }
        //}

        /// <summary>
        ///     获取第一联系人姓名
        ///     Andrew（2013-05-16）
        /// </summary>
        public string FirstContactName
        {
            get
            {
                string sName = string.Empty;
                foreach (ApplicantContact applicantContact in AppContact)
                {
                    if (applicantContact.n_Sequence == 0)
                        sName = applicantContact.ContactName;
                }
                return sName;
            }
        }

        /// #################################################################
        /// <summary>
        ///     获取申请人的英文官方地址。
        ///     Kevin Wang(2010-10-11)
        /// </summary>
        /// <returns>第一申请人英文官方地址</returns>
        public string GetOfficeENAddress()
        {
            foreach (ApplicantAddress appAddress in AppAddress)
            {
                if (appAddress.s_Type == null || appAddress.s_Type.IndexOf("E") < 0) continue;
                return appAddress.s_Street + ", " + appAddress.s_City + ", " + appAddress.s_State;
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
            foreach (ApplicantAddress address in AppAddress)
            {
                if (address.s_Type == null || address.s_Type.ToUpper().IndexOf("O") < 0) continue;
                return address.s_State + " " + address.s_City + " " + address.s_Street;
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
            foreach (ApplicantAddress address in AppAddress)
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
        ///     申请人地址，高级查询使用
        /// </summary>
        public string ApplicantAddress
        {
            get
            {
                string sAdd = string.Empty;
                using (var tempUow = new UnitOfWork())
                {
                    foreach (ApplicantAddress address in AppAddress)
                    {
                        if (address == null) continue;
                        sAdd += (tempUow.GetObjectByKey<CodeCountry>(address.n_Country) == null
                            ? string.Empty
                            : tempUow.GetObjectByKey<CodeCountry>(address.n_Country).s_Name) + " " +
                                address.s_State + " " + address.s_City + " " + address.s_Street + " ";
                    }
                }
                return sAdd;
            }
        }

        /// <summary>
        ///     联系人名，高级查询使用
        /// </summary>
        public string ApplicantContactFirstName
        {
            get
            {
                string sFirstName = string.Empty;
                foreach (ApplicantContact applicantContact in AppContact)
                {
                    if (applicantContact == null) continue;
                    sFirstName += applicantContact.s_FirstName + " ";
                }
                return sFirstName;
            }
        }

        /// <summary>
        ///     联系人姓，高级查询使用
        /// </summary>
        public string ApplicantContactLastName
        {
            get
            {
                string sLastName = string.Empty;
                foreach (ApplicantContact applicantContact in AppContact)
                {
                    if (applicantContact == null) continue;
                    sLastName += applicantContact.s_LastName + " ";
                }
                return sLastName;
            }
        }

        /// <summary>
        ///     申请人联系人地址，高级查询使用
        /// </summary>
        public string ApplicantContactAddress
        {
            get
            {
                string sAdd = string.Empty;
                using (var tempUow = new UnitOfWork())
                {
                    foreach (ApplicantContact applicantContact in AppContact)
                    {
                        if (applicantContact == null) continue;
                        foreach (ApplicantContactAddress applicantContactAddress in applicantContact.AppConAddress)
                        {
                            if (applicantContactAddress == null) continue;
                            sAdd += (tempUow.GetObjectByKey<CodeCountry>(applicantContactAddress.n_Country) == null
                                ? string.Empty
                                : tempUow.GetObjectByKey<CodeCountry>(applicantContactAddress.n_Country).s_Name) + " " +
                                    applicantContactAddress.s_State + " " + applicantContactAddress.s_City + " " +
                                    applicantContactAddress.s_Street + " ";
                        }
                    }
                }
                return sAdd;
            }
        }

        /// <summary>
        ///     申请人联系人电话，高级查询使用
        /// </summary>
        public string ApplicantContactTel
        {
            get
            {
                string sTel = string.Empty;
                foreach (ApplicantContact applicantContact in AppContact)
                {
                    if (applicantContact == null) continue;
                    sTel += applicantContact.s_Phone + " ";
                }
                return sTel;
            }
        }

        /// <summary>
        ///     申请人联系人传真，高级查询使用
        /// </summary>
        public string ApplicantContactFax
        {
            get
            {
                string sFax = string.Empty;
                foreach (ApplicantContact applicantContact in AppContact)
                {
                    if (applicantContact == null) continue;
                    sFax += applicantContact.s_Fax + " ";
                }
                return sFax;
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
using System;
using System.Text;
using System.Windows.Forms;
using DataEntities.Case;
using DataEntities.Config;
using DataEntities.Element.Fee;
using DataEntities.Element.Files;
using DataEntities.Finance.Accounting;
using DataEntities.Finance.Bill;
using DataEntities.Finance.ClaimMoney;
using DataEntities.Finance.Contract;
using DataEntities.Properties;
using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using DevExpress.Xpo.DB;
using Infralution.Localization;

namespace DataEntities.Contact.Client
{
    [Persistent("TCstmr_Client")]
    public class Client : XPLiteObject
    {
        private readonly XPDelayedProperty fdt_CreateDate = new XPDelayedProperty();
        private readonly XPDelayedProperty fdt_DepositEditDate = new XPDelayedProperty();
        private readonly XPDelayedProperty fdt_EditDate = new XPDelayedProperty();
        private readonly XPDelayedProperty fdt_FirstCaseDate = new XPDelayedProperty();
        private readonly XPDelayedProperty fdt_LastCaseDate = new XPDelayedProperty();
        private readonly XPDelayedProperty fn_ApplicantID = new XPDelayedProperty();
        private readonly XPDelayedProperty fn_CoopAgencyID = new XPDelayedProperty();
        private readonly XPDelayedProperty fn_IntroID = new XPDelayedProperty();
        private readonly XPDelayedProperty fn_Language = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_ClientCode = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_Credit = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_Email = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_Facebook = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_Fax = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_IMAddress = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_IPType = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_IsActive = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_IsAllUser = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_Mobile = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_Name = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_NativeName = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_Notes = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_OtherName = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_PayMode = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_Phone = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_Twitter = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_Type = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_Website = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_PriceDesc = new XPDelayedProperty();
        private decimal fn_ClientDeposit;
        private int fn_ClientDepositCurrency;
        

        /// <summary>
        ///     客户账户划拨合计
        /// </summary>
        private decimal fn_ClientDepositTransfer;

        private int fn_ClientID;
        private int fn_Country;
        private int fn_FlowNum;
        private int fn_PatentChargerID;
        private CodeSecurityLevelConfig fn_SecurityLevelID;
        private int fn_TMChargerID;
        private string fs_Area;
        private string fs_City;
        private string fs_Creator;
        private string fs_DepositEditor;
        private string fs_Editor;
        private string fs_Lock;
        private string fs_Locker;
        private string fs_Source;
        private string fs_State;
        private string fs_NotClaimMoney;//不催款
     

        public Client(Session session)
            : base(session)
        {
        }

        public Client()
            : base(Session.DefaultSession)
        {
        }

        [Key(true)]
        public int n_ClientID
        {
            get { return fn_ClientID; }
            set { SetPropertyValue<int>("n_ClientID", ref fn_ClientID, value); }
        }

        [Delayed("fs_Name")]
        [Size(300)]
        public string s_Name
        {
            get { return (string)fs_Name.Value; }
            set { fs_Name.Value = value; }
        }

        [Delayed("fs_NativeName")]
        [Size(200)]
        public string s_NativeName
        {
            get { return (string)fs_NativeName.Value; }
            set { fs_NativeName.Value = value; }
        }

        [Delayed("fs_OtherName")]
        [Size(200)]
        public string s_OtherName
        {
            get { return (string)fs_OtherName.Value; }
            set { fs_OtherName.Value = value; }
        }

        [Delayed("fs_ClientCode")]
        [Size(20)]
        public string s_ClientCode
        {
            get { return (string)fs_ClientCode.Value; }
            set { fs_ClientCode.Value = value; }
        }

        [Delayed("fs_IPType")]
        [Size(50)]
        public string s_IPType
        {
            get { return (string)fs_IPType.Value; }
            set { fs_IPType.Value = value; }
        }

        [Delayed("fs_Type")]
        [Size(50)]
        public string s_Type
        {
            get { return (string)fs_Type.Value; }
            set { fs_Type.Value = value; }
        }

        [Delayed("fs_Credit")]
        [Size(10)]
        public string s_Credit
        {
            get { return (string)fs_Credit.Value; }
            set { fs_Credit.Value = value; }
        }
       
        
        [Delayed("fn_ApplicantID")]
        public int n_ApplicantID
        {
            get
            {
                if (fn_ApplicantID.Value == null)
                {
                    return -1;
                }
                return (int)fn_ApplicantID.Value;
            }
            set { fn_ApplicantID.Value = value; }
        }

        [Delayed("fn_CoopAgencyID")]
        public int n_CoopAgencyID
        {
            get
            {
                if (fn_CoopAgencyID.Value == null)
                {
                    return -1;
                }
                return (int)fn_CoopAgencyID.Value;
            }
            set { fn_CoopAgencyID.Value = value; }
        }

        [Delayed("fn_IntroID")]
        public int n_IntroID
        {
            get
            {
                if (fn_IntroID.Value == null)
                {
                    return -1;
                }
                return (int)fn_IntroID.Value;
            }
            set { fn_IntroID.Value = value; }
        }

        [Delayed("fs_Notes")]
        [Size(800)]
        public string s_Notes
        {
            get { return (string)fs_Notes.Value; }
            set { fs_Notes.Value = value; }
        }

        [Delayed("fn_Language")]
        public int n_Language
        {
            get
            {
                if (fn_Language.Value == null)
                {
                    return -1;
                }
                return (int)fn_Language.Value;
            }
            set { fn_Language.Value = value; }
        }

        public string LanguageCName
        {
            get
            {
                using (var uow = new UnitOfWork())
                {
                    var xpc = new XPCollection(uow, typeof(CodeLanguage))
                    {
                        Criteria = CriteriaOperator.Parse("n_ID =" + n_Language)
                    };
                    if (xpc.Count == 0)
                    {
                        return "";
                    }
                    return ((CodeLanguage)xpc[0]).s_Name;
                }
            }
        }

        [Delayed("fs_IsActive")]
        public string s_IsActive
        {
            get { return (string)fs_IsActive.Value; }
            set { fs_IsActive.Value = value; }
        }

        [Delayed("fdt_FirstCaseDate")]
        public DateTime dt_FirstCaseDate
        {
            get
            {
                if (fdt_FirstCaseDate.Value == null)
                {
                    return DateTime.MinValue;
                }
                return (DateTime)fdt_FirstCaseDate.Value;
            }
            set { fdt_FirstCaseDate.Value = value; }
        }

        [Delayed("fdt_LastCaseDate")]
        public DateTime dt_LastCaseDate
        {
            get
            {
                if (fdt_LastCaseDate.Value == null)
                {
                    return DateTime.MinValue;
                }
                return (DateTime)fdt_LastCaseDate.Value;
            }
            set { fdt_LastCaseDate.Value = value; }
        }

        [Delayed("fs_Phone")]
        [Size(150)]
        public string s_Phone
        {
            get { return (string)fs_Phone.Value; }
            set { fs_Phone.Value = value; }
        }


        [Delayed("fs_PriceDesc")]
        [Size(8000)]
        public string s_PriceDesc
        {
            get { return (string)fs_PriceDesc.Value; }
            set { fs_PriceDesc.Value = value; }
        }
        [Delayed("fs_Mobile")]
        [Size(150)]
        public string s_Mobile
        {
            get { return (string)fs_Mobile.Value; }
            set { fs_Mobile.Value = value; }
        }

        [Delayed("fs_Fax")]
        [Size(150)]
        public string s_Fax
        {
            get { return (string)fs_Fax.Value; }
            set { fs_Fax.Value = value; }
        }

        [Delayed("fs_Email")]
        [Size(300)]
        public string s_Email
        {
            get { return (string)fs_Email.Value; }
            set { fs_Email.Value = value; }
        }

        [Delayed("fs_Website")]
        [Size(300)]
        public string s_Website
        {
            get { return (string)fs_Website.Value; }
            set { fs_Website.Value = value; }
        }

        [Delayed("fs_IMAddress")]
        public string s_IMAddress
        {
            get { return (string)fs_IMAddress.Value; }
            set { fs_IMAddress.Value = value; }
        }

        [Delayed("fs_Facebook")]
        [Size(200)]
        public string s_Facebook
        {
            get { return (string)fs_Facebook.Value; }
            set { fs_Facebook.Value = value; }
        }

        [Delayed("fs_Twitter")]
        [Size(200)]
        public string s_Twitter
        {
            get { return (string)fs_Twitter.Value; }
            set { fs_Twitter.Value = value; }
        }

        [Delayed("fs_PayMode")]
        [Size(2)]
        public string s_PayMode
        {
            get { return (string)fs_PayMode.Value; }
            set { fs_PayMode.Value = value; }
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

        [Delayed("fdt_CreateDate")]
        public DateTime dt_CreateDate
        {
            get
            {
                if (fdt_CreateDate.Value == null)
                {
                    return DateTime.MinValue;
                }
                return (DateTime)fdt_CreateDate.Value;
            }
            set { fdt_CreateDate.Value = value; }
        }

        [Delayed("fdt_EditDate")]
        public DateTime dt_EditDate
        {
            get
            {
                if (fdt_EditDate.Value == null)
                {
                    return DateTime.MinValue;
                }
                return (DateTime)fdt_EditDate.Value;
            }
            set { fdt_EditDate.Value = value; }
        }

        [Delayed("fs_IsAllUser")]
        [Size(1)]
        public string s_IsAllUser
        {
            get { return (string)fs_IsAllUser.Value; }
            set { fs_IsAllUser.Value = value; }
        }

        public int n_PatentChargerID
        {
            get { return fn_PatentChargerID; }
            set { SetPropertyValue<int>("n_PatentChargerID", ref fn_PatentChargerID, value); }
        }

        public int n_FlowNum
        {
            get { return fn_FlowNum; }
            set { SetPropertyValue<int>("n_FlowNum", ref fn_FlowNum, value); }
        }

        public int n_TMChargerID
        {
            get { return fn_TMChargerID; }
            set { SetPropertyValue<int>("n_TMChargerID", ref fn_TMChargerID, value); }
        }

        [Size(100)]
        public string s_Source
        {
            get { return fs_Source; }
            set { SetPropertyValue("s_Source", ref fs_Source, value); }
        }

        public int n_Country
        {
            get { return fn_Country; }
            set { SetPropertyValue<int>("n_Country", ref fn_Country, value); }
        }

        public string s_State
        {
            get { return fs_State; }
            set { SetPropertyValue("s_State", ref fs_State, value); }
        }

        public string s_City
        {
            get { return fs_City; }
            set { SetPropertyValue("s_City", ref fs_City, value); }
        }

        [Size(100)]
        public string s_Area
        {
            get { return fs_Area; }
            set { SetPropertyValue("s_Area", ref fs_Area, value); }
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

        [Size(50)]
        public string s_DepositEditor
        {
            get { return fs_DepositEditor; }
            set { SetPropertyValue("s_DepositEditor", ref fs_DepositEditor, value); }
        }


        [Size(2)]
        public string s_NotClaimMoney
        {
            get { return fs_NotClaimMoney; }
            set { SetPropertyValue("s_NotClaimMoney", ref fs_NotClaimMoney, value); }
        }

        [Delayed("fdt_DepositEditDate")]
        public DateTime dt_DepositEditDate
        {
            get
            {
                if (fdt_DepositEditDate.Value == null)
                {
                    return DateTime.MinValue;
                }
                return (DateTime)fdt_DepositEditDate.Value;
            }
            set { fdt_DepositEditDate.Value = value; }
        }

        //此字段只是用于PA导入数据
        [NonPersistent]
        public string PA_ClientID { get; set; }

        //public new void Save()
        //{
        //    base.Save();
        //    XPCollection caseXpc = new XPCollection(Session, typeof(BasicCase)) {
        //        Criteria = CriteriaOperator.Parse("TheClient.n_ClientID = ? ", n_ClientID)
        //    };
        //    foreach (BasicCase basicCase in caseXpc) {
        //        if (basicCase == null) continue;
        //        XPCollection feeInCaseXpc = new XPCollection(Session, typeof(FeeInCase)) {
        //            Criteria = CriteriaOperator.Parse("TheCase.n_CaseID = ? ", basicCase.n_CaseID)
        //        };
        //        foreach (FeeInCase feeInCase in feeInCaseXpc) {
        //            if (feeInCase == null || feeInCase.TheFee == null) continue;
        //            feeInCase.TheFee.Save();
        //        }
        //    }
        //}

        [Aggregated, Association("ClientContract", typeof(Contract))]
        public XPCollection ClientContract
        {
            get { return GetCollection("ClientContract"); }
        }

        [Aggregated, Association("ClientAddress", typeof(ClientAddress))]
        public XPCollection ClientAddress
        {
            get { return GetCollection("ClientAddress"); }
        }

        [Aggregated, Association("ClientContact", typeof(ClientContact))]
        public XPCollection ClientContact
        {
            get { return GetCollection("ClientContact"); }
        }

        [Aggregated, Association("Client-CaseClients", typeof(CaseClients))]
        public XPCollection CaseClients
        {
            get { return GetCollection("CaseClients"); }
        }

        [Aggregated, Association("ClientFeePolicy", typeof(ClientFeePolicy))]
        public XPCollection ClientFeePolicy
        {
            get { return GetCollection("ClientFeePolicy"); }
        }

        [Aggregated, Association("ClientFeeCombine", typeof(FeePreferentialCombine))]
        public XPCollection ClientFeeCombine
        {
            get { return GetCollection("ClientFeeCombine"); }
        }

        [Aggregated, Association("Client-BasicCases", typeof(BasicCase))]
        public XPCollection BasicCases
        {
            get { return GetCollection("BasicCases"); }
        }

        [Aggregated, Association("Client-Bills", typeof(Bill))]
        public XPCollection Bills
        {
            get { return GetCollection("Bills"); }
        }

        [Aggregated, Association("Client-CameMoney", typeof(CameMoney))]
        public XPCollection CameMoney
        {
            get { return GetCollection("CameMoney"); }
        }

        [Aggregated, Association("Client-UserClients", typeof(UserClient))]
        public XPCollection UserClients
        {
            get { return GetCollection("UserClients"); }
        }

        [Aggregated, Association("Client-RoleClients", typeof(RoleClient))]
        public XPCollection RoleClients
        {
            get { return GetCollection("RoleClients"); }
        }

        [Aggregated, Association("Client-ChangeHistory", typeof(ClientChangeHistory))]
        public XPCollection ChangeHistory
        {
            get { return GetCollection("ChangeHistory"); }
        }

        [Aggregated, Association("Client-ABillHedge", typeof(ABillHedge))]
        public XPCollection ABillHedges
        {
            get { return GetCollection("ABillHedges"); }
        }


        [Aggregated, Association("Client-CodeCycleConfig", typeof(CodeCycleConfig))]
        public XPCollection CodeCycleConfigs
        {
            get { return GetCollection("CodeCycleConfigs"); }
        }

        [Aggregated, Association("Client-ClaimMoney", typeof(ClaimMoney))]
        public XPCollection ClaimMoneys
        {
            get { return GetCollection("ClaimMoneys"); }
        }


        [Aggregated, Association("Client-BillPay")]
        public XPCollection<BillPay> BillPayInfo
        {
            get { return GetCollection<BillPay>("BillPayInfo"); }
        }

        [Aggregated, Association("Client-BaseFile", typeof(BaseFile))]
        public XPCollection<BaseFile> BaseFiles
        {
            get { return GetCollection<BaseFile>("BaseFiles"); }
        }

        [Aggregated, Association("FileCLient-ClientFile", typeof(BaseFile))]
        public XPCollection<BaseFile> ClientFiles
        {
            get { return GetCollection<BaseFile>("ClientFiles"); }
        }

        public int UserClientsCount
        {
            get { return UserClients.Count; }
        }

        public int RoleClientsCount
        {
            get { return RoleClients.Count; }
        }

        [Delayed]
        public string CAndEName
        {
            get { return s_Name + "[" + (string.IsNullOrEmpty(s_ClientCode) ? "" : s_ClientCode) + "]"; }
        }

        public decimal n_ClientDeposit
        {
            get { return fn_ClientDeposit; }
            set { SetPropertyValue<decimal>("n_ClientDeposit", ref fn_ClientDeposit, value); }
        }

        /// <summary>
        ///     案源人名称
        /// </summary>
        public string sIntoducerName
        {
            get
            {
                return new UnitOfWork().GetObjectByKey<Introducer.Introducer>(n_IntroID) == null
                    ? ""
                    : new UnitOfWork().GetObjectByKey<Introducer.Introducer>(n_IntroID).Name;
            }
        }


        /// <summary>
        ///     专利负责人
        /// </summary>
        public string sPatentChargeName
        {
            get
            {
                return new UnitOfWork().GetObjectByKey<CodeEmployee>(n_PatentChargerID) == null
                    ? ""
                    : new UnitOfWork().GetObjectByKey<CodeEmployee>(n_PatentChargerID).s_Name;
            }
        }

        /// <summary>
        ///     商品负责人
        /// </summary>
        public string sTMChargeName
        {
            get
            {
                return new UnitOfWork().GetObjectByKey<CodeEmployee>(n_TMChargerID) == null
                    ? ""
                    : new UnitOfWork().GetObjectByKey<CodeEmployee>(n_TMChargerID).s_Name;
            }
        }


        public decimal n_ClientDepositTransfer
        {
            get { return fn_ClientDepositTransfer; }
            set { SetPropertyValue<decimal>("n_ClientDepositTransfer", ref fn_ClientDepositTransfer, value); }
        }


        public decimal n_ClientDepositBalance
        {
            get
            {
                decimal n_Blance = n_ClientDeposit - n_ClientDepositTransfer;
                if (n_Blance == 0)
                {
                    return 0;
                }
                return Math.Round(n_Blance, 2);
            }
        }

        public int n_ClientDepositCurrency
        {
            get { return fn_ClientDepositCurrency; }
            set { SetPropertyValue<int>("n_ClientDepositCurrency", ref fn_ClientDepositCurrency, value); }
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

        [NonPersistent]
        public Guid GUID { get; set; }

        //int fn_SecurityLevelID;//密级
        //public int n_SecurityLevelID
        //{
        //    get { return fn_SecurityLevelID; }
        //    set { SetPropertyValue<int>("n_SecurityLevelID", ref fn_SecurityLevelID, value); }
        //}

        int fn_PPreferentialCombineID;
        public int n_PPreferentialCombineID
        {
            get { return fn_PPreferentialCombineID; }
            set { SetPropertyValue<int>("n_PPreferentialCombineID", ref fn_PPreferentialCombineID, value); }
        }

        int fn_TPreferentialCombineID;
        public int n_TPreferentialCombineID
        {
            get { return fn_TPreferentialCombineID; }
            set { SetPropertyValue<int>("n_TPreferentialCombineID", ref fn_TPreferentialCombineID, value); }
        }

        int fn_CPreferentialCombineID;
        public int n_CPreferentialCombineID
        {
            get { return fn_CPreferentialCombineID; }
            set { SetPropertyValue<int>("n_CPreferentialCombineID", ref fn_CPreferentialCombineID, value); }
        }

        int fn_DPreferentialCombineID;
        public int n_DPreferentialCombineID
        {
            get { return fn_DPreferentialCombineID; }
            set { SetPropertyValue<int>("n_DPreferentialCombineID", ref fn_DPreferentialCombineID, value); }
        }

        int fn_OPreferentialCombineID;
        public int n_OPreferentialCombineID
        {
            get { return fn_OPreferentialCombineID; }
            set { SetPropertyValue<int>("n_OPreferentialCombineID", ref fn_OPreferentialCombineID, value); }
        }

        [Association("SecurityLevel-Clients")]
        [Persistent("n_SecurityLevelID")]
        public CodeSecurityLevelConfig TheSecurityLevel
        {
            get { return fn_SecurityLevelID; }
            set { SetPropertyValue("n_SecurityLevelID", ref fn_SecurityLevelID, value); }
        }

        [Aggregated, Association("Client-Demands")]
        public XPCollection<Demand.Demand> Demands
        {
            get { return GetCollection<Demand.Demand>("Demands"); }
        }

        #region 自定义方法

        /// #################################################################
        /// <summary>
        ///     获取客户的办公地址。 取得到的第一个办公地址
        ///     Kevin Wang(2010-10-11)
        /// </summary>
        /// <returns>客户办公地址</returns>
        public string GetOfficeCNAddress()
        {
            foreach (ClientAddress address in ClientAddress)
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
        ///     获取客户的办公英文地址。 取得到的第一个办公地址
        ///     Kevin Wang(2010-10-11)
        /// </summary>
        /// <returns>客户办公英文地址</returns>
        public string GetOfficeENAddress()
        {
            foreach (ClientAddress address in ClientAddress)
            {
                if (address.s_Type != null && address.s_Type.ToUpper().IndexOf("E") >= 0)
                {
                    using (var tempUow = new UnitOfWork())
                    {
                        var country = tempUow.GetObjectByKey<CodeCountry>(address.n_Country);
                        return (!string.IsNullOrEmpty(address.s_Street) ? address.s_Street + ", " : "") +
                               (!string.IsNullOrEmpty(address.s_City) ? address.s_City + ", " : "") +
                               (!string.IsNullOrEmpty(address.s_State) ? address.s_State + ", " : "") +
                               (country == null ? "" : country.s_Name);
                    }
                }
            }
            return "";
        }

        /// #################################################################
        /// <summary>
        ///     获取客户的办公邮编。 取得到的第一个办公地址
        ///     Kevin Wang(2010-10-11)
        /// </summary>
        /// <returns>客户办公邮编</returns>
        public string GetOfficeZipCode()
        {
            foreach (ClientAddress address in ClientAddress)
            {
                if (address.s_Type != null && address.s_Type.ToUpper().IndexOf("O") >= 0)
                {
                    return address.s_ZipCode;
                }
            }
            return "";
        }

        #endregion

        #region 自定义字段

        /// <summary>
        ///     获取第一联系人
        /// </summary>
        //[NonPersistent]
        public ClientContact FisrtClientContact
        {
            get
            {
                if (ClientContact == null || ClientContact.Count < 1) return null;
                ClientContact.Sorting = new SortingCollection(new SortProperty("n_Sequence", SortingDirection.Ascending));
                return ((ClientContact)ClientContact[0]);
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
                        CriteriaOperator.Parse("TheClient.n_ClientID =?", n_ClientID)));
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
                        CriteriaOperator.Parse("TheClient.n_ClientID =? AND s_IPType ='P'", n_ClientID)));
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
                        CriteriaOperator.Parse("TheClient.n_ClientID =? AND s_IPType ='T'", n_ClientID)));
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
                        CriteriaOperator.Parse("TheClient.n_ClientID =? AND s_IPType ='C'", n_ClientID)));
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
                        CriteriaOperator.Parse("TheClient.n_ClientID =? AND s_IPType ='D'", n_ClientID)));
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
                        CriteriaOperator.Parse("TheClient.n_ClientID =? AND s_IPType ='O'", n_ClientID)));
            }
        }

        /// #################################################################
        /// <summary>
        ///     获取客户的第一办公地址
        ///     Andrew(2013-05-15)
        /// </summary>
        /// <returns>客户第一办公地址</returns>
        public string FirstOfficeAddress
        {
            get
            {
                if (ClientAddress.Count < 1) return "";
                var add = ClientAddress[0] as ClientAddress;
                if (add.s_Type == null || add.s_Type.IndexOf("O") < 0)
                    add = ClientAddress[1] as ClientAddress;
                if (add.s_Type == null || add.s_Type.IndexOf("O") < 0)
                    add = ClientAddress[2] as ClientAddress;
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
        ///     获取客户的第一外文地址
        ///     Andrew(2013-05-15)
        /// </summary>
        /// <returns>客户第一外文地址</returns>
        public string FirstOfficeAddress_EN
        {
            get
            {
                if (ClientAddress.Count < 1) return "";
                var add = ClientAddress[0] as ClientAddress;
                if (add.s_Type == null || add.s_Type.IndexOf("E") < 0)
                    add = ClientAddress[1] as ClientAddress;
                if (add.s_Type == null || add.s_Type.IndexOf("E") < 0)
                    add = ClientAddress[2] as ClientAddress;
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
        ///     获取客户第一办公地址邮编
        ///     Andrew(2013-05-15)
        /// </summary>
        /// <returns>客户第一办公地址邮编</returns>
        public string FirstZipCode
        {
            get
            {
                if (ClientAddress.Count < 1) return "";
                var add = ClientAddress[0] as ClientAddress;
                if (add.s_Type == null || add.s_Type.IndexOf("O") < 0)
                    add = ClientAddress[1] as ClientAddress;
                if (add.s_Type == null || add.s_Type.IndexOf("O") < 0)
                    add = ClientAddress[2] as ClientAddress;
                if (add == null) return "";
                using (var tempUow = new UnitOfWork())
                {
                    return add.s_ZipCode;
                }
            }
        }

        /////#################################################################
        ///// <summary>
        ///// 获取客户第一外文办公地址邮编
        ///// Andrew(2013-05-15)
        ///// </summary>
        ///// <returns>客户第一外文办公地址邮编</returns>
        //public string FirstZipCode_EN
        //{
        //    get
        //    {
        //        if (ClientAddress.Count < 1) return "";
        //        ClientAddress add = ClientAddress[0] as ClientAddress;
        //        if (add.s_Type == null || add.s_Type.IndexOf("E") < 0)
        //            add = ClientAddress[1] as ClientAddress;
        //        if (add.s_Type == null || add.s_Type.IndexOf("E") < 0)
        //            add = ClientAddress[2] as ClientAddress;
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
                foreach (ClientContact clientContact in ClientContact)
                {
                    if (clientContact.n_Sequence == 0)
                        sName = clientContact.ContactName;
                }
                return sName;
            }
        }

        #endregion

        #region 高级查询所用的特殊字段

        /// <summary>
        ///     客户地址，高级查询使用
        /// </summary>
        public string ClientAddresses
        {
            get
            {
                string sAdd = string.Empty;
                using (var tempUow = new UnitOfWork())
                {
                    foreach (ClientAddress clientAddress in ClientAddress)
                    {
                        if (clientAddress == null) continue;
                        sAdd += (tempUow.GetObjectByKey<CodeCountry>(clientAddress.n_Country) == null
                            ? string.Empty
                            : tempUow.GetObjectByKey<CodeCountry>(clientAddress.n_Country).s_Name) + " " +
                                clientAddress.s_State + " " + clientAddress.s_City + " " + clientAddress.s_Street + " ";
                    }
                }
                return sAdd;
            }
        }

        /// <summary>
        ///     客户邮编，高级查询使用
        /// </summary>
        public string ClientZipCode
        {
            get
            {
                string sZipCode = string.Empty;
                foreach (ClientAddress clientAddress in ClientAddress)
                {
                    if (clientAddress == null) continue;
                    sZipCode += clientAddress.s_ZipCode + " ";
                }
                return sZipCode;
            }
        }

        /// <summary>
        ///     客户联系人名，高级查询使用
        /// </summary>
        public string ClientContactFirstName
        {
            get
            {
                string sFirstName = string.Empty;
                foreach (ClientContact clientContact in ClientContact)
                {
                    if (clientContact == null) continue;
                    sFirstName += clientContact.s_FirstName + " ";
                }
                return sFirstName;
            }
        }

        /// <summary>
        ///     客户联系人姓，高级查询使用
        /// </summary>
        public string ClientContactLastName
        {
            get
            {
                string sLastName = string.Empty;
                foreach (ClientContact clientContact in ClientContact)
                {
                    if (clientContact == null) continue;
                    sLastName += clientContact.s_LastName + " ";
                }
                return sLastName;
            }
        }

        /// <summary>
        ///     客户联系人电话，高级查询使用
        /// </summary>
        public string ClientContactTel
        {
            get
            {
                string sTel = string.Empty;
                foreach (ClientContact clientContact in ClientContact)
                {
                    if (clientContact == null) continue;
                    sTel += clientContact.s_Phone + " ";
                }
                return sTel;
            }
        }

        /// <summary>
        ///     客户联系人地址，高级查询使用
        /// </summary>
        public string ClientContactAddress
        {
            get
            {
                string sAdd = string.Empty;
                using (var tempUow = new UnitOfWork())
                {
                    foreach (ClientContact clientContact in ClientContact)
                    {
                        if (clientContact == null) continue;
                        foreach (ClientContactAddress clientContactAddress in clientContact.ClientConAddress)
                        {
                            if (clientContactAddress == null) continue;
                            sAdd += (tempUow.GetObjectByKey<CodeCountry>(clientContactAddress.n_Country) == null
                                ? string.Empty
                                : tempUow.GetObjectByKey<CodeCountry>(clientContactAddress.n_Country).s_Name) + " " +
                                    clientContactAddress.s_State + " " + clientContactAddress.s_City + " " +
                                    clientContactAddress.s_Street + " ";
                        }
                    }
                }
                return sAdd;
            }
        }

        /// <summary>
        ///     客户联系人邮编，高级查询使用
        /// </summary>
        public string ClientContactZipCode
        {
            get
            {
                string sZipCode = string.Empty;
                foreach (ClientContact clientContact in ClientContact)
                {
                    if (clientContact == null) continue;
                    foreach (ClientContactAddress clientContactAddress in clientContact.ClientConAddress)
                    {
                        if (clientContactAddress == null) continue;
                        sZipCode += clientContactAddress.s_ZipCode + " ";
                    }
                }
                return sZipCode;
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
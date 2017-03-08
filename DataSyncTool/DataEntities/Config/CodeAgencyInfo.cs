using System;
using DevExpress.Xpo;

namespace DataEntities.Config
{
    [Persistent("TCode_AgencyInfo")]
    public class CodeAgencyInfo : XPLiteObject
    {
        private DateTime fdt_CreateDate;
        private DateTime fdt_EditDate;
        private int fn_ClientCodeFlowNumCount;
        private int fn_Country;
        private int fn_DefaultCurr;
        private int fn_DefaultLan;
        private decimal fn_GSTAgent;
        private decimal fn_GSTDisb;
        private int fn_ID;
        private decimal fn_TaxCN;
        private string fs_AgentCode;
        private string fs_City;
        private string fs_ClientCodeRule;
        private string fs_Contact;
        private string fs_EmailName;
        private string fs_EmailPwd;
        private string fs_EmailServer;
        private string fs_EmailUser;
        private string fs_Fax;
        private string fs_GSTForNativeClient;

        private string fs_Name;
        private string fs_NationalDefense;
        private string fs_Notes;
        private string fs_OtherAddress;
        private string fs_OtherContact;

        private string fs_OtherName;
        private string fs_Port;
        private byte[] fs_Signature;
        private string fs_State;
        private string fs_Street;
        private string fs_Tel;

        private string fs_TmOtherName;
        private string fs_UnifiedSend;
        private string fs_UseHolidayConfig;
        private string fs_ZipCode;

        string fs_WeekEndForeColor;
        string fs_WeekEndBackColor;
        string fs_WorkWeekEndForeColor;
        string fs_WorkWeekEndBackColor;

        private string fs_CorpID;
        private string fs_Secret;

        private string fs_CustomizeCode;

        private int fn_AnnualFeeNotificationDay;

        private readonly XPDelayedProperty fimg_Logo = new XPDelayedProperty();

        public CodeAgencyInfo(Session session)
            : base(session)
        {
        }

        public CodeAgencyInfo()
            : base(Session.DefaultSession)
        {
        }

        [Key(true)]
        public int n_ID
        {
            get { return fn_ID; }
            set { SetPropertyValue<int>("n_ID", ref fn_ID, value); }
        }

        [Size(300)]
        public string s_Name
        {
            get { return fs_Name; }
            set { SetPropertyValue("s_Name", ref fs_Name, value); }
        }

        [Size(200)]
        public string s_OtherName
        {
            get { return fs_OtherName; }
            set { SetPropertyValue("s_OtherName", ref fs_OtherName, value); }
        }

        [Size(200)]
        public string s_TmOtherName
        {
            get { return fs_TmOtherName; }
            set { SetPropertyValue("s_TmOtherName", ref fs_TmOtherName, value); }
        }

        public int n_DefaultCurr
        {
            get { return fn_DefaultCurr; }
            set { SetPropertyValue<int>("n_DefaultCurr", ref fn_DefaultCurr, value); }
        }

        public int n_DefaultLan
        {
            get { return fn_DefaultLan; }
            set { SetPropertyValue<int>("n_DefaultLan", ref fn_DefaultLan, value); }
        }

        [Size(200)]
        public string s_Contact
        {
            get { return fs_Contact; }
            set { SetPropertyValue("s_Contact", ref fs_Contact, value); }
        }

        [Size(200)]
        public string s_OtherContact
        {
            get { return fs_OtherContact; }
            set { SetPropertyValue("s_OtherContact", ref fs_OtherContact, value); }
        }

        [Size(50)]
        public string s_AgentCode
        {
            get { return fs_AgentCode; }
            set { SetPropertyValue("s_AgentCode", ref fs_AgentCode, value); }
        }

        [Size(150)]
        public string s_Tel
        {
            get { return fs_Tel; }
            set { SetPropertyValue("s_Tel", ref fs_Tel, value); }
        }

        [Size(150)]
        public string s_Fax
        {
            get { return fs_Fax; }
            set { SetPropertyValue("s_Fax", ref fs_Fax, value); }
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

        [Size(300)]
        public string s_Street
        {
            get { return fs_Street; }
            set { SetPropertyValue("s_Street", ref fs_Street, value); }
        }

        [Size(50)]
        public string s_ZipCode
        {
            get { return fs_ZipCode; }
            set { SetPropertyValue("s_ZipCode", ref fs_ZipCode, value); }
        }

        [Size(500)]
        public string s_OtherAddress
        {
            get { return fs_OtherAddress; }
            set { SetPropertyValue("s_OtherAddress", ref fs_OtherAddress, value); }
        }

        [Size(800)]
        public string s_Notes
        {
            get { return fs_Notes; }
            set { SetPropertyValue("s_Notes", ref fs_Notes, value); }
        }

        [Size(50)]
        public string s_EmailName
        {
            get { return fs_EmailName; }
            set { SetPropertyValue("s_EmailName", ref fs_EmailName, value); }
        }

        [Size(50)]
        public string s_EmailServer
        {
            get { return fs_EmailServer; }
            set { SetPropertyValue("s_EmailServer", ref fs_EmailServer, value); }
        }

        [Size(50)]
        public string s_Port
        {
            get { return fs_Port; }
            set { SetPropertyValue("s_Port", ref fs_Port, value); }
        }

        [Size(50)]
        public string s_EmailUser
        {
            get { return fs_EmailUser; }
            set { SetPropertyValue("s_EmailUser", ref fs_EmailUser, value); }
        }

        [Size(200)]
        public string s_EmailPwd
        {
            get { return fs_EmailPwd; }
            set { SetPropertyValue("s_EmailPwd", ref fs_EmailPwd, value); }
        }

        public byte[] s_Signature
        {
            get { return fs_Signature; }
            set { SetPropertyValue("s_Signature", ref fs_Signature, value); }
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

        public decimal n_GSTAgent
        {
            get { return fn_GSTAgent; }
            set { SetPropertyValue<decimal>("n_GSTAgent", ref fn_GSTAgent, value); }
        }

        public decimal n_GSTDisb
        {
            get { return fn_GSTDisb; }
            set { SetPropertyValue<decimal>("n_GSTDisb", ref fn_GSTDisb, value); }
        }

        public decimal n_TaxCN
        {
            get { return fn_TaxCN; }
            set { SetPropertyValue<decimal>("n_TaxCN", ref fn_TaxCN, value); }
        }

        public int n_AnnualFeeNotificationDay
        {
            get { return fn_AnnualFeeNotificationDay; }
            set { SetPropertyValue<int>("n_AnnualFeeNotificationDay", ref fn_AnnualFeeNotificationDay, value); }
        }

        

        [Size(1)]
        public string s_GSTForNativeClient
        {
            get { return fs_GSTForNativeClient; }
            set { SetPropertyValue("s_GSTForNativeClient", ref fs_GSTForNativeClient, value); }
        }

        public string s_ClientCodeRule
        {
            get { return fs_ClientCodeRule; }
            set { SetPropertyValue("s_ClientCodeRule", ref fs_ClientCodeRule, value); }
        }

        public int n_ClientCodeFlowNumCount
        {
            get { return fn_ClientCodeFlowNumCount; }
            set { SetPropertyValue<int>("n_ClientCodeFlowNumCount", ref fn_ClientCodeFlowNumCount, value); }
        }

        public string s_NationalDefense
        {
            get { return fs_NationalDefense; }
            set { SetPropertyValue("s_NationalDefense", ref fs_NationalDefense, value); }
        }

        public string s_UnifiedSend
        {
            get { return fs_UnifiedSend; }
            set { SetPropertyValue("s_UnifiedSend", ref fs_UnifiedSend, value); }
        }
         [Size(1)]
        public string s_UseHolidayConfig
        {
            get { return fs_UseHolidayConfig; }
            set { SetPropertyValue("s_UseHolidayConfig", ref fs_UseHolidayConfig, value); }
        }

        [Size(20)]
        public string s_WeekEndForeColor
        {
            get { return fs_WeekEndForeColor; }
            set { SetPropertyValue<string>("s_WeekEndForeColor", ref fs_WeekEndForeColor, value); }
        }

        [Size(20)]
        public string s_WeekEndBackColor
        {
            get { return fs_WeekEndBackColor; }
            set { SetPropertyValue<string>("s_WeekEndBackColor", ref fs_WeekEndBackColor, value); }
        }

        [Size(20)]
        public string s_WorkWeekEndForeColor
        {
            get { return fs_WorkWeekEndForeColor; }
            set { SetPropertyValue<string>("s_WorkWeekEndForeColor", ref fs_WorkWeekEndForeColor, value); }
        }

        [Size(20)]
        public string s_WorkWeekEndBackColor
        {
            get { return fs_WorkWeekEndBackColor; }
            set { SetPropertyValue<string>("s_WorkWeekEndBackColor", ref fs_WorkWeekEndBackColor, value); }
        }
        [NonPersistent]
        public string CAddress
        {
            get
            {
                using (var tempUow = new UnitOfWork())
                {
                    var codeCountry = tempUow.GetObjectByKey<CodeCountry>(n_Country);
                    return (codeCountry == null ? string.Empty : codeCountry.s_Name) + s_State + s_City + s_Street;
                }
            }
        }

        [Size(50)]
        public string s_CorpID
        {
            get { return fs_CorpID; }
            set { SetPropertyValue("s_CorpID", ref fs_CorpID, value); }
        }

        [Size(200)]
        public string s_Secret
        {
            get { return fs_Secret; }
            set { SetPropertyValue("s_Secret", ref fs_Secret, value); }
        }

        [Size(50)]
        public string s_CustomizeCode
        {
            get { return fs_CustomizeCode; }
            set { SetPropertyValue("s_CustomizeCode", ref fs_CustomizeCode, value); }
        }

        [Delayed("fimg_Logo")]
        public byte[] img_Logo
        {
            get { return (byte[])fimg_Logo.Value; }
            set { fimg_Logo.Value = value; }
        }

        #region 自定义方法

        /// <summary>
        ///     获取国家
        /// </summary>
        public string GetCodeAgencyCountry
        {
            get
            {
                using (var tempUow = new UnitOfWork())
                {
                    var codeCountry = tempUow.GetObjectByKey<CodeCountry>(n_Country);
                    return (codeCountry == null ? string.Empty : codeCountry.s_Name);
                }
            }
        }

        #endregion

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}
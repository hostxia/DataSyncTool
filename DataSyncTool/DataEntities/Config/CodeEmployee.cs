using System;
using System.Linq;
using DataEntities.Case;
using DataEntities.Config.Right;
using DataEntities.Contact.Client;
using DataEntities.Element.Files;
using DataEntities.Properties;
using DataEntities.Remind;
using DataEntities.Statistic;
using DevExpress.Xpo;

namespace DataEntities.Config
{
    [Persistent("TCode_Employee")]
    public class CodeEmployee : XPLiteObject
    {
        private DateTime fdt_CreateDate;
        private DateTime fdt_EditDate;
        private DateTime fdt_Lock;
        private DateTime fdt_ModifyPassword;
        private decimal fn_AttorneyPer;
        private decimal fn_ChargeRate1;
        private decimal fn_ChargeRate2;
        private int fn_Currency1;
        private int fn_Currency2;
        private int fn_ID;
        private CodeSecurityLevelConfig fn_SecurityLevelID;
        private bool fn_Valid;
        private string fs_AllowCaseConsoleAllData;
        private string fs_AllowCustomEmail;
        private string fs_AllowCaseConsoleDepartmentData;
        private string fs_AllowCaseConsoleMyData;
        private string fs_AllowViewDepartData;
        private string fs_CC;
        private string fs_CanCC;
        private string fs_CertificateNo;
        private string fs_Contact;
        private string fs_DataRight;
        private string fs_Email;
        private string fs_EmailName;
        private string fs_EmailPwd;
        private string fs_EmailServer;
        private string fs_EmailUser;
        private string fs_Facebook;
        private string fs_Fax;
        private string fs_IMAddress;
        private string fs_IPType;
        private string fs_InternalCode;
        private string fs_Mobile;
        private string fs_Name;
        private string fs_Notes;
        private string fs_OtherName;
        private string fs_Password;
        private string fs_Phone;
        private string fs_Port;

        private string fs_DefaultIPType;

        private string fs_Role;
        private byte[] fs_Signature;
        private string fs_Twitter;
        private string fs_UserName;
        private byte[] fimg_MainOrigImg;
        private byte[] fimg_MainThumbnail;
        [Key(true)]
        public int n_ID
        {
            get { return fn_ID; }
            set { SetPropertyValue<int>("n_ID", ref fn_ID, value); }
        }

        [Size(50)]
        public string s_Role
        {
            get { return fs_Role; }
            set { SetPropertyValue("s_Role", ref fs_Role, value); }
        }

        [Size(50)]
        public string s_IPType
        {
            get { return fs_IPType; }
            set { SetPropertyValue("s_IPType", ref fs_IPType, value); }
        }

        [Size(50)]
        public string s_Name
        {
            get { return fs_Name; }
            set { SetPropertyValue("s_Name", ref fs_Name, value); }
        }

        [Size(50)]
        public string s_OtherName
        {
            get { return fs_OtherName; }
            set { SetPropertyValue("s_OtherName", ref fs_OtherName, value); }
        }

        [Size(4)]
        public string s_InternalCode
        {
            get { return fs_InternalCode; }
            set { SetPropertyValue("s_InternalCode", ref fs_InternalCode, value); }
        }

        [Size(20)]
        public string s_CertificateNo
        {
            get { return fs_CertificateNo; }
            set { SetPropertyValue("s_CertificateNo", ref fs_CertificateNo, value); }
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

        public byte[] img_MainOrigImg
        {
            get { return fimg_MainOrigImg; }
            set { fimg_MainOrigImg = value; }
        }
        public byte[] img_MainThumbnail
        {
            get { return fimg_MainThumbnail; }
            set { fimg_MainThumbnail = value; }
        }
        [Size(800)]
        public string s_Notes
        {
            get { return fs_Notes; }
            set { SetPropertyValue("s_Notes", ref fs_Notes, value); }
        }

        public decimal n_ChargeRate1
        {
            get { return fn_ChargeRate1; }
            set { SetPropertyValue<decimal>("n_ChargeRate1", ref fn_ChargeRate1, value); }
        }

        public int n_Currency1
        {
            get { return fn_Currency1; }
            set { SetPropertyValue<int>("n_Currency1", ref fn_Currency1, value); }
        }

        public decimal n_ChargeRate2
        {
            get { return fn_ChargeRate2; }
            set { SetPropertyValue<decimal>("n_ChargeRate2", ref fn_ChargeRate2, value); }
        }

        public int n_Currency2
        {
            get { return fn_Currency2; }
            set { SetPropertyValue<int>("n_Currency2", ref fn_Currency2, value); }
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

        //IPSpace R1.3.0.0 新增的字段

        [Size(50)]
        public string s_UserName
        {
            get { return fs_UserName; }
            set { SetPropertyValue("s_UserName", ref fs_UserName, value); }
        }

        [Size(50)]
        public string s_Password
        {
            get { return fs_Password; }
            set { SetPropertyValue("s_Password", ref fs_Password, value); }
        }

        [Size(100)]
        public string s_EmailName
        {
            get { return fs_EmailName; }
            set { SetPropertyValue("s_EmailName", ref fs_EmailName, value); }
        }

        [Size(100)]
        public string s_EmailServer
        {
            get { return fs_EmailServer; }
            set { SetPropertyValue("s_EmailServer", ref fs_EmailServer, value); }
        }

        [Size(100)]
        public string s_Port
        {
            get { return fs_Port; }
            set { SetPropertyValue("s_Port", ref fs_Port, value); }
        }

        [Size(1)]
        public string s_DefaultIPType
        {
            get { return fs_DefaultIPType; }
            set { SetPropertyValue("s_DefaultIPType", ref fs_DefaultIPType, value); }
        }

        [Size(100)]
        public string s_EmailUser
        {
            get { return fs_EmailUser; }
            set { SetPropertyValue("s_EmailUser", ref fs_EmailUser, value); }
        }

        [Size(100)]
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

        [Size(100)]
        public string s_DataRight
        {
            get { return fs_DataRight; }
            set { SetPropertyValue("s_DataRight", ref fs_DataRight, value); }
        }

        public decimal n_AttorneyPer
        {
            get { return fn_AttorneyPer; }
            set { SetPropertyValue<decimal>("n_AttorneyPer", ref fn_AttorneyPer, value); }
        }

        [Size(1)]
        public string s_AllowViewDepartData
        {
            get { return fs_AllowViewDepartData; }
            set { SetPropertyValue("s_AllowViewDepartData", ref fs_AllowViewDepartData, value); }
        }

        [Size(1)]
        public string s_AllowCaseConsoleMyData
        {
            get { return fs_AllowCaseConsoleMyData; }
            set { SetPropertyValue("s_AllowCaseConsoleMyData", ref fs_AllowCaseConsoleMyData, value); }
        }

        [Size(1)]
        public string s_AllowCaseConsoleDepartmentData
        {
            get { return fs_AllowCaseConsoleDepartmentData; }
            set { SetPropertyValue("s_AllowCaseConsoleDepartmentData", ref fs_AllowCaseConsoleDepartmentData, value); }
        }

        [Size(1)]
        public string s_AllowCaseConsoleAllData
        {
            get { return fs_AllowCaseConsoleAllData; }
            set { SetPropertyValue("s_AllowCaseConsoleAllData", ref fs_AllowCaseConsoleAllData, value); }
        }

        [Size(500)]
        public string s_CC
        {
            get { return fs_CC; }
            set { SetPropertyValue("s_CC", ref fs_CC, value); }
        }

        [Size(1)]
        public string s_CanCC
        {
            get { return fs_CanCC; }
            set { SetPropertyValue("s_CanCC", ref fs_CanCC, value); }
        }

        [Size(1)]
        public bool n_Valid
        {
            get { return fn_Valid; }
            set { SetPropertyValue("n_Valid", ref fn_Valid, value); }
        }

        [NonPersistent]
        public string s_Valid
        {
            get { return n_Valid ? "是" : "否"; }
        }
        /// <summary>
        ///     将 BOOL 的值转换成文字 用在案件处理信息 选择处理人  列表显示的时候
        /// </summary>
        private string s_valid
        {
            get { return n_Valid ? Resource.sValid : Resource.sUnValid; }
        }

        [Size(500)]
        public string s_Contact
        {
            get { return fs_Contact; }
            set { SetPropertyValue("s_Contact", ref fs_Contact, value); }
        }

        [Size(1)]
        public string s_AllowCustomEmail
        {
            get { return fs_AllowCustomEmail; }
            set { SetPropertyValue("s_AllowCustomEmail", ref fs_AllowCustomEmail, value); }
        }


        public DateTime dt_ModifyPassword
        {
            get { return fdt_ModifyPassword; }
            set { SetPropertyValue<DateTime>("dt_ModifyPassword", ref fdt_ModifyPassword, value); }
        }

        public DateTime dt_Lock
        {
            get { return fdt_Lock; }
            set { SetPropertyValue<DateTime>("dt_Lock", ref fdt_Lock, value); }
        }

        //int fn_SecurityLevelID;//密级
        //public int n_SecurityLevelID
        //{
        //    get { return fn_SecurityLevelID; }
        //    set { SetPropertyValue<int>("n_SecurityLevelID", ref fn_SecurityLevelID, value); }
        //}

        [NonPersistent]
        public string s_DistributeType { get; set; }

        [Association("SecurityLevel-Employees")]
        [Persistent("n_SecurityLevelID")]
        public CodeSecurityLevelConfig TheSecurityLevel
        {
            get { return fn_SecurityLevelID; }
            set { SetPropertyValue("n_SecurityLevelID", ref fn_SecurityLevelID, value); }
        }

        [Aggregated, Association("User-UserRights", typeof(UserRights))]
        public XPCollection UserRights
        {
            get { return GetCollection("UserRights"); }
        }

        [Aggregated, Association("User-SelectEmail")]
        public XPCollection<CodeUserSelectEmail> SelectEmails
        {
            get { return GetCollection<CodeUserSelectEmail>("SelectEmails"); }
        }
        [Aggregated, Association("User-UserInConsole", typeof(UserCaseInConsole))]
        public XPCollection UserCaseInConsoles
        {
            get { return GetCollection("UserCaseInConsoles"); }
        }

        [Aggregated, Association("User-UserDepartments")]
        public XPCollection<UserDepartment> UserDepartments
        {
            get { return GetCollection<UserDepartment>("UserDepartments"); }
        }

        [Aggregated, Association("User-UserRoles")]
        public XPCollection<UserRoles> UserRoles
        {
            get { return GetCollection<UserRoles>("UserRoles"); }
        }

        [Aggregated, Association("User-UserQuerys")]
        public XPCollection<UserQuery> UserQuerys
        {
            get { return GetCollection<UserQuery>("UserQuerys"); }
        }

        [Aggregated, Association("User-UserTeams")]
        public XPCollection<UserTeam> UserTeams
        {
            get { return GetCollection<UserTeam>("UserTeams"); }
        }

        [Aggregated, Association("User-UserFoders", typeof(FileFolder))]
        public XPCollection UserFoders
        {
            get { return GetCollection("UserFoders"); }
        }

        [Aggregated, Association("User-UserClients", typeof(UserClient))]
        public XPCollection UserClients
        {
            get { return GetCollection("UserClients"); }
        }

        [Aggregated, Association("Employee-CaseAttorney", typeof(CaseAttorney))]
        public XPCollection CaseAttorneys
        {
            get { return GetCollection("CaseAttorneys"); }
        }

        //[Aggregated, Association("Creator-TaskChain")]
        //public XPCollection<OldTFTaskChain> TaskChains
        //{
        //    get { return GetCollection<OldTFTaskChain>("TaskChains"); }
        //}
        //[Aggregated, Association("CompleteUser-Task")]
        //public XPCollection<OldTFTask> CompletedTasks
        //{
        //    get { return GetCollection<OldTFTask>("CompletedTasks"); }
        //}

        //[Aggregated, Association("LockUser-Task")]
        //public XPCollection<OldTFTask> LockTasks
        //{
        //    get { return GetCollection<OldTFTask>("LockTasks"); }
        //}

        //[Association("User-CodeTask", typeof(OldTFCodeTask))]
        //public XPCollection CodeTasks
        //{
        //    get { return GetCollection("CodeTasks"); }
        //}

        [Aggregated, Association("RemindInEmployee-Employee", typeof(CodeRemindInEmployee))]
        public XPCollection<CodeRemindInEmployee> RemindInEmployees
        {
            get { return GetCollection<CodeRemindInEmployee>("RemindInEmployees"); }
        }

        [Aggregated, Association("SendRemindInEmployee-Employee", typeof(SendRemind))]
        public XPCollection<SendRemind> SendRemindInEmployees
        {
            get { return GetCollection<SendRemind>("SendRemindInEmployees"); }
        }

        [Aggregated, Association("Employee-CaseRoleAssignRule")]
        public XPCollection<CodeCaseRoleAssignRule> CaseRoleAssignRules
        {
            get { return GetCollection<CodeCaseRoleAssignRule>("CaseRoleAssignRules"); }
        }

        [Aggregated, Association("CodeEmployee-SearchTaskRights")]
        public XPCollection<CodeSearchTaskRights> SearchTaskRights
        {
            get { return GetCollection<CodeSearchTaskRights>("SearchTaskRights"); }
        }

        [NonPersistent]
        public bool Check
        {
            get;
            set;
        }
        public CodeEmployee(Session session) : base(session) { }
        public CodeEmployee() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }

        public string Department
        {
            get { return string.Join(",", UserDepartments.Where(p => p.TheDepartment != null).Select(f => f.TheDepartment.n_ID)); }
        }

        public string DepartmentName
        {
            get { return string.Join(",", UserDepartments.Where(p => p.TheDepartment != null).Select(f => f.TheDepartment.s_Name)); }
        }
        //[Delayed]
        //public int CaseInProcessing
        //{
        //    get
        //    {
        //        using (UnitOfWork tempUow = new UnitOfWork())
        //        {
        //            XPCollection xpc = new XPCollection(tempUow, typeof(BasicCase))
        //            {
        //                Criteria =
        //                    CriteriaOperator.Parse(
        //                        "[CaseAttorneys][[TheAttorney.n_ID] = ?] AND s_CaseStatus <>? AND s_CaseStatus <> ?",
        //                        n_ID, "结案", "Closed")
        //            };
        //            return xpc.Count;
        //        }
        //    }
        //}

        //[Delayed]
        //public int CaseNotSubmit
        //{
        //    get
        //    {
        //        using (UnitOfWork tempUow = new UnitOfWork())
        //        {
        //            XPCollection xpc = new XPCollection(tempUow, typeof(BasicCase))
        //            {
        //                Criteria =
        //                    CriteriaOperator.Parse(
        //                        "[CaseAttorneys][[TheAttorney.n_ID] = ?] AND dt_SubmitDate IS NULL",
        //                        n_ID)
        //            };
        //            return xpc.Count;
        //        }
        //    }
        //}

        //[Delayed]
        //public string Departments
        //{
        //    get
        //    {
        //        string sValue = "";
        //        foreach (UserDepartment userDepartment in UserDepartments)
        //        {
        //            if (userDepartment == null) continue;
        //            sValue += "," + userDepartment.TheDepartment.s_Name;
        //        }
        //        return sValue.TrimStart(new[] { ',' }).TrimStart(new[] { ',' });
        //    }
        //}
    }
}
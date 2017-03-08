using System.Text;
using System.Windows.Forms;
using DataEntities.Config;
using DataEntities.Contact.Applicant;
using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using DevExpress.Xpo.DB;

namespace DataEntities.Case
{
    [Persistent("TCase_Applicant")]
    public class Applicant : XPLiteObject
    {
        private readonly XPDelayedProperty fn_ApplicantID = new XPDelayedProperty();
        private readonly XPDelayedProperty fn_Country = new XPDelayedProperty();
        private readonly XPDelayedProperty fn_Sequence = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_ApplicantTypeContent = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_CardNumber = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_City = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_EFilingApplicantType = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_ElecPayer = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_Email = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_Fax = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_ForAllCountries = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_ForNonUS = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_ForSpecCountries = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_ForUS = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_IsAppInv = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_IsApplicant = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_IsDelegacy = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_IsInventor = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_Mobile = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_Name = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_NativeName = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_OtherAddress = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_OtherName = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_Phone = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_State = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_Street = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_ZipCode = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_TrustDeedNo = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_AppSerial = new XPDelayedProperty();
        private BasicCase basicCase;
        private int fn_ID;

        public Applicant(Session session)
            : base(session)
        {
        }

        public Applicant()
            : base(Session.DefaultSession)
        {
        }

        [Key(true)]
        public int n_ID
        {
            get { return fn_ID; }
            set { SetPropertyValue<int>("n_ID", ref fn_ID, value); }
        }
        [Delayed("fs_TrustDeedNo")]
        [Size(30)]
        public string s_TrustDeedNo
        {
            get { return (string)fs_TrustDeedNo.Value; }
            set { fs_TrustDeedNo.Value = value; }
        }
        [Association("Case-Applicants")]
        [Persistent("n_CaseID")]
        public BasicCase BasicCase
        {
            get { return basicCase; }
            set { SetPropertyValue("n_CaseID", ref basicCase, value); }
        }

        [Delayed("fs_IsDelegacy")]
        public string s_IsDelegacy
        {
            get { return (string)fs_IsDelegacy.Value; }
            set { fs_IsDelegacy.Value = value; }
        }

        [Delayed("fn_Sequence")]
        public int n_Sequence
        {
            get
            {
                if (fn_Sequence.Value == null)
                {
                    return -1;
                }
                return (int)fn_Sequence.Value;
            }
            set { fn_Sequence.Value = value; }
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

        [Delayed("fs_ElecPayer")]
        [Size(200)]
        public string s_ElecPayer
        {
            get
            {
                return new XPCollection(new UnitOfWork(), typeof(Contact.Applicant.Applicant))
                {
                    Criteria = CriteriaOperator.Parse("n_AppID =" + n_ApplicantID)
                }.Count == 0
                ? (fs_ElecPayer.Value != null ? fs_ElecPayer.Value.ToString() : "")
                    : ((Contact.Applicant.Applicant)
                        new XPCollection(new UnitOfWork(), typeof(Contact.Applicant.Applicant))
                        {
                            Criteria = CriteriaOperator.Parse("n_AppID =" + n_ApplicantID)
                        }[0]).s_PayFeePerson;
            }
            set { fs_ElecPayer.Value = value; }
        }

        [Delayed("fs_Phone")]
        public string s_Phone
        {
            get { return (string)fs_Phone.Value; }
            set { fs_Phone.Value = value; }
        }

        [Delayed("fs_Mobile")]
        public string s_Mobile
        {
            get { return (string)fs_Mobile.Value; }
            set { fs_Mobile.Value = value; }
        }

        [Delayed("fs_Fax")]
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

        [Delayed("fn_Country")]
        public int n_Country
        {
            get
            {
                if (fn_Country.Value == null)
                {
                    return -1;
                }
                return (int)fn_Country.Value;
            }
            set { fn_Country.Value = value; }
        }

        [Delayed("fs_State")]
        public string s_State
        {
            get { return (string)fs_State.Value; }
            set { fs_State.Value = value; }
        }

        [Delayed("fs_EFilingApplicantType")]
        public string s_EFilingApplicantType
        {
            get { return (string)fs_EFilingApplicantType.Value; }
            set { fs_EFilingApplicantType.Value = value; }
        }

        [Delayed("fs_City")]
        public string s_City
        {
            get { return (string)fs_City.Value; }
            set { fs_City.Value = value; }
        }

        [Delayed("fs_Street")]
        [Size(300)]
        public string s_Street
        {
            get { return (string)fs_Street.Value; }
            set { fs_Street.Value = value; }
        }

        [Delayed("fs_ZipCode")]
        [Size(50)]
        public string s_ZipCode
        {
            get { return (string)fs_ZipCode.Value; }
            set { fs_ZipCode.Value = value; }
        }

        [Delayed("fs_IsApplicant")]
        [Size(1)]
        public string s_IsApplicant
        {
            get { return (string)fs_IsApplicant.Value; }
            set { fs_IsApplicant.Value = value; }
        }

        [Delayed("fs_IsAppInv")]
        public string s_IsAppInv
        {
            get { return (string)fs_IsAppInv.Value; }
            set { fs_IsAppInv.Value = value; }
        }

        [Delayed("fs_IsInventor")]
        public string s_IsInventor
        {
            get { return (string)fs_IsInventor.Value; }
            set { fs_IsInventor.Value = value; }
        }

        [Delayed("fs_ForAllCountries")]
        public string s_ForAllCountries
        {
            get { return (string)fs_ForAllCountries.Value; }
            set { fs_ForAllCountries.Value = value; }
        }

        [Delayed("fs_ForNonUS")]
        public string s_ForNonUS
        {
            get { return (string)fs_ForNonUS.Value; }
            set { fs_ForNonUS.Value = value; }
        }

        [Delayed("fs_ForUS")]
        public string s_ForUS
        {
            get { return (string)fs_ForUS.Value; }
            set { fs_ForUS.Value = value; }
        }

        [Delayed("fs_ForSpecCountries")]
        public string s_ForSpecCountries
        {
            get { return (string)fs_ForSpecCountries.Value; }
            set { fs_ForSpecCountries.Value = value; }
        }

        [Delayed("fs_CardNumber")]
        public string s_CardNumber
        {
            get { return (string)fs_CardNumber.Value; }
            set { fs_CardNumber.Value = value; }
        }

        [Delayed("fs_OtherAddress")]
        public string s_OtherAddress
        {
            get { return (string)fs_OtherAddress.Value; }
            set { fs_OtherAddress.Value = value; }
        }

        [Delayed("fs_ApplicantTypeContent")]
        public string s_ApplicantTypeContent
        {
            get { return (string)fs_ApplicantTypeContent.Value; }
            set { fs_ApplicantTypeContent.Value = value; }
        }

        [Delayed]
        public string s_AppType
        {
            get
            {
                using (var tempUow = new UnitOfWork())
                {
                    var applicant = tempUow.GetObjectByKey<Contact.Applicant.Applicant>(n_ApplicantID);
                    return applicant == null ? "" : applicant.s_AppType;
                }
            }
        }

        [Delayed]
        public string s_IDNumber
        {
            get
            {
                using (var tempUow = new UnitOfWork())
                {
                    var applicant = tempUow.GetObjectByKey<Contact.Applicant.Applicant>(n_ApplicantID);
                    return applicant == null ? "" : applicant.s_IDNumber;
                }
            }
        }
        [Delayed]
        public string s_AppCode
        {
            get
            {
                using (var tempUow = new UnitOfWork())
                {
                    var applicant = tempUow.GetObjectByKey<Contact.Applicant.Applicant>(n_ApplicantID);
                    return applicant == null ? "" : applicant.s_AppCode;
                }
            }
        }

        [Delayed]
        public string s_Address
        {
            get { return GetCNAddresss(); }
        }

        [Delayed("fs_AppSerial")]
        [Size(100)]
        public string s_AppSerial
        {
            get { return (string)fs_AppSerial.Value; }
            set { fs_AppSerial.Value = value; }
        }
        #region 自定义方法

        /// #############################################
        /// <summary>
        ///     获取地址
        ///     Coder: Kevin Wang(2010-09-09)
        /// </summary>
        /// <returns>地址</returns>
        public string GetCNAddresss()
        {
            using (var tempUow = new UnitOfWork())
            {
                string sFilePath = Application.StartupPath + "\\Config\\DefaultLoadConfig.ini";
                string sSetion = "Language";
                string sKey = "Language";
                string missValue = "zh-CN";
                var sLanguage = new StringBuilder(100);
                //APIFunctions.GetPrivateProfileString(sSetion, sKey, missValue, sLanguage, 100,
                //    sFilePath);
                string tempCountry = tempUow.GetObjectByKey<CodeCountry>(n_Country) == null
                    ? string.Empty
                    : tempUow.GetObjectByKey<CodeCountry>(n_Country).s_Name;
                string tempState = s_State ?? string.Empty;
                string tempCity = s_City ?? string.Empty;
                string tempStreet = s_Street == null ? string.Empty : s_Street.Replace("\r\n", "");
                if (sLanguage.ToString() == "zh-CN")
                {
                    //return tempCountry + tempState + tempCity + tempStreet; 这里主要是拼接国家+状态+省市+街道地址
                    //return tempState + tempCity + tempStreet;  这里主要是拼接状态+省市+街道地址
                    return tempState + tempStreet; //这里主要是拼接街道地址
                }
                return tempStreet + tempCity + tempState + tempCountry;
                //return sLanguage.ToString() == "zh-CN" ?
                //    ((tempUow.GetObjectByKey<CodeCountry>(n_Country) == null ? string.Empty : tempUow.GetObjectByKey<CodeCountry>(n_Country).s_Name) + s_State == null ? string.Empty : s_State + s_City == null ? string.Empty : s_City + s_Street == null ? string.Empty : s_Street.Replace("\r\n", ""))
                //           : (s_Street == null ? string.Empty : s_Street.Replace("\r\n", "") + " " + s_City == null ? string.Empty : s_City + " " + s_State == null ? string.Empty : s_State);
            }
        }

        /// #############################################
        /// <summary>
        ///     获取英文地址，地址按照英文习惯排练
        ///     Coder: Kevin Wang(2010-09-09)
        /// </summary>
        /// <returns>地址</returns>
        public string GetENAddresss()
        {
            return s_OtherAddress;
        }

        /// #################################################################
        /// <summary>
        ///     获取申请人的国别
        ///     Kevin Wang(2010-10-11)
        /// </summary>
        /// <returns>申请人国别</returns>
        public string GetProposerCountry()
        {
            using (var uow = new UnitOfWork())
            {
                var xpc = new XPCollection(uow, typeof(CodeCountry))
                {
                    Criteria = CriteriaOperator.Parse("n_ID =" + n_Country)
                };
                return xpc.Count == 0 ? "" : ((CodeCountry)xpc[0]).s_Name;
            }
        }

        /// #################################################################
        /// <summary>
        ///     获取申请人的国别其他语言名称
        ///     Kevin Wang(2010-10-11)
        /// </summary>
        /// <returns>申请人国别其他语言名称</returns>
        public string GetProposerCountryOtherName()
        {
            using (var uow = new UnitOfWork())
            {
                var xpc = new XPCollection(uow, typeof(CodeCountry))
                {
                    Criteria = CriteriaOperator.Parse("n_ID =" + n_Country)
                };
                return xpc.Count == 0 ? "" : ((CodeCountry)xpc[0]).s_OtherName;
            }
        }

        /// #################################################################
        /// <summary>
        ///     获取申请人的企业代码/身份证号
        ///     Kevin Wang(2010-10-11)
        /// </summary>
        /// <returns>申请人企业代码/身份证号</returns>
        public string GetProposerIDNumber()
        {
            using (var uow = new UnitOfWork())
            {
                var xpc = new XPCollection(uow, typeof(Contact.Applicant.Applicant))
                {
                    Criteria = CriteriaOperator.Parse("n_AppID =" + n_ApplicantID)
                };
                return xpc.Count == 0 ? "" : ((Contact.Applicant.Applicant)xpc[0]).s_IDNumber;
            }
        }
        /// #################################################################
        /// <summary>
        ///     获取申请人的法人代表名称
        ///     Kevin Wang(2010-10-11)
        /// </summary>
        /// <returns>申请人法人代表名称</returns>
        public string GetProposerCorporation()
        {
            using (var uow = new UnitOfWork())
            {
                var xpc = new XPCollection(uow, typeof(Contact.Applicant.Applicant))
                {
                    Criteria = CriteriaOperator.Parse("n_AppID =" + n_ApplicantID)
                };
                return xpc.Count == 0 ? "" : ((Contact.Applicant.Applicant)xpc[0]).s_Corporation;
            }
        }

        /// <summary>
        /// 获取省州英文名称
        /// </summary>
        /// <returns></returns>
        public string GetENState()
        {
            using (var uow = new UnitOfWork())
            {

                var xpc = new XPCollection(uow, typeof(CodeState))
                {
                    Criteria = CriteriaOperator.Parse("s_StateName ='" + s_State + "'")
                };
                return xpc.Count == 0 ? "" : ((CodeState)xpc[0]).s_OStateName;
            }
        }
        /// #################################################################
        /// <summary>
        ///     获取申请人的法人职务
        ///     Kevin Wang(2010-10-11)
        /// </summary>
        /// <returns>申请人法人代表职务</returns>
        public string GetProposerDuty()
        {
            using (var uow = new UnitOfWork())
            {
                var xpc = new XPCollection(uow, typeof(Contact.Applicant.Applicant))
                {
                    Criteria = CriteriaOperator.Parse("n_AppID =" + n_ApplicantID)
                };
                return xpc.Count == 0 ? "" : ((Contact.Applicant.Applicant)xpc[0]).s_Duty;
            }
        }

        /// #################################################################
        /// <summary>
        ///     获取申请人的代码
        ///     Kevin Wang(2010-10-11)
        /// </summary>
        /// <returns>申请人法人代表职务</returns>
        public string GetApplicantCode()
        {
            using (var uow = new UnitOfWork())
            {
                var xpc = new XPCollection(uow, typeof(Contact.Applicant.Applicant))
                {
                    Criteria = CriteriaOperator.Parse("n_AppID =" + n_ApplicantID)
                };
                return xpc.Count == 0 ? "" : ((Contact.Applicant.Applicant)xpc[0]).s_AppCode;
            }
        }

        #region 申请人联系人

        public string CAddress
        {
            get
            {
                using (var tempUow = new UnitOfWork())
                {
                    return ((tempUow.GetObjectByKey<CodeCountry>(n_Country) == null
                        ? string.Empty
                        : tempUow.GetObjectByKey<CodeCountry>(n_Country).s_Name) + s_State + " " + s_City +
                            " " +
                            s_Street);
                }
            }
        }

        /// #################################################################
        /// <summary>
        ///     获取申请人第一联系人的邮编(办公地址的邮编）
        ///     Kevin Wang(2010-10-11)
        /// </summary>
        /// <returns>邮编</returns>
        public string GetProposerContactZipCode()
        {
            using (var uow = new UnitOfWork())
            {
                var xpc = new XPCollection(uow, typeof(Contact.Applicant.Applicant))
                {
                    Criteria = CriteriaOperator.Parse("n_AppID =" + n_ApplicantID)
                };
                if (xpc.Count == 0) return "";
                var applicant =
                    xpc[0] as Contact.Applicant.Applicant;
                applicant.AppContact.Sorting =
                    new SortingCollection(new SortProperty("n_Sequence", SortingDirection.Ascending));
                if (applicant.AppContact.Count <= 0) return "";
                foreach (ApplicantContactAddress address in ((ApplicantContact)applicant.AppContact[0]).AppConAddress)
                {
                    if (address.s_Type == null || address.s_Type.IndexOf("O") < 0) continue;
                    return address.s_ZipCode;
                }
            }
            return "";
        }

        /// #################################################################
        /// <summary>
        ///     获取申请人第一联系人的中文办公地址
        ///     Kevin Wang(2010-10-25)
        /// </summary>
        /// <returns>中文办公地址</returns>
        public string GetProposerContactOfficeCNAddress()
        {
            using (var uow = new UnitOfWork())
            {
                var xpc = new XPCollection(uow, typeof(Contact.Applicant.Applicant))
                {
                    Criteria = CriteriaOperator.Parse("n_AppID =" + n_ApplicantID)
                };
                if (xpc.Count == 0) return "";
                var applicant =
                    xpc[0] as Contact.Applicant.Applicant;
                applicant.AppContact.Sorting =
                    new SortingCollection(new SortProperty("n_Sequence", SortingDirection.Ascending));
                return applicant.AppContact.Count <= 0
                    ? ""
                    : ((ApplicantContact)applicant.AppContact[0]).GetOfficeCNAddress();
            }
        }

        /// #################################################################
        /// <summary>
        ///     获取申请人第一联系人的英文办公地址
        ///     Kevin Wang(2010-10-25)
        /// </summary>
        /// <returns>英文办公地址</returns>
        public string GetProposerContactOfficeENAddress()
        {
            using (var uow = new UnitOfWork())
            {
                var xpc = new XPCollection(uow, typeof(Contact.Applicant.Applicant))
                {
                    Criteria = CriteriaOperator.Parse("n_AppID =" + n_ApplicantID)
                };
                if (xpc.Count == 0) return "";
                var applicant =
                    xpc[0] as Contact.Applicant.Applicant;
                applicant.AppContact.Sorting =
                    new SortingCollection(new SortProperty("n_Sequence", SortingDirection.Ascending));
                return applicant.AppContact.Count <= 0
                    ? ""
                    : ((ApplicantContact)applicant.AppContact[0]).GetOfficeENAddress();
            }
        }

        /// #################################################################
        /// <summary>
        ///     获取申请人第一联系人的姓名
        ///     Coder:lixin(2010-11-06)
        /// </summary>
        /// <returns>申请人第一联系人姓名</returns>
        public string GetProposerContactName()
        {
            using (var uow = new UnitOfWork())
            {
                var xpc = new XPCollection(uow, typeof(Contact.Applicant.Applicant))
                {
                    Criteria = CriteriaOperator.Parse("n_AppID =" + n_ApplicantID)
                };
                if (xpc.Count == 0) return "";
                var applicant =
                    xpc[0] as Contact.Applicant.Applicant;
                applicant.AppContact.Sorting =
                    new SortingCollection(new SortProperty("n_Sequence", SortingDirection.Ascending));
                return applicant.AppContact.Count <= 0
                    ? ""
                    : ((ApplicantContact)applicant.AppContact[0]).s_FirstName +
                      ((ApplicantContact)applicant.AppContact[0]).s_LastName;
            }
        }

        ///// #############################################################
        ///// <summary>
        /////     获取申请人总委托书号
        ///// </summary>
        ///// <returns></returns>
        //public string GetProposerTrustDeed()
        //{
        //    return s_TrustDeedNo;
        //    //using (var uow = new UnitOfWork())
        //    //{
        //    //    var xpc = new XPCollection(uow, typeof (Contact.Applicant.Applicant))
        //    //    {
        //    //        Criteria = CriteriaOperator.Parse("n_AppID =" + n_ApplicantID)
        //    //    };
        //    //    if (xpc.Count == 0) return "";
        //    //    return ((Contact.Applicant.Applicant)xpc[0]).TheApplicantTransLatedName == null ? ((Contact.Applicant.Applicant)xpc[0]).s_TrustDeedNo : ((Contact.Applicant.Applicant)xpc[0]).TheApplicantTransLatedName.s_TrustdeedNum;
        //    //}
        //}
        ///// <summary>
        /////     获取申请人总委托书号
        ///// </summary>
        ///// <returns></returns>
        public string GetProposerTrustDeed()
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                var xpc = new XPCollection(uow, typeof(Applicant))
                {
                    Criteria = CriteriaOperator.Parse("n_ID =" + n_ID)
                };
                if (xpc.Count == 0) return "";
                return (xpc[0] as Applicant).s_TrustDeedNo;
            }
        }
        public string GetIsInvention()
        {
            return s_IsAppInv == "Y" ? "true" : "false";
        }

        public string GetIsForAllCountries()
        {
            return s_ForAllCountries == "Y" ? "true" : "false";
        }

        public string GetIsForNonUS()
        {
            return s_ForNonUS == "Y" ? "true" : "false";
        }

        public string GetIsForUS()
        {
            return s_ForUS == "Y" ? "true" : "false";
        }

        public string GetIsForSpecCountries()
        {
            return s_ForSpecCountries == "Y" ? "true" : "false";
        }

        #endregion

        #endregion

        [NonPersistent]
        public string s_TempAppCode { get; set; }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}
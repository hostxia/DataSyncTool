using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using DataEntities.Case.Patents;
using DataEntities.Config;
using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using DevExpress.Xpo.DB;

namespace DataEntities.Case
{
    public partial class BasicCase : XPLiteObject
    {
        #region 自定义方法

        /// #################################################################
        /// <summary>
        ///     获取业务类型名称
        ///     Kevin Wang(2010-08-30)
        /// </summary>
        /// <returns>业务类型名称</returns>
        public string GetBusinessTypeName()
        {
            using (var uow = new UnitOfWork())
            {
                var xpc = new XPCollection(uow, typeof(CodeBusinessType))
                {
                    Criteria = CriteriaOperator.Parse("n_ID =" + n_BusinessTypeID)
                };
                return xpc.Count == 0 ? "" : ((CodeBusinessType)xpc[0]).s_Name;
            }
        }

        /// #################################################################
        /// <summary>
        ///     获取业务类型其他名称
        ///     Kevin Wang(2010-08-30)
        /// </summary>
        /// <returns>业务类型其他名称</returns>
        public string GetBusinessTypeOtherName()
        {
            using (var uow = new UnitOfWork())
            {
                var xpc = new XPCollection(uow, typeof(CodeBusinessType))
                {
                    Criteria = CriteriaOperator.Parse("n_ID =" + n_BusinessTypeID)
                };
                return xpc.Count == 0 ? "" : ((CodeBusinessType)xpc[0]).s_OtherName;
            }
        }

        /// #################################################################
        /// <summary>
        ///     获取所有申请人名称
        ///     Kevin Wang(2010-08-30)
        /// </summary>
        /// <returns>所有申请人名称</returns>
        public string GetApplicantsNames(string sSplit)
        {
            string sNames = "";

            IOrderedEnumerable<Applicant> applicants = from e in Applicants.Cast
                <Applicant>()
                                                       orderby e.n_Sequence
                                                       select e;
            switch (sSplit)
            {
                case "1":
                    foreach (Applicant app in applicants)
                    {
                        sNames += app.s_Name + "; ";
                    }
                    sNames = sNames.Trim().TrimEnd(new[] { ';' });
                    break;
                case "2":
                    foreach (Applicant app in applicants)
                    {
                        sNames += app.s_Name + "    ";
                    }
                    sNames = sNames.Trim();
                    break;
                case "3":
                    foreach (Applicant app in applicants)
                    {
                        sNames += app.s_Name + "、";
                    }
                    sNames = sNames.TrimEnd(new[] { '、' });
                    break;
                case "4":
                    foreach (Applicant app in applicants)
                    {
                        sNames += app.s_Name + "；";
                    }
                    sNames = sNames.TrimEnd(new[] { '；' });
                    break;
            }
            return sNames;
        }

        /// <summary>
        ///     Vat2.4 修改   取案件详细信息页面的电子 缴费单缴费人勾选的人名 没有就是空的
        /// </summary>
        /// <returns></returns>
        public string GetAppllicansNames(int nCaseID)
        {
            using (var uow = new UnitOfWork())
            {
                var baseCase = uow.GetObjectByKey<BasicCase>(nCaseID);
                if (baseCase == null) return string.Empty;
                Applicant applicant =
                    baseCase.Applicants.Cast<Applicant>().FirstOrDefault(a => !string.IsNullOrEmpty(a.s_ElecPayer));
                return applicant == null ? string.Empty : applicant.s_ElecPayer;
            }
        }

        /// #################################################################
        /// <summary>
        ///     获取所有申请人其他名称
        ///     Kevin Wang(2010-08-30)
        /// </summary>
        /// <returns>所有申请人其他名称</returns>
        public string GetApplicantsOtherNames()
        {
            string sNames = "";
            IOrderedEnumerable<Applicant> applicants = from e in Applicants.Cast
                <Applicant>()
                                                       orderby e.n_Sequence
                                                       select e;

            foreach (Applicant app in applicants)
            {
                sNames += app.s_NativeName + ";";
            }
            sNames = sNames.TrimEnd(new[] { ';' });
            return sNames;
        }


        /// <summary>
        /// 获取申请人文号
        /// </summary>
        /// <returns></returns>
        public string GetApplicantsSerial()
        {
            string result = string.Empty;
            if (Applicants.Count == 0)
            {
                return string.Empty;
            }
            if (Applicants.Count == 1)
            {
                return (Applicants[0] as Applicant).s_AppSerial;
            }
            if (Applicants.Count > 1)
            {
                var lst = new List<string>();
                foreach (Applicant applicant in Applicants)
                {
                    if (string.IsNullOrWhiteSpace(applicant.s_AppSerial))
                    {
                        continue;
                    }
                    lst.Add(applicant.s_Name + ":" + applicant.s_AppSerial);
                }
                result = string.Join("; ", lst.ToArray());
            }
            return result;
        }
        public string GetApplicantsTrustNum()
        {
            string result = string.Empty;
            if (Applicants.Count == 0)
            {
                return string.Empty;
            }
            if (Applicants.Count == 1)
            {
                return (Applicants[0] as Applicant).s_TrustDeedNo;
            }
            if (Applicants.Count > 1)
            {

                foreach (Applicant applicant in Applicants)
                {
                    if (applicant.s_IsDelegacy == "Y")
                    {
                        return applicant.s_TrustDeedNo;
                    }

                }

            }
            return result;
        }
        /// <summary>
        /// 获取申请人文号(用于任务模块的预览显示)
        /// </summary>
        /// <returns></returns>
        public string GetApplicantsSerialForTask()
        {
            string result = string.Empty;
            if (Applicants.Count == 0)
            {
                return string.Empty;
            }
            if (Applicants.Count == 1)
            {
                return (Applicants[0] as Applicant).s_AppSerial;
            }
            if (Applicants.Count > 1)
            {
               
                foreach (Applicant applicant in Applicants)
                {
                    if (applicant.s_IsDelegacy=="Y")
                    {
                        return applicant.s_AppSerial;
                    }
                    
                }
               
            }
            return result;
        }
        /// #################################################################
        /// <summary>
        ///     获取第一代理人名称
        ///     Kevin Wang(2010-08-30)
        /// </summary>
        /// <returns>第一代理人名称</returns>
        public string GetFirstAttorneyName()
        {
            using (var uow = new UnitOfWork())
            {
                var xpc = new XPCollection(uow, typeof(CodeEmployee))
                {
                    Criteria = CriteriaOperator.Parse("n_ID =" + n_FirstAttorney)
                };
                return xpc.Count == 0 ? "" : ((CodeEmployee)xpc[0]).s_Name;
            }
        }

        /// #################################################################
        /// <summary>
        ///     获取第一代理人其他名称
        ///     Kevin Wang(2010-08-30)
        /// </summary>
        /// <returns>第一代理人其他名称</returns>
        public string GetFirstAttorneyOtherName()
        {
            using (var uow = new UnitOfWork())
            {
                var xpc = new XPCollection(uow, typeof(CodeEmployee))
                {
                    Criteria = CriteriaOperator.Parse("n_ID =" + n_FirstAttorney)
                };
                return xpc.Count == 0 ? "" : ((CodeEmployee)xpc[0]).s_OtherName;
            }
        }

        /// #################################################################
        /// <summary>
        ///     获取第一代理人电话
        ///     Kevin Wang(2010-10-22)
        /// </summary>
        /// <returns>第一代理人电话</returns>
        public string GetFirstAttorneyTel()
        {
            using (var uow = new UnitOfWork())
            {
                var xpc = new XPCollection(uow, typeof(CodeEmployee))
                {
                    Criteria = CriteriaOperator.Parse("n_ID =" + n_FirstAttorney)
                };
                return xpc.Count == 0 ? "" : ((CodeEmployee)xpc[0]).s_Phone;
            }
        }

        /// #################################################################
        /// <summary>
        ///     获取第一代理人传真
        ///     Kevin Wang(2010-10-22)
        /// </summary>
        /// <returns>第一代理人传真</returns>
        public string GetFirstAttorneyFax()
        {
            using (var uow = new UnitOfWork())
            {
                var xpc = new XPCollection(uow, typeof(CodeEmployee))
                {
                    Criteria = CriteriaOperator.Parse("n_ID =" + n_FirstAttorney)
                };
                return xpc.Count == 0 ? "" : ((CodeEmployee)xpc[0]).s_Fax;
            }
        }

        /// #################################################################
        /// <summary>
        ///     获取第一代理人移动电话
        ///     Kevin Wang(2010-10-22)
        /// </summary>
        /// <returns>获取第一代理人移动电话</returns>
        public string GetFirstAttorneyMobile()
        {
            using (var uow = new UnitOfWork())
            {
                var xpc = new XPCollection(uow, typeof(CodeEmployee))
                {
                    Criteria = CriteriaOperator.Parse("n_ID =" + n_FirstAttorney)
                };
                return xpc.Count == 0 ? "" : ((CodeEmployee)xpc[0]).s_Mobile;
            }
        }

        /// #################################################################
        /// <summary>
        ///     获取第二代理人移动电话
        ///     Kevin Wang(2010-10-22)
        /// </summary>
        /// <returns>获取第二代理人移动电话</returns>
        public string GetSecondAttorneyMobile()
        {
            using (var uow = new UnitOfWork())
            {
                var xpc = new XPCollection(uow, typeof(CodeEmployee))
                {
                    Criteria = CriteriaOperator.Parse("n_ID =" + n_SecondAttorney)
                };
                return xpc.Count == 0 ? "" : ((CodeEmployee)xpc[0]).s_Mobile;
            }
        }

        /// #################################################################
        /// <summary>
        ///     获取第一代理人证书号
        ///     Kevin Wang(2010-10-25)
        /// </summary>
        /// <returns>第一代理人证书号</returns>
        public string GetFirstAttorneyCerNO()
        {
            using (var uow = new UnitOfWork())
            {
                var xpc = new XPCollection(uow, typeof(CodeEmployee))
                {
                    Criteria = CriteriaOperator.Parse("n_ID =" + n_FirstAttorney)
                };
                return xpc.Count == 0 ? "" : ((CodeEmployee)xpc[0]).s_CertificateNo;
            }
        }

        /// #################################################################
        /// <summary>
        ///     获取第一代理人地址
        ///     Kevin Wang(2010-10-28)
        /// </summary>
        /// <returns>第一代理人地址</returns>
        public string GetFirstAttorneyAddr()
        {
            using (var uow = new UnitOfWork())
            {
                var xpc = new XPCollection(uow, typeof(CodeEmployee))
                {
                    Criteria = CriteriaOperator.Parse("n_ID =" + n_FirstAttorney)
                };
                return xpc.Count == 0 ? "" : ((CodeEmployee)xpc[0]).s_IMAddress;
            }
        }

        /// #################################################################
        /// <summary>
        ///     获取第一代理人Email
        ///     coder:LiKai(2010-11-11)
        /// </summary>
        /// <returns>第一代理人Email</returns>
        public string GetFirstAttorneyEmail()
        {
            using (var uow = new UnitOfWork())
            {
                var xpc = new XPCollection(uow, typeof(CodeEmployee))
                {
                    Criteria = CriteriaOperator.Parse("n_ID =" + n_FirstAttorney)
                };
                return xpc.Count == 0 ? "" : ((CodeEmployee)xpc[0]).s_Email;
            }
        }

        /// #################################################################
        /// <summary>
        ///     获取第二代理人名称
        ///     Kevin Wang(2010-08-30)
        /// </summary>
        /// <returns>第二代理人名称</returns>
        public string GetSecondAttorneyName()
        {
            using (var uow = new UnitOfWork())
            {
                var xpc = new XPCollection(uow, typeof(CodeEmployee))
                {
                    Criteria = CriteriaOperator.Parse("n_ID =" + n_SecondAttorney)
                };
                return xpc.Count == 0 ? "" : ((CodeEmployee)xpc[0]).s_Name;
            }
        }

        /// #################################################################
        /// <summary>
        ///     获取第二代理人其他名称
        ///     Kevin Wang(2010-08-30)
        /// </summary>
        /// <returns>第二代理人其他名称</returns>
        public string GetSecondAttorneyOtherName()
        {
            using (var uow = new UnitOfWork())
            {
                var xpc = new XPCollection(uow, typeof(CodeEmployee))
                {
                    Criteria = CriteriaOperator.Parse("n_ID =" + n_SecondAttorney)
                };
                return xpc.Count == 0 ? "" : ((CodeEmployee)xpc[0]).s_OtherName;
            }
        }

        /// #################################################################
        /// <summary>
        ///     获取第二代理人电话
        ///     Kevin Wang(2010-10-22)
        /// </summary>
        /// <returns>第二代理人电话</returns>
        public string GetSecondAttorneyTel()
        {
            using (var uow = new UnitOfWork())
            {
                var xpc = new XPCollection(uow, typeof(CodeEmployee))
                {
                    Criteria = CriteriaOperator.Parse("n_ID =" + n_SecondAttorney)
                };
                return xpc.Count == 0 ? "" : ((CodeEmployee)xpc[0]).s_Phone;
            }
        }

        /// #################################################################
        /// <summary>
        ///     获取第二代理人传真
        ///     Kevin Wang(2010-10-22)
        /// </summary>
        /// <returns>第二代理人传真</returns>
        public string GetSecondAttorneyFax()
        {
            using (var uow = new UnitOfWork())
            {
                var xpc = new XPCollection(uow, typeof(CodeEmployee))
                {
                    Criteria = CriteriaOperator.Parse("n_ID =" + n_SecondAttorney)
                };
                return xpc.Count == 0 ? "" : ((CodeEmployee)xpc[0]).s_Fax;
            }
        }

        /// #################################################################
        /// <summary>
        ///     获取第二代理人证书号
        ///     Kevin Wang(2010-10-25)
        /// </summary>
        /// <returns>第二代理人证书号</returns>
        public string GetSecondAttorneyCerNO()
        {
            using (var uow = new UnitOfWork())
            {
                var xpc = new XPCollection(uow, typeof(CodeEmployee))
                {
                    Criteria = CriteriaOperator.Parse("n_ID =" + n_SecondAttorney)
                };
                return xpc.Count == 0 ? "" : ((CodeEmployee)xpc[0]).s_CertificateNo;
            }
        }

        /// #################################################################
        /// <summary>
        ///     获取第二代理人地址
        ///     Kevin Wang(2010-10-28)
        /// </summary>
        /// <returns>第二代理人地址</returns>
        public string GetSecondAttorneyAddr()
        {
            using (var uow = new UnitOfWork())
            {
                var xpc = new XPCollection(uow, typeof(CodeEmployee))
                {
                    Criteria = CriteriaOperator.Parse("n_ID =" + n_SecondAttorney)
                };
                return xpc.Count == 0 ? "" : ((CodeEmployee)xpc[0]).s_Facebook;
            }
        }

        /// #################################################################
        /// <summary>
        ///     获取注册国家名称
        ///     Kevin Wang(2010-10-11)
        /// </summary>
        /// <returns>注册国家名称</returns>
        public string GetRegCountryName()
        {
            using (var uow = new UnitOfWork())
            {
                var xpc = new XPCollection(uow, typeof(CodeCountry))
                {
                    Criteria = CriteriaOperator.Parse("n_ID =" + n_RegCountry)
                };
                if (xpc.Count == 0)
                {
                    return "";
                }
                return ((CodeCountry)xpc[0]).s_Name;
            }
        }

        /// #################################################################
        /// <summary>
        ///     获取注册国家名称（英文）
        ///     gengxuejiao(2010-10-11)
        /// </summary>
        /// <returns>注册国家名称</returns>
        public string GetENRegCountryName()
        {
            using (var uow = new UnitOfWork())
            {
                var xpc = new XPCollection(uow, typeof(CodeCountry))
                {
                    Criteria = CriteriaOperator.Parse("n_ID =" + n_RegCountry)
                };
                if (xpc.Count == 0)
                {
                    return "";
                }
                return ((CodeCountry)xpc[0]).s_OtherName;
            }
        }

        ///// #################################################################
        ///// <summary>
        /////     获取实际递交日期中文格式
        /////     Kevin Wang(2010-10-25)
        ///// </summary>
        ///// <returns>实际递交日期中文格式</returns>
        //public string GetSubmitDateInCN()
        //{
        //    return ServerDate.GetDateInCNFormat(dt_SubmitDate);
        //}

        ///// #################################################################
        ///// <summary>
        /////     获取实际递交日期英文格式
        /////     Kevin Wang(2010-10-25)
        ///// </summary>
        ///// <returns>实际递交日期英文格式</returns>
        //public string GetSubmitDateInEN()
        //{
        //    return ServerDate.GetDateInENFormat(dt_SubmitDate);
        //}

        ///// #################################################################
        ///// <summary>
        /////     获取要求递交日期中文格式
        /////     Kevin Wang(2010-10-25)
        ///// </summary>
        ///// <returns>要求递交日期中文格式</returns>
        //public string GetShldSbmtDateDateInCN()
        //{
        //    return ServerDate.GetDateInCNFormat(dt_ShldSbmtDate);
        //}

        ///// #################################################################
        ///// <summary>
        /////     获取要求递交日期英文格式
        /////     Kevin Wang(2010-10-25)
        ///// </summary>
        ///// <returns>要求递交日期英文格式</returns>
        //public string GetShldSbmtDateDateInEN()
        //{
        //    return ServerDate.GetDateInENFormat(dt_ShldSbmtDate);
        //}

        public string GetFormPageXML(string sXMLNode)
        {
            string sValue = "";
            if (FormPages.Count == 0)
            {
                return sValue;
            }
            var xml = new XmlDocument();
            if (FormPages.Count <= 0) return "";
            if (string.IsNullOrEmpty(((FormPage)(FormPages[0])).s_XMLValue)) return "";
            xml.LoadXml(((FormPage)(FormPages[0])).s_XMLValue);
            XmlNode rootNode = xml.SelectSingleNode("/FormPage");
            if (rootNode == null)
            {
                return sValue;
            }
            XmlNode node = rootNode.SelectSingleNode("//Data[@FieldName = '" + sXMLNode + "']");
            if (node == null)
            {
                return "";
            }
            sValue = node.InnerXml;
            return sValue;
        }

        #region 暂时注释

        /*
        ///#################################################################
        /// <summary>
        /// 获取第一申请人的名称
        /// Kevin Wang(2010-08-30)
        /// </summary>
        /// <returns>第一申请人名称</returns>
        public string GetDelegacyProposerName()
        {
            foreach (Applicant caseApplicant in this.Applicants)
            {
                if (caseApplicant.s_IsDelegacy != null && caseApplicant.s_IsDelegacy.ToUpper() == "Y")
                {
                    return caseApplicant.s_Name;
                }
            }
            return "";
        }
        ///#################################################################
        /// <summary>
        /// 获取第一申请人的本国名称
        /// Kevin Wang(2010-08-30)
        /// </summary>
        /// <returns>第一申请人本国名称</returns>
        public string GetDelegacyProposerNativeName()
        {
            foreach (Applicant caseApplicant in this.Applicants)
            {
                if (caseApplicant.s_IsDelegacy != null && caseApplicant.s_IsDelegacy.ToUpper() == "Y")
                {
                    return caseApplicant.s_NativeName;
                }
            }
            return "";
        }
        ///#################################################################
        /// <summary>
        /// 获取第一申请人的其他名称
        /// Kevin Wang(2010-10-11)
        /// </summary>
        /// <returns>第一申请人其他名称</returns>
        public string GetDelegacyProposerOtherName()
        {
            foreach (Applicant caseApplicant in this.Applicants)
            {
                if (caseApplicant.s_IsDelegacy != null && caseApplicant.s_IsDelegacy.ToUpper() == "Y")
                {
                    return caseApplicant.s_OtherName;
                }
            }
            return "";
        }
        ///#################################################################
        /// <summary>
        /// 获取第一申请人的地址。 
        /// 这个地址取自案件申请人表，而不是取自申请人表。
        /// 这个地址是保送官方的地址。
        /// 这是按照中文习惯排练的地址。
        /// Kevin Wang(2010-10-11)
        /// </summary>
        /// <returns>第一申请人地址</returns>
        public string GetDelegacyApplicantCNAddresss()
        {
            foreach (Applicant caseApplicant in this.Applicants)
            {
                if (caseApplicant.s_IsDelegacy != null && caseApplicant.s_IsDelegacy.ToUpper() == "Y")
                {
                    return caseApplicant.GetCNAddresss();
                }
            }
            return "";
        }
        ///#################################################################
        /// <summary>
        /// 获取第一申请人的地址的省份。 
        /// Kevin Wang(2010-10-25)
        /// </summary>
        /// <returns>第一申请人的地址的省份</returns>
        public string GetDelegacyApplicantState()
        {
            foreach (Applicant caseApplicant in this.Applicants)
            {
                if (caseApplicant.s_IsDelegacy == null || caseApplicant.s_IsDelegacy.ToUpper() == "N")
                {
                    return caseApplicant.s_State;
                }
            }
            return "";
        }
        ///#################################################################
        /// <summary>
        /// 获取第一申请人的邮编
        /// Kevin Wang(2010-08-30)
        /// </summary>
        /// <returns>第一申请人邮编</returns>
        public string GetDelegacyProposerZipcode()
        {
            foreach (Applicant caseApplicant in this.Applicants)
            {
                if (caseApplicant.s_IsDelegacy != null && caseApplicant.s_IsDelegacy.ToUpper() == "Y")
                {
                    return caseApplicant.s_ZipCode;
                }
            }
            return "";
        }
        ///#################################################################
        /// <summary>
        /// 获取第一申请人的电话
        /// Kevin Wang(2010-10-11)
        /// </summary>
        /// <returns>第一申请人电话</returns>
        public string GetDelegacyProposerPhoneNumber()
        {
            foreach (Applicant caseApplicant in this.Applicants)
            {
                if (caseApplicant.s_IsDelegacy != null && caseApplicant.s_IsDelegacy.ToUpper() == "Y")
                {
                    return caseApplicant.s_Phone;
                }
            }
            return "";
        }
        ///#################################################################
        /// <summary>
        /// 获取第一申请人的电子邮箱
        /// Kevin Wang(2010-10-25)
        /// </summary>
        /// <returns>第一申请人电子邮箱</returns>
        public string GetDelegacyProposerEmail()
        {
            foreach (Applicant caseApplicant in this.Applicants)
            {
                if (caseApplicant.s_IsDelegacy == null
                    || caseApplicant.s_IsDelegacy.ToUpper() == "N") continue;

                return caseApplicant.s_Email;
            }
            return "";
        }
         * 
         * 
         *#region 申请人联系人
        ///#################################################################
        /// <summary>
        /// 获取第一申请人第一联系人的姓氏
        /// Kevin Wang(2010-10-11)
        /// </summary>
        /// <returns>姓氏</returns>
        public string GetDelegacyProposerContactFirstName()
        {
            foreach (Applicant caseApplicant in this.Applicants)
            {
                if (caseApplicant.s_IsDelegacy == null
                    || caseApplicant.s_IsDelegacy.ToUpper() == "N") continue;

                using (UnitOfWork uow = new UnitOfWork())
                {
                    var xpc = new XPCollection(uow, typeof(DataEntities.Contacts.Applicant.Applicant))
                    {
                        Criteria = CriteriaOperator.Parse("n_AppID =" + caseApplicant.n_ApplicantID)
                    };
                    if (xpc.Count == 0) return "";
                    DataEntities.Contacts.Applicant.Applicant applicant =
                        xpc[0] as DataEntities.Contacts.Applicant.Applicant;
                    foreach (ApplicantContact contact in applicant.AppContact)
                    {
                        if (contact.n_Sequence != -1 && contact.n_Sequence != 0) continue;
                        return contact.s_FirstName;
                    }
                }
            }
            return "";
        }

        ///#################################################################
        /// <summary>
        /// 获取第一申请人第一联系人的名称
        /// Kevin Wang(2010-10-11)
        /// </summary>
        /// <returns>名称</returns>
        public string GetDelegacyProposerContactLastName()
        {
            foreach (Applicant caseApplicant in this.Applicants)
            {
                if (caseApplicant.s_IsDelegacy == null
                    || caseApplicant.s_IsDelegacy.ToUpper() == "N") continue;

                using (UnitOfWork uow = new UnitOfWork())
                {
                    var xpc = new XPCollection(uow, typeof(DataEntities.Contacts.Applicant.Applicant))
                    {
                        Criteria = CriteriaOperator.Parse("n_AppID =" + caseApplicant.n_ApplicantID)
                    };
                    if (xpc.Count == 0) return "";
                    DataEntities.Contacts.Applicant.Applicant applicant =
                        xpc[0] as DataEntities.Contacts.Applicant.Applicant;
                    foreach (ApplicantContact contact in applicant.AppContact)
                    {
                        if (contact.n_Sequence != -1 && contact.n_Sequence != 0) continue;
                        return contact.s_LastName;
                    }
                }
            }
            return "";
        }

        ///#################################################################
        /// <summary>
        /// 获取第一申请人第一联系人的英文名称
        /// Kevin Wang(2010-10-11)
        /// </summary>
        /// <returns>英文名称</returns>
        public string GetDelegacyProposerContactNativeName()
        {
            foreach (Applicant caseApplicant in this.Applicants)
            {
                if (caseApplicant.s_IsDelegacy == null
                    || caseApplicant.s_IsDelegacy.ToUpper() == "N") continue;

                using (UnitOfWork uow = new UnitOfWork())
                {
                    var xpc = new XPCollection(uow, typeof(DataEntities.Contacts.Applicant.Applicant))
                    {
                        Criteria = CriteriaOperator.Parse("n_AppID =" + caseApplicant.n_ApplicantID)
                    };
                    if (xpc.Count == 0) return "";
                    DataEntities.Contacts.Applicant.Applicant applicant =
                        xpc[0] as DataEntities.Contacts.Applicant.Applicant;
                    foreach (ApplicantContact contact in applicant.AppContact)
                    {
                        if (contact.n_Sequence != -1 && contact.n_Sequence != 0) continue;
                        return contact.s_NativeName;
                    }
                }
            }
            return "";
        }

        ///#################################################################
        /// <summary>
        /// 获取第一申请人第一联系人的电话
        /// Kevin Wang(2010-10-11)
        /// </summary>
        /// <returns>电话</returns>
        public string GetDelegacyProposerContactPhoneNumber()
        {
            foreach (Applicant caseApplicant in this.Applicants)
            {
                if (caseApplicant.s_IsDelegacy == null
                    || caseApplicant.s_IsDelegacy.ToUpper() == "N") continue;

                using (UnitOfWork uow = new UnitOfWork())
                {
                    var xpc = new XPCollection(uow, typeof(DataEntities.Contacts.Applicant.Applicant))
                    {
                        Criteria = CriteriaOperator.Parse("n_AppID =" + caseApplicant.n_ApplicantID)
                    };
                    if (xpc.Count == 0) return "";
                    DataEntities.Contacts.Applicant.Applicant applicant =
                        xpc[0] as DataEntities.Contacts.Applicant.Applicant;
                    foreach (ApplicantContact contact in applicant.AppContact)
                    {
                        if (contact.n_Sequence != -1 && contact.n_Sequence != 0) continue;
                        return contact.s_Phone;
                    }
                }
            }
            return "";
        }

        ///#################################################################
        /// <summary>
        /// 获取第一申请人第一联系人的Email
        /// Kevin Wang(2010-10-11)
        /// </summary>
        /// <returns>Email</returns>
        public string GetDelegacyProposerContactEmail()
        {
            foreach (Applicant caseApplicant in this.Applicants)
            {
                if (caseApplicant.s_IsDelegacy == null
                    || caseApplicant.s_IsDelegacy.ToUpper() == "N") continue;

                using (UnitOfWork uow = new UnitOfWork())
                {
                    var xpc = new XPCollection(uow, typeof(DataEntities.Contacts.Applicant.Applicant))
                    {
                        Criteria = CriteriaOperator.Parse("n_AppID =" + caseApplicant.n_ApplicantID)
                    };
                    if (xpc.Count == 0) return "";
                    DataEntities.Contacts.Applicant.Applicant applicant =
                        xpc[0] as DataEntities.Contacts.Applicant.Applicant;
                    foreach (ApplicantContact contact in applicant.AppContact)
                    {
                        if (contact.n_Sequence != -1 && contact.n_Sequence != 0) continue;
                        return contact.s_Email;
                    }
                }
            }
            return "";
        }

        ///#################################################################
        /// <summary>
        /// 获取第一申请人第一联系人的传真
        /// Kevin Wang(2010-10-11)
        /// </summary>
        /// <returns>传真</returns>
        public string GetDelegacyProposerContactFax()
        {
            foreach (Applicant caseApplicant in this.Applicants)
            {
                if (caseApplicant.s_IsDelegacy == null
                    || caseApplicant.s_IsDelegacy.ToUpper() == "N") continue;

                using (UnitOfWork uow = new UnitOfWork())
                {
                    var xpc = new XPCollection(uow, typeof(DataEntities.Contacts.Applicant.Applicant))
                    {
                        Criteria = CriteriaOperator.Parse("n_AppID =" + caseApplicant.n_ApplicantID)
                    };
                    if (xpc.Count == 0) return "";
                    DataEntities.Contacts.Applicant.Applicant applicant =
                        xpc[0] as DataEntities.Contacts.Applicant.Applicant;
                    foreach (ApplicantContact contact in applicant.AppContact)
                    {
                        if (contact.n_Sequence != -1 && contact.n_Sequence != 0) continue;
                        return contact.s_Fax;
                    }
                }
            }
            return "";
        }

        ///#################################################################
        /// <summary>
        /// 获取第一申请人第一联系人的称谓
        /// Kevin Wang(2010-10-11)
        /// </summary>
        /// <returns>称谓</returns>
        public string GetDelegacyProposerContactPrefix()
        {
            foreach (Applicant caseApplicant in this.Applicants)
            {
                if (caseApplicant.s_IsDelegacy == null
                    || caseApplicant.s_IsDelegacy.ToUpper() == "N") continue;

                using (UnitOfWork uow = new UnitOfWork())
                {
                    var xpc = new XPCollection(uow, typeof(DataEntities.Contacts.Applicant.Applicant))
                    {
                        Criteria = CriteriaOperator.Parse("n_AppID =" + caseApplicant.n_ApplicantID)
                    };
                    if (xpc.Count == 0) return "";
                    DataEntities.Contacts.Applicant.Applicant applicant =
                        xpc[0] as DataEntities.Contacts.Applicant.Applicant;
                    foreach (ApplicantContact contact in applicant.AppContact)
                    {
                        if (contact.n_Sequence != -1 && contact.n_Sequence != 0) continue;
                        return contact.s_Prefix;
                    }
                }
            }
            return "";
        }


        #endregion
 *  * */

        #endregion

        #region 申请人

        /// #################################################################
        /// <summary>
        ///     获取第一申请人的地址。
        ///     由于案件申请人表没有英文地址，所以此处取申请人的英文官方地址。
        ///     Kevin Wang(2010-10-25)
        /// </summary>
        /// <returns>第一申请人英文地址</returns>
        public string GetDelegacyApplicantENAddresss()
        {
            foreach (Applicant caseApplicant in Applicants)
            {
                if (caseApplicant.s_IsDelegacy == null || caseApplicant.s_IsDelegacy.ToUpper() == "N") continue;
                using (var uow = new UnitOfWork())
                {
                    var xpc = new XPCollection(uow, typeof(Contact.Applicant.Applicant))
                    {
                        Criteria = CriteriaOperator.Parse("n_AppID =" + caseApplicant.n_ApplicantID)
                    };
                    if (xpc.Count == 0) return "";
                    var applicant =
                        xpc[0] as Contact.Applicant.Applicant;
                    return applicant.GetOfficeENAddress();
                }
            }
            return "";
        }

        #endregion

        #region 客户联系人

        /// #################################################################
        /// <summary>
        ///     获取客户第一联系人的姓氏
        ///     Kevin Wang(2010-10-11)
        /// </summary>
        /// <returns>第一联系人的姓氏</returns>
        public string GetClientContactFirstName()
        {
            foreach (ClientContact clientcontact in ClientContacts)
            {
                if (clientcontact.n_Sequence != -1
                    && clientcontact.n_Sequence != 0) continue;

                using (var uow = new UnitOfWork())
                {
                    var xpc = new XPCollection(uow, typeof(Contact.Client.ClientContact))
                    {
                        Criteria = CriteriaOperator.Parse("n_ContactID =" + clientcontact.n_ContactID)
                    };
                    if (xpc.Count == 0) return "";
                    return ((Contact.Client.ClientContact)xpc[0]).s_FirstName;
                }
            }
            return "";
        }

        /// #################################################################
        /// <summary>
        ///     获取客户第一联系人的名称
        ///     Kevin Wang(2010-10-11)
        /// </summary>
        /// <returns>第一联系人的名称</returns>
        public string GetClientContactLastName()
        {
            foreach (ClientContact clientcontact in ClientContacts)
            {
                if (clientcontact.n_Sequence != -1
                    && clientcontact.n_Sequence != 0) continue;

                using (var uow = new UnitOfWork())
                {
                    var xpc = new XPCollection(uow, typeof(Contact.Client.ClientContact))
                    {
                        Criteria = CriteriaOperator.Parse("n_ContactID =" + clientcontact.n_ContactID)
                    };
                    if (xpc.Count == 0) return "";
                    return ((Contact.Client.ClientContact)xpc[0]).s_LastName;
                }
            }
            return "";
        }

        /// #################################################################
        /// <summary>
        ///     获取客户第一联系人的中文办公地址
        ///     Kevin Wang(2010-10-11)
        /// </summary>
        /// <returns>第一联系人的中文办公地址</returns>
        public string GetClientContactOfficeCNAddress()
        {
            foreach (ClientContact clientcontact in ClientContacts)
            {
                if (clientcontact.n_Sequence != -1
                    && clientcontact.n_Sequence != 0) continue;

                using (var uow = new UnitOfWork())
                {
                    var xpc = new XPCollection(uow, typeof(Contact.Client.ClientContact))
                    {
                        Criteria = CriteriaOperator.Parse("n_ContactID =" + clientcontact.n_ContactID)
                    };
                    if (xpc.Count == 0) return "";
                    return ((Contact.Client.ClientContact)xpc[0]).GetOfficeCNAddress().Trim();
                }
            }
            return "";
        }

        /// #################################################################
        /// <summary>
        ///     获取客户第一联系人的外文办公地址
        ///     Kevin Wang(2010-10-11)
        /// </summary>
        /// <returns>第一联系人的外文办公地址</returns>
        public string GetClientContactOfficeENAddress()
        {
            foreach (ClientContact clientcontact in ClientContacts)
            {
                if (clientcontact.n_Sequence != -1
                    && clientcontact.n_Sequence != 0) continue;

                using (var uow = new UnitOfWork())
                {
                    var xpc = new XPCollection(uow, typeof(Contact.Client.ClientContact))
                    {
                        Criteria = CriteriaOperator.Parse("n_ContactID =" + clientcontact.n_ContactID)
                    };
                    if (xpc.Count == 0) return "";
                    return ((Contact.Client.ClientContact)xpc[0]).GetOfficeENAddress();
                }
            }
            return "";
        }

        /// #################################################################
        /// <summary>
        ///     获取客户第一联系人的邮编
        ///     Kevin Wang(2010-10-11)
        /// </summary>
        /// <returns>第一联系人的邮编</returns>
        public string GetClientContactOfficeZipCode()
        {
            foreach (ClientContact clientcontact in ClientContacts)
            {
                if (clientcontact.n_Sequence != -1
                    && clientcontact.n_Sequence != 0) continue;

                using (var uow = new UnitOfWork())
                {
                    var xpc = new XPCollection(uow, typeof(Contact.Client.ClientContact))
                    {
                        Criteria = CriteriaOperator.Parse("n_ContactID =" + clientcontact.n_ContactID)
                    };
                    if (xpc.Count == 0) return "";
                    return ((Contact.Client.ClientContact)xpc[0]).GetOfficeZipCode();
                }
            }
            return "";
        }

        /// #################################################################
        /// <summary>
        ///     获取客户第一联系人的电话
        ///     Kevin Wang(2010-10-11)
        /// </summary>
        /// <returns>第一联系人的电话</returns>
        public string GetClientContactPhoneNumber()
        {
            foreach (ClientContact clientcontact in ClientContacts)
            {
                if (clientcontact.n_Sequence != -1
                    && clientcontact.n_Sequence != 0) continue;

                using (var uow = new UnitOfWork())
                {
                    var xpc = new XPCollection(uow, typeof(Contact.Client.ClientContact))
                    {
                        Criteria = CriteriaOperator.Parse("n_ContactID =" + clientcontact.n_ContactID)
                    };
                    if (xpc.Count == 0) return "";
                    return ((Contact.Client.ClientContact)xpc[0]).s_Phone;
                }
            }
            return "";
        }

        /// #################################################################
        /// <summary>
        ///     获取客户第一联系人的传真
        ///     Kevin Wang(2010-10-11)
        /// </summary>
        /// <returns>第一联系人的传真</returns>
        public string GetClientContactFax()
        {
            foreach (ClientContact clientcontact in ClientContacts)
            {
                if (clientcontact.n_Sequence != -1
                    && clientcontact.n_Sequence != 0) continue;

                using (var uow = new UnitOfWork())
                {
                    var xpc = new XPCollection(uow, typeof(Contact.Client.ClientContact))
                    {
                        Criteria = CriteriaOperator.Parse("n_ContactID =" + clientcontact.n_ContactID)
                    };
                    if (xpc.Count == 0) return "";
                    return ((Contact.Client.ClientContact)xpc[0]).s_Fax;
                }
            }
            return "";
        }

        /// #################################################################
        /// <summary>
        ///     获取客户第一联系人的国别
        ///     Kevin Wang(2010-10-11)
        /// </summary>
        /// <returns>第一联系人的国别</returns>
        public string GetClientContactCountry()
        {
            foreach (ClientContact clientcontact in ClientContacts)
            {
                if (clientcontact.n_Sequence != -1
                    && clientcontact.n_Sequence != 0) continue;

                using (var uow = new UnitOfWork())
                {
                    var xpc = new XPCollection(uow, typeof(Contact.Client.ClientContact))
                    {
                        Criteria = CriteriaOperator.Parse("n_ContactID =" + clientcontact.n_ContactID)
                    };
                    if (xpc.Count == 0) return "";
                    return ((Contact.Client.ClientContact)xpc[0]).GetCountryName();
                }
            }
            return "";
        }

        /// #################################################################
        /// <summary>
        ///     获取客户第一联系人的国别(外文）
        ///     Kevin Wang(2010-10-11)
        /// </summary>
        /// <returns>第一联系人的国别(外文）</returns>
        public string GetClientContactCountryOtherName()
        {
            foreach (ClientContact clientcontact in ClientContacts)
            {
                if (clientcontact.n_Sequence != -1
                    && clientcontact.n_Sequence != 0) continue;

                using (var uow = new UnitOfWork())
                {
                    var xpc = new XPCollection(uow, typeof(Contact.Client.ClientContact))
                    {
                        Criteria = CriteriaOperator.Parse("n_ContactID =" + clientcontact.n_ContactID)
                    };
                    if (xpc.Count == 0) return "";
                    return ((Contact.Client.ClientContact)xpc[0]).GetCountryOtherName();
                }
            }
            return "";
        }

        /// #################################################################
        /// <summary>
        ///     获取客户第一联系人的邮件
        ///     Kevin Wang(2010-10-11)
        /// </summary>
        /// <returns>第一联系人的邮件</returns>
        public string GetClientContactEmail()
        {
            foreach (ClientContact clientcontact in ClientContacts)
            {
                if (clientcontact.n_Sequence != -1
                    && clientcontact.n_Sequence != 0) continue;

                using (var uow = new UnitOfWork())
                {
                    var xpc = new XPCollection(uow, typeof(Contact.Client.ClientContact))
                    {
                        Criteria = CriteriaOperator.Parse("n_ContactID =" + clientcontact.n_ContactID)
                    };
                    if (xpc.Count == 0) return "";
                    return ((Contact.Client.ClientContact)xpc[0]).s_Email;
                }
            }
            return "";
        }

        /// #################################################################
        /// <summary>
        ///     获取客户第一联系人的称谓
        ///     Kevin Wang(2010-10-11)
        /// </summary>
        /// <returns>第一联系人的称谓</returns>
        public string GetClientContactPrefix()
        {
            foreach (ClientContact clientcontact in ClientContacts)
            {
                if (clientcontact.n_Sequence != -1
                    && clientcontact.n_Sequence != 0) continue;

                using (var uow = new UnitOfWork())
                {
                    var xpc = new XPCollection(uow, typeof(Contact.Client.ClientContact))
                    {
                        Criteria = CriteriaOperator.Parse("n_ContactID =" + clientcontact.n_ContactID)
                    };
                    if (xpc.Count == 0) return "";
                    return ((Contact.Client.ClientContact)xpc[0]).s_Prefix;
                }
            }
            return "";
        }

        public string GetClientContactJobTitle()
        {
            foreach (ClientContact clientcontact in ClientContacts)
            {
                if (clientcontact.n_Sequence != -1
                    && clientcontact.n_Sequence != 0) continue;

                using (var uow = new UnitOfWork())
                {
                    var xpc = new XPCollection(uow, typeof(Contact.Client.ClientContact))
                    {
                        Criteria = CriteriaOperator.Parse("n_ContactID =" + clientcontact.n_ContactID)
                    };
                    if (xpc.Count == 0) return "";
                    return ((Contact.Client.ClientContact)xpc[0]).s_JobTitle;
                }
            }
            return "";
        }

        #endregion

        #region [合同备案]

        /// <summary>
        ///     获取许可备案案件申请号
        ///     Coder:zhangxinyuan(2010-11-15)
        /// </summary>
        /// <param name="sSequence">顺序号</param>
        /// <returns>申请号</returns>
        public string GetPermitPatantAppNum(string sSequence)
        {
            int index = 0;
            try
            {
                index = int.Parse(sSequence) - 1;
            }
            catch (Exception)
            {
                index = 0;
            }
            string sAppNum = string.Empty;
            using (var uow = new UnitOfWork())
            {
                var xpc = new XPCollection(uow, typeof(PermitPatent))
                {
                    Criteria = CriteriaOperator.Parse("CasePermitMemo.n_CaseID=" + n_CaseID)
                };
                xpc.Sorting = new SortingCollection(new SortProperty("n_ID", SortingDirection.Ascending));
                if (xpc.Count > 0 && index < xpc.Count)
                {
                    sAppNum = ((PermitPatent)xpc[index]).s_PatentNum;
                }
            }
            return sAppNum;
        }

        #endregion

        #region [外观专利请求书]

        /// <summary>
        ///     同类产品数量CheckBox
        ///     Coder zhangxinyuan 2010-11-25
        /// </summary>
        /// <returns></returns>
        public string GetSameProductNum()
        {
            string sCheckNum = GetFormPageXML("BM_CHkSameProduct");
            return sCheckNum.ToLower();
        }

        /// <summary>
        ///     成套产品数量CheckBox
        ///     Coder zhangxinyuan 2010-11-25
        /// </summary>
        /// <returns></returns>
        public string GetSameSerialProductNum()
        {
            string sCheckNum = GetFormPageXML("BM_CHkSameSerProduct");
            return sCheckNum.ToLower();
        }

        #endregion

        //////#region [行政复议]
        ///// <summary>
        ///// 行政复议自然人姓名
        ///// Coder:zhangxinyuan(2010-11-16)
        ///// </summary>
        ///// <returns></returns>
        //public string GetReconsiderApplicantName()
        //{
        //    foreach (Applicant caseApplicant in this.Applicants)
        //    {
        //        if (caseApplicant.s_IsDelegacy == null || caseApplicant.s_IsDelegacy.ToUpper() == "N") continue;
        //        using (UnitOfWork uow = new UnitOfWork())
        //        {
        //            var xpc = new XPCollection(uow, typeof(DataEntities.Contacts.Applicant.Applicant))
        //            {
        //                Criteria = CriteriaOperator.Parse("n_AppID =" + caseApplicant.n_ApplicantID)
        //            };
        //            if (xpc.Count == 0) return "";
        //            DataEntities.Contacts.Applicant.Applicant applicant =
        //                xpc[0] as DataEntities.Contacts.Applicant.Applicant;
        //            if (applicant.s_AppType == "5")//如果是个人的话就返回申请人姓名
        //            {
        //                return applicant.s_Name;
        //            }
        //        }
        //    }
        //    return "";
        //}
        ///// <summary>
        ///// 行政复议自然人电话
        ///// Coder:zhangxinyuan(2010-11-16)
        ///// </summary>
        ///// <returns></returns>
        //public string GetReconsiderApplicantPhone()
        //{
        //    foreach (Applicant caseApplicant in this.Applicants)
        //    {
        //        if (caseApplicant.s_IsDelegacy == null || caseApplicant.s_IsDelegacy.ToUpper() == "N") continue;
        //        using (UnitOfWork uow = new UnitOfWork())
        //        {
        //            var xpc = new XPCollection(uow, typeof(DataEntities.Contacts.Applicant.Applicant))
        //            {
        //                Criteria = CriteriaOperator.Parse("n_AppID =" + caseApplicant.n_ApplicantID)
        //            };
        //            if (xpc.Count == 0) return "";
        //            DataEntities.Contacts.Applicant.Applicant applicant =
        //                xpc[0] as DataEntities.Contacts.Applicant.Applicant;
        //            if (applicant.s_AppType == "5")//如果是个人的话就返回申请人电话
        //            {
        //                return applicant.s_Phone;
        //            }
        //        }
        //    }
        //    return "";
        //}
        ///// <summary>
        ///// 行政复议自然人邮编
        ///// Coder:zhangxinyuan(2010-11-16)
        ///// </summary>
        ///// <returns></returns>
        //public string GetReconsiderApplicantZipCode()
        //{
        //    foreach (Applicant caseApplicant in this.Applicants)
        //    {
        //        if (caseApplicant.s_IsDelegacy == null || caseApplicant.s_IsDelegacy.ToUpper() == "N") continue;
        //        using (UnitOfWork uow = new UnitOfWork())
        //        {
        //            var xpc = new XPCollection(uow, typeof(DataEntities.Contacts.Applicant.Applicant))
        //            {
        //                Criteria = CriteriaOperator.Parse("n_AppID =" + caseApplicant.n_ApplicantID)
        //            };
        //            if (xpc.Count == 0) return "";
        //            DataEntities.Contacts.Applicant.Applicant applicant =
        //                xpc[0] as DataEntities.Contacts.Applicant.Applicant;
        //            if (applicant.s_AppType == "5")//如果是个人的话就返回申请人邮编
        //            {
        //                return caseApplicant.s_ZipCode;
        //            }
        //        }
        //    }
        //    return "";
        //}
        ///// <summary>
        ///// 行政复议自然人通讯地址
        ///// Coder:zhangxinyuan(2010-11-16)
        ///// </summary>
        ///// <returns></returns>
        //public string GetReconsiderApplicantAddr()
        //{
        //    foreach (Applicant caseApplicant in this.Applicants)
        //    {
        //        if (caseApplicant.s_IsDelegacy == null || caseApplicant.s_IsDelegacy.ToUpper() == "N") continue;
        //        using (UnitOfWork uow = new UnitOfWork())
        //        {
        //            var xpc = new XPCollection(uow, typeof(DataEntities.Contacts.Applicant.Applicant))
        //            {
        //                Criteria = CriteriaOperator.Parse("n_AppID =" + caseApplicant.n_ApplicantID)
        //            };
        //            if (xpc.Count == 0) return "";
        //            DataEntities.Contacts.Applicant.Applicant applicant =
        //                xpc[0] as DataEntities.Contacts.Applicant.Applicant;
        //            if (applicant.s_AppType == "5")//如果是个人的话就返回申请人通讯地址
        //            {
        //                return caseApplicant.GetCNAddresss();
        //            }
        //        }
        //    }
        //    return "";
        //}
        ///// <summary>
        ///// 行政复议法人姓名
        ///// Coder:zhangxinyuan(2010-11-16)
        ///// </summary>
        ///// <returns></returns>
        //public string GetReconsiderCorporationName()
        //{
        //    foreach (Applicant caseApplicant in this.Applicants)
        //    {
        //        if (caseApplicant.s_IsDelegacy == null || caseApplicant.s_IsDelegacy.ToUpper() == "N") continue;
        //        using (UnitOfWork uow = new UnitOfWork())
        //        {
        //            var xpc = new XPCollection(uow, typeof(DataEntities.Contacts.Applicant.Applicant))
        //            {
        //                Criteria = CriteriaOperator.Parse("n_AppID =" + caseApplicant.n_ApplicantID)
        //            };
        //            if (xpc.Count == 0) return "";
        //            DataEntities.Contacts.Applicant.Applicant applicant =
        //                xpc[0] as DataEntities.Contacts.Applicant.Applicant;
        //            if (applicant.s_AppType !="5")//如果不是个人的话就返回申请人姓名
        //            {
        //                return applicant.s_Name;
        //            }
        //        }
        //    }
        //    return "";
        //}
        ///// <summary>
        ///// 行政复议法人第一联系人姓名
        ///// Coder:zhangxinyuan(2010-11-16)
        ///// </summary>
        ///// <returns></returns>
        //public string GetReconsiderCorporationFstContactName()
        //{
        //    foreach (Applicant caseApplicant in this.Applicants)
        //    {
        //        if (caseApplicant.s_IsDelegacy == null || caseApplicant.s_IsDelegacy.ToUpper() == "N") continue;
        //        using (UnitOfWork uow = new UnitOfWork())
        //        {
        //            var xpc = new XPCollection(uow, typeof(DataEntities.Contacts.Applicant.Applicant))
        //            {
        //                Criteria = CriteriaOperator.Parse("n_AppID =" + caseApplicant.n_ApplicantID)
        //            };
        //            if (xpc.Count == 0) return "";
        //            DataEntities.Contacts.Applicant.Applicant applicant =
        //                xpc[0] as DataEntities.Contacts.Applicant.Applicant;
        //            if (applicant.s_AppType != "5")//如果不是个人的话就返回申请人姓名
        //            {
        //                return caseApplicant.GetProposerContactOfficeCNAddress();
        //            }
        //        }
        //    }
        //    return "";
        //}
        ///// <summary>
        ///// 行政复议法人电话
        ///// Coder:zhangxinyuan(2010-11-16)
        ///// </summary>
        ///// <returns></returns>
        //public string GetReconsiderCorporationPhone()
        //{
        //    foreach (Applicant caseApplicant in this.Applicants)
        //    {
        //        if (caseApplicant.s_IsDelegacy == null || caseApplicant.s_IsDelegacy.ToUpper() == "N") continue;
        //        using (UnitOfWork uow = new UnitOfWork())
        //        {
        //            var xpc = new XPCollection(uow, typeof(DataEntities.Contacts.Applicant.Applicant))
        //            {
        //                Criteria = CriteriaOperator.Parse("n_AppID =" + caseApplicant.n_ApplicantID)
        //            };
        //            if (xpc.Count == 0) return "";
        //            DataEntities.Contacts.Applicant.Applicant applicant =
        //                xpc[0] as DataEntities.Contacts.Applicant.Applicant;
        //            if (applicant.s_AppType != "5")//如果不是个人的话就返回申请人电话
        //            {
        //                return applicant.s_Phone;
        //            }
        //        }
        //    }
        //    return "";
        //}
        ///// <summary>
        ///// 行政复议自然人邮编
        ///// Coder:zhangxinyuan(2010-11-16)
        ///// </summary>
        ///// <returns></returns>
        //public string GetReconsiderCorporationZipCode()
        //{
        //    foreach (Applicant caseApplicant in this.Applicants)
        //    {
        //        if (caseApplicant.s_IsDelegacy == null || caseApplicant.s_IsDelegacy.ToUpper() == "N") continue;
        //        using (UnitOfWork uow = new UnitOfWork())
        //        {
        //            var xpc = new XPCollection(uow, typeof(DataEntities.Contacts.Applicant.Applicant))
        //            {
        //                Criteria = CriteriaOperator.Parse("n_AppID =" + caseApplicant.n_ApplicantID)
        //            };
        //            if (xpc.Count == 0) return "";
        //            DataEntities.Contacts.Applicant.Applicant applicant =
        //                xpc[0] as DataEntities.Contacts.Applicant.Applicant;
        //            if (applicant.s_AppType != "5")//如果是个人的话就返回申请人邮编
        //            {
        //                return caseApplicant.s_ZipCode;
        //            }
        //        }
        //    }
        //    return "";
        //}
        ///// <summary>
        ///// 行政复议自然人通讯地址
        ///// Coder:zhangxinyuan(2010-11-16)
        ///// </summary>
        ///// <returns></returns>
        //public string GetReconsiderCorporationAddr()
        //{
        //    foreach (Applicant caseApplicant in this.Applicants)
        //    {
        //        if (caseApplicant.s_IsDelegacy == null || caseApplicant.s_IsDelegacy.ToUpper() == "N") continue;
        //        using (UnitOfWork uow = new UnitOfWork())
        //        {
        //            var xpc = new XPCollection(uow, typeof(DataEntities.Contacts.Applicant.Applicant))
        //            {
        //                Criteria = CriteriaOperator.Parse("n_AppID =" + caseApplicant.n_ApplicantID)
        //            };
        //            if (xpc.Count == 0) return "";
        //            DataEntities.Contacts.Applicant.Applicant applicant =
        //                xpc[0] as DataEntities.Contacts.Applicant.Applicant;
        //            if (applicant.s_AppType != "5")//如果是个人的话就返回申请人通讯地址
        //            {
        //                return caseApplicant.GetCNAddresss();
        //            }
        //        }
        //    }
        //    return "";
        //}
        /////#endregion


        #endregion
    }
}
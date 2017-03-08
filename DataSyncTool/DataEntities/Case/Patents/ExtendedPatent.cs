using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataEntities.Config;
using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using DevExpress.Xpo.DB;

namespace DataEntities.Case.Patents
{
    [MapInheritance(MapInheritanceType.ParentTable)]
    public class ExtendedPatent : BasicPatent
    {
        //此字段只是用于PA导入数据
        [NonPersistent]
        public string PA_FilePathRoot { get; set; }

        //此字段只是用于PA导入数据
        [NonPersistent]
        public string IPS_FilePathRoot { get; set; }

        //=======================================================================
        /// <summary>
        ///     专利发明人
        /// </summary>
        [Aggregated, Association("Patent-Inventors", typeof(Inventor))]
        public XPCollection Inventors
        {
            get { return GetCollection("Inventors"); }
        }

        //=======================================================================
        /// <summary>
        ///     专利优先权的集合
        /// </summary>
        [Aggregated, Association("Patent-Priorities", typeof(Priority))]
        public XPCollection Priorities
        {
            get { return GetCollection("Priorities"); }
        }

        //=======================================================================
        /// <summary>
        ///     案件相关的对方人员
        /// </summary>
        [Aggregated, Association("Patent-OppositePersons", typeof(OppositePerson))]
        public XPCollection OppositePersons
        {
            get { return GetCollection("OppositePersons"); }
        }

        /// <summary>
        ///     获取所有发明人的名称（以分号分隔）
        ///     Coder:zhangxinyuan(2010-11-11)
        /// </summary>
        public string AllInventorNames
        {
            get
            {
                string sInventors = "";
                foreach (object inv in Inventors)
                {
                    sInventors += ((Inventor)inv).s_Name + ";";
                }
                sInventors = sInventors.TrimEnd(';');
                return sInventors;
            }
        }

        #region 方法

        /// <summary>
        ///     第一发明人的姓名
        /// </summary>
        [Delayed]
        public string FirstInventorName
        {
            get
            {
                Inventors.Sorting =
                    new SortingCollection(new SortProperty("n_Sequence", SortingDirection.Ascending));
                Inventor inventor = Inventors.Cast<Inventor>().FirstOrDefault();
                return inventor == null ? string.Empty : inventor.s_Name;
            }
        }

        /// <summary>
        ///     第二发明人的姓名
        /// </summary>
        [Delayed]
        public string SecondInventorName
        {
            get
            {
                Inventors.Sorting =
                    new SortingCollection(new SortProperty("n_Sequence", SortingDirection.Ascending));
                Inventor inventor = Inventors.Cast<Inventor>().Skip(1).FirstOrDefault();
                return inventor == null ? string.Empty : inventor.s_Name;
            }
        }

        /// <summary>
        ///     第一发明人的外国姓名
        /// </summary>
        [Delayed]
        public string FirstInventorNativeName
        {
            get
            {
                Inventors.Sorting =
                    new SortingCollection(new SortProperty("n_Sequence", SortingDirection.Ascending));
                Inventor inventor = Inventors.Cast<Inventor>().FirstOrDefault();
                return inventor == null ? string.Empty : inventor.s_NativeName;
            }
        }

        /// <summary>
        ///     第二发明人的外国姓名
        /// </summary>
        [Delayed]
        public string SecondInventorNativeName
        {
            get
            {
                Inventors.Sorting =
                    new SortingCollection(new SortProperty("n_Sequence", SortingDirection.Ascending));
                Inventor inventor = Inventors.Cast<Inventor>().Skip(1).FirstOrDefault();
                return inventor == null ? string.Empty : inventor.s_NativeName;
            }
        }

        /// <summary>
        ///     第一发明人地址
        /// </summary>
        [Delayed]
        public string FirstInventorAddress
        {
            get
            {
                Inventors.Sorting =
                    new SortingCollection(new SortProperty("n_Sequence", SortingDirection.Ascending));
                Inventor inventor = Inventors.Cast<Inventor>().FirstOrDefault();
                return inventor == null ? string.Empty : inventor.s_Address;
            }
        }

        /// <summary>
        ///     第二发明人地址
        /// </summary>
        [Delayed]
        public string SecondInventorAddress
        {
            get
            {
                Inventors.Sorting =
                    new SortingCollection(new SortProperty("n_Sequence", SortingDirection.Ascending));
                Inventor inventor = Inventors.Cast<Inventor>().Skip(1).FirstOrDefault();
                return inventor == null ? string.Empty : inventor.s_Address;
            }
        }

        /// <summary>
        ///     第一发明人外国地址
        /// </summary>
        [Delayed]
        public string FirstInventorNativeAddress
        {
            get
            {
                Inventors.Sorting =
                    new SortingCollection(new SortProperty("n_Sequence", SortingDirection.Ascending));
                Inventor inventor = Inventors.Cast<Inventor>().FirstOrDefault();
                return inventor == null ? string.Empty : inventor.s_NativeAddress;
            }
        }

        /// <summary>
        ///     第二发明人外国地址
        /// </summary>
        [Delayed]
        public string SecondInventorNativeAddress
        {
            get
            {
                Inventors.Sorting =
                    new SortingCollection(new SortProperty("n_Sequence", SortingDirection.Ascending));
                Inventor inventor = Inventors.Cast<Inventor>().Skip(1).FirstOrDefault();
                return inventor == null ? string.Empty : inventor.s_NativeAddress;
            }
        }

        /// #################################################################
        /// <summary>
        ///     获取所有发明人名称
        ///     Kevin Wang(2010-10-25)
        /// </summary>
        /// <returns>所有发明人名称</returns>
        public string GetInventorNames(string sSplit)
        {
            string sNames = "";

            IOrderedEnumerable<Inventor> Invertors = from e in Inventors.Cast
                <Inventor>()
                                                     orderby e.n_Sequence
                                                     select e;

            switch (sSplit)
            {
                case "1":
                    foreach (Inventor app in Invertors)
                    {
                        sNames += app.s_Name + ";";
                    }
                    sNames = sNames.TrimEnd(new[] { ';' });
                    break;
                case "2":
                    foreach (Inventor app in Invertors)
                    {
                        sNames += app.s_Name + "    ";
                    }
                    sNames = sNames.Trim();
                    break;
                case "3":
                    foreach (Inventor app in Invertors)
                    {
                        sNames += app.s_Name + "、";
                    }
                    sNames = sNames.TrimEnd(new[] { '、' });
                    break;
                case "4":
                    foreach (Inventor app in Invertors)
                    {
                        sNames += app.s_Name + "；";
                    }
                    sNames = sNames.TrimEnd(new[] { '；' });
                    break;
                case "5":
                    int iCount = 1;
                    sNames = " ";
                    foreach (Inventor app in Invertors)
                    {
                        sNames += " " + iCount + "." + app.s_Name;
                    }
                    break;
            }
            return sNames;
        }

        /// #################################################################
        /// <summary>
        ///     获取所有发明人其他名称
        ///     Kevin Wang(2010-10-25)
        /// </summary>
        /// <returns>所有发明人其他名称</returns>
        public string GetInventorOtherNames()
        {
            string sNames = "";

            //2013-01-29 lixin for bug 26607
            IOrderedEnumerable<Inventor> Invertors = from e in Inventors.Cast
                <Inventor>()
                                                     orderby e.n_Sequence
                                                     select e;

            foreach (Inventor app in Invertors)
            {
                sNames += app.s_NativeName + ";";
            }

            //foreach (Inventor person in this.Inventors)
            //{
            //    sNames += person.s_NativeName + ";";
            //}
            sNames = sNames.TrimEnd(new[] { ';' }); //去掉最后一个分号   
            return sNames;
        }

        /// #################################################################
        /// <summary>
        ///     获取第一发明人的国籍
        ///     Kevin Wang(2010-12-30)
        /// </summary>
        /// <returns>第一发明人的国籍</returns>
        public string Get1stInventorCountry()
        {
            Inventors.Sorting = new SortingCollection(new SortProperty("n_Sequence", SortingDirection.Ascending));
            foreach (Inventor person in Inventors)
            {
                //if (person.n_Sequence != 0 || person.n_Sequence != -1) continue;
                using (var uow = new UnitOfWork())
                {
                    var xpc = new XPCollection(uow, typeof(CodeCountry))
                    {
                        Criteria = CriteriaOperator.Parse("n_ID =" + person.n_Country)
                    };
                    if (xpc.Count == 0)
                    {
                        return "";
                    }
                    return ((CodeCountry)xpc[0]).s_Name;
                }
            }

            return "";
        }

        /// #################################################################
        /// <summary>
        ///     获取第一发明人的国籍
        ///     gengxuejiao(2010-12-30)
        /// </summary>
        /// <returns>第一发明人的国籍(英文)</returns>
        public string Get1EnstInventorCountry()
        {
            Inventors.Sorting = new SortingCollection(new SortProperty("n_Sequence", SortingDirection.Ascending));
            foreach (Inventor person in Inventors)
            {
                //if (person.n_Sequence != 0 || person.n_Sequence != -1) continue;
                using (var uow = new UnitOfWork())
                {
                    var xpc = new XPCollection(uow, typeof(CodeCountry))
                    {
                        Criteria = CriteriaOperator.Parse("n_ID =" + person.n_Country)
                    };
                    if (xpc.Count == 0)
                    {
                        return "";
                    }
                    return ((CodeCountry)xpc[0]).s_OtherName;
                }
            }

            return "";
        }

        /// #################################################################
        /// <summary>
        ///     获取第一发明人身份证号
        ///     Kevin Wang(2010-12-30)
        /// </summary>
        /// <returns>第一发明人身份证号</returns>
        public string Get1stInventorIDCard()
        {
            Inventors.Sorting = new SortingCollection(new SortProperty("n_Sequence", SortingDirection.Ascending));
            foreach (Inventor person in Inventors)
            {
                //if (person.n_Sequence != 0 || person.n_Sequence != -1) continue;
                return person.s_IDCard;
            }

            return "";
        }

        /// #################################################################
        /// <summary>
        ///     获取第一发明人
        ///     Kevin Wang(2010-12-30)
        /// </summary>
        /// <returns></returns>
        public Inventor Get1stInventor()
        {
            Inventors.Sorting = new SortingCollection(new SortProperty("n_Sequence", SortingDirection.Ascending));
            foreach (Inventor person in Inventors)
            {
                //if (person.n_Sequence != 0 || person.n_Sequence != -1) continue;
                return person;
            }

            return null;
        }

        #region 优先权

        /// ############################################################
        /// <summary>
        ///     最早优先权日
        ///     coder: Kevin Wang(2010-10-12)
        /// </summary>
        /// <returns>优先权日</returns>
        public DateTime FstPriorityDate
        {
            get
            {
                if (Priorities.Count <= 0) return DateTime.MinValue;

                Priorities.Sorting =
                    new SortingCollection(new SortProperty("dt_PDate", SortingDirection.Ascending));
                return ((Priority)Priorities[0]).dt_PDate;
            }
        }

        /// ############################################################
        /// <summary>
        ///     获取当天日期（电子申请使用）
        /// </summary>
        /// <returns></returns>
        public string Today
        {
            get { return DateTime.Now.ToShortDateString(); }
        }

        /// ############################################################
        /// <summary>
        ///     获取最早优先权国家
        ///     coder: Kevin Wang(2010-10-12)
        /// </summary>
        /// <returns>国家</returns>
        public string Get1StPriorityCountry()
        {
            if (Priorities.Count <= 0) return "";

            Priorities.Sorting =
                new SortingCollection(new SortProperty("dt_PDate", SortingDirection.Ascending));

            using (var uow = new UnitOfWork())
            {
                var xpc = new XPCollection(uow, typeof(CodeCountry))
                {
                    Criteria = CriteriaOperator.Parse("n_ID =" + ((Priority)Priorities[0]).n_PCountry)
                };
                return xpc.Count == 0 ? "" : ((CodeCountry)xpc[0]).s_Name;
            }
        }

        /// ############################################################
        /// <summary>
        ///     获取最早优先权国家(英文)
        ///     coder: gengxuejiao(2010-10-12)
        /// </summary>
        /// <returns>国家</returns>
        public string Get1ENStPriorityCountry()
        {
            if (Priorities.Count <= 0) return "";

            Priorities.Sorting =
                new SortingCollection(new SortProperty("dt_PDate", SortingDirection.Ascending));

            using (var uow = new UnitOfWork())
            {
                var xpc = new XPCollection(uow, typeof(CodeCountry))
                {
                    Criteria = CriteriaOperator.Parse("n_ID =" + ((Priority)Priorities[0]).n_PCountry)
                };
                return xpc.Count == 0 ? "" : ((CodeCountry)xpc[0]).s_OtherName;
            }
        }

        /// ############################################################
        /// <summary>
        ///     获取最早优先权日
        ///     coder: Kevin Wang(2010-10-12)
        /// </summary>
        /// <returns>优先权日</returns>
        public DateTime Get1StPriorityDate()
        {
            if (Priorities.Count <= 0) return DateTime.MinValue;

            Priorities.Sorting =
                new SortingCollection(new SortProperty("dt_PDate", SortingDirection.Ascending));
            return ((Priority)Priorities[0]).dt_PDate;
        }

        ///// ############################################################
        ///// <summary>
        /////     获取最早优先权日(日月年中文格式）
        /////     coder: zhangxinyuan(2010-11-17)
        ///// </summary>
        ///// <returns>优先权日(日月年格式）</returns>
        //public string Get1StPriorityDateddMMyyyy(string sCount)
        //{
        //    if (Priorities.Count <= 0) return "";
        //    if (Priorities.Count <= Convert.ToInt32(sCount)) return "";
        //    Priorities.Sorting =
        //        new SortingCollection(new SortProperty("dt_PDate", SortingDirection.Ascending));
        //    DateTime dt_PDate = ((Priority)Priorities[Convert.ToInt32(sCount)]).dt_PDate;
        //    return ServerDate.GetDateInCNDayMonthYear(dt_PDate);
        //}

        ///// ############################################################
        ///// <summary>
        /////     获取最早优先权日(日月年中文格式）
        /////     coder: zhangxinyuan(2010-11-17)
        ///// </summary>
        ///// <returns>优先权日(日月年格式）</returns>
        //public string Get1StPriorityDateddMMyyyyBySequen(string sCount)
        //{
        //    if (Priorities.Count <= 0) return "";
        //    if (Priorities.Count <= Convert.ToInt32(sCount)) return "";
        //    Priorities.Sorting =
        //        new SortingCollection(new SortProperty("n_Sequence", SortingDirection.Ascending));
        //    DateTime dt_PDate = ((Priority)Priorities[Convert.ToInt32(sCount)]).dt_PDate;
        //    return ServerDate.GetDateInCNDayMonthYear(dt_PDate);
        //}

        ///// ############################################################
        ///// <summary>
        /////     获取最早优先权日(中文格式）
        /////     coder: Kevin Wang(2010-10-25)
        ///// </summary>
        ///// <returns>优先权日(中文格式）</returns>
        //public string Get1StPriorityDateInCNFormat()
        //{
        //    if (Priorities.Count <= 0)
        //    {
        //        return "";
        //    }
        //    return ServerDate.GetDateInCNFormat(Get1StPriorityDate());
        //}

        ///// ############################################################
        ///// <summary>
        /////     获取最早优先权日(英文格式）
        /////     coder: Kevin Wang(2010-10-25)
        ///// </summary>
        ///// <returns>优先权日(英文格式）</returns>
        //public string Get1StPriorityDateInENFormat()
        //{
        //    if (Priorities.Count <= 0)
        //    {
        //        return "";
        //    }
        //    return ServerDate.GetDateInENFormat(Get1StPriorityDate());
        //}

        /// ############################################################
        /// <summary>
        ///     获取最早优先权日(英文格式）
        ///     coder: Kevin Wang(2010-10-25)
        /// </summary>
        /// <returns>优先权日(英文格式）</returns>
        public string Get1StPriorityDateInENFormatForHongkong()
        {
            if (Priorities.Count <= 0)
            {
                return "";
            }
            return Get1StPriorityDate().ToString("dd/MM/yyyy");
        }

        /// <summary>
        /// 获取最早优先权日或申请日
        /// </summary>
        /// <returns></returns>
        public DateTime GetFStPriorityDateOrAppleDate()
        {
            DateTime dtFStPriorityDate = Get1StPriorityDate();
            if (dtFStPriorityDate == DateTime.MinValue)
            {
                return this.TheLawInfo.dt_AppDate;
            }
            return dtFStPriorityDate;
        }

        ///// <summary>
        ///// 获取最早优先权日或申请日(外文)
        ///// </summary>
        ///// <returns></returns>
        //public string GetENFStPriorityDateOrAppleDate()
        //{
        //    DateTime dtFStPriorityDate = Get1StPriorityDate();
        //    if (dtFStPriorityDate == DateTime.MinValue)
        //    {
        //        return ServerDate.GetDateInENFormat(TheLawInfo.dt_AppDate);
        //    }
        //    return ServerDate.GetDateInENFormat(dtFStPriorityDate);
        //}

        ///// <summary>
        ///// 获取所有优先权信息(外文)
        ///// </summary>
        ///// <returns></returns>
        //public string GetAllPriorityInfoEN()
        //{
        //    List<Priority> listPriority = Priorities.Cast<Priority>().OrderBy(o => o.n_Sequence).ToList();
        //    if (listPriority.Count == 0) return string.Empty;
        //    var sbPriority = new StringBuilder();
        //    var uow = new UnitOfWork();
        //    foreach (var priority in listPriority)
        //    {
        //        if (sbPriority.Length != 0) sbPriority.Append("\r\n");
        //        var country = uow.GetObjectByKey<CodeCountry>(priority.n_PCountry);
        //        sbPriority.Append(country == null ? "NULL" : country.s_CountryCode);
        //        sbPriority.Append(" Patent Application No. ");
        //        sbPriority.Append(priority.s_PNum);
        //        sbPriority.Append(" filed on ");
        //        sbPriority.Append(BasicFacility.Utility.ServerDate.GetDateInENFormat(priority.dt_PDate));
        //    }
        //    return sbPriority.ToString();
        //}

        /// ############################################################
        /// <summary>
        ///     获取最早优先权人
        ///     coder: Kevin Wang(2010-10-25)
        /// </summary>
        /// <returns>优先权人</returns>
        public string Get1StPriority()
        {
            if (Priorities.Count <= 0) return "";

            Priorities.Sorting =
                new SortingCollection(new SortProperty("dt_PDate", SortingDirection.Ascending));
            return ((Priority)Priorities[0]).s_Priority;
        }

        /// ############################################################
        /// <summary>
        ///     获取最早优先权号
        ///     coder: Kevin Wang(2010-10-12)
        /// </summary>
        /// <returns>优先权号</returns>
        public string Get1StPriorityDateNumber()
        {
            if (Priorities.Count <= 0) return "";

            Priorities.Sorting =
                new SortingCollection(new SortProperty("dt_PDate", SortingDirection.Ascending));
            return ((Priority)Priorities[0]).s_PNum;
        }

        #endregion

        #region 发明书式

        #endregion

        #endregion

        #region 高级查询所用的特殊字段

        /// <summary>
        ///     第一优先权日期，高级查询使用(数据库中存的第一个，不是最早，也不一定是列表中第一个）
        /// </summary>
        public DateTime FirstPriorityDate
        {
            get
            {
                if (Priorities.Count <= 0) return DateTime.MinValue;

                Priorities.Sorting =
                    new SortingCollection(new SortProperty("dt_PDate", SortingDirection.Ascending));

                return ((Priority)Priorities[0]).dt_PDate;
            }
        }

        /// <summary>
        ///     第一优先权日期，高级查询使用(数据库中存的第一个，不是最早，也不一定是列表中第一个）
        /// </summary>
        public string FirstPriorityNo
        {
            get
            {
                if (Priorities.Count <= 0) return "";

                Priorities.Sorting =
                    new SortingCollection(new SortProperty("dt_PDate", SortingDirection.Ascending));

                return ((Priority)Priorities[0]).s_PNum;
            }
        }

        /// <summary>
        ///     第一优先权，高级查询使用
        /// </summary>
        public string FristPriority
        {
            get
            {
                if (Priorities.Count <= 0) return string.Empty;

                return ((Priority)Priorities[0]).s_Priority;
            }
        }

        /// <summary>
        ///     发明人地址，高级查询使用
        /// </summary>
        public string InventorAddress
        {
            get
            {
                string sAdd = "";
                foreach (Inventor inventor in Inventors)
                {
                    if (inventor == null) continue;
                    sAdd += inventor.s_Address + " ";
                }
                return sAdd;
            }
        }

        #endregion

        #region 电子申请使用

        [NonPersistent]
        public string s_UtilityName
        {
            get
            {
                using (var tempUow = new UnitOfWork())
                {
                    var codePtcType = tempUow.GetObjectByKey<CodePTCType>(n_PatentTypeID);
                    if (codePtcType != null && codePtcType.s_RegularName == "Model") return s_CaseName;
                }
                return string.Empty;
            }
        }

        [NonPersistent]
        public string s_UtilityMode
        {
            get
            {
                using (var tempUow = new UnitOfWork())
                {
                    var codePtcType = tempUow.GetObjectByKey<CodePTCType>(n_PatentTypeID);
                    if (codePtcType != null && codePtcType.s_RegularName == "Model") return "1";
                }
                return "0";
            }
        }

        [NonPersistent]
        public string s_DesignName
        {
            get
            {
                using (var tempUow = new UnitOfWork())
                {
                    var codePtcType = tempUow.GetObjectByKey<CodePTCType>(n_PatentTypeID);
                    if (codePtcType != null && codePtcType.s_RegularName == "Design") return s_CaseName;
                }
                return string.Empty;
            }
        }

        [NonPersistent]
        public string s_DesignMode
        {
            get
            {
                using (var tempUow = new UnitOfWork())
                {
                    var codePtcType = tempUow.GetObjectByKey<CodePTCType>(n_PatentTypeID);
                    if (codePtcType != null && codePtcType.s_RegularName == "Design") return "1";
                }
                return "0";
            }
        }

        #endregion

        public ExtendedPatent(Session session) : base(session) { }
        public ExtendedPatent() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }
}
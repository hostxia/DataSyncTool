using System;
using DataEntities.Config;
using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using DevExpress.Xpo.DB;

namespace DataEntities.Case.Trademarks
{
    [MapInheritance(MapInheritanceType.ParentTable)]
    public class ExtendedTrademark : BasicTrademark
    {
        private readonly XPDelayedProperty fimg_MainOrigImg = new XPDelayedProperty();
        private readonly XPDelayedProperty fn_GroupID = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_ApplyType = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_CollectiveApp = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_IsMultClass = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_MadBasicType = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_Notes = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_TrademarkDesc = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_TrademarkStatus = new XPDelayedProperty();

        private bool _fbDivisionalCaseFlag;
        private string _fsOrigAppNo;
        private readonly XPDelayedProperty fdt_OrigAppDate = new XPDelayedProperty();
        private XPDelayedProperty fdt_DivSubmitDate = new XPDelayedProperty();
        private string _fsOrigCaseNo;

        public ExtendedTrademark(Session session)
            : base(session)
        {
        }

        public ExtendedTrademark()
            : base(Session.DefaultSession)
        {
        }

        [Delayed("fn_GroupID")]
        public int n_GroupID
        {
            get
            {
                if (fn_GroupID.Value == null)
                {
                    return -1;
                }
                return (int)fn_GroupID.Value;
            }
            set { fn_GroupID.Value = value; }
        }

        [Delayed("fimg_MainOrigImg")]
        public byte[] img_MainOrigImg
        {
            get { return (byte[])fimg_MainOrigImg.Value; }
            set { fimg_MainOrigImg.Value = value; }
        }

        [Aggregated, Association("Trademark-Goods", typeof(Goods))]
        public XPCollection TheGoods
        {
            get { return GetCollection("TheGoods"); }
        }

        [Aggregated, Association("Trademark-Priorities", typeof(Priority))]
        public XPCollection Priorities
        {
            get { return GetCollection("Priorities"); }
        }

        [Aggregated, Association("Trademark-MadridCountries", typeof(MadridCountry))]
        public XPCollection MadridCountries
        {
            get { return GetCollection("MadridCountries"); }
        }

        [Aggregated, Association("Trademark-OtherImages", typeof(OtherImage))]
        public XPCollection OtherImages
        {
            get { return GetCollection("OtherImages"); }
        }

        [Aggregated, Association("Trademark-MadridBasicApp", typeof(MadridBasicApp))]
        public XPCollection MadridBasicApps
        {
            get { return GetCollection("MadridBasicApps"); }
        }

        [Aggregated, Association("Trademark-MadridInfo", typeof(MadridInfo))]
        public XPCollection MadridInfo
        {
            get { return GetCollection("MadridInfo"); }
        }

        [Delayed("fs_TrademarkDesc")]
        public string s_TrademarkDesc
        {
            get { return (string)fs_TrademarkDesc.Value; }
            set { fs_TrademarkDesc.Value = value; }
        }

        [Delayed("fs_ApplyType")]
        public string s_ApplyType
        {
            get { return (string)fs_ApplyType.Value; }
            set { fs_ApplyType.Value = value; }
        }

        [Delayed("fs_IsMultClass")]
        public string s_IsMultClass
        {
            get { return (string)fs_IsMultClass.Value; }
            set { fs_IsMultClass.Value = value; }
        }

        [Delayed("fs_CollectiveApp")]
        public string s_CollectiveApp
        {
            get { return (string)fs_CollectiveApp.Value; }
            set { fs_CollectiveApp.Value = value; }
        }

        [Delayed("fs_MadBasicType")]
        public string s_MadBasicType
        {
            get { return (string)fs_MadBasicType.Value; }
            set { fs_MadBasicType.Value = value; }
        }

        [Delayed("fs_Notes")]
        [Size(800)]
        public string s_Notes
        {
            get { return (string)fs_Notes.Value; }
            set { fs_Notes.Value = value; }
        }

        [Delayed("fs_TrademarkStatus")]
        [Size(50)]
        public string s_TrademarkStatus
        {
            get { return (string)fs_TrademarkStatus.Value; }
            set { fs_TrademarkStatus.Value = value; }
        }

        public string MadBaseAppNO
        {
            get
            {
                if (MadridBasicApps.Count > 0) return (MadridBasicApps[0] as MadridBasicApp).s_BasicAppNO;
                return string.Empty;
            }
        }

        public string MadBaseAppDate
        {
            get
            {
                if (MadridBasicApps.Count > 0)
                    return (MadridBasicApps[0] as MadridBasicApp).dt_BasicAppDate.ToShortDateString();
                return string.Empty;
            }
        }

        public string MadBaseRegNO
        {
            get
            {
                if (MadridBasicApps.Count > 0)
                    return (MadridBasicApps[0] as MadridBasicApp).s_BasicRegNO;
                return string.Empty;
            }
        }

        public string MadBaseRegDate
        {
            get
            {
                if (MadridBasicApps.Count > 0)
                    return (MadridBasicApps[0] as MadridBasicApp).dt_BasicRegDate.ToShortDateString();
                return string.Empty;
            }
        }

        [NonPersistent]
        public bool Check { get; set; }


        public bool b_DivisionalCaseFlag
        {
            get { return _fbDivisionalCaseFlag; }
            set { SetPropertyValue("b_DivisionalCaseFlag", ref _fbDivisionalCaseFlag, value); }
        }

        [Size(50)]
        public string s_OrigAppNo
        {
            get { return _fsOrigAppNo; }
            set { SetPropertyValue("s_OrigAppNo", ref _fsOrigAppNo, value); }
        }

        [Delayed("fdt_OrigAppDate")]
        public DateTime dt_OrigAppDate
        {
            get
            {
                if (fdt_OrigAppDate.Value == null) return DateTime.MinValue;
                return (DateTime)fdt_OrigAppDate.Value;
            }
            set { fdt_OrigAppDate.Value = value; }
        }

        [Delayed("fdt_DivSubmitDate")]
        public DateTime dt_DivSubmitDate
        {
            get
            {
                if (fdt_DivSubmitDate.Value == null) return DateTime.MinValue;
                return (DateTime)fdt_DivSubmitDate.Value;
            }
            set { fdt_DivSubmitDate.Value = value; }
        }

        [Size(50)]
        public string s_OrigCaseNo
        {
            get { return _fsOrigCaseNo; }
            set { SetPropertyValue("s_OrigCaseNo", ref _fsOrigCaseNo, value); }
        }

        #region 自定义方法

        /// ############################################################
        /// <summary>
        ///     获取所有商品服务项目
        ///     coder: Kevin Wang(2010-09-10)
        /// </summary>
        /// <returns>商品服务项目明细（中文名称+分号）</returns>
        public string GetAllGoods()
        {
            string sGoods = "";
            int i = 0;
            foreach (Goods theGood in TheGoods)
            {
                i++;
                sGoods += i + "、" + theGood.s_GoodsName + "；";
            }
            if (sGoods.EndsWith(";")) sGoods = sGoods.Substring(0, sGoods.Length - 1);
            sGoods += "。";
            return sGoods;
        }

        /// ############################################################
        /// <summary>
        ///     获取所有商品服务项目英文名称
        ///     coder: Kevin Wang(2010-09-10)
        /// </summary>
        /// <returns>商品服务项目明细（英文名称+分号）</returns>
        public string GetAllGoodsEN()
        {
            string sGoods = "";
            foreach (Goods theGood in TheGoods)
            {
                sGoods += theGood.s_OtherName + ";";
            }
            sGoods = sGoods.TrimEnd(new[] { ';' });
            sGoods += ".";
            return sGoods;
        }

        /// ############################################################
        /// <summary>
        ///     获取所有商品服务项目英文名称
        ///     coder: Kevin Wang(2010-09-10)
        /// </summary>
        /// <returns>商品服务项目明细（英文名称+分号）</returns>
        public string GetAllGoodsContainsClass()
        {
            string sGoods = "";
            string[] sClass = s_TrademarkClass.Split(',');
            for (int i = 0; i < sClass.Length; i++)
            {
                if (string.IsNullOrEmpty(sClass[i])) continue;
                sGoods += "Class  " + sClass[i] + ":";
                TheGoods.Filter = CriteriaOperator.Parse("n_TrademarkClass = ?", Convert.ToInt32(sClass[i]));
                foreach (Goods theGood in TheGoods)
                {
                    sGoods += theGood.s_GoodsName + ";";
                }
                TheGoods.Filter = CriteriaOperator.Parse("1=1");
            }
            sGoods = sGoods.TrimEnd(new[] { ';' });
            sGoods += ".";
            return sGoods;
        }

        /// ############################################################
        /// <summary>
        ///     判断是否是共同申请
        ///     coder: Kevin Wang(2010-09-10)
        /// </summary>
        /// <returns>共同申请为true，否则为false</returns>
        public string CollectiveApp()
        {
            if (String.IsNullOrEmpty(s_CollectiveApp) == false)
            {
                return s_CollectiveApp.ToUpper() == "Y" ? "true" : "false";
            }
            return "false";
        }

        /// ############################################################
        /// <summary>
        ///     判断是否是非共同申请
        ///     coder: Kevin Wang(2010-09-10)
        /// </summary>
        /// <returns>非共同申请为true，否则为false</returns>
        public string NotCollectiveApp()
        {
            if (String.IsNullOrEmpty(s_CollectiveApp) == false)
            {
                return s_CollectiveApp.ToUpper() == "N" ? "true" : "false";
            }
            return "true";
        }

        #region 优先权

        /// ############################################################
        /// <summary>
        ///     获取最早优先权国家（英文）
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
                return xpc.Count == 0 ? "无" : ((CodeCountry)xpc[0]).s_OtherName;
            }
        }

        /// ############################################################
        /// <summary>
        ///     获取最早优先权国家
        ///     coder: Kevin Wang(2010-10-12)
        /// </summary>
        /// <returns>国家</returns>
        public string Get1StPriorityCountryCN()
        {
            if (Priorities.Count <= 0) return "无";

            Priorities.Sorting =
                new SortingCollection(new SortProperty("dt_PDate", SortingDirection.Ascending));

            using (var uow = new UnitOfWork())
            {
                var xpc = new XPCollection(uow, typeof(CodeCountry))
                {
                    Criteria = CriteriaOperator.Parse("n_ID =" + ((Priority)Priorities[0]).n_PCountry)
                };
                return xpc.Count == 0 ? "无" : ((CodeCountry)xpc[0]).s_Name;
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

        /// ############################################################
        /// <summary>
        ///     获取最早优先权日有效期(优先权+6个月）
        ///     coder: Kevin Wang(2010-10-12)
        /// </summary>
        /// <returns>优先权日有效期</returns>
        public DateTime Get1StPriorityDateDeadline()
        {
            if (Priorities.Count <= 0) return DateTime.MinValue;

            Priorities.Sorting =
                new SortingCollection(new SortProperty("dt_PDate", SortingDirection.Ascending));
            return ((Priority)Priorities[0]).dt_PDate.AddMonths(6);
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

        #endregion

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}
using System;
using DataEntities.Config;
using DevExpress.Data.Filtering;
using DevExpress.Xpo;

namespace DataEntities.Case.Patents
{
    [MapInheritance(MapInheritanceType.OwnTable)]
    [Persistent("TPCase_Patent")]
    public class BasicPatent : BasicCase
    {
        private readonly XPDelayedProperty fdt_OrigAppDate = new XPDelayedProperty();
        private XPDelayedProperty fdt_DivSubmitDate=new XPDelayedProperty();
        private bool _fbDivisionalCaseFlag;
        private DateTime _fdt_FirstPriorityDate;
        private string _fsOrigAppNo;
        private string _fsOrigCaseNo;
        private string _fs_AllInventorAddress;
        private string _fs_FirstPriorityNo;
        private string _fs_FristPriority;
        private DateTime fdt_PriorityStatusDate;
        private DateTime fdt_RequestSubmitDate;
        private string fs_DivisionCaseNo;
        private string fs_DivisionAppNo;

        /// =======================================================================
        /// <summary>
        ///     关联的专利法律状态
        /// </summary>
        private LawInfo fn_LawID;

        private OrigPatInfo fn_OrigPatInfoID;

        private int fn_PFlowNum;
        private int fn_PatentTypeID;
        private string fs_Inventors;
        private string fs_NPatentID;
        private string fs_Notes;
        private string fs_OldSerial;
        private string fs_OrigCaseSerial;
        private string fs_PatentStatus;
        private string fs_PriorityStatus;
        private string fs_TechnologyType;

        public int n_PFlowNum
        {
            get { return fn_PFlowNum; }
            set { SetPropertyValue<int>("n_PFlowNum", ref fn_PFlowNum, value); }
        }

        public DateTime dt_RequestSubmitDate
        {
            get { return fdt_RequestSubmitDate; }
            set { SetPropertyValue<DateTime>("dt_RequestSubmitDate", ref fdt_RequestSubmitDate, value); }
        }

        public int n_PatentTypeID
        {
            get { return fn_PatentTypeID; }
            set { SetPropertyValue<int>("n_PatentTypeID", ref fn_PatentTypeID, value); }
        }

        [Size(50)]
        public string s_TechnologyType
        {
            get { return fs_TechnologyType; }
            set { SetPropertyValue("s_TechnologyType", ref fs_TechnologyType, value); }
        }

        [Size(20)]
        public string s_OldSerial
        {
            get { return fs_OldSerial; }
            set { SetPropertyValue("s_OldSerial", ref fs_OldSerial, value); }
        }

        [Size(50)]
        public string s_OrigCaseSerial
        {
            get { return fs_OrigCaseSerial; }
            set { SetPropertyValue("s_OrigCaseSerial", ref fs_OrigCaseSerial, value); }
        }


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

        [Size(50)]
        public string s_DivisionCaseNo
        {
            get { return fs_DivisionCaseNo; }
            set { SetPropertyValue("s_DivisionCaseNo", ref fs_DivisionCaseNo, value); }
        }

        [Size(50)]
        public string s_DivisionAppNo
        {
            get { return fs_DivisionAppNo; }
            set { SetPropertyValue("s_DivisionAppNo", ref fs_DivisionAppNo, value); }
        }
        

        [Delayed("fdt_OrigAppDate")]
        public DateTime dt_OrigAppDate
        {
            get
            {
                if (fdt_OrigAppDate.Value == null) return DateTime.MinValue;
                return (DateTime) fdt_OrigAppDate.Value;
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
        public string s_PriorityStatus
        {
            get { return fs_PriorityStatus; }
            set { SetPropertyValue("s_PriorityStatus", ref fs_PriorityStatus, value); }
        }

        public DateTime dt_PriorityStatusDate
        {
            get { return fdt_PriorityStatusDate; }
            set { SetPropertyValue<DateTime>("dt_PriorityStatusDate", ref fdt_PriorityStatusDate, value); }
        }

        [Size(50)]
        public string s_OrigCaseNo
        {
            get { return _fsOrigCaseNo; }
            set { SetPropertyValue("s_OrigCaseNo", ref _fsOrigCaseNo, value); }
        }

        [Size(500)]
        public string s_AllInventorAddress
        {
            get { return _fs_AllInventorAddress; }
            set { SetPropertyValue("s_AllInventorAddress", ref _fs_AllInventorAddress, value); }
        }

        [Size(500)]
        public string s_FristPriority
        {
            get { return _fs_FristPriority; }
            set { SetPropertyValue("s_FristPriority", ref _fs_FristPriority, value); }
        }

        [Size(500)]
        public string s_FirstPriorityNo
        {
            get { return _fs_FirstPriorityNo; }
            set { SetPropertyValue("s_FirstPriorityNo", ref _fs_FirstPriorityNo, value); }
        }

        public DateTime dt_FirstPriorityDate
        {
            get { return _fdt_FirstPriorityDate; }
            set { SetPropertyValue<DateTime>("dt_FirstPriorityDate", ref _fdt_FirstPriorityDate, value); }
        }

        [Size(50)]
        public string s_PatentStatus
        {
            get { return fs_PatentStatus; }
            set { SetPropertyValue("s_PatentStatus", ref fs_PatentStatus, value); }
        }

        [Size(800)]
        public string s_Notes
        {
            get { return fs_Notes; }
            set { SetPropertyValue("s_Notes", ref fs_Notes, value); }
        }

        [Size(1000)]
        public string s_Inventors
        {
            get { return fs_Inventors; }
            set { SetPropertyValue("s_Inventors", ref fs_Inventors, value); }
        }

        [Association("LawInfo-BasePatents")]
        [Persistent("n_LawID")]
        public LawInfo TheLawInfo
        {
            get { return fn_LawID; }
            set { SetPropertyValue("n_LawID", ref fn_LawID, value); }
        }

        [Association("OrigPatInfo-BasePatents")]
        [Persistent("n_OrigPatInfoID")]
        public OrigPatInfo TheOrigPatInfo
        {
            get { return fn_OrigPatInfoID; }
            set { SetPropertyValue("n_OrigPatInfoID", ref fn_OrigPatInfoID, value); }
        }

        [Aggregated, Association("BasicPatent-AnnualFees", typeof (AnnualFee))]
        public XPCollection AnnualFees
        {
            get { return GetCollection("AnnualFees"); }
        }

        [Delayed]
        [NonPersistent]
        public string PCTAppDate
        {
            get
            {
                return TheLawInfo == null || TheLawInfo.dt_PCTAppDate == DateTime.MinValue
                    ? ""
                    : TheLawInfo.dt_PCTAppDate.ToShortDateString();
            }
        }

        [Delayed]
        [NonPersistent]
        public string PCTAppNo
        {
            get { return TheLawInfo == null ? "" : TheLawInfo.s_PCTAppNo; }
        }

        #region 方法

        /// #################################################################
        /// <summary>
        ///     获取专利类型名称：发明、实用新型等
        ///     Kevin Wang(2010-10-25)
        /// </summary>
        /// <returns>专利类型名称</returns>
        public string GetPatentTypeName()
        {
            using (var uow = new UnitOfWork())
            {
                var xpc = new XPCollection(uow, typeof (CodePTCType))
                {
                    Criteria = CriteriaOperator.Parse("n_ID =" + n_PatentTypeID)
                };
                if (xpc.Count == 0)
                {
                    return "";
                }
                return ((CodePTCType) xpc[0]).s_Name;
            }
        }

        /// #################################################################
        /// <summary>
        ///     获取专利类型名称：发明、实用新型等
        ///     Kevin Wang(2010-10-25)
        /// </summary>
        /// <returns>专利类型其他名称</returns>
        public string GetPatentTypeOtherName()
        {
            using (var uow = new UnitOfWork())
            {
                var xpc = new XPCollection(uow, typeof (CodePTCType))
                {
                    Criteria = CriteriaOperator.Parse("n_ID =" + n_PatentTypeID)
                };
                if (xpc.Count == 0)
                {
                    return "";
                }
                return ((CodePTCType) xpc[0]).s_OtherName;
            }
        }

        /// <summary>
        ///     该案件类型是不是实用新型(是返回True,否则返回False）
        ///     Coder:zhangxinyuan(2010-10-16)
        /// </summary>
        /// <returns></returns>
        public string GetModelCaseType()
        {
            CodePTCType codePTCType = GetPTCType("实用新型");
            if (codePTCType != null)
            {
                if (n_PatentTypeID == codePTCType.n_ID)
                {
                    return "true";
                }
            }
            return "false";
        }

        /// <summary>
        ///     获取外观专利
        ///     Coder：zhangxinyuan（2010-11-16）
        /// </summary>
        /// <returns></returns>
        public string GetFacadeCaseType()
        {
            string sType = "false";
            CodePTCType codePTCType = GetPTCType("外观设计");
            if (codePTCType != null)
            {
                if (n_PatentTypeID == codePTCType.n_ID)
                {
                    return "true";
                }
            }
            return sType;
        }

        /// <summary>
        ///     获取是否为发明专利
        ///     Coder：zhangxinyuan（2010-11-16）
        /// </summary>
        /// <returns></returns>
        public string GetInvCaseType()
        {
            string sType = "false";
            CodePTCType codePTCType = GetPTCType("发明");
            if (codePTCType != null)
            {
                if (n_PatentTypeID == codePTCType.n_ID)
                {
                    return "true";
                }
            }
            return sType;
        }

        /// <summary>
        ///     获取案件类型代码实例
        ///     Coder：zhangxinyuan（2010-11-16）
        /// </summary>
        /// <returns>案件类型的对象</returns>
        private CodePTCType GetPTCType(string sName)
        {
            CodePTCType codePTCType = null;
            using (var uow = new UnitOfWork())
            {
                var xpo = new XPCollection(uow, typeof (CodePTCType))
                {
                    Criteria = CriteriaOperator.Parse("s_IPType='P' AND s_Name= ?", sName)
                };
                if (xpo.Count > 0)
                {
                    codePTCType = (CodePTCType) xpo[0];
                }
            }
            return codePTCType;
        }

        /// <summary>
        ///     获取实用新型案件名称
        ///     Coder:zhangxinyuan(2010-11-16)
        /// </summary>
        /// <returns>案件名称</returns>
        public string GetModelCaseName()
        {
            string sName = string.Empty;
            CodePTCType codePTCType = GetPTCType("实用新型");
            if (codePTCType != null)
            {
                if (n_PatentTypeID == codePTCType.n_ID)
                {
                    sName = s_CaseName;
                }
            }
            return sName;
        }

        /// <summary>
        ///     获取外观案件名称
        ///     Coder:zhangxinyuan(2010-11-16)
        /// </summary>
        /// <returns>案件名称</returns>
        public string GetFacadeCaseName()
        {
            string sName = string.Empty;
            CodePTCType codePTCType = GetPTCType("外观设计");
            if (codePTCType != null)
            {
                if (n_PatentTypeID == codePTCType.n_ID)
                {
                    sName = s_CaseName;
                }
            }
            return sName;
        }

        /// <summary>
        ///     获取发明案件名称
        ///     Coder:zhangxinyuan(2010-11-16)
        /// </summary>
        /// <returns>案件名称</returns>
        public string GetInvCaseName()
        {
            string sName = string.Empty;
            CodePTCType codePTCType = GetPTCType("发明");
            if (codePTCType != null)
            {
                if (n_PatentTypeID == codePTCType.n_ID)
                {
                    sName = s_CaseName;
                }
            }
            return sName;
        }

        #endregion

        public BasicPatent(Session session) : base(session) { }
        public BasicPatent() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }
}
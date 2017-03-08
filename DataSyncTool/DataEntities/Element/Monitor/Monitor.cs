using System;
using System.Text;
using DataEntities.Case;
using DataEntities.Case.Patents;
using DataEntities.Case.Trademarks;
using DataEntities.Config;
using DevExpress.Data.Filtering;
using DevExpress.Xpo;

namespace DataEntities.Element.Monitor
{
    [Persistent("T_Monitor")]
    public class Monitor : XPLiteObject
    {
        private readonly XPDelayedProperty fdt_BeginDate = new XPDelayedProperty();
        private readonly XPDelayedProperty fdt_CreateDate = new XPDelayedProperty();
        private readonly XPDelayedProperty fdt_EditDate = new XPDelayedProperty();
        private readonly XPDelayedProperty fdt_MonitorDate = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_Detail = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_IsActive = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_ObjType = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_Status = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_Title = new XPDelayedProperty();
        private int fn_ClientID;
        private int fn_CreatorID;
        private int fn_GovOfficeID;
        private int fn_MainCaseID;
        private int fn_MonitorID;
        private string fs_Creator;
        private string fs_Editor;

        public Monitor(Session session) : base(session)
        {
        }

        public Monitor() : base(Session.DefaultSession)
        {
        }

        [Key(true)]
        public int n_MonitorID
        {
            get { return fn_MonitorID; }
            set { SetPropertyValue<int>("n_MonitorID", ref fn_MonitorID, value); }
        }

        [Size(200)]
        [Delayed("fs_Title")]
        public string s_Title
        {
            get { return (string) fs_Title.Value; }
            set { fs_Title.Value = value; }
        }

        [Size(800)]
        [Delayed("fs_Detail")]
        public string s_Detail
        {
            get { return (string) fs_Detail.Value; }
            set { fs_Detail.Value = value; }
        }

        [Delayed("fdt_MonitorDate")]
        public DateTime dt_MonitorDate
        {
            get
            {
                if (fdt_MonitorDate.Value == null)
                {
                    return DateTime.MinValue;
                }
                return (DateTime) fdt_MonitorDate.Value;
            }
            set { fdt_MonitorDate.Value = value; }
        }

        [Size(1)]
        [Delayed("fs_ObjType")]
        public string s_ObjType
        {
            get { return (string) fs_ObjType.Value; }
            set { fs_ObjType.Value = value; }
        }

        //private XPDelayedProperty fn_ClientID = new XPDelayedProperty();
        //[Delayed("fn_ClientID")]
        //public int n_ClientID
        //{
        //    get
        //    {
        //        if (fn_ClientID.Value == null)
        //        {
        //            return -1;
        //        }
        //        return (int)fn_ClientID.Value;
        //    }
        //    set { fn_ClientID.Value = value; }
        //}

        public int n_ClientID
        {
            get { return fn_ClientID; }
            set { SetPropertyValue<int>("n_ClientID", ref fn_ClientID, value); }
        }

        public int n_CreatorID
        {
            get { return fn_CreatorID; }
            set { SetPropertyValue<int>("n_CreatorID", ref fn_CreatorID, value); }
        }

        public int n_GovOfficeID
        {
            get { return fn_GovOfficeID; }
            set { SetPropertyValue<int>("n_GovOfficeID", ref fn_GovOfficeID, value); }
        }

        public int n_MainCaseID
        {
            get { return fn_MainCaseID; }
            set { SetPropertyValue<int>("n_MainCaseID", ref fn_MainCaseID, value); }
        }

        [Delayed("fdt_BeginDate")]
        public DateTime dt_BeginDate
        {
            get
            {
                if (fdt_BeginDate.Value == null)
                {
                    return DateTime.MinValue;
                }
                return (DateTime) fdt_BeginDate.Value;
            }
            set { fdt_BeginDate.Value = value; }
        }

        [Size(1)]
        [Delayed("fs_Status")]
        public string s_Status
        {
            get { return (string) fs_Status.Value; }
            set { fs_Status.Value = value; }
        }

        [Size(1)]
        [Delayed("fs_IsActive")]
        public string s_IsActive
        {
            get { return (string) fs_IsActive.Value; }
            set { fs_IsActive.Value = value; }
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

        [Delayed("fdt_CreateDate")]
        public DateTime dt_CreateDate
        {
            get
            {
                if (fdt_CreateDate.Value == null)
                {
                    return DateTime.MinValue;
                }
                return (DateTime) fdt_CreateDate.Value;
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
                return (DateTime) fdt_EditDate.Value;
            }
            set { fdt_EditDate.Value = value; }
        }

        /// <summary>
        ///     监控对象
        ///     coder:zhangjiechen(2010-8-4)
        /// </summary>
        public string sMonitorObject
        {
            get
            {
                string sMonitorObiect = "";
                MonitorInCases.Filter = CriteriaOperator.Parse("s_IsMainCase = 'Y'");
                if (MonitorInCases != null && MonitorInCases.Count > 0)
                {
                    if (MonitorInCases.Count > 0)
                    {
                        switch (s_ObjType)
                        {
                            case "O":
                                int iOfficeID = ((MonitorInCase) MonitorInCases[0]).TheCase.n_OfficeID;
                                using (var uow = new UnitOfWork())
                                {
                                    if (uow.GetObjectByKey<CodeOfficial>(iOfficeID) != null)
                                    {
                                        sMonitorObiect = (uow.GetObjectByKey<CodeOfficial>(iOfficeID)).s_Name;
                                    }
                                }
                                break;
                            case "C":
                                if (((MonitorInCase) MonitorInCases[0]).TheCase.TheClient != null)
                                {
                                    sMonitorObiect = ((MonitorInCase) MonitorInCases[0]).TheCase.TheClient.s_Name;
                                }
                                break;
                        }
                    }
                }
                MonitorInCases.Filter = CriteriaOperator.Parse("1 = 1");
                return sMonitorObiect;
            }
        }

        /// <summary>
        ///     我方文号文号
        ///     coder:zhangjiechen(2010-8-4)
        /// </summary>
        public string sCaseSerials
        {
            get
            {
                //StringBuilder sTmp = new StringBuilder();
                //foreach (MonitorInCase monitorInCase in MonitorInCases)
                //{
                //    sTmp.Append(monitorInCase.TheCase.s_CaseSerial);
                //    sTmp.Append(";");
                //}
                //return sTmp.ToString();

                if (MonitorInCases.Count >= 1)
                {
                    MonitorInCase monitorInCase = null;
                    MonitorInCases.Filter = CriteriaOperator.Parse("s_IsMainCase = 'Y'");
                    if (MonitorInCases.Count > 0)
                    {
                        monitorInCase = (MonitorInCase) MonitorInCases[0];
                    }
                    MonitorInCases.Filter = CriteriaOperator.Parse("1 = 1");
                    if (monitorInCase == null) return "";
                    return monitorInCase.TheCase.s_CaseSerial;
                }
                return "";
            }
        }

        /// <summary>
        ///     案件的案件名称
        ///     coder:zhangjiechen(2010-8-4)
        /// </summary>
        public string sCaseName
        {
            get
            {
                //if (MonitorInCases.Count >= 1)
                //{
                //    MonitorInCase monitorInCase = (MonitorInCase)MonitorInCases[0];
                //    return monitorInCase.TheCase.s_CaseName;
                //}
                //else
                //{
                //    return "";
                //}

                if (MonitorInCases.Count >= 1)
                {
                    MonitorInCase monitorInCase = null;
                    MonitorInCases.Filter = CriteriaOperator.Parse("s_IsMainCase = 'Y'");
                    if (MonitorInCases.Count > 0)
                    {
                        monitorInCase = (MonitorInCase) MonitorInCases[0];
                    }
                    MonitorInCases.Filter = CriteriaOperator.Parse("1 = 1");
                    if (monitorInCase == null) return "";
                    var sTmp = new StringBuilder();
                    sTmp.Append(monitorInCase.TheCase.s_CaseName);
                    if (MonitorInCases.Count > 1)
                    {
                        sTmp.Append("...");
                    }
                    return sTmp.ToString();
                }
                return "";
            }
        }

        /// <summary>
        ///     案件的程序
        ///     coder:zhangjiechen(2010-8-4)
        /// </summary>
        public string sCaseProcess
        {
            get
            {
                string sReturn = "";
                if (MonitorInCases.Count >= 1)
                {
                    MonitorInCase monitorInCase = null;
                    MonitorInCases.Filter = CriteriaOperator.Parse("s_IsMainCase = 'Y'");
                    if (MonitorInCases.Count > 0)
                    {
                        monitorInCase = (MonitorInCase) MonitorInCases[0];
                    }
                    MonitorInCases.Filter = CriteriaOperator.Parse("1 = 1");
                    if (monitorInCase == null) return sReturn;
                    if (monitorInCase.TheProcess != null)
                    {
                        using (var tempUow = new UnitOfWork())
                        {
                            CodeProcess codeProcess = monitorInCase.TheProcess.TheCodeProcess;
                            if (codeProcess != null)
                            {
                                sReturn = codeProcess.s_Name;
                            }
                        }
                    }
                }
                return sReturn;
            }
        }

        [Aggregated, Association("Monitor-MonitorInCases", typeof (MonitorInCase))]
        public XPCollection MonitorInCases
        {
            get { return GetCollection("MonitorInCases"); }
        }

        public int CaseCount
        {
            get { return MonitorInCases.Count; }
        }

        [NonPersistent]
        public bool Check { get; set; }

        #region 触发器字段

        private string fs_AppNo;
        private string fs_CaseSerial;

        [Size(50)]
        public string s_CaseSerial
        {
            get { return fs_CaseSerial; }
            set { SetPropertyValue("s_CaseSerial", ref fs_CaseSerial, value); }
        }

        [Size(50)]
        public string s_AppNo
        {
            get { return fs_AppNo; }
            set { SetPropertyValue("s_AppNo", ref fs_AppNo, value); }
        }

        #endregion

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }

        #region 高级查询所用的特殊字段

        /// <summary>
        ///     来文的主案件，高级查询使用
        /// </summary>
        public BasicCase TheMainCase
        {
            get
            {
                foreach (MonitorInCase monitorInCase in MonitorInCases)
                {
                    if (monitorInCase == null) continue;
                    if (monitorInCase.s_IsMainCase == "Y") return monitorInCase.TheCase;
                }
                return null;
            }
        }

        /// <summary>
        ///     申请号，高级查询使用
        /// </summary>
        public string CaseAppNo
        {
            get
            {
                if ((TheMainCase as ExtendedPatent) != null) return (TheMainCase as ExtendedPatent).TheLawInfo.s_AppNo;
                if ((TheMainCase as ExtendedTrademark) != null)
                    return (TheMainCase as ExtendedTrademark).TheLawInfo.s_AppNo;
                return string.Empty;
            }
        }

        #endregion
    }
}
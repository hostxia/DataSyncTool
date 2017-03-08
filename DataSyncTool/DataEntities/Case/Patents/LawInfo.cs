using System;
using System.Collections.Generic;
using DataEntities.Config;
using DevExpress.Xpo;

namespace DataEntities.Case.Patents
{
    [Persistent("TPCase_LawInfo")]
    public class LawInfo : XPLiteObject
    {
        private readonly XPDelayedProperty fdt_AppDate = new XPDelayedProperty();
        private readonly XPDelayedProperty fdt_CertfDate = new XPDelayedProperty();
        private readonly XPDelayedProperty fdt_IssuedPubDate = new XPDelayedProperty();
        private readonly XPDelayedProperty fdt_PCTAppDate = new XPDelayedProperty();
        private readonly XPDelayedProperty fdt_PCTInNationDate = new XPDelayedProperty();
        private readonly XPDelayedProperty fdt_PCTPubDate = new XPDelayedProperty();
        private readonly XPDelayedProperty fdt_PubDate = new XPDelayedProperty();
        private readonly XPDelayedProperty fdt_SubstantiveExamDate = new XPDelayedProperty();
        private readonly XPDelayedProperty fdt_FirstCheckDate = new XPDelayedProperty();
        private int fn_ClaimCount;
        private int fn_ID;
        private int fn_PCTPubLan;

        private string fs_AppNo;
        private string fs_CertfNo;
        private string fs_IssuedPubClass1;
        private string fs_IssuedPubClass2;
        private string fs_IssuedPubGazette;
        private string fs_IssuedPubNo;
        private string fs_IssuedPubVolume;
        private string fs_PCTAppNo;
        private string fs_PCTPubNo;
        private string fs_PubClass1;
        private string fs_PubClass2;
        private string fs_PubGazette;
        private string fs_PubNo;
        private string fs_ReviewNo;
        private string fs_PubVolume;
        private string fs_PCTSearchBureau;

        public LawInfo(Session session)
            : base(session)
        {
        }

        public LawInfo()
            : base(Session.DefaultSession)
        {
        }

        [Key(true)]
        public int n_ID
        {
            get { return fn_ID; }
            set { SetPropertyValue<int>("n_ID", ref fn_ID, value); }
        }

        [Size(50)]
        public string s_AppNo
        {
            get { return fs_AppNo; }
            set { SetPropertyValue("s_AppNo", ref fs_AppNo, value); }
        }
        [Size(200)]
        public string s_PCTSearchBureau
        {
            get { return fs_PCTSearchBureau; }
            set { SetPropertyValue("s_PCTSearchBureau", ref fs_PCTSearchBureau, value); }
        }
        [Delayed("fdt_AppDate")]
        public DateTime dt_AppDate
        {
            get
            {
                if (fdt_AppDate.Value == null)
                {
                    return DateTime.MinValue;
                }
                return (DateTime)fdt_AppDate.Value;
            }
            set { fdt_AppDate.Value = value; }
        }

        public int n_ClaimCount
        {
            get { return fn_ClaimCount; }
            set { SetPropertyValue<int>("n_ClaimCount", ref fn_ClaimCount, value); }
        }


        private int fn_ManualPages;
        public int n_ManualPages
        {
            get { return fn_ManualPages; }
            set { SetPropertyValue<int>("n_ManualPages", ref fn_ManualPages, value); }
        }


        [Size(50)]
        public string s_PubNo
        {
            get { return fs_PubNo; }
            set { SetPropertyValue("s_PubNo", ref fs_PubNo, value); }
        }

        [Size(50)]
        public string s_ReviewNo
        {
            get { return fs_ReviewNo; }
            set { SetPropertyValue("s_ReviewNo", ref fs_ReviewNo, value); }
        }

        [Delayed("fdt_PubDate")]
        public DateTime dt_PubDate
        {
            get
            {
                if (fdt_PubDate.Value == null) return DateTime.MinValue;
                return (DateTime)fdt_PubDate.Value;
            }
            set { fdt_PubDate.Value = value; }
        }

        [Size(50)]
        public string s_PubVolume
        {
            get { return fs_PubVolume; }
            set { SetPropertyValue("s_PubVolume", ref fs_PubVolume, value); }
        }

        [Size(50)]
        public string s_PubGazette
        {
            get { return fs_PubGazette; }
            set { SetPropertyValue("s_PubGazette", ref fs_PubGazette, value); }
        }

        [Size(50)]
        public string s_PubClass1
        {
            get { return fs_PubClass1; }
            set { SetPropertyValue("s_PubClass1", ref fs_PubClass1, value); }
        }

        [Size(50)]
        public string s_PubClass2
        {
            get { return fs_PubClass2; }
            set { SetPropertyValue("s_PubClass2", ref fs_PubClass2, value); }
        }

        [Delayed("fdt_SubstantiveExamDate")]
        public DateTime dt_SubstantiveExamDate
        {
            get
            {
                if (fdt_SubstantiveExamDate.Value == null) return DateTime.MinValue;
                return (DateTime)fdt_SubstantiveExamDate.Value;
            }
            set { fdt_SubstantiveExamDate.Value = value; }
        }

        [Size(50)]
        public string s_IssuedPubNo
        {
            get { return fs_IssuedPubNo; }
            set { SetPropertyValue("s_IssuedPubNo", ref fs_IssuedPubNo, value); }
        }

        [Delayed("fdt_IssuedPubDate")]
        public DateTime dt_IssuedPubDate
        {
            get
            {
                if (fdt_IssuedPubDate.Value == null) return DateTime.MinValue;
                return (DateTime)fdt_IssuedPubDate.Value;
            }
            set { fdt_IssuedPubDate.Value = value; }
        }

        [Size(50)]
        public string s_IssuedPubVolume
        {
            get { return fs_IssuedPubVolume; }
            set { SetPropertyValue("s_IssuedPubVolume", ref fs_IssuedPubVolume, value); }
        }

        [Size(50)]
        public string s_IssuedPubGazette
        {
            get { return fs_IssuedPubGazette; }
            set { SetPropertyValue("s_IssuedPubGazette", ref fs_IssuedPubGazette, value); }
        }

        [Size(50)]
        public string s_IssuedPubClass1
        {
            get { return fs_IssuedPubClass1; }
            set { SetPropertyValue("s_IssuedPubClass1", ref fs_IssuedPubClass1, value); }
        }

        [Size(50)]
        public string s_IssuedPubClass2
        {
            get { return fs_IssuedPubClass2; }
            set { SetPropertyValue("s_IssuedPubClass2", ref fs_IssuedPubClass2, value); }
        }

        [Size(50)]
        public string s_CertfNo
        {
            get { return fs_CertfNo; }
            set { SetPropertyValue("s_CertfNo", ref fs_CertfNo, value); }
        }

        [Delayed("fdt_CertfDate")]
        public DateTime dt_CertfDate
        {
            get
            {
                if (fdt_CertfDate.Value == null) return DateTime.MinValue;
                return (DateTime)fdt_CertfDate.Value;
            }
            set { fdt_CertfDate.Value = value; }
        }

        [Size(50)]
        public string s_PCTAppNo
        {
            get { return fs_PCTAppNo; }
            set { SetPropertyValue("s_PCTAppNo", ref fs_PCTAppNo, value); }
        }

        [Delayed("fdt_PCTAppDate")]
        public DateTime dt_PCTAppDate
        {
            get
            {
                if (fdt_PCTAppDate.Value == null) return DateTime.MinValue;
                return (DateTime)fdt_PCTAppDate.Value;
            }
            set { fdt_PCTAppDate.Value = value; }
        }

        [Size(50)]
        public string s_PCTPubNo
        {
            get { return fs_PCTPubNo; }
            set { SetPropertyValue("s_PCTPubNo", ref fs_PCTPubNo, value); }
        }

        [Delayed("fdt_PCTPubDate")]
        public DateTime dt_PCTPubDate
        {
            get
            {
                if (fdt_PCTPubDate.Value == null) return DateTime.MinValue;
                return (DateTime)fdt_PCTPubDate.Value;
            }
            set { fdt_PCTPubDate.Value = value; }
        }

        [Delayed("fdt_PCTInNationDate")]
        public DateTime dt_PCTInNationDate
        {
            get
            {
                if (fdt_PCTInNationDate.Value == null) return DateTime.MinValue;
                return (DateTime)fdt_PCTInNationDate.Value;
            }
            set { fdt_PCTInNationDate.Value = value; }
        }
        [Delayed("fdt_FirstCheckDate")]
        public DateTime dt_FirstCheckDate
        {
            get
            {
                if (fdt_FirstCheckDate.Value == null) return DateTime.MinValue;
                return (DateTime)fdt_FirstCheckDate.Value;
            }
            set { fdt_FirstCheckDate.Value = value; }
        }
        public int n_PCTPubLan
        {
            get { return fn_PCTPubLan; }
            set { SetPropertyValue<int>("n_PCTPubLan", ref fn_PCTPubLan, value); }
        }

        [Aggregated, Association("LawInfo-BasePatents", typeof(BasicPatent))]
        public XPCollection BasePatents
        {
            get { return GetCollection("BasePatents"); }
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }

        ////#region 方法

        /////// ############################################
        /////// <summary>
        ///////     获取撰写申请日期中文格式，带年月日
        ///////     coder: Kevin Wang(2010-10-12)
        /////// </summary>
        /////// <returns>申请日期</returns>
        ////public string GetAppDateCN()
        ////{
        ////    return ServerDate.GetDateInCNFormat(dt_AppDate);
        ////}

        /////// ############################################
        /////// <summary>
        ///////     获取申请日期英文格式，带年月日
        ///////     coder: Kevin Wang(2010-10-12)
        /////// </summary>
        /////// <returns>申请日期</returns>
        ////public string GetAppDateEN()
        ////{
        ////    return ServerDate.GetDateInENFormat(dt_AppDate);
        ////}


        /////// ############################################
        /////// <summary>
        ///////     获取申请日期英文格式，只带月日
        /////// </summary>
        /////// <returns>申请日期</returns>
        ////public string GetAppDateMonthAndDayEN()
        ////{
        ////    return ServerDate.GetDateMonthAndDayInENFormat(dt_AppDate);
        ////}

        /////// ############################################
        /////// <summary>
        ///////     获取公开日期中文格式，带年月日
        ///////     coder: Kevin Wang(2010-10-12)
        /////// </summary>
        /////// <returns>公开日期</returns>
        ////public string GetPubateCN()
        ////{
        ////    return ServerDate.GetDateInCNFormat(dt_PubDate);
        ////}

        /////// ############################################
        /////// <summary>
        ///////     获取公开日期英文格式，带年月日
        ///////     coder: Kevin Wang(2010-10-12)
        /////// </summary>
        /////// <returns>公开日期</returns>
        ////public string GetPubDateEN()
        ////{
        ////    return ServerDate.GetDateInENFormat(dt_PubDate);
        ////}

        /////// ############################################
        /////// <summary>
        ///////     获取授权公告日期中文格式，带年月日
        ///////     coder: Kevin Wang(2010-10-12)
        /////// </summary>
        /////// <returns>授权公告日期</returns>
        ////public string GetIssuedPubateCN()
        ////{
        ////    return ServerDate.GetDateInCNFormat(dt_IssuedPubDate);
        ////}

        /////// ############################################
        /////// <summary>
        ///////     获取授权公告日期英文格式，带年月日
        ///////     coder: Kevin Wang(2010-10-12)
        /////// </summary>
        /////// <returns>授权公告日期</returns>
        ////public string GetIssuedPubDateEN()
        ////{
        ////    return ServerDate.GetDateInENFormat(dt_IssuedPubDate);
        ////}

        /////// ############################################
        /////// <summary>
        ///////     获取发证书日期中文格式，带年月日
        ///////     coder: Kevin Wang(2010-10-12)
        /////// </summary>
        /////// <returns>发证书日期</returns>
        ////public string GetCertfPubateCN()
        ////{
        ////    return ServerDate.GetDateInCNFormat(dt_CertfDate);
        ////}

        /////// ############################################
        /////// <summary>
        ///////     获取发证书日期英文格式，带年月日
        ///////     coder: Kevin Wang(2010-10-12)
        /////// </summary>
        /////// <returns>发证书日期</returns>
        ////public string GetCertfPubateEN()
        ////{
        ////    return ServerDate.GetDateInENFormat(dt_CertfDate);
        ////}

        /////// ############################################
        /////// <summary>
        ///////     获取PCT国际申请日中文格式，带年月日
        ///////     coder: Kevin Wang(2010-10-12)
        /////// </summary>
        /////// <returns>PCT国际申请日</returns>
        ////public string GetPCTAppDateCN()
        ////{
        ////    return ServerDate.GetDateInCNFormat(dt_PCTAppDate);
        ////}

        /////// ############################################
        /////// <summary>
        ///////     获取PCT国际申请日英文格式，带年月日
        ///////     coder: Kevin Wang(2010-10-12)
        /////// </summary>
        /////// <returns>PCT国际申请日</returns>
        ////public string GetPCTAppDateEN()
        ////{
        ////    return ServerDate.GetDateInENFormat(dt_PCTAppDate);
        ////}

        /////// ############################################
        /////// <summary>
        ///////     获取PCT国际申请日（中文日月年格式）
        ///////     coder: zhangxinyuan(2010-11-17)
        /////// </summary>
        /////// <returns>PCT国际申请日</returns>
        ////public string GetPCTAppDateCNDayMonYear()
        ////{
        ////    return ServerDate.GetDateInCNDayMonthYear(dt_PCTAppDate);
        ////}

        /////// ############################################
        /////// <summary>
        ///////     获取进入国家阶段日期中文格式，带年月日
        ///////     coder: Kevin Wang(2010-10-12)
        /////// </summary>
        /////// <returns>进入国家阶段日期</returns>
        ////public string GetPCTInNationDateCN()
        ////{
        ////    return ServerDate.GetDateInCNFormat(dt_PCTInNationDate);
        ////}

        /////// ############################################
        /////// <summary>
        ///////     获取进入国家阶段日期英文格式，带年月日
        ///////     coder: Kevin Wang(2010-10-12)
        /////// </summary>
        /////// <returns>进入国家阶段日期</returns>
        ////public string GetPCTInNationDateEN()
        ////{
        ////    return ServerDate.GetDateInENFormat(dt_PCTInNationDate);
        ////}

        /////// ############################################
        /////// <summary>
        ///////     获取国际公布日中文格式，带年月日
        ///////     coder: Kevin Wang(2010-10-12)
        /////// </summary>
        /////// <returns>国际公布日</returns>
        ////public string GetPCTPubDateCN()
        ////{
        ////    return ServerDate.GetDateInCNFormat(dt_PCTPubDate);
        ////}

        /////// ############################################
        /////// <summary>
        ///////     获取国际公布日英文格式，带年月日
        ///////     coder: Kevin Wang(2010-10-12)
        /////// </summary>
        /////// <returns>国际公布日</returns>
        ////public string GetPCTPubDateEN()
        ////{
        ////    return ServerDate.GetDateInENFormat(dt_PCTPubDate);
        ////}

        /////// ############################################
        /////// <summary>
        ///////     获取国际公布语言(中文)
        ///////     coder: Kevin Wang(2010-10-12)
        /////// </summary>
        /////// <returns></returns>
        ////public string GetPCTPubLanguageCN()
        ////{
        ////    using (var uow = new UnitOfWork())
        ////    {
        ////        var codeLanguage = uow.GetObjectByKey<CodeLanguage>(n_PCTPubLan);
        ////        return codeLanguage == null ? string.Empty : codeLanguage.s_Name;
        ////    }
        ////}

        /////// <summary>
        ///////     获取国家公布语言(英文)
        ///////     coder:sunfei(2014-04-13)
        /////// </summary>
        /////// <returns></returns>
        ////public string GetPCTPubLanguageEN()
        ////{
        ////    using (var uow = new UnitOfWork())
        ////    {
        ////        var CodeLanguage = uow.GetLoadedObjectByKey<CodeLanguage>(n_PCTPubLan);
        ////        return CodeLanguage == null ? string.Empty : CodeLanguage.s_OtherName;
        ////    }
        ////}

        //#endregion

        #region Common Method For Update

        protected List<ConmonFunctionForUpdate.MonitorField> _listBeMonitorField;
        protected XPLiteObject _xplCopyOfObject;

        protected override void OnLoaded()
        {
            base.OnLoaded();
            _listBeMonitorField = new List<ConmonFunctionForUpdate.MonitorField>
            {
                new ConmonFunctionForUpdate.MonitorField{MonitorType = ConmonFunctionForUpdate.EnumMonitorType.Deadline,FieldName = "dt_AppDate",CodeNameSpace = "DataEntities.Case.Patents.BasicPatent",CodeFieldName = "TheLawInfo.dt_AppDate"},
                new ConmonFunctionForUpdate.MonitorField{MonitorType = ConmonFunctionForUpdate.EnumMonitorType.Deadline,FieldName = "dt_PubDate",CodeNameSpace = "DataEntities.Case.Patents.BasicPatent",CodeFieldName = "TheLawInfo.dt_PubDate"},
                new ConmonFunctionForUpdate.MonitorField{MonitorType = ConmonFunctionForUpdate.EnumMonitorType.Deadline,FieldName = "dt_CertfDate",CodeNameSpace = "DataEntities.Case.Patents.BasicPatent",CodeFieldName = "TheLawInfo.dt_CertfDate"},
                new ConmonFunctionForUpdate.MonitorField{MonitorType = ConmonFunctionForUpdate.EnumMonitorType.Deadline,FieldName = "dt_PCTAppDate",CodeNameSpace = "DataEntities.Case.Patents.BasicPatent",CodeFieldName = "TheLawInfo.dt_PCTAppDate"},
                new ConmonFunctionForUpdate.MonitorField{MonitorType = ConmonFunctionForUpdate.EnumMonitorType.Deadline,FieldName = "dt_PCTPubDate",CodeNameSpace = "DataEntities.Case.Patents.BasicPatent",CodeFieldName = "TheLawInfo.dt_PCTPubDate"},
                new ConmonFunctionForUpdate.MonitorField{MonitorType = ConmonFunctionForUpdate.EnumMonitorType.Deadline,FieldName = "dt_PCTInNationDate",CodeNameSpace = "DataEntities.Case.Patents.BasicPatent",CodeFieldName = "TheLawInfo.dt_PCTInNationDate"},
                new ConmonFunctionForUpdate.MonitorField{MonitorType = ConmonFunctionForUpdate.EnumMonitorType.Deadline,FieldName = "dt_IssuedPubDate",CodeNameSpace = "DataEntities.Case.Patents.BasicPatent",CodeFieldName = "TheLawInfo.dt_IssuedPubDate"},
                new ConmonFunctionForUpdate.MonitorField{MonitorType = ConmonFunctionForUpdate.EnumMonitorType.RelatedInfo,FieldName = "s_AppNo",CodeNameSpace = "DataEntities.Case.Patents.BasicPatent",CodeFieldName = "TheLawInfo.s_AppNo"},
            };
            var type = this.GetType();
            _xplCopyOfObject = Activator.CreateInstance(type, new[] { new UnitOfWork() }) as XPLiteObject;
            ConmonFunctionForUpdate.CopyDataEntityFileds(this, _xplCopyOfObject, _listBeMonitorField);
        }

        protected override void OnSaved()
        {
            base.OnSaved();
            if (Session.IsNewObject(this)) return;
            ConmonFunctionForUpdate.CompareDataEntityFiledsForDeadline(this, _xplCopyOfObject, _listBeMonitorField);
            ConmonFunctionForUpdate.CompareDataEntityFiledsForRelatedInfo(this, _xplCopyOfObject, _listBeMonitorField);
        }

        #endregion
    }
}
using System;
using System.Collections.Generic;
using DevExpress.Xpo;

namespace DataEntities.Case.Trademarks
{
    [Persistent("TTCase_LawInfo")]
    public class LawInfo : XPLiteObject
    {
        public LawInfo(Session session)
            : base(session)
        {
        }

        public LawInfo()
            : base(Session.DefaultSession)
        {
        }

        private int fn_ID;
        [Key(true)]
        public int n_ID
        {
            get { return fn_ID; }
            set { SetPropertyValue<int>("n_ID", ref fn_ID, value); }
        }

        private string fs_AcceptNO;
        [Persistent("s_AcceptNO")]
        [Size(50)]
        public string s_AcceptNO
        {
            get { return fs_AcceptNO; }
            set { SetPropertyValue<string>("s_AcceptNO", ref fs_AcceptNO, value); }
        }

        private DateTime fdt_AppDate;
        [Persistent("dt_AppDate")]
        public DateTime dt_AppDate
        {
            get { return fdt_AppDate; }
            set { SetPropertyValue<DateTime>("dt_AppDate", ref fdt_AppDate, value); }
        }

        private DateTime fdt_FormalCheckDate;
        [Persistent("dt_FormalCheckDate")]
        public DateTime dt_FormalCheckDate
        {
            get { return fdt_FormalCheckDate; }
            set { SetPropertyValue<DateTime>("dt_FormalCheckDate", ref fdt_FormalCheckDate, value); }
        }

        private DateTime fdt_EssCheckDate;
        [Persistent("dt_EssCheckDate")]
        public DateTime dt_EssCheckDate
        {
            get { return fdt_EssCheckDate; }
            set { SetPropertyValue<DateTime>("dt_EssCheckDate", ref fdt_EssCheckDate, value); }
        }


        private string fs_AppNO;
        [Persistent("s_AppNO")]
        [Size(50)]
        public string s_AppNo
        {
            get { return fs_AppNO; }
            set { SetPropertyValue<string>("s_AppNO", ref fs_AppNO, value); }
        }

        private string fs_PrePubIssue;
        [Persistent("s_PrePubIssue")]
        [Size(50)]
        public string s_PrePubIssue
        {
            get { return fs_PrePubIssue; }
            set { SetPropertyValue<string>("s_PrePubIssue", ref fs_PrePubIssue, value); }
        }

        private DateTime fdt_PrePubDate;
        [Persistent("dt_PrePubDate")]
        public DateTime dt_PrePubDate
        {
            get { return fdt_PrePubDate; }
            set { SetPropertyValue<DateTime>("dt_PrePubDate", ref fdt_PrePubDate, value); }
        }

        private DateTime fdt_RegistrationDate;
        [Persistent("dt_RegistrationDate")]
        public DateTime dt_RegistrationDate
        {
            get { return fdt_RegistrationDate; }
            set { SetPropertyValue<DateTime>("dt_RegistrationDate", ref fdt_RegistrationDate, value); }
        }

        private string fs_PubIssue;
        [Persistent("s_PubIssue")]
        [Size(50)]
        public string s_PubIssue
        {
            get { return fs_PubIssue; }
            set { SetPropertyValue<string>("s_PubIssue", ref fs_PubIssue, value); }
        }

        private string fs_RegistrationNO;
        [Persistent("s_RegistrationNO")]
        [Size(50)]
        public string s_RegistrationNO
        {
            get { return fs_RegistrationNO; }
            set { SetPropertyValue<string>("s_RegistrationNO", ref fs_RegistrationNO, value); }
        }

        private DateTime fdt_WithdrawDate;
        [Persistent("dt_WithdrawDate")]
        public DateTime dt_WithdrawDate
        {
            get { return fdt_WithdrawDate; }
            set { SetPropertyValue<DateTime>("dt_WithdrawDate", ref fdt_WithdrawDate, value); }
        }

        private string fs_NTrademarkID;
        [Persistent("s_NTrademarkID")]
        [Size(16)]
        public string s_NTrademarkID
        {
            get { return fs_NTrademarkID; }
            set { SetPropertyValue<string>("s_NTrademarkID", ref fs_NTrademarkID, value); }
        }

        private DateTime fdt_ApprovedDate;
        [Persistent("dt_ApprovedDate")]
        public DateTime dt_ApprovedDate
        {
            get { return fdt_ApprovedDate; }
            set { SetPropertyValue<DateTime>("dt_ApprovedDate", ref fdt_ApprovedDate, value); }
        }

        private string fs_PrePubNO;
        [Persistent("s_PrePubNO")]
        [Size(50)]
        public string s_PrePubNO
        {
            get { return fs_PrePubNO; }
            set { SetPropertyValue<string>("s_PrePubNO", ref fs_PrePubNO, value); }
        }

        private DateTime fdt_BeginDate;
        [Persistent("dt_BeginDate")]
        public DateTime dt_BeginDate
        {
            get { return fdt_BeginDate; }
            set { SetPropertyValue<DateTime>("dt_BeginDate", ref fdt_BeginDate, value); }
        }

        private DateTime fdt_EndDate;
        [Persistent("dt_EndDate")]
        public DateTime dt_EndDate
        {
            get { return fdt_EndDate; }
            set { SetPropertyValue<DateTime>("dt_EndDate", ref fdt_EndDate, value); }
        }

        private DateTime fdt_NextRenewal;
        [Persistent("dt_NextRenewal")]
        public DateTime dt_NextRenewal
        {
            get { return fdt_NextRenewal; }
            set { SetPropertyValue<DateTime>("dt_NextRenewal", ref fdt_NextRenewal, value); }
        }

        private string fs_MadFilingNo;
        [Persistent("s_MadFilingNo")]
        [Size(50)]
        public string s_MadFilingNo
        {
            get { return fs_MadFilingNo; }
            set { SetPropertyValue<string>("s_MadFilingNo", ref fs_MadFilingNo, value); }
        }

        private DateTime fdt_MadFilingDate;
        [Persistent("dt_MadFilingDate")]
        public DateTime dt_MadFilingDate
        {
            get { return fdt_MadFilingDate; }
            set { SetPropertyValue<DateTime>("dt_MadFilingDate", ref fdt_MadFilingDate, value); }
        }

        private string fs_MadRegNo;
        [Persistent("s_MadRegNo")]
        [Size(50)]
        public string s_MadRegNo
        {
            get { return fs_MadRegNo; }
            set { SetPropertyValue<string>("s_MadRegNo", ref fs_MadRegNo, value); }
        }

        private DateTime fdt_MadRegDate;
        [Persistent("dt_MadRegDate")]
        public DateTime dt_MadRegDate
        {
            get { return fdt_MadRegDate; }
            set { SetPropertyValue<DateTime>("dt_MadRegDate", ref fdt_MadRegDate, value); }
        }

        private int fn_MadLan;
        [Persistent("n_MadLan")]
        public int n_MadLan
        {
            get { return fn_MadLan; }
            set { SetPropertyValue<int>("n_MadLan", ref fn_MadLan, value); }
        }

        [Aggregated, Association("LawInfo-BasicTrademarks", typeof(BasicTrademark))]
        public XPCollection Cases
        {
            get { return GetCollection("Cases"); }
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }

        #region Common Method For Update

        protected List<ConmonFunctionForUpdate.MonitorField> _listBeMonitorField;
        protected XPLiteObject _xplCopyOfObject;

        protected override void OnLoaded()
        {
            base.OnLoaded();
            _listBeMonitorField = new List<ConmonFunctionForUpdate.MonitorField>
            {
                new ConmonFunctionForUpdate.MonitorField{MonitorType = ConmonFunctionForUpdate.EnumMonitorType.Deadline,FieldName = "dt_AppDate",CodeNameSpace = "DataEntities.Case.Trademarks.BasicTrademark",CodeFieldName = "TheLawInfo.dt_AppDate"},
                new ConmonFunctionForUpdate.MonitorField{MonitorType = ConmonFunctionForUpdate.EnumMonitorType.Deadline,FieldName = "dt_PrePubDate",CodeNameSpace = "DataEntities.Case.Trademarks.BasicTrademark",CodeFieldName = "TheLawInfo.dt_PrePubDate"},
                new ConmonFunctionForUpdate.MonitorField{MonitorType = ConmonFunctionForUpdate.EnumMonitorType.Deadline,FieldName = "dt_FormalCheckDate",CodeNameSpace = "DataEntities.Case.Trademarks.BasicTrademark",CodeFieldName = "TheLawInfo.dt_FormalCheckDate"},
                new ConmonFunctionForUpdate.MonitorField{MonitorType = ConmonFunctionForUpdate.EnumMonitorType.Deadline,FieldName = "dt_EssCheckDate",CodeNameSpace = "DataEntities.Case.Trademarks.BasicTrademark",CodeFieldName = "TheLawInfo.dt_EssCheckDate"},
                new ConmonFunctionForUpdate.MonitorField{MonitorType = ConmonFunctionForUpdate.EnumMonitorType.Deadline,FieldName = "dt_RegistrationDate",CodeNameSpace = "DataEntities.Case.Trademarks.BasicTrademark",CodeFieldName = "TheLawInfo.dt_RegistrationDate"},
                new ConmonFunctionForUpdate.MonitorField{MonitorType = ConmonFunctionForUpdate.EnumMonitorType.Deadline,FieldName = "dt_ApprovedDate",CodeNameSpace = "DataEntities.Case.Trademarks.BasicTrademark",CodeFieldName = "TheLawInfo.dt_ApprovedDate"},
                new ConmonFunctionForUpdate.MonitorField{MonitorType = ConmonFunctionForUpdate.EnumMonitorType.Deadline,FieldName = "dt_BeginDate",CodeNameSpace = "DataEntities.Case.Trademarks.BasicTrademark",CodeFieldName = "TheLawInfo.dt_BeginDate"},
                new ConmonFunctionForUpdate.MonitorField{MonitorType = ConmonFunctionForUpdate.EnumMonitorType.Deadline,FieldName = "dt_EndDate",CodeNameSpace = "DataEntities.Case.Trademarks.BasicTrademark",CodeFieldName = "TheLawInfo.dt_EndDate"},
                new ConmonFunctionForUpdate.MonitorField{MonitorType = ConmonFunctionForUpdate.EnumMonitorType.Deadline,FieldName = "dt_WithdrawDate",CodeNameSpace = "DataEntities.Case.Trademarks.BasicTrademark",CodeFieldName = "TheLawInfo.dt_WithdrawDate"},
                new ConmonFunctionForUpdate.MonitorField{MonitorType = ConmonFunctionForUpdate.EnumMonitorType.Deadline,FieldName = "dt_NextRenewal",CodeNameSpace = "DataEntities.Case.Trademarks.BasicTrademark",CodeFieldName = "TheLawInfo.dt_NextRenewal"},
                new ConmonFunctionForUpdate.MonitorField{MonitorType = ConmonFunctionForUpdate.EnumMonitorType.Deadline,FieldName = "dt_DivSubmitDate",CodeNameSpace = "DataEntities.Case.Trademarks.BasicTrademark",CodeFieldName = "TheLawInfo.dt_DivSubmitDate"},
                new ConmonFunctionForUpdate.MonitorField{MonitorType = ConmonFunctionForUpdate.EnumMonitorType.Deadline,FieldName = "dt_OrigAppDate",CodeNameSpace = "DataEntities.Case.Trademarks.BasicTrademark",CodeFieldName = "TheLawInfo.dt_OrigAppDate"},
                new ConmonFunctionForUpdate.MonitorField{MonitorType = ConmonFunctionForUpdate.EnumMonitorType.Deadline,FieldName = "dt_MadFilingDate",CodeNameSpace = "DataEntities.Case.Trademarks.BasicTrademark",CodeFieldName = "TheLawInfo.dt_MadFilingDate"},
                new ConmonFunctionForUpdate.MonitorField{MonitorType = ConmonFunctionForUpdate.EnumMonitorType.Deadline,FieldName = "dt_MadRegDate",CodeNameSpace = "DataEntities.Case.Trademarks.BasicTrademark",CodeFieldName = "TheLawInfo.dt_MadRegDate"},
                new ConmonFunctionForUpdate.MonitorField{MonitorType = ConmonFunctionForUpdate.EnumMonitorType.RelatedInfo,FieldName = "s_AppNo",CodeNameSpace = "DataEntities.Case.Trademarks.BasicTrademark",CodeFieldName = "TheLawInfo.s_AppNo"},
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
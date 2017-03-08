using System;
using System.Collections.Generic;
using DevExpress.Xpo;

namespace DataEntities.Case.Patents
{
    [Persistent("TPCase_OrigPatInfo")]
    public class OrigPatInfo : XPLiteObject
    {
        private DateTime fdt_AppDate;
        private DateTime fdt_CertfDate;
        private DateTime fdt_IssuedPubDate;
        private DateTime fdt_PctAppDate;
        private DateTime fdt_PctInNationDate;
        private DateTime fdt_PctPubDate;
        private DateTime fdt_PubDate;
        private DateTime fdt_SubstantiveExamDate;
        private DateTime fdt_FirstCheckDate;
        private int fn_ClaimCount;
        private int fn_ID;
        private int fn_PCTPubLan;

        private string fs_AppNo;
        private string fs_CaseSerial;
        private int fn_OrigRegCountry;
        private string fs_CertfNo;
        private string fs_IssuedPubClass1;
        private string fs_IssuedPubClass2;
        private string fs_IssuedPubGazette;
        private string fs_IssuedPubNo;
        private string fs_IssuedPubVolume;
        private string fs_Note;
        private string fs_PCTAppNo;
        private string fs_PCTPubNo;
        private string fs_PatentName;
        private string fs_PatentStatus;
        private string fs_PubClass1;
        private string fs_PubClass2;
        private string fs_PubGazette;
        private string fs_PubNo;
        private string fs_PubVolume;

        public OrigPatInfo(Session session)
            : base(session)
        {
        }

        public OrigPatInfo()
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
        public string s_CaseSerial
        {
            get { return fs_CaseSerial; }
            set { SetPropertyValue("s_CaseSerial", ref fs_CaseSerial, value); }
        }

        public int n_OrigRegCountry
        {
            get { return fn_OrigRegCountry; }
            set { SetPropertyValue<int>("n_OrigRegCountry", ref fn_OrigRegCountry, value); }
        }
        [Size(50)]
        public string s_AppNo
        {
            get { return fs_AppNo; }
            set { SetPropertyValue("s_AppNo", ref fs_AppNo, value); }
        }

        public DateTime dt_AppDate
        {
            get { return fdt_AppDate; }
            set { SetPropertyValue<DateTime>("dt_AppDate", ref fdt_AppDate, value); }
        }

        public int n_ClaimCount
        {
            get { return fn_ClaimCount; }
            set { SetPropertyValue<int>("n_ClaimCount", ref fn_ClaimCount, value); }
        }

        [Size(50)]
        public string s_PubNo
        {
            get { return fs_PubNo; }
            set { SetPropertyValue("s_PubNo", ref fs_PubNo, value); }
        }

        public DateTime dt_PubDate
        {
            get { return fdt_PubDate; }
            set { SetPropertyValue<DateTime>("dt_PubDate", ref fdt_PubDate, value); }
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

        public DateTime dt_SubstantiveExamDate
        {
            get { return fdt_SubstantiveExamDate; }
            set { SetPropertyValue<DateTime>("dt_SubstantiveExamDate", ref fdt_SubstantiveExamDate, value); }
        }

        [Size(50)]
        public string s_IssuedPubNo
        {
            get { return fs_IssuedPubNo; }
            set { SetPropertyValue("s_IssuedPubNo", ref fs_IssuedPubNo, value); }
        }

        public DateTime dt_IssuedPubDate
        {
            get { return fdt_IssuedPubDate; }
            set { SetPropertyValue<DateTime>("dt_IssuedPubDate", ref fdt_IssuedPubDate, value); }
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

        public DateTime dt_CertfDate
        {
            get { return fdt_CertfDate; }
            set { SetPropertyValue<DateTime>("dt_CertfDate", ref fdt_CertfDate, value); }
        }

        [Size(50)]
        public string s_PCTAppNo
        {
            get { return fs_PCTAppNo; }
            set { SetPropertyValue("s_PCTAppNo", ref fs_PCTAppNo, value); }
        }

        public DateTime dt_PctAppDate
        {
            get { return fdt_PctAppDate; }
            set { SetPropertyValue<DateTime>("dt_PctAppDate", ref fdt_PctAppDate, value); }
        }

        [Size(50)]
        public string s_PCTPubNo
        {
            get { return fs_PCTPubNo; }
            set { SetPropertyValue("s_PCTPubNo", ref fs_PCTPubNo, value); }
        }

        [Size(50)]
        public string s_Note
        {
            get { return fs_Note; }
            set { SetPropertyValue("s_Note", ref fs_Note, value); }
        }

        [Size(100)]
        public string s_PatentStatus
        {
            get { return fs_PatentStatus; }
            set { SetPropertyValue("s_PatentStatus", ref fs_PatentStatus, value); }
        }

        [Size(300)]
        public string s_PatentName
        {
            get { return fs_PatentName; }
            set { SetPropertyValue("s_PatentName", ref fs_PatentName, value); }
        }

        public DateTime dt_PctPubDate
        {
            get { return fdt_PctPubDate; }
            set { SetPropertyValue<DateTime>("dt_PctPubDate", ref fdt_PctPubDate, value); }
        }

        public DateTime dt_PctInNationDate
        {
            get { return fdt_PctInNationDate; }
            set { SetPropertyValue<DateTime>("dt_PctInNationDate", ref fdt_PctInNationDate, value); }
        }

        public int n_PCTPubLan
        {
            get { return fn_PCTPubLan; }
            set { SetPropertyValue<int>("n_PCTPubLan", ref fn_PCTPubLan, value); }
        }

        public DateTime dt_FirstCheckDate
        {
            get { return fdt_FirstCheckDate; }
            set { SetPropertyValue<DateTime>("dt_FirstCheckDate", ref fdt_FirstCheckDate, value); }
        }


        [Aggregated, Association("OrigPatInfo-BasePatents", typeof(BasicPatent))]
        public XPCollection BasePatents
        {
            get { return GetCollection("BasePatents"); }
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }

        #region Common Method For Update

        protected List<ConmonFunctionForUpdate.MonitorField> _listBeMonitorDateField;
        protected XPLiteObject _xplCopyOfObject;

        protected override void OnLoaded()
        {
            base.OnLoaded();
            _listBeMonitorDateField = new List<ConmonFunctionForUpdate.MonitorField>
            {
                new ConmonFunctionForUpdate.MonitorField{FieldName = "dt_PubDate",CodeNameSpace = "DataEntities.Case.Patents.BasicPatent",CodeFieldName = "TheOrigPatInfo.dt_PubDate"},
                new ConmonFunctionForUpdate.MonitorField{FieldName = "dt_IssuedPubDate",CodeNameSpace = "DataEntities.Case.Patents.BasicPatent",CodeFieldName = "TheOrigPatInfo.dt_IssuedPubDate"},
            };
            var type = this.GetType();
            _xplCopyOfObject = Activator.CreateInstance(type, new[] { new UnitOfWork() }) as XPLiteObject;
            ConmonFunctionForUpdate.CopyDataEntityFileds(this, _xplCopyOfObject, _listBeMonitorDateField);
        }

        protected override void OnSaved()
        {
            base.OnSaved();
            if (Session.IsNewObject(this)) return;
            ConmonFunctionForUpdate.CompareDataEntityFiledsForDeadline(this, _xplCopyOfObject, _listBeMonitorDateField);
        }

        #endregion
    }
}
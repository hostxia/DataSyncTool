using System;
using DataEntities.Properties;
using DevExpress.Xpo;

namespace DataEntities.Config
{
    [Persistent("TCode_CaseProcessItem")]
    public class CodeCaseProcessItem : XPLiteObject
    {
        private CodeCaseProcess codeCaseProcess;
        private CodeProcess codeProcess;
        private int fn_EMaxTimeValue;
        private int fn_EMinTimeValue;
        private int fn_ID;
        private int fn_OrderNum;
        private int fn_PatentID;
        private string fs_AllowRepeat;
        private string fs_AutoCreate;
        private string fs_BaseDate;
        private string fs_EMaxTimeUnit;
        private string fs_EMinTimeUnit;
        private string fs_Note;

        public CodeCaseProcessItem(Session session) : base(session)
        {
        }

        public CodeCaseProcessItem() : base(Session.DefaultSession)
        {
        }

        [Key(true)]
        public int n_ID
        {
            get { return fn_ID; }
            set { SetPropertyValue<int>("n_ID", ref fn_ID, value); }
        }

        [Association("CodeCaseProcess_Item")]
        [Persistent("n_MasterID")]
        public CodeCaseProcess TheCodeCaseProcess
        {
            get { return codeCaseProcess; }
            set { SetPropertyValue("n_MasterID", ref codeCaseProcess, value); }
        }
        //[Aggregated, Association("CodeCaseProcessItem-CodeTaskChainInCodeCaseProcess")]
        //public XPCollection<OldTFCodeTaskChainInCodeCaseProcess> CodeTaskChainInCodeCaseProcess
        //{
        //    get { return GetCollection<OldTFCodeTaskChainInCodeCaseProcess>("CodeTaskChainInCodeCaseProcess"); }
        //}
        //[Aggregated, Association("CodeCaseProcessItem-CodeTaskInChainInCodeCaseProcess")]
        //public XPCollection<OldTFCodeTaskFlowInCodeProcess> CodeTaskInChainInCodeCaseProcess
        //{
        //    get { return GetCollection<OldTFCodeTaskFlowInCodeProcess>("CodeTaskInChainInCodeCaseProcess"); }
        //}
        //int fn_CaseProcessID;
        //public int n_CaseProcessID
        //{
        //    get { return fn_CaseProcessID; }
        //    set { SetPropertyValue<int>("n_CaseProcessID", ref fn_CaseProcessID, value); }
        //}
      
        [Association("CodeCaseProcess_Name")]
        [Persistent("n_ProcessNameID")]
        public CodeProcess TheCodeProcess
        {
            get { return codeProcess; }
            set { SetPropertyValue("n_ProcessNameID", ref codeProcess, value); }
        }
        private string fsName;
        [NonPersistent]
        public string sName
        {
            get { return TheCodeProcess != null ? TheCodeProcess.s_Name : fsName; }
            set { fsName = value; }
        }

        //int fn_ProcessNameID;
        //public int n_ProcessNameID
        //{
        //    get { return fn_ProcessNameID; }
        //    set { SetPropertyValue<int>("n_ProcessNameID", ref fn_ProcessNameID, value); }
        //}

        public int n_PatentID
        {
            get { return fn_PatentID; }
            set { SetPropertyValue<int>("n_PatentID", ref fn_PatentID, value); }
        }

        [NonPersistent]
        public int SpecialID { get; set; }

        //CodeCaseProcessItem codeCaseProcessItemPatent;
        //[Association("CodeCaseProcess_Parent")]
        //[Persistent("n_PatentID")]
        //public CodeCaseProcessItem TheCodeProcessPratent
        //{
        //    get { return codeCaseProcessItemPatent; }
        //    set { SetPropertyValue<CodeCaseProcessItem>("n_PatentID", ref codeCaseProcessItemPatent, value); }
        //}

        public int n_OrderNum
        {
            get { return fn_OrderNum; }
            set { SetPropertyValue<int>("n_OrderNum", ref fn_OrderNum, value); }
        }

        [Size(1)]
        public string s_AutoCreate
        {
            get { return fs_AutoCreate; }
            set { SetPropertyValue("s_AutoCreate", ref fs_AutoCreate, value); }
        }

        [Size(50)]
        public string s_AllowRepeat
        {
            get { return fs_AllowRepeat; }
            set { SetPropertyValue("s_AllowRepeat", ref fs_AllowRepeat, value); }
        }

        public int n_EMinTimeValue
        {
            get { return fn_EMinTimeValue; }
            set { SetPropertyValue<int>("n_EMinTimeValue", ref fn_EMinTimeValue, value); }
        }

        [Size(5)]
        public string s_EMinTimeUnit
        {
            get { return fs_EMinTimeUnit; }
            set { SetPropertyValue("s_EMinTimeUnit", ref fs_EMinTimeUnit, value); }
        }

        public int n_EMaxTimeValue
        {
            get { return fn_EMaxTimeValue; }
            set { SetPropertyValue<int>("n_EMaxTimeValue", ref fn_EMaxTimeValue, value); }
        }

        [Size(5)]
        public string s_EMaxTimeUnit
        {
            get { return fs_EMaxTimeUnit; }
            set { SetPropertyValue("s_EMaxTimeUnit", ref fs_EMaxTimeUnit, value); }
        }

        [Size(50)]
        public string s_Note
        {
            get { return fs_Note; }
            set { SetPropertyValue("s_Note", ref fs_Note, value); }
        }

        public string s_BaseDate
        {
            get { return fs_BaseDate; }
            set { SetPropertyValue("s_BaseDate", ref fs_BaseDate, value); }
        }

        [NonPersistent]
        public string s_MaxTime
        {
            get
            {
                switch (s_EMaxTimeUnit)
                {
                    case "D":
                        return n_EMaxTimeValue + Resource.Day;
                    case "M":
                        return n_EMaxTimeValue + Resource.Month;
                    case "W":
                        return n_EMaxTimeValue + Resource.Week;
                }
                return "";
            }
        }

        [NonPersistent]
        public string s_MinTime
        {
            get
            {
                switch (s_EMinTimeUnit)
                {
                    case "D":
                        return n_EMinTimeValue + Resource.Day;
                    case "M":
                        return n_EMinTimeValue + Resource.Month;
                    case "W":
                        return n_EMinTimeValue + Resource.Week;
                }
                return "";
            }
        }
        [NonPersistent]
        public string sAutoCreate
        {
            get
            {
                return s_AutoCreate=="Y"?"ÊÇ":"·ñ";
            }
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}
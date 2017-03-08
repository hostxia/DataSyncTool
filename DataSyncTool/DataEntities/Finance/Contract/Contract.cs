using System;
using DataEntities.Case;
using DataEntities.Contact.Client;
using DataEntities.Finance.Accounting;
using DevExpress.Xpo;

namespace DataEntities.Finance.Contract
{
    [Persistent("T_Contract")]
    public class Contract : XPLiteObject
    {
        private readonly XPDelayedProperty fdt_CreateDate = new XPDelayedProperty();
        private readonly XPDelayedProperty fdt_EditDate = new XPDelayedProperty();
        private Client TCstmrClient;
        private DateTime fdt_ContractDate;
        private int fn_ID;
        private string fs_CNO;
        private string fs_CState;
        private string fs_Creator;
        private string fs_Editor;
        private string fs_FilePath;
        private string fs_Note;

        public Contract(Session session) : base(session)
        {
        }

        public Contract() : base(Session.DefaultSession)
        {
        }

        [Key(true)]
        public int n_ID
        {
            get { return fn_ID; }
            set { SetPropertyValue<int>("n_ID", ref fn_ID, value); }
        }

        public DateTime dt_ContractDate
        {
            get { return fdt_ContractDate; }
            set { SetPropertyValue<DateTime>("dt_ContractDate", ref fdt_ContractDate, value); }
        }

        [Size(100)]
        public string s_CNO
        {
            get { return fs_CNO; }
            set { SetPropertyValue("s_CNO", ref fs_CNO, value); }
        }

        [Size(100)]
        public string s_CState
        {
            get { return fs_CState; }
            set { SetPropertyValue("s_CState", ref fs_CState, value); }
        }


        [Association("ClientContract")]
        [Persistent("n_ClientID")]
        public Client tCstmrClient
        {
            get { return TCstmrClient; }
            set { SetPropertyValue("n_ClientID", ref TCstmrClient, value); }
        }

        [Size(1000)]
        public string s_Note
        {
            get { return fs_Note; }
            set { SetPropertyValue("s_Note", ref fs_Note, value); }
        }

        [Size(1000)]
        public string s_FilePath
        {
            get { return fs_FilePath; }
            set { SetPropertyValue("s_FilePath", ref fs_FilePath, value); }
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

        [Aggregated, Association("Contract-CameMoneys")]
        public XPCollection<CameMoney> CameMoneys
        {
            get { return GetCollection<CameMoney>("CameMoneys"); }
        }

        [Aggregated, Association("Contract-Cases")]
        public XPCollection<BasicCase> BasicCases
        {
            get { return GetCollection<BasicCase>("BasicCases"); }
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}
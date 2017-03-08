using System;
using DataEntities.Case;
using DevExpress.Xpo;

namespace DataEntities.Config
{
    [Persistent("TCode_Process")]
    public class CodeProcess : XPLiteObject
    {
        private DateTime fdt_CreateDate;
        private DateTime fdt_EditDate;
        private int fn_ID;
        private string fs_AllowRepeat;
        private string fs_Business;

        private string fs_MasterType;

        private string fs_Name;
        private string fs_Notes;

        private string fs_OtherName;

        public CodeProcess(Session session) : base(session)
        {
        }

        public CodeProcess() : base(Session.DefaultSession)
        {
        }

        [Key(true)]
        public int n_ID
        {
            get { return fn_ID; }
            set { SetPropertyValue<int>("n_ID", ref fn_ID, value); }
        }

        [Size(1)]
        public string s_IPType
        {
            get { return fs_MasterType; }
            set { SetPropertyValue("s_IPType", ref fs_MasterType, value); }
        }

        [Size(50)]
        public string s_Name
        {
            get { return fs_Name; }
            set { SetPropertyValue("s_Name", ref fs_Name, value); }
        }

        [Size(50)]
        public string s_OtherName
        {
            get { return fs_OtherName; }
            set { SetPropertyValue("s_OtherName", ref fs_OtherName, value); }
        }

        [Size(1)]
        public string s_AllowRepeat
        {
            get { return fs_AllowRepeat; }
            set { SetPropertyValue("s_AllowRepeat", ref fs_AllowRepeat, value); }
        }

        [Size(300)]
        public string s_Business
        {
            get { return fs_Business; }
            set { SetPropertyValue("s_Business", ref fs_Business, value); }
        }

        [Size(800)]
        public string s_Notes
        {
            get { return fs_Notes; }
            set { SetPropertyValue("s_Notes", ref fs_Notes, value); }
        }

        public DateTime dt_CreateDate
        {
            get { return fdt_CreateDate; }
            set { SetPropertyValue<DateTime>("dt_CreateDate", ref fdt_CreateDate, value); }
        }

        public DateTime dt_EditDate
        {
            get { return fdt_EditDate; }
            set { SetPropertyValue<DateTime>("dt_EditDate", ref fdt_EditDate, value); }
        }

        [Aggregated, Association("CodeProcessCustomField", typeof (CodeProcessCustomField))]
        public XPCollection CodeProcessCustomField
        {
            get { return GetCollection("CodeProcessCustomField"); }
        }

        [Aggregated, Association("CodeProcess-Processes", typeof (Process))]
        public XPCollection Processes
        {
            get { return GetCollection("Processes"); }
        }

        [Aggregated, Association("CodeCaseProcess_Name", typeof (CodeCaseProcessItem))]
        public XPCollection CodeProcessCustomItems
        {
            get { return GetCollection("CodeProcessCustomItems"); }
        }

        [NonPersistent]
        public bool Check { get; set; }

        [NonPersistent]
        public int CodeCaseProcessItemID { get; set; }

        [NonPersistent]
        public int iOrderNum { get; set; }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}
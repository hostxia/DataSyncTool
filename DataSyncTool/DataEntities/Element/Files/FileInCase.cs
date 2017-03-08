using DataEntities.Case;
using DevExpress.Xpo;

namespace DataEntities.Element.Files
{
    [Persistent("T_FileInCase")]
    public class FileInCase : XPLiteObject
    {
        private int fn_ID;
        private string fs_IsMainCase;
        private string fs_SelectType;
        private BasicCase theCase;
        private BaseFile theFile;
        private Process theProcess;
        private int fn_AnnualFeeID;
        public FileInCase(Session session)
            : base(session)
        {
        }

        public FileInCase()
            : base(Session.DefaultSession)
        {
        }

        [Key(true)]
        public int n_ID
        {
            get { return fn_ID; }
            set { SetPropertyValue<int>("n_ID", ref fn_ID, value); }
        }

        public int n_AnnualFeeID
        {
            get { return fn_AnnualFeeID; }
            set { SetPropertyValue<int>("n_AnnualFeeID", ref fn_AnnualFeeID, value); }
        }

        [Persistent("n_FileID")]
        [Association("File-FileInCases", typeof(BaseFile))]
        public BaseFile TheFile
        {
            get { return theFile; }
            set { SetPropertyValue("n_FileID", ref theFile, value); }
        }

        [Persistent("n_CaseID")]
        [Association("BasicCase-FileInCases", typeof(BasicCase))]
        public BasicCase TheCase
        {
            get { return theCase; }
            set { SetPropertyValue("n_CaseID", ref theCase, value); }
        }

        [Persistent("n_ProcessID")]
        [Association("Process-FileInCases")]
        public Process TheProcess
        {
            get { return theProcess; }
            set { SetPropertyValue("n_ProcessID", ref theProcess, value); }
        }

        [Size(1)]
        [Persistent("s_IsMainCase")]
        public string s_IsMainCase
        {
            get { return fs_IsMainCase; }
            set { SetPropertyValue("s_IsMainCase", ref fs_IsMainCase, value); }
        }
        [Size(1)]
        [Persistent("s_SelectType")]
        public string s_SelectType
        {
            get { return fs_SelectType; }
            set { SetPropertyValue("s_SelectType", ref fs_SelectType, value); }
        }

        private string fs_MaterialType;
        [Size(50)]
        [Persistent("s_MaterialType")]
        public string s_MaterialType
        {
            get { return fs_MaterialType; }
            set { SetPropertyValue("s_MaterialType", ref fs_MaterialType, value); }
        }
        [NonPersistent]
        public string s_OfficialNo
        {
            get { return (theFile as InFile) != null ? (theFile as InFile).s_OfficialNO : ""; }
        }
        [NonPersistent]
        public int n_FileCodeID
        {
            get { return (theFile as InFile) != null ? (theFile as InFile).n_FileCodeID : 0; }
        }
        [NonPersistent]
        public bool Check { get; set; }
        //[NonPersistent]
        //public string s_IsNewCaseInFile
        //{
        //    get { return (theFile as InFile) != null ? (theFile as InFile).s_IsNewCaseInFile : "";}
        //    set { s_IsNewCaseInFile = value; }
        //}
        //此字段只是用于PA导入数据
        [NonPersistent]
        public string PA_FileID { get; set; }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}
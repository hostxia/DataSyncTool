using DevExpress.Xpo;

namespace DataEntities.Case.Patents
{
    [Persistent("TPCase_Inventor")]
    public class Inventor : XPLiteObject
    {
        private ExtendedPatent fPatent;
        private int fn_Country;
        private int fn_ID;
        private int fn_Sequence;
        private string fs_Address;
        private string fs_IDCard;
        private string fs_Name;
        private string fs_NativeAddress;
        private string fs_NativeName;
        private string fs_OtherAddr;
        private string fs_Notes;
        private string fs_OtherName;
        private string fs_SecretName;

        public Inventor(Session session) : base(session)
        {
        }

        public Inventor() : base(Session.DefaultSession)
        {
        }

        [Key(true)]
        public int n_ID
        {
            get { return fn_ID; }
            set { SetPropertyValue<int>("n_ID", ref fn_ID, value); }
        }

        [Association("Patent-Inventors")]
        [Persistent("n_CaseID")]
        public ExtendedPatent ThePatent
        {
            get { return fPatent; }
            set { SetPropertyValue("n_CaseID", ref fPatent, value); }
        }

        public int n_Sequence
        {
            get { return fn_Sequence; }
            set { SetPropertyValue<int>("n_Sequence", ref fn_Sequence, value); }
        }

        [Size(300)]
        public string s_Name
        {
            get { return fs_Name; }
            set { SetPropertyValue("s_Name", ref fs_Name, value); }
        }

        [Size(300)]
        public string s_NativeName
        {
            get { return fs_NativeName; }
            set { SetPropertyValue("s_NativeName", ref fs_NativeName, value); }
        }

        [Size(500)]
        public string s_OtherName
        {
            get { return fs_OtherName; }
            set { SetPropertyValue("s_OtherNae", ref fs_OtherName, value); }
        }

        public int n_Country
        {
            get { return fn_Country; }
            set { SetPropertyValue<int>("n_Country", ref fn_Country, value); }
        }

        [Size(300)]
        public string s_Address
        {
            get { return fs_Address; }
            set { SetPropertyValue("s_Address", ref fs_Address, value); }
        }

        [Size(300)]
        public string s_NativeAddress
        {
            get { return fs_NativeAddress; }
            set { SetPropertyValue("s_NativeAddress", ref fs_NativeAddress, value); }
        }

        [Size(50)]
        public string s_IDCard
        {
            get { return fs_IDCard; }
            set { SetPropertyValue("s_IDCard", ref fs_IDCard, value); }
        }

        [Size(1)]
        public string s_SecretName
        {
            get { return fs_SecretName; }
            set { SetPropertyValue("s_SecretName", ref fs_SecretName, value); }
        }

        [Size(500)]
        public string s_OtherAddr
        {
            get { return fs_OtherAddr; }
            set { SetPropertyValue(" s_OtherAddr", ref fs_OtherAddr, value); }
        }

        [Size(500)]
        public string s_Notes
        {
            get { return fs_Notes; }
            set { SetPropertyValue(" s_Notes", ref fs_Notes, value); }
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}
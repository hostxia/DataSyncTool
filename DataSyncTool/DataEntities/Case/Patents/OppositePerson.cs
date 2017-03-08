using DevExpress.Xpo;

namespace DataEntities.Case.Patents
{
    [Persistent("TPCase_OppositePersons")]
    public class OppositePerson : XPLiteObject
    {
        private ExtendedPatent fn_CaseID;
        private int fn_Country;
        private int fn_ID;
        private string fs_Addr;
        private string fs_Contact;
        private string fs_Email;
        private string fs_Fax;
        private string fs_LawDeputy;
        private string fs_Name;
        private string fs_OtherAddr;
        private string fs_OtherName;
        private string fs_Role;
        private string fs_Tel;
        private string fs_ZipCode;

        public OppositePerson(Session session) : base(session)
        {
        }

        public OppositePerson() : base(Session.DefaultSession)
        {
        }

        [Key(true)]
        public int n_ID
        {
            get { return fn_ID; }
            set { SetPropertyValue<int>("n_ID", ref fn_ID, value); }
        }

        [Association("Patent-OppositePersons")]
        [Persistent("n_CaseID")]
        public ExtendedPatent ThePatent
        {
            get { return fn_CaseID; }
            set { SetPropertyValue("n_CaseID", ref fn_CaseID, value); }
        }

        [Size(1)]
        public string s_Role
        {
            get { return fs_Role; }
            set { SetPropertyValue("s_Role", ref fs_Role, value); }
        }

        [Size(300)]
        public string s_Name
        {
            get { return fs_Name; }
            set { SetPropertyValue("s_Name", ref fs_Name, value); }
        }

        [Size(200)]
        public string s_OtherName
        {
            get { return fs_OtherName; }
            set { SetPropertyValue("s_OtherName", ref fs_OtherName, value); }
        }

        [Size(300)]
        public string s_Addr
        {
            get { return fs_Addr; }
            set { SetPropertyValue("s_Addr", ref fs_Addr, value); }
        }

        [Size(300)]
        public string s_OtherAddr
        {
            get { return fs_OtherAddr; }
            set { SetPropertyValue("s_OtherAddr", ref fs_OtherAddr, value); }
        }

        [Size(50)]
        public string s_ZipCode
        {
            get { return fs_ZipCode; }
            set { SetPropertyValue("s_ZipCode", ref fs_ZipCode, value); }
        }

        [Size(50)]
        public string s_Tel
        {
            get { return fs_Tel; }
            set { SetPropertyValue("s_Tel", ref fs_Tel, value); }
        }

        [Size(50)]
        public string s_Fax
        {
            get { return fs_Fax; }
            set { SetPropertyValue("s_Fax", ref fs_Fax, value); }
        }

        [Size(50)]
        public string s_Email
        {
            get { return fs_Email; }
            set { SetPropertyValue("s_Email", ref fs_Email, value); }
        }

        [Size(200)]
        public string s_LawDeputy
        {
            get { return fs_LawDeputy; }
            set { SetPropertyValue("s_LawDeputy", ref fs_LawDeputy, value); }
        }

        [Size(200)]
        public string s_Contact
        {
            get { return fs_Contact; }
            set { SetPropertyValue("s_Contact", ref fs_Contact, value); }
        }

        public int n_Country
        {
            get { return fn_Country; }
            set { SetPropertyValue<int>("n_Country", ref fn_Country, value); }
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}
using DevExpress.Xpo;

namespace DataEntities.Contact.Client
{
    [Persistent("TCstmr_ClientConAddress")]
    public class ClientContactAddress : XPLiteObject
    {
        private ClientContact TCstmrClientContact;
        private int fn_Country;
        private int fn_ID;
        private string fs_City;
        private string fs_IsMailingAddress;
        private string fs_State;
        private string fs_Street;
        private string fs_Type;
        private string fs_ZipCode;

        public ClientContactAddress(Session session) : base(session)
        {
        }

        public ClientContactAddress() : base(Session.DefaultSession)
        {
        }

        [Key(true)]
        public int n_ID
        {
            get { return fn_ID; }
            set { SetPropertyValue<int>("n_ID", ref fn_ID, value); }
        }

        [Association("ClientConAddress")]
        [Persistent("n_ContactID")]
        public ClientContact tCstmrClientContact
        {
            get { return TCstmrClientContact; }
            set { SetPropertyValue("n_ContactID", ref TCstmrClientContact, value); }
        }

        public int n_Country
        {
            get { return fn_Country; }
            set { SetPropertyValue<int>("n_Country", ref fn_Country, value); }
        }

        public string s_State
        {
            get { return fs_State; }
            set { SetPropertyValue("s_State", ref fs_State, value); }
        }

        public string s_City
        {
            get { return fs_City; }
            set { SetPropertyValue("s_City", ref fs_City, value); }
        }

        [Size(300)]
        public string s_Street
        {
            get { return fs_Street; }
            set { SetPropertyValue("s_Street", ref fs_Street, value); }
        }

        string fs_TitleAddress;
        [Size(1000)]
        public string s_TitleAddress
        {
            get { return fs_TitleAddress; }
            set { SetPropertyValue<string>("s_TitleAddress", ref fs_TitleAddress, value); }
        }

        [Size(50)]
        public string s_ZipCode
        {
            get { return fs_ZipCode; }
            set { SetPropertyValue("s_ZipCode", ref fs_ZipCode, value); }
        }

        [Size(10)]
        public string s_Type
        {
            get { return fs_Type; }
            set { SetPropertyValue("s_Type", ref fs_Type, value); }
        }

        [Size(1)]
        public string s_IsMailingAddress
        {
            get { return fs_IsMailingAddress; }
            set { SetPropertyValue("s_IsMailingAddress", ref fs_IsMailingAddress, value); }
        }

        public string s_StreetAll
        {
            get
            {
                if (string.IsNullOrEmpty(s_Street))
                    return "";
                return fs_Street.Replace("\r\n", "");
            }
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}
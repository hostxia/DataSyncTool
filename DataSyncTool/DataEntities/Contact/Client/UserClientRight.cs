using DataEntities.Config;
using DevExpress.Xpo;

namespace DataEntities.Contact.Client
{
    [Persistent("T_UserClient")]
    public class UserClient : XPLiteObject
    {
        private Client TCstmrClient;
        private CodeEmployee codeEmployee;
        private int fn_ID;

        public UserClient(Session session) : base(session)
        {
        }

        public UserClient() : base(Session.DefaultSession)
        {
        }

        [Key(true)]
        public int n_ID
        {
            get { return fn_ID; }
            set { SetPropertyValue<int>("n_ID", ref fn_ID, value); }
        }

        //int fn_UserID;
        //public int n_UserID
        //{
        //    get { return fn_UserID; }
        //    set { SetPropertyValue<int>("n_UserID", ref fn_UserID, value); }
        //}

        [Association("User-UserClients")]
        [Persistent("n_UserID")]
        public CodeEmployee TheEmployee
        {
            get { return codeEmployee; }
            set { SetPropertyValue("n_UserID", ref codeEmployee, value); }
        }

        [Association("Client-UserClients")]
        [Persistent("n_ClientID")]
        public Client TheClient
        {
            get { return TCstmrClient; }
            set { SetPropertyValue("n_ClientID", ref TCstmrClient, value); }
        }

        //int fn_ClientID;
        //public int n_ClientID
        //{
        //    get { return fn_ClientID; }
        //    set { SetPropertyValue<int>("n_ClientID", ref fn_ClientID, value); }
        //}

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}
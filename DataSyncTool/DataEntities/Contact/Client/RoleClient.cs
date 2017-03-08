using DataEntities.Config.Right;
using DevExpress.Xpo;

namespace DataEntities.Contact.Client
{
    [Persistent("T_RoleClient")]
    public class RoleClient : XPLiteObject
    {
        private Client TCstmrClient;
        private Role _role;
        private int fn_ID;

        public RoleClient(Session session) : base(session)
        {
        }

        public RoleClient() : base(Session.DefaultSession)
        {
        }

        [Key(true)]
        public int n_ID
        {
            get { return fn_ID; }
            set { SetPropertyValue<int>("n_ID", ref fn_ID, value); }
        }

        [Association("Role-RoleClients")]
        [Persistent("n_RoleID")]
        public Role TheRole
        {
            get { return _role; }
            set { SetPropertyValue("n_RoleID", ref _role, value); }
        }

        //int fn_RoleID;
        //public int n_RoleID
        //{
        //    get { return fn_RoleID; }
        //    set { SetPropertyValue<int>("n_RoleID", ref fn_RoleID, value); }
        //}

        [Association("Client-RoleClients")]
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
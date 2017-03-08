using DataEntities.Contact.Client;
using DevExpress.Xpo;

namespace DataEntities.Case
{
    [Persistent("TCase_Clients")]
    public class CaseClients : XPLiteObject
    {
        public CaseClients(Session session)
            : base(session)
        {
        }

        public CaseClients()
            : base(Session.DefaultSession)
        {
        }

        int fn_ID;
        [Key(true)]
        public int n_ID
        {
            get { return fn_ID; }
            set { SetPropertyValue<int>("n_ID", ref fn_ID, value); }
        }

        BasicCase basicCase;
        [Association("Case-CaseClients")]
        [Persistent("n_CaseID")]
        public BasicCase BasicCase
        {
            get { return basicCase; }
            set { SetPropertyValue("n_CaseID", ref basicCase, value); }
        }

        private Client client;
        [Association("Client-CaseClients")]
        [Persistent("n_ClientID")]
        public Client Client
        {
            get { return client; }
            set { SetPropertyValue("n_ClientID", ref client, value); }
        }
    }
}

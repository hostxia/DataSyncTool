using System;
using DevExpress.Xpo;

namespace DataEntities.Contact.Client
{
    [Persistent("TCstmr_ClientChangeHistory")]
    public class ClientChangeHistory : XPLiteObject
    {
        private Client client;
        private DateTime fdt_ChangeDate;
        private int fn_ID;
        private string fs_ChangeFrom;
        private string fs_ChangeProject;
        private string fs_ChangeTo;
        private string fs_Notes;

        public ClientChangeHistory(Session session) : base(session)
        {
        }

        public ClientChangeHistory() : base(Session.DefaultSession)
        {
        }

        [Key(true)]
        public int n_ID
        {
            get { return fn_ID; }
            set { SetPropertyValue<int>("n_ID", ref fn_ID, value); }
        }

        [Persistent("n_ClientID")]
        [Association("Client-ChangeHistory")]
        public Client TheClient
        {
            get { return client; }
            set { SetPropertyValue("n_ClientID", ref client, value); }
        }

        [Size(50)]
        public string s_ChangeProject
        {
            get { return fs_ChangeProject; }
            set { SetPropertyValue("s_ChangeProject", ref fs_ChangeProject, value); }
        }

        [Size(1000)]
        public string s_ChangeFrom
        {
            get { return fs_ChangeFrom; }
            set { SetPropertyValue("s_ChangeFrom", ref fs_ChangeFrom, value); }
        }

        [Size(1000)]
        public string s_ChangeTo
        {
            get { return fs_ChangeTo; }
            set { SetPropertyValue("s_ChangeTo", ref fs_ChangeTo, value); }
        }

        public DateTime dt_ChangeDate
        {
            get { return fdt_ChangeDate; }
            set { SetPropertyValue<DateTime>("dt_ChangeDate", ref fdt_ChangeDate, value); }
        }

        [Size(800)]
        public string s_Notes
        {
            get { return fs_Notes; }
            set { SetPropertyValue("s_Notes", ref fs_Notes, value); }
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}
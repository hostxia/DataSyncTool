using DevExpress.Xpo;

namespace DataEntities.Config
{
    [Persistent("DZSQ_KHD_GJDQPZB")]
    public class CodeCPCCountry : XPLiteObject
    {
        private string fGUOJIADQDM;

        private string fGUOJIADQID;

        private string fGUOJIADQMC;

        public CodeCPCCountry(Session session) : base(session)
        {
        }

        public CodeCPCCountry() : base(Session.DefaultSession)
        {
        }

        [Persistent("GUOJIADQDM")]
        [Size(16)]
        public string GUOJIADQDM
        {
            get { return fGUOJIADQDM; }
            set { SetPropertyValue("GUOJIADQDM", ref fGUOJIADQDM, value); }
        }

        [Key]
        [Persistent("GUOJIADQID")]
        public string GUOJIADQID
        {
            get { return fGUOJIADQID; }
            set { SetPropertyValue("GUOJIADQID", ref fGUOJIADQID, value); }
        }

        [Persistent("GUOJIADQMC")]
        [Size(255)]
        public string GUOJIADQMC
        {
            get { return fGUOJIADQMC; }
            set { SetPropertyValue("GUOJIADQMC", ref fGUOJIADQMC, value); }
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}
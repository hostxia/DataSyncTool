using DevExpress.Xpo;

namespace DataEntities.Config
{
    [Persistent("DZSQ_KHD_GJXZQH")]
    public class CodeCPCProvince : XPLiteObject
    {
        private string fGJXZQHDM;

        private string fGJXZQHMC;

        private string fGJXZQHSJ;

        private string fGJXZQHYZBM;
        private string fGJXZQH_ID;

        private string fZHUANTAI;

        public CodeCPCProvince(Session session) : base(session)
        {
        }

        public CodeCPCProvince() : base(Session.DefaultSession)
        {
        }

        [Key]
        [Size(64)]
        [Persistent("GJXZQH_ID")]
        public string GJXZQH_ID
        {
            get { return fGJXZQH_ID; }
            set { SetPropertyValue("GJXZQH_ID", ref fGJXZQH_ID, value); }
        }

        [Persistent("GJXZQHDM")]
        [Size(16)]
        public string GJXZQHDM
        {
            get { return fGJXZQHDM; }
            set { SetPropertyValue("GJXZQHDM", ref fGJXZQHDM, value); }
        }

        [Size(255)]
        [Persistent("GJXZQHMC")]
        public string GJXZQHMC
        {
            get { return fGJXZQHMC; }
            set { SetPropertyValue("GJXZQHMC", ref fGJXZQHMC, value); }
        }

        [Size(64)]
        [Persistent("GJXZQHSJ")]
        public string GJXZQHSJ
        {
            get { return fGJXZQHSJ; }
            set { SetPropertyValue("GJXZQHSJ", ref fGJXZQHSJ, value); }
        }

        [Size(64)]
        [Persistent("GJXZQHYZBM")]
        public string GJXZQHYZBM
        {
            get { return fGJXZQHYZBM; }
            set { SetPropertyValue("GJXZQHYZBM", ref fGJXZQHYZBM, value); }
        }

        [Size(4)]
        [Persistent("ZHUANTAI")]
        public string ZHUANTAI
        {
            get { return fZHUANTAI; }
            set { SetPropertyValue("ZHUANTAI", ref fZHUANTAI, value); }
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}
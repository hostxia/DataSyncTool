using DevExpress.Xpo;

namespace DataEntities.Config
{
    [Persistent("TCode_State")]
    public class CodeState : XPLiteObject
    {
        private CodeCountry codeCountry;
        private int fn_StateID;
        private string fs_OStateName;
        private string fs_RegionCode;
        private string fs_StateName;

        public CodeState(Session session) : base(session)
        {
        }

        public CodeState() : base(Session.DefaultSession)
        {
        }

        [Key(true)]
        public int n_StateID
        {
            get { return fn_StateID; }
            set { SetPropertyValue<int>("n_StateID", ref fn_StateID, value); }
        }

        [Association("Country-State")]
        [Persistent("n_Country")]
        public CodeCountry CodeCountry
        {
            get { return codeCountry; }
            set { SetPropertyValue("n_Country", ref codeCountry, value); }
        }

        public string s_StateName
        {
            get { return fs_StateName; }
            set { SetPropertyValue("s_StateName", ref fs_StateName, value); }
        }

        public string s_OStateName
        {
            get { return fs_OStateName; }
            set { SetPropertyValue("s_OStateName", ref fs_OStateName, value); }
        }

        /// <summary>
        ///     行政区划编码
        /// </summary>
        public string s_RegionCode
        {
            get { return fs_RegionCode; }
            set { SetPropertyValue("s_RegionCode", ref fs_RegionCode, value); }
        }

        [Aggregated, Association("State-City", typeof (CodeCity))]
        public XPCollection Cities
        {
            get { return GetCollection("Cities"); }
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}
using DevExpress.Xpo;

namespace DataEntities.Config
{
    [Persistent("TCode_City")]
    public class CodeCity : XPLiteObject
    {
        private CodeState codeState;
        private int fn_CityID;
        private string fs_CityName;
        private string fs_OCityName;
        private string fs_RegionCode;
        private string fs_TelAreaCode;
        private string fs_ZipCode;

        public CodeCity(Session session) : base(session)
        {
        }

        public CodeCity() : base(Session.DefaultSession)
        {
        }

        [Key(true)]
        public int n_CityID
        {
            get { return fn_CityID; }
            set { SetPropertyValue<int>("n_CityID", ref fn_CityID, value); }
        }

        [Association("State-City")]
        [Persistent("n_StateID")]
        public CodeState CodeState
        {
            get { return codeState; }
            set { SetPropertyValue("n_StateID", ref codeState, value); }
        }

        public string s_CityName
        {
            get { return fs_CityName; }
            set { SetPropertyValue("s_CityName", ref fs_CityName, value); }
        }

        public string s_OCityName
        {
            get { return fs_OCityName; }
            set { SetPropertyValue("s_OCityName", ref fs_OCityName, value); }
        }

        [Size(50)]
        public string s_TelAreaCode
        {
            get { return fs_TelAreaCode; }
            set { SetPropertyValue("s_TelAreaCode", ref fs_TelAreaCode, value); }
        }

        [Size(50)]
        public string s_ZipCode
        {
            get { return fs_ZipCode; }
            set { SetPropertyValue("s_ZipCode", ref fs_ZipCode, value); }
        }

        /// <summary>
        ///     行政区划编码
        /// </summary>
        public string s_RegionCode
        {
            get { return fs_RegionCode; }
            set { SetPropertyValue("s_RegionCode", ref fs_RegionCode, value); }
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}
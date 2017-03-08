using DevExpress.Xpo;

namespace DataEntities.Case.Trademarks
{
    [MapInheritance(MapInheritanceType.OwnTable)]
    [Persistent("TTCase_CountermandInfo")]
    public class CaseCountermandInfo : ExtendedTrademark
    {
        private string fs_ApplyInfo;
        private string fs_CheckNum;
        private string fs_CountermandType;

        private string fs_Reason;

        public CaseCountermandInfo(Session session) : base(session)
        {
        }

        public CaseCountermandInfo() : base(Session.DefaultSession)
        {
        }

        [Size(200)]
        public string s_CountermandType
        {
            get { return fs_CountermandType; }
            set { SetPropertyValue("s_CountermandType", ref fs_CountermandType, value); }
        }

        [Size(500)]
        public string s_Reason
        {
            get { return fs_Reason; }
            set { SetPropertyValue("s_Reason", ref fs_Reason, value); }
        }

        [Size(500)]
        public string s_ApplyInfo
        {
            get { return fs_ApplyInfo; }
            set { SetPropertyValue("s_ApplyInfo", ref fs_ApplyInfo, value); }
        }

        [Size(500)]
        public string s_CheckNum
        {
            get { return fs_CheckNum; }
            set { SetPropertyValue("s_CheckNum", ref fs_CheckNum, value); }
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}
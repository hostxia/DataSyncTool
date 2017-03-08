using DevExpress.Xpo;

namespace DataEntities.Case.Trademarks
{
    [MapInheritance(MapInheritanceType.OwnTable)]
    [Persistent("TTCase_Repeal3Info")]
    public class CaseRepeal3Info : ConflictInfo
    {
        private string fs_RepealReason;
        private string fs_RepealType;

        public CaseRepeal3Info(Session session) : base(session)
        {
        }

        public CaseRepeal3Info() : base(Session.DefaultSession)
        {
        }

        [Size(1)]
        public string s_RepealType
        {
            get { return fs_RepealType; }
            set { SetPropertyValue("s_RepealType", ref fs_RepealType, value); }
        }

        [Size(1000)]
        public string s_RepealReason
        {
            get { return fs_RepealReason; }
            set { SetPropertyValue("s_RepealReason", ref fs_RepealReason, value); }
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}
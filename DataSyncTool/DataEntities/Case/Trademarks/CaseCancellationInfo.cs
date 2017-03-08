using DevExpress.Xpo;

namespace DataEntities.Case.Trademarks
{
    [MapInheritance(MapInheritanceType.OwnTable)]
    [Persistent("TTCase_CancellationInfo")]
    public class CaseCancellationInfo : ConflictInfo
    {
        private string fs_LogoutRegister;
        private string fs_ReasonCancelReason;

        public CaseCancellationInfo(Session session) : base(session)
        {
        }

        public CaseCancellationInfo() : base(Session.DefaultSession)
        {
        }

        [Size(1000)]
        public string s_ReasonCancelReason
        {
            get { return fs_ReasonCancelReason; }
            set { SetPropertyValue("s_ReasonCancelReason", ref fs_ReasonCancelReason, value); }
        }

        public string s_LogoutRegister
        {
            get { return fs_LogoutRegister; }
            set { SetPropertyValue("s_LogoutRegister", ref fs_LogoutRegister, value); }
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}
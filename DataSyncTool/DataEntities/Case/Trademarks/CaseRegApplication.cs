using DevExpress.Xpo;

namespace DataEntities.Case.Trademarks
{
    [MapInheritance(MapInheritanceType.ParentTable)]
    public class CaseRegApplication : ExtendedTrademark
    {
        public CaseRegApplication(Session session) : base(session)
        {
        }

        public CaseRegApplication() : base(Session.DefaultSession)
        {
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}
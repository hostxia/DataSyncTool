using DevExpress.Xpo;

namespace DataEntities.Case.Trademarks
{
    [MapInheritance(MapInheritanceType.ParentTable)]
    public class CaseRenewal : ExtendedTrademark
    {
        public CaseRenewal(Session session) : base(session)
        {
        }

        public CaseRenewal() : base(Session.DefaultSession)
        {
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}
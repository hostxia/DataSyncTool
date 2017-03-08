using DevExpress.Xpo;

namespace DataEntities.Case.Patents
{
    [MapInheritance(MapInheritanceType.ParentTable)]
    public class CasePCTN : ExtendedPatent
    {
        public CasePCTN(Session session) : base(session)
        {
        }

        public CasePCTN() : base(Session.DefaultSession)
        {
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}
using DevExpress.Xpo;

namespace DataEntities.Case.Patents
{
    [MapInheritance(MapInheritanceType.ParentTable)]
    public class CaseTransfer : ExtendedPatent
    {
        public CaseTransfer(Session session) : base(session)
        {
        }

        public CaseTransfer() : base(Session.DefaultSession)
        {
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}
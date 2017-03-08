using DevExpress.Xpo;

namespace DataEntities.Case.Trademarks
{
    [MapInheritance(MapInheritanceType.ParentTable)]
    public class CaseTransfer : MultiPersonCase
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
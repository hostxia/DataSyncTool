using DevExpress.Xpo;

namespace DataEntities.Case.Trademarks
{
    [MapInheritance(MapInheritanceType.ParentTable)]
    public class CaseRefusedReview : ConflictInfo
    {
        public CaseRefusedReview(Session session) : base(session)
        {
        }

        public CaseRefusedReview() : base(Session.DefaultSession)
        {
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}
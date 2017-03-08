using DevExpress.Xpo;

namespace DataEntities.Case.Trademarks
{
    [MapInheritance(MapInheritanceType.ParentTable)]
    public class CaseDissentReview : ConflictInfo
    {
        public CaseDissentReview(Session session) : base(session)
        {
        }

        public CaseDissentReview() : base(Session.DefaultSession)
        {
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}
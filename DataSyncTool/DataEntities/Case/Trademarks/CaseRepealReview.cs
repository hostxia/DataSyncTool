using DevExpress.Xpo;

namespace DataEntities.Case.Trademarks
{
    [MapInheritance(MapInheritanceType.ParentTable)]
    public class CaseRepealReview : ConflictInfo
    {
        public CaseRepealReview(Session session) : base(session)
        {
        }

        public CaseRepealReview() : base(Session.DefaultSession)
        {
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}
using DevExpress.Xpo;

namespace DataEntities.Case.Trademarks
{
    [MapInheritance(MapInheritanceType.ParentTable)]
    public class CaseRepealReviewReply : ConflictInfo
    {
        public CaseRepealReviewReply(Session session) : base(session)
        {
        }

        public CaseRepealReviewReply() : base(Session.DefaultSession)
        {
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}
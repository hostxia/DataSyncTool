using DevExpress.Xpo;

namespace DataEntities.Case.Trademarks
{
    [MapInheritance(MapInheritanceType.ParentTable)]
    public class CaseDisputeReply : ConflictInfo
    {
        public CaseDisputeReply(Session session) : base(session)
        {
        }

        public CaseDisputeReply() : base(Session.DefaultSession)
        {
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}
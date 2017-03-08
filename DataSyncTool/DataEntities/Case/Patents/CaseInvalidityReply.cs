using DevExpress.Xpo;

namespace DataEntities.Case.Patents
{
    [MapInheritance(MapInheritanceType.ParentTable)]
    public class CaseInvalidityReply : ExtendedPatent
    {
        public CaseInvalidityReply(Session session) : base(session)
        {
        }

        public CaseInvalidityReply() : base(Session.DefaultSession)
        {
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}
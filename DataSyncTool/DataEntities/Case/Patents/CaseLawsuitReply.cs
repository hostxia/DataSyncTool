using DevExpress.Xpo;

namespace DataEntities.Case.Patents
{
    [MapInheritance(MapInheritanceType.ParentTable)]
    public class CaseLawsuitReply : ExtendedPatent
    {
        public CaseLawsuitReply(Session session) : base(session)
        {
        }

        public CaseLawsuitReply() : base(Session.DefaultSession)
        {
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}
using DevExpress.Xpo;

namespace DataEntities.Case.Trademarks
{
    [MapInheritance(MapInheritanceType.ParentTable)]
    public class CaseLawsuitReply : CaseLawsuit
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
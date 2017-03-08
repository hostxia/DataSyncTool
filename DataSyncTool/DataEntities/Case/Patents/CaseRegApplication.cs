using DevExpress.Xpo;

namespace DataEntities.Case.Patents
{
    [MapInheritance(MapInheritanceType.ParentTable)]
    public class CaseRegApplication : ExtendedPatent
    {
        public CaseRegApplication(Session session) : base(session) { }
        public CaseRegApplication() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }
}
using DevExpress.Xpo;

namespace DataEntities.Case.DomainNames
{
    [MapInheritance(MapInheritanceType.ParentTable)]
    public class ExtendedDomain : BasicDomain
    {
        //TODO
        public ExtendedDomain(Session session) : base(session)
        {
        }

        public ExtendedDomain() : base(Session.DefaultSession)
        {
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}
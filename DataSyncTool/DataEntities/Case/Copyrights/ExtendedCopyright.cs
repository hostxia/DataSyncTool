using DevExpress.Xpo;

namespace DataEntities.Case.Copyrights
{
    [MapInheritance(MapInheritanceType.ParentTable)]
    public class ExtendedCopyright : BasicCopyright
    {
        public ExtendedCopyright(Session session) : base(session)
        {
        }

        public ExtendedCopyright() : base(Session.DefaultSession)
        {
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}
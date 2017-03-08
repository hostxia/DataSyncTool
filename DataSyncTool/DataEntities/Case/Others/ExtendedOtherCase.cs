using DevExpress.Xpo;

namespace DataEntities.Case.Others
{
    [MapInheritance(MapInheritanceType.ParentTable)]
    public class ExtendedOtherCase : BasicOtherCase
    {
        public ExtendedOtherCase(Session session) : base(session)
        {
        }

        public ExtendedOtherCase() : base(Session.DefaultSession)
        {
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}
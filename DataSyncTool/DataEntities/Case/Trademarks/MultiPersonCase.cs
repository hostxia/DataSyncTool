using DevExpress.Xpo;

namespace DataEntities.Case.Trademarks
{
    [MapInheritance(MapInheritanceType.ParentTable)]
    public class MultiPersonCase : ExtendedTrademark
    {
        public MultiPersonCase(Session session) : base(session)
        {
        }

        public MultiPersonCase() : base(Session.DefaultSession)
        {
        }

        [Aggregated, Association("Trademark-OppositePersons", typeof (OppositePerson))]
        public XPCollection OppositePersons
        {
            get { return GetCollection("OppositePersons"); }
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}
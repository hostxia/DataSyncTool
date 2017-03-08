using DevExpress.Xpo;

namespace DataEntities.Case.Trademarks
{
    [MapInheritance(MapInheritanceType.ParentTable)]
    public class CaseChange : ExtendedTrademark
    {
        public CaseChange(Session session) : base(session)
        {
        }

        public CaseChange() : base(Session.DefaultSession)
        {
        }

        [Aggregated, Association("Trademark-ChangeItems", typeof (ChangeItem))]
        public XPCollection ChangeItems
        {
            get { return GetCollection("ChangeItems"); }
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}
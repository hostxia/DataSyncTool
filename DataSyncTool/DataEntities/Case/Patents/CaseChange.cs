using DevExpress.Xpo;

namespace DataEntities.Case.Patents
{
    [MapInheritance(MapInheritanceType.ParentTable)]
    public class CaseChange : ExtendedPatent
    {
        public CaseChange(Session session) : base(session)
        {
        }

        public CaseChange() : base(Session.DefaultSession)
        {
        }

        /// <summary>
        ///     专利的变更项
        /// </summary>
        [Aggregated, Association("CaseChange-ChangeItems", typeof (ChangeItems))]
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
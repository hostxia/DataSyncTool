using DevExpress.Xpo;

namespace DataEntities.Case.Trademarks
{
    [MapInheritance(MapInheritanceType.OwnTable)]
    [Persistent("TTCase_ComplementInfo")]
    public class CaseComplementInfo : ExtendedTrademark
    {
        private string fs_ComplementItem;
        private string fs_Reason;

        public CaseComplementInfo(Session session) : base(session)
        {
        }

        public CaseComplementInfo() : base(Session.DefaultSession)
        {
        }

        [Size(500)]
        public string s_Reason
        {
            get { return fs_Reason; }
            set { SetPropertyValue("s_Reason", ref fs_Reason, value); }
        }

        [Size(500)]
        public string s_ComplementItem
        {
            get { return fs_ComplementItem; }
            set { SetPropertyValue("s_ComplementItem", ref fs_ComplementItem, value); }
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}
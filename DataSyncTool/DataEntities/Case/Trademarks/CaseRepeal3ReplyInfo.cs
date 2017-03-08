using DevExpress.Xpo;

namespace DataEntities.Case.Trademarks
{
    [MapInheritance(MapInheritanceType.OwnTable)]
    [Persistent("TTCase_Repeal3ReplyInfo")]
    public class CaseRepeal3ReplyInfo : ConflictInfo
    {
        private string fs_ReasonReplyReason;

        public CaseRepeal3ReplyInfo(Session session) : base(session)
        {
        }

        public CaseRepeal3ReplyInfo() : base(Session.DefaultSession)
        {
        }

        public string s_ReasonReplyReason
        {
            get { return fs_ReasonReplyReason; }
            set { SetPropertyValue("s_ReasonReplyReason", ref fs_ReasonReplyReason, value); }
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}
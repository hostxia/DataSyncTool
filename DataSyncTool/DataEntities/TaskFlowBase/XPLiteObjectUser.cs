using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;

namespace DataEntities.TaskFlowBase
{
    [MemberDesignTimeVisibility(false)]
    [OptimisticLocking(false)]
    [NonPersistent]
    public abstract class XPLiteObjectUser : XPLiteObject
    {
        protected UnitOfWork TheUow { get { return this.Session as UnitOfWork; } }

        protected XPLiteObjectUser(Session session, XPClassInfo classInfo) : base(session, classInfo) { }
        protected XPLiteObjectUser(Session session) : base(session) { }
        protected XPLiteObjectUser() : base(Session.DefaultSession) { }
    }
}
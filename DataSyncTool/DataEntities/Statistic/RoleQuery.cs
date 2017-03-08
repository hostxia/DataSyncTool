using DataEntities.Config.Right;
using DevExpress.Xpo;

namespace DataEntities.Statistic
{
    [Persistent("T_RoleQuery")]
    public class RoleQuery : XPLiteObject
    {
        private int fn_ID;
        private Role role;
        private CodeQuery codeQuery;

        [Key(true)]
        public int n_ID
        {
            get { return fn_ID; }
            set { SetPropertyValue<int>("n_ID", ref fn_ID, value); }
        }

        [Association("Role-RoleQuerys")]
        [Persistent("n_RoleID")]
        public Role TheRole
        {
            get { return role; }
            set { SetPropertyValue("n_RoleID", ref role, value); }
        }

        [Association("CodeQuery-RoleQuerys")]
        [Persistent("n_CodeQueryID")]
        public CodeQuery TheCodeQuery
        {
            get { return codeQuery; }
            set { SetPropertyValue("n_CodeQueryID", ref codeQuery, value); }
        }

        public RoleQuery(Session session)
            : base(session)
        {
        }

        public RoleQuery()
            : base(Session.DefaultSession)
        {
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}
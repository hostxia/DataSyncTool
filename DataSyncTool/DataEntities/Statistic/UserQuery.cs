using DataEntities.Config;
using DevExpress.Xpo;

namespace DataEntities.Statistic
{
    [Persistent("T_UserQuery")]
    public class UserQuery : XPLiteObject
    {
        private int fn_ID;
        private CodeEmployee codeEmployee;
        private CodeQuery codeQuery;

        [Key(true)]
        public int n_ID
        {
            get { return fn_ID; }
            set { SetPropertyValue<int>("n_ID", ref fn_ID, value); }
        }

        [Association("User-UserQuerys")]
        [Persistent("n_UserID")]
        public CodeEmployee TheEmployee
        {
            get { return codeEmployee; }
            set { SetPropertyValue("n_UserID", ref codeEmployee, value); }
        }

        [Association("CodeQuery-UserQuerys")]
        [Persistent("n_CodeQueryID")]
        public CodeQuery TheCodeQuery
        {
            get { return codeQuery; }
            set { SetPropertyValue("n_CodeQueryID", ref codeQuery, value); }
        }

        public UserQuery(Session session)
            : base(session)
        {
        }

        public UserQuery()
            : base(Session.DefaultSession)
        {
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}
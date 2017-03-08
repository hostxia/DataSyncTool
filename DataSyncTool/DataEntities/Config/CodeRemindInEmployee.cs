using DevExpress.Xpo;

namespace DataEntities.Config
{
    [Persistent("TCode_RemindInEmployee")]
    public class CodeRemindInEmployee : XPLiteObject
    {
        private int fn_ID;
        private CodeEmployee theEmployee;
        private CodeRemind theRemind;
        private bool fb_Mail;
        private bool fb_WeiXin;

        [Key(true)]
        public int n_ID
        {
            get { return fn_ID; }
            set { SetPropertyValue<int>("n_ID", ref fn_ID, value); }
        }

        [Association("RemindInEmployee-Employee")]
        [Persistent("n_EmployeeID")]
        public CodeEmployee TheEmployee
        {
            get { return theEmployee; }
            set { SetPropertyValue<CodeEmployee>("n_EmployeeID", ref theEmployee, value); }
        }

        [Association("RemindInEmployee-Remind")]
        [Persistent("n_RemindID")]
        public CodeRemind TheRemind
        {
            get { return theRemind; }
            set { SetPropertyValue<CodeRemind>("n_RemindID", ref theRemind, value); }
        }

        public bool b_Mail
        {
            get { return fb_Mail; }
            set { SetPropertyValue<bool>("b_Mail", ref fb_Mail, value); }
        }

        public bool b_WeiXin
        {
            get { return fb_WeiXin; }
            set { SetPropertyValue<bool>("b_WeiXin", ref fb_WeiXin, value); }
        }

         public CodeRemindInEmployee(Session session)
            : base(session)
        {
        }

         public CodeRemindInEmployee()
            : base(Session.DefaultSession)
        {
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}
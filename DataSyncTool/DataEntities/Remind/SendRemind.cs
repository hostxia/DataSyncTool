using System;
using DataEntities.Config;
using DevExpress.Xpo;

namespace DataEntities.Remind
{
    [Persistent("T_SendRemind")]
    public class SendRemind : XPLiteObject
    {
        private int fn_ID;
        private CodeEmployee theEmployee;
        private string fs_RemindType;
        private int fn_ElementID;
        private string fs_SendType;
        private string fs_Title;
        private string fs_Content;
        private bool fb_SendFail;
        private Guid fs_GuID;
        private string fs_RemainingDays;

        [Key(true)]
        public int n_ID
        {
            get { return fn_ID; }
            set { SetPropertyValue<int>("n_ID", ref fn_ID, value); }
        }

        [Association("SendRemindInEmployee-Employee")]
        [Persistent("n_EmployeeID")]
        public CodeEmployee TheEmployee
        {
            get { return theEmployee; }
            set { SetPropertyValue<CodeEmployee>("n_EmployeeID", ref theEmployee, value); }
        }

        [Size(2)]
        public string s_RemindType
        {
            get { return fs_RemindType; }
            set { SetPropertyValue("s_RemindType", ref fs_RemindType, value); }
        }

        public int n_ElementID
        {
            get { return fn_ElementID; }
            set { SetPropertyValue<int>("n_ElementID", ref fn_ElementID, value); }
        }

        [Size(2)]
        public string s_SendType
        {
            get { return fs_SendType; }
            set { SetPropertyValue("s_SendType", ref fs_SendType, value); }
        }

        public bool b_SendFail
        {
            get { return fb_SendFail; }
            set { SetPropertyValue("b_SendFail", ref fb_SendFail, value); }
        }

        public Guid s_GuID
        {
            get { return fs_GuID; }
            set { SetPropertyValue<Guid>("s_GuID", ref fs_GuID, value); }
        }

        [Size(10)]
        public string s_RemainingDays
        {
            get { return fs_RemainingDays; }
            set { SetPropertyValue("s_RemainingDays", ref fs_RemainingDays, value); }
        }

        public SendRemind(Session session)
            : base(session)
        {
        }

        public SendRemind()
            : base(Session.DefaultSession)
        {
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}
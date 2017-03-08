using DevExpress.Xpo;

namespace DataEntities.Config
{
    [Persistent("TCode_SecurityConfig")]
    public class CodeSecurityConfig : XPLiteObject
    {
        private int fn_ID;
        private int fn_LockHour;
        private int fn_LockMinute;
        private int fn_PwdDay;
        private int fn_PwdMinLength;
        private int fn_PwdMonth;
        private int fn_PwdYear;
        private int fn_Retry;
        private int fn_TimeoutDay;
        private int fn_TimeoutHour;
        private int fn_TimeoutMinute;
        private string fs_AccessControl;
        private string fs_FailureTry;
        private string fs_IP;
        private string fs_Idle;

        private string fs_PwdComplexity;
        private string fs_PwdCycle;
        private string fs_PwdRegular;

        public CodeSecurityConfig(Session session) : base(session)
        {
        }

        public CodeSecurityConfig() : base(Session.DefaultSession)
        {
        }

        [Key(true)]
        public int n_ID
        {
            get { return fn_ID; }
            set { SetPropertyValue<int>("n_ID", ref fn_ID, value); }
        }

        [Size(1)]
        public string s_PwdComplexity
        {
            get { return fs_PwdComplexity; }
            set { SetPropertyValue("s_PwdComplexity", ref fs_PwdComplexity, value); }
        }

        public int n_PwdMinLength
        {
            get { return fn_PwdMinLength; }
            set { SetPropertyValue<int>("n_PwdMinLength", ref fn_PwdMinLength, value); }
        }

        /// <summary>
        ///     U:´óÐ´×ÖÄ¸;L:Ð¡Ð´×ÖÄ¸;N:Êý×Ö;S:ÌØÊâ×ÖÄ¸£¬°üº¬~!@#$%^&*()_+`-=[]{};':,.?/\\
        /// </summary>
        [Size(20)]
        public string s_PwdRegular
        {
            get { return fs_PwdRegular; }
            set { SetPropertyValue("s_PwdRegular", ref fs_PwdRegular, value); }
        }

        [Size(1)]
        public string s_PwdCycle
        {
            get { return fs_PwdCycle; }
            set { SetPropertyValue("s_PwdCycle", ref fs_PwdCycle, value); }
        }

        public int n_PwdYear
        {
            get { return fn_PwdYear; }
            set { SetPropertyValue<int>("n_PwdYear", ref fn_PwdYear, value); }
        }

        public int n_PwdMonth
        {
            get { return fn_PwdMonth; }
            set { SetPropertyValue<int>("n_PwdMonth", ref fn_PwdMonth, value); }
        }

        public int n_PwdDay
        {
            get { return fn_PwdDay; }
            set { SetPropertyValue<int>("n_PwdDay", ref fn_PwdDay, value); }
        }

        [Size(1)]
        public string s_Idle
        {
            get { return fs_Idle; }
            set { SetPropertyValue("s_Idle", ref fs_Idle, value); }
        }

        public int n_TimeoutDay
        {
            get { return fn_TimeoutDay; }
            set { SetPropertyValue<int>("n_TimeoutDay", ref fn_TimeoutDay, value); }
        }

        public int n_TimeoutHour
        {
            get { return fn_TimeoutHour; }
            set { SetPropertyValue<int>("n_TimeoutHour", ref fn_TimeoutHour, value); }
        }

        public int n_TimeoutMinute
        {
            get { return fn_TimeoutMinute; }
            set { SetPropertyValue<int>("n_TimeoutMinute", ref fn_TimeoutMinute, value); }
        }

        [Size(1)]
        public string s_FailureTry
        {
            get { return fs_FailureTry; }
            set { SetPropertyValue("s_FailureTry", ref fs_FailureTry, value); }
        }

        public int n_LockHour
        {
            get { return fn_LockHour; }
            set { SetPropertyValue<int>("n_LockHour", ref fn_LockHour, value); }
        }

        public int n_LockMinute
        {
            get { return fn_LockMinute; }
            set { SetPropertyValue<int>("n_LockMinute", ref fn_LockMinute, value); }
        }

        public int n_Retry
        {
            get { return fn_Retry; }
            set { SetPropertyValue<int>("n_Retry", ref fn_Retry, value); }
        }

        [Size(1)]
        public string s_AccessControl
        {
            get { return fs_AccessControl; }
            set { SetPropertyValue("s_AccessControl", ref fs_AccessControl, value); }
        }

        [Size(SizeAttribute.Unlimited)]
        public string s_IP
        {
            get { return fs_IP; }
            set { SetPropertyValue("s_IP", ref fs_IP, value); }
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}
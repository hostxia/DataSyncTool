using System;
using DevExpress.Xpo;

namespace DataEntities.Config
{
    [Persistent("TCode_Remind")]
    public class CodeRemind : XPLiteObject
    {
        private int fn_ID;
        private string fs_Module;
        private string fs_Item;
        private string fs_Time;
        private DateTime fdt_CreateDate;
        private DateTime fdt_EditDate;
        private bool fb_Mail;
        private bool fb_WeiXin;

        [Key(true)]
        public int n_ID
        {
            get { return fn_ID; }
            set { SetPropertyValue<int>("n_ID", ref fn_ID, value); }
        }

        [Size(2)]
        public string s_Module
        {
            get { return fs_Module; }
            set { SetPropertyValue("s_Module", ref fs_Module, value); }
        }

        [Size(2)]
        public string s_Item
        {
            get { return fs_Item; }
            set { SetPropertyValue("s_Item", ref fs_Item, value); }
        }

        [Size(4)]
        public string s_Time
        {
            get { return fs_Time; }
            set { SetPropertyValue("s_Time", ref fs_Time, value); }
        }

        [NonPersistent]
        public string s_TimeDescription
        {
            get { return string.IsNullOrEmpty(fs_Time) ? "立即" : (fs_Time == 0.ToString() ? "到期" : fs_Time + "天"); }
        }

        public DateTime dt_CreateDate
        {
            get { return fdt_CreateDate; }
            set { SetPropertyValue<DateTime>("dt_CreateDate", ref fdt_CreateDate, value); }
        }

        public DateTime dt_EditDate
        {
            get { return fdt_EditDate; }
            set { SetPropertyValue<DateTime>("dt_EditDate", ref fdt_EditDate, value); }
        }

        [Aggregated, Association("RemindInEmployee-Remind", typeof(CodeRemindInEmployee))]
        public XPCollection<CodeRemindInEmployee> RemindInEmployees
        {
            get { return GetCollection<CodeRemindInEmployee>("RemindInEmployees"); }
        }

        [NonPersistent]
        public bool b_Mail
        {
            get { return fb_Mail; }
            set { SetPropertyValue<bool>("b_Mail", ref fb_Mail, value); }
        }

        [NonPersistent]
        public bool b_WeiXin
        {
            get { return fb_WeiXin; }
            set { SetPropertyValue<bool>("b_WeiXin", ref fb_WeiXin, value); }
        }

        public CodeRemind(Session session)
            : base(session)
        {
        }

        public CodeRemind()
            : base(Session.DefaultSession)
        {
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}
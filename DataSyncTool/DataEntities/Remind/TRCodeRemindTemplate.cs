using System;
using DevExpress.Xpo;

namespace DataEntities.Remind
{
    [Persistent("TRCode_RemindTemplate")]
    public class TRCodeRemindTemplate : XPLiteObject
    {
        Guid fg_ID;
        [Key(false)]
        public Guid g_ID
        {
            get { return fg_ID; }
            set { SetPropertyValue<Guid>("g_ID", ref fg_ID, value); }
        }

        string fs_Name;
        [Size(100)]
        public string s_Name
        {
            get { return fs_Name; }
            set { SetPropertyValue<string>("s_Name", ref fs_Name, value); }
        }

        string fs_Title;
        [Size(100)]
        public string s_Title
        {
            get { return fs_Title; }
            set { SetPropertyValue<string>("s_Title", ref fs_Title, value); }
        }

        string fs_Content;
        [Size(SizeAttribute.Unlimited)]
        public string s_Content
        {
            get { return fs_Content; }
            set { SetPropertyValue<string>("s_Content", ref fs_Content, value); }
        }

        string fs_Path;
        [Size(1000)]
        public string s_Path
        {
            get { return fs_Path; }
            set { SetPropertyValue<string>("s_Path", ref fs_Path, value); }
        }

        string fs_Description;
        [Size(1000)]
        public string s_Description
        {
            get { return fs_Description; }
            set { SetPropertyValue<string>("s_Description", ref fs_Description, value); }
        }

        public TRCodeRemindTemplate(Session session) : base(session) { }

        public TRCodeRemindTemplate(Guid guid)
            : this(new UnitOfWork())
        {
            g_ID = guid;
        }
    }
}

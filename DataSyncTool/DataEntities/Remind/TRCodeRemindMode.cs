using System;
using DataEntities.TaskFlowBase;
using DevExpress.Xpo;

namespace DataEntities.Remind
{
    [Persistent("TRCode_RemindMode")]
    public class TRCodeRemindMode : XPLiteObjectUser
    {
        Guid fg_ID;
        [Key(false)]
        public Guid g_ID
        {
            get { return fg_ID; }
            set { SetPropertyValue<Guid>("g_ID", ref fg_ID, value); }
        }

        Guid fg_CodeRemindID;
        public Guid g_CodeRemindID
        {
            get { return fg_CodeRemindID; }
            set { SetPropertyValue<Guid>("g_CodeRemindID", ref fg_CodeRemindID, value); }
        }

        string fs_RemindMode;
        [Size(1)]
        public string s_RemindMode
        {
            get { return fs_RemindMode; }
            set { SetPropertyValue<string>("s_RemindMode", ref fs_RemindMode, value); }
        }


        string fs_RemindObjectType;
        [Size(1)]
        public string s_RemindObjectType
        {
            get { return fs_RemindObjectType; }
            set { SetPropertyValue<string>("s_RemindObjectType", ref fs_RemindObjectType, value); }
        }

        string fs_RemindObjectID;
        [Size(50)]
        public string s_RemindObjectID
        {
            get { return fs_RemindObjectID; }
            set { SetPropertyValue<string>("s_RemindObjectID", ref fs_RemindObjectID, value); }
        }

        Guid? fg_RemindTemplateID;
        public Guid? g_RemindTemplateID
        {
            get { return fg_RemindTemplateID; }
            set { SetPropertyValue<Guid?>("g_RemindTemplateID", ref fg_RemindTemplateID, value); }
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

        public TRCodeRemindMode(Session session) : base(session) { }

        public TRCodeRemindMode(Guid guid)
            : this(new UnitOfWork())
        {
            g_ID = guid;
        }
    }
}

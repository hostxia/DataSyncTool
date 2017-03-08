using System;
using DataEntities.TaskFlowBase;
using DevExpress.Xpo;

namespace DataEntities.Remind
{
    [Persistent("TR_RemindRecord")]
    public class TRRemindRecord : XPLiteObjectUser
    {
        Guid fg_ID;
        [Key(false)]
        public Guid g_ID
        {
            get { return fg_ID; }
            set { SetPropertyValue<Guid>("g_ID", ref fg_ID, value); }
        }

        Guid fg_RemindModeID;
        public Guid g_RemindModeID
        {
            get { return fg_RemindModeID; }
            set { SetPropertyValue<Guid>("g_RemindModeID", ref fg_RemindModeID, value); }
        }

        string fs_RemindMode;
        [Size(1)]
        public string s_RemindMode
        {
            get { return fs_RemindMode; }
            set { SetPropertyValue<string>("s_RemindMode", ref fs_RemindMode, value); }
        }

        int fn_EmployeeID;
        public int n_EmployeeID
        {
            get { return fn_EmployeeID; }
            set { SetPropertyValue<int>("n_EmployeeID", ref fn_EmployeeID, value); }
        }

        string fs_State;
        [Size(1)]
        public string s_State
        {
            get { return fs_State; }
            set { SetPropertyValue<string>("s_State", ref fs_State, value); }
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

        DateTime fdt_StateTime;
        [NullValue(typeof(DateTime), "0001/1/1 0:00:00")]
        public DateTime dt_StateTime
        {
            get { return fdt_StateTime; }
            set { SetPropertyValue<DateTime>("dt_StateTime", ref fdt_StateTime, value); }
        }

        DateTime fdt_CreateTime;
        [NullValue(typeof(DateTime), "0001/1/1 0:00:00")]
        public DateTime dt_CreateTime
        {
            get { return fdt_CreateTime; }
            set { SetPropertyValue<DateTime>("dt_CreateTime", ref fdt_CreateTime, value); }
        }

        string fs_Valid;
        [Size(1)]
        public string s_Valid
        {
            get { return fs_Valid; }
            set { SetPropertyValue<string>("s_Valid", ref fs_Valid, value); }
        }

        /// <summary>
        /// 是否已经加载到消息框
        /// </summary>
        [NonPersistent]
        public bool IsLoadedToBoard { get; set; }

        #region Method

        public TRRemindMode GetTheRemindMode()
        {
            return TheUow.GetObjectByKey<TRRemindMode>(g_RemindModeID);
        }

        #endregion

        public TRRemindRecord(Session session) : base(session) { }

        public TRRemindRecord(Guid guid)
            : this(new UnitOfWork())
        {
            g_ID = guid;
        }
    }
}

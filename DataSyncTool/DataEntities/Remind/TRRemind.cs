using System;
using System.Collections.Generic;
using System.Linq;
using DataEntities.TaskFlowBase;
using DevExpress.Data.Filtering;
using DevExpress.Xpo;

namespace DataEntities.Remind
{
    [Persistent("TR_Remind")]
    public class TRRemind : XPLiteObjectUser
    {
        Guid fg_ID;
        [Key(false)]
        public Guid g_ID
        {
            get { return fg_ID; }
            set { SetPropertyValue<Guid>("g_ID", ref fg_ID, value); }
        }

        Guid? fg_CodeRemindID;
        public Guid? g_CodeRemindID
        {
            get { return fg_CodeRemindID; }
            set { SetPropertyValue<Guid?>("g_CodeRemindID", ref fg_CodeRemindID, value); }
        }

        string fs_TriggerType;
        [Size(50)]
        public string s_TriggerType
        {
            get { return fs_TriggerType; }
            set { SetPropertyValue<string>("s_TriggerType", ref fs_TriggerType, value); }
        }

        string fs_TriggerID;
        [Size(50)]
        public string s_TriggerID
        {
            get { return fs_TriggerID; }
            set { SetPropertyValue<string>("s_TriggerID", ref fs_TriggerID, value); }
        }

        string fs_State;
        [Size(1)]
        public string s_State
        {
            get { return fs_State; }
            set { SetPropertyValue<string>("s_State", ref fs_State, value); }
        }

        int fn_RemindCount;
        public int n_RemindCount
        {
            get { return fn_RemindCount; }
            set { SetPropertyValue<int>("n_RemindCount", ref fn_RemindCount, value); }
        }

        DateTime fdt_RemindDate;
        [NullValue(typeof(DateTime), "0001/1/1 0:00:00")]
        public DateTime dt_RemindDate
        {
            get { return fdt_RemindDate; }
            set { SetPropertyValue<DateTime>("dt_RemindDate", ref fdt_RemindDate, value); }
        }

        string fs_RemindType;
        [Size(1)]
        public string s_RemindType
        {
            get { return fs_RemindType; }
            set { SetPropertyValue<string>("s_RemindType", ref fs_RemindType, value); }
        }

        string fs_RemindPara;
        [Size(200)]
        public string s_RemindPara
        {
            get { return fs_RemindPara; }
            set { SetPropertyValue<string>("s_RemindPara", ref fs_RemindPara, value); }
        }

        int fn_Creator;
        public int n_Creator
        {
            get { return fn_Creator; }
            set { SetPropertyValue<int>("n_Creator", ref fn_Creator, value); }
        }

        public List<TRRemindMode> GetListRemindModes()
        {
            var xpcRemindModes = new XPCollection<TRRemindMode>(TheUow, CriteriaOperator.Parse("g_RemindID = ?", g_ID));
            return xpcRemindModes.ToList();
        }

        string fs_Valid;
        [Size(1)]
        public string s_Valid
        {
            get { return fs_Valid; }
            set { SetPropertyValue<string>("s_Valid", ref fs_Valid, value); }
        }

        //[NonPersistent]
        //public List<TRRemindMode> ListRemindModes { get; set; }

        public TRRemind(Session session) : base(session) { }

        public TRRemind(Guid guid)
            : this(new UnitOfWork())
        {
            g_ID = guid;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using DataEntities.TaskFlowBase;
using DevExpress.Data.Filtering;
using DevExpress.Xpo;

namespace DataEntities.Remind
{
    [Persistent("TRCode_Remind")]
    public class TRCodeRemind : XPLiteObjectUser
    {
        Guid fg_ID;
        [Key(false)]
        public Guid g_ID
        {
            get { return fg_ID; }
            set { SetPropertyValue<Guid>("g_ID", ref fg_ID, value); }
        }

        string fs_TriggerType;
        [Size(50)]
        public string s_TriggerType
        {
            get { return fs_TriggerType; }
            set { SetPropertyValue<string>("s_TriggerType", ref fs_TriggerType, value); }
        }

        string fs_TriggerConfigID;
        [Size(50)]
        public string s_TriggerConfigID
        {
            get { return fs_TriggerConfigID; }
            set { SetPropertyValue<string>("s_TriggerConfigID", ref fs_TriggerConfigID, value); }
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

        string fs_RemindDatePara;
        [Size(200)]
        public string s_RemindDatePara
        {
            get { return fs_RemindDatePara; }
            set { SetPropertyValue<string>("s_RemindDatePara", ref fs_RemindDatePara, value); }
        }

        string fs_Description;
        [Size(1000)]
        public string s_Description
        {
            get { return fs_Description; }
            set { SetPropertyValue<string>("s_Description", ref fs_Description, value); }
        }

        public List<TRCodeRemindMode> GetListCodeRemindModes()
        {
            var xpcCodeRemindModes = new XPCollection<TRCodeRemindMode>(TheUow, CriteriaOperator.Parse("g_CodeRemindID = ?", g_ID));
            return xpcCodeRemindModes.ToList();
        }

        [NonPersistent]
        public List<TRCodeRemindMode> ListCodeRemindModes { get; set; }

        public TRCodeRemind(Session session) : base(session) { }

        public TRCodeRemind(Guid guid) : this(new UnitOfWork())
        {
            g_ID = guid;
        }
    }
}

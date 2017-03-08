using System;
using DevExpress.Xpo;

namespace DataEntities.Case
{
    [Persistent("TCase_StatusHistory")]
    public class StatusHistory : XPLiteObject
    {
        private readonly XPDelayedProperty fdt_StatusChangeDate = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_NewStatus = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_Notes = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_OldStatus = new XPDelayedProperty();
        private BasicCase basicCase;
        private int fn_ID;

        public StatusHistory(Session session) : base(session)
        {
        }

        public StatusHistory() : base(Session.DefaultSession)
        {
        }

        [Key(true)]
        public int n_ID
        {
            get { return fn_ID; }
            set { SetPropertyValue<int>("n_ID", ref fn_ID, value); }
        }

        [Association("Case-StatusHistory")]
        [Persistent("n_CaseID")]
        public BasicCase BasicCase
        {
            get { return basicCase; }
            set { SetPropertyValue("n_CaseID", ref basicCase, value); }
        }

        [Size(50)]
        [Delayed("fs_OldStatus")]
        public string s_OldStatus
        {
            get { return (string) fs_OldStatus.Value; }
            set { fs_OldStatus.Value = value; }
        }

        [Size(50)]
        [Delayed("fs_NewStatus")]
        public string s_NewStatus
        {
            get { return (string) fs_NewStatus.Value; }
            set { fs_NewStatus.Value = value; }
        }

        [Delayed("fdt_StatusChangeDate")]
        public DateTime dt_StatusChangeDate
        {
            get
            {
                if (fdt_StatusChangeDate.Value == null)
                {
                    return DateTime.MinValue;
                }
                return (DateTime) fdt_StatusChangeDate.Value;
            }
            set { fdt_StatusChangeDate.Value = value; }
        }

        [Delayed("fs_Notes")]
        public string s_Notes
        {
            get { return (string) fs_Notes.Value; }
            set { fs_Notes.Value = value; }
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}
using System;
using DevExpress.Xpo;

namespace DataEntities.Case.Trademarks
{
    [Persistent("TTCase_Priority")]
    public class Priority : XPLiteObject
    {
        private readonly XPDelayedProperty fdt_PDate = new XPDelayedProperty();
        private readonly XPDelayedProperty fn_PCountry = new XPDelayedProperty();
        private readonly XPDelayedProperty fn_Sequence = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_PDocProvided = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_PNum = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_PTransDocProvided = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_Priority = new XPDelayedProperty();
        private int fn_ID;
        private string fs_Notes;

        private ExtendedTrademark trademark;

        public Priority(Session session)
            : base(session)
        {
        }

        public Priority()
            : base(Session.DefaultSession)
        {
        }

        [Key(true)]
        public int n_ID
        {
            get { return fn_ID; }
            set { SetPropertyValue<int>("n_ID", ref fn_ID, value); }
        }

        [Association("Trademark-Priorities")]
        [Persistent("n_CaseID")]
        public ExtendedTrademark TheTrademark
        {
            get { return trademark; }
            set { SetPropertyValue("n_CaseID", ref trademark, value); }
        }

        [Delayed("fn_Sequence")]
        public int n_Sequence
        {
            get
            {
                if (fn_Sequence.Value == null)
                {
                    return -1;
                }
                return (int)fn_Sequence.Value;
            }
            set { fn_Sequence.Value = value; }
        }

        [Delayed("fs_Priority")]
        [Size(300)]
        public string s_Priority
        {
            get { return (string)fs_Priority.Value; }
            set { fs_Priority.Value = value; }
        }

        [Delayed("fn_PCountry")]
        public int n_PCountry
        {
            get
            {
                if (fn_PCountry.Value == null)
                {
                    return -1;
                }
                return (int)fn_PCountry.Value;
            }
            set { fn_PCountry.Value = value; }
        }

        [Delayed("fdt_PDate")]
        public DateTime dt_PDate
        {
            get
            {
                if (fdt_PDate.Value == null)
                {
                    return DateTime.MinValue;
                }
                return (DateTime)fdt_PDate.Value;
            }
            set { fdt_PDate.Value = value; }
        }

        [Delayed("fs_PNum")]
        [Size(50)]
        public string s_PNum
        {
            get { return (string)fs_PNum.Value; }
            set { fs_PNum.Value = value; }
        }

        [Delayed("fs_PDocProvided")]
        [Size(1)]
        public string s_PDocProvided
        {
            get { return (string)fs_PDocProvided.Value; }
            set { fs_PDocProvided.Value = value; }
        }

        [Delayed("fs_PTransDocProvided")]
        [Size(1)]
        public string s_PTransDocProvided
        {
            get { return (string)fs_PTransDocProvided.Value; }
            set { fs_PTransDocProvided.Value = value; }
        }

        [Size(1000)]
        public string s_Notes
        {
            get { return fs_Notes; }
            set { SetPropertyValue("s_Notes", ref fs_Notes, value); }
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}
using System;
using DevExpress.Xpo;

namespace DataEntities.Case
{
    [Persistent("TCase_CaseRelative")]
    public class Relative : XPLiteObject
    {
        private readonly XPDelayedProperty fdt_CreateDate = new XPDelayedProperty();
        private readonly XPDelayedProperty fdt_EditDate = new XPDelayedProperty();
        private readonly XPDelayedProperty fn_CaseIDA = new XPDelayedProperty();
        private readonly XPDelayedProperty fn_CaseIDB = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_Notes = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_CaseRelation = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_MasterSlaveRelation = new XPDelayedProperty();
        private readonly XPDelayedProperty fn_CodeRelativeID = new XPDelayedProperty();

        [NonPersistent]
        public int VirturalID;
        private int fn_ID;

        public Relative(Session session)
            : base(session)
        {
        }

        public Relative()
            : base(Session.DefaultSession)
        {
        }

        [Key(true)]
        public int n_ID
        {
            get { return fn_ID; }
            set { SetPropertyValue<int>("n_ID", ref fn_ID, value); }
        }

        [Delayed("fn_CaseIDA")]
        public int n_CaseIDA
        {
            get
            {
                if (fn_CaseIDA.Value == null)
                {
                    return -1;
                }
                return (int)fn_CaseIDA.Value;
            }
            set { fn_CaseIDA.Value = value; }
        }

        [Delayed("fn_CaseIDB")]
        public int n_CaseIDB
        {
            get
            {
                if (fn_CaseIDB.Value == null)
                {
                    return -1;
                }
                return (int)fn_CaseIDB.Value;
            }
            set { fn_CaseIDB.Value = value; }
        }

        [Delayed("fs_Notes")]
        public string s_Notes
        {
            get { return (string)fs_Notes.Value; }
            set { fs_Notes.Value = value; }
        }

        [Delayed("fdt_CreateDate")]
        public DateTime dt_CreateDate
        {
            get
            {
                if (fdt_CreateDate.Value == null)
                {
                    return DateTime.MinValue;
                }
                return (DateTime)fdt_CreateDate.Value;
            }
            set { fdt_CreateDate.Value = value; }
        }

        [Delayed("fdt_EditDate")]
        public DateTime dt_EditDate
        {
            get
            {
                if (fdt_EditDate.Value == null)
                {
                    return DateTime.MinValue;
                }
                return (DateTime)fdt_EditDate.Value;
            }
            set { fdt_EditDate.Value = value; }
        }

        [Delayed("fs_CaseRelation")]
        public string s_CaseRelation
        {
            get { return (string)fs_CaseRelation.Value; }
            set { fs_CaseRelation.Value = value; }
        }

        [Delayed("fs_MasterSlaveRelation")]
        public string s_MasterSlaveRelation
        {
            get { return (string)fs_MasterSlaveRelation.Value; }
            set { fs_MasterSlaveRelation.Value = value; }
        }

        [Delayed("fn_CodeRelativeID")]
        public int n_CodeRelativeID
        {
            get
            {
                if (fn_CodeRelativeID.Value == null)
                {
                    return -1;
                }
                return (int)fn_CodeRelativeID.Value;
            }
            set { fn_CodeRelativeID.Value = value; }
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}
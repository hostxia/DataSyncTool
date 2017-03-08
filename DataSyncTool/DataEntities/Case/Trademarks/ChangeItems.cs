using DevExpress.Xpo;

namespace DataEntities.Case.Trademarks
{
    [Persistent("TTCase_ChangeItems")]
    public class ChangeItem : XPLiteObject
    {
        private readonly XPDelayedProperty fn_ProcessID = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_AfterChg = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_BeforeChg = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_Item = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_Notes = new XPDelayedProperty();
        private int fn_ID;

        private CaseChange trademark;

        public ChangeItem(Session session) : base(session)
        {
        }

        public ChangeItem() : base(Session.DefaultSession)
        {
        }

        [Key(true)]
        public int n_ID
        {
            get { return fn_ID; }
            set { SetPropertyValue<int>("n_ID", ref fn_ID, value); }
        }

        [Association("Trademark-ChangeItems")]
        [Persistent("n_CaseID")]
        public CaseChange TheTrademark
        {
            get { return trademark; }
            set { SetPropertyValue("n_CaseID", ref trademark, value); }
        }

        [Delayed("fs_Item")]
        public string s_Item
        {
            get { return (string) fs_Item.Value; }
            set { fs_Item.Value = value; }
        }

        [Delayed("fn_ProcessID")]
        public int n_ProcessID
        {
            get
            {
                if (fn_ProcessID.Value == null) return -1;
                return (int) fn_ProcessID.Value;
            }
            set { fn_ProcessID.Value = value; }
        }

        [Delayed("fs_BeforeChg")]
        [Size(300)]
        public string s_BeforeChg
        {
            get { return (string) fs_BeforeChg.Value; }
            set { fs_BeforeChg.Value = value; }
        }

        [Delayed("fs_AfterChg")]
        [Size(300)]
        public string s_AfterChg
        {
            get { return (string) fs_AfterChg.Value; }
            set { fs_AfterChg.Value = value; }
        }

        [Delayed("fs_Notes")]
        [Size(800)]
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
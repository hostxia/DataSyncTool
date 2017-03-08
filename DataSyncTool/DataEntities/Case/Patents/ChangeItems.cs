using DevExpress.Xpo;

namespace DataEntities.Case.Patents
{
    [Persistent("TPCase_ChangeItems")]
    public class ChangeItems : XPLiteObject
    {
        private CaseChange fn_CaseID;
        private int fn_ID;
        private int fn_ProcessID;
        private string fs_AfterChg;
        private string fs_BeforeChg;
        private string fs_Item;
        private string fs_Notes;

        public ChangeItems(Session session) : base(session)
        {
        }

        public ChangeItems() : base(Session.DefaultSession)
        {
        }

        [Key(true)]
        public int n_ID
        {
            get { return fn_ID; }
            set { SetPropertyValue<int>("n_ID", ref fn_ID, value); }
        }

        [Association("CaseChange-ChangeItems")]
        [Persistent("n_CaseID")]
        public CaseChange ThePatent
        {
            get { return fn_CaseID; }
            set { SetPropertyValue("n_CaseID", ref fn_CaseID, value); }
        }

        public int n_ProcessID
        {
            get { return fn_ProcessID; }
            set { SetPropertyValue<int>("n_ProcessID", ref fn_ProcessID, value); }
        }

        public string s_Item
        {
            get { return fs_Item; }
            set { SetPropertyValue("s_Item", ref fs_Item, value); }
        }

        [Size(300)]
        public string s_BeforeChg
        {
            get { return fs_BeforeChg; }
            set { SetPropertyValue("s_BeforeChg", ref fs_BeforeChg, value); }
        }

        [Size(300)]
        public string s_AfterChg
        {
            get { return fs_AfterChg; }
            set { SetPropertyValue("s_AfterChg", ref fs_AfterChg, value); }
        }

        [Size(800)]
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
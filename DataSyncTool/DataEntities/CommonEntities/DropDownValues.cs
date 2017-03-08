using DevExpress.Xpo;

namespace DataEntities.CommonEntities
{
    [Persistent("TCode_DropDownValues")]
    public class DropDownValue : XPLiteObject
    {
        private DropDownList fn_CtrID;
        private int fn_ID;
        private int fn_Sequence;
        private string fs_CtrlValue;
        private string fs_IsSystem;

        public DropDownValue(Session session) : base(session)
        {
        }

        public DropDownValue() : base(Session.DefaultSession)
        {
        }

        [Key(true)]
        public int n_ID
        {
            get { return fn_ID; }
            set { SetPropertyValue<int>("n_ID", ref fn_ID, value); }
        }

        [Association("DropDownList-EditValues")]
        [Persistent("n_CtrID")]
        public DropDownList DropDownList
        {
            get { return fn_CtrID; }
            set { SetPropertyValue("n_CtrID", ref fn_CtrID, value); }
        }

        [Size(500)]
        public string s_CtrlValue
        {
            get { return fs_CtrlValue; }
            set { SetPropertyValue("s_CtrlValue", ref fs_CtrlValue, value); }
        }

        [Size(100)]
        public string s_IsSystem
        {
            get { return fs_IsSystem; }
            set { SetPropertyValue("s_IsSystem", ref fs_IsSystem, value); }
        }

        public int n_Sequence
        {
            get { return fn_Sequence; }
            set { SetPropertyValue<int>("n_Sequence", ref fn_Sequence, value); }
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}
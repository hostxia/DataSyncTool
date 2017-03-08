using DevExpress.Xpo;

namespace DataEntities.CommonEntities
{
    [Persistent("TCode_DropDownList")]
    public class DropDownList : XPLiteObject
    {
        private int fn_ID;

        private string fs_Name;

        public DropDownList(Session session) : base(session)
        {
        }

        public DropDownList() : base(Session.DefaultSession)
        {
        }

        [Key(true)]
        public int n_ID
        {
            get { return fn_ID; }
            set { SetPropertyValue<int>("n_ID", ref fn_ID, value); }
        }

        [Size(50)]
        public string s_Name
        {
            get { return fs_Name; }
            set { SetPropertyValue("s_Name", ref fs_Name, value); }
        }

        [Aggregated, Association("DropDownList-EditValues", typeof (DropDownValue))]
        public XPCollection EditValues
        {
            get { return GetCollection("EditValues"); }
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}
using DevExpress.Xpo;

namespace DataEntities.Case.Trademarks
{
    [Persistent("TTCase_Group")]
    public class Group : XPLiteObject
    {
        private readonly XPDelayedProperty fs_Notes = new XPDelayedProperty();
        private int fn_GroupID;

        public Group(Session session) : base(session)
        {
        }

        public Group() : base(Session.DefaultSession)
        {
        }

        [Key(true)]
        public int n_GroupID
        {
            get { return fn_GroupID; }
            set { SetPropertyValue<int>("n_GroupID", ref fn_GroupID, value); }
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
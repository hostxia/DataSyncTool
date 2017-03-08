using DevExpress.Xpo;

namespace DataEntities.ConfigOrganization
{
    [Persistent("TCode_User")]
    public class CodeUser : XPLiteObject
    {
        int fn_ID;
        [Key(true)]
        public int n_ID
        {
            get { return fn_ID; }
            set { SetPropertyValue<int>("n_ID", ref fn_ID, value); }
        }

        string fs_Name;
        [Size(100)]
        public string s_Name
        {
            get { return fs_Name; }
            set { SetPropertyValue<string>("s_Name", ref fs_Name, value); }
        }

        public CodeUser(Session session) : base(session) { } 
    }
}
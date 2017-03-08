using DevExpress.Xpo;

namespace DataEntities.Statistic
{
    [Persistent("T_QueryInFolder")]
    public class QueryInFolder : XPLiteObject
    {
        private int fn_ID;
        private string fs_Name;
        private int fn_ParentID;
        private string fs_Type;
        private CodeQuery codeQuery;

        [Key(true)]
        public int n_ID
        {
            get { return fn_ID; }
            set { SetPropertyValue<int>("n_ID", ref fn_ID, value); }
        }

        [Size(100)]
        public string s_Name
        {
            get { return fs_Name; }
            set { SetPropertyValue("s_Name", ref fs_Name, value); }
        }

        public int n_ParentID
        {
            get { return fn_ParentID; }
            set { SetPropertyValue<int>("n_ParentID", ref fn_ParentID, value); }
        }

        [Size(1)]
        public string s_Type
        {
            get { return fs_Type; }
            set { SetPropertyValue("s_Type", ref fs_Type, value); }
        }

        [Association("CodeQuery-QueryInFolders")]
        [Persistent("n_CodeQueryID")]
        public CodeQuery TheCodeQuery
        {
            get { return codeQuery; }
            set { SetPropertyValue("n_CodeQueryID", ref codeQuery, value); }
        }

        public QueryInFolder(Session session)
            : base(session)
        {
        }

        public QueryInFolder()
            : base(Session.DefaultSession)
        {
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}
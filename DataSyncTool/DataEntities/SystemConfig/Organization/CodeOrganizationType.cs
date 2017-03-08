using DevExpress.Xpo;

namespace DataEntities.ConfigOrganization
{
    [Persistent("TCode_OrganizationType")]
    public class CodeOrganizationType : XPLiteObject
    {
        int fn_ID;
        [Key(true)]
        public int n_ID
        {
            get { return fn_ID; }
            set { SetPropertyValue<int>("n_ID", ref fn_ID, value); }
        }

        int fn_Sequence;
        public int n_Sequence
        {
            get { return fn_Sequence; }
            set { SetPropertyValue<int>("n_Sequence", ref fn_Sequence, value); }
        }

        string fs_Name;
        [Size(100)]
        public string s_Name
        {
            get { return fs_Name; }
            set { SetPropertyValue<string>("s_Name", ref fs_Name, value); }
        }

        string fs_RelatedObjectType;
        [Size(50)]
        public string s_RelatedObjectType
        {
            get { return fs_RelatedObjectType; }
            set { SetPropertyValue<string>("s_RelatedObjectType", ref fs_RelatedObjectType, value); }
        }

        string fs_Description;
        [Size(1000)]
        public string s_Description
        {
            get { return fs_Description; }
            set { SetPropertyValue<string>("s_Description", ref fs_Description, value); }
        }

        public CodeOrganizationType(Session session) : base(session) { }
    }
}
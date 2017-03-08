using DevExpress.Xpo;

namespace DataEntities.ConfigOrganization
{
    [Persistent("TCode_UserInOrganization")]
    public class CodeUserInOrganization : XPLiteObject
    {
        int fn_ID;
        [Key(true)]
        public int n_ID
        {
            get { return fn_ID; }
            set { SetPropertyValue<int>("n_ID", ref fn_ID, value); }
        }

        int fn_UserID;
        public int n_UserID
        {
            get { return fn_UserID; }
            set { SetPropertyValue<int>("n_UserID", ref fn_UserID, value); }
        }

        int fn_OrganizationID;
        public int n_OrganizationID
        {
            get { return fn_OrganizationID; }
            set { SetPropertyValue<int>("n_OrganizationID", ref fn_OrganizationID, value); }
        }

        public CodeUserInOrganization(Session session) : base(session) { } 
    }
}
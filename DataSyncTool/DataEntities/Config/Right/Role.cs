using DataEntities.Contact.Client;
using DataEntities.Statistic;
using DevExpress.Xpo;

namespace DataEntities.Config.Right
{
    [Persistent("T_Role")]
    public class Role : XPLiteObject
    {
        private int fn_RoleID;
        private string fs_Notes;
        private string fs_RoleCode;

        private string fs_RoleName;

        public Role(Session session) : base(session)
        {
        }

        public Role() : base(Session.DefaultSession)
        {
        }

        [Key(true)]
        public int n_RoleID
        {
            get { return fn_RoleID; }
            set { SetPropertyValue<int>("n_RoleID", ref fn_RoleID, value); }
        }

        [Size(50)]
        public string s_RoleName
        {
            get { return fs_RoleName; }
            set { SetPropertyValue("s_RoleName", ref fs_RoleName, value); }
        }

        [Size(500)]
        public string s_Notes
        {
            get { return fs_Notes; }
            set { SetPropertyValue("s_Notes", ref fs_Notes, value); }
        }

        [Size(50)]
        public string s_RoleCode
        {
            get { return fs_RoleCode; }
            set { SetPropertyValue("s_RoleCode", ref fs_RoleCode, value); }
        }

        [Aggregated, Association("Role-RoleRights", typeof (RoleRights))]
        public XPCollection RoleRights
        {
            get { return GetCollection("RoleRights"); }
        }

        [Aggregated, Association("Role-UserRoles", typeof (UserRoles))]
        public XPCollection<UserRoles> UserRoles
        {
            get { return GetCollection<UserRoles>("UserRoles"); }
        }

        [Aggregated, Association("Role-RoleClients", typeof (RoleClient))]
        public XPCollection RoleClients
        {
            get { return GetCollection("RoleClients"); }
        }

        [Aggregated, Association("Role-RoleQuerys")]
        public XPCollection<RoleQuery> RoleQuerys
        {
            get { return GetCollection<RoleQuery>("RoleQuerys"); }
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}
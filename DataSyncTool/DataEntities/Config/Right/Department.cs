using DataEntities.Case;
using DevExpress.Xpo;

namespace DataEntities.Config.Right
{
    [Persistent("T_Department")]
    public class Department : XPLiteObject
    {
        private int fn_ID;
        private string fs_DataRight;
        private string fs_Description;

        private string fs_Name;

        public Department(Session session) : base(session)
        {
        }

        public Department() : base(Session.DefaultSession)
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

        [Size(500)]
        public string s_Description
        {
            get { return fs_Description; }
            set { SetPropertyValue("s_Description", ref fs_Description, value); }
        }

        public string s_DataRight
        {
            get { return fs_DataRight; }
            set { SetPropertyValue("s_DataRight", ref fs_DataRight, value); }
        }

        [Aggregated, Association("Department-UserDepartments", typeof (UserDepartment))]
        public XPCollection UserDepartments
        {
            get { return GetCollection("UserDepartments"); }
        }

        [Aggregated, Association("Department-CaseDepartments", typeof (CaseDepartment))]
        public XPCollection CaseDepartments
        {
            get { return GetCollection("CaseDepartments"); }
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}
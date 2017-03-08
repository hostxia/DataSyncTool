using DevExpress.Xpo;

namespace DataEntities.ConfigOrganization
{
    [Persistent("TCode_OrganizationCommon")]
    public class CodeOrganizationCommon : XPLiteObject
    {
        int fn_ID;
        [Key(true)]
        public int n_ID
        {
            get { return fn_ID; }
            set { SetPropertyValue<int>("n_ID", ref fn_ID, value); }
        }

        string fs_Phone;
        [Size(50)]
        public string s_Phone
        {
            get { return fs_Phone; }
            set { SetPropertyValue<string>("s_Phone", ref fs_Phone, value); }
        }

        string fs_InternalPhone;
        [Size(50)]
        public string s_InternalPhone
        {
            get { return fs_InternalPhone; }
            set { SetPropertyValue<string>("s_InternalPhone", ref fs_InternalPhone, value); }
        }

        string fs_Fax;
        [Size(50)]
        public string s_Fax
        {
            get { return fs_Fax; }
            set { SetPropertyValue<string>("s_Fax", ref fs_Fax, value); }
        }

        string fs_ZipCode;
        [Size(50)]
        public string s_ZipCode
        {
            get { return fs_ZipCode; }
            set { SetPropertyValue<string>("s_ZipCode", ref fs_ZipCode, value); }
        }

        string fs_Address;
        [Size(50)]
        public string s_Address
        {
            get { return fs_Address; }
            set { SetPropertyValue<string>("s_Address", ref fs_Address, value); }
        }

        public CodeOrganizationCommon(Session session) : base(session) { }
    }
}
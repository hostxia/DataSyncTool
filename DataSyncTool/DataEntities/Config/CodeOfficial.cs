using System;
using DevExpress.Xpo;

namespace DataEntities.Config
{
    [Persistent("TCode_Official")]
    public class CodeOfficial : XPLiteObject
    {
        private DateTime fdt_CreateDate;
        private DateTime fdt_EditDate;
        private int fn_Country;
        private int fn_ID;
        private int fn_Language;
        private string fs_Charger;
        private string fs_ChargerEmail;
        private string fs_ChargerPhone;
        private string fs_City;
        private string fs_Email;
        private string fs_Fax;

        private string fs_IPType;
        private string fs_IsSystem;
        private string fs_Name;
        private string fs_Notes;

        private string fs_OfficialCode;
        private string fs_OtherName;
        private string fs_Phone;
        private string fs_State;
        private string fs_Street;
        private string fs_Website;
        private string fs_ZipCode;

        public CodeOfficial(Session session) : base(session)
        {
        }

        public CodeOfficial() : base(Session.DefaultSession)
        {
        }

        [Key(true)]
        public int n_ID
        {
            get { return fn_ID; }
            set { SetPropertyValue<int>("n_ID", ref fn_ID, value); }
        }

        [Size(50)]
        public string s_IPType
        {
            get { return fs_IPType; }
            set { SetPropertyValue("s_IPType", ref fs_IPType, value); }
        }

        [Size(40)]
        public string s_OfficialCode
        {
            get { return fs_OfficialCode; }
            set { SetPropertyValue("s_OfficialCode", ref fs_OfficialCode, value); }
        }

        [Size(200)]
        public string s_Name
        {
            get { return fs_Name; }
            set { SetPropertyValue("s_Name", ref fs_Name, value); }
        }

        [Size(200)]
        public string s_OtherName
        {
            get { return fs_OtherName; }
            set { SetPropertyValue("s_OtherName", ref fs_OtherName, value); }
        }

        public int n_Language
        {
            get { return fn_Language; }
            set { SetPropertyValue<int>("n_Language", ref fn_Language, value); }
        }

        [Size(150)]
        public string s_Phone
        {
            get { return fs_Phone; }
            set { SetPropertyValue("s_Phone", ref fs_Phone, value); }
        }

        [Size(150)]
        public string s_Fax
        {
            get { return fs_Fax; }
            set { SetPropertyValue("s_Fax", ref fs_Fax, value); }
        }

        [Size(300)]
        public string s_Email
        {
            get { return fs_Email; }
            set { SetPropertyValue("s_Email", ref fs_Email, value); }
        }

        [Size(300)]
        public string s_Website
        {
            get { return fs_Website; }
            set { SetPropertyValue("s_Website", ref fs_Website, value); }
        }

        public int n_Country
        {
            get { return fn_Country; }
            set { SetPropertyValue<int>("n_Country", ref fn_Country, value); }
        }

        public string s_State
        {
            get { return fs_State; }
            set { SetPropertyValue("s_State", ref fs_State, value); }
        }

        public string s_City
        {
            get { return fs_City; }
            set { SetPropertyValue("s_City", ref fs_City, value); }
        }

        [Size(300)]
        public string s_Street
        {
            get { return fs_Street; }
            set { SetPropertyValue("s_Street", ref fs_Street, value); }
        }

        [Size(50)]
        public string s_ZipCode
        {
            get { return fs_ZipCode; }
            set { SetPropertyValue("s_ZipCode", ref fs_ZipCode, value); }
        }

        [Size(800)]
        public string s_Notes
        {
            get { return fs_Notes; }
            set { SetPropertyValue("s_Notes", ref fs_Notes, value); }
        }

        [Size(1)]
        public string s_IsSystem
        {
            get { return fs_IsSystem; }
            set { SetPropertyValue("s_IsSystem", ref fs_IsSystem, value); }
        }

        public DateTime dt_CreateDate
        {
            get { return fdt_CreateDate; }
            set { SetPropertyValue<DateTime>("dt_CreateDate", ref fdt_CreateDate, value); }
        }

        public DateTime dt_EditDate
        {
            get { return fdt_EditDate; }
            set { SetPropertyValue<DateTime>("dt_EditDate", ref fdt_EditDate, value); }
        }

        [Size(50)]
        public string s_Charger
        {
            get { return fs_Charger; }
            set { SetPropertyValue("s_Charger", ref fs_Charger, value); }
        }

        [Size(50)]
        public string s_ChargerPhone
        {
            get { return fs_ChargerPhone; }
            set { SetPropertyValue("s_ChargerPhone", ref fs_ChargerPhone, value); }
        }

        [Size(50)]
        public string s_ChargerEmail
        {
            get { return fs_ChargerEmail; }
            set { SetPropertyValue("s_ChargerEmail", ref fs_ChargerEmail, value); }
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}
using System;
using DevExpress.Xpo;

namespace DataEntities.Contact.CommContact
{
    [Persistent("TCstmr_CommContact")]
    public class CommContact : XPLiteObject
    {
        private readonly XPDelayedProperty fdt_CreateDate = new XPDelayedProperty();
        private readonly XPDelayedProperty fdt_EditDate = new XPDelayedProperty();
        private readonly XPDelayedProperty fn_CountryID = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_Addr = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_City = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_Creator = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_Editor = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_Email = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_Fax = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_Lock = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_Locker = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_Name = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_Note = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_Province = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_Public = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_Tel = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_WebSite = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_ZipCode = new XPDelayedProperty();
        private int fn_ContactID;

        public CommContact(Session session) : base(session)
        {
        }

        public CommContact() : base(Session.DefaultSession)
        {
        }

        [Key(true)]
        public int n_ContactID
        {
            get { return fn_ContactID; }
            set { SetPropertyValue<int>("n_ContactID", ref fn_ContactID, value); }
        }

        [Delayed("fs_Name")]
        [Size(200)]
        public string s_Name
        {
            get { return (string) fs_Name.Value; }
            set { fs_Name.Value = value; }
        }

        [Delayed("fn_CountryID")]
        public int n_CountryID
        {
            get { return (int) fn_CountryID.Value; }
            set { fn_CountryID.Value = value; }
        }

        [Delayed("fs_Province")]
        [Size(50)]
        public string s_Province
        {
            get { return (string) fs_Province.Value; }
            set { fs_Province.Value = value; }
        }

        [Delayed("fs_City")]
        [Size(50)]
        public string s_City
        {
            get { return (string) fs_City.Value; }
            set { fs_City.Value = value; }
        }

        [Delayed("fs_Tel")]
        [Size(150)]
        public string s_Tel
        {
            get { return (string) fs_Tel.Value; }
            set { fs_Tel.Value = value; }
        }

        [Delayed("fs_Fax")]
        [Size(150)]
        public string s_Fax
        {
            get { return (string) fs_Fax.Value; }
            set { fs_Fax.Value = value; }
        }

        [Delayed("fs_Email")]
        [Size(300)]
        public string s_Email
        {
            get { return (string) fs_Email.Value; }
            set { fs_Email.Value = value; }
        }

        [Delayed("fs_WebSite")]
        [Size(300)]
        public string s_WebSite
        {
            get { return (string) fs_WebSite.Value; }
            set { fs_WebSite.Value = value; }
        }

        [Delayed("fs_ZipCode")]
        [Size(20)]
        public string s_ZipCode
        {
            get { return (string) fs_ZipCode.Value; }
            set { fs_ZipCode.Value = value; }
        }

        [Delayed("fs_Addr")]
        [Size(500)]
        public string s_Addr
        {
            get { return (string) fs_Addr.Value; }
            set { fs_Addr.Value = value; }
        }

        [Delayed("fs_Note")]
        [Size(500)]
        public string s_Note
        {
            get { return (string) fs_Note.Value; }
            set { fs_Note.Value = value; }
        }

        [Delayed("fs_Public")]
        [Size(1)]
        public string s_Public
        {
            get { return (string) fs_Public.Value; }
            set { fs_Public.Value = value; }
        }

        [Delayed("fdt_CreateDate")]
        public DateTime dt_CreateDate
        {
            get
            {
                if (fdt_CreateDate.Value == null)
                {
                    return DateTime.MinValue;
                }
                return (DateTime) fdt_CreateDate.Value;
            }
            set { fdt_CreateDate.Value = value; }
        }

        [Delayed("fs_Creator")]
        [Size(50)]
        public string s_Creator
        {
            get { return (string) fs_Creator.Value; }
            set { fs_Creator.Value = value; }
        }

        [Delayed("fdt_EditDate")]
        public DateTime dt_EditDate
        {
            get
            {
                if (fdt_EditDate.Value == null)
                {
                    return DateTime.MinValue;
                }
                return (DateTime) fdt_EditDate.Value;
            }
            set { fdt_EditDate.Value = value; }
        }

        [Delayed("fs_Editor")]
        [Size(50)]
        public string s_Editor
        {
            get { return (string) fs_Editor.Value; }
            set { fs_Editor.Value = value; }
        }

        [Delayed("fs_Lock")]
        [Size(1)]
        public string s_Lock
        {
            get { return (string) fs_Lock.Value; }
            set { fs_Lock.Value = value; }
        }

        [Delayed("fs_Locker")]
        [Size(50)]
        public string s_Locker
        {
            get { return (string) fs_Locker.Value; }
            set { fs_Locker.Value = value; }
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}
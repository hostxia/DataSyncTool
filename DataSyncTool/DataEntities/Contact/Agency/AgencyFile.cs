using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.Xpo;

namespace DataEntities.Contact.Agency
{
    [Persistent("TCstmr_AgencyFile")]
    public class AgencyFile : XPLiteObject
    {
         private Agency agency;
        private DateTime fdt_CreateDate;
        private DateTime fdt_EditDate;
        private int fn_ID;
        private string fs_Description;
        private string fs_FilePath;
        private string fs_Name;

        public AgencyFile(Session session) : base(session)
        {
        }

        public AgencyFile()
            : base(Session.DefaultSession)
        {
        }

        [Key(true)]
        public int n_ID
        {
            get { return fn_ID; }
            set { SetPropertyValue<int>("n_ID", ref fn_ID, value); }
        }

        [Persistent("n_AgencyID")]
        [Association("Agency-Files")]
        public Agency TheAgency
        {
            get { return agency; }
            set { SetPropertyValue("n_AgencyID", ref agency, value); }
        }

        [Size(200)]
        public string s_Name
        {
            get { return fs_Name; }
            set { SetPropertyValue("s_Name", ref fs_Name, value); }
        }

        [Size(800)]
        public string s_Description
        {
            get { return fs_Description; }
            set { SetPropertyValue("s_Description", ref fs_Description, value); }
        }

        [Size(500)]
        public string s_FilePath
        {
            get { return fs_FilePath; }
            set { SetPropertyValue("s_FilePath", ref fs_FilePath, value); }
        }

        public DateTime dt_EditDate
        {
            get { return fdt_EditDate; }
            set { SetPropertyValue<DateTime>("dt_EditDate", ref fdt_EditDate, value); }
        }

        public DateTime dt_CreateDate
        {
            get { return fdt_CreateDate; }
            set { SetPropertyValue<DateTime>("dt_CreateDate", ref fdt_CreateDate, value); }
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}

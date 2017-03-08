using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.Xpo;

namespace DataEntities.Config
{
    [Persistent("TCode_UserSelectEmail")]
    public class CodeUserSelectEmail : XPLiteObject
    {
        private int fn_ID;
        private string fs_Name;
        private string fs_Email;
        private int fn_CurrentEmployeeID;
        private CodeEmployee fCodeEmployee;

        private string fs_Default;
        private int fn_EmailId;
        [Key(true)]

        public int n_ID
        {
            get { return fn_ID; }
            set { SetPropertyValue<int>("n_ID", ref fn_ID, value); }

        }
        public string s_Email
        {
            get { return fs_Email; }
            set { SetPropertyValue("s_Email", ref fs_Email, value); }
        }

        [Size(50)]
        public string s_Name
        {
            get { return fs_Name; }
            set { SetPropertyValue("s_Name", ref fs_Name, value); }
        }

        //public int n_CurrentEmployeeID
        //{
        //    get { return fn_CurrentEmployeeID; }
        //    set { SetPropertyValue<int>("n_CurrentEmployeeID", ref fn_CurrentEmployeeID, value); }

        //}
        [Association("User-SelectEmail")]
        [Persistent("n_CodeEmployeelID")]
        public CodeEmployee TheCodeEmployee
        {
            get { return fCodeEmployee; }
            set { SetPropertyValue("n_CodeEmployeelID", ref fCodeEmployee, value); }

        }

        public string s_Default
        {
            get { return fs_Default; }
            set { SetPropertyValue("s_Default", ref fs_Default, value); }
        }

        [NonPersistent]
        public string s_DefaultDisplay
        {
            get { return fs_Default == "Y" ? "True" : "False"; }
        }

        public int n_EmailId
        {
            get { return fn_EmailId; }
            set { SetPropertyValue<int>("s_EmailId", ref fn_EmailId, value); }

        }

        public CodeUserSelectEmail(Session session) : base(session) { }
        public CodeUserSelectEmail() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); } 
    }
}

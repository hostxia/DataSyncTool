using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.Xpo;

namespace DataEntities.Config
{
    [Persistent("TCode_CaseRoleAssignRule")]
    public class CodeCaseRoleAssignRule : XPLiteObject
    {
        private int fn_ID;
        [Key(true)]
        public int n_ID
        {
            get { return fn_ID; }
            set { SetPropertyValue<int>("n_ID", ref fn_ID, value); }
        }

        private CodeCaseRole caseRole;
        [Persistent("n_CodeCaseRoleID"), Association("CaseRole-CaseRoleAssignRule")]
        public CodeCaseRole TheCodeCaseRole
        {
            get { return caseRole; }
            set { SetPropertyValue("n_CodeCaseRoleID", ref caseRole, value); }
        }

        string fs_AssignRule;
        [Size(50)]
        public string s_AssignRule
        {
            get { return fs_AssignRule; }
            set { SetPropertyValue<string>("s_AssignRule", ref fs_AssignRule, value); }
        }

        private CodeEmployee employee;
        [Persistent("n_EmployeeID"), Association("Employee-CaseRoleAssignRule")]
        public CodeEmployee TheEmployee
        {
            get { return employee; }
            set { SetPropertyValue("n_EmployeeID", ref employee, value); }
        }

        public CodeCaseRoleAssignRule(Session session) : base(session) { }
        public CodeCaseRoleAssignRule() : base(Session.DefaultSession) { }
    }
}

using System;
using DataEntities.Config;
using DevExpress.Xpo;

namespace DataEntities.Case
{
    [Persistent("TCase_Attorney")]
    public class CaseAttorney : XPLiteObject
    {
        private BasicCase basicCase;
        private CodeEmployee codeEmployee;
        private DateTime fdt_AssignDate;
        private int fn_AssignorID;
        private int fn_ID;
        private int fn_Sequence;

        public CaseAttorney(Session session)
            : base(session)
        {
        }

        public CaseAttorney()
            : base(Session.DefaultSession)
        {
        }

        [Key(true)]
        public int n_ID
        {
            get { return fn_ID; }
            set { SetPropertyValue<int>("n_ID", ref fn_ID, value); }
        }

        [Association("Case-CaseAttorney")]
        [Persistent("n_CaseID")]
        public BasicCase TheCase
        {
            get { return basicCase; }
            set { SetPropertyValue("n_CaseID", ref basicCase, value); }
        }

        //int fn_CaseID;
        //public int n_CaseID
        //{
        //    get { return fn_CaseID; }
        //    set { SetPropertyValue<int>("n_CaseID", ref fn_CaseID, value); }
        //}

        public int n_Sequence
        {
            get { return fn_Sequence; }
            set { SetPropertyValue<int>("n_Sequence", ref fn_Sequence, value); }
        }

        [Association("Employee-CaseAttorney")]
        [Persistent("n_AttorneyID")]
        public CodeEmployee TheAttorney
        {
            get { return codeEmployee; }
            set { SetPropertyValue("n_AttorneyID", ref codeEmployee, value); }
        }

        //int fn_AttorneyID;
        //public int n_AttorneyID
        //{
        //    get { return fn_AttorneyID; }
        //    set { SetPropertyValue<int>("n_AttorneyID", ref fn_AttorneyID, value); }
        //}

        public DateTime dt_AssignDate
        {
            get { return fdt_AssignDate; }
            set { SetPropertyValue<DateTime>("dt_AssignDate", ref fdt_AssignDate, value); }
        }

        public int n_AssignorID
        {
            get { return fn_AssignorID; }
            set { SetPropertyValue<int>("n_AssignorID", ref fn_AssignorID, value); }
        }

        private int fn_CaseRoleID;
        public int n_CaseRoleID
        {
            get { return fn_CaseRoleID; }
            set { SetPropertyValue<int>("n_CaseRoleID", ref fn_CaseRoleID, value); }
        }
        private int fnAttorneyID;
        [NonPersistent]
        public int nAttorneyID
        {
            get { return TheAttorney == null ? fnAttorneyID : TheAttorney.n_ID; }
            set { fnAttorneyID = value; }
        }

        [NonPersistent]
        public int newCycleEEId { get; set; }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}
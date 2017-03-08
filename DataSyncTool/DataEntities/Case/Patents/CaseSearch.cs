using System;
using DevExpress.Xpo;

namespace DataEntities.Case.Patents
{
    [MapInheritance(MapInheritanceType.OwnTable)]
    [Persistent("TPCase_SearchInfo")]
    public class CaseSearch : ExtendedPatent
    {
        //int fn_ID;
        //[Key(true)]
        //public int n_ID
        //{
        //    get { return fn_ID; }
        //    set { SetPropertyValue<int>("n_ID", ref fn_ID, value); }
        //}
        //Patent fn_CaseID;
        //[Association("Patent-SearchInfo")]
        //[Persistent("n_CaseID")]
        //public Patent Patent
        //{
        //    get { return fn_CaseID; }
        //    set { SetPropertyValue<Patent>("n_CaseID", ref fn_CaseID, value); }
        //}

        private DateTime fdt_AppDate;
        private DateTime fdt_FulFillDate;
        private string fs_Aim;
        private string fs_AppNumber;
        private string fs_Applicant;
        private string fs_Notes;
        private string fs_PatentName;
        private string fs_Property;
        private string fs_ReqDesc;
        private string fs_Result;
        private string fs_SearchAppDate;
        private string fs_SearchAppNumber;
        private string fs_SearchApplicant;
        private string fs_SearchPatentName;
        private string fs_SearchType;
        private string fs_SearchTypeCode;

        public CaseSearch(Session session) : base(session)
        {
        }

        public CaseSearch() : base(Session.DefaultSession)
        {
        }

        [Size(50)]
        public string s_Property
        {
            get { return fs_Property; }
            set { SetPropertyValue("s_Property", ref fs_Property, value); }
        }

        [Size(200)]
        public string s_Aim
        {
            get { return fs_Aim; }
            set { SetPropertyValue("s_Aim", ref fs_Aim, value); }
        }

        [Size(50)]
        public string s_SearchType
        {
            get { return fs_SearchType; }
            set { SetPropertyValue("s_SearchType", ref fs_SearchType, value); }
        }

        [Size(10)]
        public string s_SearchTypeCode
        {
            get { return fs_SearchTypeCode; }
            set { SetPropertyValue("s_SearchTypeCode", ref fs_SearchTypeCode, value); }
        }

        [Size(500)]
        public string s_ReqDesc
        {
            get { return fs_ReqDesc; }
            set { SetPropertyValue("s_ReqDesc", ref fs_ReqDesc, value); }
        }

        [Size(1)]
        public string s_SearchAppNumber
        {
            get { return fs_SearchAppNumber; }
            set { SetPropertyValue("s_SearchAppNumber", ref fs_SearchAppNumber, value); }
        }

        [Size(50)]
        public string s_AppNumber
        {
            get { return fs_AppNumber; }
            set { SetPropertyValue("s_AppNumber", ref fs_AppNumber, value); }
        }

        [Size(1)]
        public string s_SearchAppDate
        {
            get { return fs_SearchAppDate; }
            set { SetPropertyValue("s_SearchAppDate", ref fs_SearchAppDate, value); }
        }

        public DateTime dt_AppDate
        {
            get { return fdt_AppDate; }
            set { SetPropertyValue<DateTime>("dt_AppDate", ref fdt_AppDate, value); }
        }

        [Size(1)]
        public string s_SearchApplicant
        {
            get { return fs_SearchApplicant; }
            set { SetPropertyValue("s_SearchApplicant", ref fs_SearchApplicant, value); }
        }

        [Size(300)]
        public string s_Applicant
        {
            get { return fs_Applicant; }
            set { SetPropertyValue("s_Applicant", ref fs_Applicant, value); }
        }

        [Size(1)]
        public string s_SearchPatentName
        {
            get { return fs_SearchPatentName; }
            set { SetPropertyValue("s_SearchPatentName", ref fs_SearchPatentName, value); }
        }

        [Size(300)]
        public string s_PatentName
        {
            get { return fs_PatentName; }
            set { SetPropertyValue("s_PatentName", ref fs_PatentName, value); }
        }

        [Size(500)]
        public string s_Result
        {
            get { return fs_Result; }
            set { SetPropertyValue("s_Result", ref fs_Result, value); }
        }

        public DateTime dt_FulFillDate
        {
            get { return fdt_FulFillDate; }
            set { SetPropertyValue<DateTime>("dt_FulFillDate", ref fdt_FulFillDate, value); }
        }

        [Size(800)]
        public string s_SearchNotes
        {
            get { return fs_Notes; }
            set { SetPropertyValue("s_Notes", ref fs_Notes, value); }
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}
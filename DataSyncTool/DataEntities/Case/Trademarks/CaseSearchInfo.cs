using System;
using DevExpress.Xpo;

namespace DataEntities.Case.Trademarks
{
    [Persistent("TTCase_SearchInfo")]
    [MapInheritance(MapInheritanceType.OwnTable)]
    public class CaseSearchInfo : ExtendedTrademark
    {
        private DateTime fdt_AppDate;
        private DateTime fdt_SearchDate;
        private string fs_AppNumber;
        private string fs_Applicant;
        private string fs_ReqDesc;
        private string fs_SearchAim;
        private string fs_SearchAppDate;
        private string fs_SearchApplicant;
        private string fs_SearchNumber;
        private string fs_SearchResult;
        private string fs_SearchTMName;

        private string fs_SearchType;

        private string fs_SearchTypeCode;
        private string fs_TMName;

        public CaseSearchInfo(Session session) : base(session)
        {
        }

        public CaseSearchInfo() : base(Session.DefaultSession)
        {
        }

        [Size(200)]
        public string s_SearchAim
        {
            get { return fs_SearchAim; }
            set { SetPropertyValue("s_SearchAim", ref fs_SearchAim, value); }
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
        public string s_SearchNumber
        {
            get { return fs_SearchNumber; }
            set { SetPropertyValue("s_SearchNumber", ref fs_SearchNumber, value); }
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
        public string s_SearchTMName
        {
            get { return fs_SearchTMName; }
            set { SetPropertyValue("s_SearchTMName", ref fs_SearchTMName, value); }
        }

        [Size(300)]
        public string s_TMName
        {
            get { return fs_TMName; }
            set { SetPropertyValue("s_TMName", ref fs_TMName, value); }
        }

        [Size(500)]
        public string s_SearchResult
        {
            get { return fs_SearchResult; }
            set { SetPropertyValue("s_SearchResult", ref fs_SearchResult, value); }
        }

        public DateTime dt_SearchDate
        {
            get { return fdt_SearchDate; }
            set { SetPropertyValue<DateTime>("dt_SearchDate", ref fdt_SearchDate, value); }
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}
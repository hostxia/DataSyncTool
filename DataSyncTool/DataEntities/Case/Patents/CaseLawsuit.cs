using System;
using DevExpress.Xpo;

namespace DataEntities.Case.Patents
{
    [MapInheritance(MapInheritanceType.OwnTable)]
    [Persistent("TPCase_LawsuitInfo")]
    public class CaseLawsuit : ExtendedPatent
    {
        private DateTime fdt_CourtDate;
        private DateTime fdt_CourtNoticeDate;
        private DateTime fdt_CourtRegDate;
        private DateTime fdt_PubProofDate;
        private DateTime fdt_ReplyDate;
        private DateTime fdt_SubpoenaDate;
        private string fs_AcceptCourt;
        private string fs_CaseBrief;
        private string fs_CheckLevel;
        private string fs_CourtAddr;
        private string fs_CourtContact;
        private string fs_CourtEmail;
        private string fs_CourtFax;

        private string fs_CourtName;
        private string fs_CourtOfficer;
        private string fs_CourtSerial;
        private string fs_CourtTel;
        private string fs_CourtZipCode;
        private string fs_Judge;

        public CaseLawsuit(Session session) : base(session)
        {
        }

        public CaseLawsuit() : base(Session.DefaultSession)
        {
        }

        [Size(2000)]
        public string s_CaseBrief
        {
            get { return fs_CaseBrief; }
            set { SetPropertyValue("s_CaseBrief", ref fs_CaseBrief, value); }
        }

        [Size(200)]
        public string s_CourtName
        {
            get { return fs_CourtName; }
            set { SetPropertyValue("s_CourtName", ref fs_CourtName, value); }
        }

        [Size(300)]
        public string s_CourtAddr
        {
            get { return fs_CourtAddr; }
            set { SetPropertyValue("s_CourtAddr", ref fs_CourtAddr, value); }
        }

        [Size(50)]
        public string s_CourtZipCode
        {
            get { return fs_CourtZipCode; }
            set { SetPropertyValue("s_CourtZipCode", ref fs_CourtZipCode, value); }
        }

        [Size(200)]
        public string s_CourtContact
        {
            get { return fs_CourtContact; }
            set { SetPropertyValue("s_CourtContact", ref fs_CourtContact, value); }
        }

        [Size(50)]
        public string s_CourtTel
        {
            get { return fs_CourtTel; }
            set { SetPropertyValue("s_CourtTel", ref fs_CourtTel, value); }
        }

        [Size(50)]
        public string s_CourtFax
        {
            get { return fs_CourtFax; }
            set { SetPropertyValue("s_CourtFax", ref fs_CourtFax, value); }
        }

        [Size(50)]
        public string s_CourtEmail
        {
            get { return fs_CourtEmail; }
            set { SetPropertyValue("s_CourtEmail", ref fs_CourtEmail, value); }
        }

        [Size(50)]
        public string s_CourtSerial
        {
            get { return fs_CourtSerial; }
            set { SetPropertyValue("s_CourtSerial", ref fs_CourtSerial, value); }
        }

        public DateTime dt_CourtRegDate
        {
            get { return fdt_CourtRegDate; }
            set { SetPropertyValue<DateTime>("dt_CourtRegDate", ref fdt_CourtRegDate, value); }
        }

        public DateTime dt_CourtNoticeDate
        {
            get { return fdt_CourtNoticeDate; }
            set { SetPropertyValue<DateTime>("dt_CourtNoticeDate", ref fdt_CourtNoticeDate, value); }
        }

        [Size(200)]
        public string s_Judge
        {
            get { return fs_Judge; }
            set { SetPropertyValue("s_Judge", ref fs_Judge, value); }
        }

        [Size(200)]
        public string s_CourtOfficer
        {
            get { return fs_CourtOfficer; }
            set { SetPropertyValue("s_CourtOfficer", ref fs_CourtOfficer, value); }
        }

        public string s_AcceptCourt
        {
            get { return fs_AcceptCourt; }
            set { SetPropertyValue("s_AcceptCourt", ref fs_AcceptCourt, value); }
        }

        public string s_CheckLevel
        {
            get { return fs_CheckLevel; }
            set { SetPropertyValue("s_CheckLevel", ref fs_CheckLevel, value); }
        }

        public DateTime dt_PubProofDate
        {
            get { return fdt_PubProofDate; }
            set { SetPropertyValue<DateTime>("dt_PubProofDate", ref fdt_PubProofDate, value); }
        }

        public DateTime dt_CourtDate
        {
            get { return fdt_CourtDate; }
            set { SetPropertyValue<DateTime>("dt_CourtDate", ref fdt_CourtDate, value); }
        }

        public DateTime dt_SubpoenaDate
        {
            get { return fdt_SubpoenaDate; }
            set { SetPropertyValue<DateTime>("dt_SubpoenaDate", ref fdt_SubpoenaDate, value); }
        }

        public DateTime dt_ReplyDate
        {
            get { return fdt_ReplyDate; }
            set { SetPropertyValue<DateTime>("dt_ReplyDate", ref fdt_ReplyDate, value); }
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}
using System;
using DevExpress.Xpo;

namespace DataEntities.Case.Trademarks
{
    [MapInheritance(MapInheritanceType.OwnTable)]
    [Persistent("TTCase_LawsuitInfo")]
    public class CaseLawsuit : MultiPersonCase
    {
        private readonly XPDelayedProperty fdt_CourtDate = new XPDelayedProperty();
        private readonly XPDelayedProperty fdt_CourtNoticeDate = new XPDelayedProperty();
        private readonly XPDelayedProperty fdt_CourtRegDate = new XPDelayedProperty();
        private readonly XPDelayedProperty fdt_PubProofDate = new XPDelayedProperty();
        private readonly XPDelayedProperty fdt_ReplyDate = new XPDelayedProperty();
        private readonly XPDelayedProperty fdt_SubpoenaDate = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_AcceptCourt = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_CaseBrief = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_CheckLevel = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_CourtAddr = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_CourtContact = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_CourtEmail = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_CourtFax = new XPDelayedProperty();

        private readonly XPDelayedProperty fs_CourtName = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_CourtOfficer = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_CourtSerial = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_CourtTel = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_CourtZipCode = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_Judge = new XPDelayedProperty();

        public CaseLawsuit(Session session) : base(session)
        {
        }

        public CaseLawsuit() : base(Session.DefaultSession)
        {
        }

        [Delayed("fs_CaseBrief")]
        [Size(2000)]
        public string s_CaseBrief
        {
            get { return (string) fs_CaseBrief.Value; }
            set { fs_CaseBrief.Value = value; }
        }

        [Delayed("fs_CourtName")]
        [Size(200)]
        public string s_CourtName
        {
            get { return (string) fs_CourtName.Value; }
            set { fs_CourtName.Value = value; }
        }

        [Delayed("fs_CourtAddr")]
        [Size(300)]
        public string s_CourtAddr
        {
            get { return (string) fs_CourtAddr.Value; }
            set { fs_CourtAddr.Value = value; }
        }

        [Delayed("fs_CourtZipCode")]
        [Size(10)]
        public string s_CourtZipCode
        {
            get { return (string) fs_CourtZipCode.Value; }
            set { fs_CourtZipCode.Value = value; }
        }

        [Delayed("fs_CourtContact")]
        [Size(200)]
        public string s_CourtContact
        {
            get { return (string) fs_CourtContact.Value; }
            set { fs_CourtContact.Value = value; }
        }

        [Delayed("fs_CourtTel")]
        [Size(50)]
        public string s_CourtTel
        {
            get { return (string) fs_CourtTel.Value; }
            set { fs_CourtTel.Value = value; }
        }

        [Delayed("fs_CourtFax")]
        [Size(50)]
        public string s_CourtFax
        {
            get { return (string) fs_CourtFax.Value; }
            set { fs_CourtFax.Value = value; }
        }

        [Delayed("fs_CourtEmail")]
        [Size(50)]
        public string s_CourtEmail
        {
            get { return (string) fs_CourtEmail.Value; }
            set { fs_CourtEmail.Value = value; }
        }

        [Delayed("fs_CourtSerial")]
        [Size(50)]
        public string s_CourtSerial
        {
            get { return (string) fs_CourtSerial.Value; }
            set { fs_CourtSerial.Value = value; }
        }

        [Delayed("fdt_CourtRegDate")]
        public DateTime dt_CourtRegDate
        {
            get
            {
                if (fdt_CourtRegDate.Value == null)
                {
                    return DateTime.MinValue;
                }
                return (DateTime) fdt_CourtRegDate.Value;
            }
            set { fdt_CourtRegDate.Value = value; }
        }

        [Delayed("fdt_CourtNoticeDate")]
        public DateTime dt_CourtNoticeDate
        {
            get
            {
                if (fdt_CourtNoticeDate.Value == null)
                {
                    return DateTime.MinValue;
                }
                return (DateTime) fdt_CourtNoticeDate.Value;
            }
            set { fdt_CourtNoticeDate.Value = value; }
        }

        [Delayed("fs_Judge")]
        [Size(200)]
        public string s_Judge
        {
            get { return (string) fs_Judge.Value; }
            set { fs_Judge.Value = value; }
        }

        [Delayed("fs_CourtOfficer")]
        [Size(200)]
        public string s_CourtOfficer
        {
            get { return (string) fs_CourtOfficer.Value; }
            set { fs_CourtOfficer.Value = value; }
        }

        [Delayed("fs_AcceptCourt")]
        public string s_AcceptCourt
        {
            get { return (string) fs_AcceptCourt.Value; }
            set { fs_AcceptCourt.Value = value; }
        }

        [Delayed("fs_CheckLevel")]
        public string s_CheckLevel
        {
            get { return (string) fs_CheckLevel.Value; }
            set { fs_CheckLevel.Value = value; }
        }

        [Delayed("fdt_PubProofDate")]
        public DateTime dt_PubProofDate
        {
            get
            {
                if (fdt_PubProofDate.Value == null)
                {
                    return DateTime.MinValue;
                }
                return (DateTime) fdt_PubProofDate.Value;
            }
            set { fdt_PubProofDate.Value = value; }
        }

        [Delayed("fdt_CourtDate")]
        public DateTime dt_CourtDate
        {
            get
            {
                if (fdt_CourtDate.Value == null)
                {
                    return DateTime.MinValue;
                }
                return (DateTime) fdt_CourtDate.Value;
            }
            set { fdt_CourtDate.Value = value; }
        }

        [Delayed("fdt_SubpoenaDate")]
        public DateTime dt_SubpoenaDate
        {
            get
            {
                if (fdt_SubpoenaDate.Value == null)
                {
                    return DateTime.MinValue;
                }
                return (DateTime) fdt_SubpoenaDate.Value;
            }
            set { fdt_SubpoenaDate.Value = value; }
        }

        [Delayed("fdt_ReplyDate")]
        public DateTime dt_ReplyDate
        {
            get
            {
                if (fdt_ReplyDate.Value == null)
                {
                    return DateTime.MinValue;
                }
                return (DateTime) fdt_ReplyDate.Value;
            }
            set { fdt_ReplyDate.Value = value; }
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}
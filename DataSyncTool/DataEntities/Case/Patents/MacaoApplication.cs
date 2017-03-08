using System;
using DevExpress.Xpo;

namespace DataEntities.Case.Patents
{
    [MapInheritance(MapInheritanceType.OwnTable)]
    [Persistent("TPCase_MacaoApplication")]
    public class MacaoApplication : ExtendedPatent
    {
        public MacaoApplication(Session session) : base(session)
        {
        }

        public MacaoApplication() : base(Session.DefaultSession)
        {
        }

        private string fs_ParentCaseSerial;
        [Size(50)]
        public string s_ParentCaseSerial
        {
            get { return fs_ParentCaseSerial; }
            set { SetPropertyValue("s_ParentCaseSerial", ref fs_ParentCaseSerial, value); }
        }

        private string fs_ParentCaseAppNo;
        [Size(50)]
        public string s_ParentCaseAppNo
        {
            get { return fs_ParentCaseAppNo; }
            set { SetPropertyValue("s_ParentCaseAppNo", ref fs_ParentCaseAppNo, value); }
        }

        private string fs_ParentCaseCountry;
        [Size(100)]
        public string s_ParentCaseCountry
        {
            get { return fs_ParentCaseCountry; }
            set { SetPropertyValue("s_ParentCaseCountry", ref fs_ParentCaseCountry, value); }
        }

        private DateTime? fdt_AppDate;
        public DateTime? dt_AppDate
        {
            get { return fdt_AppDate; }
            set { SetPropertyValue<DateTime?>("dt_AppDate", ref fdt_AppDate, value); }
        }

        private DateTime? fdt_GrantDate;
        public DateTime? dt_GrantDate
        {
            get { return fdt_GrantDate; }
            set { SetPropertyValue<DateTime?>("dt_GrantDate", ref fdt_GrantDate, value); }
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}
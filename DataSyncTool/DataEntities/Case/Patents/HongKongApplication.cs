using System;
using DevExpress.Xpo;

namespace DataEntities.Case.Patents
{
    [MapInheritance(MapInheritanceType.OwnTable)]
    [Persistent("TPCase_HongKongApplication")]
    public class HongKongApplication : ExtendedPatent
    {
        private int fn_Type;

        private string fs_Note;

        public HongKongApplication(Session session) : base(session)
        {
        }

        public HongKongApplication() : base(Session.DefaultSession)
        {
        }

        public int n_Type
        {
            get { return fn_Type; }
            set { SetPropertyValue<int>("n_Type", ref fn_Type, value); }
        }

        [Size(1000)]
        public string s_Note
        {
            get { return fs_Note; }
            set { SetPropertyValue("s_Note", ref fs_Note, value); }
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

        private DateTime? fdt_1stRegisterDate;
        public DateTime? dt_1stRegisterDate
        {
            get { return fdt_1stRegisterDate; }
            set { SetPropertyValue<DateTime?>("dt_1stRegisterDate", ref fdt_1stRegisterDate, value); }
        }

        private DateTime? fdt_1stAgentReport;
        public DateTime? dt_1stAgentReport
        {
            get { return fdt_1stAgentReport; }
            set { SetPropertyValue<DateTime?>("dt_1stAgentReport", ref fdt_1stAgentReport, value); }
        }

        private DateTime? fdt_1stPublish;
        public DateTime? dt_1stPublish
        {
            get { return fdt_1stPublish; }
            set { SetPropertyValue<DateTime?>("dt_1stPublish", ref fdt_1stPublish, value); }
        }

        private DateTime? fdt_2ndRegisterDate;
        public DateTime? dt_2ndRegisterDate
        {
            get { return fdt_2ndRegisterDate; }
            set { SetPropertyValue<DateTime?>("dt_2ndRegisterDate", ref fdt_2ndRegisterDate, value); }
        }

        private DateTime? fdt_2ndAgentReport;
        public DateTime? dt_2ndAgentReport
        {
            get { return fdt_2ndAgentReport; }
            set { SetPropertyValue<DateTime?>("dt_2ndAgentReport", ref fdt_2ndAgentReport, value); }
        }

        private DateTime? fdt_2ndGrantReport;
        public DateTime? dt_2ndGrantReport
        {
            get { return fdt_2ndGrantReport; }
            set { SetPropertyValue<DateTime?>("dt_2ndGrantReport", ref fdt_2ndGrantReport, value); }
        }
        private DateTime? fdt_RemindShldDate;
        public DateTime? dt_RemindShldDate
        {
            get { return fdt_RemindShldDate; }
            set { SetPropertyValue<DateTime?>("dt_RemindShldDate", ref fdt_RemindShldDate, value); }
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}
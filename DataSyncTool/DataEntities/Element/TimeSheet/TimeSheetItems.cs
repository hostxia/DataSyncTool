using System;
using DevExpress.Xpo;

namespace DataEntities.Element.TimeSheet
{
    [Persistent("T_TimesheetItems")]
    public class TimeSheetItems : XPLiteObject
    {
        private DateTime fdt_EndTime;
        private DateTime fdt_StartedTime;
        private decimal fn_BillingHours;
        private decimal fn_ChargeRate;
        private int fn_EmployeeID;
        private int fn_ID;
        private decimal fn_WorkingHours;
        private string fs_SubTask;

        private TimeSheet timeSheet;

        public TimeSheetItems(Session session) : base(session)
        {
        }

        public TimeSheetItems() : base(Session.DefaultSession)
        {
        }

        [Key(true)]
        public int n_ID
        {
            get { return fn_ID; }
            set { SetPropertyValue<int>("n_ID", ref fn_ID, value); }
        }

        [Association("TimeSheet-Items")]
        [Persistent("n_TimesheetID")]
        public TimeSheet Timesheet
        {
            get { return timeSheet; }
            set { SetPropertyValue("n_TimesheetID", ref timeSheet, value); }
        }

        public int n_EmployeeID
        {
            get { return fn_EmployeeID; }
            set { SetPropertyValue<int>("n_EmployeeID", ref fn_EmployeeID, value); }
        }

        public decimal n_ChargeRate
        {
            get { return fn_ChargeRate; }
            set { SetPropertyValue<decimal>("n_ChargeRate", ref fn_ChargeRate, value); }
        }

        [Size(200)]
        public string s_SubTask
        {
            get { return fs_SubTask; }
            set { SetPropertyValue("s_SubTask", ref fs_SubTask, value); }
        }

        public DateTime dt_StartedTime
        {
            get { return fdt_StartedTime; }
            set { SetPropertyValue<DateTime>("dt_StartedTime", ref fdt_StartedTime, value); }
        }

        public DateTime dt_EndTime
        {
            get { return fdt_EndTime; }
            set { SetPropertyValue<DateTime>("dt_EndTime", ref fdt_EndTime, value); }
        }

        public decimal n_WorkingHours
        {
            get { return fn_WorkingHours; }
            set { SetPropertyValue<decimal>("n_WorkingHours", ref fn_WorkingHours, value); }
        }

        public decimal n_BillingHours
        {
            get { return fn_BillingHours; }
            set { SetPropertyValue<decimal>("n_BillingHours", ref fn_BillingHours, value); }
        }

        public decimal n_TotalPaid
        {
            get { return Math.Round(n_ChargeRate*fn_BillingHours, 2); }
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}
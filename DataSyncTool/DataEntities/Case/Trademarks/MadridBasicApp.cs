using System;
using DevExpress.Xpo;

namespace DataEntities.Case.Trademarks
{
    [Persistent("TTCase_MadridBasicApp")]
    public class MadridBasicApp : XPLiteObject
    {
        private DateTime fdt_BasicAppDate;
        private DateTime fdt_BasicRegDate;
        private int fn_BasicCaseID;
        private int fn_ID;
        private string fs_BasicAppNO;
        private string fs_BasicRegNO;

        private ExtendedTrademark trademark;

        public MadridBasicApp(Session session) : base(session)
        {
        }

        public MadridBasicApp() : base(Session.DefaultSession)
        {
        }

        [Key(true)]
        public int n_ID
        {
            get { return fn_ID; }
            set { SetPropertyValue<int>("n_ID", ref fn_ID, value); }
        }

        [Association("Trademark-MadridBasicApp")]
        [Persistent("n_CaseID")]
        public ExtendedTrademark ExtendedTrademark
        {
            get { return trademark; }
            set { SetPropertyValue("n_CaseID", ref trademark, value); }
        }

        public int n_BasicCaseID
        {
            get { return fn_BasicCaseID; }
            set { SetPropertyValue<int>("n_BasicCaseID", ref fn_BasicCaseID, value); }
        }

        [Size(50)]
        public string s_BasicAppNO
        {
            get { return fs_BasicAppNO; }
            set { SetPropertyValue("s_BasicAppNO", ref fs_BasicAppNO, value); }
        }

        public DateTime dt_BasicAppDate
        {
            get { return fdt_BasicAppDate; }
            set { SetPropertyValue<DateTime>("dt_BasicAppDate", ref fdt_BasicAppDate, value); }
        }

        [Size(50)]
        public string s_BasicRegNO
        {
            get { return fs_BasicRegNO; }
            set { SetPropertyValue("s_BasicRegNO", ref fs_BasicRegNO, value); }
        }

        public DateTime dt_BasicRegDate
        {
            get { return fdt_BasicRegDate; }
            set { SetPropertyValue<DateTime>("dt_BasicRegDate", ref fdt_BasicRegDate, value); }
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}
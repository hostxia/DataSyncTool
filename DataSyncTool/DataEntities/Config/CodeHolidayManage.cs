using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.Xpo;

namespace DataEntities.Config
{
    [Persistent("TCode_HolidayManage")]
    public class CodeHolidayManage : XPLiteObject
    {
        private int fn_ID;
        private string fs_Type;
        private string fs_Notes;
        private DateTime fdt_Date;
        [Key(true)]
        public int n_ID
        {
            get { return fn_ID; }
            set { SetPropertyValue<int>("n_ID", ref fn_ID, value); }
        }

        public string s_Type
        {
            get { return fs_Type; }
            set { SetPropertyValue<string>("s_Type", ref fs_Type, value); }
        }
        [Size(1000)]
        public string s_Notes
        {
            get { return fs_Notes; }
            set { SetPropertyValue<string>("s_Notes", ref fs_Notes, value); }
        }

        public DateTime dt_Date
        {
            get { return fdt_Date; }
            set { SetPropertyValue<DateTime>("dt_Date", ref fdt_Date, value); }
        }
        public CodeHolidayManage(Session session) : base(session)
        {
        }

        public CodeHolidayManage() : base(Session.DefaultSession)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}

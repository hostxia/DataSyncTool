using System;
using DevExpress.Xpo;

namespace DataEntities.Case.Others
{
    [MapInheritance(MapInheritanceType.OwnTable)]
    [Persistent("TOCase_Other")]
    public class BasicOtherCase : BasicCase
    {
        private DateTime fdt_AppDate;
        private int fn_OFlowNum;

        private string fs_ApplyAim;

        private string fs_IPStatus;

        public BasicOtherCase(Session session) : base(session)
        {
        }

        public BasicOtherCase() : base(Session.DefaultSession)
        {
        }

        public int n_OFlowNum
        {
            get { return fn_OFlowNum; }
            set { SetPropertyValue<int>("n_OFlowNum", ref fn_OFlowNum, value); }
        }

        public DateTime dt_AppDate
        {
            get { return fdt_AppDate; }
            set { SetPropertyValue<DateTime>("dt_AppDate", ref fdt_AppDate, value); }
        }

        [Size(500)]
        public string s_ApplyAim
        {
            get { return fs_ApplyAim; }
            set { SetPropertyValue("s_ApplyAim", ref fs_ApplyAim, value); }
        }

        [Size(50)]
        public string s_IPStatus
        {
            get { return fs_IPStatus; }
            set { SetPropertyValue("s_IPStatus", ref fs_IPStatus, value); }
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}
using System;
using DevExpress.Xpo;

namespace DataEntities.Case.Patents
{
    [MapInheritance(MapInheritanceType.OwnTable)]
    [Persistent("TPCase_PermitPatents")]
    public class PermitPatent : XPLiteObject
    {
        private CasePermitMemo _casePermitMemo;
        private DateTime fdt_AppDate;
        private DateTime fdt_ProcDate;
        private int fn_ID;
        private string fs_PatentName;

        private string fs_PatentNum;

        public PermitPatent(Session session) : base(session)
        {
        }

        public PermitPatent() : base(Session.DefaultSession)
        {
        }

        [Key(true)]
        public int n_ID
        {
            get { return fn_ID; }
            set { SetPropertyValue<int>("n_ID", ref fn_ID, value); }
        }

        [Association("CasePermitMemo-PermitPatents")]
        [Persistent("n_CaseID")]
        public CasePermitMemo CasePermitMemo
        {
            get { return _casePermitMemo; }
            set { SetPropertyValue("n_CaseID", ref _casePermitMemo, value); }
        }

        [Size(50)]
        public string s_PatentNum
        {
            get { return fs_PatentNum; }
            set { SetPropertyValue("s_PatentNum", ref fs_PatentNum, value); }
        }

        [Size(300)]
        public string s_PatentName
        {
            get { return fs_PatentName; }
            set { SetPropertyValue("s_PatentName", ref fs_PatentName, value); }
        }

        public DateTime dt_AppDate
        {
            get { return fdt_AppDate; }
            set { SetPropertyValue<DateTime>("dt_AppDate", ref fdt_AppDate, value); }
        }

        public DateTime dt_ProcDate
        {
            get { return fdt_ProcDate; }
            set { SetPropertyValue<DateTime>("dt_ProcDate", ref fdt_ProcDate, value); }
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}
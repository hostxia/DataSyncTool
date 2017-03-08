using System;
using DevExpress.Xpo;

namespace DataEntities.Case.Patents
{
    [MapInheritance(MapInheritanceType.OwnTable)]
    [Persistent("TPCase_ReviewInfo")]
    public class CaseReview : ExtendedPatent
    {
        //int fn_ID;
        //[Key(true)]
        //public int n_ID
        //{
        //    get { return fn_ID; }
        //    set { SetPropertyValue<int>("n_ID", ref fn_ID, value); }
        //}
        //Patent fn_CaseID;
        //[Association("Patent-ReviewInfo")]
        //[Persistent("n_CaseID")]
        //public Patent Patent
        //{
        //    get { return fn_CaseID; }
        //    set { SetPropertyValue<Patent>("n_CaseID", ref fn_CaseID, value); }
        //}

        private DateTime fdt_RejectDate;

        private string fs_Reason;

        public CaseReview(Session session) : base(session)
        {
        }

        public CaseReview() : base(Session.DefaultSession)
        {
        }

        public DateTime dt_RejectDate
        {
            get { return fdt_RejectDate; }
            set { SetPropertyValue<DateTime>("dt_RejectDate", ref fdt_RejectDate, value); }
        }

        [Size(1000)]
        public string s_Reason
        {
            get { return fs_Reason; }
            set { SetPropertyValue("s_Reason", ref fs_Reason, value); }
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}
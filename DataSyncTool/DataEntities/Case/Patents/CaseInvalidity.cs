using System;
using DevExpress.Xpo;

namespace DataEntities.Case.Patents
{
    [MapInheritance(MapInheritanceType.OwnTable)]
    [Persistent("TPCase_InvalidityInfo")]
    public class CaseInvalidity : ExtendedPatent
    {
        //int fn_ID;
        //[Key(true)]
        //public int n_ID
        //{
        //    get { return fn_ID; }
        //    set { SetPropertyValue<int>("n_ID", ref fn_ID, value); }
        //}
        //Patent fn_CaseID;
        //[Association("Patent-InvalidityInfo")]
        //[Persistent("n_CaseID")]
        //public Patent Patent
        //{
        //    get { return fn_CaseID; }
        //    set { SetPropertyValue<Patent>("n_CaseID", ref fn_CaseID, value); }
        //}

        private DateTime fdt_NullPubDate;

        private string fs_NullProposer;

        private string fs_Reason;

        public CaseInvalidity(Session session) : base(session)
        {
        }

        public CaseInvalidity() : base(Session.DefaultSession)
        {
        }

        public DateTime dt_NullPubDate
        {
            get { return fdt_NullPubDate; }
            set { SetPropertyValue<DateTime>("dt_NullPubDate", ref fdt_NullPubDate, value); }
        }

        [Size(300)]
        public string s_NullProposer
        {
            get { return fs_NullProposer; }
            set { SetPropertyValue("s_NullProposer", ref fs_NullProposer, value); }
        }

        [Size(800)]
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
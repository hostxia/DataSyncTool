using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
namespace DataSyncTool.DBIPS4_Import
{

    public partial class TCstmr_Applicant
    {
        public TCstmr_Applicant() : base(Session.DefaultSession) { }
        public TCstmr_Applicant(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}

using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
namespace DataSyncTool.DBIPS4_Import
{

    public partial class TCstmr_ClientConAddress
    {
        public TCstmr_ClientConAddress() : base(Session.DefaultSession) { }
        public TCstmr_ClientConAddress(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}

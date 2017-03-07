using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
namespace DataSyncTool.DBIPS4_Import
{

    public partial class TCstmr_AppConAddress
    {
        public TCstmr_AppConAddress() : base(Session.DefaultSession) { }
        public TCstmr_AppConAddress(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}

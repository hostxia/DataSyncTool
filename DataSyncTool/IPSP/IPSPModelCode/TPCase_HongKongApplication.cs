using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
namespace DataSyncTool.DBIPS4_Import
{

    public partial class TPCase_HongKongApplication
    {
        public TPCase_HongKongApplication() : base(Session.DefaultSession) { }
        public TPCase_HongKongApplication(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}

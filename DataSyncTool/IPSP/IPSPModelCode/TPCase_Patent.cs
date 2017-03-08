using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
namespace DataSyncTool.DBIPS4_Import
{

    public partial class TPCase_Patent
    {
        public TPCase_Patent() : base(Session.DefaultSession) { }
        public TPCase_Patent(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}

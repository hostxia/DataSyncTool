using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
namespace DataSyncTool.DBIPS4_Import
{

    public partial class TPCase_TortiousWare
    {
        public TPCase_TortiousWare() : base(Session.DefaultSession) { }
        public TPCase_TortiousWare(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}

using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
namespace DataSyncTool.DBIPS4_Import
{

    public partial class TFCode_Demand
    {
        public TFCode_Demand() : base(Session.DefaultSession) { }
        public TFCode_Demand(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}

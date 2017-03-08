using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
namespace DataSyncTool.DBIPS4_Import
{

    public partial class TPCase_AnnFeeStage
    {
        public TPCase_AnnFeeStage() : base(Session.DefaultSession) { }
        public TPCase_AnnFeeStage(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}

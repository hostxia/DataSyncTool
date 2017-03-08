using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
namespace DataSyncTool.DBIPS4_Import
{

    public partial class TFCode_DemandTypeInCodeTask
    {
        public TFCode_DemandTypeInCodeTask() : base(Session.DefaultSession) { }
        public TFCode_DemandTypeInCodeTask(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}

using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
namespace DataSyncTool.DBIPS4_Import
{

    public partial class TF_DemandTypeInTask
    {
        public TF_DemandTypeInTask() : base(Session.DefaultSession) { }
        public TF_DemandTypeInTask(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}

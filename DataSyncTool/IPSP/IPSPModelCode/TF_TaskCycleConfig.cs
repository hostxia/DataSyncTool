using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
namespace DataSyncTool.DBIPS4_Import
{

    public partial class TF_TaskCycleConfig
    {
        public TF_TaskCycleConfig() : base(Session.DefaultSession) { }
        public TF_TaskCycleConfig(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}

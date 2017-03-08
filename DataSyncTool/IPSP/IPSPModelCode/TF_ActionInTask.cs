using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
namespace DataSyncTool.DBIPS4_Import
{

    public partial class TF_ActionInTask
    {
        public TF_ActionInTask() : base(Session.DefaultSession) { }
        public TF_ActionInTask(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}

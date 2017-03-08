using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
namespace DataSyncTool.DBIPS4_Import
{

    public partial class TF_OperationLog
    {
        public TF_OperationLog() : base(Session.DefaultSession) { }
        public TF_OperationLog(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}

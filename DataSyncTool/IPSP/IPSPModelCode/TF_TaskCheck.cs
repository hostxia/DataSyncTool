using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
namespace DataSyncTool.DBIPS4_Import
{

    public partial class TF_TaskCheck
    {
        public TF_TaskCheck() : base(Session.DefaultSession) { }
        public TF_TaskCheck(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}

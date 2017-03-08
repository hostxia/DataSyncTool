using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
namespace DataSyncTool.DBIPS4_Import
{

    public partial class TFCode_WorkItemInCodeTaskChain
    {
        public TFCode_WorkItemInCodeTaskChain() : base(Session.DefaultSession) { }
        public TFCode_WorkItemInCodeTaskChain(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}

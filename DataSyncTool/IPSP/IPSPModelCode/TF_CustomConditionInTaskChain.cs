using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
namespace DataSyncTool.DBIPS4_Import
{

    public partial class TF_CustomConditionInTaskChain
    {
        public TF_CustomConditionInTaskChain() : base(Session.DefaultSession) { }
        public TF_CustomConditionInTaskChain(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}

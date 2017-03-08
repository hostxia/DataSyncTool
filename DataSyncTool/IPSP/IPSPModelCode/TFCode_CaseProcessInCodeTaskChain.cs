using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
namespace DataSyncTool.DBIPS4_Import
{

    public partial class TFCode_CaseProcessInCodeTaskChain
    {
        public TFCode_CaseProcessInCodeTaskChain() : base(Session.DefaultSession) { }
        public TFCode_CaseProcessInCodeTaskChain(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}

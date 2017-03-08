using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
namespace DataSyncTool.DBIPS4_Import
{

    public partial class TFCode_TaskChainLayout
    {
        public TFCode_TaskChainLayout() : base(Session.DefaultSession) { }
        public TFCode_TaskChainLayout(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}

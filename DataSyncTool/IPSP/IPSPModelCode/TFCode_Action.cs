using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
namespace DataSyncTool.DBIPS4_Import
{

    public partial class TFCode_Action
    {
        public TFCode_Action() : base(Session.DefaultSession) { }
        public TFCode_Action(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}

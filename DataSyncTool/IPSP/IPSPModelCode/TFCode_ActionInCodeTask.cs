using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
namespace DataSyncTool.DBIPS4_Import
{

    public partial class TFCode_ActionInCodeTask
    {
        public TFCode_ActionInCodeTask() : base(Session.DefaultSession) { }
        public TFCode_ActionInCodeTask(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}

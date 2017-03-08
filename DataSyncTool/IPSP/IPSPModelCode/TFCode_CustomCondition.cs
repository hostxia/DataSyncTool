using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
namespace DataSyncTool.DBIPS4_Import
{

    public partial class TFCode_CustomCondition
    {
        public TFCode_CustomCondition() : base(Session.DefaultSession) { }
        public TFCode_CustomCondition(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}

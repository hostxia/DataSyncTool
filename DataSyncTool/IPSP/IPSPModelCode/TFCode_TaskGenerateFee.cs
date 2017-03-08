using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
namespace DataSyncTool.DBIPS4_Import
{

    public partial class TFCode_TaskGenerateFee
    {
        public TFCode_TaskGenerateFee() : base(Session.DefaultSession) { }
        public TFCode_TaskGenerateFee(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}

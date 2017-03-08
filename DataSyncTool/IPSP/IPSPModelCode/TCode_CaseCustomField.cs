using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
namespace DataSyncTool.DBIPS4_Import
{

    public partial class TCode_CaseCustomField
    {
        public TCode_CaseCustomField() : base(Session.DefaultSession) { }
        public TCode_CaseCustomField(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}

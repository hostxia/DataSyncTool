using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
namespace DataSyncTool.DBIPS4_Import
{

    public partial class TCase_CaseRelative
    {
        public TCase_CaseRelative() : base(Session.DefaultSession) { }
        public TCase_CaseRelative(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}

using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
namespace DataSyncTool.DBIPS4_Import
{

    public partial class TPCase_Priority
    {
        public TPCase_Priority() : base(Session.DefaultSession) { }
        public TPCase_Priority(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}

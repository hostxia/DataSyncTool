using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
namespace DataSyncTool.DBIPS4_Import
{

    public partial class TPCase_ChangeItems
    {
        public TPCase_ChangeItems() : base(Session.DefaultSession) { }
        public TPCase_ChangeItems(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}

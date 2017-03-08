using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
namespace DataSyncTool.DBIPS4_Import
{

    public partial class TPCase_PermitPatents
    {
        public TPCase_PermitPatents() : base(Session.DefaultSession) { }
        public TPCase_PermitPatents(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}

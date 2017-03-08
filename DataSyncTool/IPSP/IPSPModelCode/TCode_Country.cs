using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
namespace DataSyncTool.DBIPS4_Import
{

    public partial class TCode_Country
    {
        public TCode_Country() : base(Session.DefaultSession) { }
        public TCode_Country(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}

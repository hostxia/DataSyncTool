using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
namespace DataSyncTool.DBIPS4_Import
{

    public partial class TCase_Base
    {
        public TCase_Base() : base(Session.DefaultSession) { }
        public TCase_Base(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}

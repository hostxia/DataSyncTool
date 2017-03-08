using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
namespace DataSyncTool.DBIPS4_Import
{

    public partial class T_FeeInCase
    {
        public T_FeeInCase() : base(Session.DefaultSession) { }
        public T_FeeInCase(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}

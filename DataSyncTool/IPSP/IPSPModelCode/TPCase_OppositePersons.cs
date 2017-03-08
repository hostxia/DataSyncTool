using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
namespace DataSyncTool.DBIPS4_Import
{

    public partial class TPCase_OppositePersons
    {
        public TPCase_OppositePersons() : base(Session.DefaultSession) { }
        public TPCase_OppositePersons(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}

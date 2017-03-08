using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
namespace DataSyncTool.DBIPS4_Import
{

    public partial class TF_Deadline
    {
        public TF_Deadline() : base(Session.DefaultSession) { }
        public TF_Deadline(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}

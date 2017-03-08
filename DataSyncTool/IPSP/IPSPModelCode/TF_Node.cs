using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
namespace DataSyncTool.DBIPS4_Import
{

    public partial class TF_Node
    {
        public TF_Node() : base(Session.DefaultSession) { }
        public TF_Node(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}

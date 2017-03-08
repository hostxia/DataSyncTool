using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
namespace DataSyncTool.DBIPS4_Import
{

    public partial class T_FileInCase
    {
        public T_FileInCase() : base(Session.DefaultSession) { }
        public T_FileInCase(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}

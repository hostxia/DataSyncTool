﻿using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
namespace DataSyncTool.DBIPS4_Import
{

    public partial class TPCase_PCTICaseInfo
    {
        public TPCase_PCTICaseInfo() : base(Session.DefaultSession) { }
        public TPCase_PCTICaseInfo(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}

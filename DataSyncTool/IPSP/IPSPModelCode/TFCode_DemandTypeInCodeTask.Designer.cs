﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
namespace DataSyncTool.DBIPS4_Import
{

    public partial class TFCode_DemandTypeInCodeTask : XPLiteObject
    {
        int fn_ID;
        [Key(true)]
        public int n_ID
        {
            get { return fn_ID; }
            set { SetPropertyValue<int>("n_ID", ref fn_ID, value); }
        }
        TFCode_Task fg_CodeTaskGuid;
        [Association(@"TFCode_DemandTypeInCodeTaskReferencesTFCode_Task")]
        public TFCode_Task g_CodeTaskGuid
        {
            get { return fg_CodeTaskGuid; }
            set { SetPropertyValue<TFCode_Task>("g_CodeTaskGuid", ref fg_CodeTaskGuid, value); }
        }
        TFCode_DemandType fn_CodeDemandTypeID;
        [Association(@"TFCode_DemandTypeInCodeTaskReferencesTFCode_DemandType")]
        public TFCode_DemandType n_CodeDemandTypeID
        {
            get { return fn_CodeDemandTypeID; }
            set { SetPropertyValue<TFCode_DemandType>("n_CodeDemandTypeID", ref fn_CodeDemandTypeID, value); }
        }
    }

}

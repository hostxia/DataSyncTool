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

    public partial class TF_DemandTypeInTask : XPLiteObject
    {
        Guid fg_ID;
        [Key(true)]
        public Guid g_ID
        {
            get { return fg_ID; }
            set { SetPropertyValue<Guid>("g_ID", ref fg_ID, value); }
        }
        TF_Task fg_TaskID;
        [Association(@"TF_DemandTypeInTaskReferencesTF_Task")]
        public TF_Task g_TaskID
        {
            get { return fg_TaskID; }
            set { SetPropertyValue<TF_Task>("g_TaskID", ref fg_TaskID, value); }
        }
        TFCode_DemandType fn_CodeDemandTypeID;
        [Association(@"TF_DemandTypeInTaskReferencesTFCode_DemandType")]
        public TFCode_DemandType n_CodeDemandTypeID
        {
            get { return fn_CodeDemandTypeID; }
            set { SetPropertyValue<TFCode_DemandType>("n_CodeDemandTypeID", ref fn_CodeDemandTypeID, value); }
        }
    }

}
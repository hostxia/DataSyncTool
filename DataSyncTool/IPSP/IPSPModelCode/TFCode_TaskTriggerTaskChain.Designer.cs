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

    public partial class TFCode_TaskTriggerTaskChain : XPLiteObject
    {
        Guid fg_ID;
        [Key(true)]
        public Guid g_ID
        {
            get { return fg_ID; }
            set { SetPropertyValue<Guid>("g_ID", ref fg_ID, value); }
        }
        TFCode_Task fg_CodeTaskGuid;
        [Association(@"TFCode_TaskTriggerTaskChainReferencesTFCode_Task")]
        public TFCode_Task g_CodeTaskGuid
        {
            get { return fg_CodeTaskGuid; }
            set { SetPropertyValue<TFCode_Task>("g_CodeTaskGuid", ref fg_CodeTaskGuid, value); }
        }
        TFCode_TaskChain fg_CodeTaskChainGuid;
        [Association(@"TFCode_TaskTriggerTaskChainReferencesTFCode_TaskChain")]
        public TFCode_TaskChain g_CodeTaskChainGuid
        {
            get { return fg_CodeTaskChainGuid; }
            set { SetPropertyValue<TFCode_TaskChain>("g_CodeTaskChainGuid", ref fg_CodeTaskChainGuid, value); }
        }
        string fs_TriggerTime;
        [Size(1)]
        public string s_TriggerTime
        {
            get { return fs_TriggerTime; }
            set { SetPropertyValue<string>("s_TriggerTime", ref fs_TriggerTime, value); }
        }
        string fs_TriggerCondition;
        [Size(2000)]
        public string s_TriggerCondition
        {
            get { return fs_TriggerCondition; }
            set { SetPropertyValue<string>("s_TriggerCondition", ref fs_TriggerCondition, value); }
        }
        string fs_Repeat;
        [Size(1)]
        public string s_Repeat
        {
            get { return fs_Repeat; }
            set { SetPropertyValue<string>("s_Repeat", ref fs_Repeat, value); }
        }
        string fs_RelatedObjectSource;
        [Size(50)]
        public string s_RelatedObjectSource
        {
            get { return fs_RelatedObjectSource; }
            set { SetPropertyValue<string>("s_RelatedObjectSource", ref fs_RelatedObjectSource, value); }
        }
        string fs_MasterSlaveRelation;
        [Size(2)]
        public string s_MasterSlaveRelation
        {
            get { return fs_MasterSlaveRelation; }
            set { SetPropertyValue<string>("s_MasterSlaveRelation", ref fs_MasterSlaveRelation, value); }
        }
    }

}

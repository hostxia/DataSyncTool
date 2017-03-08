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

    public partial class TFCode_TaskChain : XPLiteObject
    {
        Guid fg_ID;
        [Key(true)]
        public Guid g_ID
        {
            get { return fg_ID; }
            set { SetPropertyValue<Guid>("g_ID", ref fg_ID, value); }
        }
        string fs_Code;
        [Size(10)]
        public string s_Code
        {
            get { return fs_Code; }
            set { SetPropertyValue<string>("s_Code", ref fs_Code, value); }
        }
        string fs_Name;
        public string s_Name
        {
            get { return fs_Name; }
            set { SetPropertyValue<string>("s_Name", ref fs_Name, value); }
        }
        string fs_Description;
        [Size(1000)]
        public string s_Description
        {
            get { return fs_Description; }
            set { SetPropertyValue<string>("s_Description", ref fs_Description, value); }
        }
        string fs_State;
        [Size(1)]
        public string s_State
        {
            get { return fs_State; }
            set { SetPropertyValue<string>("s_State", ref fs_State, value); }
        }
        TFCode_TaskChainType fn_TaskChainTypeID;
        [Association(@"TFCode_TaskChainReferencesTFCode_TaskChainType")]
        public TFCode_TaskChainType n_TaskChainTypeID
        {
            get { return fn_TaskChainTypeID; }
            set { SetPropertyValue<TFCode_TaskChainType>("n_TaskChainTypeID", ref fn_TaskChainTypeID, value); }
        }
        string fs_TriggerType;
        public string s_TriggerType
        {
            get { return fs_TriggerType; }
            set { SetPropertyValue<string>("s_TriggerType", ref fs_TriggerType, value); }
        }
        string fs_TriggerCaseIPType;
        [Size(1)]
        public string s_TriggerCaseIPType
        {
            get { return fs_TriggerCaseIPType; }
            set { SetPropertyValue<string>("s_TriggerCaseIPType", ref fs_TriggerCaseIPType, value); }
        }
        string fs_TriggerCameFileIDs;
        [Size(SizeAttribute.Unlimited)]
        public string s_TriggerCameFileIDs
        {
            get { return fs_TriggerCameFileIDs; }
            set { SetPropertyValue<string>("s_TriggerCameFileIDs", ref fs_TriggerCameFileIDs, value); }
        }
        int fn_Creator;
        public int n_Creator
        {
            get { return fn_Creator; }
            set { SetPropertyValue<int>("n_Creator", ref fn_Creator, value); }
        }
        DateTime fdt_CreateTime;
        public DateTime dt_CreateTime
        {
            get { return fdt_CreateTime; }
            set { SetPropertyValue<DateTime>("dt_CreateTime", ref fdt_CreateTime, value); }
        }
        int fn_Editor;
        public int n_Editor
        {
            get { return fn_Editor; }
            set { SetPropertyValue<int>("n_Editor", ref fn_Editor, value); }
        }
        DateTime fdt_EditTime;
        public DateTime dt_EditTime
        {
            get { return fdt_EditTime; }
            set { SetPropertyValue<DateTime>("dt_EditTime", ref fdt_EditTime, value); }
        }
        string fs_FinishCondition;
        [Size(1000)]
        public string s_FinishCondition
        {
            get { return fs_FinishCondition; }
            set { SetPropertyValue<string>("s_FinishCondition", ref fs_FinishCondition, value); }
        }
        string fs_TriggerScope;
        [Size(1)]
        public string s_TriggerScope
        {
            get { return fs_TriggerScope; }
            set { SetPropertyValue<string>("s_TriggerScope", ref fs_TriggerScope, value); }
        }
        [Association(@"TFCode_DeadlineInCodeTaskChainReferencesTFCode_TaskChain")]
        public XPCollection<TFCode_DeadlineInCodeTaskChain> TFCode_DeadlineInCodeTaskChains { get { return GetCollection<TFCode_DeadlineInCodeTaskChain>("TFCode_DeadlineInCodeTaskChains"); } }
        [Association(@"TFCode_NodeReferencesTFCode_TaskChain")]
        public XPCollection<TFCode_Node> TFCode_Nodes { get { return GetCollection<TFCode_Node>("TFCode_Nodes"); } }
        [Association(@"TFCode_NodeReferencesTFCode_TaskChain1")]
        public XPCollection<TFCode_Node> TFCode_Nodes1 { get { return GetCollection<TFCode_Node>("TFCode_Nodes1"); } }
        [Association(@"TFCode_NodeRelationReferencesTFCode_TaskChain")]
        public XPCollection<TFCode_NodeRelation> TFCode_NodeRelations { get { return GetCollection<TFCode_NodeRelation>("TFCode_NodeRelations"); } }
        [Association(@"TFCode_TaskTriggerTaskChainReferencesTFCode_TaskChain")]
        public XPCollection<TFCode_TaskTriggerTaskChain> TFCode_TaskTriggerTaskChains { get { return GetCollection<TFCode_TaskTriggerTaskChain>("TFCode_TaskTriggerTaskChains"); } }
    }

}
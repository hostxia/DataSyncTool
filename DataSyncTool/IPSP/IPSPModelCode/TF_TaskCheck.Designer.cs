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

    public partial class TF_TaskCheck : XPLiteObject
    {
        Guid fg_ID;
        [Key(true)]
        public Guid g_ID
        {
            get { return fg_ID; }
            set { SetPropertyValue<Guid>("g_ID", ref fg_ID, value); }
        }
        TF_Task fg_TaskID;
        [Association(@"TF_TaskCheckReferencesTF_Task")]
        public TF_Task g_TaskID
        {
            get { return fg_TaskID; }
            set { SetPropertyValue<TF_Task>("g_TaskID", ref fg_TaskID, value); }
        }
        int fn_Sequence;
        public int n_Sequence
        {
            get { return fn_Sequence; }
            set { SetPropertyValue<int>("n_Sequence", ref fn_Sequence, value); }
        }
        TF_Task fg_CheckTaskID;
        [Association(@"TF_TaskCheckReferencesTF_Task1")]
        public TF_Task g_CheckTaskID
        {
            get { return fg_CheckTaskID; }
            set { SetPropertyValue<TF_Task>("g_CheckTaskID", ref fg_CheckTaskID, value); }
        }
        string fs_CheckReselt;
        [Size(1)]
        public string s_CheckReselt
        {
            get { return fs_CheckReselt; }
            set { SetPropertyValue<string>("s_CheckReselt", ref fs_CheckReselt, value); }
        }
        string fs_CheckReason;
        [Size(1000)]
        public string s_CheckReason
        {
            get { return fs_CheckReason; }
            set { SetPropertyValue<string>("s_CheckReason", ref fs_CheckReason, value); }
        }
        int fn_Checker;
        public int n_Checker
        {
            get { return fn_Checker; }
            set { SetPropertyValue<int>("n_Checker", ref fn_Checker, value); }
        }
        DateTime fdt_CheckTime;
        public DateTime dt_CheckTime
        {
            get { return fdt_CheckTime; }
            set { SetPropertyValue<DateTime>("dt_CheckTime", ref fdt_CheckTime, value); }
        }
    }

}

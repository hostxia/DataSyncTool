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

    public partial class TF_ActionInTask : XPLiteObject
    {
        Guid fg_ID;
        [Key(true)]
        public Guid g_ID
        {
            get { return fg_ID; }
            set { SetPropertyValue<Guid>("g_ID", ref fg_ID, value); }
        }
        TF_Task fg_TaskID;
        [Association(@"TF_ActionInTaskReferencesTF_Task")]
        public TF_Task g_TaskID
        {
            get { return fg_TaskID; }
            set { SetPropertyValue<TF_Task>("g_TaskID", ref fg_TaskID, value); }
        }
        TFCode_Action fn_CodeActionID;
        [Association(@"TF_ActionInTaskReferencesTFCode_Action")]
        public TFCode_Action n_CodeActionID
        {
            get { return fn_CodeActionID; }
            set { SetPropertyValue<TFCode_Action>("n_CodeActionID", ref fn_CodeActionID, value); }
        }
        string fs_Name;
        public string s_Name
        {
            get { return fs_Name; }
            set { SetPropertyValue<string>("s_Name", ref fs_Name, value); }
        }
        string fs_ParamIn;
        [Size(50)]
        public string s_ParamIn
        {
            get { return fs_ParamIn; }
            set { SetPropertyValue<string>("s_ParamIn", ref fs_ParamIn, value); }
        }
        int fn_Sequence;
        public int n_Sequence
        {
            get { return fn_Sequence; }
            set { SetPropertyValue<int>("n_Sequence", ref fn_Sequence, value); }
        }
    }

}
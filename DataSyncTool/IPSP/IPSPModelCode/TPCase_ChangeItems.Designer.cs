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

    public partial class TPCase_ChangeItems : XPLiteObject
    {
        int fn_ID;
        [Key(true)]
        public int n_ID
        {
            get { return fn_ID; }
            set { SetPropertyValue<int>("n_ID", ref fn_ID, value); }
        }
        TPCase_Patent fn_CaseID;
        [Association(@"TPCase_ChangeItemsReferencesTPCase_Patent")]
        public TPCase_Patent n_CaseID
        {
            get { return fn_CaseID; }
            set { SetPropertyValue<TPCase_Patent>("n_CaseID", ref fn_CaseID, value); }
        }
        int fn_ProcessID;
        public int n_ProcessID
        {
            get { return fn_ProcessID; }
            set { SetPropertyValue<int>("n_ProcessID", ref fn_ProcessID, value); }
        }
        string fs_Item;
        public string s_Item
        {
            get { return fs_Item; }
            set { SetPropertyValue<string>("s_Item", ref fs_Item, value); }
        }
        string fs_BeforeChg;
        [Size(300)]
        public string s_BeforeChg
        {
            get { return fs_BeforeChg; }
            set { SetPropertyValue<string>("s_BeforeChg", ref fs_BeforeChg, value); }
        }
        string fs_AfterChg;
        [Size(300)]
        public string s_AfterChg
        {
            get { return fs_AfterChg; }
            set { SetPropertyValue<string>("s_AfterChg", ref fs_AfterChg, value); }
        }
        string fs_Notes;
        [Size(800)]
        public string s_Notes
        {
            get { return fs_Notes; }
            set { SetPropertyValue<string>("s_Notes", ref fs_Notes, value); }
        }
    }

}

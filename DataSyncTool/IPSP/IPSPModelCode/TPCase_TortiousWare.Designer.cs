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

    public partial class TPCase_TortiousWare : XPLiteObject
    {
        TPCase_CustomMemo fn_CaseID;
        [Association(@"TPCase_TortiousWareReferencesTPCase_CustomMemo")]
        public TPCase_CustomMemo n_CaseID
        {
            get { return fn_CaseID; }
            set { SetPropertyValue<TPCase_CustomMemo>("n_CaseID", ref fn_CaseID, value); }
        }
        string fs_WareName;
        [Size(300)]
        public string s_WareName
        {
            get { return fs_WareName; }
            set { SetPropertyValue<string>("s_WareName", ref fs_WareName, value); }
        }
        string fs_HSCode;
        [Size(30)]
        public string s_HSCode
        {
            get { return fs_HSCode; }
            set { SetPropertyValue<string>("s_HSCode", ref fs_HSCode, value); }
        }
        string fs_Note;
        [Size(600)]
        public string s_Note
        {
            get { return fs_Note; }
            set { SetPropertyValue<string>("s_Note", ref fs_Note, value); }
        }
        int fn_ID;
        [Key(true)]
        public int n_ID
        {
            get { return fn_ID; }
            set { SetPropertyValue<int>("n_ID", ref fn_ID, value); }
        }
    }

}

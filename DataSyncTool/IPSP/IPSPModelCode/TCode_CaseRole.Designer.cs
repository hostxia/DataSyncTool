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

    public partial class TCode_CaseRole : XPLiteObject
    {
        int fn_ID;
        [Key(true)]
        public int n_ID
        {
            get { return fn_ID; }
            set { SetPropertyValue<int>("n_ID", ref fn_ID, value); }
        }
        string fs_Name;
        [Size(200)]
        public string s_Name
        {
            get { return fs_Name; }
            set { SetPropertyValue<string>("s_Name", ref fs_Name, value); }
        }
        string fs_Note;
        [Size(500)]
        public string s_Note
        {
            get { return fs_Note; }
            set { SetPropertyValue<string>("s_Note", ref fs_Note, value); }
        }
        string fs_AssignRuleType;
        [Size(1)]
        public string s_AssignRuleType
        {
            get { return fs_AssignRuleType; }
            set { SetPropertyValue<string>("s_AssignRuleType", ref fs_AssignRuleType, value); }
        }
        string fs_AssignRuleValue;
        [Size(400)]
        public string s_AssignRuleValue
        {
            get { return fs_AssignRuleValue; }
            set { SetPropertyValue<string>("s_AssignRuleValue", ref fs_AssignRuleValue, value); }
        }
    }

}

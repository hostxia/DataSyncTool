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

    public partial class TFCode_TaskType : XPLiteObject
    {
        int fn_ID;
        [Key(true)]
        public int n_ID
        {
            get { return fn_ID; }
            set { SetPropertyValue<int>("n_ID", ref fn_ID, value); }
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
        [Association(@"TFCode_TaskReferencesTFCode_TaskType")]
        public XPCollection<TFCode_Task> TFCode_Tasks { get { return GetCollection<TFCode_Task>("TFCode_Tasks"); } }
    }

}

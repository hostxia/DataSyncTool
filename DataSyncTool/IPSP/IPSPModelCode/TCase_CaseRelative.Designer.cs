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

    public partial class TCase_CaseRelative : XPLiteObject
    {
        int fn_ID;
        [Key(true)]
        public int n_ID
        {
            get { return fn_ID; }
            set { SetPropertyValue<int>("n_ID", ref fn_ID, value); }
        }
        int fn_CaseIDA;
        [Indexed(Name = @"in_CaseIDA_TCase_CaseRelative")]
        public int n_CaseIDA
        {
            get { return fn_CaseIDA; }
            set { SetPropertyValue<int>("n_CaseIDA", ref fn_CaseIDA, value); }
        }
        int fn_CaseIDB;
        [Indexed(Name = @"in_CaseIDB_TCase_CaseRelative")]
        public int n_CaseIDB
        {
            get { return fn_CaseIDB; }
            set { SetPropertyValue<int>("n_CaseIDB", ref fn_CaseIDB, value); }
        }
        string fs_Notes;
        [Size(1000)]
        public string s_Notes
        {
            get { return fs_Notes; }
            set { SetPropertyValue<string>("s_Notes", ref fs_Notes, value); }
        }
        DateTime fdt_CreateDate;
        public DateTime dt_CreateDate
        {
            get { return fdt_CreateDate; }
            set { SetPropertyValue<DateTime>("dt_CreateDate", ref fdt_CreateDate, value); }
        }
        DateTime fdt_EditDate;
        public DateTime dt_EditDate
        {
            get { return fdt_EditDate; }
            set { SetPropertyValue<DateTime>("dt_EditDate", ref fdt_EditDate, value); }
        }
        string fs_CaseRelation;
        public string s_CaseRelation
        {
            get { return fs_CaseRelation; }
            set { SetPropertyValue<string>("s_CaseRelation", ref fs_CaseRelation, value); }
        }
        string fs_MasterSlaveRelation;
        public string s_MasterSlaveRelation
        {
            get { return fs_MasterSlaveRelation; }
            set { SetPropertyValue<string>("s_MasterSlaveRelation", ref fs_MasterSlaveRelation, value); }
        }
        int fn_CodeRelativeID;
        public int n_CodeRelativeID
        {
            get { return fn_CodeRelativeID; }
            set { SetPropertyValue<int>("n_CodeRelativeID", ref fn_CodeRelativeID, value); }
        }
    }

}

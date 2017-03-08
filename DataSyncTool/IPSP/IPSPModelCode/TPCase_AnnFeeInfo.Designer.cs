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

    public partial class TPCase_AnnFeeInfo : XPLiteObject
    {
        int fn_ID;
        [Key(true)]
        public int n_ID
        {
            get { return fn_ID; }
            set { SetPropertyValue<int>("n_ID", ref fn_ID, value); }
        }
        TPCase_Patent fn_CaseID;
        [Association(@"TPCase_AnnFeeInfoReferencesTPCase_Patent")]
        public TPCase_Patent n_CaseID
        {
            get { return fn_CaseID; }
            set { SetPropertyValue<TPCase_Patent>("n_CaseID", ref fn_CaseID, value); }
        }
        string fs_OfficialDiscStyle;
        [Size(1)]
        public string s_OfficialDiscStyle
        {
            get { return fs_OfficialDiscStyle; }
            set { SetPropertyValue<string>("s_OfficialDiscStyle", ref fs_OfficialDiscStyle, value); }
        }
        decimal fn_OfficialDiscount;
        public decimal n_OfficialDiscount
        {
            get { return fn_OfficialDiscount; }
            set { SetPropertyValue<decimal>("n_OfficialDiscount", ref fn_OfficialDiscount, value); }
        }
        int fn_DiscYears;
        public int n_DiscYears
        {
            get { return fn_DiscYears; }
            set { SetPropertyValue<int>("n_DiscYears", ref fn_DiscYears, value); }
        }
        int fn_FstPayYear;
        public int n_FstPayYear
        {
            get { return fn_FstPayYear; }
            set { SetPropertyValue<int>("n_FstPayYear", ref fn_FstPayYear, value); }
        }
        int fn_LastPayYear;
        public int n_LastPayYear
        {
            get { return fn_LastPayYear; }
            set { SetPropertyValue<int>("n_LastPayYear", ref fn_LastPayYear, value); }
        }
        int fn_AlarmMonths;
        public int n_AlarmMonths
        {
            get { return fn_AlarmMonths; }
            set { SetPropertyValue<int>("n_AlarmMonths", ref fn_AlarmMonths, value); }
        }
        DateTime fdt_FstPayYear;
        public DateTime dt_FstPayYear
        {
            get { return fdt_FstPayYear; }
            set { SetPropertyValue<DateTime>("dt_FstPayYear", ref fdt_FstPayYear, value); }
        }
        DateTime fdt_LastPayYear;
        public DateTime dt_LastPayYear
        {
            get { return fdt_LastPayYear; }
            set { SetPropertyValue<DateTime>("dt_LastPayYear", ref fdt_LastPayYear, value); }
        }
        int fn_CountPayYear;
        public int n_CountPayYear
        {
            get { return fn_CountPayYear; }
            set { SetPropertyValue<int>("n_CountPayYear", ref fn_CountPayYear, value); }
        }
    }

}
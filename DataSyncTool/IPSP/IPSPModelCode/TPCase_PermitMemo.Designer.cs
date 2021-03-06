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

    public partial class TPCase_PermitMemo : XPLiteObject
    {
        int fn_CaseID;
        [Key]
        public int n_CaseID
        {
            get { return fn_CaseID; }
            set { SetPropertyValue<int>("n_CaseID", ref fn_CaseID, value); }
        }
        string fs_MemoNum;
        [Size(50)]
        public string s_MemoNum
        {
            get { return fs_MemoNum; }
            set { SetPropertyValue<string>("s_MemoNum", ref fs_MemoNum, value); }
        }
        DateTime fdt_MemoDate;
        public DateTime dt_MemoDate
        {
            get { return fdt_MemoDate; }
            set { SetPropertyValue<DateTime>("dt_MemoDate", ref fdt_MemoDate, value); }
        }
        DateTime fdt_MemoBeginDate;
        public DateTime dt_MemoBeginDate
        {
            get { return fdt_MemoBeginDate; }
            set { SetPropertyValue<DateTime>("dt_MemoBeginDate", ref fdt_MemoBeginDate, value); }
        }
        DateTime fdt_MemoEndDate;
        public DateTime dt_MemoEndDate
        {
            get { return fdt_MemoEndDate; }
            set { SetPropertyValue<DateTime>("dt_MemoEndDate", ref fdt_MemoEndDate, value); }
        }
        string fs_Type;
        [Size(50)]
        public string s_Type
        {
            get { return fs_Type; }
            set { SetPropertyValue<string>("s_Type", ref fs_Type, value); }
        }
        string fs_FulFilAddr;
        [Size(200)]
        public string s_FulFilAddr
        {
            get { return fs_FulFilAddr; }
            set { SetPropertyValue<string>("s_FulFilAddr", ref fs_FulFilAddr, value); }
        }
        DateTime fdt_ContractDate;
        public DateTime dt_ContractDate
        {
            get { return fdt_ContractDate; }
            set { SetPropertyValue<DateTime>("dt_ContractDate", ref fdt_ContractDate, value); }
        }
        decimal fn_UseFee;
        public decimal n_UseFee
        {
            get { return fn_UseFee; }
            set { SetPropertyValue<decimal>("n_UseFee", ref fn_UseFee, value); }
        }
        int fn_UseFeeCurrency;
        public int n_UseFeeCurrency
        {
            get { return fn_UseFeeCurrency; }
            set { SetPropertyValue<int>("n_UseFeeCurrency", ref fn_UseFeeCurrency, value); }
        }
        string fs_Property;
        [Size(50)]
        public string s_Property
        {
            get { return fs_Property; }
            set { SetPropertyValue<string>("s_Property", ref fs_Property, value); }
        }
        [Association(@"TPCase_PermitPatentsReferencesTPCase_PermitMemo")]
        public XPCollection<TPCase_PermitPatents> TPCase_PermitPatentss { get { return GetCollection<TPCase_PermitPatents>("TPCase_PermitPatentss"); } }
    }

}

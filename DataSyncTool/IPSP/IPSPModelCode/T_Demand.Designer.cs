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

    public partial class T_Demand : XPLiteObject
    {
        int fn_ID;
        [Key(true)]
        public int n_ID
        {
            get { return fn_ID; }
            set { SetPropertyValue<int>("n_ID", ref fn_ID, value); }
        }
        string fs_Content;
        [Size(1000)]
        public string s_Content
        {
            get { return fs_Content; }
            set { SetPropertyValue<string>("s_Content", ref fs_Content, value); }
        }
        DateTime fdt_EditDate;
        public DateTime dt_EditDate
        {
            get { return fdt_EditDate; }
            set { SetPropertyValue<DateTime>("dt_EditDate", ref fdt_EditDate, value); }
        }
        string fs_Type;
        public string s_Type
        {
            get { return fs_Type; }
            set { SetPropertyValue<string>("s_Type", ref fs_Type, value); }
        }
        string fs_ModuleType;
        [Size(20)]
        public string s_ModuleType
        {
            get { return fs_ModuleType; }
            set { SetPropertyValue<string>("s_ModuleType", ref fs_ModuleType, value); }
        }
        int fn_EditorID;
        public int n_EditorID
        {
            get { return fn_EditorID; }
            set { SetPropertyValue<int>("n_EditorID", ref fn_EditorID, value); }
        }
        string fs_Active;
        [Size(1)]
        public string s_Active
        {
            get { return fs_Active; }
            set { SetPropertyValue<string>("s_Active", ref fs_Active, value); }
        }
        int fn_Sequence;
        public int n_Sequence
        {
            get { return fn_Sequence; }
            set { SetPropertyValue<int>("n_Sequence", ref fn_Sequence, value); }
        }
        int fn_objectID;
        public int n_objectID
        {
            get { return fn_objectID; }
            set { SetPropertyValue<int>("n_objectID", ref fn_objectID, value); }
        }
        int fn_SysDemandID;
        public int n_SysDemandID
        {
            get { return fn_SysDemandID; }
            set { SetPropertyValue<int>("n_SysDemandID", ref fn_SysDemandID, value); }
        }
        string fs_Title;
        [Size(SizeAttribute.Unlimited)]
        public string s_Title
        {
            get { return fs_Title; }
            set { SetPropertyValue<string>("s_Title", ref fs_Title, value); }
        }
        string fs_Description;
        [Size(2000)]
        public string s_Description
        {
            get { return fs_Description; }
            set { SetPropertyValue<string>("s_Description", ref fs_Description, value); }
        }
        string fs_Creator;
        [Size(50)]
        public string s_Creator
        {
            get { return fs_Creator; }
            set { SetPropertyValue<string>("s_Creator", ref fs_Creator, value); }
        }
        DateTime fdt_CreateDate;
        public DateTime dt_CreateDate
        {
            get { return fdt_CreateDate; }
            set { SetPropertyValue<DateTime>("dt_CreateDate", ref fdt_CreateDate, value); }
        }
        string fs_Editor;
        [Size(50)]
        public string s_Editor
        {
            get { return fs_Editor; }
            set { SetPropertyValue<string>("s_Editor", ref fs_Editor, value); }
        }
        string fs_IPType;
        [Size(20)]
        public string s_IPType
        {
            get { return fs_IPType; }
            set { SetPropertyValue<string>("s_IPType", ref fs_IPType, value); }
        }
        TCstmr_Client fn_ClientID;
        [Indexed(Name = @"in_ClientID_T_Demand")]
        [Association(@"T_DemandReferencesTCstmr_Client")]
        public TCstmr_Client n_ClientID
        {
            get { return fn_ClientID; }
            set { SetPropertyValue<TCstmr_Client>("n_ClientID", ref fn_ClientID, value); }
        }
        TCstmr_Applicant fn_ApplicantID;
        [Indexed(Name = @"in_ApplicantID_T_Demand")]
        [Association(@"T_DemandReferencesTCstmr_Applicant")]
        public TCstmr_Applicant n_ApplicantID
        {
            get { return fn_ApplicantID; }
            set { SetPropertyValue<TCstmr_Applicant>("n_ApplicantID", ref fn_ApplicantID, value); }
        }
        int fn_CaseID;
        [Indexed(Name = @"in_CaseID_T_Demand")]
        public int n_CaseID
        {
            get { return fn_CaseID; }
            set { SetPropertyValue<int>("n_CaseID", ref fn_CaseID, value); }
        }
        TCstmr_CoopAgency fn_AgencyID;
        [Indexed(Name = @"in_AgencyID_T_Demand")]
        [Association(@"T_DemandReferencesTCstmr_CoopAgency")]
        public TCstmr_CoopAgency n_AgencyID
        {
            get { return fn_AgencyID; }
            set { SetPropertyValue<TCstmr_CoopAgency>("n_AgencyID", ref fn_AgencyID, value); }
        }
        string fs_DemandPosition;
        public string s_DemandPosition
        {
            get { return fs_DemandPosition; }
            set { SetPropertyValue<string>("s_DemandPosition", ref fs_DemandPosition, value); }
        }
        int fn_CodeDemandID;
        [Indexed(Name = @"in_CodeDemandID_T_Demand")]
        public int n_CodeDemandID
        {
            get { return fn_CodeDemandID; }
            set { SetPropertyValue<int>("n_CodeDemandID", ref fn_CodeDemandID, value); }
        }
        string fs_ReceiptMethod;
        public string s_ReceiptMethod
        {
            get { return fs_ReceiptMethod; }
            set { SetPropertyValue<string>("s_ReceiptMethod", ref fs_ReceiptMethod, value); }
        }
        string fs_Assignor;
        public string s_Assignor
        {
            get { return fs_Assignor; }
            set { SetPropertyValue<string>("s_Assignor", ref fs_Assignor, value); }
        }
        DateTime fdt_ReceiptDate;
        public DateTime dt_ReceiptDate
        {
            get { return fdt_ReceiptDate; }
            set { SetPropertyValue<DateTime>("dt_ReceiptDate", ref fdt_ReceiptDate, value); }
        }
        int fn_CodeDemandTypeID;
        public int n_CodeDemandTypeID
        {
            get { return fn_CodeDemandTypeID; }
            set { SetPropertyValue<int>("n_CodeDemandTypeID", ref fn_CodeDemandTypeID, value); }
        }
        string fs_FilePath;
        [Size(500)]
        public string s_FilePath
        {
            get { return fs_FilePath; }
            set { SetPropertyValue<string>("s_FilePath", ref fs_FilePath, value); }
        }
        string fs_SysDemand;
        public string s_SysDemand
        {
            get { return fs_SysDemand; }
            set { SetPropertyValue<string>("s_SysDemand", ref fs_SysDemand, value); }
        }
        int fn_SysOftenDemand;
        public int n_SysOftenDemand
        {
            get { return fn_SysOftenDemand; }
            set { SetPropertyValue<int>("n_SysOftenDemand", ref fn_SysOftenDemand, value); }
        }
        string fs_Process;
        [Size(500)]
        public string s_Process
        {
            get { return fs_Process; }
            set { SetPropertyValue<string>("s_Process", ref fs_Process, value); }
        }
        string fs_BussinessType;
        [Size(500)]
        public string s_BussinessType
        {
            get { return fs_BussinessType; }
            set { SetPropertyValue<string>("s_BussinessType", ref fs_BussinessType, value); }
        }
        string fs_SourceModuleType;
        [Size(20)]
        public string s_SourceModuleType
        {
            get { return fs_SourceModuleType; }
            set { SetPropertyValue<string>("s_SourceModuleType", ref fs_SourceModuleType, value); }
        }
        int fn_SourceID;
        public int n_SourceID
        {
            get { return fn_SourceID; }
            set { SetPropertyValue<int>("n_SourceID", ref fn_SourceID, value); }
        }
        int fn_DemadType;
        public int n_DemadType
        {
            get { return fn_DemadType; }
            set { SetPropertyValue<int>("n_DemadType", ref fn_DemadType, value); }
        }
        int fn_DemandType;
        public int n_DemandType
        {
            get { return fn_DemandType; }
            set { SetPropertyValue<int>("n_DemandType", ref fn_DemandType, value); }
        }
        string fs_sourcetype1;
        public string s_sourcetype1
        {
            get { return fs_sourcetype1; }
            set { SetPropertyValue<string>("s_sourcetype1", ref fs_sourcetype1, value); }
        }
    }

}

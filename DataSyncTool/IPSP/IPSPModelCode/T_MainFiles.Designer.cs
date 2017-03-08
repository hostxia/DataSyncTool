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

    public partial class T_MainFiles : XPLiteObject
    {
        int fn_FileID;
        [Key(true)]
        public int n_FileID
        {
            get { return fn_FileID; }
            set { SetPropertyValue<int>("n_FileID", ref fn_FileID, value); }
        }
        string fs_SendMethod;
        [Size(50)]
        public string s_SendMethod
        {
            get { return fs_SendMethod; }
            set { SetPropertyValue<string>("s_SendMethod", ref fs_SendMethod, value); }
        }
        string fs_Name;
        [Size(400)]
        public string s_Name
        {
            get { return fs_Name; }
            set { SetPropertyValue<string>("s_Name", ref fs_Name, value); }
        }
        string fs_Abstact;
        [Size(1000)]
        public string s_Abstact
        {
            get { return fs_Abstact; }
            set { SetPropertyValue<string>("s_Abstact", ref fs_Abstact, value); }
        }
        string fs_FilePathName;
        [Size(500)]
        public string s_FilePathName
        {
            get { return fs_FilePathName; }
            set { SetPropertyValue<string>("s_FilePathName", ref fs_FilePathName, value); }
        }
        string fs_IOType;
        [Size(10)]
        public string s_IOType
        {
            get { return fs_IOType; }
            set { SetPropertyValue<string>("s_IOType", ref fs_IOType, value); }
        }
        string fs_ClientGov;
        [Size(50)]
        public string s_ClientGov
        {
            get { return fs_ClientGov; }
            set { SetPropertyValue<string>("s_ClientGov", ref fs_ClientGov, value); }
        }
        int fn_ProcessID;
        public int n_ProcessID
        {
            get { return fn_ProcessID; }
            set { SetPropertyValue<int>("n_ProcessID", ref fn_ProcessID, value); }
        }
        DateTime fdt_SendDate;
        public DateTime dt_SendDate
        {
            get { return fdt_SendDate; }
            set { SetPropertyValue<DateTime>("dt_SendDate", ref fdt_SendDate, value); }
        }
        DateTime fdt_ReceiveDate;
        public DateTime dt_ReceiveDate
        {
            get { return fdt_ReceiveDate; }
            set { SetPropertyValue<DateTime>("dt_ReceiveDate", ref fdt_ReceiveDate, value); }
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
        string fs_IsActive;
        [Size(1)]
        public string s_IsActive
        {
            get { return fs_IsActive; }
            set { SetPropertyValue<string>("s_IsActive", ref fs_IsActive, value); }
        }
        int fn_TemplateID;
        public int n_TemplateID
        {
            get { return fn_TemplateID; }
            set { SetPropertyValue<int>("n_TemplateID", ref fn_TemplateID, value); }
        }
        DateTime fdt_AppDate;
        public DateTime dt_AppDate
        {
            get { return fdt_AppDate; }
            set { SetPropertyValue<DateTime>("dt_AppDate", ref fdt_AppDate, value); }
        }
        string fs_PubNo;
        [Size(50)]
        public string s_PubNo
        {
            get { return fs_PubNo; }
            set { SetPropertyValue<string>("s_PubNo", ref fs_PubNo, value); }
        }
        DateTime fdt_PubDate;
        public DateTime dt_PubDate
        {
            get { return fdt_PubDate; }
            set { SetPropertyValue<DateTime>("dt_PubDate", ref fdt_PubDate, value); }
        }
        string fs_CaseSerial;
        public string s_CaseSerial
        {
            get { return fs_CaseSerial; }
            set { SetPropertyValue<string>("s_CaseSerial", ref fs_CaseSerial, value); }
        }
        string fs_AppNo;
        public string s_AppNo
        {
            get { return fs_AppNo; }
            set { SetPropertyValue<string>("s_AppNo", ref fs_AppNo, value); }
        }
        string fs_Applicants;
        [Size(1000)]
        public string s_Applicants
        {
            get { return fs_Applicants; }
            set { SetPropertyValue<string>("s_Applicants", ref fs_Applicants, value); }
        }
        string fs_Introducer;
        [Size(300)]
        public string s_Introducer
        {
            get { return fs_Introducer; }
            set { SetPropertyValue<string>("s_Introducer", ref fs_Introducer, value); }
        }
        string fs_Inventors;
        [Size(1000)]
        public string s_Inventors
        {
            get { return fs_Inventors; }
            set { SetPropertyValue<string>("s_Inventors", ref fs_Inventors, value); }
        }
        string fs_Attorney;
        [Size(200)]
        public string s_Attorney
        {
            get { return fs_Attorney; }
            set { SetPropertyValue<string>("s_Attorney", ref fs_Attorney, value); }
        }
        string fs_Creator;
        [Size(50)]
        public string s_Creator
        {
            get { return fs_Creator; }
            set { SetPropertyValue<string>("s_Creator", ref fs_Creator, value); }
        }
        string fs_Editor;
        [Size(50)]
        public string s_Editor
        {
            get { return fs_Editor; }
            set { SetPropertyValue<string>("s_Editor", ref fs_Editor, value); }
        }
        int fn_MainCaseID;
        public int n_MainCaseID
        {
            get { return fn_MainCaseID; }
            set { SetPropertyValue<int>("n_MainCaseID", ref fn_MainCaseID, value); }
        }
        string fs_Status;
        public string s_Status
        {
            get { return fs_Status; }
            set { SetPropertyValue<string>("s_Status", ref fs_Status, value); }
        }
        int fn_FlowNum;
        public int n_FlowNum
        {
            get { return fn_FlowNum; }
            set { SetPropertyValue<int>("n_FlowNum", ref fn_FlowNum, value); }
        }
        string fs_InfileFlowNum;
        public string s_InfileFlowNum
        {
            get { return fs_InfileFlowNum; }
            set { SetPropertyValue<string>("s_InfileFlowNum", ref fs_InfileFlowNum, value); }
        }
        string fs_IsNewCaseInFile;
        public string s_IsNewCaseInFile
        {
            get { return fs_IsNewCaseInFile; }
            set { SetPropertyValue<string>("s_IsNewCaseInFile", ref fs_IsNewCaseInFile, value); }
        }
        int fn_NumCount;
        public int n_NumCount
        {
            get { return fn_NumCount; }
            set { SetPropertyValue<int>("n_NumCount", ref fn_NumCount, value); }
        }
        int fn_PicCount;
        public int n_PicCount
        {
            get { return fn_PicCount; }
            set { SetPropertyValue<int>("n_PicCount", ref fn_PicCount, value); }
        }
        string fs_From;
        [Size(1000)]
        public string s_From
        {
            get { return fs_From; }
            set { SetPropertyValue<string>("s_From", ref fs_From, value); }
        }
        string fs_To;
        [Size(3000)]
        public string s_To
        {
            get { return fs_To; }
            set { SetPropertyValue<string>("s_To", ref fs_To, value); }
        }
        string fs_Cc;
        [Size(3000)]
        public string s_Cc
        {
            get { return fs_Cc; }
            set { SetPropertyValue<string>("s_Cc", ref fs_Cc, value); }
        }
        string fs_Bc;
        [Size(3000)]
        public string s_Bc
        {
            get { return fs_Bc; }
            set { SetPropertyValue<string>("s_Bc", ref fs_Bc, value); }
        }
        TCstmr_Client fn_ClientID;
        [Association(@"T_MainFilesReferencesTCstmr_Client")]
        public TCstmr_Client n_ClientID
        {
            get { return fn_ClientID; }
            set { SetPropertyValue<TCstmr_Client>("n_ClientID", ref fn_ClientID, value); }
        }
        string fs_IPType;
        [Size(1)]
        public string s_IPType
        {
            get { return fs_IPType; }
            set { SetPropertyValue<string>("s_IPType", ref fs_IPType, value); }
        }
        TCstmr_Applicant fn_ApplicantID;
        [Association(@"T_MainFilesReferencesTCstmr_Applicant")]
        public TCstmr_Applicant n_ApplicantID
        {
            get { return fn_ApplicantID; }
            set { SetPropertyValue<TCstmr_Applicant>("n_ApplicantID", ref fn_ApplicantID, value); }
        }
        int fn_CreatorID;
        public int n_CreatorID
        {
            get { return fn_CreatorID; }
            set { SetPropertyValue<int>("n_CreatorID", ref fn_CreatorID, value); }
        }
        TCstmr_Client fn_FileClientID;
        [Association(@"T_MainFilesReferencesTCstmr_Client1")]
        public TCstmr_Client n_FileClientID
        {
            get { return fn_FileClientID; }
            set { SetPropertyValue<TCstmr_Client>("n_FileClientID", ref fn_FileClientID, value); }
        }
        TCstmr_Applicant fn_FileApplicantID;
        [Association(@"T_MainFilesReferencesTCstmr_Applicant1")]
        public TCstmr_Applicant n_FileApplicantID
        {
            get { return fn_FileApplicantID; }
            set { SetPropertyValue<TCstmr_Applicant>("n_FileApplicantID", ref fn_FileApplicantID, value); }
        }
        string fs_NameForeign;
        [Size(400)]
        public string s_NameForeign
        {
            get { return fs_NameForeign; }
            set { SetPropertyValue<string>("s_NameForeign", ref fs_NameForeign, value); }
        }
        string fs_ClientType;
        [Size(1)]
        public string s_ClientType
        {
            get { return fs_ClientType; }
            set { SetPropertyValue<string>("s_ClientType", ref fs_ClientType, value); }
        }
        string fs_ManualCreateChain;
        [Size(1)]
        public string s_ManualCreateChain
        {
            get { return fs_ManualCreateChain; }
            set { SetPropertyValue<string>("s_ManualCreateChain", ref fs_ManualCreateChain, value); }
        }
        string fs_sourcetype1;
        [Size(500)]
        public string s_sourcetype1
        {
            get { return fs_sourcetype1; }
            set { SetPropertyValue<string>("s_sourcetype1", ref fs_sourcetype1, value); }
        }
        [Association(@"T_FileInCaseReferencesT_MainFiles")]
        public XPCollection<T_FileInCase> T_FileInCases { get { return GetCollection<T_FileInCase>("T_FileInCases"); } }
    }

}

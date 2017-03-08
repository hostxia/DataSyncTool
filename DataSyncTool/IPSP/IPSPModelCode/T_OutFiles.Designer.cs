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

    public partial class T_OutFiles : T_MainFiles
    {
        string fs_Version;
        [Size(20)]
        public string s_Version
        {
            get { return fs_Version; }
            set { SetPropertyValue<string>("s_Version", ref fs_Version, value); }
        }
        string fs_CheckedOut;
        [Size(1)]
        public string s_CheckedOut
        {
            get { return fs_CheckedOut; }
            set { SetPropertyValue<string>("s_CheckedOut", ref fs_CheckedOut, value); }
        }
        int fn_CheckedOutBy;
        public int n_CheckedOutBy
        {
            get { return fn_CheckedOutBy; }
            set { SetPropertyValue<int>("n_CheckedOutBy", ref fn_CheckedOutBy, value); }
        }
        string fs_CheckedOutPath;
        [Size(500)]
        public string s_CheckedOutPath
        {
            get { return fs_CheckedOutPath; }
            set { SetPropertyValue<string>("s_CheckedOutPath", ref fs_CheckedOutPath, value); }
        }
        int fn_GovOfficeID;
        public int n_GovOfficeID
        {
            get { return fn_GovOfficeID; }
            set { SetPropertyValue<int>("n_GovOfficeID", ref fn_GovOfficeID, value); }
        }
        string fs_FileStatus;
        [Size(1)]
        public string s_FileStatus
        {
            get { return fs_FileStatus; }
            set { SetPropertyValue<string>("s_FileStatus", ref fs_FileStatus, value); }
        }
        DateTime fdt_StatusDate;
        public DateTime dt_StatusDate
        {
            get { return fdt_StatusDate; }
            set { SetPropertyValue<DateTime>("dt_StatusDate", ref fdt_StatusDate, value); }
        }
        DateTime fdt_WriteDate;
        public DateTime dt_WriteDate
        {
            get { return fdt_WriteDate; }
            set { SetPropertyValue<DateTime>("dt_WriteDate", ref fdt_WriteDate, value); }
        }
        int fn_WriterID;
        public int n_WriterID
        {
            get { return fn_WriterID; }
            set { SetPropertyValue<int>("n_WriterID", ref fn_WriterID, value); }
        }
        DateTime fdt_SubmitDate;
        public DateTime dt_SubmitDate
        {
            get { return fdt_SubmitDate; }
            set { SetPropertyValue<DateTime>("dt_SubmitDate", ref fdt_SubmitDate, value); }
        }
        int fn_SubmiterID;
        public int n_SubmiterID
        {
            get { return fn_SubmiterID; }
            set { SetPropertyValue<int>("n_SubmiterID", ref fn_SubmiterID, value); }
        }
        DateTime fdt_SubmitDueDate;
        public DateTime dt_SubmitDueDate
        {
            get { return fdt_SubmitDueDate; }
            set { SetPropertyValue<DateTime>("dt_SubmitDueDate", ref fdt_SubmitDueDate, value); }
        }
        string fs_OfficialCode;
        [Size(50)]
        public string s_OfficialCode
        {
            get { return fs_OfficialCode; }
            set { SetPropertyValue<string>("s_OfficialCode", ref fs_OfficialCode, value); }
        }
        int fn_PrintNum;
        public int n_PrintNum
        {
            get { return fn_PrintNum; }
            set { SetPropertyValue<int>("n_PrintNum", ref fn_PrintNum, value); }
        }
        int fn_PageNum;
        public int n_PageNum
        {
            get { return fn_PageNum; }
            set { SetPropertyValue<int>("n_PageNum", ref fn_PageNum, value); }
        }
        string fs_Writer;
        [Size(50)]
        public string s_Writer
        {
            get { return fs_Writer; }
            set { SetPropertyValue<string>("s_Writer", ref fs_Writer, value); }
        }
        string fs_Submiter;
        [Size(50)]
        public string s_Submiter
        {
            get { return fs_Submiter; }
            set { SetPropertyValue<string>("s_Submiter", ref fs_Submiter, value); }
        }
        int fn_FileListID;
        public int n_FileListID
        {
            get { return fn_FileListID; }
            set { SetPropertyValue<int>("n_FileListID", ref fn_FileListID, value); }
        }
        int fn_ReFileID;
        public int n_ReFileID
        {
            get { return fn_ReFileID; }
            set { SetPropertyValue<int>("n_ReFileID", ref fn_ReFileID, value); }
        }
        string fs_ElectronicCode;
        [Size(20)]
        public string s_ElectronicCode
        {
            get { return fs_ElectronicCode; }
            set { SetPropertyValue<string>("s_ElectronicCode", ref fs_ElectronicCode, value); }
        }
        int fn_Count;
        public int n_Count
        {
            get { return fn_Count; }
            set { SetPropertyValue<int>("n_Count", ref fn_Count, value); }
        }
        string fs_FileType;
        [Size(10)]
        public string s_FileType
        {
            get { return fs_FileType; }
            set { SetPropertyValue<string>("s_FileType", ref fs_FileType, value); }
        }
        TCstmr_CoopAgency fn_AgencyID;
        [Association(@"T_OutFilesReferencesTCstmr_CoopAgency")]
        public TCstmr_CoopAgency n_AgencyID
        {
            get { return fn_AgencyID; }
            set { SetPropertyValue<TCstmr_CoopAgency>("n_AgencyID", ref fn_AgencyID, value); }
        }
        int fn_ModuleCheckStatusID;
        public int n_ModuleCheckStatusID
        {
            get { return fn_ModuleCheckStatusID; }
            set { SetPropertyValue<int>("n_ModuleCheckStatusID", ref fn_ModuleCheckStatusID, value); }
        }
        int fn_LatestCheckInfoID;
        public int n_LatestCheckInfoID
        {
            get { return fn_LatestCheckInfoID; }
            set { SetPropertyValue<int>("n_LatestCheckInfoID", ref fn_LatestCheckInfoID, value); }
        }
        int fn_AuthorID;
        public int n_AuthorID
        {
            get { return fn_AuthorID; }
            set { SetPropertyValue<int>("n_AuthorID", ref fn_AuthorID, value); }
        }
        int fn_CurCheckerID;
        public int n_CurCheckerID
        {
            get { return fn_CurCheckerID; }
            set { SetPropertyValue<int>("n_CurCheckerID", ref fn_CurCheckerID, value); }
        }
    }

}
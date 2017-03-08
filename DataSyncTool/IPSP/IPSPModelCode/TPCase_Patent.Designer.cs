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

    public partial class TPCase_Patent : TCase_Base
    {
        int fn_PFlowNum;
        public int n_PFlowNum
        {
            get { return fn_PFlowNum; }
            set { SetPropertyValue<int>("n_PFlowNum", ref fn_PFlowNum, value); }
        }
        TPCase_LawInfo fn_LawID;
        [Association(@"TPCase_PatentReferencesTPCase_LawInfo")]
        public TPCase_LawInfo n_LawID
        {
            get { return fn_LawID; }
            set { SetPropertyValue<TPCase_LawInfo>("n_LawID", ref fn_LawID, value); }
        }
        int fn_PatentTypeID;
        public int n_PatentTypeID
        {
            get { return fn_PatentTypeID; }
            set { SetPropertyValue<int>("n_PatentTypeID", ref fn_PatentTypeID, value); }
        }
        string fs_TechnologyType;
        [Size(50)]
        public string s_TechnologyType
        {
            get { return fs_TechnologyType; }
            set { SetPropertyValue<string>("s_TechnologyType", ref fs_TechnologyType, value); }
        }
        string fs_OldSerial;
        [Size(20)]
        public string s_OldSerial
        {
            get { return fs_OldSerial; }
            set { SetPropertyValue<string>("s_OldSerial", ref fs_OldSerial, value); }
        }
        string fs_NPatentID;
        [Size(50)]
        public string s_NPatentID
        {
            get { return fs_NPatentID; }
            set { SetPropertyValue<string>("s_NPatentID", ref fs_NPatentID, value); }
        }
        string fs_OrigCaseSerial;
        [Size(50)]
        public string s_OrigCaseSerial
        {
            get { return fs_OrigCaseSerial; }
            set { SetPropertyValue<string>("s_OrigCaseSerial", ref fs_OrigCaseSerial, value); }
        }
        string fs_OrigAppNo;
        [Size(50)]
        public string s_OrigAppNo
        {
            get { return fs_OrigAppNo; }
            set { SetPropertyValue<string>("s_OrigAppNo", ref fs_OrigAppNo, value); }
        }
        DateTime fdt_OrigAppDate;
        public DateTime dt_OrigAppDate
        {
            get { return fdt_OrigAppDate; }
            set { SetPropertyValue<DateTime>("dt_OrigAppDate", ref fdt_OrigAppDate, value); }
        }
        string fs_PatentStatus;
        [Size(50)]
        public string s_PatentStatus
        {
            get { return fs_PatentStatus; }
            set { SetPropertyValue<string>("s_PatentStatus", ref fs_PatentStatus, value); }
        }
        string fs_Notes;
        [Size(800)]
        public string s_Notes
        {
            get { return fs_Notes; }
            set { SetPropertyValue<string>("s_Notes", ref fs_Notes, value); }
        }
        TPCase_OrigPatInfo fn_OrigPatInfoID;
        [Indexed(Name = @"in_OrigPatInfoID_TPCase_Patent")]
        [Association(@"TPCase_PatentReferencesTPCase_OrigPatInfo")]
        public TPCase_OrigPatInfo n_OrigPatInfoID
        {
            get { return fn_OrigPatInfoID; }
            set { SetPropertyValue<TPCase_OrigPatInfo>("n_OrigPatInfoID", ref fn_OrigPatInfoID, value); }
        }
        string fs_Inventors;
        [Size(1000)]
        public string s_Inventors
        {
            get { return fs_Inventors; }
            set { SetPropertyValue<string>("s_Inventors", ref fs_Inventors, value); }
        }
        DateTime fdt_RequestSubmitDate;
        public DateTime dt_RequestSubmitDate
        {
            get { return fdt_RequestSubmitDate; }
            set { SetPropertyValue<DateTime>("dt_RequestSubmitDate", ref fdt_RequestSubmitDate, value); }
        }
        bool fb_DivisionalCaseFlag;
        public bool b_DivisionalCaseFlag
        {
            get { return fb_DivisionalCaseFlag; }
            set { SetPropertyValue<bool>("b_DivisionalCaseFlag", ref fb_DivisionalCaseFlag, value); }
        }
        string fs_OrigCaseNo;
        [Size(50)]
        public string s_OrigCaseNo
        {
            get { return fs_OrigCaseNo; }
            set { SetPropertyValue<string>("s_OrigCaseNo", ref fs_OrigCaseNo, value); }
        }
        string fs_AllInventorAddress;
        [Size(500)]
        public string s_AllInventorAddress
        {
            get { return fs_AllInventorAddress; }
            set { SetPropertyValue<string>("s_AllInventorAddress", ref fs_AllInventorAddress, value); }
        }
        string fs_FristPriority;
        [Size(500)]
        public string s_FristPriority
        {
            get { return fs_FristPriority; }
            set { SetPropertyValue<string>("s_FristPriority", ref fs_FristPriority, value); }
        }
        string fs_FirstPriorityNo;
        [Size(500)]
        public string s_FirstPriorityNo
        {
            get { return fs_FirstPriorityNo; }
            set { SetPropertyValue<string>("s_FirstPriorityNo", ref fs_FirstPriorityNo, value); }
        }
        DateTime fdt_FirstPriorityDate;
        public DateTime dt_FirstPriorityDate
        {
            get { return fdt_FirstPriorityDate; }
            set { SetPropertyValue<DateTime>("dt_FirstPriorityDate", ref fdt_FirstPriorityDate, value); }
        }
        string fs_FirstInventor;
        [Size(200)]
        public string s_FirstInventor
        {
            get { return fs_FirstInventor; }
            set { SetPropertyValue<string>("s_FirstInventor", ref fs_FirstInventor, value); }
        }
        string fs_PriorityStatus;
        [Size(1)]
        public string s_PriorityStatus
        {
            get { return fs_PriorityStatus; }
            set { SetPropertyValue<string>("s_PriorityStatus", ref fs_PriorityStatus, value); }
        }
        DateTime fdt_PriorityStatusDate;
        public DateTime dt_PriorityStatusDate
        {
            get { return fdt_PriorityStatusDate; }
            set { SetPropertyValue<DateTime>("dt_PriorityStatusDate", ref fdt_PriorityStatusDate, value); }
        }
        DateTime fdt_DivSubmitDate;
        public DateTime dt_DivSubmitDate
        {
            get { return fdt_DivSubmitDate; }
            set { SetPropertyValue<DateTime>("dt_DivSubmitDate", ref fdt_DivSubmitDate, value); }
        }
        string fs_DivisionAppNo;
        [Size(50)]
        public string s_DivisionAppNo
        {
            get { return fs_DivisionAppNo; }
            set { SetPropertyValue<string>("s_DivisionAppNo", ref fs_DivisionAppNo, value); }
        }
        string fs_DivisionCaseNo;
        [Size(50)]
        public string s_DivisionCaseNo
        {
            get { return fs_DivisionCaseNo; }
            set { SetPropertyValue<string>("s_DivisionCaseNo", ref fs_DivisionCaseNo, value); }
        }
        [Association(@"TPCase_InventorReferencesTPCase_Patent")]
        public XPCollection<TPCase_Inventor> TPCase_Inventors { get { return GetCollection<TPCase_Inventor>("TPCase_Inventors"); } }
        [Association(@"TPCase_PriorityReferencesTPCase_Patent")]
        public XPCollection<TPCase_Priority> TPCase_Prioritys { get { return GetCollection<TPCase_Priority>("TPCase_Prioritys"); } }
        [Association(@"TPCase_ReviewInfoReferencesTPCase_Patent")]
        public XPCollection<TPCase_ReviewInfo> TPCase_ReviewInfos { get { return GetCollection<TPCase_ReviewInfo>("TPCase_ReviewInfos"); } }
        [Association(@"TPCase_SearchInfoReferencesTPCase_Patent")]
        public XPCollection<TPCase_SearchInfo> TPCase_SearchInfos { get { return GetCollection<TPCase_SearchInfo>("TPCase_SearchInfos"); } }
        [Association(@"TPCase_AnnFeeInfoReferencesTPCase_Patent")]
        public XPCollection<TPCase_AnnFeeInfo> TPCase_AnnFeeInfos { get { return GetCollection<TPCase_AnnFeeInfo>("TPCase_AnnFeeInfos"); } }
        [Association(@"TPCase_ChangeItemsReferencesTPCase_Patent")]
        public XPCollection<TPCase_ChangeItems> TPCase_ChangeItemss { get { return GetCollection<TPCase_ChangeItems>("TPCase_ChangeItemss"); } }
        [Association(@"TPCase_ConsultInfoReferencesTPCase_Patent")]
        public XPCollection<TPCase_ConsultInfo> TPCase_ConsultInfos { get { return GetCollection<TPCase_ConsultInfo>("TPCase_ConsultInfos"); } }
        [Association(@"TPCase_InvalidityInfoReferencesTPCase_Patent")]
        public XPCollection<TPCase_InvalidityInfo> TPCase_InvalidityInfos { get { return GetCollection<TPCase_InvalidityInfo>("TPCase_InvalidityInfos"); } }
        [Association(@"TPCase_OppositePersonsReferencesTPCase_Patent")]
        public XPCollection<TPCase_OppositePersons> TPCase_OppositePersonss { get { return GetCollection<TPCase_OppositePersons>("TPCase_OppositePersonss"); } }
        [Association(@"TPCase_TranslateInfoReferencesTPCase_Patent")]
        public XPCollection<TPCase_TranslateInfo> TPCase_TranslateInfos { get { return GetCollection<TPCase_TranslateInfo>("TPCase_TranslateInfos"); } }
        [Association(@"TPCase_WriteInfoReferencesTPCase_Patent")]
        public XPCollection<TPCase_WriteInfo> TPCase_WriteInfos { get { return GetCollection<TPCase_WriteInfo>("TPCase_WriteInfos"); } }
    }

}

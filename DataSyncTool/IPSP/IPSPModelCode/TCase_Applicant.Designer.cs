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

    public partial class TCase_Applicant : XPLiteObject
    {
        int fn_ID;
        [Key(true)]
        public int n_ID
        {
            get { return fn_ID; }
            set { SetPropertyValue<int>("n_ID", ref fn_ID, value); }
        }
        TCase_Base fn_CaseID;
        [Association(@"TCase_ApplicantReferencesTCase_Base")]
        public TCase_Base n_CaseID
        {
            get { return fn_CaseID; }
            set { SetPropertyValue<TCase_Base>("n_CaseID", ref fn_CaseID, value); }
        }
        string fs_IsDelegacy;
        [Size(1)]
        public string s_IsDelegacy
        {
            get { return fs_IsDelegacy; }
            set { SetPropertyValue<string>("s_IsDelegacy", ref fs_IsDelegacy, value); }
        }
        int fn_Sequence;
        public int n_Sequence
        {
            get { return fn_Sequence; }
            set { SetPropertyValue<int>("n_Sequence", ref fn_Sequence, value); }
        }
        int fn_ApplicantID;
        public int n_ApplicantID
        {
            get { return fn_ApplicantID; }
            set { SetPropertyValue<int>("n_ApplicantID", ref fn_ApplicantID, value); }
        }
        string fs_Name;
        [Size(300)]
        public string s_Name
        {
            get { return fs_Name; }
            set { SetPropertyValue<string>("s_Name", ref fs_Name, value); }
        }
        string fs_NativeName;
        [Size(200)]
        public string s_NativeName
        {
            get { return fs_NativeName; }
            set { SetPropertyValue<string>("s_NativeName", ref fs_NativeName, value); }
        }
        string fs_OtherName;
        [Size(200)]
        public string s_OtherName
        {
            get { return fs_OtherName; }
            set { SetPropertyValue<string>("s_OtherName", ref fs_OtherName, value); }
        }
        string fs_Phone;
        [Size(150)]
        public string s_Phone
        {
            get { return fs_Phone; }
            set { SetPropertyValue<string>("s_Phone", ref fs_Phone, value); }
        }
        string fs_Mobile;
        [Size(150)]
        public string s_Mobile
        {
            get { return fs_Mobile; }
            set { SetPropertyValue<string>("s_Mobile", ref fs_Mobile, value); }
        }
        string fs_Fax;
        [Size(150)]
        public string s_Fax
        {
            get { return fs_Fax; }
            set { SetPropertyValue<string>("s_Fax", ref fs_Fax, value); }
        }
        string fs_Email;
        [Size(300)]
        public string s_Email
        {
            get { return fs_Email; }
            set { SetPropertyValue<string>("s_Email", ref fs_Email, value); }
        }
        int fn_Country;
        public int n_Country
        {
            get { return fn_Country; }
            set { SetPropertyValue<int>("n_Country", ref fn_Country, value); }
        }
        string fs_State;
        public string s_State
        {
            get { return fs_State; }
            set { SetPropertyValue<string>("s_State", ref fs_State, value); }
        }
        string fs_City;
        public string s_City
        {
            get { return fs_City; }
            set { SetPropertyValue<string>("s_City", ref fs_City, value); }
        }
        string fs_Street;
        [Size(300)]
        public string s_Street
        {
            get { return fs_Street; }
            set { SetPropertyValue<string>("s_Street", ref fs_Street, value); }
        }
        string fs_ZipCode;
        [Size(50)]
        public string s_ZipCode
        {
            get { return fs_ZipCode; }
            set { SetPropertyValue<string>("s_ZipCode", ref fs_ZipCode, value); }
        }
        string fs_IsApplicant;
        [Size(1)]
        public string s_IsApplicant
        {
            get { return fs_IsApplicant; }
            set { SetPropertyValue<string>("s_IsApplicant", ref fs_IsApplicant, value); }
        }
        string fs_IsAppInv;
        [Size(1)]
        public string s_IsAppInv
        {
            get { return fs_IsAppInv; }
            set { SetPropertyValue<string>("s_IsAppInv", ref fs_IsAppInv, value); }
        }
        string fs_IsInventor;
        [Size(1)]
        public string s_IsInventor
        {
            get { return fs_IsInventor; }
            set { SetPropertyValue<string>("s_IsInventor", ref fs_IsInventor, value); }
        }
        string fs_ForAllCountries;
        [Size(1)]
        public string s_ForAllCountries
        {
            get { return fs_ForAllCountries; }
            set { SetPropertyValue<string>("s_ForAllCountries", ref fs_ForAllCountries, value); }
        }
        string fs_ForNonUS;
        [Size(1)]
        public string s_ForNonUS
        {
            get { return fs_ForNonUS; }
            set { SetPropertyValue<string>("s_ForNonUS", ref fs_ForNonUS, value); }
        }
        string fs_ForUS;
        [Size(1)]
        public string s_ForUS
        {
            get { return fs_ForUS; }
            set { SetPropertyValue<string>("s_ForUS", ref fs_ForUS, value); }
        }
        string fs_ForSpecCountries;
        [Size(1)]
        public string s_ForSpecCountries
        {
            get { return fs_ForSpecCountries; }
            set { SetPropertyValue<string>("s_ForSpecCountries", ref fs_ForSpecCountries, value); }
        }
        string fs_EFilingApplicantType;
        public string s_EFilingApplicantType
        {
            get { return fs_EFilingApplicantType; }
            set { SetPropertyValue<string>("s_EFilingApplicantType", ref fs_EFilingApplicantType, value); }
        }
        string fs_ApplicantTypeContent;
        public string s_ApplicantTypeContent
        {
            get { return fs_ApplicantTypeContent; }
            set { SetPropertyValue<string>("s_ApplicantTypeContent", ref fs_ApplicantTypeContent, value); }
        }
        string fs_OtherAddress;
        [Size(800)]
        public string s_OtherAddress
        {
            get { return fs_OtherAddress; }
            set { SetPropertyValue<string>("s_OtherAddress", ref fs_OtherAddress, value); }
        }
        string fs_CardNumber;
        public string s_CardNumber
        {
            get { return fs_CardNumber; }
            set { SetPropertyValue<string>("s_CardNumber", ref fs_CardNumber, value); }
        }
        string fs_ElecPayer;
        [Size(200)]
        public string s_ElecPayer
        {
            get { return fs_ElecPayer; }
            set { SetPropertyValue<string>("s_ElecPayer", ref fs_ElecPayer, value); }
        }
        string fs_TrustDeedNo;
        [Size(30)]
        public string s_TrustDeedNo
        {
            get { return fs_TrustDeedNo; }
            set { SetPropertyValue<string>("s_TrustDeedNo", ref fs_TrustDeedNo, value); }
        }
        string fs_AppSerial;
        public string s_AppSerial
        {
            get { return fs_AppSerial; }
            set { SetPropertyValue<string>("s_AppSerial", ref fs_AppSerial, value); }
        }
        string fn_IsReceipt;
        [Size(1)]
        public string n_IsReceipt
        {
            get { return fn_IsReceipt; }
            set { SetPropertyValue<string>("n_IsReceipt", ref fn_IsReceipt, value); }
        }
    }

}

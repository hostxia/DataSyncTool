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

    public partial class TCstmr_AgencyAddress : XPLiteObject
    {
        int fn_ID;
        [Key(true)]
        public int n_ID
        {
            get { return fn_ID; }
            set { SetPropertyValue<int>("n_ID", ref fn_ID, value); }
        }
        TCstmr_CoopAgency fn_AgencyID;
        [Association(@"TCstmr_AgencyAddressReferencesTCstmr_CoopAgency")]
        public TCstmr_CoopAgency n_AgencyID
        {
            get { return fn_AgencyID; }
            set { SetPropertyValue<TCstmr_CoopAgency>("n_AgencyID", ref fn_AgencyID, value); }
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
        string fs_Type;
        [Size(10)]
        public string s_Type
        {
            get { return fs_Type; }
            set { SetPropertyValue<string>("s_Type", ref fs_Type, value); }
        }
        string fs_Country;
        [Size(5)]
        public string s_Country
        {
            get { return fs_Country; }
            set { SetPropertyValue<string>("s_Country", ref fs_Country, value); }
        }
        string fs_IsMailingAddress;
        [Size(1)]
        public string s_IsMailingAddress
        {
            get { return fs_IsMailingAddress; }
            set { SetPropertyValue<string>("s_IsMailingAddress", ref fs_IsMailingAddress, value); }
        }
    }

}

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

    public partial class T_Role : XPLiteObject
    {
        int fn_RoleID;
        [Key(true)]
        public int n_RoleID
        {
            get { return fn_RoleID; }
            set { SetPropertyValue<int>("n_RoleID", ref fn_RoleID, value); }
        }
        string fs_RoleName;
        [Size(50)]
        public string s_RoleName
        {
            get { return fs_RoleName; }
            set { SetPropertyValue<string>("s_RoleName", ref fs_RoleName, value); }
        }
        string fs_Notes;
        [Size(500)]
        public string s_Notes
        {
            get { return fs_Notes; }
            set { SetPropertyValue<string>("s_Notes", ref fs_Notes, value); }
        }
        string fs_RoleCode;
        [Size(50)]
        public string s_RoleCode
        {
            get { return fs_RoleCode; }
            set { SetPropertyValue<string>("s_RoleCode", ref fs_RoleCode, value); }
        }
    }

}
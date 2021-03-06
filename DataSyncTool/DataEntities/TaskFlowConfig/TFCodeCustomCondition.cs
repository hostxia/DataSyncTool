﻿using DataEntities.TaskFlowBase;
using DevExpress.Xpo;

namespace DataEntities.TaskFlowConfig
{
    [Persistent("TFCode_CustomCondition")]
    public class TFCodeCustomCondition : XPLiteObjectUser
    {
        int fn_ID;
        [Key(true)]
        public int n_ID
        {
            get { return fn_ID; }
            set { SetPropertyValue<int>("n_ID", ref fn_ID, value); }
        }

        string fs_Code;
        [Size(21)]
        public string s_Code
        {
            get { return fs_Code; }
            set { SetPropertyValue<string>("s_Code", ref fs_Code, value); }
        }

        string fs_Name;
        [Size(100)]
        public string s_Name
        {
            get { return fs_Name; }
            set { SetPropertyValue<string>("s_Name", ref fs_Name, value); }
        }

        string fs_Values;
        [Size(1000)]
        public string s_Values
        {
            get { return fs_Values; }
            set { SetPropertyValue<string>("s_Values", ref fs_Values, value); }
        }

        string fs_MultiSelect;
        [Size(1)]
        public string s_MultiSelect
        {
            get { return fs_MultiSelect; }
            set { SetPropertyValue<string>("s_MultiSelect", ref fs_MultiSelect, value); }
        }

        string fs_Description;
        [Size(1000)]
        public string s_Description
        {
            get { return fs_Description; }
            set { SetPropertyValue<string>("s_Description", ref fs_Description, value); }
        }

        public TFCodeCustomCondition(Session session) : base(session) { }
    }
}

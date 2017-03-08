using System;
using DataEntities.TaskFlowBase;
using DevExpress.Xpo;

namespace DataEntities.Config
{
    [Persistent("TCode_AutoDemandParams")]
    public class CodeAutoDemandParams : XPLiteObjectUser
    {
        Guid fg_ID;
        [Key(false)]
        public Guid g_ID
        {
            get { return fg_ID; }
            set { SetPropertyValue<Guid>("g_ID", ref fg_ID, value); }
        }

        Guid fg_CodeAutoDemandID;
        public Guid g_CodeAutoDemandID
        {
            get { return fg_CodeAutoDemandID; }
            set { SetPropertyValue<Guid>("g_CodeAutoDemandID", ref fg_CodeAutoDemandID, value); }
        }

        string fs_DataType;
        [Size(50)]
        public string s_DataType
        {
            get { return fs_DataType; }
            set { SetPropertyValue<string>("s_DataType", ref fs_DataType, value); }
        }

        string fs_RuleRegex;
        [Size(1000)]
        public string s_RuleRegex
        {
            get { return fs_RuleRegex; }
            set { SetPropertyValue<string>("s_RuleRegex", ref fs_RuleRegex, value); }
        }

        string fs_Description;
        [Size(500)]
        public string s_Description
        {
            get { return fs_Description; }
            set { SetPropertyValue<string>("s_Description", ref fs_Description, value); }
        }

        int fn_Sequence;
        public int n_Sequence
        {
            get { return fn_Sequence; }
            set { SetPropertyValue<int>("n_Sequence", ref fn_Sequence, value); }
        }

        public CodeAutoDemandParams(Session session) : base(session) { }
    }
}

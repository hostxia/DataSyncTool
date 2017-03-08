using System;
using System.Collections.Generic;
using System.Linq;
using DataEntities.TaskFlowBase;
using DevExpress.Data.Filtering;
using DevExpress.Xpo;

namespace DataEntities.TaskFlowConfig
{
    [Persistent("TFCode_Deadline")]
    public class TFCodeDeadline : XPLiteObjectUser
    {
        Guid fg_ID;
        [Key(true)]
        public Guid g_ID
        {
            get { return fg_ID; }
            set { SetPropertyValue<Guid>("g_ID", ref fg_ID, value); }
        }

        string fs_Name;
        [Size(100)]
        public string s_Name
        {
            get { return fs_Name; }
            set { SetPropertyValue<string>("s_Name", ref fs_Name, value); }
        }

        string fs_Type;
        [Size(50)]
        public string s_Type
        {
            get { return fs_Type; }
            set { SetPropertyValue<string>("s_Type", ref fs_Type, value); }
        }

        string fs_Classification;
        [Size(50)]
        public string s_Classification
        {
            get { return fs_Classification; }
            set { SetPropertyValue<string>("s_Classification", ref fs_Classification, value); }
        }

        string fs_ValueRule;
        [Size(50)]
        public string s_ValueRule
        {
            get { return fs_ValueRule; }
            set { SetPropertyValue<string>("s_ValueRule", ref fs_ValueRule, value); }
        }

        string fs_StoredProcedure;
        [Size(500)]
        public string s_StoredProcedure
        {
            get { return fs_StoredProcedure; }
            set { SetPropertyValue<string>("s_StoredProcedure", ref fs_StoredProcedure, value); }
        }

        string fs_Description;
        [Size(1000)]
        public string s_Description
        {
            get { return fs_Description; }
            set { SetPropertyValue<string>("s_Description", ref fs_Description, value); }
        }

        string fs_AllowEdit;
        [Size(1)]
        public string s_AllowEdit
        {
            get { return fs_AllowEdit; }
            set { SetPropertyValue<string>("s_AllowEdit", ref fs_AllowEdit, value); }
        }

        #region Method

        public List<TFCodeBaseDateInCodeDeadline> GetListCodeBaseDateInCodeDeadlines()
        {
            var xpcCodeBaseDateInCodeDeadlines = new XPCollection<TFCodeBaseDateInCodeDeadline>(TheUow, CriteriaOperator.Parse("g_CodeDeadlineID = ?", g_ID));
            return xpcCodeBaseDateInCodeDeadlines.ToList();
        }

        public List<TFCodeTaskChain> GetListCodeTaskChains()
        {
            var xpcCodeDeadlineInCodeTaskChains = new XPCollection<TFCodeDeadlineInCodeTaskChain>(TheUow, CriteriaOperator.Parse("g_CodeDeadlineID = ?", g_ID));
            return xpcCodeDeadlineInCodeTaskChains.Where(w => w != null).Select(s => s.GetTheCodeTaskChain()).Distinct().ToList();
        }

        #endregion

        public TFCodeDeadline(Session session) : base(session) { }

        public TFCodeDeadline() : this(new UnitOfWork()) { }
    }
}

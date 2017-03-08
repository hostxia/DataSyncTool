using System;
using System.Collections.Generic;
using System.Linq;
using DataEntities.TaskFlowBase;
using DevExpress.Data.Filtering;
using DevExpress.Xpo;

namespace DataEntities.Config
{
    [Persistent("TCode_AutoDemand")]
    public class CodeAutoDemand : XPLiteObjectUser
    {
        Guid fg_ID;
        [Key(false)]
        public Guid g_ID
        {
            get { return fg_ID; }
            set { SetPropertyValue<Guid>("g_ID", ref fg_ID, value); }
        }

        string fs_SysDemand;
        [Size(100)]
        public string s_SysDemand
        {
            get { return fs_SysDemand; }
            set { SetPropertyValue<string>("s_SysDemand", ref fs_SysDemand, value); }
        }

        string fs_Name;
        [Size(200)]
        public string s_Name
        {
            get { return fs_Name; }
            set { SetPropertyValue<string>("s_Name", ref fs_Name, value); }
        }

        string fs_Content;
        [Size(500)]
        public string s_Content
        {
            get { return fs_Content; }
            set { SetPropertyValue<string>("s_Content", ref fs_Content, value); }
        }

        string fs_MethodName;
        [Size(200)]
        public string s_MethodName
        {
            get { return fs_MethodName; }
            set { SetPropertyValue<string>("s_MethodName", ref fs_MethodName, value); }
        }

        #region method

        public List<CodeAutoDemandParams> GetListAutoDemandParams()
        {
            var xpcCodeAutoDemandParamss = new XPCollection<CodeAutoDemandParams>(TheUow, CriteriaOperator.Parse("g_CodeAutoDemandID = ?", g_ID));
            return xpcCodeAutoDemandParamss.OrderBy(o => o.n_Sequence).ToList();
        }

        #endregion

        public CodeAutoDemand(Session session) : base(session) { }
    }
}

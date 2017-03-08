using System.Collections.Generic;
using System.Linq;
using DataEntities.TaskFlowBase;
using DevExpress.Data.Filtering;
using DevExpress.Xpo;

namespace DataEntities.TaskFlowConfig
{
    [Persistent("TFCode_BaseDate")]
    public class TFCodeBaseDate : XPLiteObjectUser
    {
        int fn_ID;
        [Key(true)]
        public int n_ID
        {
            get { return fn_ID; }
            set { SetPropertyValue<int>("n_ID", ref fn_ID, value); }
        }

        string fs_Name;
        [Size(100)]
        public string s_Name
        {
            get { return fs_Name; }
            set { SetPropertyValue<string>("s_Name", ref fs_Name, value); }
        }

        string fs_ObjectType;
        [Size(50)]
        public string s_ObjectType
        {
            get { return fs_ObjectType; }
            set { SetPropertyValue<string>("s_ObjectType", ref fs_ObjectType, value); }
        }

        string fs_NameSpace;
        [Size(500)]
        public string s_NameSpace
        {
            get { return fs_NameSpace; }
            set { SetPropertyValue<string>("s_NameSpace", ref fs_NameSpace, value); }
        }

        string fs_FieldName;
        [Size(50)]
        public string s_FieldName
        {
            get { return fs_FieldName; }
            set { SetPropertyValue<string>("s_FieldName", ref fs_FieldName, value); }
        }

        #region MyRegion

        public List<TFCodeDeadline> GetListCodeDeadlines()
        {
            var xpcCodeBaseDateInCodeDeadlines = new XPCollection<TFCodeBaseDateInCodeDeadline>(TheUow, CriteriaOperator.Parse("n_CodeBaseDateID = ?", n_ID));
            return xpcCodeBaseDateInCodeDeadlines.Where(w => w != null).Select(s => s.GetTheCodeDeadline()).Distinct().ToList();
        }

        #endregion

        public TFCodeBaseDate(Session session) : base(session) { }
    }
}

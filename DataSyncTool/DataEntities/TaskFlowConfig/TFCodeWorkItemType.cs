using DataEntities.TaskFlowBase;
using DevExpress.Xpo;

namespace DataEntities.TaskFlowConfig
{
    [Persistent("TFCode_WorkItemType")]
    public class TFCodeWorkItemType : XPLiteObjectUser
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

        string fs_Description;
        [Size(1000)]
        public string s_Description
        {
            get { return fs_Description; }
            set { SetPropertyValue<string>("s_Description", ref fs_Description, value); }
        }

        public TFCodeWorkItemType(Session session) : base(session) { }
    }
}
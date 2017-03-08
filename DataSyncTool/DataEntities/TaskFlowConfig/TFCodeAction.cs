using DataEntities.TaskFlowBase;
using DevExpress.Xpo;

namespace DataEntities.TaskFlowConfig
{
    [Persistent("TFCode_Action")]
    public class TFCodeAction : XPLiteObjectUser
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

        string fs_Type;
        [Size(50)]
        public string s_Type
        {
            get { return fs_Type; }
            set { SetPropertyValue<string>("s_Type", ref fs_Type, value); }
        }

        string fs_FuncNameSpace;
        [Size(500)]
        public string s_FuncNameSpace
        {
            get { return fs_FuncNameSpace; }
            set { SetPropertyValue<string>("s_FuncNameSpace", ref fs_FuncNameSpace, value); }
        }

        string fs_FuncName;
        [Size(500)]
        public string s_FuncName
        {
            get { return fs_FuncName; }
            set { SetPropertyValue<string>("s_FuncName", ref fs_FuncName, value); }
        }

        string fs_DefaultParamIn;
        [Size(50)]
        public string s_DefaultParamIn
        {
            get { return fs_DefaultParamIn; }
            set { SetPropertyValue<string>("s_DefaultParamIn", ref fs_DefaultParamIn, value); }
        }

        string fs_Description;
        [Size(1000)]
        public string s_Description
        {
            get { return fs_Description; }
            set { SetPropertyValue<string>("s_Description", ref fs_Description, value); }
        }

        public TFCodeAction(Session session) : base(session) { }
    }
}
using DataEntities.Config;
using DataEntities.TaskFlowBase;
using DevExpress.Data.Filtering;
using DevExpress.Xpo;

namespace DataEntities.TaskFlowConfig
{
    [Persistent("TFCode_WorkItem")]
    public class TFCodeWorkItem : XPLiteObjectUser
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

        string fs_Unit;
        [Size(100)]
        public string s_Unit
        {
            get { return fs_Unit; }
            set { SetPropertyValue<string>("s_Unit", ref fs_Unit, value); }
        }

        int fn_TypeID;
        public int n_TypeID
        {
            get { return fn_TypeID; }
            set { SetPropertyValue<int>("n_TypeID", ref fn_TypeID, value); }
        }

        string fs_Description;
        [Size(1000)]
        public string s_Description
        {
            get { return fs_Description; }
            set { SetPropertyValue<string>("s_Description", ref fs_Description, value); }
        }

        int fn_CodeFeeID;
        public int n_CodeFeeID
        {
            get { return fn_CodeFeeID; }
            set { SetPropertyValue<int>("n_CodeFeeID", ref fn_CodeFeeID, value); }
        }

        string fs_ConvertToFeeMethod;
        [Size(1)]
        public string s_ConvertToFeeMethod
        {
            get { return fs_ConvertToFeeMethod; }
            set { SetPropertyValue<string>("s_ConvertToFeeMethod", ref fs_ConvertToFeeMethod, value); }
        }

        #region Method

        public CodeFee GetTheCodeFee()
        {
            return n_CodeFeeID <= 0 ? null : TheUow.GetObjectByKey<CodeFee>(n_CodeFeeID);
        }

        #endregion

        public TFCodeWorkItem(Session session) : base(session) { }
    }
}
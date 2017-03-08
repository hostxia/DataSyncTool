using System;
using DataEntities.TaskFlowBase;
using DataEntities.TaskFlowConfig;
using DevExpress.Data.Filtering;
using DevExpress.Xpo;

namespace DataEntities.TaskFlowData
{
    [Persistent("TF_Deadline")]
    public class TFDeadline : XPLiteObjectUser
    {
        int fn_ID;
        [Key(true)]
        public int n_ID
        {
            get { return fn_ID; }
            set { SetPropertyValue<int>("n_ID", ref fn_ID, value); }
        }

        Guid fg_CodeDeadlineID;
        public Guid g_CodeDeadlineID
        {
            get { return fg_CodeDeadlineID; }
            set { SetPropertyValue<Guid>("g_CodeDeadlineID", ref fg_CodeDeadlineID, value); }
        }

        string fs_RelatedObjectType;
        [Size(50)]
        public string s_RelatedObjectType
        {
            get { return fs_RelatedObjectType; }
            set { SetPropertyValue<string>("s_RelatedObjectType", ref fs_RelatedObjectType, value); }
        }

        int fn_RelatedObjectID;
        public int n_RelatedObjectID
        {
            get { return fn_RelatedObjectID; }
            set { SetPropertyValue<int>("n_RelatedObjectID", ref fn_RelatedObjectID, value); }
        }

        DateTime fdt_Deadline;
        public DateTime dt_Deadline
        {
            get { return fdt_Deadline; }
            set { SetPropertyValue<DateTime>("dt_Deadline", ref fdt_Deadline, value); }
        }

        string fs_ManualUpdateDeadline;
        [Size(1)]
        public string s_ManualUpdateDeadline
        {
            get { return fs_ManualUpdateDeadline; }
            set { SetPropertyValue<string>("s_ManualUpdateDeadline", ref fs_ManualUpdateDeadline, value); }
        }

        string fs_AllowEdit;
        [Size(1)]
        public string s_AllowEdit
        {
            get { return fs_AllowEdit; }
            set { SetPropertyValue<string>("s_AllowEdit", ref fs_AllowEdit, value); }
        }

        #region Method

        public TFCodeDeadline GetTheCodeDeadline()
        {
            return TheUow.FindObject<TFCodeDeadline>(CriteriaOperator.Parse("g_ID = ?", g_CodeDeadlineID));
        }

        public object GetTheRelatedObject()
        {
            if (s_RelatedObjectType == "Case") return TheUow.GetObjectByKey<Case.BasicCase>(n_RelatedObjectID);
            if (s_RelatedObjectType == "CameFileOfficial") return TheUow.GetObjectByKey<Element.Files.InFile>(n_RelatedObjectID);
            return null;
        }

        #endregion

        public TFDeadline(Session session) : base(session) { }
    }
}

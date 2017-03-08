using System;
using DevExpress.Xpo;

namespace DataEntities.Element.Fee
{
    [Persistent("T_FeeInWorkItem")]
    public class FeeInWorkItem : XPLiteObject
    {
        private int fn_ID;
        [Key(true)]
        public int n_ID
        {
            get { return fn_ID; }
            set { SetPropertyValue<int>("n_ID", ref fn_ID, value); }
        }

        private Fee fee;
        [Persistent("n_FeeID")]
        [Association("Fee-FeeInWorkItem")]
        public Fee TheFee
        {
            get { return fee; }
            set { SetPropertyValue("n_FeeID", ref fee, value); }
        }

        Guid fg_WorkItemGuid;
        public Guid g_WorkItemGuid
        {
            get { return fg_WorkItemGuid; }
            set { SetPropertyValue<Guid>("g_WorkItemGuid", ref fg_WorkItemGuid, value); }
        }

        int fn_FeeType;
        /// <summary>
        /// 费用类型 1=收费 2=官费
        /// </summary>
        public int n_FeeType
        {
            get { return fn_FeeType; }
            set { SetPropertyValue<int>("n_FeeType", ref fn_FeeType, value); }
        }

        public FeeInWorkItem(Session session)
            : base(session)
        {
        }

        public FeeInWorkItem()
            : base(Session.DefaultSession)
        {
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}
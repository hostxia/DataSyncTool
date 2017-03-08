using DevExpress.Xpo;

namespace DataEntities.Case.Trademarks
{
    [Persistent("TTCase_Goods")]
    public class Goods : XPLiteObject
    {
        private readonly XPDelayedProperty fn_Sequence = new XPDelayedProperty();
        private readonly XPDelayedProperty fn_TrademarkClass = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_GoodsName = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_GroupCode = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_ItemCode = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_OtherName = new XPDelayedProperty();
        private int fn_ID;

        private ExtendedTrademark trademark;

        public Goods(Session session) : base(session)
        {
        }

        public Goods() : base(Session.DefaultSession)
        {
        }

        [Key(true)]
        public int n_ID
        {
            get { return fn_ID; }
            set { SetPropertyValue<int>("n_ID", ref fn_ID, value); }
        }

        [Association("Trademark-Goods")]
        [Persistent("n_CaseID")]
        public ExtendedTrademark TheTrademark
        {
            get { return trademark; }
            set { SetPropertyValue("n_CaseID", ref trademark, value); }
        }

        [Delayed("fs_GoodsName")]
        [Size(500)]
        public string s_GoodsName
        {
            get { return (string) fs_GoodsName.Value; }
            set { fs_GoodsName.Value = value; }
        }

        [Delayed("fs_OtherName")]
        [Size(500)]
        public string s_OtherName
        {
            get { return (string) fs_OtherName.Value; }
            set { fs_OtherName.Value = value; }
        }

        [Delayed("fs_GroupCode")]
        [Size(10)]
        public string s_GroupCode
        {
            get { return (string) fs_GroupCode.Value; }
            set { fs_GroupCode.Value = value; }
        }

        [Delayed("fs_ItemCode")]
        [Size(20)]
        public string s_ItemCode
        {
            get { return (string) fs_ItemCode.Value; }
            set { fs_ItemCode.Value = value; }
        }

        [Delayed("fn_Sequence")]
        public int n_Sequence
        {
            get
            {
                if (fn_Sequence.Value == null)
                {
                    return -1;
                }
                return (int) fn_Sequence.Value;
            }
            set { fn_Sequence.Value = value; }
        }

        [Delayed("fn_TrademarkClass")]
        public int n_TrademarkClass
        {
            get
            {
                if (fn_TrademarkClass.Value == null)
                {
                    return -1;
                }
                return (int) fn_TrademarkClass.Value;
            }
            set { fn_TrademarkClass.Value = value; }
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}
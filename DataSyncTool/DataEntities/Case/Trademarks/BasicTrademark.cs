using DataEntities.Config;
using DevExpress.Data.Filtering;
using DevExpress.Xpo;

namespace DataEntities.Case.Trademarks
{
    [MapInheritance(MapInheritanceType.OwnTable)]
    [Persistent("TTCase_Trademark")]
    public class BasicTrademark : BasicCase
    {
        private readonly XPDelayedProperty fimg_MainThumbnail = new XPDelayedProperty();
        private readonly XPDelayedProperty fn_MadBasicCountry = new XPDelayedProperty();
        private readonly XPDelayedProperty fn_TFlowNum = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_TrademarkClass = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_TrademarkType = new XPDelayedProperty();
        private string fs_OldSerial;
        private string fs_PriorityFileBackup;
        private LawInfo trademarkLawInfo;

        public BasicTrademark(Session session) : base(session)
        {
        }

        public BasicTrademark() : base(Session.DefaultSession)
        {
        }

        [Association("LawInfo-BasicTrademarks")]
        [Persistent("n_LawID")]
        public LawInfo TheLawInfo
        {
            get { return trademarkLawInfo; }
            set { SetPropertyValue("n_LawID", ref trademarkLawInfo, value); }
        }

        [Delayed("fn_TFlowNum")]
        public int n_TFlowNum
        {
            get
            {
                if (fn_TFlowNum.Value == null)
                {
                    return -1;
                }
                return (int) fn_TFlowNum.Value;
            }
            set { fn_TFlowNum.Value = value; }
        }

        [Delayed("fs_TrademarkType")]
        [Size(500)]
        public string s_TrademarkType
        {
            get { return (string) fs_TrademarkType.Value; }
            set { fs_TrademarkType.Value = value; }
        }

        [Delayed("fs_TrademarkClass")]
        [Size(200)]
        public string s_TrademarkClass
        {
            get { return (string) fs_TrademarkClass.Value; }
            set { fs_TrademarkClass.Value = value; }
        }

        [Delayed("fimg_MainThumbnail")]
        public byte[] img_MainThumbnail
        {
            get { return (byte[]) fimg_MainThumbnail.Value; }
            set { fimg_MainThumbnail.Value = value; }
        }

        [Delayed("fn_MadBasicCountry")]
        public int n_MadBasicCountry
        {
            get
            {
                if (fn_MadBasicCountry.Value == null)
                {
                    return -1;
                }
                return (int) fn_MadBasicCountry.Value;
            }
            set { fn_MadBasicCountry.Value = value; }
        }

        [Size(50)]
        public string s_OldSerial
        {
            get { return fs_OldSerial; }
            set { SetPropertyValue("s_OldSerial", ref fs_OldSerial, value); }
        }

        [Size(1)]
        public string s_PriorityFileBackup
        {
            get { return fs_PriorityFileBackup; }
            set { SetPropertyValue("s_PriorityFileBackup", ref fs_PriorityFileBackup, value); }
        }

        [Aggregated, Association("ExtendedTrademark-TMRenewalFee", typeof (TMRenewalFee))]
        public XPCollection TMRenewalFees
        {
            get { return GetCollection("TMRenewalFees"); }
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }

        #region 自定义方法

        /// #################################################################
        /// <summary>
        ///     获取商标种类名称。 例如：一般。集体等。
        ///     Kevin Wang(2010-10-11)
        /// </summary>
        /// <returns>商标种类名称，用分号间隔</returns>
        public string GetTMType()
        {
            string sTypeName = "";
            if (string.IsNullOrEmpty(s_TrademarkType))
            {
                return "";
            }
            string[] sTypeID = s_TrademarkType.Split(new[] {','});
            using (var uow = new UnitOfWork())
            {
                foreach (string sID in sTypeID)
                {
                    var xpc = new XPCollection(uow, typeof (CodePTCType))
                    {
                        Criteria = CriteriaOperator.Parse("n_ID =" + sID)
                    };
                    if (xpc.Count == 0) continue;
                    sTypeName += ((CodePTCType) xpc[0]).s_Name + ";";
                }
            }
            sTypeName = sTypeName.TrimEnd(new[] {';'});
            return sTypeName;
        }

        #endregion
    }
}
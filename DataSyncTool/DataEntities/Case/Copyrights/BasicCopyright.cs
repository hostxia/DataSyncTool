using System;
using DataEntities.Config;
using DevExpress.Data.Filtering;
using DevExpress.Xpo;

namespace DataEntities.Case.Copyrights
{
    [MapInheritance(MapInheritanceType.OwnTable)]
    [Persistent("TCCase_Copyright")]
    public class BasicCopyright : BasicCase
    {
        private DateTime fdt_Apply;
        private DateTime fdt_CreationEnd;
        private DateTime fdt_CreationStart;
        private DateTime fdt_FirstPublished;
        private DateTime fdt_Register;
        private DateTime fdt_Store;
        private int fn_CFlowNum;
        private int fn_CopyrightType;
        private int fn_Wordage;
        private string fs_AcceptNo;
        private string fs_ApplyAim;
        private string fs_CompleteType;
        private string fs_CopyrightStatus;
        private string fs_FirstPublishAddr;
        private string fs_Published;
        private string fs_ReceiptNo;
        private string fs_Register;
        private string fs_RightRange;

        private string fs_SignName;
        private string fs_StoreNo;

        public BasicCopyright(Session session) : base(session)
        {
        }

        public BasicCopyright() : base(Session.DefaultSession)
        {
        }

        public int n_CFlowNum
        {
            get { return fn_CFlowNum; }
            set { SetPropertyValue<int>("n_FlowNum", ref fn_CFlowNum, value); }
        }

        [Size(50)]
        public string s_SignName
        {
            get { return fs_SignName; }
            set { SetPropertyValue("s_SignName", ref fs_SignName, value); }
        }

        public int n_CopyrightType
        {
            get { return fn_CopyrightType; }
            set { SetPropertyValue<int>("n_CopyrightType", ref fn_CopyrightType, value); }
        }

        public DateTime dt_CreationStart
        {
            get { return fdt_CreationStart; }
            set { SetPropertyValue<DateTime>("dt_CreationStart", ref fdt_CreationStart, value); }
        }

        public DateTime dt_CreationEnd
        {
            get { return fdt_CreationEnd; }
            set { SetPropertyValue<DateTime>("dt_CreationEnd", ref fdt_CreationEnd, value); }
        }

        public int n_Wordage
        {
            get { return fn_Wordage; }
            set { SetPropertyValue<int>("n_Wordage", ref fn_Wordage, value); }
        }

        [Size(50)]
        public string s_CompleteType
        {
            get { return fs_CompleteType; }
            set { SetPropertyValue("s_CompleteType", ref fs_CompleteType, value); }
        }

        [Size(1)]
        public string s_Published
        {
            get { return fs_Published; }
            set { SetPropertyValue("s_Published", ref fs_Published, value); }
        }

        public DateTime dt_FirstPublished
        {
            get { return fdt_FirstPublished; }
            set { SetPropertyValue<DateTime>("dt_FirstPublished", ref fdt_FirstPublished, value); }
        }

        [Size(500)]
        public string s_FirstPublishAddr
        {
            get { return fs_FirstPublishAddr; }
            set { SetPropertyValue("s_FirstPublishAddr", ref fs_FirstPublishAddr, value); }
        }

        [Size(500)]
        public string s_ApplyAim
        {
            get { return fs_ApplyAim; }
            set { SetPropertyValue("s_ApplyAim", ref fs_ApplyAim, value); }
        }

        [Size(1000)]
        public string s_RightRange
        {
            get { return fs_RightRange; }
            set { SetPropertyValue("s_RightRange", ref fs_RightRange, value); }
        }

        public DateTime dt_Apply
        {
            get { return fdt_Apply; }
            set { SetPropertyValue<DateTime>("dt_Apply", ref fdt_Apply, value); }
        }

        [Size(50)]
        public string s_Register
        {
            get { return fs_Register; }
            set { SetPropertyValue("s_Register", ref fs_Register, value); }
        }

        public DateTime dt_Register
        {
            get { return fdt_Register; }
            set { SetPropertyValue<DateTime>("dt_Register", ref fdt_Register, value); }
        }

        [Size(50)]
        public string s_AcceptNo
        {
            get { return fs_AcceptNo; }
            set { SetPropertyValue("s_AcceptNo", ref fs_AcceptNo, value); }
        }

        [Size(50)]
        public string s_ReceiptNo
        {
            get { return fs_ReceiptNo; }
            set { SetPropertyValue("s_ReceiptNo", ref fs_ReceiptNo, value); }
        }

        [Size(50)]
        public string s_StoreNo
        {
            get { return fs_StoreNo; }
            set { SetPropertyValue("s_StoreNo", ref fs_StoreNo, value); }
        }

        public DateTime dt_Store
        {
            get { return fdt_Store; }
            set { SetPropertyValue<DateTime>("dt_Store", ref fdt_Store, value); }
        }

        [Size(50)]
        public string s_CopyrightStatus
        {
            get { return fs_CopyrightStatus; }
            set { SetPropertyValue("s_CopyrightStatus", ref fs_CopyrightStatus, value); }
        }

        [Aggregated, Association("Copyright-TortiousWare", typeof (CopyrightTortiousWare))]
        public XPCollection TortiousWare
        {
            get { return GetCollection("TortiousWare"); }
        }

        [Aggregated, Association("Copyright-CustomMemo", typeof (CopyrightCustomMemo))]
        public XPCollection CustomMemos
        {
            get { return GetCollection("CustomMemos"); }
        }

        #region 方法 

        /// #################################################################
        /// <summary>
        ///     获取业务类型名称
        ///     Kevin Wang(2010-08-30)
        /// </summary>
        /// <returns>业务类型名称</returns>
        public string GetCopyrightTypeName()
        {
            using (var uow = new UnitOfWork())
            {
                var xpc = new XPCollection(uow, typeof (CodeBusinessType))
                {
                    Criteria = CriteriaOperator.Parse("n_ID =" + n_BusinessTypeID)
                };
                return xpc.Count == 0 ? "" : ((CodeBusinessType) xpc[0]).s_Name;
            }
        }

        #endregion

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}
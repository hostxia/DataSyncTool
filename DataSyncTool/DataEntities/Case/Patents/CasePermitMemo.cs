using System;
using DevExpress.Xpo;

namespace DataEntities.Case.Patents
{
    [MapInheritance(MapInheritanceType.OwnTable)]
    [Persistent("TPCase_PermitMemo")]
    public class CasePermitMemo : ExtendedPatent
    {
        private DateTime fdt_ContractDate;
        private DateTime fdt_MemoBeginDate;
        private DateTime fdt_MemoDate;
        private DateTime fdt_MemoEndDate;
        private decimal fn_UseFee;
        private int fn_UseFeeCurrency;
        private string fs_FulFilAddr;
        private string fs_MemoNum;
        private string fs_Property;
        private string fs_Type;

        public CasePermitMemo(Session session) : base(session)
        {
        }

        public CasePermitMemo() : base(Session.DefaultSession)
        {
        }

        [Size(50)]
        public string s_MemoNum
        {
            get { return fs_MemoNum; }
            set { SetPropertyValue("s_MemoNum", ref fs_MemoNum, value); }
        }

        public DateTime dt_MemoDate
        {
            get { return fdt_MemoDate; }
            set { SetPropertyValue<DateTime>("dt_MemoDate", ref fdt_MemoDate, value); }
        }

        public DateTime dt_MemoBeginDate
        {
            get { return fdt_MemoBeginDate; }
            set { SetPropertyValue<DateTime>("dt_MemoBeginDate", ref fdt_MemoBeginDate, value); }
        }

        public DateTime dt_MemoEndDate
        {
            get { return fdt_MemoEndDate; }
            set { SetPropertyValue<DateTime>("dt_MemoEndDate", ref fdt_MemoEndDate, value); }
        }

        [Size(50)]
        public string s_Type
        {
            get { return fs_Type; }
            set { SetPropertyValue("s_Type", ref fs_Type, value); }
        }

        [Size(50)]
        public string s_FulFilAddr
        {
            get { return fs_FulFilAddr; }
            set { SetPropertyValue("s_FulFilAddr", ref fs_FulFilAddr, value); }
        }

        public DateTime dt_ContractDate
        {
            get { return fdt_ContractDate; }
            set { SetPropertyValue<DateTime>("dt_ContractDate", ref fdt_ContractDate, value); }
        }

        public decimal n_UseFee
        {
            get { return fn_UseFee; }
            set { SetPropertyValue<decimal>("n_UseFee", ref fn_UseFee, value); }
        }

        public int n_UseFeeCurrency
        {
            get { return fn_UseFeeCurrency; }
            set { SetPropertyValue<int>("n_UseFeeCurrency", ref fn_UseFeeCurrency, value); }
        }

        [Size(50)]
        public string s_Property
        {
            get { return fs_Property; }
            set { SetPropertyValue("s_Property", ref fs_Property, value); }
        }

        /// <summary>
        ///     许可的专利
        /// </summary>
        [Aggregated, Association("CasePermitMemo-PermitPatents", typeof (PermitPatent))]
        public XPCollection PermitPatents
        {
            get { return GetCollection("PermitPatents"); }
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }

        #region 自定义方法

        /// <summary>
        ///     获取合同备案中文格式的日期
        ///     Coder:zhangxinyuan (2010-11-15)
        /// </summary>
        public string ContractDateCN
        {
            get
            {
                if (dt_ContractDate == null)
                {
                    return null;
                }
                return dt_ContractDate.ToString("yyyy年MM月dd日");
            }
        }

        //public string GetContractDateEN()
        //{
        //    return ServerDate.GetDateInENFormat(dt_ContractDate);
        //}

        #endregion
    }
}
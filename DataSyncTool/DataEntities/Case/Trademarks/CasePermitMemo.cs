using System;
using DevExpress.Xpo;

namespace DataEntities.Case.Trademarks
{
    [MapInheritance(MapInheritanceType.OwnTable)]
    [Persistent("TTCase_PermitMemo")]
    public class CasePermitMemo : MultiPersonCase
    {
        private readonly XPDelayedProperty fdt_ContractDate = new XPDelayedProperty();
        private readonly XPDelayedProperty fdt_MemoBeginDate = new XPDelayedProperty();
        private readonly XPDelayedProperty fdt_MemoDate = new XPDelayedProperty();
        private readonly XPDelayedProperty fdt_MemoEndDate = new XPDelayedProperty();
        private readonly XPDelayedProperty fn_UseFee = new XPDelayedProperty();
        private readonly XPDelayedProperty fn_UseFeeCurrency = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_AppItem = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_FulFilAddr = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_MemoNum = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_RePermit = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_Type = new XPDelayedProperty();

        public CasePermitMemo(Session session) : base(session)
        {
        }

        public CasePermitMemo() : base(Session.DefaultSession)
        {
        }

        [Delayed("fs_MemoNum")]
        [Size(50)]
        public string s_MemoNum
        {
            get { return (string) fs_MemoNum.Value; }
            set { fs_MemoNum.Value = value; }
        }

        [Delayed("fdt_MemoDate")]
        public DateTime dt_MemoDate
        {
            get
            {
                if (fdt_MemoDate.Value == null)
                {
                    return DateTime.MinValue;
                }
                return (DateTime) fdt_MemoDate.Value;
            }
            set { fdt_MemoDate.Value = value; }
        }

        [Delayed("fdt_MemoBeginDate")]
        public DateTime dt_MemoBeginDate
        {
            get
            {
                if (fdt_MemoBeginDate.Value == null)
                {
                    return DateTime.MinValue;
                }
                return (DateTime) fdt_MemoBeginDate.Value;
            }
            set { fdt_MemoBeginDate.Value = value; }
        }

        [Delayed("fdt_MemoEndDate")]
        public DateTime dt_MemoEndDate
        {
            get
            {
                if (fdt_MemoEndDate.Value == null)
                {
                    return DateTime.MinValue;
                }
                return (DateTime) fdt_MemoEndDate.Value;
            }
            set { fdt_MemoEndDate.Value = value; }
        }

        [Delayed("fs_Type")]
        [Size(50)]
        public string s_Type
        {
            get { return (string) fs_Type.Value; }
            set { fs_Type.Value = value; }
        }

        [Delayed("fs_FulFilAddr")]
        [Size(200)]
        public string s_FulFilAddr
        {
            get { return (string) fs_FulFilAddr.Value; }
            set { fs_FulFilAddr.Value = value; }
        }

        [Delayed("fdt_ContractDate")]
        public DateTime dt_ContractDate
        {
            get
            {
                if (fdt_ContractDate.Value == null)
                {
                    return DateTime.MinValue;
                }
                return (DateTime) fdt_ContractDate.Value;
            }
            set { fdt_ContractDate.Value = value; }
        }

        [Delayed("fn_UseFee")]
        public decimal n_UseFee
        {
            get
            {
                if (fn_UseFee.Value == null)
                {
                    return -1;
                }
                return (decimal) fn_UseFee.Value;
            }
            set { fn_UseFee.Value = value; }
        }

        [Delayed("fn_UseFeeCurrency")]
        public int n_UseFeeCurrency
        {
            get
            {
                if (fn_UseFeeCurrency.Value == null)
                {
                    return -1;
                }
                return (int) fn_UseFeeCurrency.Value;
            }
            set { fn_UseFeeCurrency.Value = value; }
        }

        [Delayed("fs_AppItem")]
        [Size(500)]
        public string s_AppItem
        {
            get { return (string) fs_AppItem.Value; }
            set { fs_AppItem.Value = value; }
        }

        [Delayed("fs_RePermit")]
        public string s_RePermit
        {
            get { return (string) fs_RePermit.Value; }
            set { fs_RePermit.Value = value; }
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }

        #region 方法

        /// ############################################################
        /// <summary>
        ///     判断是否再许可
        ///     coder: Kevin Wang(2010-10-22)
        /// </summary>
        /// <returns>共同申请为true，否则为false</returns>
        public string RePermit()
        {
            int zPerson = 0;
            int sPerson = 0;
            foreach (OppositePerson oppositePerson in OppositePersons)
            {
                if (oppositePerson.s_Role == "0")
                    zPerson++;
                if (oppositePerson.s_Role == "1")
                    sPerson++;
            }

            return (zPerson > 1 || sPerson > 1).ToString().ToLower();
        }

        /// ############################################################
        /// <summary>
        ///     判断是否是非共同申请
        ///     coder: Kevin Wang(2010-09-10)
        /// </summary>
        /// <returns>非共同申请为true，否则为false</returns>
        public string NotRePermit()
        {
            int zPerson = 0;
            int sPerson = 0;
            foreach (OppositePerson oppositePerson in OppositePersons)
            {
                if (oppositePerson.s_Role == "0")
                    zPerson++;
                if (oppositePerson.s_Role == "1")
                    sPerson++;
            }
            return (!(zPerson > 1 || sPerson > 1)).ToString().ToLower();
        }

        #endregion
    }
}
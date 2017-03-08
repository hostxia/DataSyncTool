using System;
using DataEntities.Contact.Client;
using DevExpress.Xpo;

namespace DataEntities.Finance.Accounting
{
    [Persistent("T_CameMoney")]
    public class CameMoney : XPLiteObject
    {
        private readonly XPDelayedProperty fS_Lock = new XPDelayedProperty();
        private readonly XPDelayedProperty fS_Locker = new XPDelayedProperty();

        /// <summary>
        ///     到款日期
        /// </summary>
        private readonly XPDelayedProperty fdt_ArriveDate = new XPDelayedProperty();

        private readonly XPDelayedProperty fdt_CreateDate = new XPDelayedProperty();
        private readonly XPDelayedProperty fdt_EditDate = new XPDelayedProperty();

        /// <summary>
        ///     开票日期
        /// </summary>
        private readonly XPDelayedProperty fdt_ReceiptDate = new XPDelayedProperty();

        /// <summary>
        ///     转换成划拨币种的金额
        /// </summary>
        private readonly XPDelayedProperty fn_Amount = new XPDelayedProperty();

        /// <summary>
        ///     余额（到款转换后金额-划拨金额-客户钱包金额）
        /// </summary>
        private readonly XPDelayedProperty fn_Balance = new XPDelayedProperty();

        /// <summary>
        ///     手续费金额
        /// </summary>
        private readonly XPDelayedProperty fn_CommissionCharge = new XPDelayedProperty();

        /// <summary>
        ///     到款币种
        /// </summary>
        private readonly XPDelayedProperty fn_CurrUnitID = new XPDelayedProperty();

        /// <summary>
        ///     到款所属部门ID
        /// </summary>
        private readonly XPDelayedProperty fn_DeptID = new XPDelayedProperty();

        /// <summary>
        ///     到款币种和划拨币种的汇率
        /// </summary>
        private readonly XPDelayedProperty fn_ExRate = new XPDelayedProperty();

        /// <summary>
        ///     转入客户钱包金额
        /// </summary>
        private readonly XPDelayedProperty fn_MergeToAccount = new XPDelayedProperty();

        /// <summary>
        ///     划拨币种
        /// </summary>
        private readonly XPDelayedProperty fn_PayCurrencyID = new XPDelayedProperty();

        /// <summary>
        ///     到款金额（到款币种）
        /// </summary>
        private readonly XPDelayedProperty fn_TotalMoney = new XPDelayedProperty();

        /// <summary>
        ///     到款行名称
        /// </summary>
        private readonly XPDelayedProperty fs_Bank = new XPDelayedProperty();

        /// <summary>
        ///     到款原值中是否包含手续费（方便以后统计使用）
        /// </summary>
        private readonly XPDelayedProperty fs_CMHasCommissionCharge = new XPDelayedProperty();

        /// <summary>
        ///     汇单编号
        /// </summary>
        private readonly XPDelayedProperty fs_CMoneyNum = new XPDelayedProperty();

        /// <summary>
        ///     汇款方式
        /// </summary>
        private readonly XPDelayedProperty fs_CameMode = new XPDelayedProperty();

        private readonly XPDelayedProperty fs_Creator = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_Editor = new XPDelayedProperty();

        /// <summary>
        ///     发票电子件路径
        /// </summary>
        private readonly XPDelayedProperty fs_FileInvoicePath = new XPDelayedProperty();

        /// <summary>
        ///     协同空间字段，暂时不清楚作用
        /// </summary>
        private readonly XPDelayedProperty fs_Mark = new XPDelayedProperty();

        /// <summary>
        ///     备注
        /// </summary>
        private readonly XPDelayedProperty fs_Note = new XPDelayedProperty();

        /// <summary>
        ///     汇款人
        /// </summary>
        private readonly XPDelayedProperty fs_Payer = new XPDelayedProperty();

        /// <summary>
        ///     发票号
        /// </summary>
        private readonly XPDelayedProperty fs_Receipt = new XPDelayedProperty();

        private readonly XPDelayedProperty fs_Solified = new XPDelayedProperty();
        private Client client;

        private int fn_CMoneyID;
        private Contract.Contract tContract;

        public CameMoney(Session session) : base(session)
        {
        }

        public CameMoney() : base(Session.DefaultSession)
        {
        }

        [Key(true)]
        public int n_CMoneyID
        {
            get { return fn_CMoneyID; }
            set { SetPropertyValue<int>("n_CMoneyID", ref fn_CMoneyID, value); }
        }

        [Persistent("n_ClientID")]
        [Association("Client-CameMoney")]
        public Client TheClient
        {
            get { return client; }
            set { SetPropertyValue("n_ClientID", ref client, value); }
        }

        [Association("Contract-CameMoneys")]
        [Persistent("n_ContractID")]
        public Contract.Contract TContract
        {
            get { return tContract; }
            set { SetPropertyValue("n_ContractID", ref tContract, value); }
        }

        [Delayed("fs_CameMode")]
        [Size(30)]
        public string s_CameMode
        {
            get { return (string) fs_CameMode.Value; }
            set { fs_CameMode.Value = value; }
        }

        [Delayed("fs_CMoneyNum")]
        [Size(18)]
        public string s_CMoneyNum
        {
            get { return (string) fs_CMoneyNum.Value; }
            set { fs_CMoneyNum.Value = value; }
        }

        [Delayed("fdt_ArriveDate")]
        public DateTime dt_ArriveDate
        {
            get
            {
                if (fdt_ArriveDate.Value == null)
                {
                    return DateTime.MinValue;
                }
                return (DateTime) fdt_ArriveDate.Value;
            }
            set { fdt_ArriveDate.Value = value; }
        }

        [Delayed("fn_CurrUnitID")]
        public int n_CurrUnitID
        {
            get
            {
                if (fn_CurrUnitID.Value == null)
                {
                    return -1;
                }
                return (int) fn_CurrUnitID.Value;
            }
            set { fn_CurrUnitID.Value = value; }
        }

        [Delayed("fn_PayCurrencyID")]
        public int n_PayCurrencyID
        {
            get
            {
                if (fn_PayCurrencyID.Value == null)
                {
                    return -1;
                }
                return (int) fn_PayCurrencyID.Value;
            }
            set { fn_PayCurrencyID.Value = value; }
        }

        [Delayed("fn_TotalMoney")]
        public decimal n_TotalMoney
        {
            get
            {
                if (fn_TotalMoney.Value == null)
                {
                    return 0;
                }
                return (decimal) fn_TotalMoney.Value;
            }
            set { fn_TotalMoney.Value = value; }
        }

        [Delayed("fn_ExRate")]
        public decimal n_ExRate
        {
            get
            {
                if (fn_ExRate.Value == null)
                {
                    return 0;
                }
                return (decimal) fn_ExRate.Value;
            }
            set { fn_ExRate.Value = value; }
        }

        [Delayed("fn_Amount")]
        public decimal n_Amount
        {
            get
            {
                if (fn_Amount.Value == null)
                {
                    return 0;
                }
                return (decimal) fn_Amount.Value;
            }
            set { fn_Amount.Value = value; }
        }


        [Delayed("fs_Creator")]
        [Size(30)]
        public string s_Creator
        {
            get { return (string) fs_Creator.Value; }
            set { fs_Creator.Value = value; }
        }

        [Delayed("fdt_CreateDate")]
        public DateTime dt_CreateDate
        {
            get
            {
                if (fdt_CreateDate.Value == null)
                {
                    return DateTime.MinValue;
                }
                return (DateTime) fdt_CreateDate.Value;
            }
            set { fdt_CreateDate.Value = value; }
        }

        [Delayed("fn_DeptID")]
        public int n_DeptID
        {
            get
            {
                if (fn_DeptID.Value == null)
                {
                    return -1;
                }
                return (int) fn_DeptID.Value;
            }
            set { fn_DeptID.Value = value; }
        }

        [Delayed("fs_Mark")]
        [Size(50)]
        public string s_Mark
        {
            get { return (string) fs_Mark.Value; }
            set { fs_Mark.Value = value; }
        }

        [Delayed("fn_Balance")]
        public decimal n_Balance
        {
            get
            {
                if (fn_Balance.Value == null)
                {
                    return 0;
                }
                return (decimal) fn_Balance.Value;
            }
            set { fn_Balance.Value = value; }
        }

        [Delayed("fn_MergeToAccount")]
        public decimal n_MergeToAccount
        {
            get
            {
                if (fn_MergeToAccount.Value == null)
                {
                    return 0;
                }
                return (decimal) fn_MergeToAccount.Value;
            }
            set { fn_MergeToAccount.Value = value; }
        }

        [Delayed("fs_Note")]
        [Size(800)]
        public string s_Note
        {
            get { return (string) fs_Note.Value; }
            set { fs_Note.Value = value; }
        }

        [Delayed("fs_Bank")]
        [Size(50)]
        public string s_Bank
        {
            get { return (string) fs_Bank.Value; }
            set { fs_Bank.Value = value; }
        }

        [Delayed("fs_Editor")]
        [Size(10)]
        public string s_Editor
        {
            get { return (string) fs_Editor.Value; }
            set { fs_Editor.Value = value; }
        }

        [Delayed("fS_Lock")]
        [Size(1)]
        public string S_Lock
        {
            get { return (string) fS_Lock.Value; }
            set { fS_Lock.Value = value; }
        }

        [Delayed("fS_Locker")]
        [Size(50)]
        public string S_Locker
        {
            get { return (string) fS_Locker.Value; }
            set { fS_Locker.Value = value; }
        }

        [Delayed("fs_Receipt")]
        [Size(100)]
        public string s_Receipt
        {
            get { return (string) fs_Receipt.Value; }
            set { fs_Receipt.Value = value; }
        }

        [Delayed("fdt_ReceiptDate")]
        public DateTime dt_ReceiptDate
        {
            get
            {
                if (fdt_ReceiptDate.Value == null)
                {
                    return DateTime.MinValue;
                }
                return (DateTime) fdt_ReceiptDate.Value;
            }
            set { fdt_ReceiptDate.Value = value; }
        }

        [Delayed("fs_FileInvoicePath")]
        [Size(255)]
        public string s_FileInvoicePath
        {
            get { return (string) fs_FileInvoicePath.Value; }
            set { fs_FileInvoicePath.Value = value; }
        }

        [Delayed("fs_Payer")]
        [Size(100)]
        public string s_Payer
        {
            get { return (string) fs_Payer.Value; }
            set { fs_Payer.Value = value; }
        }


        [Delayed("fs_Solified")]
        [Size(50)]
        public string s_Solified
        {
            get { return (string) fs_Solified.Value; }
            set { fs_Solified.Value = value; }
        }

        [Delayed("fn_CommissionCharge")]
        public decimal n_CommissionCharge
        {
            get
            {
                if (fn_CommissionCharge.Value == null)
                {
                    return 0;
                }
                return (decimal) fn_CommissionCharge.Value;
            }
            set { fn_CommissionCharge.Value = value; }
        }

        [Delayed("fs_CMHasCommissionCharge")]
        [Size(100)]
        public string s_CMHasCommissionCharge
        {
            get { return (string) fs_CMHasCommissionCharge.Value; }
            set { fs_CMHasCommissionCharge.Value = value; }
        }

        [Delayed("fdt_EditDate")]
        public DateTime dt_EditDate
        {
            get
            {
                if (fdt_EditDate.Value == null)
                {
                    return DateTime.MinValue;
                }
                return (DateTime) fdt_EditDate.Value;
            }
            set { fdt_EditDate.Value = value; }
        }

        [Aggregated, Association("CameMoney-BillPay")]
        public XPCollection<BillPay> BillPayInfo
        {
            get { return GetCollection<BillPay>("BillPayInfo"); }
        }

        [NonPersistent]
        public string s_OldFilePath { get; set; }


        public decimal n_PayAmonut
        {
            get
            {
                decimal nPayAmount = 0;
                if (BillPayInfo.Count > 0)
                {
                    foreach (BillPay item in BillPayInfo)
                    {
                        nPayAmount += item.n_PayAmount;
                    }
                }
                return nPayAmount;
            }
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}
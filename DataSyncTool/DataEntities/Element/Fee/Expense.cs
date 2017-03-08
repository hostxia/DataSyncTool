using System;
using System.Linq;
using DataEntities.Case;
using DataEntities.Config;
using DataEntities.Config.Check.Config;
using DataEntities.Config.Check.Info;
using DevExpress.Data.Filtering;
using DevExpress.Xpo;

namespace DataEntities.Element.Fee
{
    [Persistent("T_Expense")]
    public class Expense : XPLiteObject
    {
        private DateTime fdt_CheckDate;
        private DateTime fdt_CreateDate;
        private DateTime fdt_EditDate;
        private DateTime fdt_PayDate;
        private DateTime fdt_ShldPayDate;
        private decimal fn_Account;
        private int fn_Checker;
        private int fn_Creator;
        private int fn_Currency;
        private int fn_ExpenseID;
        private int fn_LatestCheckInfoID;
        private int fn_MainCaseID;
        private int fn_Payer;
        private string fs_CheckStatus;
        private string fs_Content;
        private string fs_Creator;
        private string fs_Editor;
        private string fs_Name;
        private string fs_Object;
        private string fs_PayBillNo;
        private string fs_PayStatus;
        private string fs_Notes;

        //BasicCase basicCase;
        //[Persistent("n_CaseID")]
        //[Association("BasicCase-Expense")]
        //public BasicCase TheCase
        //{
        //    get { return basicCase; }
        //    set { SetPropertyValue<BasicCase>("n_CaseID", ref basicCase, value); }
        //}
        private string fs_Type;

        public Expense(Session session)
            : base(session)
        {
        }

        public Expense()
            : base(Session.DefaultSession)
        {
        }

        [Key(true)]
        public int n_ExpenseID
        {
            get { return fn_ExpenseID; }
            set { SetPropertyValue<int>("n_ExpenseID", ref fn_ExpenseID, value); }
        }

        [Size(50)]
        public string s_Type
        {
            get { return fs_Type; }
            set { SetPropertyValue("s_Type", ref fs_Type, value); }
        }

        [Size(200)]
        public string s_Name
        {
            get { return fs_Name; }
            set { SetPropertyValue("s_Name", ref fs_Name, value); }
        }

        [Size(200)]
        public string s_Object
        {
            get { return fs_Object; }
            set { SetPropertyValue("s_Object", ref fs_Object, value); }
        }

        [Size(800)]
        public string s_Content
        {
            get { return fs_Content; }
            set { SetPropertyValue("s_Content", ref fs_Content, value); }
        }

        public int n_Currency
        {
            get { return fn_Currency; }
            set { SetPropertyValue<int>("n_Currency", ref fn_Currency, value); }
        }

        public decimal n_Account
        {
            get { return fn_Account; }
            set { SetPropertyValue<decimal>("n_Account", ref fn_Account, value); }
        }

        public DateTime dt_ShldPayDate
        {
            get { return fdt_ShldPayDate; }
            set { SetPropertyValue<DateTime>("dt_ShldPayDate", ref fdt_ShldPayDate, value); }
        }

        public int n_Creator
        {
            get { return fn_Creator; }
            set { SetPropertyValue<int>("n_Creator", ref fn_Creator, value); }
        }

        [Size(2)]
        public string s_PayStatus
        {
            get { return fs_PayStatus; }
            set { SetPropertyValue("s_PayStatus", ref fs_PayStatus, value); }
        }

        [Size(50)]
        public string s_PayBillNo
        {
            get { return fs_PayBillNo; }
            set { SetPropertyValue("s_PayBillNo", ref fs_PayBillNo, value); }
        }

        public DateTime dt_PayDate
        {
            get { return fdt_PayDate; }
            set { SetPropertyValue<DateTime>("dt_PayDate", ref fdt_PayDate, value); }
        }

        public int n_Payer
        {
            get { return fn_Payer; }
            set { SetPropertyValue<int>("n_Payer", ref fn_Payer, value); }
        }

        [Size(1)]
        public string s_CheckStatus
        {
            get { return (string.IsNullOrEmpty(fs_CheckStatus) || string.Equals(fs_CheckStatus, "0")) ? "U" : fs_CheckStatus; }
            set { SetPropertyValue("s_CheckStatus", ref fs_CheckStatus, value); }
        }

        public DateTime dt_CheckDate
        {
            get { return fdt_CheckDate; }
            set { SetPropertyValue<DateTime>("dt_CheckDate", ref fdt_CheckDate, value); }
        }

        public int n_Checker
        {
            get { return fn_Checker; }
            set { SetPropertyValue<int>("n_Checker", ref fn_Checker, value); }
        }

        [Size(50)]
        public string s_Creator
        {
            get { return fs_Creator; }
            set { SetPropertyValue("s_Creator", ref fs_Creator, value); }
        }

        [Size(50)]
        public string s_Editor
        {
            get { return fs_Editor; }
            set { SetPropertyValue("s_Editor", ref fs_Editor, value); }
        }

        public DateTime dt_EditDate
        {
            get { return fdt_EditDate; }
            set { SetPropertyValue<DateTime>("dt_EditDate", ref fdt_EditDate, value); }
        }

        public DateTime dt_CreateDate
        {
            get { return fdt_CreateDate; }
            set { SetPropertyValue<DateTime>("dt_CreateDate", ref fdt_CreateDate, value); }
        }

        public int n_LatestCheckInfoID
        {
            get { return fn_LatestCheckInfoID; }
            set { SetPropertyValue<int>("n_LatestCheckInfoID", ref fn_LatestCheckInfoID, value); }
        }

        public int n_MainCaseID
        {
            get { return fn_MainCaseID; }
            set { SetPropertyValue<int>("n_MainCaseID", ref fn_MainCaseID, value); }
        }

        /// <summary>
        ///     获取模块审核状态排序的最大值（最大值默认为审核通过）
        /// </summary>
        [Delayed]
        public int MaxSeqID
        {
            get
            {
                var tempUow = new UnitOfWork();
                var codeModuleCheck =
                    tempUow.FindObject<CodeModuleCheck>(CriteriaOperator.Parse("s_Module = ? ", "Expense"));
                CodeModuleCheckStatuses re =
                    codeModuleCheck.CodeModuleCheckStatuses.OrderBy(s => s.n_Seq).Skip(1).FirstOrDefault();
                if (re != null)
                    return re.n_ID;
                return -1;
            }
        }

        [Aggregated, Association("Expense-ExpenseInCases", typeof(ExpenseInCase))]
        public XPCollection ExpenseInCases
        {
            get { return GetCollection("ExpenseInCases"); }
        }

        [Aggregated, Association("Expense-ExpenseChecks")]
        public XPCollection<ExpenseChecks> ExpenseChecks
        {
            get { return GetCollection<ExpenseChecks>("ExpenseChecks"); }
        }

        [Delayed]
        public string sPayerName
        {
            get
            {
                using (var uow = new UnitOfWork())
                {
                    var codeEmployee = uow.GetObjectByKey<CodeEmployee>(n_Payer);
                    return codeEmployee == null ? "" : codeEmployee.s_Name;
                }
                return "";
            }
        }

        /// <summary>
        ///     主案件
        /// </summary>
        [Delayed]
        public BasicCase TheMainCase
        {
            get
            {
                ExpenseInCase expenseCase =
                    ExpenseInCases.Cast<ExpenseInCase>().FirstOrDefault(f => f.s_IsMainCase == "Y");
                return expenseCase != null && expenseCase.TheCase != null ? expenseCase.TheCase : null;
            }
        }

        [Size(800)]
        public string s_Notes
        {
            get { return fs_Notes; }
            set { SetPropertyValue("s_Notes", ref fs_Notes, value); }
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}
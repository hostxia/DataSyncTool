using System;
using DataEntities.Contact.Demand;
using DevExpress.Xpo;

namespace DataEntities.Config
{
    [Persistent("TCode_Demand")]
    public class CodeDemand : XPLiteObject
    {
        private DateTime fdt_CreateDate;
        private DateTime fdt_EditDate;
        private DateTime fdt_ReceiptDate;
        private int fn_ID;
        private bool fn_IsActive;
        private string fs_Creator;
        private string fs_Description;
        private string fs_Editor;

        private string fs_IPType;
        private string fs_Title;
        private string fs_SysDemand;
        private int fn_DemandType;
        private string fs_Type;
        private string fs_DisplayPosition;
        private string fs_Assignor;
        private string fs_ReceiptMethod;
        private CodeDemandType CodeDemandTypes;
        public CodeDemand(Session session)
            : base(session)
        {
        }

        public CodeDemand()
            : base(Session.DefaultSession)
        {
        }

        [Key(true)]
        public int n_ID
        {
            get { return fn_ID; }
            set { SetPropertyValue<int>("n_ID", ref fn_ID, value); }
        }

        [Size(20)]
        public string s_IPType
        {
            get { return fs_IPType; }
            set { SetPropertyValue("s_IPType", ref fs_IPType, value); }
        }

        [Size(200)]
        public string s_Title
        {
            get { return fs_Title; }
            set { SetPropertyValue("s_Title", ref fs_Title, value); }
        }

        public string s_SysDemand
        {
            get { return fs_SysDemand; }
            set { SetPropertyValue("s_SysDemand", ref fs_SysDemand, value); }
        }
        [Size(500)]
        public string s_Description
        {
            get { return fs_Description; }
            set { SetPropertyValue("s_Description", ref fs_Description, value); }
        }

        public bool n_IsActive
        {
            get { return fn_IsActive; }
            set { SetPropertyValue("n_IsActive", ref fn_IsActive, value); }
        }

        [Size(50)]
        public string s_Creator
        {
            get { return fs_Creator; }
            set { SetPropertyValue("s_Creator", ref fs_Creator, value); }
        }

        public DateTime dt_CreateDate
        {
            get { return fdt_CreateDate; }
            set { SetPropertyValue<DateTime>("dt_CreateDate", ref fdt_CreateDate, value); }
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

        public DateTime dt_ReceiptDate
        {
            get { return fdt_ReceiptDate; }
            set { SetPropertyValue<DateTime>("dt_ReceiptDate", ref fdt_ReceiptDate, value); }
        }
        public string s_Assignor
        {
            get { return fs_Assignor; }
            set { SetPropertyValue<string>("s_Assignor", ref fs_Assignor, value); }
        }
        public string s_ReceiptMethod
        {
            get { return fs_ReceiptMethod; }
            set { SetPropertyValue<string>("s_ReceiptMethod", ref fs_ReceiptMethod, value); }
        }

        public int n_DemandType
        {
            get { return fn_DemandType; }
            set { SetPropertyValue<int>("n_DemandType", ref fn_DemandType, value); }
        }

        [NonPersistent]
        public string s_DisplayPosition
        {
            get { return TheCodeDemandType == null ? fs_DisplayPosition : TheCodeDemandType.s_CodeDemandPosition; }
            set { fs_DisplayPosition = value; }
        }
        [Aggregated, Association("CodeDemand-CodeOftenDemand")]
        public XPCollection<OftenDemand> OftenDemands
        {
            get { return GetCollection<OftenDemand>("OftenDemands"); }
        }

        [Association("CodeDemandType-CodeDemand")]
        [Persistent("n_CodeDemandTypeID")]
        public CodeDemandType TheCodeDemandType
        {
            get { return CodeDemandTypes; }
            set { SetPropertyValue("n_CodeDemandTypeID", ref CodeDemandTypes, value); }
        }
        [Aggregated, Association("CodeDemand-Demand")]
        public XPCollection<Demand> Demands
        {
            get { return GetCollection<Demand>("Demands"); }
        }
        [Aggregated, Association("CodeDemand-CodeSysTasksDemandCondition", typeof(CodeSysTasksDemandCondition))]
        public XPCollection CodeSysTasksDemandConditions
        {
            get { return GetCollection("CodeSysTasksDemandConditions"); }
        }
        //[Aggregated, Association("CodeDemand-CodeTaskChainInCodeDemand")]
        //public XPCollection<OldTFCodeTaskChainInCodeDemand> CodeTaskChainInCodeDemands
        //{
        //    get { return GetCollection<OldTFCodeTaskChainInCodeDemand>("CodeTaskChainInCodeDemands"); }
        //}
        //[Aggregated, Association("CodeDemand-CodeTaskInChainInCodeDemand")]
        //public XPCollection<OldTFCodeTaskFlowInCodeDemand> CodeTaskInChainInCodeDemands
        //{
        //    get { return GetCollection<OldTFCodeTaskFlowInCodeDemand>("CodeTaskInChainInCodeDemands"); }
        //}
        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}
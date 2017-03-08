using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.Xpo;

namespace DataEntities.Config
{
    [Persistent("TCode_OftenDemand")]
    public class OftenDemand : XPLiteObject
    {
        int fn_ID;
        [Key(true)]
        public int n_ID
        {
            get { return fn_ID; }
            set { SetPropertyValue<int>("n_ID", ref fn_ID, value); }
        }
        string fs_BusinessType;
        [Size(500)]
        public string s_BusinessType
        {
            get { return fs_BusinessType; }
            set { SetPropertyValue<string>("s_BusinessType", ref fs_BusinessType, value); }
        }

        string fs_PatentType;
        [Size(50)]
        public string s_PatentType
        {
            get { return fs_PatentType; }
            set { SetPropertyValue<string>("s_PatentType", ref fs_PatentType, value); }
        }

        string fs_TrademarkType;
        [Size(50)]
        public string s_TrademarkType
        {
            get { return fs_TrademarkType; }
            set { SetPropertyValue<string>("s_TrademarkType", ref fs_TrademarkType, value); }
        }

        string fs_ApplicationType;
        [Size(50)]
        public string s_ApplicationType
        {
            get { return fs_ApplicationType; }
            set { SetPropertyValue<string>("s_ApplicationType", ref fs_ApplicationType, value); }
        }

        private CodeDemand codeDemand;
        [Persistent("n_CodeDemandID")]
        [Association("CodeDemand-CodeOftenDemand")]
        public CodeDemand TheCodeDemand
        {
            get { return codeDemand; }
            set { SetPropertyValue("n_CodeDemandID", ref codeDemand, value); }
        }

        string fs_CaseType;
        [Size(2)]
        public string s_CaseType
        {
            get { return fs_CaseType; }
            set { SetPropertyValue<string>("s_CaseType", ref fs_CaseType, value); }
        }

        string fs_OftenCreator;
        [Size(50)]
        public string s_OftenCreator
        {
            get { return fs_OftenCreator; }
            set { SetPropertyValue<string>("s_OftenCreator", ref fs_OftenCreator, value); }
        }
        DateTime fdt_OftenCreateDate;
        public DateTime dt_OftenCreateDate
        {
            get { return fdt_OftenCreateDate; }
            set { SetPropertyValue<DateTime>("dt_OftenCreateDate", ref fdt_OftenCreateDate, value); }
        }
        string fs_OftenEditor;
        [Size(50)]
        public string s_OftenEditor
        {
            get { return fs_OftenEditor; }
            set { SetPropertyValue<string>("s_OftenEditor", ref fs_OftenEditor, value); }
        }
        DateTime fdt_OftenEditDate;
        public DateTime dt_OftenEditDate
        {
            get { return fdt_OftenEditDate; }
            set { SetPropertyValue<DateTime>("dt_OftenEditDate", ref fdt_OftenEditDate, value); }
        }

        string fs_Process;
        [Size(500)]
        public string s_Process
        {
            get { return fs_Process; }
            set { SetPropertyValue<string>("s_Process", ref fs_Process, value); }
        }


        [NonPersistent]
        public bool Check
        {
            get;
            set;
        }

        public OftenDemand(Session session) : base(session) { }
        public OftenDemand() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }
}

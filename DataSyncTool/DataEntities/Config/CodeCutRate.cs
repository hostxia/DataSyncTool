using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.Xpo;

namespace DataEntities.Config
{
    [Persistent("TCode_CutRate")]
    public class CodeCutRate : XPLiteObject
    {
        private int fn_ID;
        [Key(true)]
        public int n_ID
        {
            get { return fn_ID; }
            set { SetPropertyValue<int>("n_ID", ref fn_ID, value); }
        }

        private int fn_CutRateScale;
        public int n_CutRateScale
        {
            get { return fn_CutRateScale; }
            set { SetPropertyValue<int>("n_CutRateScale", ref fn_CutRateScale, value); }
        }

        private string fs_CutRateType;
        [Size(100)]
        public string s_CutRateType
        {
            get { return fs_CutRateType; }
            set { SetPropertyValue("s_CutRateType", ref fs_CutRateType, value); }
        }

        private string fs_AnnualCutRate;
        [Size(2)]
        public string s_AnnualCutRate
        {
            get { return fs_AnnualCutRate; }
            set { SetPropertyValue("s_AnnualCutRate", ref fs_AnnualCutRate, value); }
        }

        private string fs_IPType;
        [Size(2)]
        public string s_IPType
        {
            get { return fs_IPType; }
            set { SetPropertyValue("s_IPType", ref fs_IPType, value); }
        }

        private DateTime fdt_EditDate;
        public DateTime dt_EditDate
        {
            get { return fdt_EditDate; }
            set { SetPropertyValue<DateTime>("dt_EditDate", ref fdt_EditDate, value); }
        }

        public string fs_Editor;
        [Size(50)]
        public string s_Editor
        {
            get { return fs_Editor; }
            set { SetPropertyValue("s_Editor", ref fs_Editor, value); }
        }

        [Aggregated, Association("CodeCutRate_CodeCutRateProject", typeof(CodeCutRateProject))]
        public XPCollection CodeCutRateProjects
        {
            get { return GetCollection("CodeCutRateProjects"); }
        }


        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }

        public CodeCutRate(Session session)
            : base(session)
        {
        }

        public CodeCutRate()
            : base(Session.DefaultSession)
        {
        }

    }
}

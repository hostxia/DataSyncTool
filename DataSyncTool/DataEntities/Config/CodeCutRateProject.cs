using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.Xpo;

namespace DataEntities.Config
{
    [Persistent("TCode_CutRateProject")]
    public class CodeCutRateProject : XPLiteObject
    {
        private int fn_ID;

        [Key(true)]
        public int n_ID
        {
            get { return fn_ID; }
            set { SetPropertyValue<int>("n_ID", ref fn_ID, value); }
        }

        //private int fn_CutRateID;
        //public int n_CutRateID
        //{
        //    get { return fn_CutRateID; }
        //    set { SetPropertyValue<int>("n_CutRateID", ref fn_CutRateID, value); }
        //}
        private CodeCutRate codeCutRate;
        [Association("CodeCutRate_CodeCutRateProject")]
        [Persistent("n_CutRateID")]
        public CodeCutRate TheCodeCutRate
        {
            get { return codeCutRate; }
            set { SetPropertyValue("n_CutRateID", ref codeCutRate, value); }
        }

        private int fn_CodeFeeID;

        public int n_CodeFeeID
        {
            get { return fn_CodeFeeID; }
            set { SetPropertyValue<int>("n_CodeFeeID", ref fn_CodeFeeID, value); }
        }

        private int fn_Scale;

        public int n_Scale
        {
            get { return fn_Scale; }
            set { SetPropertyValue<int>("n_Scale", ref fn_Scale, value); }
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }

        public CodeCutRateProject(Session session)
            : base(session)
        {
        }

        public CodeCutRateProject()
            : base(Session.DefaultSession)
        {
        }
    }
}
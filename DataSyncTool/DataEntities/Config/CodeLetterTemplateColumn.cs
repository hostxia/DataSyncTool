using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.Xpo;

namespace DataEntities.Config
{
    [Persistent("TCode_LetterTemplateColumn")]
    public class CodeLetterTemplateColumn : XPLiteObject
    {
        private CodeLetterTemplate codeLetterTemplate; 
        private int fn_ID;
        private int fn_OrderNum;
        private decimal fn_Width;

        private string fs_ColumnName;

        public CodeLetterTemplateColumn(Session session) : base(session)
        {
        }

        public CodeLetterTemplateColumn()
            : base(Session.DefaultSession)
        {
        }

        [Key(true)]
        public int n_ID
        {
            get { return fn_ID; }
            set { SetPropertyValue<int>("n_ID", ref fn_ID, value); }
        }

        [Size(50)]
        public string s_ColumnName
        {
            get { return fs_ColumnName; }
            set { SetPropertyValue("s_ColumnName", ref fs_ColumnName, value); }
        }

        [Association("CodeLetterTemplate_Columns")]
        [Persistent("n_LetterTemplateID")]
        public CodeLetterTemplate TheCodeLetterTemplate
        {
            get { return codeLetterTemplate; }
            set { SetPropertyValue("n_LetterTemplateID", ref codeLetterTemplate, value); }
        }

        //int fn_BillTemplateID;
        //public int n_BillTemplateID
        //{
        //    get { return fn_BillTemplateID; }
        //    set { SetPropertyValue<int>("n_BillTemplateID", ref fn_BillTemplateID, value); }
        //}

        public decimal n_Width
        {
            get { return fn_Width; }
            set { SetPropertyValue<decimal>("n_Width", ref fn_Width, value); }
        }

        public int n_OrderNum
        {
            get { return fn_OrderNum; }
            set { SetPropertyValue<int>("n_OrderNum", ref fn_OrderNum, value); }
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}
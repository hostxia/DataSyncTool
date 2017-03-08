using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.Xpo;

namespace DataEntities.Config
{
    [Persistent("TCode_DemandType")]
    public class CodeDemandType : XPLiteObject
    {
        private DateTime fdt_CreateDate;
        private int fn_ID;
        private string fs_CodeDemandType;
        private string fs_CodeDemandPosition;
        private string fs_Creator;
        public CodeDemandType(Session session)
            : base(session)
        {
        }

        public CodeDemandType()
            : base(Session.DefaultSession)
        {
        }
        [Key(true)]
        public int n_ID
        {
            get { return fn_ID; }
            set { SetPropertyValue<int>("n_ID", ref fn_ID, value); }
        }

        [Size(100)]
        public string s_CodeDemandType
        {
            get { return fs_CodeDemandType; }
            set { SetPropertyValue("s_CodeDemandType", ref fs_CodeDemandType, value); }
        }
        public string s_CodeDemandPosition
        {
            get { return fs_CodeDemandPosition; }
            set { SetPropertyValue("s_CodeDemandPosition", ref fs_CodeDemandPosition, value); }
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
        [Aggregated, Association("CodeDemandType-CodeDemand", typeof(CodeDemand))]
        public XPCollection CodeDemands
        {
            get { return GetCollection("CodeDemands"); }
        }
    }
}

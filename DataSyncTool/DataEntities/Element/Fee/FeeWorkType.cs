using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.Xpo;

namespace DataEntities.Element.Fee
{
    [Persistent("T_FeeWorkType")]
    public class FeeWorkType : XPLiteObject
    {
        private int fn_ID;
        private string fs_Name;
        public FeeWorkType(Session session)
            : base(session)
        {
        }

        public FeeWorkType()
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
        public string s_Name
        {
            get { return fs_Name; }
            set { SetPropertyValue<string>("s_Name", ref fs_Name, value); }

        }
    }
}

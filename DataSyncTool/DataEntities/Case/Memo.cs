using System;
using DevExpress.Xpo;

namespace DataEntities.Case
{
    [Persistent("TCase_Memo")]
    public class CaseMemo : XPLiteObject
    {
        private readonly XPDelayedProperty fdt_CreateDate = new XPDelayedProperty();
        private readonly XPDelayedProperty fdt_EditDate = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_Memo = new XPDelayedProperty();
        private readonly XPDelayedProperty fs_Type = new XPDelayedProperty();
        private BasicCase basicCase;
        private int fn_ID;

        public CaseMemo(Session session) : base(session)
        {
        }

        public CaseMemo() : base(Session.DefaultSession)
        {
        }

        [Key(true)]
        public int n_ID
        {
            get { return fn_ID; }
            set { SetPropertyValue<int>("n_ID", ref fn_ID, value); }
        }

        [Association("Case-Memos")]
        [Persistent("n_CaseID")]
        public BasicCase BasicCase
        {
            get { return basicCase; }
            set { SetPropertyValue("n_CaseID", ref basicCase, value); }
        }

        [Delayed("fs_Memo")]
        [Size(SizeAttribute.Unlimited)]
        public string s_Memo
        {
            get { return (string) fs_Memo.Value; }
            set { fs_Memo.Value = value; }
        }

        [Delayed("fs_Type")]
        [Size(50)]
        public string s_Type
        {
            get { return (string) fs_Type.Value; }
            set { fs_Type.Value = value; }
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

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}
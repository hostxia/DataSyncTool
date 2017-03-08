using System;
using DevExpress.Xpo;

namespace DataEntities.Config
{
    [Persistent("TCode_Goods")]
    public class CodeGoods : XPLiteObject
    {
        private DateTime fdt_CreateDate;
        private DateTime fdt_EditDate;
        private int fn_ClassID;
        private int fn_ID;
        private string fs_GroupCode;
        private string fs_ItemCode;
        private string fs_Name;
        private string fs_OtherName;

        public CodeGoods(Session session) : base(session)
        {
        }

        public CodeGoods() : base(Session.DefaultSession)
        {
        }

        [Key(true)]
        public int n_ID
        {
            get { return fn_ID; }
            set { SetPropertyValue<int>("n_ID", ref fn_ID, value); }
        }

        public int n_ClassID
        {
            get { return fn_ClassID; }
            set { SetPropertyValue<int>("n_ClassID", ref fn_ClassID, value); }
        }

        [Size(200)]
        public string s_Name
        {
            get { return fs_Name; }
            set { SetPropertyValue("s_Name", ref fs_Name, value); }
        }

        [Size(200)]
        public string s_OtherName
        {
            get { return fs_OtherName; }
            set { SetPropertyValue("s_OtherName", ref fs_OtherName, value); }
        }

        [Size(20)]
        public string s_ItemCode
        {
            get { return fs_ItemCode; }
            set { SetPropertyValue("s_ItemCode", ref fs_ItemCode, value); }
        }

        [Size(50)]
        public string s_GroupCode
        {
            get { return fs_GroupCode; }
            set { SetPropertyValue("s_GroupCode", ref fs_GroupCode, value); }
        }

        public DateTime dt_CreateDate
        {
            get { return fdt_CreateDate; }
            set { SetPropertyValue<DateTime>("dt_CreateDate", ref fdt_CreateDate, value); }
        }

        public DateTime dt_EditDate
        {
            get { return fdt_EditDate; }
            set { SetPropertyValue<DateTime>("dt_EditDate", ref fdt_EditDate, value); }
        }

        [NonPersistent]
        public bool Check { get; set; }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}
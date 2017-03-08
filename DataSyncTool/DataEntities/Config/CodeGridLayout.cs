using System;
using DevExpress.Xpo;

namespace DataEntities.Config
{
    [Persistent("TCode_GridLayout")]
    public class CodeGridLayout : XPLiteObject
    {
        private DateTime fdt_CreateDate;
        private DateTime fdt_EditDate;
        private int fn_ID;
        private string fs_IsSystemLayout;
        private string fs_LayoutName;
        private string fs_LayoutXml;

        private string fs_ModuleName;

        public CodeGridLayout(Session session) : base(session)
        {
        }

        public CodeGridLayout() : base(Session.DefaultSession)
        {
        }

        [Key(true)]
        public int n_ID
        {
            get { return fn_ID; }
            set { SetPropertyValue<int>("n_ID", ref fn_ID, value); }
        }

        [Size(20)]
        public string s_ModuleName
        {
            get { return fs_ModuleName; }
            set { SetPropertyValue("s_ModuleName", ref fs_ModuleName, value); }
        }

        [Size(200)]
        public string s_LayoutName
        {
            get { return fs_LayoutName; }
            set { SetPropertyValue("s_LayoutName", ref fs_LayoutName, value); }
        }

        [Size(SizeAttribute.Unlimited)]
        public string s_LayoutXml
        {
            get { return fs_LayoutXml; }
            set { SetPropertyValue("s_LayoutXml", ref fs_LayoutXml, value); }
        }

        [Size(1)]
        public string s_IsSystemLayout
        {
            get { return fs_IsSystemLayout; }
            set { SetPropertyValue("s_IsSystemLayout", ref fs_IsSystemLayout, value); }
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

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}
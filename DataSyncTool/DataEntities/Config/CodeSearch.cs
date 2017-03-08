using System;
using DevExpress.Xpo;

namespace DataEntities.Config
{
    [Persistent("TCode_Search")]
    public class CodeSearch : XPLiteObject
    {
        private DateTime fdt_CreateDate;
        private DateTime fdt_EditDate;
        private int fn_SearchID;
        private int fn_Sequence;
        private string fs_Description;
        private string fs_IsSystemSearch;
        private string fs_ModuleName;
        private string fs_OrderBy;
        private string fs_IPType;
        private string fs_SearchCondition;
        private string fs_SearchName;

        public CodeSearch(Session session) : base(session)
        {
        }

        public CodeSearch() : base(Session.DefaultSession)
        {
        }

        [Key(true)]
        public int n_SearchID
        {
            get { return fn_SearchID; }
            set { SetPropertyValue<int>("n_SearchID", ref fn_SearchID, value); }
        }

        [Size(1000)]
        public string s_SearchCondition
        {
            get { return fs_SearchCondition; }
            set { SetPropertyValue("s_SearchCondition", ref fs_SearchCondition, value); }
        }

        [Size(200)]
        public string s_OrderBy
        {
            get { return fs_OrderBy; }
            set { SetPropertyValue("s_OrderBy", ref fs_OrderBy, value); }
        }
        
        public string s_IPType
        {
            get { return fs_IPType; }
            set { SetPropertyValue("s_IPType", ref fs_IPType, value); }
        }
        [Size(200)]
        public string s_SearchName
        {
            get { return fs_SearchName; }
            set { SetPropertyValue("s_SearchName", ref fs_SearchName, value); }
        }

        public string s_IsSystemSearch
        {
            get { return fs_IsSystemSearch; }
            set { SetPropertyValue("s_IsSystemSearch", ref fs_IsSystemSearch, value); }
        }

        public string s_ModuleName
        {
            get { return fs_ModuleName; }
            set { SetPropertyValue("s_ModuleName", ref fs_ModuleName, value); }
        }

        public int n_Sequence
        {
            get { return fn_Sequence; }
            set { SetPropertyValue<int>("n_Sequence", ref fn_Sequence, value); }
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

        public string s_SearchID
        {
            get { return fn_SearchID.ToString(); }
        }

        [Size(800)]
        public string s_Description
        {
            get { return fs_Description; }
            set { SetPropertyValue("s_Description", ref fs_Description, value); }
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using DataEntities.Config;
using DataEntities.TaskFlowBase;
using DevExpress.Data.Filtering;
using DevExpress.Xpo;

namespace DataEntities.ConfigOrganization
{
    [Persistent("TCode_Organization")]
    public class CodeOrganization : XPLiteObjectUser
    {
        int fn_ID;
        [Key(true)]
        public int n_ID
        {
            get { return fn_ID; }
            set { SetPropertyValue<int>("n_ID", ref fn_ID, value); }
        }

        int fn_ParentID;
        public int n_ParentID
        {
            get { return fn_ParentID; }
            set { SetPropertyValue<int>("n_ParentID", ref fn_ParentID, value); }
        }

        int fn_Sequence;
        public int n_Sequence
        {
            get { return fn_Sequence; }
            set { SetPropertyValue<int>("n_Sequence", ref fn_Sequence, value); }
        }

        int fn_TypeID;
        public int n_TypeID
        {
            get { return fn_TypeID; }
            set { SetPropertyValue<int>("n_TypeID", ref fn_TypeID, value); }
        }

        int fn_ImageIndex;
        public int n_ImageIndex
        {
            get { return fn_ImageIndex; }
            set { SetPropertyValue<int>("n_ImageIndex", ref fn_ImageIndex, value); }
        }

        string fs_RelatedObjectType;
        [Size(50)]
        public string s_RelatedObjectType
        {
            get { return fs_RelatedObjectType; }
            set { SetPropertyValue<string>("s_RelatedObjectType", ref fs_RelatedObjectType, value); }
        }

        int fn_RelatedObjectID;
        public int n_RelatedObjectID
        {
            get { return fn_RelatedObjectID; }
            set { SetPropertyValue<int>("n_RelatedObjectID", ref fn_RelatedObjectID, value); }
        }

        string fs_Name;
        [Size(100)]
        public string s_Name
        {
            get { return fs_Name; }
            set { SetPropertyValue<string>("s_Name", ref fs_Name, value); }
        }

        string fs_ShortName;
        [Size(100)]
        public string s_ShortName
        {
            get { return fs_ShortName; }
            set { SetPropertyValue<string>("s_ShortName", ref fs_ShortName, value); }
        }

        string fs_Code;
        [Size(100)]
        public string s_Code
        {
            get { return fs_Code; }
            set { SetPropertyValue<string>("s_Code", ref fs_Code, value); }
        }

        string fs_Description;
        [Size(1000)]
        public string s_Description
        {
            get { return fs_Description; }
            set { SetPropertyValue<string>("s_Description", ref fs_Description, value); }
        }

        int fn_Creator;
        public int n_Creator
        {
            get { return fn_Creator; }
            set { SetPropertyValue<int>("n_Creator", ref fn_Creator, value); }
        }

        DateTime fdt_CreateTime;
        public DateTime dt_CreateTime
        {
            get { return fdt_CreateTime; }
            set { SetPropertyValue<DateTime>("dt_CreateTime", ref fdt_CreateTime, value); }
        }

        int fn_Editor;
        public int n_Editor
        {
            get { return fn_Editor; }
            set { SetPropertyValue<int>("n_Editor", ref fn_Editor, value); }
        }

        DateTime fdt_EditTime;
        public DateTime dt_EditTime
        {
            get { return fdt_EditTime; }
            set { SetPropertyValue<DateTime>("dt_EditTime", ref fdt_EditTime, value); }
        }

        #region Method

        public CodeOrganization GetTheParentCodeOrganization()
        {
            return TheUow.GetObjectByKey<CodeOrganization>(n_ParentID);
        }

        public object GetTheRelatedObject()
        {
            if (s_RelatedObjectType == "Common") return TheUow.GetObjectByKey<CodeOrganizationCommon>(n_RelatedObjectID);
            if (s_RelatedObjectType == "Agency") return TheUow.GetObjectByKey<CodeAgencyInfo>(n_RelatedObjectID);
            return null;
        }

        public List<CodeOrganization> GetListChildCodeOrganizations()
        {
            var xpcChildCodeOrganizations = new XPCollection<CodeOrganization>(TheUow, CriteriaOperator.Parse("n_ParentID = ?", n_ID));
            return xpcChildCodeOrganizations.ToList();
        }

        public List<CodeOrganization> GetListClusterCodeOrganizations()
        {
            var listClusterCodeOrganizations = new List<CodeOrganization>();
            GetChildCodeOrganizations(ref listClusterCodeOrganizations, this);
            return listClusterCodeOrganizations;
        }

        private void GetChildCodeOrganizations(ref List<CodeOrganization> listCodeOrganizations, CodeOrganization codeOrganization)
        {
            var listChildCodeOrganizations = codeOrganization.GetListChildCodeOrganizations();
            foreach (var childCodeOrganization in listChildCodeOrganizations)
            {
                GetChildCodeOrganizations(ref listCodeOrganizations, childCodeOrganization);
                listCodeOrganizations.Add(childCodeOrganization);
            }
        }

        #endregion

        public CodeOrganization(Session session) : base(session) { }
    }
}
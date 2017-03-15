using System;
using System.Collections.Generic;
using System.Linq;
using DataEntities.Element.Files;
using DataEntities.TaskFlowBase;
using DataEntities.TaskFlowConfig;
using DevExpress.Data.Filtering;
using DevExpress.Xpo;

namespace DataEntities.TaskFlowData
{
    [Persistent("TF_TaskChain")]
    public class TFTaskChain : XPLiteObjectUser
    {
        Guid fg_ID;
        [Key(false)]
        public Guid g_ID
        {
            get { return fg_ID; }
            set { SetPropertyValue<Guid>("g_ID", ref fg_ID, value); }
        }

        int fn_Num;
        public int n_Num
        {
            get
            {
                if (fn_Num > 0) return fn_Num;
                var sNum = TheUow.ExecuteQuery(string.Format(@"SELECT n_Num FROM dbo.TF_TaskChain WHERE g_ID = '{0}'", g_ID)).ResultSet[0].Rows.Select(r => r.Values[0]).FirstOrDefault();
                fn_Num = sNum == null ? 0 : Convert.ToInt32(sNum);
                return fn_Num;
            }
        }

        Guid fg_CodeTaskChainGuid;
        [NullValue(typeof(Guid), "00000000-0000-0000-0000-000000000000")]
        public Guid g_CodeTaskChainGuid
        {
            get { return fg_CodeTaskChainGuid; }
            set { SetPropertyValue<Guid>("g_CodeTaskChainGuid", ref fg_CodeTaskChainGuid, value); }
        }

        string fs_Name;
        [Size(100)]
        public string s_Name
        {
            get { return fs_Name; }
            set { SetPropertyValue<string>("s_Name", ref fs_Name, value); }
        }

        string fs_Description;
        [Size(SizeAttribute.Unlimited)]
        public string s_Description
        {
            get { return fs_Description; }
            set { SetPropertyValue<string>("s_Description", ref fs_Description, value); }
        }

        string fs_State;
        [Size(1)]
        public string s_State
        {
            get { return fs_State; }
            set { SetPropertyValue<string>("s_State", ref fs_State, value); }
        }

        int? fn_TaskChainTypeID;
        public int? n_TaskChainTypeID
        {
            get { return fn_TaskChainTypeID; }
            set { SetPropertyValue<int?>("n_TaskChainTypeID", ref fn_TaskChainTypeID, value); }
        }

        string fs_TriggerType;
        [Size(100)]
        public string s_TriggerType
        {
            get { return fs_TriggerType; }
            set { SetPropertyValue<string>("s_TriggerType", ref fs_TriggerType, value); }
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

        string fs_RelatedInfo1;
        [Size(450)]
        public string s_RelatedInfo1
        {
            get { return fs_RelatedInfo1; }
            set { SetPropertyValue<string>("s_RelatedInfo1", ref fs_RelatedInfo1, value); }
        }

        string fs_RelatedInfo2;
        [Size(450)]
        public string s_RelatedInfo2
        {
            get { return fs_RelatedInfo2; }
            set { SetPropertyValue<string>("s_RelatedInfo2", ref fs_RelatedInfo2, value); }
        }

        int? fn_Creator;
        public int? n_Creator
        {
            get { return fn_Creator; }
            set { SetPropertyValue<int?>("n_Creator", ref fn_Creator, value); }
        }

        DateTime? fdt_CreateTime;
        public DateTime? dt_CreateTime
        {
            get { return fdt_CreateTime; }
            set { SetPropertyValue<DateTime?>("dt_CreateTime", ref fdt_CreateTime, value); }
        }

        int? fn_Editor;
        public int? n_Editor
        {
            get { return fn_Editor; }
            set { SetPropertyValue<int?>("n_Editor", ref fn_Editor, value); }
        }

        DateTime? fdt_EditTime;
        public DateTime? dt_EditTime
        {
            get { return fdt_EditTime; }
            set { SetPropertyValue<DateTime?>("dt_EditTime", ref fdt_EditTime, value); }
        }

        #region Method

        public TFCodeTaskChain GetTheCodeTaskChain()
        {
            var codeTaskChain = TheUow.GetObjectByKey<TFCodeTaskChain>(g_CodeTaskChainGuid);
            if (codeTaskChain != null) return codeTaskChain;
            var belongNode = GetTheBelongNode();
            if (belongNode == null) return codeTaskChain;
            var codeNode = belongNode.GetTheCodeNode();
            if (codeNode != null) codeTaskChain = codeNode.GetTheOwnCodeTaskChain();
            return codeTaskChain;
        }

        public TFNode GetTheBelongNode()
        {
            CriteriaOperator criteriaOperator = CriteriaOperator.Parse("s_Type = 'C' And g_OwnTaskChainGuid = ?", g_ID);
            var node = TheUow.FindObject<TFNode>(criteriaOperator);
            if (node != null) return node;
            node = TheUow.GetObjectsInTransaction(TheUow.GetClassInfo<TFNode>(), criteriaOperator, false).Cast<TFNode>().FirstOrDefault();
            return node;
        }

        public TFTaskChain GetTheParentTaskChain()
        {
            var belongNode = GetTheBelongNode();
            return belongNode == null ? null : belongNode.GetTheTaskChain();
        }

        public TFTaskChain GetTheTopTaskChain()
        {
            var listClusterTaskChains = GetListClusterTaskChains();
            return listClusterTaskChains.FirstOrDefault(f => f.g_CodeTaskChainGuid != Guid.Empty);
        }

        public TFNode GetTheStartNode()
        {
            return TheUow.FindObject<TFNode>(CriteriaOperator.Parse("g_TaskChainGuid = ? And s_Type = 'S'", g_ID));
        }

        public List<TFNode> GetListNodes()
        {
            var xpcNodes = new XPCollection<TFNode>(TheUow, CriteriaOperator.Parse("g_TaskChainGuid = ?", g_ID));
            return xpcNodes.ToList();
        }

        public List<TFNode> GetListNodesInTransaction()
        {
            return TheUow.GetObjectsInTransaction(TheUow.GetClassInfo<TFNode>(), CriteriaOperator.Parse("g_TaskChainGuid = ?", g_ID), false).Cast<TFNode>().ToList();
        }

        public List<TFTaskParameter> GetListTaskParameters(string paraType = "")
        {
            var criteriaOperator = string.IsNullOrWhiteSpace(paraType) ? CriteriaOperator.Parse("g_TaskChainID = ?", g_ID) : CriteriaOperator.Parse("g_TaskChainID = ? and s_ParaType = ?", g_ID, paraType);
            return new XPCollection<TFTaskParameter>(TheUow, criteriaOperator).ToList();
        }

        public object GetTheRelatedObject()
        {
            if (s_RelatedObjectType == "Case") return TheUow.GetObjectByKey<Case.BasicCase>(n_RelatedObjectID);
            if (s_RelatedObjectType == "CameFileOfficial") return TheUow.GetObjectByKey<Element.Files.InFile>(n_RelatedObjectID);
            return null;
        }

        public Case.BasicCase GetRelatedCase()
        {
            Case.BasicCase baseCase = null;
            if (s_RelatedObjectType == "Case") baseCase = TheUow.GetObjectByKey<Case.BasicCase>(n_RelatedObjectID);
            if (baseCase == null)
            {
                var inFile = GetRelateInFile();
                if (inFile != null) baseCase = inFile.TheMainCase;
            }
            return baseCase;
        }

        public Element.Files.InFile GetRelateInFile()
        {
            if (s_RelatedObjectType != "CameFileOfficial") return null;
            return TheUow.GetObjectByKey<DataEntities.Element.Files.InFile>(n_RelatedObjectID);
        }

        /// <summary>
        /// 获取本链所有相关文件IDS(直接关联的来文及其附件+任务输出参数中的来文)
        /// </summary>
        /// <returns></returns>
        public List<string> GetInFileIdsOfTheTaskChain()
        {
            var lst = new List<string>();
            //1. 直接关联的来文及其附件
            if (s_RelatedObjectType == "CameFileOfficial")
            {
                var relateMainInFile = TheUow.GetObjectByKey<DataEntities.Element.Files.InFile>(n_RelatedObjectID);
                if (relateMainInFile != null)
                {
                    lst.Add(relateMainInFile.n_FileID.ToString());
                    var attachInFiles = new XPCollection<DataEntities.Element.Files.InFile>(TheUow, CriteriaOperator.Parse("n_ParentID = ?", relateMainInFile.n_FileID));
                    foreach (InFile attachInFile in attachInFiles)
                    {
                        lst.Add(attachInFile.n_FileID.ToString());
                    }
                }
            }
            //2. 本任务链输出参数相关来文
            var paramsInFiles = new XPCollection<TFTaskParameter>(TheUow, CriteriaOperator.Parse("g_TaskChainID = ? AND s_ParaType = 'InFile'", g_ID));
            foreach (TFTaskParameter paramsInFile in paramsInFiles)
            {
                if (!string.IsNullOrWhiteSpace(paramsInFile.s_ParaValue))
                {
                    lst.Add(paramsInFile.s_ParaValue);
                }
            }
            //3. 新案来文
            var relateCaseId = GetRelateCaseID();
            if (relateCaseId > 0)
            {
                var lstNewFileInCase = new XPCollection<FileInCase>(TheUow, CriteriaOperator.Parse("TheFile.s_IsNewCaseInFile = 'Y' AND TheCase.n_CaseID = ?", relateCaseId));
                foreach (FileInCase fileInCase in lstNewFileInCase)
                {
                    lst.Add(fileInCase.TheFile.n_FileID.ToString());
                }
            }
            return lst;
        }

        public int GetRelateCaseID()
        {
            if (s_RelatedObjectType == "Case")
                return n_RelatedObjectID;
            else
            {
                var result = TheUow.ExecuteScalar(string.Format("SELECT TOP 1 n_CaseID FROM T_FileInCase WHERE s_IsMainCase = 'Y' AND n_FileID = {0}", n_RelatedObjectID));
                if (result != null) return Convert.ToInt32(result);
            }
            return -1;
        }

        public List<TFDeadline> GetListDeadlines()
        {
            var listDeadlines = new List<TFDeadline>();
            var codeTaskChain = GetTheCodeTaskChain();
            if (codeTaskChain == null) return listDeadlines;
            var listCodeDeadlines = codeTaskChain.GetListCodeDeadlines();
            foreach (var codeDeadline in listCodeDeadlines)
            {
                var xpcDeadlines = new XPCollection<TFDeadline>(TheUow, CriteriaOperator.Parse("g_CodeDeadlineID = ? And s_RelatedObjectType = ? And n_RelatedObjectID = ?", codeDeadline.g_ID, s_RelatedObjectType, n_RelatedObjectID));
                if (xpcDeadlines.Count == 0) continue;
                listDeadlines.AddRange(xpcDeadlines.ToList());
            }
            return listDeadlines;
        }

        public List<TFCustomConditionInTaskChain> GetListCustomConditions()
        {
            return new XPCollection<TFCustomConditionInTaskChain>(TheUow, CriteriaOperator.Parse("g_TaskChainID = ?", g_ID)).ToList();
        }

        public List<TFOperationLog> GetListOperationLogs()
        {
            return new XPCollection<TFOperationLog>(TheUow, CriteriaOperator.Parse("g_TaskChainGuid = ?", g_ID)).ToList();
        }

        public List<TFTaskParameter> GetTaskChainParameters(string sParaType)
        {
            return GetListTaskParameters().Where(p => p.s_ParaType == sParaType).ToList();
        }

        public List<TFTaskCycleConfig> GetListTaskCycleConfigs()
        {
            return new XPCollection<TFTaskCycleConfig>(TheUow, CriteriaOperator.Parse("g_TaskChainGuid = ?", g_ID)).ToList();
        }

        public List<TFWorkItemInTaskChain> GetListWorkItemInTaskChains()
        {
            return new XPCollection<TFWorkItemInTaskChain>(TheUow, CriteriaOperator.Parse("g_TaskChainGuid = ?", g_ID)).ToList();
        }

        public List<TFWorkItemInTaskChain> GetListWorkItemInClusterTaskChains()
        {
            var listWorkItemInClusterTaskChains = new List<TFWorkItemInTaskChain>();
            var listClusterTaskChains = GetListClusterTaskChains();
            listClusterTaskChains.ForEach(f => listWorkItemInClusterTaskChains.AddRange(f.GetListWorkItemInTaskChains()));
            return listWorkItemInClusterTaskChains;
        }

        public List<TFTaskChain> GetListChildTaskChains()
        {
            var listChildTaskChainNodes = GetListNodes().Where(w => w.s_Type == "C").ToList();
            return listChildTaskChainNodes.Select(s => s.GetTheOwnTaskChain()).ToList();
        }

        public List<TFTaskChain> GetListClusterTaskChains()
        {
            var listClusterTaskChains = new List<TFTaskChain> { this };
            listClusterTaskChains.AddRange(GetListParentAndChildTaskChains(this, null, ref listClusterTaskChains));
            return listClusterTaskChains;
        }

        private List<TFTaskChain> GetListParentAndChildTaskChains(TFTaskChain currentTaskChain, TFTaskChain sourceTaskChain, ref List<TFTaskChain> listClusterTaskChains)
        {
            var listParentAndChildTaskChains = new List<TFTaskChain>();
            var parentTaskChain = currentTaskChain.GetTheParentTaskChain();
            if (parentTaskChain != null) listParentAndChildTaskChains.Add(parentTaskChain);
            listParentAndChildTaskChains.AddRange(currentTaskChain.GetListChildTaskChains());
            if (sourceTaskChain != null) listParentAndChildTaskChains = listParentAndChildTaskChains.Where(c => c.g_ID != sourceTaskChain.g_ID).ToList();
            foreach (var taskChain in listParentAndChildTaskChains)
            {
                listClusterTaskChains.AddRange(GetListParentAndChildTaskChains(taskChain, currentTaskChain, ref listClusterTaskChains));
            }
            return listParentAndChildTaskChains;
        }

        #endregion

        public TFTaskChain(Session session) : base(session) { }

        public TFTaskChain() : base(Session.DefaultSession)
        {
        }

    }
}
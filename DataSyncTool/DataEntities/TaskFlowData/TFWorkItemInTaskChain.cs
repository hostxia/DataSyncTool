using System;
using System.Collections.Generic;
using System.Linq;
using DataEntities.Element.Fee;
using DataEntities.TaskFlowBase;
using DataEntities.TaskFlowConfig;
using DevExpress.Data.Filtering;
using DevExpress.Xpo;

namespace DataEntities.TaskFlowData
{
    [Persistent("TF_WorkItemInTaskChain")]
    public class TFWorkItemInTaskChain : XPLiteObjectUser
    {
        Guid fg_ID;
        [Key(false)]
        public Guid g_ID
        {
            get { return fg_ID; }
            set { SetPropertyValue<Guid>("g_ID", ref fg_ID, value); }
        }

        Guid fg_TaskChainGuid;
        /// <summary>
        /// 任务链 关联（外键）
        /// </summary>
        public Guid g_TaskChainGuid
        {
            get { return fg_TaskChainGuid; }
            set { SetPropertyValue<Guid>("g_TaskChainGuid", ref fg_TaskChainGuid, value); }
        }
        Guid fg_TaskGuid;
        /// <summary>
        /// 任务 GID 关联（外键）
        /// </summary>
        public Guid g_TaskGuid
        {
            get { return fg_TaskGuid; }
            set { SetPropertyValue<Guid>("g_TaskGuid", ref fg_TaskGuid, value); }
        }
        int fn_CodeWorkItemID;
        /// <summary>
        /// 工作项 关联（外键）
        /// </summary>
        public int n_CodeWorkItemID
        {
            get { return fn_CodeWorkItemID; }
            set { SetPropertyValue<int>("n_CodeWorkItemID", ref fn_CodeWorkItemID, value); }
        }

        string fs_Description;
        [Size(1000)]
        public string s_Description
        {
            get { return fs_Description; }
            set { SetPropertyValue<string>("s_Description", ref fs_Description, value); }
        }

        string fs_Note;
        [Size(1000)]
        public string s_Note
        {
            get { return fs_Note; }
            set { SetPropertyValue<string>("s_Note", ref fs_Note, value); }
        }

        int fn_RelatedFileID;
        public int n_RelatedFileID
        {
            get { return fn_RelatedFileID; }
            set { SetPropertyValue<int>("n_RelatedFileID", ref fn_RelatedFileID, value); }
        }

        decimal fn_EstimateValue;
        /// <summary>
        /// 预设值
        /// </summary>
        public decimal n_EstimateValue
        {
            get { return fn_EstimateValue; }
            set { SetPropertyValue<decimal>("n_EstimateValue", ref fn_EstimateValue, value); }
        }

        int fn_EstimateValueRecorder;
        /// <summary>
        /// 预设工作相关人
        /// </summary>
        public int n_EstimateValueRecorder
        {
            get { return fn_EstimateValueRecorder; }
            set { SetPropertyValue<int>("n_EstimateValueRecorder", ref fn_EstimateValueRecorder, value); }
        }

        string fs_EstimateValueNote;
        /// <summary>
        /// 预设人备注
        /// </summary>
        [Size(1000)]
        public string s_EstimateValueNote
        {
            get { return fs_EstimateValueNote; }
            set { SetPropertyValue<string>("s_EstimateValueNote", ref fs_EstimateValueNote, value); }
        }

        DateTime fdt_EstimateValueTime;
        /// <summary>
        /// 预设时间
        /// </summary>
        public DateTime dt_EstimateValueTime
        {
            get { return fdt_EstimateValueTime; }
            set { SetPropertyValue<DateTime>("dt_EstimateValueTime", ref fdt_EstimateValueTime, value); }
        }

        decimal fn_ActualValue;
        /// <summary>
        /// 实际值（审定开帐单数量）
        /// </summary>
        public decimal n_ActualValue
        {
            get { return fn_ActualValue; }
            set { SetPropertyValue<decimal>("n_ActualValue", ref fn_ActualValue, value); }
        }

        int fn_ActualValueRecorder;
        /// <summary>
        /// 审定人
        /// </summary>
        public int n_ActualValueRecorder
        {
            get { return fn_ActualValueRecorder; }
            set { SetPropertyValue<int>("n_ActualValueRecorder", ref fn_ActualValueRecorder, value); }
        }

        string fs_ActualValueNote;
        /// <summary>
        /// 审定备注
        /// </summary>
        [Size(1000)]
        public string s_ActualValueNote
        {
            get { return fs_ActualValueNote; }
            set { SetPropertyValue<string>("s_ActualValueNote", ref fs_ActualValueNote, value); }
        }

        DateTime fdt_ActualValueTime;
        /// <summary>
        /// 审定时间
        /// </summary>
        public DateTime dt_ActualValueTime
        {
            get { return fdt_ActualValueTime; }
            set { SetPropertyValue<DateTime>("dt_ActualValueTime", ref fdt_ActualValueTime, value); }
        }

        int fn_Status;
        /// <summary>
        /// 工作项状态（已经弃用）
        /// </summary>
        public int n_Status
        {
            get { return fn_Status; }
            set { SetPropertyValue<int>("n_Status", ref fn_Status, value); }
        }

        decimal fn_ActualServiceValue;
        /// <summary>
        /// 实际值（审定劳务数量）
        /// </summary>
        public decimal n_ActualServiceValue
        {
            get { return fn_ActualServiceValue; }
            set { SetPropertyValue<decimal>("n_ActualServiceValue", ref fn_ActualServiceValue, value); }
        }
        int fn_HasCharge;
        /// <summary>
        /// 已转收费（标记）
        /// </summary>
        public int n_HasCharge
        {
            get { return fn_HasCharge; }
            set { SetPropertyValue<int>("n_HasCharge", ref fn_HasCharge, value); }
        }
        DateTime fdt_ChargeTime;
        /// <summary>
        /// 转收费日期
        /// </summary>
        public DateTime dt_ChargeTime
        {
            get { return fdt_ChargeTime; }
            set { SetPropertyValue<DateTime>("dt_ChargeTime", ref fdt_ChargeTime, value); }
        }
        int fn_ChargeRecorder;
        /// <summary>
        /// 转收费人
        /// </summary>
        public int n_ChargeRecorder
        {
            get { return fn_ChargeRecorder; }
            set { SetPropertyValue<int>("n_ChargeRecorder", ref fn_ChargeRecorder, value); }
        }
        [NonPersistent]
        public int n_CodeWorkItemIDForType
        {
            get { return fn_CodeWorkItemID; }
            set { SetPropertyValue<int>("n_CodeWorkItemID", ref fn_CodeWorkItemID, value); }
        }

        [NonPersistent]
        public int n_CodeWorkItemIDForUnit
        {
            get { return fn_CodeWorkItemID; }
            set { SetPropertyValue<int>("n_CodeWorkItemID", ref fn_CodeWorkItemID, value); }
        }

        #region Method

        public TFTaskChain GetTheTaskChain()
        {
            return TheUow.GetObjectByKey<TFTaskChain>(g_TaskChainGuid);
        }

        public TFCodeWorkItem GetTheCodeWorkItem()
        {
            return TheUow.GetObjectByKey<TFCodeWorkItem>(n_CodeWorkItemID);
        }

        public List<FeeInWorkItem> GetListFeeInWorkItems()
        {
            return new XPCollection<FeeInWorkItem>(TheUow, CriteriaOperator.Parse("g_WorkItemGuid = ?", g_ID)).ToList();
        }

        #endregion

        public TFWorkItemInTaskChain(Session session) : base(session) { }
    }
}
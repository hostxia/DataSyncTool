/**  版本信息模板在安装目录下，可自行修改。
* TF_WorkItemInTaskChain.cs
*
* 功 能： N/A
* 类 名： TF_WorkItemInTaskChain
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:48:25   N/A    初版
*
* Copyright (c) 2012 Maticsoft Corporation. All rights reserved.
*┌──────────────────────────────────┐
*│　此技术信息为本公司机密信息，未经本公司书面同意禁止向第三方披露．　│
*│　版权所有：动软卓越（北京）科技有限公司　　　　　　　　　　　　　　│
*└──────────────────────────────────┘
*/

using System;

namespace DataSyncTool.IPSP.Model
{
	/// <summary>
	/// TF_WorkItemInTaskChain:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TF_WorkItemInTaskChain
	{
		public TF_WorkItemInTaskChain()
		{}
		#region Model
		private Guid _g_id;
		private Guid _g_taskchainguid;
		private int? _n_codeworkitemid;
		private string _s_description;
		private string _s_note;
		private int? _n_relatedfileid;
		private decimal? _n_estimatevalue;
		private int? _n_estimatevaluerecorder;
		private string _s_estimatevaluenote;
		private DateTime? _dt_estimatevaluetime;
		private decimal? _n_actualvalue;
		private int? _n_actualvaluerecorder;
		private string _s_actualvaluenote;
		private DateTime? _dt_actualvaluetime;
		private int? _n_status;
		private decimal? _n_actualservicevalue;
		private int? _n_hascharge;
		private DateTime? _dt_chargetime;
		private int? _n_chargerecorder;
		private int? _n_hasofeecharge;
		private DateTime? _dt_ofeechargetime;
		private int? _n_ofeechargerecorder;
		private Guid _g_taskguid;
		/// <summary>
		/// 
		/// </summary>
		public Guid g_ID
		{
			set{ _g_id=value;}
			get{return _g_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public Guid g_TaskChainGuid
		{
			set{ _g_taskchainguid=value;}
			get{return _g_taskchainguid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_CodeWorkItemID
		{
			set{ _n_codeworkitemid=value;}
			get{return _n_codeworkitemid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_Description
		{
			set{ _s_description=value;}
			get{return _s_description;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_Note
		{
			set{ _s_note=value;}
			get{return _s_note;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_RelatedFileID
		{
			set{ _n_relatedfileid=value;}
			get{return _n_relatedfileid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? n_EstimateValue
		{
			set{ _n_estimatevalue=value;}
			get{return _n_estimatevalue;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_EstimateValueRecorder
		{
			set{ _n_estimatevaluerecorder=value;}
			get{return _n_estimatevaluerecorder;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_EstimateValueNote
		{
			set{ _s_estimatevaluenote=value;}
			get{return _s_estimatevaluenote;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? dt_EstimateValueTime
		{
			set{ _dt_estimatevaluetime=value;}
			get{return _dt_estimatevaluetime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? n_ActualValue
		{
			set{ _n_actualvalue=value;}
			get{return _n_actualvalue;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_ActualValueRecorder
		{
			set{ _n_actualvaluerecorder=value;}
			get{return _n_actualvaluerecorder;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_ActualValueNote
		{
			set{ _s_actualvaluenote=value;}
			get{return _s_actualvaluenote;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? dt_ActualValueTime
		{
			set{ _dt_actualvaluetime=value;}
			get{return _dt_actualvaluetime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_Status
		{
			set{ _n_status=value;}
			get{return _n_status;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? n_ActualServiceValue
		{
			set{ _n_actualservicevalue=value;}
			get{return _n_actualservicevalue;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_HasCharge
		{
			set{ _n_hascharge=value;}
			get{return _n_hascharge;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? dt_ChargeTime
		{
			set{ _dt_chargetime=value;}
			get{return _dt_chargetime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_ChargeRecorder
		{
			set{ _n_chargerecorder=value;}
			get{return _n_chargerecorder;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_HasOfeeCharge
		{
			set{ _n_hasofeecharge=value;}
			get{return _n_hasofeecharge;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? dt_OfeeChargeTime
		{
			set{ _dt_ofeechargetime=value;}
			get{return _dt_ofeechargetime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_OfeeChargeRecorder
		{
			set{ _n_ofeechargerecorder=value;}
			get{return _n_ofeechargerecorder;}
		}
		/// <summary>
		/// 
		/// </summary>
		public Guid g_TaskGuid
		{
			set{ _g_taskguid=value;}
			get{return _g_taskguid;}
		}
		#endregion Model

	}
}


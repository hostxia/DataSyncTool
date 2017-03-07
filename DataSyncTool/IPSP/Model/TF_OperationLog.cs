/**  版本信息模板在安装目录下，可自行修改。
* TF_OperationLog.cs
*
* 功 能： N/A
* 类 名： TF_OperationLog
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:48:15   N/A    初版
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
	/// TF_OperationLog:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TF_OperationLog
	{
		public TF_OperationLog()
		{}
		#region Model
		private Guid _g_id;
		private Guid _g_taskchainguid;
		private Guid _g_taskguid;
		private string _s_codenodecode;
		private string _s_taskname;
		private string _s_operationtype;
		private string _s_statebefore;
		private string _s_stateafter;
		private string _s_reason;
		private int? _n_creator;
		private DateTime? _dt_createtime;
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
		public Guid g_TaskGuid
		{
			set{ _g_taskguid=value;}
			get{return _g_taskguid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_CodeNodeCode
		{
			set{ _s_codenodecode=value;}
			get{return _s_codenodecode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_TaskName
		{
			set{ _s_taskname=value;}
			get{return _s_taskname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_OperationType
		{
			set{ _s_operationtype=value;}
			get{return _s_operationtype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_StateBefore
		{
			set{ _s_statebefore=value;}
			get{return _s_statebefore;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_StateAfter
		{
			set{ _s_stateafter=value;}
			get{return _s_stateafter;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_Reason
		{
			set{ _s_reason=value;}
			get{return _s_reason;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_Creator
		{
			set{ _n_creator=value;}
			get{return _n_creator;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? dt_CreateTime
		{
			set{ _dt_createtime=value;}
			get{return _dt_createtime;}
		}
		#endregion Model

	}
}


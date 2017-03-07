/**  版本信息模板在安装目录下，可自行修改。
* TFCode_TaskTriggerTaskChain.cs
*
* 功 能： N/A
* 类 名： TFCode_TaskTriggerTaskChain
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:48:57   N/A    初版
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
	/// TFCode_TaskTriggerTaskChain:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TFCode_TaskTriggerTaskChain
	{
		public TFCode_TaskTriggerTaskChain()
		{}
		#region Model
		private Guid _g_id;
		private Guid _g_codetaskguid;
		private Guid _g_codetaskchainguid;
		private string _s_triggertime;
		private string _s_triggercondition;
		private string _s_repeat;
		private string _s_relatedobjectsource;
		private string _s_masterslaverelation;
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
		public Guid g_CodeTaskGuid
		{
			set{ _g_codetaskguid=value;}
			get{return _g_codetaskguid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public Guid g_CodeTaskChainGuid
		{
			set{ _g_codetaskchainguid=value;}
			get{return _g_codetaskchainguid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_TriggerTime
		{
			set{ _s_triggertime=value;}
			get{return _s_triggertime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_TriggerCondition
		{
			set{ _s_triggercondition=value;}
			get{return _s_triggercondition;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_Repeat
		{
			set{ _s_repeat=value;}
			get{return _s_repeat;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_RelatedObjectSource
		{
			set{ _s_relatedobjectsource=value;}
			get{return _s_relatedobjectsource;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_MasterSlaveRelation
		{
			set{ _s_masterslaverelation=value;}
			get{return _s_masterslaverelation;}
		}
		#endregion Model

	}
}


/**  版本信息模板在安装目录下，可自行修改。
* TF_TaskCycleConfig.cs
*
* 功 能： N/A
* 类 名： TF_TaskCycleConfig
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:48:22   N/A    初版
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
	/// TF_TaskCycleConfig:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TF_TaskCycleConfig
	{
		public TF_TaskCycleConfig()
		{}
		#region Model
		private Guid _g_id;
		private Guid _g_taskchainguid;
		private string _s_cyclepara;
		private DateTime _dt_basedate;
		private int _n_advancedays;
		private string _s_ischanged;
		private DateTime _dt_originalbasedate;
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
		public string s_CyclePara
		{
			set{ _s_cyclepara=value;}
			get{return _s_cyclepara;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime dt_BaseDate
		{
			set{ _dt_basedate=value;}
			get{return _dt_basedate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int n_AdvanceDays
		{
			set{ _n_advancedays=value;}
			get{return _n_advancedays;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_IsChanged
		{
			set{ _s_ischanged=value;}
			get{return _s_ischanged;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime dt_OriginalBaseDate
		{
			set{ _dt_originalbasedate=value;}
			get{return _dt_originalbasedate;}
		}
		#endregion Model

	}
}


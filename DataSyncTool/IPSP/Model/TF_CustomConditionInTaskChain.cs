/**  版本信息模板在安装目录下，可自行修改。
* TF_CustomConditionInTaskChain.cs
*
* 功 能： N/A
* 类 名： TF_CustomConditionInTaskChain
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:48:09   N/A    初版
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
	/// TF_CustomConditionInTaskChain:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TF_CustomConditionInTaskChain
	{
		public TF_CustomConditionInTaskChain()
		{}
		#region Model
		private Guid _g_id;
		private int? _n_customconditionid;
		private Guid _g_taskchainid;
		private string _s_values;
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
		public int? n_CustomConditionID
		{
			set{ _n_customconditionid=value;}
			get{return _n_customconditionid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public Guid g_TaskChainID
		{
			set{ _g_taskchainid=value;}
			get{return _g_taskchainid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_Values
		{
			set{ _s_values=value;}
			get{return _s_values;}
		}
		#endregion Model

	}
}


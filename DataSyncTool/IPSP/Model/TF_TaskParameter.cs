/**  版本信息模板在安装目录下，可自行修改。
* TF_TaskParameter.cs
*
* 功 能： N/A
* 类 名： TF_TaskParameter
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:48:23   N/A    初版
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
	/// TF_TaskParameter:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TF_TaskParameter
	{
		public TF_TaskParameter()
		{}
		#region Model
		private Guid _g_id;
		private Guid _g_taskid;
		private Guid _g_taskchainid;
		private int _n_codeactionid;
		private string _s_paratype;
		private string _s_paravalue;
		private int? _n_taskchainid;
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
		public Guid g_TaskID
		{
			set{ _g_taskid=value;}
			get{return _g_taskid;}
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
		public int n_CodeActionID
		{
			set{ _n_codeactionid=value;}
			get{return _n_codeactionid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_ParaType
		{
			set{ _s_paratype=value;}
			get{return _s_paratype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_ParaValue
		{
			set{ _s_paravalue=value;}
			get{return _s_paravalue;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_TaskChainID
		{
			set{ _n_taskchainid=value;}
			get{return _n_taskchainid;}
		}
		#endregion Model

	}
}


/**  版本信息模板在安装目录下，可自行修改。
* T_CheckFlow.cs
*
* 功 能： N/A
* 类 名： T_CheckFlow
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:44:34   N/A    初版
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
	/// T_CheckFlow:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class T_CheckFlow
	{
		public T_CheckFlow()
		{}
		#region Model
		private int _n_id;
		private int? _n_flowseq;
		private string _s_flowname;
		private string _s_checkresult;
		private DateTime? _dt_resulttime;
		private DateTime? _dt_limittime;
		/// <summary>
		/// 
		/// </summary>
		public int n_ID
		{
			set{ _n_id=value;}
			get{return _n_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_FlowSeq
		{
			set{ _n_flowseq=value;}
			get{return _n_flowseq;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_FlowName
		{
			set{ _s_flowname=value;}
			get{return _s_flowname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_CheckResult
		{
			set{ _s_checkresult=value;}
			get{return _s_checkresult;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? dt_ResultTime
		{
			set{ _dt_resulttime=value;}
			get{return _dt_resulttime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? dt_LimitTime
		{
			set{ _dt_limittime=value;}
			get{return _dt_limittime;}
		}
		#endregion Model

	}
}


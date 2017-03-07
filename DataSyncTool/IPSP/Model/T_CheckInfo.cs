/**  版本信息模板在安装目录下，可自行修改。
* T_CheckInfo.cs
*
* 功 能： N/A
* 类 名： T_CheckInfo
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
	/// T_CheckInfo:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class T_CheckInfo
	{
		public T_CheckInfo()
		{}
		#region Model
		private int _n_id;
		private int _n_checkflowid;
		private int? _n_checker;
		private string _s_checkstatus;
		private string _s_reason;
		private DateTime? _dt_checktime;
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
		public int n_CheckFlowID
		{
			set{ _n_checkflowid=value;}
			get{return _n_checkflowid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_Checker
		{
			set{ _n_checker=value;}
			get{return _n_checker;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_CheckStatus
		{
			set{ _s_checkstatus=value;}
			get{return _s_checkstatus;}
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
		public DateTime? dt_CheckTime
		{
			set{ _dt_checktime=value;}
			get{return _dt_checktime;}
		}
		#endregion Model

	}
}


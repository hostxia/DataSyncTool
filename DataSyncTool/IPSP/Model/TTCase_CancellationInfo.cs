/**  版本信息模板在安装目录下，可自行修改。
* TTCase_CancellationInfo.cs
*
* 功 能： N/A
* 类 名： TTCase_CancellationInfo
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:50:14   N/A    初版
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
	/// TTCase_CancellationInfo:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TTCase_CancellationInfo
	{
		public TTCase_CancellationInfo()
		{}
		#region Model
		private int _n_caseid;
		private string _s_reasoncancelreason;
		private string _s_logoutregister;
		/// <summary>
		/// 
		/// </summary>
		public int n_CaseID
		{
			set{ _n_caseid=value;}
			get{return _n_caseid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_ReasonCancelReason
		{
			set{ _s_reasoncancelreason=value;}
			get{return _s_reasoncancelreason;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_LogoutRegister
		{
			set{ _s_logoutregister=value;}
			get{return _s_logoutregister;}
		}
		#endregion Model

	}
}


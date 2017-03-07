/**  版本信息模板在安装目录下，可自行修改。
* TDCase_Domain.cs
*
* 功 能： N/A
* 类 名： TDCase_Domain
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:48:06   N/A    初版
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
	/// TDCase_Domain:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TDCase_Domain
	{
		public TDCase_Domain()
		{}
		#region Model
		private int _n_caseid;
		private int? _n_dflownum;
		private string _s_applypurpose;
		private string _s_manager;
		private string _s_mainserverinfo;
		private string _s_secondaryserverinfo;
		private DateTime? _dt_apply;
		private DateTime? _dt_approve;
		private string _s_domainstatus;
		private DateTime? _dt_nextrenewal;
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
		public int? n_DFlowNum
		{
			set{ _n_dflownum=value;}
			get{return _n_dflownum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_ApplyPurpose
		{
			set{ _s_applypurpose=value;}
			get{return _s_applypurpose;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_Manager
		{
			set{ _s_manager=value;}
			get{return _s_manager;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_MainServerInfo
		{
			set{ _s_mainserverinfo=value;}
			get{return _s_mainserverinfo;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_SecondaryServerInfo
		{
			set{ _s_secondaryserverinfo=value;}
			get{return _s_secondaryserverinfo;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? dt_Apply
		{
			set{ _dt_apply=value;}
			get{return _dt_apply;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? dt_Approve
		{
			set{ _dt_approve=value;}
			get{return _dt_approve;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_DomainStatus
		{
			set{ _s_domainstatus=value;}
			get{return _s_domainstatus;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? dt_NextRenewal
		{
			set{ _dt_nextrenewal=value;}
			get{return _dt_nextrenewal;}
		}
		#endregion Model

	}
}


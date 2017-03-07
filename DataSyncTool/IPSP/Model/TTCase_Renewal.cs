/**  版本信息模板在安装目录下，可自行修改。
* TTCase_Renewal.cs
*
* 功 能： N/A
* 类 名： TTCase_Renewal
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:50:57   N/A    初版
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
	/// TTCase_Renewal:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TTCase_Renewal
	{
		public TTCase_Renewal()
		{}
		#region Model
		private int _n_id;
		private int _n_caseid;
		private string _s_notifystatus;
		private string _s_clientconfstatus;
		private DateTime? _dt_consign;
		private DateTime? _dt_publish;
		private string _s_pubnum;
		private string _s_pubissue;
		private string _s_pubvol;
		private string _s_renewalfilepath;
		private DateTime? _dt_effective;
		private DateTime? _dt_end;
		private string _s_status;
		private int? _n_feeid;
		private string _s_notes;
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
		public int n_CaseID
		{
			set{ _n_caseid=value;}
			get{return _n_caseid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_NotifyStatus
		{
			set{ _s_notifystatus=value;}
			get{return _s_notifystatus;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_ClientConfStatus
		{
			set{ _s_clientconfstatus=value;}
			get{return _s_clientconfstatus;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? dt_Consign
		{
			set{ _dt_consign=value;}
			get{return _dt_consign;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? dt_Publish
		{
			set{ _dt_publish=value;}
			get{return _dt_publish;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_PubNum
		{
			set{ _s_pubnum=value;}
			get{return _s_pubnum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_PubIssue
		{
			set{ _s_pubissue=value;}
			get{return _s_pubissue;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_PubVol
		{
			set{ _s_pubvol=value;}
			get{return _s_pubvol;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_RenewalFilePath
		{
			set{ _s_renewalfilepath=value;}
			get{return _s_renewalfilepath;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? dt_Effective
		{
			set{ _dt_effective=value;}
			get{return _dt_effective;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? dt_End
		{
			set{ _dt_end=value;}
			get{return _dt_end;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_Status
		{
			set{ _s_status=value;}
			get{return _s_status;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_FeeID
		{
			set{ _n_feeid=value;}
			get{return _n_feeid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_Notes
		{
			set{ _s_notes=value;}
			get{return _s_notes;}
		}
		#endregion Model

	}
}


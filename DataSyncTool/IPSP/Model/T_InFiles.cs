/**  版本信息模板在安装目录下，可自行修改。
* T_InFiles.cs
*
* 功 能： N/A
* 类 名： T_InFiles
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:44:51   N/A    初版
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
	/// T_InFiles:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class T_InFiles
	{
		public T_InFiles()
		{}
		#region Model
		private int _n_fileid;
		private int? _n_filecodeid;
		private string _s_filetype;
		private int _n_clientid;
		private int? _n_govofficeid;
		private string _s_officer;
		private string _s_officialno;
		private string _s_ofilestatus;
		private string _s_needtransfer;
		private string _s_lock;
		private string _s_locker;
		private int? _n_agencyofficeid;
		private DateTime? _dt_transmitdate;
		private string _s_getcertificater;
		private DateTime? _dt_getcertificatedate;
		private string _s_distribute;
		private string _s_note;
		private string _s_urgent;
		private int? _n_parentid;
		private string _s_isprechange;
		/// <summary>
		/// 
		/// </summary>
		public int n_FileID
		{
			set{ _n_fileid=value;}
			get{return _n_fileid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_FileCodeID
		{
			set{ _n_filecodeid=value;}
			get{return _n_filecodeid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_FileType
		{
			set{ _s_filetype=value;}
			get{return _s_filetype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int n_ClientID
		{
			set{ _n_clientid=value;}
			get{return _n_clientid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_GovOfficeID
		{
			set{ _n_govofficeid=value;}
			get{return _n_govofficeid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_Officer
		{
			set{ _s_officer=value;}
			get{return _s_officer;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_OfficialNO
		{
			set{ _s_officialno=value;}
			get{return _s_officialno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_OFileStatus
		{
			set{ _s_ofilestatus=value;}
			get{return _s_ofilestatus;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_NeedTransfer
		{
			set{ _s_needtransfer=value;}
			get{return _s_needtransfer;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_Lock
		{
			set{ _s_lock=value;}
			get{return _s_lock;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_Locker
		{
			set{ _s_locker=value;}
			get{return _s_locker;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_AgencyOfficeID
		{
			set{ _n_agencyofficeid=value;}
			get{return _n_agencyofficeid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? dt_TransmitDate
		{
			set{ _dt_transmitdate=value;}
			get{return _dt_transmitdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_GetCertificater
		{
			set{ _s_getcertificater=value;}
			get{return _s_getcertificater;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? dt_GetCertificatedate
		{
			set{ _dt_getcertificatedate=value;}
			get{return _dt_getcertificatedate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_Distribute
		{
			set{ _s_distribute=value;}
			get{return _s_distribute;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_Note
		{
			set{ _s_note=value;}
			get{return _s_note;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_Urgent
		{
			set{ _s_urgent=value;}
			get{return _s_urgent;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_ParentID
		{
			set{ _n_parentid=value;}
			get{return _n_parentid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_IsPreChange
		{
			set{ _s_isprechange=value;}
			get{return _s_isprechange;}
		}
		#endregion Model

	}
}


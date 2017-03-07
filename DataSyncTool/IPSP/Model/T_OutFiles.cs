/**  版本信息模板在安装目录下，可自行修改。
* T_OutFiles.cs
*
* 功 能： N/A
* 类 名： T_OutFiles
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:44:58   N/A    初版
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
	/// T_OutFiles:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class T_OutFiles
	{
		public T_OutFiles()
		{}
		#region Model
		private int _n_fileid;
		private string _s_version;
		private string _s_checkedout;
		private int? _n_checkedoutby;
		private string _s_checkedoutpath;
		private int _n_clientid;
		private int? _n_govofficeid;
		private string _s_filestatus;
		private DateTime? _dt_statusdate;
		private DateTime? _dt_writedate;
		private int? _n_writerid;
		private DateTime? _dt_submitdate;
		private int? _n_submiterid;
		private DateTime? _dt_submitduedate;
		private string _s_officialcode;
		private int? _n_printnum=0;
		private int? _n_pagenum=0;
		private string _s_writer;
		private string _s_submiter;
		private int? _n_filelistid;
		private int? _n_refileid;
		private string _s_electroniccode;
		private int? _n_count;
		private string _s_filetype;
		private int _n_agencyid;
		private int? _n_modulecheckstatusid;
		private int? _n_latestcheckinfoid;
		private int? _n_authorid;
		private int? _n_curcheckerid;
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
		public string s_Version
		{
			set{ _s_version=value;}
			get{return _s_version;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_CheckedOut
		{
			set{ _s_checkedout=value;}
			get{return _s_checkedout;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_CheckedOutBy
		{
			set{ _n_checkedoutby=value;}
			get{return _n_checkedoutby;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_CheckedOutPath
		{
			set{ _s_checkedoutpath=value;}
			get{return _s_checkedoutpath;}
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
		public string s_FileStatus
		{
			set{ _s_filestatus=value;}
			get{return _s_filestatus;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? dt_StatusDate
		{
			set{ _dt_statusdate=value;}
			get{return _dt_statusdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? dt_WriteDate
		{
			set{ _dt_writedate=value;}
			get{return _dt_writedate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_WriterID
		{
			set{ _n_writerid=value;}
			get{return _n_writerid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? dt_SubmitDate
		{
			set{ _dt_submitdate=value;}
			get{return _dt_submitdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_SubmiterID
		{
			set{ _n_submiterid=value;}
			get{return _n_submiterid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? dt_SubmitDueDate
		{
			set{ _dt_submitduedate=value;}
			get{return _dt_submitduedate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_OfficialCode
		{
			set{ _s_officialcode=value;}
			get{return _s_officialcode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_PrintNum
		{
			set{ _n_printnum=value;}
			get{return _n_printnum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_PageNum
		{
			set{ _n_pagenum=value;}
			get{return _n_pagenum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_Writer
		{
			set{ _s_writer=value;}
			get{return _s_writer;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_Submiter
		{
			set{ _s_submiter=value;}
			get{return _s_submiter;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_FileListID
		{
			set{ _n_filelistid=value;}
			get{return _n_filelistid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_ReFileID
		{
			set{ _n_refileid=value;}
			get{return _n_refileid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_ElectronicCode
		{
			set{ _s_electroniccode=value;}
			get{return _s_electroniccode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_Count
		{
			set{ _n_count=value;}
			get{return _n_count;}
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
		public int n_AgencyID
		{
			set{ _n_agencyid=value;}
			get{return _n_agencyid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_ModuleCheckStatusID
		{
			set{ _n_modulecheckstatusid=value;}
			get{return _n_modulecheckstatusid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_LatestCheckInfoID
		{
			set{ _n_latestcheckinfoid=value;}
			get{return _n_latestcheckinfoid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_AuthorID
		{
			set{ _n_authorid=value;}
			get{return _n_authorid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_CurCheckerID
		{
			set{ _n_curcheckerid=value;}
			get{return _n_curcheckerid;}
		}
		#endregion Model

	}
}


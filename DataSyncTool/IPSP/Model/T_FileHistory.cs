/**  版本信息模板在安装目录下，可自行修改。
* T_FileHistory.cs
*
* 功 能： N/A
* 类 名： T_FileHistory
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:44:49   N/A    初版
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
	/// T_FileHistory:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class T_FileHistory
	{
		public T_FileHistory()
		{}
		#region Model
		private int _n_id;
		private int _n_fileid;
		private string _s_version;
		private int? _n_checkedoutby;
		private DateTime _dt_checkedindate;
		private string _s_notes;
		private string _s_filepathname;
		private string _s_checkedoutby;
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
		public int? n_CheckedOutBy
		{
			set{ _n_checkedoutby=value;}
			get{return _n_checkedoutby;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime dt_CheckedInDate
		{
			set{ _dt_checkedindate=value;}
			get{return _dt_checkedindate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_Notes
		{
			set{ _s_notes=value;}
			get{return _s_notes;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_FilePathName
		{
			set{ _s_filepathname=value;}
			get{return _s_filepathname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_CheckedOutBy
		{
			set{ _s_checkedoutby=value;}
			get{return _s_checkedoutby;}
		}
		#endregion Model

	}
}


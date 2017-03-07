/**  版本信息模板在安装目录下，可自行修改。
* T_OtherFiles.cs
*
* 功 能： N/A
* 类 名： T_OtherFiles
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:44:57   N/A    初版
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
	/// T_OtherFiles:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class T_OtherFiles
	{
		public T_OtherFiles()
		{}
		#region Model
		private int _n_fileid;
		private string _s_version;
		private string _s_checkedout;
		private int? _n_checkedoutby;
		private string _s_checkedoutpath;
		private string _s_filestatus;
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
		public string s_FileStatus
		{
			set{ _s_filestatus=value;}
			get{return _s_filestatus;}
		}
		#endregion Model

	}
}


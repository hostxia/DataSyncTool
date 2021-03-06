﻿/**  版本信息模板在安装目录下，可自行修改。
* T_EmailFolder.cs
*
* 功 能： N/A
* 类 名： T_EmailFolder
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:44:41   N/A    初版
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
	/// T_EmailFolder:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class T_EmailFolder
	{
		public T_EmailFolder()
		{}
		#region Model
		private int _n_id;
		private string _s_foldername;
		private int? _n_upperfolderid;
		private int _n_userid;
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
		public string s_FolderName
		{
			set{ _s_foldername=value;}
			get{return _s_foldername;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_UpperFolderID
		{
			set{ _n_upperfolderid=value;}
			get{return _n_upperfolderid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int n_UserID
		{
			set{ _n_userid=value;}
			get{return _n_userid;}
		}
		#endregion Model

	}
}


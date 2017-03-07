/**  版本信息模板在安装目录下，可自行修改。
* T_FileFolder.cs
*
* 功 能： N/A
* 类 名： T_FileFolder
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:44:48   N/A    初版
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
	/// T_FileFolder:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class T_FileFolder
	{
		public T_FileFolder()
		{}
		#region Model
		private int _n_folderid;
		private string _s_foldername;
		private int _n_upperfolderid;
		private string _s_foldercategory;
		private int _n_userid;
		/// <summary>
		/// 
		/// </summary>
		public int n_FolderID
		{
			set{ _n_folderid=value;}
			get{return _n_folderid;}
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
		public int n_UpperFolderID
		{
			set{ _n_upperfolderid=value;}
			get{return _n_upperfolderid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_FolderCategory
		{
			set{ _s_foldercategory=value;}
			get{return _s_foldercategory;}
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


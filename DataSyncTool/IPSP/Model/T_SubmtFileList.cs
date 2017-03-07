/**  版本信息模板在安装目录下，可自行修改。
* T_SubmtFileList.cs
*
* 功 能： N/A
* 类 名： T_SubmtFileList
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:45:05   N/A    初版
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
	/// T_SubmtFileList:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class T_SubmtFileList
	{
		public T_SubmtFileList()
		{}
		#region Model
		private decimal _n_filelistid;
		private string _s_filepath;
		private DateTime? _dt_filelistdate;
		private DateTime _dt_createdate;
		private DateTime _dt_editdate;
		private string _s_note;
		/// <summary>
		/// 
		/// </summary>
		public decimal n_FileListID
		{
			set{ _n_filelistid=value;}
			get{return _n_filelistid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_FilePath
		{
			set{ _s_filepath=value;}
			get{return _s_filepath;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? dt_FileListDate
		{
			set{ _dt_filelistdate=value;}
			get{return _dt_filelistdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime dt_CreateDate
		{
			set{ _dt_createdate=value;}
			get{return _dt_createdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime dt_EditDate
		{
			set{ _dt_editdate=value;}
			get{return _dt_editdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_Note
		{
			set{ _s_note=value;}
			get{return _s_note;}
		}
		#endregion Model

	}
}


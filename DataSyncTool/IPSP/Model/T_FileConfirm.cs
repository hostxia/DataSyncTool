/**  版本信息模板在安装目录下，可自行修改。
* T_FileConfirm.cs
*
* 功 能： N/A
* 类 名： T_FileConfirm
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:44:47   N/A    初版
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
	/// T_FileConfirm:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class T_FileConfirm
	{
		public T_FileConfirm()
		{}
		#region Model
		private int _n_id;
		private int _n_filesid;
		private int? _n_confirmorid;
		private string _s_status;
		private DateTime? _dt_confirmdate;
		private string _s_complete;
		private string _s_distributetype;
		private int? _n_distributerid;
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
		public int n_FilesID
		{
			set{ _n_filesid=value;}
			get{return _n_filesid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_ConfirmorID
		{
			set{ _n_confirmorid=value;}
			get{return _n_confirmorid;}
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
		public DateTime? dt_ConfirmDate
		{
			set{ _dt_confirmdate=value;}
			get{return _dt_confirmdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_Complete
		{
			set{ _s_complete=value;}
			get{return _s_complete;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_DistributeType
		{
			set{ _s_distributetype=value;}
			get{return _s_distributetype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_DistributerID
		{
			set{ _n_distributerid=value;}
			get{return _n_distributerid;}
		}
		#endregion Model

	}
}


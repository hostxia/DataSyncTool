﻿/**  版本信息模板在安装目录下，可自行修改。
* TCode_ProcessCustomField.cs
*
* 功 能： N/A
* 类 名： TCode_ProcessCustomField
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:46:48   N/A    初版
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
	/// TCode_ProcessCustomField:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TCode_ProcessCustomField
	{
		public TCode_ProcessCustomField()
		{}
		#region Model
		private int _n_id;
		private int _n_processid;
		private string _s_customfieldname;
		private string _s_type;
		private string _s_content;
		private string _s_isactive;
		private DateTime? _dt_createdate;
		private DateTime? _dt_editdate;
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
		public int n_ProcessID
		{
			set{ _n_processid=value;}
			get{return _n_processid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_CustomFieldName
		{
			set{ _s_customfieldname=value;}
			get{return _s_customfieldname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_Type
		{
			set{ _s_type=value;}
			get{return _s_type;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_Content
		{
			set{ _s_content=value;}
			get{return _s_content;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_IsActive
		{
			set{ _s_isactive=value;}
			get{return _s_isactive;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? dt_CreateDate
		{
			set{ _dt_createdate=value;}
			get{return _dt_createdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? dt_EditDate
		{
			set{ _dt_editdate=value;}
			get{return _dt_editdate;}
		}
		#endregion Model

	}
}


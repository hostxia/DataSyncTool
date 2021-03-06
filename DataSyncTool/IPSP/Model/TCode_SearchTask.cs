﻿/**  版本信息模板在安装目录下，可自行修改。
* TCode_SearchTask.cs
*
* 功 能： N/A
* 类 名： TCode_SearchTask
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:46:56   N/A    初版
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
	/// TCode_SearchTask:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TCode_SearchTask
	{
		public TCode_SearchTask()
		{}
		#region Model
		private int _n_id;
		private string _s_name;
		private string _s_condition;
		private string _s_issystem;
		private string _s_active;
		private int? _n_sequence;
		private string _s_description;
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
		public string s_Name
		{
			set{ _s_name=value;}
			get{return _s_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_Condition
		{
			set{ _s_condition=value;}
			get{return _s_condition;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_IsSystem
		{
			set{ _s_issystem=value;}
			get{return _s_issystem;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_Active
		{
			set{ _s_active=value;}
			get{return _s_active;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_Sequence
		{
			set{ _n_sequence=value;}
			get{return _n_sequence;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_Description
		{
			set{ _s_description=value;}
			get{return _s_description;}
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


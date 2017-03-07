﻿/**  版本信息模板在安装目录下，可自行修改。
* TCase_ArchivesHistory.cs
*
* 功 能： N/A
* 类 名： TCase_ArchivesHistory
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:45:23   N/A    初版
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
	/// TCase_ArchivesHistory:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TCase_ArchivesHistory
	{
		public TCase_ArchivesHistory()
		{}
		#region Model
		private int _n_id;
		private int _n_caseid;
		private DateTime? _dt_instructionborrowertime;
		private int? _n_borrowerid;
		private DateTime? _dt_borrowertime;
		private DateTime? _dt_backtime;
		private string _s_notes;
		private DateTime? _dt_createtime;
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
		public int n_CaseID
		{
			set{ _n_caseid=value;}
			get{return _n_caseid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? dt_InstructionBorrowerTime
		{
			set{ _dt_instructionborrowertime=value;}
			get{return _dt_instructionborrowertime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_BorrowerID
		{
			set{ _n_borrowerid=value;}
			get{return _n_borrowerid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? dt_BorrowerTime
		{
			set{ _dt_borrowertime=value;}
			get{return _dt_borrowertime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? dt_BackTime
		{
			set{ _dt_backtime=value;}
			get{return _dt_backtime;}
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
		public DateTime? dt_CreateTime
		{
			set{ _dt_createtime=value;}
			get{return _dt_createtime;}
		}
		#endregion Model

	}
}


﻿/**  版本信息模板在安装目录下，可自行修改。
* T_Contract.cs
*
* 功 能： N/A
* 类 名： T_Contract
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:44:37   N/A    初版
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
	/// T_Contract:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class T_Contract
	{
		public T_Contract()
		{}
		#region Model
		private int _n_id;
		private DateTime? _dt_contractdate;
		private string _s_cno;
		private string _s_cstate;
		private int _n_clientid;
		private string _s_note;
		private string _s_filepath;
		private string _s_creator;
		private DateTime? _dt_createdate;
		private string _s_editor;
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
		public DateTime? dt_ContractDate
		{
			set{ _dt_contractdate=value;}
			get{return _dt_contractdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_CNO
		{
			set{ _s_cno=value;}
			get{return _s_cno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_CState
		{
			set{ _s_cstate=value;}
			get{return _s_cstate;}
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
		public string s_Note
		{
			set{ _s_note=value;}
			get{return _s_note;}
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
		public string s_Creator
		{
			set{ _s_creator=value;}
			get{return _s_creator;}
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
		public string s_Editor
		{
			set{ _s_editor=value;}
			get{return _s_editor;}
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


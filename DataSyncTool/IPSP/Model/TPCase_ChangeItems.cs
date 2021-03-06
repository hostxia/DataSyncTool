﻿/**  版本信息模板在安装目录下，可自行修改。
* TPCase_ChangeItems.cs
*
* 功 能： N/A
* 类 名： TPCase_ChangeItems
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:49:14   N/A    初版
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
	/// TPCase_ChangeItems:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TPCase_ChangeItems
	{
		public TPCase_ChangeItems()
		{}
		#region Model
		private int _n_id;
		private int _n_caseid;
		private int? _n_processid;
		private string _s_item;
		private string _s_beforechg;
		private string _s_afterchg;
		private string _s_notes;
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
		public int? n_ProcessID
		{
			set{ _n_processid=value;}
			get{return _n_processid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_Item
		{
			set{ _s_item=value;}
			get{return _s_item;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_BeforeChg
		{
			set{ _s_beforechg=value;}
			get{return _s_beforechg;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_AfterChg
		{
			set{ _s_afterchg=value;}
			get{return _s_afterchg;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_Notes
		{
			set{ _s_notes=value;}
			get{return _s_notes;}
		}
		#endregion Model

	}
}


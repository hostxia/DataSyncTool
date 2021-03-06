﻿/**  版本信息模板在安装目录下，可自行修改。
* TCode_Currency.cs
*
* 功 能： N/A
* 类 名： TCode_Currency
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:46:06   N/A    初版
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
	/// TCode_Currency:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TCode_Currency
	{
		public TCode_Currency()
		{}
		#region Model
		private int _n_id;
		private string _s_currencycode;
		private string _s_name;
		private string _s_othername;
		private decimal? _n_rate;
		private DateTime? _dt_createdate;
		private DateTime? _dt_editdate;
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
		public string s_CurrencyCode
		{
			set{ _s_currencycode=value;}
			get{return _s_currencycode;}
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
		public string s_OtherName
		{
			set{ _s_othername=value;}
			get{return _s_othername;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? n_Rate
		{
			set{ _n_rate=value;}
			get{return _n_rate;}
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


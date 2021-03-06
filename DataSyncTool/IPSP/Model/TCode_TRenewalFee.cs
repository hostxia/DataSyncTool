﻿/**  版本信息模板在安装目录下，可自行修改。
* TCode_TRenewalFee.cs
*
* 功 能： N/A
* 类 名： TCode_TRenewalFee
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:47:17   N/A    初版
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
	/// TCode_TRenewalFee:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TCode_TRenewalFee
	{
		public TCode_TRenewalFee()
		{}
		#region Model
		private int _n_id;
		private string _s_tapplytype;
		private int? _n_regcountry;
		private decimal? _n_officialfee;
		private int? _n_officialcurrency;
		private string _s_unitprice;
		private string _s_unit;
		private int? _n_exceedunit;
		private decimal? _n_exceedunitfee;
		private string _s_initialdatetype;
		private int? _n_renewalyear;
		private string _s_notes;
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
		public string s_TApplyType
		{
			set{ _s_tapplytype=value;}
			get{return _s_tapplytype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_RegCountry
		{
			set{ _n_regcountry=value;}
			get{return _n_regcountry;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? n_OfficialFee
		{
			set{ _n_officialfee=value;}
			get{return _n_officialfee;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_OfficialCurrency
		{
			set{ _n_officialcurrency=value;}
			get{return _n_officialcurrency;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_UnitPrice
		{
			set{ _s_unitprice=value;}
			get{return _s_unitprice;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_Unit
		{
			set{ _s_unit=value;}
			get{return _s_unit;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_ExceedUnit
		{
			set{ _n_exceedunit=value;}
			get{return _n_exceedunit;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? n_ExceedUnitFee
		{
			set{ _n_exceedunitfee=value;}
			get{return _n_exceedunitfee;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_InitialDateType
		{
			set{ _s_initialdatetype=value;}
			get{return _s_initialdatetype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_RenewalYear
		{
			set{ _n_renewalyear=value;}
			get{return _n_renewalyear;}
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


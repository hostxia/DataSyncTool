/**  版本信息模板在安装目录下，可自行修改。
* TPCase_AnnFeeInfo.cs
*
* 功 能： N/A
* 类 名： TPCase_AnnFeeInfo
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:49:11   N/A    初版
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
	/// TPCase_AnnFeeInfo:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TPCase_AnnFeeInfo
	{
		public TPCase_AnnFeeInfo()
		{}
		#region Model
		private int _n_id;
		private int _n_caseid;
		private string _s_officialdiscstyle;
		private decimal? _n_officialdiscount;
		private int? _n_discyears;
		private int? _n_fstpayyear;
		private int? _n_lastpayyear;
		private int? _n_alarmmonths;
		private DateTime? _dt_fstpayyear;
		private DateTime? _dt_lastpayyear;
		private int? _n_countpayyear;
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
		public string s_OfficialDiscStyle
		{
			set{ _s_officialdiscstyle=value;}
			get{return _s_officialdiscstyle;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? n_OfficialDiscount
		{
			set{ _n_officialdiscount=value;}
			get{return _n_officialdiscount;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_DiscYears
		{
			set{ _n_discyears=value;}
			get{return _n_discyears;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_FstPayYear
		{
			set{ _n_fstpayyear=value;}
			get{return _n_fstpayyear;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_LastPayYear
		{
			set{ _n_lastpayyear=value;}
			get{return _n_lastpayyear;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_AlarmMonths
		{
			set{ _n_alarmmonths=value;}
			get{return _n_alarmmonths;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? dt_FstPayYear
		{
			set{ _dt_fstpayyear=value;}
			get{return _dt_fstpayyear;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? dt_LastPayYear
		{
			set{ _dt_lastpayyear=value;}
			get{return _dt_lastpayyear;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_CountPayYear
		{
			set{ _n_countpayyear=value;}
			get{return _n_countpayyear;}
		}
		#endregion Model

	}
}


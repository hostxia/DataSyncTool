/**  版本信息模板在安装目录下，可自行修改。
* TPCase_AnnFeeStage.cs
*
* 功 能： N/A
* 类 名： TPCase_AnnFeeStage
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:49:12   N/A    初版
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
	/// TPCase_AnnFeeStage:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TPCase_AnnFeeStage
	{
		public TPCase_AnnFeeStage()
		{}
		#region Model
		private int _n_id;
		private int? _n_caseid;
		private string _s_officialdiscstyle;
		private decimal? _n_officialdiscount;
		private int? _n_discyears;
		private int? _n_fstpayyear;
		private int? _n_lastpayyear;
		private int? _n_alarmmonths;
		private string _s_notes;
		private string _s_paymode;
		private string _s_statusorder;
		private string _s_statusinit;
		private int? _n_chargecurrency;
		private int? _n_officialcurrency;
		private string _s_feemode;
		private decimal? _n_feediscount;
		private decimal? _n_fixafee;
		private decimal? _n_fixfee;
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
		public int? n_CaseID
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
		public string s_Notes
		{
			set{ _s_notes=value;}
			get{return _s_notes;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_PayMode
		{
			set{ _s_paymode=value;}
			get{return _s_paymode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_StatusOrder
		{
			set{ _s_statusorder=value;}
			get{return _s_statusorder;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_StatusInit
		{
			set{ _s_statusinit=value;}
			get{return _s_statusinit;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_ChargeCurrency
		{
			set{ _n_chargecurrency=value;}
			get{return _n_chargecurrency;}
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
		public string s_FeeMode
		{
			set{ _s_feemode=value;}
			get{return _s_feemode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? n_FeeDiscount
		{
			set{ _n_feediscount=value;}
			get{return _n_feediscount;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? n_FixAFee
		{
			set{ _n_fixafee=value;}
			get{return _n_fixafee;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? n_FixFee
		{
			set{ _n_fixfee=value;}
			get{return _n_fixfee;}
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


/**  版本信息模板在安装目录下，可自行修改。
* TCode_Fee.cs
*
* 功 能： N/A
* 类 名： TCode_Fee
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:46:23   N/A    初版
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
	/// TCode_Fee:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TCode_Fee
	{
		public TCode_Fee()
		{}
		#region Model
		private int _n_id;
		private string _s_iptype;
		private string _s_tapplytype;
		private string _s_regcountry;
		private string _s_business;
		private string _s_ptctype;
		private int? _n_processid;
		private string _s_name;
		private string _s_othername;
		private string _s_officialname;
		private decimal? _n_officialfee;
		private int? _n_officialcurrency;
		private string _s_afeedisc;
		private string _s_ofeedisc;
		private string _s_unitprice;
		private string _s_unit;
		private decimal? _n_exceedunit;
		private decimal? _n_exceedunitfee;
		private string _s_notes;
		private DateTime? _dt_createdate;
		private DateTime? _dt_editdate;
		private string _s_issystem;
		private string _s_codecamefileid;
		private string _s_autofeetype;
		private string _s_timetype;
		private int? _n_month;
		private int? _n_day;
		private string _s_autofee;
		private string _s_dayandmonthsequence;
		private string _s_autopaydate;
		private string _s_isforelectriconline;
		private string _s_officalflag;
		private string _s_feeregion;
		private string _s_isforpayablebill;
		private string _s_feetype;
		private decimal? _n_everyunitcount;
		private string _s_translationfee;
		private string _s_sysflowdirection;
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
		public string s_IPType
		{
			set{ _s_iptype=value;}
			get{return _s_iptype;}
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
		public string s_RegCountry
		{
			set{ _s_regcountry=value;}
			get{return _s_regcountry;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_Business
		{
			set{ _s_business=value;}
			get{return _s_business;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_PTCType
		{
			set{ _s_ptctype=value;}
			get{return _s_ptctype;}
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
		public string s_OfficialName
		{
			set{ _s_officialname=value;}
			get{return _s_officialname;}
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
		public string s_AFeeDisc
		{
			set{ _s_afeedisc=value;}
			get{return _s_afeedisc;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_OFeeDisc
		{
			set{ _s_ofeedisc=value;}
			get{return _s_ofeedisc;}
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
		public decimal? n_ExceedUnit
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
		public string s_CodeCameFileID
		{
			set{ _s_codecamefileid=value;}
			get{return _s_codecamefileid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_AutoFeeType
		{
			set{ _s_autofeetype=value;}
			get{return _s_autofeetype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_TimeType
		{
			set{ _s_timetype=value;}
			get{return _s_timetype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_Month
		{
			set{ _n_month=value;}
			get{return _n_month;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_Day
		{
			set{ _n_day=value;}
			get{return _n_day;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_AutoFee
		{
			set{ _s_autofee=value;}
			get{return _s_autofee;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_DayAndMonthSequence
		{
			set{ _s_dayandmonthsequence=value;}
			get{return _s_dayandmonthsequence;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_AutoPayDate
		{
			set{ _s_autopaydate=value;}
			get{return _s_autopaydate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_IsForElectricOnline
		{
			set{ _s_isforelectriconline=value;}
			get{return _s_isforelectriconline;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_OfficalFlag
		{
			set{ _s_officalflag=value;}
			get{return _s_officalflag;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_FeeRegion
		{
			set{ _s_feeregion=value;}
			get{return _s_feeregion;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_IsForPayableBill
		{
			set{ _s_isforpayablebill=value;}
			get{return _s_isforpayablebill;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_FeeType
		{
			set{ _s_feetype=value;}
			get{return _s_feetype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? n_EveryUnitCount
		{
			set{ _n_everyunitcount=value;}
			get{return _n_everyunitcount;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_TranslationFee
		{
			set{ _s_translationfee=value;}
			get{return _s_translationfee;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_SysFlowDirection
		{
			set{ _s_sysflowdirection=value;}
			get{return _s_sysflowdirection;}
		}
		#endregion Model

	}
}


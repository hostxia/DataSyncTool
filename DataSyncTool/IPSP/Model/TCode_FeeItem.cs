/**  版本信息模板在安装目录下，可自行修改。
* TCode_FeeItem.cs
*
* 功 能： N/A
* 类 名： TCode_FeeItem
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:46:24   N/A    初版
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
	/// TCode_FeeItem:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TCode_FeeItem
	{
		public TCode_FeeItem()
		{}
		#region Model
		private int _n_id;
		private int _n_feecodeid;
		private int? _n_chargecurrency;
		private decimal? _n_chargeofee;
		private decimal? _n_chargeunitfee;
		private decimal? _n_chargeafee;
		private decimal? _n_otherfee;
		private decimal? _n_agencyunitfee;
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
		public int n_FeeCodeID
		{
			set{ _n_feecodeid=value;}
			get{return _n_feecodeid;}
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
		public decimal? n_ChargeOFee
		{
			set{ _n_chargeofee=value;}
			get{return _n_chargeofee;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? n_ChargeUnitFee
		{
			set{ _n_chargeunitfee=value;}
			get{return _n_chargeunitfee;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? n_ChargeAFee
		{
			set{ _n_chargeafee=value;}
			get{return _n_chargeafee;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? n_OtherFee
		{
			set{ _n_otherfee=value;}
			get{return _n_otherfee;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? n_AgencyUnitFee
		{
			set{ _n_agencyunitfee=value;}
			get{return _n_agencyunitfee;}
		}
		#endregion Model

	}
}


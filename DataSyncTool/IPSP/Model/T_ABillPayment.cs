/**  版本信息模板在安装目录下，可自行修改。
* T_ABillPayment.cs
*
* 功 能： N/A
* 类 名： T_ABillPayment
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:44:27   N/A    初版
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
	/// T_ABillPayment:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class T_ABillPayment
	{
		public T_ABillPayment()
		{}
		#region Model
		private int _n_paylistid;
		private DateTime? _dt_paydate;
		private decimal? _n_paysum;
		private string _s_paybillno;
		private int? _n_currencyid;
		private int? _n_exchangecurrency;
		private decimal? _n_exrate;
		private string _s_dealer;
		private string _s_note;
		private string _s_rereceiptcontent;
		private DateTime? _dt_rereceiptdate;
		private string _s_register;
		private string _s_lock;
		private string _s_locker;
		private string _s_editor;
		private DateTime? _dt_createdate;
		private DateTime? _dt_editdate;
		private string _s_registerno;
		private string _s_creator;
		private int? _n_balance;
		private int? _n_dealerid;
		/// <summary>
		/// 
		/// </summary>
		public int n_PayListID
		{
			set{ _n_paylistid=value;}
			get{return _n_paylistid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? dt_PayDate
		{
			set{ _dt_paydate=value;}
			get{return _dt_paydate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? n_PaySum
		{
			set{ _n_paysum=value;}
			get{return _n_paysum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_PayBillNo
		{
			set{ _s_paybillno=value;}
			get{return _s_paybillno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_CurrencyID
		{
			set{ _n_currencyid=value;}
			get{return _n_currencyid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_ExchangeCurrency
		{
			set{ _n_exchangecurrency=value;}
			get{return _n_exchangecurrency;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? n_ExRate
		{
			set{ _n_exrate=value;}
			get{return _n_exrate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_Dealer
		{
			set{ _s_dealer=value;}
			get{return _s_dealer;}
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
		public string s_ReReceiptContent
		{
			set{ _s_rereceiptcontent=value;}
			get{return _s_rereceiptcontent;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? dt_ReReceiptDate
		{
			set{ _dt_rereceiptdate=value;}
			get{return _dt_rereceiptdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_Register
		{
			set{ _s_register=value;}
			get{return _s_register;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_Lock
		{
			set{ _s_lock=value;}
			get{return _s_lock;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_Locker
		{
			set{ _s_locker=value;}
			get{return _s_locker;}
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
		public string s_RegisterNo
		{
			set{ _s_registerno=value;}
			get{return _s_registerno;}
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
		public int? n_Balance
		{
			set{ _n_balance=value;}
			get{return _n_balance;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_DealerID
		{
			set{ _n_dealerid=value;}
			get{return _n_dealerid;}
		}
		#endregion Model

	}
}


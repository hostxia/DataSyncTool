/**  版本信息模板在安装目录下，可自行修改。
* T_CameMoney.cs
*
* 功 能： N/A
* 类 名： T_CameMoney
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:44:33   N/A    初版
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
	/// T_CameMoney:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class T_CameMoney
	{
		public T_CameMoney()
		{}
		#region Model
		private int _n_cmoneyid;
		private int _n_clientid;
		private string _s_camemode;
		private string _s_cmoneynum;
		private DateTime? _dt_arrivedate;
		private int? _n_currunitid;
		private decimal? _n_totalmoney;
		private decimal? _n_exrate;
		private decimal? _n_amount;
		private string _s_creator;
		private DateTime _dt_createdate;
		private int? _n_deptid;
		private string _s_mark;
		private decimal? _n_balance;
		private decimal? _n_mergetoaccount;
		private string _s_note;
		private string _s_bank;
		private string _s_editor;
		private string _s_lock;
		private string _s_locker;
		private string _s_receipt;
		private DateTime? _dt_receiptdate;
		private string _s_fileinvoicepath;
		private string _s_payer;
		private string _s_solified;
		private decimal? _n_commissioncharge;
		private string _s_cmhascommissioncharge;
		private DateTime? _dt_editdate;
		private int? _n_paycurrencyid;
		private int _n_contractid;
		/// <summary>
		/// 
		/// </summary>
		public int n_CMoneyID
		{
			set{ _n_cmoneyid=value;}
			get{return _n_cmoneyid;}
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
		public string s_CameMode
		{
			set{ _s_camemode=value;}
			get{return _s_camemode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_CMoneyNum
		{
			set{ _s_cmoneynum=value;}
			get{return _s_cmoneynum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? dt_ArriveDate
		{
			set{ _dt_arrivedate=value;}
			get{return _dt_arrivedate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_CurrUnitID
		{
			set{ _n_currunitid=value;}
			get{return _n_currunitid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? n_TotalMoney
		{
			set{ _n_totalmoney=value;}
			get{return _n_totalmoney;}
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
		public decimal? n_Amount
		{
			set{ _n_amount=value;}
			get{return _n_amount;}
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
		public DateTime dt_CreateDate
		{
			set{ _dt_createdate=value;}
			get{return _dt_createdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_DeptID
		{
			set{ _n_deptid=value;}
			get{return _n_deptid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_Mark
		{
			set{ _s_mark=value;}
			get{return _s_mark;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? n_Balance
		{
			set{ _n_balance=value;}
			get{return _n_balance;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? n_MergeToAccount
		{
			set{ _n_mergetoaccount=value;}
			get{return _n_mergetoaccount;}
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
		public string s_Bank
		{
			set{ _s_bank=value;}
			get{return _s_bank;}
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
		public string S_Lock
		{
			set{ _s_lock=value;}
			get{return _s_lock;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string S_Locker
		{
			set{ _s_locker=value;}
			get{return _s_locker;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_Receipt
		{
			set{ _s_receipt=value;}
			get{return _s_receipt;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? dt_ReceiptDate
		{
			set{ _dt_receiptdate=value;}
			get{return _dt_receiptdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_FileInvoicePath
		{
			set{ _s_fileinvoicepath=value;}
			get{return _s_fileinvoicepath;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_Payer
		{
			set{ _s_payer=value;}
			get{return _s_payer;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_Solified
		{
			set{ _s_solified=value;}
			get{return _s_solified;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? n_CommissionCharge
		{
			set{ _n_commissioncharge=value;}
			get{return _n_commissioncharge;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_CMHasCommissionCharge
		{
			set{ _s_cmhascommissioncharge=value;}
			get{return _s_cmhascommissioncharge;}
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
		public int? n_PayCurrencyID
		{
			set{ _n_paycurrencyid=value;}
			get{return _n_paycurrencyid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int n_ContractID
		{
			set{ _n_contractid=value;}
			get{return _n_contractid;}
		}
		#endregion Model

	}
}


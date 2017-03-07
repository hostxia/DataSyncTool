/**  版本信息模板在安装目录下，可自行修改。
* T_AbroadBill.cs
*
* 功 能： N/A
* 类 名： T_AbroadBill
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:44:28   N/A    初版
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
	/// T_AbroadBill:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class T_AbroadBill
	{
		public T_AbroadBill()
		{}
		#region Model
		private int _n_billid;
		private int _n_vendorid;
		private int _n_paylistid;
		private string _s_oppid;
		private string _s_reason;
		private DateTime? _dt_shldpaydate;
		private int? _n_currencyid;
		private DateTime? _dt_receivebill;
		private string _s_paymark;
		private string _s_payer;
		private DateTime? _dt_paydate;
		private decimal? _n_feepayed;
		private string _s_checkmark;
		private DateTime? _dt_checkdate;
		private string _s_checker;
		private string _s_note;
		private string _s_filepath;
		private string _s_lock;
		private string _s_locker;
		private string _s_editor;
		private DateTime? _dt_createdate;
		private DateTime? _dt_editdate;
		private int? _n_apaymentid;
		private int _n_hedgeid;
		private string _s_creator;
		private DateTime? _dt_billing;
		private int? _n_modulecheckstatusid;
		private int? _n_latestcheckinfoid;
		private int? _n_authorid;
		private int? _n_curcheckerid;
		private string _s_checkstatus;
		private int? _n_checker;
		private int? _n_payerid;
		/// <summary>
		/// 
		/// </summary>
		public int n_BillID
		{
			set{ _n_billid=value;}
			get{return _n_billid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int n_VendorID
		{
			set{ _n_vendorid=value;}
			get{return _n_vendorid;}
		}
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
		public string s_OppID
		{
			set{ _s_oppid=value;}
			get{return _s_oppid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_Reason
		{
			set{ _s_reason=value;}
			get{return _s_reason;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? dt_ShldPayDate
		{
			set{ _dt_shldpaydate=value;}
			get{return _dt_shldpaydate;}
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
		public DateTime? dt_ReceiveBill
		{
			set{ _dt_receivebill=value;}
			get{return _dt_receivebill;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_PayMark
		{
			set{ _s_paymark=value;}
			get{return _s_paymark;}
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
		public DateTime? dt_PayDate
		{
			set{ _dt_paydate=value;}
			get{return _dt_paydate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? n_FeePayed
		{
			set{ _n_feepayed=value;}
			get{return _n_feepayed;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_CheckMark
		{
			set{ _s_checkmark=value;}
			get{return _s_checkmark;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? dt_CheckDate
		{
			set{ _dt_checkdate=value;}
			get{return _dt_checkdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_Checker
		{
			set{ _s_checker=value;}
			get{return _s_checker;}
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
		public int? n_APaymentID
		{
			set{ _n_apaymentid=value;}
			get{return _n_apaymentid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int n_HedgeID
		{
			set{ _n_hedgeid=value;}
			get{return _n_hedgeid;}
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
		public DateTime? dt_Billing
		{
			set{ _dt_billing=value;}
			get{return _dt_billing;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_ModuleCheckStatusID
		{
			set{ _n_modulecheckstatusid=value;}
			get{return _n_modulecheckstatusid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_LatestCheckInfoID
		{
			set{ _n_latestcheckinfoid=value;}
			get{return _n_latestcheckinfoid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_AuthorID
		{
			set{ _n_authorid=value;}
			get{return _n_authorid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_CurCheckerID
		{
			set{ _n_curcheckerid=value;}
			get{return _n_curcheckerid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_CheckStatus
		{
			set{ _s_checkstatus=value;}
			get{return _s_checkstatus;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_Checker
		{
			set{ _n_checker=value;}
			get{return _n_checker;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_PayerID
		{
			set{ _n_payerid=value;}
			get{return _n_payerid;}
		}
		#endregion Model

	}
}


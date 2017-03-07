/**  版本信息模板在安装目录下，可自行修改。
* T_AnnualFee.cs
*
* 功 能： N/A
* 类 名： T_AnnualFee
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:44:29   N/A    初版
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
	/// T_AnnualFee:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class T_AnnualFee
	{
		public T_AnnualFee()
		{}
		#region Model
		private int _n_annualfeeid;
		private int _n_caseid;
		private decimal? _n_yearno;
		private string _s_status;
		private string _s_paymode;
		private string _s_statusorder;
		private int? _n_chargecurrency;
		private decimal? _n_chargeofee;
		private decimal? _n_chargeafee;
		private decimal? _n_chargetfee;
		private DateTime? _dt_chargeshldpaydate;
		private DateTime? _dt_chargepaydate;
		private int? _n_officialcurrency;
		private decimal? _n_officialfee;
		private decimal? _n_officiallatefee;
		private string _s_isofficialdisc;
		private string _s_officialdiscstyle;
		private decimal? _n_officialdiscount;
		private DateTime? _dt_officialshldpaydate;
		private DateTime? _dt_officialpaydate;
		private string _s_officialreceiptpath;
		private int? _n_payfeelistid;
		private string _s_notes;
		private string _s_invoicenum;
		private DateTime? _dt_alarmdate;
		private decimal? _n_rate;
		private string _s_isactive;
		private DateTime? _dt_createdate;
		private DateTime? _dt_editdate;
		private string _s_feereceivecashstatue;
		private int? _n_exchangecurrency;
		private string _s_priority;
		private string _s_creator;
		private string _s_editor;
		private int _n_billid;
		private string _s_elecpayer;
		private int? _n_assignannualfeehandler;
		private int? _n_assignbillhandler;
		private int? _n_reportstatus;
		private int? _n_feeapprovalstatus;
		private string _s_billapprovalstatus;
		private string _s_approvalnotes;
		private string _s_checkstatus;
		private int? _n_checker;
		private DateTime? _dt_checkdate;
		private string _s_receiptno;
		private DateTime? _dt_receiptdate;
		private int? _n_operatorid;
		/// <summary>
		/// 
		/// </summary>
		public int n_AnnualFeeID
		{
			set{ _n_annualfeeid=value;}
			get{return _n_annualfeeid;}
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
		public decimal? n_YearNo
		{
			set{ _n_yearno=value;}
			get{return _n_yearno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_Status
		{
			set{ _s_status=value;}
			get{return _s_status;}
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
		public decimal? n_ChargeAFee
		{
			set{ _n_chargeafee=value;}
			get{return _n_chargeafee;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? n_ChargeTFee
		{
			set{ _n_chargetfee=value;}
			get{return _n_chargetfee;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? dt_ChargeShldPayDate
		{
			set{ _dt_chargeshldpaydate=value;}
			get{return _dt_chargeshldpaydate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? dt_ChargePayDate
		{
			set{ _dt_chargepaydate=value;}
			get{return _dt_chargepaydate;}
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
		public decimal? n_OfficialFee
		{
			set{ _n_officialfee=value;}
			get{return _n_officialfee;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? n_OfficialLateFee
		{
			set{ _n_officiallatefee=value;}
			get{return _n_officiallatefee;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_IsOfficialDisc
		{
			set{ _s_isofficialdisc=value;}
			get{return _s_isofficialdisc;}
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
		public DateTime? dt_OfficialShldPayDate
		{
			set{ _dt_officialshldpaydate=value;}
			get{return _dt_officialshldpaydate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? dt_OfficialPayDate
		{
			set{ _dt_officialpaydate=value;}
			get{return _dt_officialpaydate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_OfficialReceiptPath
		{
			set{ _s_officialreceiptpath=value;}
			get{return _s_officialreceiptpath;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_PayFeeListID
		{
			set{ _n_payfeelistid=value;}
			get{return _n_payfeelistid;}
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
		public string s_InvoiceNum
		{
			set{ _s_invoicenum=value;}
			get{return _s_invoicenum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? dt_AlarmDate
		{
			set{ _dt_alarmdate=value;}
			get{return _dt_alarmdate;}
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
		public string s_IsActive
		{
			set{ _s_isactive=value;}
			get{return _s_isactive;}
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
		public string s_FeeReceiveCashStatue
		{
			set{ _s_feereceivecashstatue=value;}
			get{return _s_feereceivecashstatue;}
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
		public string s_Priority
		{
			set{ _s_priority=value;}
			get{return _s_priority;}
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
		public string s_Editor
		{
			set{ _s_editor=value;}
			get{return _s_editor;}
		}
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
		public string s_ElecPayer
		{
			set{ _s_elecpayer=value;}
			get{return _s_elecpayer;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_AssignAnnualFeeHandler
		{
			set{ _n_assignannualfeehandler=value;}
			get{return _n_assignannualfeehandler;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_AssignBillHandler
		{
			set{ _n_assignbillhandler=value;}
			get{return _n_assignbillhandler;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_ReportStatus
		{
			set{ _n_reportstatus=value;}
			get{return _n_reportstatus;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_FeeApprovalStatus
		{
			set{ _n_feeapprovalstatus=value;}
			get{return _n_feeapprovalstatus;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_BillApprovalStatus
		{
			set{ _s_billapprovalstatus=value;}
			get{return _s_billapprovalstatus;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_ApprovalNotes
		{
			set{ _s_approvalnotes=value;}
			get{return _s_approvalnotes;}
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
		public DateTime? dt_CheckDate
		{
			set{ _dt_checkdate=value;}
			get{return _dt_checkdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_ReceiptNo
		{
			set{ _s_receiptno=value;}
			get{return _s_receiptno;}
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
		public int? n_OperatorID
		{
			set{ _n_operatorid=value;}
			get{return _n_operatorid;}
		}
		#endregion Model

	}
}


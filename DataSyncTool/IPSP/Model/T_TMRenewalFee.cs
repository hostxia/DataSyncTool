/**  版本信息模板在安装目录下，可自行修改。
* T_TMRenewalFee.cs
*
* 功 能： N/A
* 类 名： T_TMRenewalFee
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:45:13   N/A    初版
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
	/// T_TMRenewalFee:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class T_TMRenewalFee
	{
		public T_TMRenewalFee()
		{}
		#region Model
		private int _n_trenewalfeeid;
		private int _n_caseid;
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
		private DateTime? _dt_consign;
		private DateTime? _dt_publish;
		private string _s_pubnum;
		private string _s_pubissue;
		private string _s_pubvol;
		private string _s_renewalfilepath;
		private DateTime? _dt_effective;
		private DateTime? _dt_end;
		private DateTime? _dt_nextrenewal;
		private string _s_renewalstatus;
		private string _s_feereceivecashstatue;
		private int? _n_exchangecurrency;
		private string _s_feereceivedstatus;
		private string _s_creator;
		private string _s_editor;
		private int _n_billid;
		/// <summary>
		/// 
		/// </summary>
		public int n_TRenewalFeeID
		{
			set{ _n_trenewalfeeid=value;}
			get{return _n_trenewalfeeid;}
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
		public DateTime? dt_Consign
		{
			set{ _dt_consign=value;}
			get{return _dt_consign;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? dt_Publish
		{
			set{ _dt_publish=value;}
			get{return _dt_publish;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_PubNum
		{
			set{ _s_pubnum=value;}
			get{return _s_pubnum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_PubIssue
		{
			set{ _s_pubissue=value;}
			get{return _s_pubissue;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_PubVol
		{
			set{ _s_pubvol=value;}
			get{return _s_pubvol;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_RenewalFilePath
		{
			set{ _s_renewalfilepath=value;}
			get{return _s_renewalfilepath;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? dt_Effective
		{
			set{ _dt_effective=value;}
			get{return _dt_effective;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? dt_End
		{
			set{ _dt_end=value;}
			get{return _dt_end;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? dt_NextRenewal
		{
			set{ _dt_nextrenewal=value;}
			get{return _dt_nextrenewal;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_RenewalStatus
		{
			set{ _s_renewalstatus=value;}
			get{return _s_renewalstatus;}
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
		public string s_FeeReceivedStatus
		{
			set{ _s_feereceivedstatus=value;}
			get{return _s_feereceivedstatus;}
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
		#endregion Model

	}
}


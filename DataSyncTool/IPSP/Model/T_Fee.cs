/**  版本信息模板在安装目录下，可自行修改。
* T_Fee.cs
*
* 功 能： N/A
* 类 名： T_Fee
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:44:44   N/A    初版
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
	/// T_Fee:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class T_Fee
	{
		public T_Fee()
		{}
		#region Model
		private int _n_feeid;
		private int? _n_feecodeid;
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
		private string _s_officialdiscmark;
		private string _s_officialdiscstyle;
		private decimal? _n_officialdiscount;
		private DateTime? _dt_officialshldpaydate;
		private DateTime? _dt_officialpaydate;
		private string _s_officialreceiptpath;
		private int? _n_payfeelistid;
		private string _s_notes;
		private string _s_invoicenum;
		private decimal? _n_rate;
		private string _s_isactive;
		private DateTime? _dt_createdate;
		private DateTime? _dt_editdate;
		private string _s_feepaymentstatue;
		private string _s_feereceivecashstatue;
		private int? _n_exchangecurrency;
		private int? _n_camefileid;
		private string _s_chargefeename;
		private string _s_officialfeename;
		private string _s_feename;
		private string _s_processmark;
		private int? _n_asker;
		private DateTime? _dt_askdate;
		private int? _n_checker;
		private DateTime? _dt_checkdate;
		private int? _n_payer;
		private DateTime? _dt_paydate;
		private int? _n_receipter;
		private DateTime? _dt_receiptdate;
		private string _s_receiptno;
		private string _s_processnote;
		private string _s_caseserial;
		private string _s_clientcontacts;
		private string _s_appno;
		private DateTime? _dt_appdate;
		private string _s_applicants;
		private string _s_introducer;
		private string _s_attorney;
		private int? _n_patenttypeid;
		private int? _n_fbilllistid;
		private bool _n_bonuscalced;
		private string _s_creator;
		private string _s_editor;
		private int? _n_expenseid;
		private string _s_bonusfeetype;
		private int? _n_maincaseid;
		private string _s_chargenativename;
		private string _s_officialnativename;
		private string _s_reviewstatus;
		private decimal? _n_moreunitcount;
		private string _s_feebeyonditemunit;
		private decimal? _n_chargediscountafeerate;
		private decimal? _n_oriagencyfee;
		private string _s_translatefeediscounttype;
		private decimal? _n_oritranslatecount;
		private int? _n_creatorid;
		private string _s_checkstatus;
		private int _n_billid;
		private string _s_feemode;
		private string _s_elecpayer;
		private string _s_chargingcheckstatus;
		private int? _n_chargingchecker;
		private DateTime? _dt_chargingcheckdate;
		private string _s_chargingnotes;
		/// <summary>
		/// 
		/// </summary>
		public int n_FeeID
		{
			set{ _n_feeid=value;}
			get{return _n_feeid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_FeeCodeID
		{
			set{ _n_feecodeid=value;}
			get{return _n_feecodeid;}
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
		public string s_OfficialDiscMark
		{
			set{ _s_officialdiscmark=value;}
			get{return _s_officialdiscmark;}
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
		public string s_FeePaymentStatue
		{
			set{ _s_feepaymentstatue=value;}
			get{return _s_feepaymentstatue;}
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
		public int? n_CameFileID
		{
			set{ _n_camefileid=value;}
			get{return _n_camefileid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_ChargeFeeName
		{
			set{ _s_chargefeename=value;}
			get{return _s_chargefeename;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_OfficialFeeName
		{
			set{ _s_officialfeename=value;}
			get{return _s_officialfeename;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_FeeName
		{
			set{ _s_feename=value;}
			get{return _s_feename;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_ProcessMark
		{
			set{ _s_processmark=value;}
			get{return _s_processmark;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_Asker
		{
			set{ _n_asker=value;}
			get{return _n_asker;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? dt_AskDate
		{
			set{ _dt_askdate=value;}
			get{return _dt_askdate;}
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
		public int? n_Payer
		{
			set{ _n_payer=value;}
			get{return _n_payer;}
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
		public int? n_Receipter
		{
			set{ _n_receipter=value;}
			get{return _n_receipter;}
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
		public string s_ReceiptNo
		{
			set{ _s_receiptno=value;}
			get{return _s_receiptno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_ProcessNote
		{
			set{ _s_processnote=value;}
			get{return _s_processnote;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_CaseSerial
		{
			set{ _s_caseserial=value;}
			get{return _s_caseserial;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_ClientContacts
		{
			set{ _s_clientcontacts=value;}
			get{return _s_clientcontacts;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_AppNo
		{
			set{ _s_appno=value;}
			get{return _s_appno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? dt_AppDate
		{
			set{ _dt_appdate=value;}
			get{return _dt_appdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_Applicants
		{
			set{ _s_applicants=value;}
			get{return _s_applicants;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_Introducer
		{
			set{ _s_introducer=value;}
			get{return _s_introducer;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_Attorney
		{
			set{ _s_attorney=value;}
			get{return _s_attorney;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_PatentTypeID
		{
			set{ _n_patenttypeid=value;}
			get{return _n_patenttypeid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_FBillListID
		{
			set{ _n_fbilllistid=value;}
			get{return _n_fbilllistid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool n_BonusCalced
		{
			set{ _n_bonuscalced=value;}
			get{return _n_bonuscalced;}
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
		public int? n_ExpenseID
		{
			set{ _n_expenseid=value;}
			get{return _n_expenseid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_BonusFeeType
		{
			set{ _s_bonusfeetype=value;}
			get{return _s_bonusfeetype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_MainCaseID
		{
			set{ _n_maincaseid=value;}
			get{return _n_maincaseid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_ChargeNativeName
		{
			set{ _s_chargenativename=value;}
			get{return _s_chargenativename;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_OfficialNativeName
		{
			set{ _s_officialnativename=value;}
			get{return _s_officialnativename;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_ReviewStatus
		{
			set{ _s_reviewstatus=value;}
			get{return _s_reviewstatus;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? n_moreUnitCount
		{
			set{ _n_moreunitcount=value;}
			get{return _n_moreunitcount;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_feeBeyondItemUnit
		{
			set{ _s_feebeyonditemunit=value;}
			get{return _s_feebeyonditemunit;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? n_ChargeDiscountAFeeRate
		{
			set{ _n_chargediscountafeerate=value;}
			get{return _n_chargediscountafeerate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? n_OriAgencyFee
		{
			set{ _n_oriagencyfee=value;}
			get{return _n_oriagencyfee;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_TransLateFeeDiscountType
		{
			set{ _s_translatefeediscounttype=value;}
			get{return _s_translatefeediscounttype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? n_OriTransLateCount
		{
			set{ _n_oritranslatecount=value;}
			get{return _n_oritranslatecount;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_CreatorID
		{
			set{ _n_creatorid=value;}
			get{return _n_creatorid;}
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
		public int n_BillID
		{
			set{ _n_billid=value;}
			get{return _n_billid;}
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
		public string s_ElecPayer
		{
			set{ _s_elecpayer=value;}
			get{return _s_elecpayer;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_ChargingCheckStatus
		{
			set{ _s_chargingcheckstatus=value;}
			get{return _s_chargingcheckstatus;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_ChargingChecker
		{
			set{ _n_chargingchecker=value;}
			get{return _n_chargingchecker;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? dt_ChargingCheckDate
		{
			set{ _dt_chargingcheckdate=value;}
			get{return _dt_chargingcheckdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_ChargingNotes
		{
			set{ _s_chargingnotes=value;}
			get{return _s_chargingnotes;}
		}
		#endregion Model

	}
}


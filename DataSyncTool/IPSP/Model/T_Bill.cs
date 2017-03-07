/**  版本信息模板在安装目录下，可自行修改。
* T_Bill.cs
*
* 功 能： N/A
* 类 名： T_Bill
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:44:30   N/A    初版
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
	/// T_Bill:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class T_Bill
	{
		public T_Bill()
		{}
		#region Model
		private int _n_billid;
		private string _s_billnum;
		private int? _n_flownum;
		private string _s_status;
		private DateTime? _dt_shldpaydate;
		private DateTime? _dt_confirmdate;
		private int _n_clientid;
		private string _s_reason;
		private string _s_billto;
		private string _s_billtoname;
		private string _s_street;
		private string _s_city;
		private string _s_state;
		private int? _n_country;
		private string _s_zipcode;
		private int? _n_invoicetemplate;
		private int? _n_billcurrency;
		private decimal? _n_rate;
		private int? _n_exchangecurrency;
		private string _s_filepath;
		private DateTime? _dt_createdate;
		private DateTime? _dt_editdate;
		private string _s_isannbill;
		private string _s_billtype;
		private string _s_showzero;
		private decimal? _n_feesum=0M;
		private string _s_creator;
		private string _s_editor;
		private int? _n_modulecheckstatusid;
		private int? _n_latestcheckinfoid;
		private int? _n_authorid;
		private int? _n_curcheckerid;
		private int? _n_maincaseid;
		private int? _n_remindcount;
		private DateTime? _dt_recentreminddate;
		private string _s_caseserial;
		private string _s_appno;
		private string _s_invoicenum;
		private string _s_language;
		private decimal? _n_ofeesum;
		private decimal? _n_afeesum;
		private decimal? _n_tfeesum;
		private DateTime? _dt_billdate;
		private string _s_clientserial;
		private string _s_applicants;
		private decimal? _n_rate2;
		private decimal? _n_feesum2;
		private int? _n_billcurrency2;
		private int? _n_payerid;
		private string _s_payertype;
		private string _s_notes;
		private DateTime? _dt_sendoutdate;
		private int? _n_preferentialcombineid;
		private string _s_email;
		private string _s_checkstatus;
		private int? _n_checker;
		private DateTime? _dt_checkdate;
		private string _s_flag;
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
		public string s_BillNum
		{
			set{ _s_billnum=value;}
			get{return _s_billnum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_FlowNum
		{
			set{ _n_flownum=value;}
			get{return _n_flownum;}
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
		public DateTime? dt_ShldPayDate
		{
			set{ _dt_shldpaydate=value;}
			get{return _dt_shldpaydate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? dt_ConfirmDate
		{
			set{ _dt_confirmdate=value;}
			get{return _dt_confirmdate;}
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
		public string s_Reason
		{
			set{ _s_reason=value;}
			get{return _s_reason;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_BillTo
		{
			set{ _s_billto=value;}
			get{return _s_billto;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_BillToName
		{
			set{ _s_billtoname=value;}
			get{return _s_billtoname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_Street
		{
			set{ _s_street=value;}
			get{return _s_street;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_City
		{
			set{ _s_city=value;}
			get{return _s_city;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_State
		{
			set{ _s_state=value;}
			get{return _s_state;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_Country
		{
			set{ _n_country=value;}
			get{return _n_country;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_ZipCode
		{
			set{ _s_zipcode=value;}
			get{return _s_zipcode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_InvoiceTemplate
		{
			set{ _n_invoicetemplate=value;}
			get{return _n_invoicetemplate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_BillCurrency
		{
			set{ _n_billcurrency=value;}
			get{return _n_billcurrency;}
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
		public int? n_ExchangeCurrency
		{
			set{ _n_exchangecurrency=value;}
			get{return _n_exchangecurrency;}
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
		public string s_IsAnnBill
		{
			set{ _s_isannbill=value;}
			get{return _s_isannbill;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_BillType
		{
			set{ _s_billtype=value;}
			get{return _s_billtype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_ShowZero
		{
			set{ _s_showzero=value;}
			get{return _s_showzero;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? n_FeeSum
		{
			set{ _n_feesum=value;}
			get{return _n_feesum;}
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
		public int? n_MainCaseID
		{
			set{ _n_maincaseid=value;}
			get{return _n_maincaseid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_RemindCount
		{
			set{ _n_remindcount=value;}
			get{return _n_remindcount;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? dt_RecentRemindDate
		{
			set{ _dt_recentreminddate=value;}
			get{return _dt_recentreminddate;}
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
		public string s_AppNo
		{
			set{ _s_appno=value;}
			get{return _s_appno;}
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
		public string s_Language
		{
			set{ _s_language=value;}
			get{return _s_language;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? n_OFeeSum
		{
			set{ _n_ofeesum=value;}
			get{return _n_ofeesum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? n_AFeeSum
		{
			set{ _n_afeesum=value;}
			get{return _n_afeesum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? n_TFeeSum
		{
			set{ _n_tfeesum=value;}
			get{return _n_tfeesum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? dt_BillDate
		{
			set{ _dt_billdate=value;}
			get{return _dt_billdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_ClientSerial
		{
			set{ _s_clientserial=value;}
			get{return _s_clientserial;}
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
		public decimal? n_Rate2
		{
			set{ _n_rate2=value;}
			get{return _n_rate2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? n_FeeSum2
		{
			set{ _n_feesum2=value;}
			get{return _n_feesum2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_BillCurrency2
		{
			set{ _n_billcurrency2=value;}
			get{return _n_billcurrency2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_PayerID
		{
			set{ _n_payerid=value;}
			get{return _n_payerid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_PayerType
		{
			set{ _s_payertype=value;}
			get{return _s_payertype;}
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
		public DateTime? dt_SendOutDate
		{
			set{ _dt_sendoutdate=value;}
			get{return _dt_sendoutdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_PreferentialCombineID
		{
			set{ _n_preferentialcombineid=value;}
			get{return _n_preferentialcombineid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_Email
		{
			set{ _s_email=value;}
			get{return _s_email;}
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
		public string s_Flag
		{
			set{ _s_flag=value;}
			get{return _s_flag;}
		}
		#endregion Model

	}
}


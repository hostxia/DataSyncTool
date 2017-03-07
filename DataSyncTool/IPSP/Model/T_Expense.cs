/**  版本信息模板在安装目录下，可自行修改。
* T_Expense.cs
*
* 功 能： N/A
* 类 名： T_Expense
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:44:42   N/A    初版
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
	/// T_Expense:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class T_Expense
	{
		public T_Expense()
		{}
		#region Model
		private int _n_expenseid;
		private string _s_type;
		private string _s_name;
		private string _s_object;
		private string _s_content;
		private int? _n_currency;
		private decimal? _n_account;
		private DateTime? _dt_shldpaydate;
		private int? _n_creator;
		private string _s_paystatus;
		private string _s_paybillno;
		private DateTime? _dt_paydate;
		private int? _n_payer;
		private string _s_checkstatus;
		private DateTime? _dt_checkdate;
		private int? _n_checker;
		private DateTime? _dt_editdate;
		private DateTime? _dt_createdate;
		private string _s_creator;
		private string _s_editor;
		private int? _n_modulecheckstatusid;
		private int? _n_latestcheckinfoid;
		private int? _n_authorid;
		private int? _n_curcheckerid;
		private int? _n_maincaseid;
		private string _s_notes;
		/// <summary>
		/// 
		/// </summary>
		public int n_ExpenseID
		{
			set{ _n_expenseid=value;}
			get{return _n_expenseid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_Type
		{
			set{ _s_type=value;}
			get{return _s_type;}
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
		public string s_Object
		{
			set{ _s_object=value;}
			get{return _s_object;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_Content
		{
			set{ _s_content=value;}
			get{return _s_content;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_Currency
		{
			set{ _n_currency=value;}
			get{return _n_currency;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? n_Account
		{
			set{ _n_account=value;}
			get{return _n_account;}
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
		public int? n_Creator
		{
			set{ _n_creator=value;}
			get{return _n_creator;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_PayStatus
		{
			set{ _s_paystatus=value;}
			get{return _s_paystatus;}
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
		public DateTime? dt_PayDate
		{
			set{ _dt_paydate=value;}
			get{return _dt_paydate;}
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
		public string s_CheckStatus
		{
			set{ _s_checkstatus=value;}
			get{return _s_checkstatus;}
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
		public int? n_Checker
		{
			set{ _n_checker=value;}
			get{return _n_checker;}
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
		public DateTime? dt_CreateDate
		{
			set{ _dt_createdate=value;}
			get{return _dt_createdate;}
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
		public string s_Notes
		{
			set{ _s_notes=value;}
			get{return _s_notes;}
		}
		#endregion Model

	}
}


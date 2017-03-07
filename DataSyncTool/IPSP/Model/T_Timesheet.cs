/**  版本信息模板在安装目录下，可自行修改。
* T_Timesheet.cs
*
* 功 能： N/A
* 类 名： T_Timesheet
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:45:11   N/A    初版
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
	/// T_Timesheet:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class T_Timesheet
	{
		public T_Timesheet()
		{}
		#region Model
		private int _n_timesheetid;
		private string _s_task;
		private string _s_status;
		private string _s_invoiced;
		private string _s_paid;
		private int? _n_chargecurrency;
		private decimal? _n_rate;
		private int? _n_exchangecurrency;
		private string _s_notes;
		private string _s_isactive;
		private DateTime? _dt_createdate;
		private DateTime? _dt_editdate;
		private string _s_caseserial;
		private string _s_casename;
		private string _s_creator;
		private string _s_editor;
		private int? _n_maincaseid;
		private int? _n_creatorid;
		private string _s_checkstatus;
		private int _n_billid;
		/// <summary>
		/// 
		/// </summary>
		public int n_TimesheetID
		{
			set{ _n_timesheetid=value;}
			get{return _n_timesheetid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_Task
		{
			set{ _s_task=value;}
			get{return _s_task;}
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
		public string s_Invoiced
		{
			set{ _s_invoiced=value;}
			get{return _s_invoiced;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_Paid
		{
			set{ _s_paid=value;}
			get{return _s_paid;}
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
		public string s_Notes
		{
			set{ _s_notes=value;}
			get{return _s_notes;}
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
		public string s_CaseSerial
		{
			set{ _s_caseserial=value;}
			get{return _s_caseserial;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_CaseName
		{
			set{ _s_casename=value;}
			get{return _s_casename;}
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
		public int? n_MainCaseID
		{
			set{ _n_maincaseid=value;}
			get{return _n_maincaseid;}
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
		#endregion Model

	}
}


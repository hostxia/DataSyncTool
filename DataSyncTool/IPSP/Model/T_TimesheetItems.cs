/**  版本信息模板在安装目录下，可自行修改。
* T_TimesheetItems.cs
*
* 功 能： N/A
* 类 名： T_TimesheetItems
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:45:12   N/A    初版
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
	/// T_TimesheetItems:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class T_TimesheetItems
	{
		public T_TimesheetItems()
		{}
		#region Model
		private int _n_id;
		private int _n_timesheetid;
		private int? _n_employeeid;
		private decimal? _n_chargerate;
		private string _s_subtask;
		private DateTime? _dt_startedtime;
		private DateTime? _dt_endtime;
		private decimal? _n_workinghours;
		private decimal? _n_billinghours;
		private string _s_employeename;
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
		public int n_TimesheetID
		{
			set{ _n_timesheetid=value;}
			get{return _n_timesheetid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_EmployeeID
		{
			set{ _n_employeeid=value;}
			get{return _n_employeeid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? n_ChargeRate
		{
			set{ _n_chargerate=value;}
			get{return _n_chargerate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_SubTask
		{
			set{ _s_subtask=value;}
			get{return _s_subtask;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? dt_StartedTime
		{
			set{ _dt_startedtime=value;}
			get{return _dt_startedtime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? dt_EndTime
		{
			set{ _dt_endtime=value;}
			get{return _dt_endtime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? n_WorkingHours
		{
			set{ _n_workinghours=value;}
			get{return _n_workinghours;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? n_BillingHours
		{
			set{ _n_billinghours=value;}
			get{return _n_billinghours;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_EmployeeName
		{
			set{ _s_employeename=value;}
			get{return _s_employeename;}
		}
		#endregion Model

	}
}


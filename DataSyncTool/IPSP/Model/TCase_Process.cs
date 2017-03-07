/**  版本信息模板在安装目录下，可自行修改。
* TCase_Process.cs
*
* 功 能： N/A
* 类 名： TCase_Process
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:45:38   N/A    初版
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
	/// TCase_Process:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TCase_Process
	{
		public TCase_Process()
		{}
		#region Model
		private int _n_id;
		private int _n_caseid;
		private int? _n_ordernum;
		private int _n_processcodeid;
		private DateTime? _dt_startdate;
		private DateTime? _dt_enddate;
		private string _s_status;
		private string _s_notes;
		private int? _n_parentid;
		private string _s_processname;
		private decimal? _n_emintimevalue;
		private string _s_emintimeunit;
		private decimal? _n_emaxtimevalue;
		private string _s_emaxtimeunit;
		private string _s_allowrepeat;
		private string _s_basedate;
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
		public int n_CaseID
		{
			set{ _n_caseid=value;}
			get{return _n_caseid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_OrderNum
		{
			set{ _n_ordernum=value;}
			get{return _n_ordernum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int n_ProcessCodeID
		{
			set{ _n_processcodeid=value;}
			get{return _n_processcodeid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? dt_StartDate
		{
			set{ _dt_startdate=value;}
			get{return _dt_startdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? dt_EndDate
		{
			set{ _dt_enddate=value;}
			get{return _dt_enddate;}
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
		public string s_Notes
		{
			set{ _s_notes=value;}
			get{return _s_notes;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_ParentID
		{
			set{ _n_parentid=value;}
			get{return _n_parentid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_ProcessName
		{
			set{ _s_processname=value;}
			get{return _s_processname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? n_EMinTimeValue
		{
			set{ _n_emintimevalue=value;}
			get{return _n_emintimevalue;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_EMinTimeUnit
		{
			set{ _s_emintimeunit=value;}
			get{return _s_emintimeunit;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? n_EMaxTimeValue
		{
			set{ _n_emaxtimevalue=value;}
			get{return _n_emaxtimevalue;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_EMaxTimeUnit
		{
			set{ _s_emaxtimeunit=value;}
			get{return _s_emaxtimeunit;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_AllowRepeat
		{
			set{ _s_allowrepeat=value;}
			get{return _s_allowrepeat;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_BaseDate
		{
			set{ _s_basedate=value;}
			get{return _s_basedate;}
		}
		#endregion Model

	}
}


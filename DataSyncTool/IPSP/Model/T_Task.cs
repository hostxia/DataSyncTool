/**  版本信息模板在安装目录下，可自行修改。
* T_Task.cs
*
* 功 能： N/A
* 类 名： T_Task
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:45:05   N/A    初版
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
	/// T_Task:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class T_Task
	{
		public T_Task()
		{}
		#region Model
		private int _n_taskid;
		private string _s_tasktype;
		private int? _n_systaskcodeid;
		private int? _n_employeeid;
		private string _s_tasktoemail;
		private string _s_level;
		private string _s_taskname;
		private string _s_taskdetail;
		private DateTime? _dt_alarmdate;
		private DateTime? _dt_interdeadline;
		private DateTime? _dt_clientdeadline;
		private DateTime? _dt_officialdeadline;
		private DateTime? _dt_deadline;
		private string _s_status;
		private DateTime? _dt_statusdate;
		private string _s_isactive;
		private DateTime? _dt_createdate;
		private DateTime? _dt_editdate;
		private int _n_fileid;
		private string _s_taskto;
		private int? _n_camefileid;
		private int _n_outfileid;
		private int _n_feeid;
		private int _n_billid;
		private string _s_applicants;
		private string _s_caseserial;
		private string _s_country;
		private string _s_appno;
		private string _s_introducer;
		private string _s_attorney;
		private string _s_creator;
		private string _s_editor;
		private string _s_inrecycle;
		private int? _n_modulecheckstatusid;
		private int? _n_latestcheckinfoid;
		private int? _n_authorid;
		private int? _n_curcheckerid;
		private string _s_taskresult;
		private int? _n_maincaseid;
		private string _s_category;
		private string _s_renewaldeadline;
		/// <summary>
		/// 
		/// </summary>
		public int n_TaskID
		{
			set{ _n_taskid=value;}
			get{return _n_taskid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_TaskType
		{
			set{ _s_tasktype=value;}
			get{return _s_tasktype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_SysTaskCodeID
		{
			set{ _n_systaskcodeid=value;}
			get{return _n_systaskcodeid;}
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
		public string s_TaskToEmail
		{
			set{ _s_tasktoemail=value;}
			get{return _s_tasktoemail;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_Level
		{
			set{ _s_level=value;}
			get{return _s_level;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_TaskName
		{
			set{ _s_taskname=value;}
			get{return _s_taskname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_TaskDetail
		{
			set{ _s_taskdetail=value;}
			get{return _s_taskdetail;}
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
		public DateTime? dt_InterDeadline
		{
			set{ _dt_interdeadline=value;}
			get{return _dt_interdeadline;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? dt_ClientDeadline
		{
			set{ _dt_clientdeadline=value;}
			get{return _dt_clientdeadline;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? dt_OfficialDeadline
		{
			set{ _dt_officialdeadline=value;}
			get{return _dt_officialdeadline;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? dt_Deadline
		{
			set{ _dt_deadline=value;}
			get{return _dt_deadline;}
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
		public DateTime? dt_StatusDate
		{
			set{ _dt_statusdate=value;}
			get{return _dt_statusdate;}
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
		public int n_FileID
		{
			set{ _n_fileid=value;}
			get{return _n_fileid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_TaskTo
		{
			set{ _s_taskto=value;}
			get{return _s_taskto;}
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
		public int n_OutFileID
		{
			set{ _n_outfileid=value;}
			get{return _n_outfileid;}
		}
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
		public int n_BillID
		{
			set{ _n_billid=value;}
			get{return _n_billid;}
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
		public string s_CaseSerial
		{
			set{ _s_caseserial=value;}
			get{return _s_caseserial;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_Country
		{
			set{ _s_country=value;}
			get{return _s_country;}
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
		public string s_InRecycle
		{
			set{ _s_inrecycle=value;}
			get{return _s_inrecycle;}
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
		public string s_TaskResult
		{
			set{ _s_taskresult=value;}
			get{return _s_taskresult;}
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
		public string s_Category
		{
			set{ _s_category=value;}
			get{return _s_category;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_RenewalDeadline
		{
			set{ _s_renewaldeadline=value;}
			get{return _s_renewaldeadline;}
		}
		#endregion Model

	}
}


/**  版本信息模板在安装目录下，可自行修改。
* TCode_SysTasks.cs
*
* 功 能： N/A
* 类 名： TCode_SysTasks
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:47:08   N/A    初版
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
	/// TCode_SysTasks:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TCode_SysTasks
	{
		public TCode_SysTasks()
		{}
		#region Model
		private int _n_id;
		private string _s_iptype;
		private int? _n_regcountry;
		private string _s_systaskcode;
		private string _s_taskname;
		private string _s_othername;
		private string _s_taskdesc;
		private string _s_business;
		private string _s_ptctype;
		private int? _n_processid;
		private string _s_isactive;
		private string _s_basefield;
		private int? _n_alarmdays;
		private int? _n_alarmmonths;
		private string _s_alarmcalcorder;
		private int? _n_officialdeaddays;
		private int? _n_officialdeadmonths;
		private string _s_officialdeadcalcorder;
		private int? _n_clientdeaddays;
		private int? _n_clientdeadmonths;
		private string _s_clientdeadcalcorder;
		private int? _n_interdeaddays;
		private int? _n_interdeadmonths;
		private string _s_interdeadcalcorder;
		private string _s_tasktype;
		private int? _n_employeeid;
		private string _s_sysconfiguretask;
		private DateTime? _dt_createdate;
		private DateTime? _dt_editdate;
		private string _s_tapplytype;
		private string _s_officialdeadm;
		private string _s_clientdeadm;
		private string _s_interdeadm;
		private string _s_dealer;
		private string _s_issystem;
		private string _s_autosendemail;
		private string _s_priority;
		private string _s_changedatesendemail;
		private string _s_relatedelement;
		private string _s_relatedelementstatus;
		private string _s_autofinished;
		private string _s_remindwithcreating;
		private string _s_relationer;
		private string _s_category;
		private string _s_systasktype;
		private string _s_sysflowdirection;
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
		public string s_IPType
		{
			set{ _s_iptype=value;}
			get{return _s_iptype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_RegCountry
		{
			set{ _n_regcountry=value;}
			get{return _n_regcountry;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_SysTaskCode
		{
			set{ _s_systaskcode=value;}
			get{return _s_systaskcode;}
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
		public string s_OtherName
		{
			set{ _s_othername=value;}
			get{return _s_othername;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_TaskDesc
		{
			set{ _s_taskdesc=value;}
			get{return _s_taskdesc;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_Business
		{
			set{ _s_business=value;}
			get{return _s_business;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_PTCType
		{
			set{ _s_ptctype=value;}
			get{return _s_ptctype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_ProcessID
		{
			set{ _n_processid=value;}
			get{return _n_processid;}
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
		public string s_BaseField
		{
			set{ _s_basefield=value;}
			get{return _s_basefield;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_AlarmDays
		{
			set{ _n_alarmdays=value;}
			get{return _n_alarmdays;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_AlarmMonths
		{
			set{ _n_alarmmonths=value;}
			get{return _n_alarmmonths;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_AlarmCalcOrder
		{
			set{ _s_alarmcalcorder=value;}
			get{return _s_alarmcalcorder;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_OfficialDeadDays
		{
			set{ _n_officialdeaddays=value;}
			get{return _n_officialdeaddays;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_OfficialDeadMonths
		{
			set{ _n_officialdeadmonths=value;}
			get{return _n_officialdeadmonths;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_OfficialDeadCalcOrder
		{
			set{ _s_officialdeadcalcorder=value;}
			get{return _s_officialdeadcalcorder;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_ClientDeadDays
		{
			set{ _n_clientdeaddays=value;}
			get{return _n_clientdeaddays;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_ClientDeadMonths
		{
			set{ _n_clientdeadmonths=value;}
			get{return _n_clientdeadmonths;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_ClientDeadCalcOrder
		{
			set{ _s_clientdeadcalcorder=value;}
			get{return _s_clientdeadcalcorder;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_InterDeadDays
		{
			set{ _n_interdeaddays=value;}
			get{return _n_interdeaddays;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_InterDeadMonths
		{
			set{ _n_interdeadmonths=value;}
			get{return _n_interdeadmonths;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_InterDeadCalcOrder
		{
			set{ _s_interdeadcalcorder=value;}
			get{return _s_interdeadcalcorder;}
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
		public int? n_EmployeeID
		{
			set{ _n_employeeid=value;}
			get{return _n_employeeid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_SysConfigureTask
		{
			set{ _s_sysconfiguretask=value;}
			get{return _s_sysconfiguretask;}
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
		public string s_TApplyType
		{
			set{ _s_tapplytype=value;}
			get{return _s_tapplytype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_OfficialDeadM
		{
			set{ _s_officialdeadm=value;}
			get{return _s_officialdeadm;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_ClientDeadM
		{
			set{ _s_clientdeadm=value;}
			get{return _s_clientdeadm;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_InterDeadM
		{
			set{ _s_interdeadm=value;}
			get{return _s_interdeadm;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_Dealer
		{
			set{ _s_dealer=value;}
			get{return _s_dealer;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_IsSystem
		{
			set{ _s_issystem=value;}
			get{return _s_issystem;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_AutoSendEmail
		{
			set{ _s_autosendemail=value;}
			get{return _s_autosendemail;}
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
		public string s_ChangeDateSendEmail
		{
			set{ _s_changedatesendemail=value;}
			get{return _s_changedatesendemail;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_RelatedElement
		{
			set{ _s_relatedelement=value;}
			get{return _s_relatedelement;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_RelatedElementStatus
		{
			set{ _s_relatedelementstatus=value;}
			get{return _s_relatedelementstatus;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_AutoFinished
		{
			set{ _s_autofinished=value;}
			get{return _s_autofinished;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_RemindWithCreating
		{
			set{ _s_remindwithcreating=value;}
			get{return _s_remindwithcreating;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_Relationer
		{
			set{ _s_relationer=value;}
			get{return _s_relationer;}
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
		public string s_SysTaskType
		{
			set{ _s_systasktype=value;}
			get{return _s_systasktype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_SysFlowDirection
		{
			set{ _s_sysflowdirection=value;}
			get{return _s_sysflowdirection;}
		}
		#endregion Model

	}
}


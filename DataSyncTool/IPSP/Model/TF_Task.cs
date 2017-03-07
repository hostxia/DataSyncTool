/**  版本信息模板在安装目录下，可自行修改。
* TF_Task.cs
*
* 功 能： N/A
* 类 名： TF_Task
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:48:17   N/A    初版
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
	/// TF_Task:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TF_Task
	{
		public TF_Task()
		{}
		#region Model
		private Guid _g_id;
		private string _s_name;
		private string _s_description;
		private string _s_state;
		private string _s_readstate;
		private int? _n_level;
		private int? _n_urgencyid;
		private int? _n_executorid;
		private int? _n_executepositionid;
		private int? _n_mentorid;
		private DateTime? _dt_finishtime;
		private DateTime? _dt_startdate;
		private DateTime? _dt_enddate;
		private int? _n_creator;
		private DateTime? _dt_createtime;
		private int? _n_editor;
		private DateTime? _dt_edittime;
		private string _s_taskconfigtype;
		private int? _n_relateddeadlineid;
		private int? _n_monitoremployeeid;
		private int? _b_monitor;
		private string _s_note;
		private int? _n_tasktypeid;
		private int? _n_operator;
		private Guid _g_taskcycleconfigguid;
		private int _n_num;
		private int? _n_finisher;
		private string _s_notes;
		private string _s_manualupdatedeadline;
		/// <summary>
		/// 
		/// </summary>
		public Guid g_ID
		{
			set{ _g_id=value;}
			get{return _g_id;}
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
		public string s_Description
		{
			set{ _s_description=value;}
			get{return _s_description;}
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
		public string s_ReadState
		{
			set{ _s_readstate=value;}
			get{return _s_readstate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_Level
		{
			set{ _n_level=value;}
			get{return _n_level;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_UrgencyID
		{
			set{ _n_urgencyid=value;}
			get{return _n_urgencyid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_ExecutorID
		{
			set{ _n_executorid=value;}
			get{return _n_executorid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_ExecutePositionID
		{
			set{ _n_executepositionid=value;}
			get{return _n_executepositionid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_MentorID
		{
			set{ _n_mentorid=value;}
			get{return _n_mentorid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? dt_FinishTime
		{
			set{ _dt_finishtime=value;}
			get{return _dt_finishtime;}
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
		public int? n_Creator
		{
			set{ _n_creator=value;}
			get{return _n_creator;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? dt_CreateTime
		{
			set{ _dt_createtime=value;}
			get{return _dt_createtime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_Editor
		{
			set{ _n_editor=value;}
			get{return _n_editor;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? dt_EditTime
		{
			set{ _dt_edittime=value;}
			get{return _dt_edittime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_TaskConfigType
		{
			set{ _s_taskconfigtype=value;}
			get{return _s_taskconfigtype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_RelatedDeadlineID
		{
			set{ _n_relateddeadlineid=value;}
			get{return _n_relateddeadlineid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_MonitorEmployeeID
		{
			set{ _n_monitoremployeeid=value;}
			get{return _n_monitoremployeeid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? b_Monitor
		{
			set{ _b_monitor=value;}
			get{return _b_monitor;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_Note
		{
			set{ _s_note=value;}
			get{return _s_note;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_TaskTypeID
		{
			set{ _n_tasktypeid=value;}
			get{return _n_tasktypeid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_Operator
		{
			set{ _n_operator=value;}
			get{return _n_operator;}
		}
		/// <summary>
		/// 
		/// </summary>
		public Guid g_TaskCycleConfigGuid
		{
			set{ _g_taskcycleconfigguid=value;}
			get{return _g_taskcycleconfigguid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int n_Num
		{
			set{ _n_num=value;}
			get{return _n_num;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_Finisher
		{
			set{ _n_finisher=value;}
			get{return _n_finisher;}
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
		public string s_ManualUpdateDeadline
		{
			set{ _s_manualupdatedeadline=value;}
			get{return _s_manualupdatedeadline;}
		}
		#endregion Model

	}
}


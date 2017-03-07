/**  版本信息模板在安装目录下，可自行修改。
* T_Monitor.cs
*
* 功 能： N/A
* 类 名： T_Monitor
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:44:56   N/A    初版
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
	/// T_Monitor:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class T_Monitor
	{
		public T_Monitor()
		{}
		#region Model
		private int _n_monitorid;
		private string _s_title;
		private string _s_detail;
		private DateTime? _dt_monitordate;
		private string _s_objtype;
		private int? _n_govofficeid;
		private int? _n_clientid;
		private DateTime? _dt_begindate;
		private string _s_status;
		private string _s_isactive;
		private DateTime? _dt_createdate;
		private DateTime? _dt_editdate;
		private string _s_caseserial;
		private string _s_appno;
		private string _s_creator;
		private string _s_editor;
		private int? _n_maincaseid;
		private int? _n_creatorid;
		/// <summary>
		/// 
		/// </summary>
		public int n_MonitorID
		{
			set{ _n_monitorid=value;}
			get{return _n_monitorid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_Title
		{
			set{ _s_title=value;}
			get{return _s_title;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_Detail
		{
			set{ _s_detail=value;}
			get{return _s_detail;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? dt_MonitorDate
		{
			set{ _dt_monitordate=value;}
			get{return _dt_monitordate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_ObjType
		{
			set{ _s_objtype=value;}
			get{return _s_objtype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_GovOfficeID
		{
			set{ _n_govofficeid=value;}
			get{return _n_govofficeid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_ClientID
		{
			set{ _n_clientid=value;}
			get{return _n_clientid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? dt_BeginDate
		{
			set{ _dt_begindate=value;}
			get{return _dt_begindate;}
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
		public string s_AppNo
		{
			set{ _s_appno=value;}
			get{return _s_appno;}
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
		#endregion Model

	}
}


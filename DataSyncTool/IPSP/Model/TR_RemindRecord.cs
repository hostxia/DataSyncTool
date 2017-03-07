/**  版本信息模板在安装目录下，可自行修改。
* TR_RemindRecord.cs
*
* 功 能： N/A
* 类 名： TR_RemindRecord
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:50:00   N/A    初版
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
	/// TR_RemindRecord:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TR_RemindRecord
	{
		public TR_RemindRecord()
		{}
		#region Model
		private Guid _g_id;
		private string _s_remindmode;
		private int? _n_employeeid;
		private string _s_state;
		private string _s_title;
		private string _s_content;
		private DateTime? _dt_statetime;
		private DateTime? _dt_createtime;
		private Guid _g_remindmodeid;
		private string _s_valid;
		private int _n_num;
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
		public string s_RemindMode
		{
			set{ _s_remindmode=value;}
			get{return _s_remindmode;}
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
		public string s_State
		{
			set{ _s_state=value;}
			get{return _s_state;}
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
		public string s_Content
		{
			set{ _s_content=value;}
			get{return _s_content;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? dt_StateTime
		{
			set{ _dt_statetime=value;}
			get{return _dt_statetime;}
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
		public Guid g_RemindModeID
		{
			set{ _g_remindmodeid=value;}
			get{return _g_remindmodeid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_Valid
		{
			set{ _s_valid=value;}
			get{return _s_valid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int n_Num
		{
			set{ _n_num=value;}
			get{return _n_num;}
		}
		#endregion Model

	}
}


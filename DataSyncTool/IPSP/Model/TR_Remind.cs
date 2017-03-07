/**  版本信息模板在安装目录下，可自行修改。
* TR_Remind.cs
*
* 功 能： N/A
* 类 名： TR_Remind
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:49:56   N/A    初版
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
	/// TR_Remind:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TR_Remind
	{
		public TR_Remind()
		{}
		#region Model
		private Guid _g_id;
		private Guid _g_coderemindid;
		private string _s_triggertype;
		private string _s_triggerid;
		private string _s_state;
		private int? _n_remindcount;
		private DateTime? _dt_reminddate;
		private string _s_remindtype;
		private string _s_remindpara;
		private int? _n_creator;
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
		public Guid g_CodeRemindID
		{
			set{ _g_coderemindid=value;}
			get{return _g_coderemindid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_TriggerType
		{
			set{ _s_triggertype=value;}
			get{return _s_triggertype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_TriggerID
		{
			set{ _s_triggerid=value;}
			get{return _s_triggerid;}
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
		public int? n_RemindCount
		{
			set{ _n_remindcount=value;}
			get{return _n_remindcount;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? dt_RemindDate
		{
			set{ _dt_reminddate=value;}
			get{return _dt_reminddate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_RemindType
		{
			set{ _s_remindtype=value;}
			get{return _s_remindtype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_RemindPara
		{
			set{ _s_remindpara=value;}
			get{return _s_remindpara;}
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


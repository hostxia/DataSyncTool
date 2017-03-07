/**  版本信息模板在安装目录下，可自行修改。
* TRCode_Remind.cs
*
* 功 能： N/A
* 类 名： TRCode_Remind
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:50:02   N/A    初版
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
	/// TRCode_Remind:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TRCode_Remind
	{
		public TRCode_Remind()
		{}
		#region Model
		private Guid _g_id;
		private string _s_triggertype;
		private string _s_triggerconfigid;
		private string _s_remindtype;
		private string _s_remindpara;
		private string _s_reminddatepara;
		private string _s_description;
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
		public string s_TriggerType
		{
			set{ _s_triggertype=value;}
			get{return _s_triggertype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_TriggerConfigID
		{
			set{ _s_triggerconfigid=value;}
			get{return _s_triggerconfigid;}
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
		public string s_RemindDatePara
		{
			set{ _s_reminddatepara=value;}
			get{return _s_reminddatepara;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_Description
		{
			set{ _s_description=value;}
			get{return _s_description;}
		}
		#endregion Model

	}
}


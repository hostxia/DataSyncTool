/**  版本信息模板在安装目录下，可自行修改。
* TR_RemindMode.cs
*
* 功 能： N/A
* 类 名： TR_RemindMode
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:49:58   N/A    初版
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
	/// TR_RemindMode:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TR_RemindMode
	{
		public TR_RemindMode()
		{}
		#region Model
		private Guid _g_id;
		private Guid _g_remindid;
		private string _s_remindmode;
		private string _s_remindobjecttype;
		private string _s_remindobjectid;
		private Guid _g_remindtemplateid;
		private string _s_title;
		private string _s_content;
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
		public Guid g_RemindID
		{
			set{ _g_remindid=value;}
			get{return _g_remindid;}
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
		public string s_RemindObjectType
		{
			set{ _s_remindobjecttype=value;}
			get{return _s_remindobjecttype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_RemindObjectID
		{
			set{ _s_remindobjectid=value;}
			get{return _s_remindobjectid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public Guid g_RemindTemplateID
		{
			set{ _g_remindtemplateid=value;}
			get{return _g_remindtemplateid;}
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
		#endregion Model

	}
}


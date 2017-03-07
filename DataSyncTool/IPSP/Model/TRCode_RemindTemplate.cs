/**  版本信息模板在安装目录下，可自行修改。
* TRCode_RemindTemplate.cs
*
* 功 能： N/A
* 类 名： TRCode_RemindTemplate
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:50:07   N/A    初版
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
	/// TRCode_RemindTemplate:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TRCode_RemindTemplate
	{
		public TRCode_RemindTemplate()
		{}
		#region Model
		private Guid _g_id;
		private string _s_name;
		private string _s_title;
		private string _s_content;
		private string _s_path;
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
		public string s_Name
		{
			set{ _s_name=value;}
			get{return _s_name;}
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
		public string s_Path
		{
			set{ _s_path=value;}
			get{return _s_path;}
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


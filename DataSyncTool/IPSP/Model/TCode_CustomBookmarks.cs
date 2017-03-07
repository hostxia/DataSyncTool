/**  版本信息模板在安装目录下，可自行修改。
* TCode_CustomBookmarks.cs
*
* 功 能： N/A
* 类 名： TCode_CustomBookmarks
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:46:07   N/A    初版
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
	/// TCode_CustomBookmarks:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TCode_CustomBookmarks
	{
		public TCode_CustomBookmarks()
		{}
		#region Model
		private int _n_id;
		private string _s_name;
		private string _s_bookmarkname;
		private string _s_procname;
		private string _s_casetype;
		private string _s_xpobject;
		private string _s_fieldname;
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
		public string s_Name
		{
			set{ _s_name=value;}
			get{return _s_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_BookMarkName
		{
			set{ _s_bookmarkname=value;}
			get{return _s_bookmarkname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_ProcName
		{
			set{ _s_procname=value;}
			get{return _s_procname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_CaseType
		{
			set{ _s_casetype=value;}
			get{return _s_casetype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_XPObject
		{
			set{ _s_xpobject=value;}
			get{return _s_xpobject;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_FieldName
		{
			set{ _s_fieldname=value;}
			get{return _s_fieldname;}
		}
		#endregion Model

	}
}


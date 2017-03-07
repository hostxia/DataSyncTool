/**  版本信息模板在安装目录下，可自行修改。
* TCode_GridLayout.cs
*
* 功 能： N/A
* 类 名： TCode_GridLayout
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:46:29   N/A    初版
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
	/// TCode_GridLayout:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TCode_GridLayout
	{
		public TCode_GridLayout()
		{}
		#region Model
		private int _n_id;
		private string _s_modulename;
		private string _s_layoutname;
		private string _s_layoutxml;
		private string _s_issystemlayout;
		private DateTime? _dt_createdate;
		private DateTime? _dt_editdate;
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
		public string s_ModuleName
		{
			set{ _s_modulename=value;}
			get{return _s_modulename;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_LayoutName
		{
			set{ _s_layoutname=value;}
			get{return _s_layoutname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_LayoutXml
		{
			set{ _s_layoutxml=value;}
			get{return _s_layoutxml;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_IsSystemLayout
		{
			set{ _s_issystemlayout=value;}
			get{return _s_issystemlayout;}
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
		#endregion Model

	}
}


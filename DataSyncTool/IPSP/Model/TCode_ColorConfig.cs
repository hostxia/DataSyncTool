/**  版本信息模板在安装目录下，可自行修改。
* TCode_ColorConfig.cs
*
* 功 能： N/A
* 类 名： TCode_ColorConfig
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:46:03   N/A    初版
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
	/// TCode_ColorConfig:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TCode_ColorConfig
	{
		public TCode_ColorConfig()
		{}
		#region Model
		private int _n_id;
		private string _s_modulename;
		private string _s_datefieldname;
		private decimal? _n_absday;
		private string _s_forecolor;
		private string _s_backcolor;
		private string _s_typefortask;
		private string _s_tooltip;
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
		public string s_DateFieldName
		{
			set{ _s_datefieldname=value;}
			get{return _s_datefieldname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? n_AbsDay
		{
			set{ _n_absday=value;}
			get{return _n_absday;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_ForeColor
		{
			set{ _s_forecolor=value;}
			get{return _s_forecolor;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_BackColor
		{
			set{ _s_backcolor=value;}
			get{return _s_backcolor;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_TypeForTask
		{
			set{ _s_typefortask=value;}
			get{return _s_typefortask;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_ToolTip
		{
			set{ _s_tooltip=value;}
			get{return _s_tooltip;}
		}
		#endregion Model

	}
}


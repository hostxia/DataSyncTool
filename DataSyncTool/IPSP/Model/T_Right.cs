/**  版本信息模板在安装目录下，可自行修改。
* T_Right.cs
*
* 功 能： N/A
* 类 名： T_Right
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:45:00   N/A    初版
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
	/// T_Right:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class T_Right
	{
		public T_Right()
		{}
		#region Model
		private int _n_rightid;
		private string _s_rightname;
		private int? _n_parentid;
		private string _s_description;
		private string _s_codename;
		private string _s_frommodule;
		/// <summary>
		/// 
		/// </summary>
		public int n_RightID
		{
			set{ _n_rightid=value;}
			get{return _n_rightid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_RightName
		{
			set{ _s_rightname=value;}
			get{return _s_rightname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_ParentID
		{
			set{ _n_parentid=value;}
			get{return _n_parentid;}
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
		public string s_CodeName
		{
			set{ _s_codename=value;}
			get{return _s_codename;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_FromModule
		{
			set{ _s_frommodule=value;}
			get{return _s_frommodule;}
		}
		#endregion Model

	}
}


/**  版本信息模板在安装目录下，可自行修改。
* T_AssignRule.cs
*
* 功 能： N/A
* 类 名： T_AssignRule
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:44:29   N/A    初版
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
	/// T_AssignRule:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class T_AssignRule
	{
		public T_AssignRule()
		{}
		#region Model
		private string _s_assigntype;
		private int? _n_assignid;
		private string _s_assignuser;
		/// <summary>
		/// 
		/// </summary>
		public string s_AssignType
		{
			set{ _s_assigntype=value;}
			get{return _s_assigntype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_AssignID
		{
			set{ _n_assignid=value;}
			get{return _n_assignid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_AssignUser
		{
			set{ _s_assignuser=value;}
			get{return _s_assignuser;}
		}
		#endregion Model

	}
}


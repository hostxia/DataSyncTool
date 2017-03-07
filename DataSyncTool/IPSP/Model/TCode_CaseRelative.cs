/**  版本信息模板在安装目录下，可自行修改。
* TCode_CaseRelative.cs
*
* 功 能： N/A
* 类 名： TCode_CaseRelative
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:45:56   N/A    初版
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
	/// TCode_CaseRelative:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TCode_CaseRelative
	{
		public TCode_CaseRelative()
		{}
		#region Model
		private int _n_id;
		private string _s_iptype;
		private string _s_relatename;
		private string _s_mastername;
		private string _s_slavename;
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
		public string s_IPType
		{
			set{ _s_iptype=value;}
			get{return _s_iptype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_RelateName
		{
			set{ _s_relatename=value;}
			get{return _s_relatename;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_MasterName
		{
			set{ _s_mastername=value;}
			get{return _s_mastername;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_SlaveName
		{
			set{ _s_slavename=value;}
			get{return _s_slavename;}
		}
		#endregion Model

	}
}


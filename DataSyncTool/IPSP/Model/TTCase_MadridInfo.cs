/**  版本信息模板在安装目录下，可自行修改。
* TTCase_MadridInfo.cs
*
* 功 能： N/A
* 类 名： TTCase_MadridInfo
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:50:44   N/A    初版
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
	/// TTCase_MadridInfo:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TTCase_MadridInfo
	{
		public TTCase_MadridInfo()
		{}
		#region Model
		private int _n_id;
		private int _n_caseid;
		private int? _n_madappcaseid;
		private string _s_isallcountry;
		private string _s_isallgoods;
		private string _s_notes;
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
		public int n_CaseID
		{
			set{ _n_caseid=value;}
			get{return _n_caseid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_MadAppCaseID
		{
			set{ _n_madappcaseid=value;}
			get{return _n_madappcaseid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_IsAllCountry
		{
			set{ _s_isallcountry=value;}
			get{return _s_isallcountry;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_IsAllGoods
		{
			set{ _s_isallgoods=value;}
			get{return _s_isallgoods;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_Notes
		{
			set{ _s_notes=value;}
			get{return _s_notes;}
		}
		#endregion Model

	}
}


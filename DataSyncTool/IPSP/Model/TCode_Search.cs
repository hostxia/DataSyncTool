/**  版本信息模板在安装目录下，可自行修改。
* TCode_Search.cs
*
* 功 能： N/A
* 类 名： TCode_Search
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:46:55   N/A    初版
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
	/// TCode_Search:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TCode_Search
	{
		public TCode_Search()
		{}
		#region Model
		private int _n_searchid;
		private string _s_searchcondition;
		private string _s_orderby;
		private string _s_searchname;
		private string _s_issystemsearch;
		private string _s_modulename;
		private int? _n_sequence;
		private DateTime? _dt_createdate;
		private DateTime? _dt_editdate;
		private string _s_description;
		private string _s_iptype;
		private int? _n_employeeid;
		/// <summary>
		/// 
		/// </summary>
		public int n_SearchID
		{
			set{ _n_searchid=value;}
			get{return _n_searchid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_SearchCondition
		{
			set{ _s_searchcondition=value;}
			get{return _s_searchcondition;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_OrderBy
		{
			set{ _s_orderby=value;}
			get{return _s_orderby;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_SearchName
		{
			set{ _s_searchname=value;}
			get{return _s_searchname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_IsSystemSearch
		{
			set{ _s_issystemsearch=value;}
			get{return _s_issystemsearch;}
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
		public int? n_Sequence
		{
			set{ _n_sequence=value;}
			get{return _n_sequence;}
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
		public string s_IPType
		{
			set{ _s_iptype=value;}
			get{return _s_iptype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_EmployeeID
		{
			set{ _n_employeeid=value;}
			get{return _n_employeeid;}
		}
		#endregion Model

	}
}


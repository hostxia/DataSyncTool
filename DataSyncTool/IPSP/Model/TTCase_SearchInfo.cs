/**  版本信息模板在安装目录下，可自行修改。
* TTCase_SearchInfo.cs
*
* 功 能： N/A
* 类 名： TTCase_SearchInfo
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:51:04   N/A    初版
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
	/// TTCase_SearchInfo:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TTCase_SearchInfo
	{
		public TTCase_SearchInfo()
		{}
		#region Model
		private int _n_id;
		private int _n_caseid;
		private string _s_searchaim;
		private string _s_searchtype;
		private string _s_reqdesc;
		private string _s_searchnumber;
		private string _s_appnumber;
		private string _s_searchappdate;
		private DateTime? _dt_appdate;
		private string _s_searchapplicant;
		private string _s_applicant;
		private string _s_searchtmname;
		private string _s_tmname;
		private string _s_searchresult;
		private DateTime? _dt_searchdate;
		private string _s_searchtypecode;
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
		public string s_SearchAim
		{
			set{ _s_searchaim=value;}
			get{return _s_searchaim;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_SearchType
		{
			set{ _s_searchtype=value;}
			get{return _s_searchtype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_ReqDesc
		{
			set{ _s_reqdesc=value;}
			get{return _s_reqdesc;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_SearchNumber
		{
			set{ _s_searchnumber=value;}
			get{return _s_searchnumber;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_AppNumber
		{
			set{ _s_appnumber=value;}
			get{return _s_appnumber;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_SearchAppDate
		{
			set{ _s_searchappdate=value;}
			get{return _s_searchappdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? dt_AppDate
		{
			set{ _dt_appdate=value;}
			get{return _dt_appdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_SearchApplicant
		{
			set{ _s_searchapplicant=value;}
			get{return _s_searchapplicant;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_Applicant
		{
			set{ _s_applicant=value;}
			get{return _s_applicant;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_SearchTMName
		{
			set{ _s_searchtmname=value;}
			get{return _s_searchtmname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_TMName
		{
			set{ _s_tmname=value;}
			get{return _s_tmname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_SearchResult
		{
			set{ _s_searchresult=value;}
			get{return _s_searchresult;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? dt_SearchDate
		{
			set{ _dt_searchdate=value;}
			get{return _dt_searchdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_SearchTypeCode
		{
			set{ _s_searchtypecode=value;}
			get{return _s_searchtypecode;}
		}
		#endregion Model

	}
}


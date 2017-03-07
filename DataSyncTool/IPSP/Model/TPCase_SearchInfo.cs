/**  版本信息模板在安装目录下，可自行修改。
* TPCase_SearchInfo.cs
*
* 功 能： N/A
* 类 名： TPCase_SearchInfo
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:49:48   N/A    初版
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
	/// TPCase_SearchInfo:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TPCase_SearchInfo
	{
		public TPCase_SearchInfo()
		{}
		#region Model
		private int _n_id;
		private int _n_caseid;
		private string _s_property;
		private string _s_aim;
		private string _s_searchtype;
		private string _s_reqdesc;
		private string _s_searchappnumber;
		private string _s_appnumber;
		private string _s_searchappdate;
		private DateTime? _dt_appdate;
		private string _s_searchapplicant;
		private string _s_applicant;
		private string _s_searchpatentname;
		private string _s_patentname;
		private string _s_result;
		private DateTime? _dt_fulfilldate;
		private string _s_searchnotes;
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
		public string s_Property
		{
			set{ _s_property=value;}
			get{return _s_property;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_Aim
		{
			set{ _s_aim=value;}
			get{return _s_aim;}
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
		public string s_SearchAppNumber
		{
			set{ _s_searchappnumber=value;}
			get{return _s_searchappnumber;}
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
		public string s_SearchPatentName
		{
			set{ _s_searchpatentname=value;}
			get{return _s_searchpatentname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_PatentName
		{
			set{ _s_patentname=value;}
			get{return _s_patentname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_Result
		{
			set{ _s_result=value;}
			get{return _s_result;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? dt_FulFillDate
		{
			set{ _dt_fulfilldate=value;}
			get{return _dt_fulfilldate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_SearchNotes
		{
			set{ _s_searchnotes=value;}
			get{return _s_searchnotes;}
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


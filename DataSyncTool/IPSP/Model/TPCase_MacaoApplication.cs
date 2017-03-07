/**  版本信息模板在安装目录下，可自行修改。
* TPCase_MacaoApplication.cs
*
* 功 能： N/A
* 类 名： TPCase_MacaoApplication
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:49:29   N/A    初版
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
	/// TPCase_MacaoApplication:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TPCase_MacaoApplication
	{
		public TPCase_MacaoApplication()
		{}
		#region Model
		private int _n_caseid;
		private string _s_parentcaseserial;
		private string _s_parentcaseappno;
		private string _s_parentcasecountry;
		private DateTime? _dt_appdate;
		private DateTime? _dt_grantdate;
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
		public string s_ParentCaseSerial
		{
			set{ _s_parentcaseserial=value;}
			get{return _s_parentcaseserial;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_ParentCaseAppNo
		{
			set{ _s_parentcaseappno=value;}
			get{return _s_parentcaseappno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_ParentCaseCountry
		{
			set{ _s_parentcasecountry=value;}
			get{return _s_parentcasecountry;}
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
		public DateTime? dt_GrantDate
		{
			set{ _dt_grantdate=value;}
			get{return _dt_grantdate;}
		}
		#endregion Model

	}
}


﻿/**  版本信息模板在安装目录下，可自行修改。
* TPCase_HongKongApplication.cs
*
* 功 能： N/A
* 类 名： TPCase_HongKongApplication
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:49:20   N/A    初版
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
	/// TPCase_HongKongApplication:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TPCase_HongKongApplication
	{
		public TPCase_HongKongApplication()
		{}
		#region Model
		private int _n_caseid;
		private int? _n_type;
		private string _s_note;
		private string _s_parentcaseserial;
		private string _s_parentcaseappno;
		private string _s_parentcasecountry;
		private DateTime? _dt_1stregisterdate;
		private DateTime? _dt_2ndregisterdate;
		private DateTime? _dt_1stagentreport;
		private DateTime? _dt_1stpublish;
		private DateTime? _dt_2ndagentreport;
		private DateTime? _dt_2ndgrantreport;
		private DateTime? _dt_remindshlddate;
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
		public int? n_Type
		{
			set{ _n_type=value;}
			get{return _n_type;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_Note
		{
			set{ _s_note=value;}
			get{return _s_note;}
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
		public DateTime? dt_1stRegisterDate
		{
			set{ _dt_1stregisterdate=value;}
			get{return _dt_1stregisterdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? dt_2ndRegisterDate
		{
			set{ _dt_2ndregisterdate=value;}
			get{return _dt_2ndregisterdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? dt_1stAgentReport
		{
			set{ _dt_1stagentreport=value;}
			get{return _dt_1stagentreport;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? dt_1stPublish
		{
			set{ _dt_1stpublish=value;}
			get{return _dt_1stpublish;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? dt_2ndAgentReport
		{
			set{ _dt_2ndagentreport=value;}
			get{return _dt_2ndagentreport;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? dt_2ndGrantReport
		{
			set{ _dt_2ndgrantreport=value;}
			get{return _dt_2ndgrantreport;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? dt_RemindShldDate
		{
			set{ _dt_remindshlddate=value;}
			get{return _dt_remindshlddate;}
		}
		#endregion Model

	}
}


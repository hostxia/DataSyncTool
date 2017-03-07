/**  版本信息模板在安装目录下，可自行修改。
* TTCase_MadridCountry.cs
*
* 功 能： N/A
* 类 名： TTCase_MadridCountry
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:50:42   N/A    初版
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
	/// TTCase_MadridCountry:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TTCase_MadridCountry
	{
		public TTCase_MadridCountry()
		{}
		#region Model
		private int _n_id;
		private int _n_caseid;
		private int? _n_disignatedcountry;
		private string _n_trademarkclass;
		private string _s_individualspecify;
		private string _s_trademarkitem;
		private string _s_lawstatus;
		private string _s_notes;
		private string _s_newcaseid;
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
		public int? n_DisignatedCountry
		{
			set{ _n_disignatedcountry=value;}
			get{return _n_disignatedcountry;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string n_TrademarkClass
		{
			set{ _n_trademarkclass=value;}
			get{return _n_trademarkclass;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_IndividualSpecify
		{
			set{ _s_individualspecify=value;}
			get{return _s_individualspecify;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_TrademarkItem
		{
			set{ _s_trademarkitem=value;}
			get{return _s_trademarkitem;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_LawStatus
		{
			set{ _s_lawstatus=value;}
			get{return _s_lawstatus;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_Notes
		{
			set{ _s_notes=value;}
			get{return _s_notes;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_NewCaseID
		{
			set{ _s_newcaseid=value;}
			get{return _s_newcaseid;}
		}
		#endregion Model

	}
}


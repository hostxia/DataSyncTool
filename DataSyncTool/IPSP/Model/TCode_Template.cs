/**  版本信息模板在安装目录下，可自行修改。
* TCode_Template.cs
*
* 功 能： N/A
* 类 名： TCode_Template
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:47:14   N/A    初版
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
	/// TCode_Template:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TCode_Template
	{
		public TCode_Template()
		{}
		#region Model
		private int _n_id;
		private string _s_iptype;
		private string _s_tapplytype;
		private string _s_templatetype;
		private int? _n_regcountry;
		private string _s_business;
		private string _s_ptctype;
		private string _s_processid;
		private int? _n_language;
		private string _s_name;
		private string _s_othername;
		private string _s_filepathname;
		private string _s_officialcode;
		private string _s_namespace;
		private string _s_needinfile;
		private string _s_notes;
		private DateTime? _dt_createdate;
		private DateTime? _dt_editdate;
		private string _s_issystemdefine;
		private string _s_officialname;
		private string _s_exporttype;
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
		public string s_TApplyType
		{
			set{ _s_tapplytype=value;}
			get{return _s_tapplytype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_TemplateType
		{
			set{ _s_templatetype=value;}
			get{return _s_templatetype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_RegCountry
		{
			set{ _n_regcountry=value;}
			get{return _n_regcountry;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_Business
		{
			set{ _s_business=value;}
			get{return _s_business;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_PTCType
		{
			set{ _s_ptctype=value;}
			get{return _s_ptctype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_ProcessID
		{
			set{ _s_processid=value;}
			get{return _s_processid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_Language
		{
			set{ _n_language=value;}
			get{return _n_language;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_Name
		{
			set{ _s_name=value;}
			get{return _s_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_OtherName
		{
			set{ _s_othername=value;}
			get{return _s_othername;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_FilePathName
		{
			set{ _s_filepathname=value;}
			get{return _s_filepathname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_OfficialCode
		{
			set{ _s_officialcode=value;}
			get{return _s_officialcode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_NameSpace
		{
			set{ _s_namespace=value;}
			get{return _s_namespace;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_NeedInFile
		{
			set{ _s_needinfile=value;}
			get{return _s_needinfile;}
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
		public string s_IsSystemDefine
		{
			set{ _s_issystemdefine=value;}
			get{return _s_issystemdefine;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_OfficialName
		{
			set{ _s_officialname=value;}
			get{return _s_officialname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_ExportType
		{
			set{ _s_exporttype=value;}
			get{return _s_exporttype;}
		}
		#endregion Model

	}
}


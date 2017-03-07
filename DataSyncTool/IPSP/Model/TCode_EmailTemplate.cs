/**  版本信息模板在安装目录下，可自行修改。
* TCode_EmailTemplate.cs
*
* 功 能： N/A
* 类 名： TCode_EmailTemplate
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:46:19   N/A    初版
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
	/// TCode_EmailTemplate:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TCode_EmailTemplate
	{
		public TCode_EmailTemplate()
		{}
		#region Model
		private int _n_id;
		private string _s_name;
		private string _s_subject;
		private string _s_filepathname;
		private string _s_notes;
		private DateTime? _dt_createdate;
		private DateTime? _dt_editdate;
		private string _s_type;
		private string _s_templatetype;
		private int? _n_codeemailserverid;
		private int? _n_languageid;
		private string _s_casetype;
		private string _s_default;
		private int? _n_language;
		private string _s_othername;
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
		public string s_Name
		{
			set{ _s_name=value;}
			get{return _s_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_Subject
		{
			set{ _s_subject=value;}
			get{return _s_subject;}
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
		public string s_Type
		{
			set{ _s_type=value;}
			get{return _s_type;}
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
		public int? n_CodeEmailServerID
		{
			set{ _n_codeemailserverid=value;}
			get{return _n_codeemailserverid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_LanguageID
		{
			set{ _n_languageid=value;}
			get{return _n_languageid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_CaseType
		{
			set{ _s_casetype=value;}
			get{return _s_casetype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_Default
		{
			set{ _s_default=value;}
			get{return _s_default;}
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
		public string s_OtherName
		{
			set{ _s_othername=value;}
			get{return _s_othername;}
		}
		#endregion Model

	}
}


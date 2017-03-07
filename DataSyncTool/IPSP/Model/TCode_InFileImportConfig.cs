/**  版本信息模板在安装目录下，可自行修改。
* TCode_InFileImportConfig.cs
*
* 功 能： N/A
* 类 名： TCode_InFileImportConfig
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:46:31   N/A    初版
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
	/// TCode_InFileImportConfig:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TCode_InFileImportConfig
	{
		public TCode_InFileImportConfig()
		{}
		#region Model
		private int _n_configid;
		private string _s_configname;
		private int? _n_filenamerule;
		private int? _n_delimiter;
		private int? _n_filetype;
		private string _s_importedfilename;
		private int? _n_casemethod;
		private int? _n_filemethod;
		/// <summary>
		/// 
		/// </summary>
		public int n_ConfigID
		{
			set{ _n_configid=value;}
			get{return _n_configid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_ConfigName
		{
			set{ _s_configname=value;}
			get{return _s_configname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_FileNameRule
		{
			set{ _n_filenamerule=value;}
			get{return _n_filenamerule;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_Delimiter
		{
			set{ _n_delimiter=value;}
			get{return _n_delimiter;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_FileType
		{
			set{ _n_filetype=value;}
			get{return _n_filetype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_ImportedFileName
		{
			set{ _s_importedfilename=value;}
			get{return _s_importedfilename;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_CaseMethod
		{
			set{ _n_casemethod=value;}
			get{return _n_casemethod;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_FileMethod
		{
			set{ _n_filemethod=value;}
			get{return _n_filemethod;}
		}
		#endregion Model

	}
}


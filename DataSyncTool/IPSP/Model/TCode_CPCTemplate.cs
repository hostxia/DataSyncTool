/**  版本信息模板在安装目录下，可自行修改。
* TCode_CPCTemplate.cs
*
* 功 能： N/A
* 类 名： TCode_CPCTemplate
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:46:05   N/A    初版
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
	/// TCode_CPCTemplate:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TCode_CPCTemplate
	{
		public TCode_CPCTemplate()
		{}
		#region Model
		private int _n_id;
		private string _s_code;
		private string _s_listxmltype;
		private string _s_iscancoding;
		private string _s_iscanimport;
		private string _s_impotfiletype;
		private string _s_needcameofile;
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
		public string s_Code
		{
			set{ _s_code=value;}
			get{return _s_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_ListXmlType
		{
			set{ _s_listxmltype=value;}
			get{return _s_listxmltype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_IsCanCoding
		{
			set{ _s_iscancoding=value;}
			get{return _s_iscancoding;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_IsCanImport
		{
			set{ _s_iscanimport=value;}
			get{return _s_iscanimport;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_ImpotFileType
		{
			set{ _s_impotfiletype=value;}
			get{return _s_impotfiletype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_NeedCameOFile
		{
			set{ _s_needcameofile=value;}
			get{return _s_needcameofile;}
		}
		#endregion Model

	}
}


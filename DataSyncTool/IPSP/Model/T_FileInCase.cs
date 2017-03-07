/**  版本信息模板在安装目录下，可自行修改。
* T_FileInCase.cs
*
* 功 能： N/A
* 类 名： T_FileInCase
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:44:49   N/A    初版
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
	/// T_FileInCase:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class T_FileInCase
	{
		public T_FileInCase()
		{}
		#region Model
		private int _n_id;
		private int _n_fileid;
		private int _n_caseid;
		private int _n_processid;
		private string _s_ismaincase;
		private string _s_selecttype;
		private string _s_materialtype;
		private int? _n_annualfeeid;
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
		public int n_FileID
		{
			set{ _n_fileid=value;}
			get{return _n_fileid;}
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
		public int n_ProcessID
		{
			set{ _n_processid=value;}
			get{return _n_processid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_IsMainCase
		{
			set{ _s_ismaincase=value;}
			get{return _s_ismaincase;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_SelectType
		{
			set{ _s_selecttype=value;}
			get{return _s_selecttype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_MaterialType
		{
			set{ _s_materialtype=value;}
			get{return _s_materialtype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_AnnualFeeID
		{
			set{ _n_annualfeeid=value;}
			get{return _n_annualfeeid;}
		}
		#endregion Model

	}
}


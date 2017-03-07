/**  版本信息模板在安装目录下，可自行修改。
* TCCase_TortiousWare.cs
*
* 功 能： N/A
* 类 名： TCCase_TortiousWare
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:45:43   N/A    初版
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
	/// TCCase_TortiousWare:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TCCase_TortiousWare
	{
		public TCCase_TortiousWare()
		{}
		#region Model
		private int _n_caseid;
		private string _s_warename;
		private string _s_hscode;
		private string _s_note;
		private int _n_id;
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
		public string s_WareName
		{
			set{ _s_warename=value;}
			get{return _s_warename;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_HSCode
		{
			set{ _s_hscode=value;}
			get{return _s_hscode;}
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
		public int n_ID
		{
			set{ _n_id=value;}
			get{return _n_id;}
		}
		#endregion Model

	}
}


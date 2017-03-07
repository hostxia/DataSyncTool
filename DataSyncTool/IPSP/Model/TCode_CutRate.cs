/**  版本信息模板在安装目录下，可自行修改。
* TCode_CutRate.cs
*
* 功 能： N/A
* 类 名： TCode_CutRate
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:46:08   N/A    初版
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
	/// TCode_CutRate:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TCode_CutRate
	{
		public TCode_CutRate()
		{}
		#region Model
		private int _n_id;
		private string _s_cutratetype;
		private string _s_annualcutrate;
		private int? _n_cutratescale;
		private string _s_iptype;
		private string _s_editor;
		private DateTime? _dt_editdate;
		private string _fs_editor;
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
		public string s_CutRateType
		{
			set{ _s_cutratetype=value;}
			get{return _s_cutratetype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_AnnualCutRate
		{
			set{ _s_annualcutrate=value;}
			get{return _s_annualcutrate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_CutRateScale
		{
			set{ _n_cutratescale=value;}
			get{return _n_cutratescale;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_IpType
		{
			set{ _s_iptype=value;}
			get{return _s_iptype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_Editor
		{
			set{ _s_editor=value;}
			get{return _s_editor;}
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
		public string fs_Editor
		{
			set{ _fs_editor=value;}
			get{return _fs_editor;}
		}
		#endregion Model

	}
}


/**  版本信息模板在安装目录下，可自行修改。
* TCode_CutRateProject.cs
*
* 功 能： N/A
* 类 名： TCode_CutRateProject
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:46:09   N/A    初版
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
	/// TCode_CutRateProject:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TCode_CutRateProject
	{
		public TCode_CutRateProject()
		{}
		#region Model
		private int _n_id;
		private int _n_cutrateid;
		private int? _n_codefeeid;
		private int? _n_scale;
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
		public int n_CutRateID
		{
			set{ _n_cutrateid=value;}
			get{return _n_cutrateid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_CodeFeeID
		{
			set{ _n_codefeeid=value;}
			get{return _n_codefeeid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_Scale
		{
			set{ _n_scale=value;}
			get{return _n_scale;}
		}
		#endregion Model

	}
}


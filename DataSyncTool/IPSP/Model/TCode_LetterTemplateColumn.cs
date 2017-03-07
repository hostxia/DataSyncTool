/**  版本信息模板在安装目录下，可自行修改。
* TCode_LetterTemplateColumn.cs
*
* 功 能： N/A
* 类 名： TCode_LetterTemplateColumn
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:46:35   N/A    初版
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
	/// TCode_LetterTemplateColumn:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TCode_LetterTemplateColumn
	{
		public TCode_LetterTemplateColumn()
		{}
		#region Model
		private int _n_id;
		private string _s_columnname;
		private int _n_lettertemplateid;
		private decimal? _n_width;
		private int? _n_ordernum;
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
		public string s_ColumnName
		{
			set{ _s_columnname=value;}
			get{return _s_columnname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int n_LetterTemplateID
		{
			set{ _n_lettertemplateid=value;}
			get{return _n_lettertemplateid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? n_Width
		{
			set{ _n_width=value;}
			get{return _n_width;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_OrderNum
		{
			set{ _n_ordernum=value;}
			get{return _n_ordernum;}
		}
		#endregion Model

	}
}


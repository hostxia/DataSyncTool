/**  版本信息模板在安装目录下，可自行修改。
* TPCase_WriteInfo.cs
*
* 功 能： N/A
* 类 名： TPCase_WriteInfo
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:49:54   N/A    初版
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
	/// TPCase_WriteInfo:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TPCase_WriteInfo
	{
		public TPCase_WriteInfo()
		{}
		#region Model
		private int _n_id;
		private int _n_caseid;
		private string _s_origcaseserial;
		private int? _n_writerid;
		private DateTime? _dt_writeassigndate;
		private DateTime? _dt_writeltddate;
		private DateTime? _dt_writeenddate;
		private int? _n_descpagenum;
		private int? _n_imgnum;
		private int? _n_poweritemnum;
		private string _s_writequality;
		private int? _n_typewriteid;
		private int? _n_typewritepagenum;
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
		public string s_OrigCaseSerial
		{
			set{ _s_origcaseserial=value;}
			get{return _s_origcaseserial;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_WriterID
		{
			set{ _n_writerid=value;}
			get{return _n_writerid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? dt_WriteAssignDate
		{
			set{ _dt_writeassigndate=value;}
			get{return _dt_writeassigndate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? dt_WriteLtdDate
		{
			set{ _dt_writeltddate=value;}
			get{return _dt_writeltddate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? dt_WriteEndDate
		{
			set{ _dt_writeenddate=value;}
			get{return _dt_writeenddate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_DescPageNum
		{
			set{ _n_descpagenum=value;}
			get{return _n_descpagenum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_ImgNum
		{
			set{ _n_imgnum=value;}
			get{return _n_imgnum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_PowerItemNum
		{
			set{ _n_poweritemnum=value;}
			get{return _n_poweritemnum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_WriteQuality
		{
			set{ _s_writequality=value;}
			get{return _s_writequality;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_TypewriteID
		{
			set{ _n_typewriteid=value;}
			get{return _n_typewriteid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_TypeWritePageNum
		{
			set{ _n_typewritepagenum=value;}
			get{return _n_typewritepagenum;}
		}
		#endregion Model

	}
}


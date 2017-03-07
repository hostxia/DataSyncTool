/**  版本信息模板在安装目录下，可自行修改。
* TPCase_TranslateInfo.cs
*
* 功 能： N/A
* 类 名： TPCase_TranslateInfo
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:49:52   N/A    初版
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
	/// TPCase_TranslateInfo:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TPCase_TranslateInfo
	{
		public TPCase_TranslateInfo()
		{}
		#region Model
		private int _n_id;
		private int _n_caseid;
		private int? _n_origlan;
		private int? _n_origwordsnum;
		private int? _n_destlan;
		private int? _n_translatorid;
		private DateTime? _dt_transassigndate;
		private DateTime? _dt_transltddate;
		private DateTime? _dt_transenddate;
		private string _s_transquality;
		private int? _n_collator1id;
		private int? _n_collator2id;
		private DateTime? _dt_collateassigndate;
		private DateTime? _dt_collateltddate;
		private DateTime? _dt_collateenddate;
		private int? _n_typewritebyid;
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
		public int? n_OrigLan
		{
			set{ _n_origlan=value;}
			get{return _n_origlan;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_OrigWordsNum
		{
			set{ _n_origwordsnum=value;}
			get{return _n_origwordsnum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_DestLan
		{
			set{ _n_destlan=value;}
			get{return _n_destlan;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_TranslatorID
		{
			set{ _n_translatorid=value;}
			get{return _n_translatorid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? dt_TransAssignDate
		{
			set{ _dt_transassigndate=value;}
			get{return _dt_transassigndate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? dt_TransLtdDate
		{
			set{ _dt_transltddate=value;}
			get{return _dt_transltddate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? dt_TransEndDate
		{
			set{ _dt_transenddate=value;}
			get{return _dt_transenddate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_TransQuality
		{
			set{ _s_transquality=value;}
			get{return _s_transquality;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_Collator1ID
		{
			set{ _n_collator1id=value;}
			get{return _n_collator1id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_Collator2ID
		{
			set{ _n_collator2id=value;}
			get{return _n_collator2id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? dt_CollateAssignDate
		{
			set{ _dt_collateassigndate=value;}
			get{return _dt_collateassigndate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? dt_CollateLtdDate
		{
			set{ _dt_collateltddate=value;}
			get{return _dt_collateltddate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? dt_CollateEndDate
		{
			set{ _dt_collateenddate=value;}
			get{return _dt_collateenddate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_TypeWriteByID
		{
			set{ _n_typewritebyid=value;}
			get{return _n_typewritebyid;}
		}
		#endregion Model

	}
}


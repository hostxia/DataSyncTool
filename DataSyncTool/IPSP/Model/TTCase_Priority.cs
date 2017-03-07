/**  版本信息模板在安装目录下，可自行修改。
* TTCase_Priority.cs
*
* 功 能： N/A
* 类 名： TTCase_Priority
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:50:55   N/A    初版
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
	/// TTCase_Priority:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TTCase_Priority
	{
		public TTCase_Priority()
		{}
		#region Model
		private int _n_id;
		private int _n_caseid;
		private int _n_sequence;
		private string _s_priority;
		private int? _n_pcountry;
		private DateTime? _dt_pdate;
		private string _s_pnum;
		private string _s_pdocprovided;
		private string _s_ptransdocprovided;
		private string _s_notes;
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
		public int n_Sequence
		{
			set{ _n_sequence=value;}
			get{return _n_sequence;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_Priority
		{
			set{ _s_priority=value;}
			get{return _s_priority;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_PCountry
		{
			set{ _n_pcountry=value;}
			get{return _n_pcountry;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? dt_PDate
		{
			set{ _dt_pdate=value;}
			get{return _dt_pdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_PNum
		{
			set{ _s_pnum=value;}
			get{return _s_pnum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_PDocProvided
		{
			set{ _s_pdocprovided=value;}
			get{return _s_pdocprovided;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_PTransDocProvided
		{
			set{ _s_ptransdocprovided=value;}
			get{return _s_ptransdocprovided;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_Notes
		{
			set{ _s_notes=value;}
			get{return _s_notes;}
		}
		#endregion Model

	}
}


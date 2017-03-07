/**  版本信息模板在安装目录下，可自行修改。
* TPCase_Priority.cs
*
* 功 能： N/A
* 类 名： TPCase_Priority
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:49:44   N/A    初版
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
	/// TPCase_Priority:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TPCase_Priority
	{
		public TPCase_Priority()
		{}
		#region Model
		private int _n_id;
		private int _n_caseid;
		private int _n_sequence;
		private string _s_priority;
		private string _s_pofficetype;
		private int? _n_pcountry;
		private string _s_poffice;
		private DateTime? _dt_pdate;
		private string _s_pnum;
		private string _s_pdocprovided;
		private string _s_ptransdocprovided;
		private int _patent;
		private string _s_inputnum;
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
		public string s_POfficeType
		{
			set{ _s_pofficetype=value;}
			get{return _s_pofficetype;}
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
		public string s_POffice
		{
			set{ _s_poffice=value;}
			get{return _s_poffice;}
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
		public int Patent
		{
			set{ _patent=value;}
			get{return _patent;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_InputNum
		{
			set{ _s_inputnum=value;}
			get{return _s_inputnum;}
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


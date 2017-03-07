/**  版本信息模板在安装目录下，可自行修改。
* TPCase_Patent.cs
*
* 功 能： N/A
* 类 名： TPCase_Patent
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:49:34   N/A    初版
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
	/// TPCase_Patent:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TPCase_Patent
	{
		public TPCase_Patent()
		{}
		#region Model
		private int _n_caseid;
		private int? _n_pflownum;
		private int _n_lawid;
		private int? _n_patenttypeid;
		private string _s_technologytype;
		private string _s_oldserial;
		private string _s_npatentid;
		private string _s_origcaseserial;
		private string _s_origappno;
		private DateTime? _dt_origappdate;
		private string _s_patentstatus;
		private string _s_notes;
		private int _n_origpatinfoid;
		private string _s_inventors;
		private DateTime? _dt_requestsubmitdate;
		private bool _b_divisionalcaseflag;
		private string _s_origcaseno;
		private string _s_allinventoraddress;
		private string _s_fristpriority;
		private string _s_firstpriorityno;
		private DateTime? _dt_firstprioritydate;
		private string _s_firstinventor;
		private string _s_prioritystatus;
		private DateTime? _dt_prioritystatusdate;
		private DateTime? _dt_divsubmitdate;
		private string _s_divisionappno;
		private string _s_divisioncaseno;
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
		public int? n_PFlowNum
		{
			set{ _n_pflownum=value;}
			get{return _n_pflownum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int n_LawID
		{
			set{ _n_lawid=value;}
			get{return _n_lawid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_PatentTypeID
		{
			set{ _n_patenttypeid=value;}
			get{return _n_patenttypeid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_TechnologyType
		{
			set{ _s_technologytype=value;}
			get{return _s_technologytype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_OldSerial
		{
			set{ _s_oldserial=value;}
			get{return _s_oldserial;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_NPatentID
		{
			set{ _s_npatentid=value;}
			get{return _s_npatentid;}
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
		public string s_OrigAppNo
		{
			set{ _s_origappno=value;}
			get{return _s_origappno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? dt_OrigAppDate
		{
			set{ _dt_origappdate=value;}
			get{return _dt_origappdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_PatentStatus
		{
			set{ _s_patentstatus=value;}
			get{return _s_patentstatus;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_Notes
		{
			set{ _s_notes=value;}
			get{return _s_notes;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int n_OrigPatInfoID
		{
			set{ _n_origpatinfoid=value;}
			get{return _n_origpatinfoid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_Inventors
		{
			set{ _s_inventors=value;}
			get{return _s_inventors;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? dt_RequestSubmitDate
		{
			set{ _dt_requestsubmitdate=value;}
			get{return _dt_requestsubmitdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool b_DivisionalCaseFlag
		{
			set{ _b_divisionalcaseflag=value;}
			get{return _b_divisionalcaseflag;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_OrigCaseNo
		{
			set{ _s_origcaseno=value;}
			get{return _s_origcaseno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_AllInventorAddress
		{
			set{ _s_allinventoraddress=value;}
			get{return _s_allinventoraddress;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_FristPriority
		{
			set{ _s_fristpriority=value;}
			get{return _s_fristpriority;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_FirstPriorityNo
		{
			set{ _s_firstpriorityno=value;}
			get{return _s_firstpriorityno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? dt_FirstPriorityDate
		{
			set{ _dt_firstprioritydate=value;}
			get{return _dt_firstprioritydate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_FirstInventor
		{
			set{ _s_firstinventor=value;}
			get{return _s_firstinventor;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_PriorityStatus
		{
			set{ _s_prioritystatus=value;}
			get{return _s_prioritystatus;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? dt_PriorityStatusDate
		{
			set{ _dt_prioritystatusdate=value;}
			get{return _dt_prioritystatusdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? dt_DivSubmitDate
		{
			set{ _dt_divsubmitdate=value;}
			get{return _dt_divsubmitdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_DivisionAppNo
		{
			set{ _s_divisionappno=value;}
			get{return _s_divisionappno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_DivisionCaseNo
		{
			set{ _s_divisioncaseno=value;}
			get{return _s_divisioncaseno;}
		}
		#endregion Model

	}
}


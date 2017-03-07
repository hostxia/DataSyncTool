/**  版本信息模板在安装目录下，可自行修改。
* TTCase_LawInfo.cs
*
* 功 能： N/A
* 类 名： TTCase_LawInfo
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:50:35   N/A    初版
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
	/// TTCase_LawInfo:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TTCase_LawInfo
	{
		public TTCase_LawInfo()
		{}
		#region Model
		private int _n_id;
		private string _s_acceptno;
		private DateTime? _dt_appdate;
		private DateTime? _dt_formalcheckdate;
		private DateTime? _dt_esscheckdate;
		private string _s_appno;
		private string _s_prepubissue;
		private DateTime? _dt_prepubdate;
		private DateTime? _dt_registrationdate;
		private string _s_pubissue;
		private string _s_registrationno;
		private DateTime? _dt_withdrawdate;
		private DateTime? _dt_approveddate;
		private string _s_prepubno;
		private DateTime? _dt_begindate;
		private DateTime? _dt_enddate;
		private DateTime? _dt_nextrenewal;
		private string _s_madfilingno;
		private DateTime? _dt_madfilingdate;
		private string _s_madregno;
		private DateTime? _dt_madregdate;
		private int? _n_madlan;
		private string _s_ntrademarkid;
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
		public string s_AcceptNO
		{
			set{ _s_acceptno=value;}
			get{return _s_acceptno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? dt_AppDate
		{
			set{ _dt_appdate=value;}
			get{return _dt_appdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? dt_FormalCheckDate
		{
			set{ _dt_formalcheckdate=value;}
			get{return _dt_formalcheckdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? dt_EssCheckDate
		{
			set{ _dt_esscheckdate=value;}
			get{return _dt_esscheckdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_AppNO
		{
			set{ _s_appno=value;}
			get{return _s_appno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_PrePubIssue
		{
			set{ _s_prepubissue=value;}
			get{return _s_prepubissue;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? dt_PrePubDate
		{
			set{ _dt_prepubdate=value;}
			get{return _dt_prepubdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? dt_RegistrationDate
		{
			set{ _dt_registrationdate=value;}
			get{return _dt_registrationdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_PubIssue
		{
			set{ _s_pubissue=value;}
			get{return _s_pubissue;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_RegistrationNO
		{
			set{ _s_registrationno=value;}
			get{return _s_registrationno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? dt_WithdrawDate
		{
			set{ _dt_withdrawdate=value;}
			get{return _dt_withdrawdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? dt_ApprovedDate
		{
			set{ _dt_approveddate=value;}
			get{return _dt_approveddate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_PrePubNO
		{
			set{ _s_prepubno=value;}
			get{return _s_prepubno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? dt_BeginDate
		{
			set{ _dt_begindate=value;}
			get{return _dt_begindate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? dt_EndDate
		{
			set{ _dt_enddate=value;}
			get{return _dt_enddate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? dt_NextRenewal
		{
			set{ _dt_nextrenewal=value;}
			get{return _dt_nextrenewal;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_MadFilingNo
		{
			set{ _s_madfilingno=value;}
			get{return _s_madfilingno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? dt_MadFilingDate
		{
			set{ _dt_madfilingdate=value;}
			get{return _dt_madfilingdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_MadRegNo
		{
			set{ _s_madregno=value;}
			get{return _s_madregno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? dt_MadRegDate
		{
			set{ _dt_madregdate=value;}
			get{return _dt_madregdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_MadLan
		{
			set{ _n_madlan=value;}
			get{return _n_madlan;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_NTrademarkID
		{
			set{ _s_ntrademarkid=value;}
			get{return _s_ntrademarkid;}
		}
		#endregion Model

	}
}


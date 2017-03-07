/**  版本信息模板在安装目录下，可自行修改。
* TTCase_LawsuitInfo.cs
*
* 功 能： N/A
* 类 名： TTCase_LawsuitInfo
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:50:38   N/A    初版
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
	/// TTCase_LawsuitInfo:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TTCase_LawsuitInfo
	{
		public TTCase_LawsuitInfo()
		{}
		#region Model
		private int _n_id;
		private int _n_caseid;
		private string _s_casebrief;
		private string _s_courtname;
		private string _s_courtaddr;
		private string _s_courtzipcode;
		private string _s_courtcontact;
		private string _s_courttel;
		private string _s_courtfax;
		private string _s_courtemail;
		private string _s_courtserial;
		private DateTime? _dt_courtregdate;
		private DateTime? _dt_courtnoticedate;
		private string _s_judge;
		private string _s_courtofficer;
		private string _s_acceptcourt;
		private string _s_checklevel;
		private DateTime? _dt_pubproofdate;
		private DateTime? _dt_courtdate;
		private DateTime? _dt_subpoenadate;
		private DateTime? _dt_replydate;
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
		public string s_CaseBrief
		{
			set{ _s_casebrief=value;}
			get{return _s_casebrief;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_CourtName
		{
			set{ _s_courtname=value;}
			get{return _s_courtname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_CourtAddr
		{
			set{ _s_courtaddr=value;}
			get{return _s_courtaddr;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_CourtZipCode
		{
			set{ _s_courtzipcode=value;}
			get{return _s_courtzipcode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_CourtContact
		{
			set{ _s_courtcontact=value;}
			get{return _s_courtcontact;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_CourtTel
		{
			set{ _s_courttel=value;}
			get{return _s_courttel;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_CourtFax
		{
			set{ _s_courtfax=value;}
			get{return _s_courtfax;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_CourtEmail
		{
			set{ _s_courtemail=value;}
			get{return _s_courtemail;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_CourtSerial
		{
			set{ _s_courtserial=value;}
			get{return _s_courtserial;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? dt_CourtRegDate
		{
			set{ _dt_courtregdate=value;}
			get{return _dt_courtregdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? dt_CourtNoticeDate
		{
			set{ _dt_courtnoticedate=value;}
			get{return _dt_courtnoticedate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_Judge
		{
			set{ _s_judge=value;}
			get{return _s_judge;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_CourtOfficer
		{
			set{ _s_courtofficer=value;}
			get{return _s_courtofficer;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_AcceptCourt
		{
			set{ _s_acceptcourt=value;}
			get{return _s_acceptcourt;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_CheckLevel
		{
			set{ _s_checklevel=value;}
			get{return _s_checklevel;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? dt_PubProofDate
		{
			set{ _dt_pubproofdate=value;}
			get{return _dt_pubproofdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? dt_CourtDate
		{
			set{ _dt_courtdate=value;}
			get{return _dt_courtdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? dt_SubpoenaDate
		{
			set{ _dt_subpoenadate=value;}
			get{return _dt_subpoenadate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? dt_ReplyDate
		{
			set{ _dt_replydate=value;}
			get{return _dt_replydate;}
		}
		#endregion Model

	}
}


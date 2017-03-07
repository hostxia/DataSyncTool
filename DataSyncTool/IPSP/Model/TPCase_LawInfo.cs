/**  版本信息模板在安装目录下，可自行修改。
* TPCase_LawInfo.cs
*
* 功 能： N/A
* 类 名： TPCase_LawInfo
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:49:25   N/A    初版
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
	/// TPCase_LawInfo:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TPCase_LawInfo
	{
		public TPCase_LawInfo()
		{}
		#region Model
		private int _n_id;
		private string _s_appno;
		private DateTime? _dt_appdate;
		private int? _n_claimcount;
		private string _s_pubno;
		private DateTime? _dt_pubdate;
		private string _s_pubvolume;
		private string _s_pubgazette;
		private string _s_pubclass1;
		private string _s_pubclass2;
		private DateTime? _dt_substantiveexamdate;
		private string _s_issuedpubno;
		private DateTime? _dt_issuedpubdate;
		private string _s_issuedpubvolume;
		private string _s_issuedpubgazette;
		private string _s_issuedpubclass1;
		private string _s_issuedpubclass2;
		private string _s_certfno;
		private DateTime? _dt_certfdate;
		private string _s_pctappno;
		private DateTime? _dt_pctappdate;
		private string _s_pctpubno;
		private DateTime? _dt_pctpubdate;
		private DateTime? _dt_pctinnationdate;
		private int? _n_pctpublan;
		private int? _n_manualpages;
		private decimal? _n_protectionduration;
		private DateTime? _dt_expirationdate;
		private string _s_pctsearchbureau;
		private DateTime? _dt_firstcheckdate;
		private string _s_reviewno;
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
		public string s_AppNo
		{
			set{ _s_appno=value;}
			get{return _s_appno;}
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
		public int? n_ClaimCount
		{
			set{ _n_claimcount=value;}
			get{return _n_claimcount;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_PubNo
		{
			set{ _s_pubno=value;}
			get{return _s_pubno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? dt_PubDate
		{
			set{ _dt_pubdate=value;}
			get{return _dt_pubdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_PubVolume
		{
			set{ _s_pubvolume=value;}
			get{return _s_pubvolume;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_PubGazette
		{
			set{ _s_pubgazette=value;}
			get{return _s_pubgazette;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_PubClass1
		{
			set{ _s_pubclass1=value;}
			get{return _s_pubclass1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_PubClass2
		{
			set{ _s_pubclass2=value;}
			get{return _s_pubclass2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? dt_SubstantiveExamDate
		{
			set{ _dt_substantiveexamdate=value;}
			get{return _dt_substantiveexamdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_IssuedPubNo
		{
			set{ _s_issuedpubno=value;}
			get{return _s_issuedpubno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? dt_IssuedPubDate
		{
			set{ _dt_issuedpubdate=value;}
			get{return _dt_issuedpubdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_IssuedPubVolume
		{
			set{ _s_issuedpubvolume=value;}
			get{return _s_issuedpubvolume;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_IssuedPubGazette
		{
			set{ _s_issuedpubgazette=value;}
			get{return _s_issuedpubgazette;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_IssuedPubClass1
		{
			set{ _s_issuedpubclass1=value;}
			get{return _s_issuedpubclass1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_IssuedPubClass2
		{
			set{ _s_issuedpubclass2=value;}
			get{return _s_issuedpubclass2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_CertfNo
		{
			set{ _s_certfno=value;}
			get{return _s_certfno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? dt_CertfDate
		{
			set{ _dt_certfdate=value;}
			get{return _dt_certfdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_PCTAppNo
		{
			set{ _s_pctappno=value;}
			get{return _s_pctappno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? dt_PctAppDate
		{
			set{ _dt_pctappdate=value;}
			get{return _dt_pctappdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_PCTPubNo
		{
			set{ _s_pctpubno=value;}
			get{return _s_pctpubno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? dt_PctPubDate
		{
			set{ _dt_pctpubdate=value;}
			get{return _dt_pctpubdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? dt_PctInNationDate
		{
			set{ _dt_pctinnationdate=value;}
			get{return _dt_pctinnationdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_PCTPubLan
		{
			set{ _n_pctpublan=value;}
			get{return _n_pctpublan;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_ManualPages
		{
			set{ _n_manualpages=value;}
			get{return _n_manualpages;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? n_ProtectionDuration
		{
			set{ _n_protectionduration=value;}
			get{return _n_protectionduration;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? dt_ExpirationDate
		{
			set{ _dt_expirationdate=value;}
			get{return _dt_expirationdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_PCTSearchBureau
		{
			set{ _s_pctsearchbureau=value;}
			get{return _s_pctsearchbureau;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? dt_FirstCheckDate
		{
			set{ _dt_firstcheckdate=value;}
			get{return _dt_firstcheckdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_ReviewNo
		{
			set{ _s_reviewno=value;}
			get{return _s_reviewno;}
		}
		#endregion Model

	}
}


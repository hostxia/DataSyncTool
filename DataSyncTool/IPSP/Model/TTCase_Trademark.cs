/**  版本信息模板在安装目录下，可自行修改。
* TTCase_Trademark.cs
*
* 功 能： N/A
* 类 名： TTCase_Trademark
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:51:10   N/A    初版
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
	/// TTCase_Trademark:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TTCase_Trademark
	{
		public TTCase_Trademark()
		{}
		#region Model
		private int _n_caseid;
		private int? _n_groupid;
		private int _n_lawid;
		private int? _n_tflownum;
		private string _s_trademarkdesc;
		private string _s_trademarktype;
		private string _s_trademarkclass;
		private string _s_ismultclass;
		private string _s_collectiveapp;
		private byte[] _img_mainorigimg;
		private byte[] _img_mainthumbnail;
		private string _s_applytype;
		private int? _n_madbasiccountry;
		private string _s_madbasictype;
		private int _objecttype;
		private string _s_notes;
		private string _s_trademarkstatus;
		private string _s_oldserial;
		private string _s_gooodsnames;
		private bool _b_divisionalcaseflag;
		private string _s_origappno;
		private DateTime? _dt_origappdate;
		private string _s_origcaseno;
		private DateTime? _dt_divsubmitdate;
		private string _s_priorityfilebackup;
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
		public int? n_GroupID
		{
			set{ _n_groupid=value;}
			get{return _n_groupid;}
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
		public int? n_TFlowNum
		{
			set{ _n_tflownum=value;}
			get{return _n_tflownum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_TrademarkDesc
		{
			set{ _s_trademarkdesc=value;}
			get{return _s_trademarkdesc;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_TrademarkType
		{
			set{ _s_trademarktype=value;}
			get{return _s_trademarktype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_TrademarkClass
		{
			set{ _s_trademarkclass=value;}
			get{return _s_trademarkclass;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_IsMultClass
		{
			set{ _s_ismultclass=value;}
			get{return _s_ismultclass;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_CollectiveApp
		{
			set{ _s_collectiveapp=value;}
			get{return _s_collectiveapp;}
		}
		/// <summary>
		/// 
		/// </summary>
		public byte[] img_MainOrigImg
		{
			set{ _img_mainorigimg=value;}
			get{return _img_mainorigimg;}
		}
		/// <summary>
		/// 
		/// </summary>
		public byte[] img_MainThumbnail
		{
			set{ _img_mainthumbnail=value;}
			get{return _img_mainthumbnail;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_ApplyType
		{
			set{ _s_applytype=value;}
			get{return _s_applytype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_MadBasicCountry
		{
			set{ _n_madbasiccountry=value;}
			get{return _n_madbasiccountry;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_MadBasicType
		{
			set{ _s_madbasictype=value;}
			get{return _s_madbasictype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int ObjectType
		{
			set{ _objecttype=value;}
			get{return _objecttype;}
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
		public string s_TrademarkStatus
		{
			set{ _s_trademarkstatus=value;}
			get{return _s_trademarkstatus;}
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
		public string s_GooodsNames
		{
			set{ _s_gooodsnames=value;}
			get{return _s_gooodsnames;}
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
		public string s_OrigCaseNo
		{
			set{ _s_origcaseno=value;}
			get{return _s_origcaseno;}
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
		public string s_PriorityFileBackup
		{
			set{ _s_priorityfilebackup=value;}
			get{return _s_priorityfilebackup;}
		}
		#endregion Model

	}
}


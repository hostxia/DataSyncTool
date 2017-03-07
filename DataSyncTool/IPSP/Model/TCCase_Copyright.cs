/**  版本信息模板在安装目录下，可自行修改。
* TCCase_Copyright.cs
*
* 功 能： N/A
* 类 名： TCCase_Copyright
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:45:41   N/A    初版
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
	/// TCCase_Copyright:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TCCase_Copyright
	{
		public TCCase_Copyright()
		{}
		#region Model
		private int _n_caseid;
		private int _n_cflownum;
		private string _s_signname;
		private int? _n_copyrighttype;
		private DateTime? _dt_creationstart;
		private DateTime? _dt_creationend;
		private int? _n_wordage;
		private string _s_completetype;
		private string _s_published;
		private DateTime? _dt_firstpublished;
		private string _s_firstpublishaddr;
		private string _s_applyaim;
		private string _s_rightrange;
		private DateTime? _dt_apply;
		private string _s_register;
		private DateTime? _dt_register;
		private string _s_acceptno;
		private string _s_receiptno;
		private string _s_storeno;
		private DateTime? _dt_store;
		private string _s_copyrightstatus;
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
		public int n_CFlowNum
		{
			set{ _n_cflownum=value;}
			get{return _n_cflownum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_SignName
		{
			set{ _s_signname=value;}
			get{return _s_signname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_CopyrightType
		{
			set{ _n_copyrighttype=value;}
			get{return _n_copyrighttype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? dt_CreationStart
		{
			set{ _dt_creationstart=value;}
			get{return _dt_creationstart;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? dt_CreationEnd
		{
			set{ _dt_creationend=value;}
			get{return _dt_creationend;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_Wordage
		{
			set{ _n_wordage=value;}
			get{return _n_wordage;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_CompleteType
		{
			set{ _s_completetype=value;}
			get{return _s_completetype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_Published
		{
			set{ _s_published=value;}
			get{return _s_published;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? dt_FirstPublished
		{
			set{ _dt_firstpublished=value;}
			get{return _dt_firstpublished;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_FirstPublishAddr
		{
			set{ _s_firstpublishaddr=value;}
			get{return _s_firstpublishaddr;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_ApplyAim
		{
			set{ _s_applyaim=value;}
			get{return _s_applyaim;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_RightRange
		{
			set{ _s_rightrange=value;}
			get{return _s_rightrange;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? dt_Apply
		{
			set{ _dt_apply=value;}
			get{return _dt_apply;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_Register
		{
			set{ _s_register=value;}
			get{return _s_register;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? dt_Register
		{
			set{ _dt_register=value;}
			get{return _dt_register;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_AcceptNo
		{
			set{ _s_acceptno=value;}
			get{return _s_acceptno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_ReceiptNo
		{
			set{ _s_receiptno=value;}
			get{return _s_receiptno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_StoreNo
		{
			set{ _s_storeno=value;}
			get{return _s_storeno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? dt_Store
		{
			set{ _dt_store=value;}
			get{return _dt_store;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_CopyrightStatus
		{
			set{ _s_copyrightstatus=value;}
			get{return _s_copyrightstatus;}
		}
		#endregion Model

	}
}


/**  版本信息模板在安装目录下，可自行修改。
* T_Email.cs
*
* 功 能： N/A
* 类 名： T_Email
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:44:39   N/A    初版
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
	/// T_Email:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class T_Email
	{
		public T_Email()
		{}
		#region Model
		private int _n_emailid;
		private string _s_emailpath;
		private string _s_from;
		private string _s_to;
		private string _s_cc;
		private string _s_bc;
		private string _s_subject;
		private byte[] _s_emailbody;
		private DateTime? _dt_sendtime;
		private DateTime? _dt_receivetime;
		private string _s_type;
		private int _n_emailclass;
		private string _s_important;
		private DateTime? _dt_createdate;
		private DateTime? _dt_editdate;
		private string _s_io;
		private string _s_readmark;
		private int _n_userid;
		private int? _n_modulecheckstatusid;
		private int? _n_latestcheckinfoid;
		private int? _n_authorid;
		private int? _n_curcheckerid;
		private int? _n_maincaseid;
		private int? _n_attachcounts;
		private string _s_folderid;
		private string _s_abstact;
		/// <summary>
		/// 
		/// </summary>
		public int n_EmailID
		{
			set{ _n_emailid=value;}
			get{return _n_emailid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_EmailPath
		{
			set{ _s_emailpath=value;}
			get{return _s_emailpath;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_From
		{
			set{ _s_from=value;}
			get{return _s_from;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_To
		{
			set{ _s_to=value;}
			get{return _s_to;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_Cc
		{
			set{ _s_cc=value;}
			get{return _s_cc;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_Bc
		{
			set{ _s_bc=value;}
			get{return _s_bc;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_Subject
		{
			set{ _s_subject=value;}
			get{return _s_subject;}
		}
		/// <summary>
		/// 
		/// </summary>
		public byte[] s_EmailBody
		{
			set{ _s_emailbody=value;}
			get{return _s_emailbody;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? dt_SendTime
		{
			set{ _dt_sendtime=value;}
			get{return _dt_sendtime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? dt_ReceiveTime
		{
			set{ _dt_receivetime=value;}
			get{return _dt_receivetime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_Type
		{
			set{ _s_type=value;}
			get{return _s_type;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int n_EmailClass
		{
			set{ _n_emailclass=value;}
			get{return _n_emailclass;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_Important
		{
			set{ _s_important=value;}
			get{return _s_important;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? dt_CreateDate
		{
			set{ _dt_createdate=value;}
			get{return _dt_createdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? dt_EditDate
		{
			set{ _dt_editdate=value;}
			get{return _dt_editdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_IO
		{
			set{ _s_io=value;}
			get{return _s_io;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_ReadMark
		{
			set{ _s_readmark=value;}
			get{return _s_readmark;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int n_UserID
		{
			set{ _n_userid=value;}
			get{return _n_userid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_ModuleCheckStatusID
		{
			set{ _n_modulecheckstatusid=value;}
			get{return _n_modulecheckstatusid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_LatestCheckInfoID
		{
			set{ _n_latestcheckinfoid=value;}
			get{return _n_latestcheckinfoid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_AuthorID
		{
			set{ _n_authorid=value;}
			get{return _n_authorid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_CurCheckerID
		{
			set{ _n_curcheckerid=value;}
			get{return _n_curcheckerid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_MainCaseID
		{
			set{ _n_maincaseid=value;}
			get{return _n_maincaseid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_AttachCounts
		{
			set{ _n_attachcounts=value;}
			get{return _n_attachcounts;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_FolderID
		{
			set{ _s_folderid=value;}
			get{return _s_folderid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_Abstact
		{
			set{ _s_abstact=value;}
			get{return _s_abstact;}
		}
		#endregion Model

	}
}


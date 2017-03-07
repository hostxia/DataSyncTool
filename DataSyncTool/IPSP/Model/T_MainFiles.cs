/**  版本信息模板在安装目录下，可自行修改。
* T_MainFiles.cs
*
* 功 能： N/A
* 类 名： T_MainFiles
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:44:55   N/A    初版
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
	/// T_MainFiles:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class T_MainFiles
	{
		public T_MainFiles()
		{}
		#region Model
		private int _n_fileid;
		private string _s_sendmethod;
		private string _s_name;
		private string _s_abstact;
		private string _s_filepathname;
		private string _s_iotype;
		private string _s_clientgov;
		private int? _n_processid;
		private DateTime? _dt_senddate;
		private DateTime? _dt_receivedate;
		private DateTime _dt_createdate;
		private DateTime _dt_editdate;
		private int _objecttype;
		private string _s_isactive;
		private int? _n_templateid;
		private DateTime? _dt_appdate;
		private string _s_pubno;
		private DateTime? _dt_pubdate;
		private string _s_caseserial;
		private string _s_appno;
		private string _s_applicants;
		private string _s_introducer;
		private string _s_inventors;
		private string _s_attorney;
		private string _s_creator;
		private string _s_editor;
		private int? _n_maincaseid;
		private string _s_status;
		private int? _n_flownum;
		private string _s_infileflownum;
		private string _s_isnewcaseinfile;
		private int? _n_numcount;
		private int? _n_piccount;
		private string _s_from;
		private string _s_to;
		private string _s_cc;
		private string _s_bc;
		private int _n_clientid;
		private string _s_iptype;
		private int _n_applicantid;
		private int? _n_creatorid;
		private int _n_fileclientid;
		private int _n_fileapplicantid;
		private string _s_nameforeign;
		private string _s_clienttype;
		private string _s_manualcreatechain;
		private string _s_sourcetype1;
		/// <summary>
		/// 
		/// </summary>
		public int n_FileID
		{
			set{ _n_fileid=value;}
			get{return _n_fileid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_SendMethod
		{
			set{ _s_sendmethod=value;}
			get{return _s_sendmethod;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_Name
		{
			set{ _s_name=value;}
			get{return _s_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_Abstact
		{
			set{ _s_abstact=value;}
			get{return _s_abstact;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_FilePathName
		{
			set{ _s_filepathname=value;}
			get{return _s_filepathname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_IOType
		{
			set{ _s_iotype=value;}
			get{return _s_iotype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_ClientGov
		{
			set{ _s_clientgov=value;}
			get{return _s_clientgov;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_ProcessID
		{
			set{ _n_processid=value;}
			get{return _n_processid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? dt_SendDate
		{
			set{ _dt_senddate=value;}
			get{return _dt_senddate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? dt_ReceiveDate
		{
			set{ _dt_receivedate=value;}
			get{return _dt_receivedate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime dt_CreateDate
		{
			set{ _dt_createdate=value;}
			get{return _dt_createdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime dt_EditDate
		{
			set{ _dt_editdate=value;}
			get{return _dt_editdate;}
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
		public string s_IsActive
		{
			set{ _s_isactive=value;}
			get{return _s_isactive;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_TemplateID
		{
			set{ _n_templateid=value;}
			get{return _n_templateid;}
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
		public string s_CaseSerial
		{
			set{ _s_caseserial=value;}
			get{return _s_caseserial;}
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
		public string s_Applicants
		{
			set{ _s_applicants=value;}
			get{return _s_applicants;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_Introducer
		{
			set{ _s_introducer=value;}
			get{return _s_introducer;}
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
		public string s_Attorney
		{
			set{ _s_attorney=value;}
			get{return _s_attorney;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_Creator
		{
			set{ _s_creator=value;}
			get{return _s_creator;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_Editor
		{
			set{ _s_editor=value;}
			get{return _s_editor;}
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
		public string s_Status
		{
			set{ _s_status=value;}
			get{return _s_status;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_FlowNum
		{
			set{ _n_flownum=value;}
			get{return _n_flownum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_InfileFlowNum
		{
			set{ _s_infileflownum=value;}
			get{return _s_infileflownum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_IsNewCaseInFile
		{
			set{ _s_isnewcaseinfile=value;}
			get{return _s_isnewcaseinfile;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_NumCount
		{
			set{ _n_numcount=value;}
			get{return _n_numcount;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_PicCount
		{
			set{ _n_piccount=value;}
			get{return _n_piccount;}
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
		public int n_ClientID
		{
			set{ _n_clientid=value;}
			get{return _n_clientid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_IPType
		{
			set{ _s_iptype=value;}
			get{return _s_iptype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int n_ApplicantID
		{
			set{ _n_applicantid=value;}
			get{return _n_applicantid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_CreatorID
		{
			set{ _n_creatorid=value;}
			get{return _n_creatorid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int n_FileClientID
		{
			set{ _n_fileclientid=value;}
			get{return _n_fileclientid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int n_FileApplicantID
		{
			set{ _n_fileapplicantid=value;}
			get{return _n_fileapplicantid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_NameForeign
		{
			set{ _s_nameforeign=value;}
			get{return _s_nameforeign;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_ClientType
		{
			set{ _s_clienttype=value;}
			get{return _s_clienttype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_ManualCreateChain
		{
			set{ _s_manualcreatechain=value;}
			get{return _s_manualcreatechain;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_sourcetype1
		{
			set{ _s_sourcetype1=value;}
			get{return _s_sourcetype1;}
		}
		#endregion Model

	}
}


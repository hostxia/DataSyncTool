/**  版本信息模板在安装目录下，可自行修改。
* T_Demand.cs
*
* 功 能： N/A
* 类 名： T_Demand
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:44:37   N/A    初版
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
	/// T_Demand:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class T_Demand
	{
		public T_Demand()
		{}
		#region Model
		private int _n_id;
		private string _s_content;
		private DateTime? _dt_editdate;
		private string _s_type;
		private string _s_moduletype;
		private int? _n_editorid;
		private string _s_active;
		private int? _n_sequence;
		private int? _n_objectid;
		private int? _n_sysdemandid;
		private string _s_title;
		private string _s_description;
		private string _s_creator;
		private DateTime? _dt_createdate;
		private string _s_editor;
		private string _s_iptype;
		private int _n_clientid;
		private int _n_applicantid;
		private int _n_caseid;
		private int _n_agencyid;
		private string _s_demandposition;
		private int _n_codedemandid;
		private string _s_receiptmethod;
		private string _s_assignor;
		private DateTime? _dt_receiptdate;
		private int? _n_codedemandtypeid;
		private string _s_filepath;
		private string _s_sysdemand;
		private int? _n_sysoftendemand;
		private string _s_process;
		private string _s_bussinesstype;
		private string _s_sourcemoduletype;
		private int? _n_sourceid;
		private int? _n_demadtype;
		private int? _n_demandtype;
		private string _s_sourcetype1;
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
		public string s_Content
		{
			set{ _s_content=value;}
			get{return _s_content;}
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
		public string s_Type
		{
			set{ _s_type=value;}
			get{return _s_type;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_ModuleType
		{
			set{ _s_moduletype=value;}
			get{return _s_moduletype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_EditorID
		{
			set{ _n_editorid=value;}
			get{return _n_editorid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_Active
		{
			set{ _s_active=value;}
			get{return _s_active;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_Sequence
		{
			set{ _n_sequence=value;}
			get{return _n_sequence;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_objectID
		{
			set{ _n_objectid=value;}
			get{return _n_objectid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_SysDemandID
		{
			set{ _n_sysdemandid=value;}
			get{return _n_sysdemandid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_Title
		{
			set{ _s_title=value;}
			get{return _s_title;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_Description
		{
			set{ _s_description=value;}
			get{return _s_description;}
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
		public DateTime? dt_CreateDate
		{
			set{ _dt_createdate=value;}
			get{return _dt_createdate;}
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
		public string s_IPType
		{
			set{ _s_iptype=value;}
			get{return _s_iptype;}
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
		public int n_ApplicantID
		{
			set{ _n_applicantid=value;}
			get{return _n_applicantid;}
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
		public int n_AgencyID
		{
			set{ _n_agencyid=value;}
			get{return _n_agencyid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_DemandPosition
		{
			set{ _s_demandposition=value;}
			get{return _s_demandposition;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int n_CodeDemandID
		{
			set{ _n_codedemandid=value;}
			get{return _n_codedemandid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_ReceiptMethod
		{
			set{ _s_receiptmethod=value;}
			get{return _s_receiptmethod;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_Assignor
		{
			set{ _s_assignor=value;}
			get{return _s_assignor;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? dt_ReceiptDate
		{
			set{ _dt_receiptdate=value;}
			get{return _dt_receiptdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_CodeDemandTypeID
		{
			set{ _n_codedemandtypeid=value;}
			get{return _n_codedemandtypeid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_FilePath
		{
			set{ _s_filepath=value;}
			get{return _s_filepath;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_SysDemand
		{
			set{ _s_sysdemand=value;}
			get{return _s_sysdemand;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_SysOftenDemand
		{
			set{ _n_sysoftendemand=value;}
			get{return _n_sysoftendemand;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_Process
		{
			set{ _s_process=value;}
			get{return _s_process;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_BussinessType
		{
			set{ _s_bussinesstype=value;}
			get{return _s_bussinesstype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_SourceModuleType
		{
			set{ _s_sourcemoduletype=value;}
			get{return _s_sourcemoduletype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_SourceID
		{
			set{ _n_sourceid=value;}
			get{return _n_sourceid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_DemadType
		{
			set{ _n_demadtype=value;}
			get{return _n_demadtype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_DemandType
		{
			set{ _n_demandtype=value;}
			get{return _n_demandtype;}
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


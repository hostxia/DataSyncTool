/**  版本信息模板在安装目录下，可自行修改。
* TCode_Demand.cs
*
* 功 能： N/A
* 类 名： TCode_Demand
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:46:11   N/A    初版
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
	/// TCode_Demand:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TCode_Demand
	{
		public TCode_Demand()
		{}
		#region Model
		private int _n_id;
		private string _s_iptype;
		private string _s_type;
		private string _s_title;
		private string _s_description;
		private bool _n_isactive;
		private string _s_creator;
		private DateTime? _dt_createdate;
		private string _s_editor;
		private DateTime? _dt_editdate;
		private string _s_sysdemand;
		private DateTime? _dt_receiptdate;
		private string _s_assignor;
		private string _s_receiptmethod;
		private int _n_codedemandtypeid;
		private int? _n_demadtype;
		private int? _n_demandtype;
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
		public string s_IPType
		{
			set{ _s_iptype=value;}
			get{return _s_iptype;}
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
		public bool n_IsActive
		{
			set{ _n_isactive=value;}
			get{return _n_isactive;}
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
		public DateTime? dt_EditDate
		{
			set{ _dt_editdate=value;}
			get{return _dt_editdate;}
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
		public DateTime? dt_ReceiptDate
		{
			set{ _dt_receiptdate=value;}
			get{return _dt_receiptdate;}
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
		public string s_ReceiptMethod
		{
			set{ _s_receiptmethod=value;}
			get{return _s_receiptmethod;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int n_CodeDemandTypeID
		{
			set{ _n_codedemandtypeid=value;}
			get{return _n_codedemandtypeid;}
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
		#endregion Model

	}
}


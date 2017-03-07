/**  版本信息模板在安装目录下，可自行修改。
* T_ContactMemo.cs
*
* 功 能： N/A
* 类 名： T_ContactMemo
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:44:36   N/A    初版
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
	/// T_ContactMemo:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class T_ContactMemo
	{
		public T_ContactMemo()
		{}
		#region Model
		private int _n_id;
		private string _s_objecttype;
		private int? _n_objectid;
		private int? _n_caseid;
		private string _s_subject;
		private string _s_cotactway;
		private DateTime? _s_contacttime;
		private int? _n_employeeid;
		private string _s_memo;
		private DateTime? _dt_contacttime;
		private string _s_filepath;
		private string _s_creator;
		private string _s_editor;
		private DateTime? _dt_createdate;
		private DateTime? _dt_editdate;
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
		public string s_ObjectType
		{
			set{ _s_objecttype=value;}
			get{return _s_objecttype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_ObjectID
		{
			set{ _n_objectid=value;}
			get{return _n_objectid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_CaseID
		{
			set{ _n_caseid=value;}
			get{return _n_caseid;}
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
		public string s_CotactWay
		{
			set{ _s_cotactway=value;}
			get{return _s_cotactway;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? s_ContactTime
		{
			set{ _s_contacttime=value;}
			get{return _s_contacttime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_EmployeeID
		{
			set{ _n_employeeid=value;}
			get{return _n_employeeid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_Memo
		{
			set{ _s_memo=value;}
			get{return _s_memo;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? dt_ContactTime
		{
			set{ _dt_contacttime=value;}
			get{return _dt_contacttime;}
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
		#endregion Model

	}
}


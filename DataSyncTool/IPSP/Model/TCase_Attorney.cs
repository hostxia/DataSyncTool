/**  版本信息模板在安装目录下，可自行修改。
* TCase_Attorney.cs
*
* 功 能： N/A
* 类 名： TCase_Attorney
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:45:24   N/A    初版
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
	/// TCase_Attorney:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TCase_Attorney
	{
		public TCase_Attorney()
		{}
		#region Model
		private int _n_id;
		private int _n_caseid;
		private int? _n_sequence;
		private int _n_attorneyid;
		private DateTime? _dt_assigndate;
		private int? _n_assignorid;
		private int? _n_caseroleid;
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
		public int? n_Sequence
		{
			set{ _n_sequence=value;}
			get{return _n_sequence;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int n_AttorneyID
		{
			set{ _n_attorneyid=value;}
			get{return _n_attorneyid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? dt_AssignDate
		{
			set{ _dt_assigndate=value;}
			get{return _dt_assigndate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_AssignorID
		{
			set{ _n_assignorid=value;}
			get{return _n_assignorid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_CaseRoleID
		{
			set{ _n_caseroleid=value;}
			get{return _n_caseroleid;}
		}
		#endregion Model

	}
}


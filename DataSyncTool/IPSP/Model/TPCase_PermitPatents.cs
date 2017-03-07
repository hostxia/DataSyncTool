/**  版本信息模板在安装目录下，可自行修改。
* TPCase_PermitPatents.cs
*
* 功 能： N/A
* 类 名： TPCase_PermitPatents
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:49:42   N/A    初版
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
	/// TPCase_PermitPatents:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TPCase_PermitPatents
	{
		public TPCase_PermitPatents()
		{}
		#region Model
		private int _n_id;
		private int _n_caseid;
		private string _s_patentnum;
		private string _s_patentname;
		private DateTime? _dt_appdate;
		private DateTime? _dt_procdate;
		private int _patent;
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
		public string s_PatentNum
		{
			set{ _s_patentnum=value;}
			get{return _s_patentnum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_PatentName
		{
			set{ _s_patentname=value;}
			get{return _s_patentname;}
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
		public DateTime? dt_ProcDate
		{
			set{ _dt_procdate=value;}
			get{return _dt_procdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int Patent
		{
			set{ _patent=value;}
			get{return _patent;}
		}
		#endregion Model

	}
}


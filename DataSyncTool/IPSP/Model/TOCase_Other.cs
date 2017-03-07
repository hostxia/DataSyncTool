/**  版本信息模板在安装目录下，可自行修改。
* TOCase_Other.cs
*
* 功 能： N/A
* 类 名： TOCase_Other
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:49:09   N/A    初版
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
	/// TOCase_Other:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TOCase_Other
	{
		public TOCase_Other()
		{}
		#region Model
		private int _n_caseid;
		private int? _n_oflownum;
		private DateTime? _dt_appdate;
		private string _s_applyaim;
		private string _s_ipstatus;
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
		public int? n_OFlowNum
		{
			set{ _n_oflownum=value;}
			get{return _n_oflownum;}
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
		public string s_ApplyAim
		{
			set{ _s_applyaim=value;}
			get{return _s_applyaim;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_IPStatus
		{
			set{ _s_ipstatus=value;}
			get{return _s_ipstatus;}
		}
		#endregion Model

	}
}


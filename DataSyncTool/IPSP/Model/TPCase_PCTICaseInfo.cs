/**  版本信息模板在安装目录下，可自行修改。
* TPCase_PCTICaseInfo.cs
*
* 功 能： N/A
* 类 名： TPCase_PCTICaseInfo
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:49:36   N/A    初版
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
	/// TPCase_PCTICaseInfo:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TPCase_PCTICaseInfo
	{
		public TPCase_PCTICaseInfo()
		{}
		#region Model
		private int _n_caseid;
		private string _s_isa;
		private string _s_isanum;
		private DateTime? _dt_isadate;
		private int? _n_isacountry;
		private int _patent;
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
		public string s_ISA
		{
			set{ _s_isa=value;}
			get{return _s_isa;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_ISANum
		{
			set{ _s_isanum=value;}
			get{return _s_isanum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? dt_ISADate
		{
			set{ _dt_isadate=value;}
			get{return _dt_isadate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_ISACountry
		{
			set{ _n_isacountry=value;}
			get{return _n_isacountry;}
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


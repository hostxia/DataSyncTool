/**  版本信息模板在安装目录下，可自行修改。
* TTCase_PermitMemo.cs
*
* 功 能： N/A
* 类 名： TTCase_PermitMemo
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:50:53   N/A    初版
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
	/// TTCase_PermitMemo:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TTCase_PermitMemo
	{
		public TTCase_PermitMemo()
		{}
		#region Model
		private int _n_id;
		private int _n_caseid;
		private string _s_memonum;
		private DateTime? _dt_memodate;
		private DateTime? _dt_memobegindate;
		private DateTime? _dt_memoenddate;
		private string _s_type;
		private string _s_fulfiladdr;
		private DateTime? _dt_contractdate;
		private decimal? _n_usefee;
		private int? _n_usefeecurrency;
		private string _s_appitem;
		private int? _s_repermit;
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
		public string s_MemoNum
		{
			set{ _s_memonum=value;}
			get{return _s_memonum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? dt_MemoDate
		{
			set{ _dt_memodate=value;}
			get{return _dt_memodate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? dt_MemoBeginDate
		{
			set{ _dt_memobegindate=value;}
			get{return _dt_memobegindate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? dt_MemoEndDate
		{
			set{ _dt_memoenddate=value;}
			get{return _dt_memoenddate;}
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
		public string s_FulFilAddr
		{
			set{ _s_fulfiladdr=value;}
			get{return _s_fulfiladdr;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? dt_ContractDate
		{
			set{ _dt_contractdate=value;}
			get{return _dt_contractdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? n_UseFee
		{
			set{ _n_usefee=value;}
			get{return _n_usefee;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_UseFeeCurrency
		{
			set{ _n_usefeecurrency=value;}
			get{return _n_usefeecurrency;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_AppItem
		{
			set{ _s_appitem=value;}
			get{return _s_appitem;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? s_RePermit
		{
			set{ _s_repermit=value;}
			get{return _s_repermit;}
		}
		#endregion Model

	}
}


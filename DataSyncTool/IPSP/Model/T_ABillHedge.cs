/**  版本信息模板在安装目录下，可自行修改。
* T_ABillHedge.cs
*
* 功 能： N/A
* 类 名： T_ABillHedge
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:44:27   N/A    初版
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
	/// T_ABillHedge:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class T_ABillHedge
	{
		public T_ABillHedge()
		{}
		#region Model
		private int _n_id;
		private int _n_agencyid;
		private int _n_clientid;
		private string _s_hedgeno;
		private DateTime? _dt_hedge;
		private decimal? _n_amount;
		private int? _n_currencyid;
		private decimal? _s_balanceamount;
		private string _s_editor;
		private DateTime? _dt_edittime;
		private string _isputintowallet;
		private DateTime? _dt_createdate;
		private DateTime? _dt_editdate;
		private string _s_creator;
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
		public int n_AgencyID
		{
			set{ _n_agencyid=value;}
			get{return _n_agencyid;}
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
		public string s_HedgeNo
		{
			set{ _s_hedgeno=value;}
			get{return _s_hedgeno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? dt_Hedge
		{
			set{ _dt_hedge=value;}
			get{return _dt_hedge;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? n_Amount
		{
			set{ _n_amount=value;}
			get{return _n_amount;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_CurrencyID
		{
			set{ _n_currencyid=value;}
			get{return _n_currencyid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? s_BalanceAmount
		{
			set{ _s_balanceamount=value;}
			get{return _s_balanceamount;}
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
		public DateTime? dt_EditTime
		{
			set{ _dt_edittime=value;}
			get{return _dt_edittime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string IsPutIntoWallet
		{
			set{ _isputintowallet=value;}
			get{return _isputintowallet;}
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
		public string s_Creator
		{
			set{ _s_creator=value;}
			get{return _s_creator;}
		}
		#endregion Model

	}
}


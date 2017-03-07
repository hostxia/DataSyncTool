/**  版本信息模板在安装目录下，可自行修改。
* TTB_Deposit.cs
*
* 功 能： N/A
* 类 名： TTB_Deposit
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:50:09   N/A    初版
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
	/// TTB_Deposit:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TTB_Deposit
	{
		public TTB_Deposit()
		{}
		#region Model
		private int _n_depositid;
		private string _s_class;
		private DateTime? _dt_date;
		private decimal? _n_money;
		private string _s_sheetno;
		private string _s_bank;
		private string _s_account;
		private DateTime? _dt_createdate;
		private string _s_creator;
		private DateTime? _dt_editdate;
		private string _s_editor;
		private string _s_note;
		/// <summary>
		/// 
		/// </summary>
		public int n_DepositID
		{
			set{ _n_depositid=value;}
			get{return _n_depositid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_Class
		{
			set{ _s_class=value;}
			get{return _s_class;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? dt_Date
		{
			set{ _dt_date=value;}
			get{return _dt_date;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? n_Money
		{
			set{ _n_money=value;}
			get{return _n_money;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_SheetNo
		{
			set{ _s_sheetno=value;}
			get{return _s_sheetno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_Bank
		{
			set{ _s_bank=value;}
			get{return _s_bank;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_Account
		{
			set{ _s_account=value;}
			get{return _s_account;}
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
		public string s_Creator
		{
			set{ _s_creator=value;}
			get{return _s_creator;}
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
		public string s_Editor
		{
			set{ _s_editor=value;}
			get{return _s_editor;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_Note
		{
			set{ _s_note=value;}
			get{return _s_note;}
		}
		#endregion Model

	}
}


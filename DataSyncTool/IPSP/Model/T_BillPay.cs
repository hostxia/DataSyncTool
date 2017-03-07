/**  版本信息模板在安装目录下，可自行修改。
* T_BillPay.cs
*
* 功 能： N/A
* 类 名： T_BillPay
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:44:32   N/A    初版
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
	/// T_BillPay:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class T_BillPay
	{
		public T_BillPay()
		{}
		#region Model
		private int _n_billpayid;
		private int _n_cmoneyid;
		private int _n_clientid;
		private int _n_billid;
		private int? _n_paycurrencyid;
		/// <summary>
		/// 
		/// </summary>
		public int n_BillPayID
		{
			set{ _n_billpayid=value;}
			get{return _n_billpayid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int n_CMoneyID
		{
			set{ _n_cmoneyid=value;}
			get{return _n_cmoneyid;}
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
		public int n_BillID
		{
			set{ _n_billid=value;}
			get{return _n_billid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_PayCurrencyID
		{
			set{ _n_paycurrencyid=value;}
			get{return _n_paycurrencyid;}
		}
		#endregion Model

	}
}


/**  版本信息模板在安装目录下，可自行修改。
* T_Payment.cs
*
* 功 能： N/A
* 类 名： T_Payment
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:44:59   N/A    初版
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
	/// T_Payment:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class T_Payment
	{
		public T_Payment()
		{}
		#region Model
		private int _n_paymentid;
		private int? _n_billlistid;
		private int _n_billid;
		private int? _n_receiveid;
		private int _n_hedgeid;
		private decimal? _n_paymentamount;
		private DateTime? _dt_paymentdate;
		private int? _n_paymentuserid;
		private string _s_editor;
		private DateTime? _dt_edittime;
		/// <summary>
		/// 
		/// </summary>
		public int n_PaymentID
		{
			set{ _n_paymentid=value;}
			get{return _n_paymentid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_BillListID
		{
			set{ _n_billlistid=value;}
			get{return _n_billlistid;}
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
		public int? n_ReceiveID
		{
			set{ _n_receiveid=value;}
			get{return _n_receiveid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int n_HedgeID
		{
			set{ _n_hedgeid=value;}
			get{return _n_hedgeid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? n_PaymentAmount
		{
			set{ _n_paymentamount=value;}
			get{return _n_paymentamount;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? dt_PaymentDate
		{
			set{ _dt_paymentdate=value;}
			get{return _dt_paymentdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_PaymentUserID
		{
			set{ _n_paymentuserid=value;}
			get{return _n_paymentuserid;}
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
		#endregion Model

	}
}


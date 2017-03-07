/**  版本信息模板在安装目录下，可自行修改。
* T_BillListPay.cs
*
* 功 能： N/A
* 类 名： T_BillListPay
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:44:31   N/A    初版
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
	/// T_BillListPay:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class T_BillListPay
	{
		public T_BillListPay()
		{}
		#region Model
		private int _n_billlistpayid;
		private int _n_billpayid;
		private int _n_billlistid;
		private decimal? _n_paymentamount;
		private DateTime? _dt_paymentdate;
		private int? _n_paymentuserid;
		private string _s_editor;
		private DateTime? _dt_edittime;
		private decimal? _n_ofee;
		private decimal? _n_attrfee;
		private decimal? _n_orginalattrfee;
		private decimal? _n_otherfee;
		/// <summary>
		/// 
		/// </summary>
		public int n_BillListPayID
		{
			set{ _n_billlistpayid=value;}
			get{return _n_billlistpayid;}
		}
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
		public int n_BillListID
		{
			set{ _n_billlistid=value;}
			get{return _n_billlistid;}
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
		/// <summary>
		/// 
		/// </summary>
		public decimal? n_OFee
		{
			set{ _n_ofee=value;}
			get{return _n_ofee;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? n_AttrFee
		{
			set{ _n_attrfee=value;}
			get{return _n_attrfee;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? n_OrginalAttrFee
		{
			set{ _n_orginalattrfee=value;}
			get{return _n_orginalattrfee;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? n_OtherFee
		{
			set{ _n_otherfee=value;}
			get{return _n_otherfee;}
		}
		#endregion Model

	}
}


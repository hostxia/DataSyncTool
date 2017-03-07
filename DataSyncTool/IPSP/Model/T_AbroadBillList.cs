/**  版本信息模板在安装目录下，可自行修改。
* T_AbroadBillList.cs
*
* 功 能： N/A
* 类 名： T_AbroadBillList
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:44:28   N/A    初版
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
	/// T_AbroadBillList:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class T_AbroadBillList
	{
		public T_AbroadBillList()
		{}
		#region Model
		private int _n_id;
		private int _n_billid;
		private int _n_caseid;
		private string _s_feename;
		private decimal? _n_fee;
		private decimal? _n_afee;
		private decimal? _n_tfee;
		private string _s_paymark;
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
		public int n_BillID
		{
			set{ _n_billid=value;}
			get{return _n_billid;}
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
		public string s_FeeName
		{
			set{ _s_feename=value;}
			get{return _s_feename;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? n_Fee
		{
			set{ _n_fee=value;}
			get{return _n_fee;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? n_AFee
		{
			set{ _n_afee=value;}
			get{return _n_afee;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? n_TFee
		{
			set{ _n_tfee=value;}
			get{return _n_tfee;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_PayMark
		{
			set{ _s_paymark=value;}
			get{return _s_paymark;}
		}
		#endregion Model

	}
}


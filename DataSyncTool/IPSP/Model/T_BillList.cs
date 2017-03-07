/**  版本信息模板在安装目录下，可自行修改。
* T_BillList.cs
*
* 功 能： N/A
* 类 名： T_BillList
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
	/// T_BillList:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class T_BillList
	{
		public T_BillList()
		{}
		#region Model
		private int _n_id;
		private int _n_billid;
		private string _s_feename;
		private string _s_type;
		private int? _n_sourceid;
		private decimal? _n_ofee;
		private decimal? _n_attrfee;
		private decimal? _n_otherfee;
		private string _s_status;
		private int? _n_sequence;
		private int? _n_feeid;
		private int? _n_feecodeid;
		private decimal? _n_attrfeetaxrate;
		private decimal? _n_ofeetaxrate;
		private decimal? _n_disbfeetaxrate;
		private decimal? _n_orginalattrfee;
		private decimal? _n_orignalotherfee;
		private decimal? _n_discountattrfeerate;
		private decimal? _n_discountotherfeerate;
		private int? _n_preferentialpolicyid;
		private decimal? _n_moreunitcount;
		private string _s_feenotes;
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
		public string s_FeeName
		{
			set{ _s_feename=value;}
			get{return _s_feename;}
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
		public int? n_SourceID
		{
			set{ _n_sourceid=value;}
			get{return _n_sourceid;}
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
		public decimal? n_OtherFee
		{
			set{ _n_otherfee=value;}
			get{return _n_otherfee;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_Status
		{
			set{ _s_status=value;}
			get{return _s_status;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_Sequence
		{
			set{ _n_sequence=value;}
			get{return _n_sequence;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_FeeID
		{
			set{ _n_feeid=value;}
			get{return _n_feeid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_FeeCodeID
		{
			set{ _n_feecodeid=value;}
			get{return _n_feecodeid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? n_AttrFeeTaxRate
		{
			set{ _n_attrfeetaxrate=value;}
			get{return _n_attrfeetaxrate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? n_OFeeTaxRate
		{
			set{ _n_ofeetaxrate=value;}
			get{return _n_ofeetaxrate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? n_DisbFeeTaxRate
		{
			set{ _n_disbfeetaxrate=value;}
			get{return _n_disbfeetaxrate;}
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
		public decimal? n_OrignalOtherFee
		{
			set{ _n_orignalotherfee=value;}
			get{return _n_orignalotherfee;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? n_DiscountAttrFeeRate
		{
			set{ _n_discountattrfeerate=value;}
			get{return _n_discountattrfeerate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? n_DiscountOtherFeeRate
		{
			set{ _n_discountotherfeerate=value;}
			get{return _n_discountotherfeerate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_PreferentialPolicyID
		{
			set{ _n_preferentialpolicyid=value;}
			get{return _n_preferentialpolicyid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? n_moreUnitCount
		{
			set{ _n_moreunitcount=value;}
			get{return _n_moreunitcount;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_FeeNotes
		{
			set{ _s_feenotes=value;}
			get{return _s_feenotes;}
		}
		#endregion Model

	}
}


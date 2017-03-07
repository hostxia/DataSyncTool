/**  版本信息模板在安装目录下，可自行修改。
* TCode_PreferentialPolicy.cs
*
* 功 能： N/A
* 类 名： TCode_PreferentialPolicy
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:46:44   N/A    初版
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
	/// TCode_PreferentialPolicy:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TCode_PreferentialPolicy
	{
		public TCode_PreferentialPolicy()
		{}
		#region Model
		private int _n_id;
		private string _s_iptype;
		private string _s_name;
		private string _s_preferentialpolicytype;
		private int? _n_preferentialpolicysubtype;
		private string _s_discounttype;
		private decimal? _n_discount;
		private int? _n_currency;
		private string _s_notes;
		private DateTime? _dt_createdate;
		private DateTime? _dt_editdate;
		private string _s_creator;
		private string _s_editor;
		private string _s_preferentialpolicysubtype;
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
		public string s_IPType
		{
			set{ _s_iptype=value;}
			get{return _s_iptype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_Name
		{
			set{ _s_name=value;}
			get{return _s_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_PreferentialPolicyType
		{
			set{ _s_preferentialpolicytype=value;}
			get{return _s_preferentialpolicytype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_PreferentialPolicySubType
		{
			set{ _n_preferentialpolicysubtype=value;}
			get{return _n_preferentialpolicysubtype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_DiscountType
		{
			set{ _s_discounttype=value;}
			get{return _s_discounttype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? n_Discount
		{
			set{ _n_discount=value;}
			get{return _n_discount;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_Currency
		{
			set{ _n_currency=value;}
			get{return _n_currency;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_Notes
		{
			set{ _s_notes=value;}
			get{return _s_notes;}
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
		public string s_PreferentialPolicySubType
		{
			set{ _s_preferentialpolicysubtype=value;}
			get{return _s_preferentialpolicysubtype;}
		}
		#endregion Model

	}
}


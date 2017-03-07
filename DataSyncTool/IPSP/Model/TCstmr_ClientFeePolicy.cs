/**  版本信息模板在安装目录下，可自行修改。
* TCstmr_ClientFeePolicy.cs
*
* 功 能： N/A
* 类 名： TCstmr_ClientFeePolicy
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:47:48   N/A    初版
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
	/// TCstmr_ClientFeePolicy:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TCstmr_ClientFeePolicy
	{
		public TCstmr_ClientFeePolicy()
		{}
		#region Model
		private int _n_id;
		private int _n_clientid;
		private int? _n_chargecurrency;
		private string _s_iptype;
		private string _s_feemode;
		private decimal? _n_value;
		private string _s_note;
		private DateTime? _dt_editdate;
		private int? _n_payunit;
		private string _s_iprole;
		private string _s_feetype;
		private int? _n_endprocess;
		private string _s_businesstype;
		private string _s_ptctype;
		/// <summary>
		/// 自增ID
		/// </summary>
		public int n_ID
		{
			set{ _n_id=value;}
			get{return _n_id;}
		}
		/// <summary>
		/// 客户ID
		/// </summary>
		public int n_ClientID
		{
			set{ _n_clientid=value;}
			get{return _n_clientid;}
		}
		/// <summary>
		/// 收费币种（取自币种代码表中的编号）
		/// </summary>
		public int? n_ChargeCurrency
		{
			set{ _n_chargecurrency=value;}
			get{return _n_chargecurrency;}
		}
		/// <summary>
		/// 委托业务（专利,商标等），可多选
	///P:专利；T:商标；D：域名；C：版权 O：其它
	///空：不限或all
		/// </summary>
		public string s_IPType
		{
			set{ _s_iptype=value;}
			get{return _s_iptype;}
		}
		/// <summary>
		/// 收费类别（1：代理费折扣 2：包干代理费 3：包干全案费）
		/// </summary>
		public string s_FeeMode
		{
			set{ _s_feemode=value;}
			get{return _s_feemode;}
		}
		/// <summary>
		/// 费用金额，或代理费折扣
		/// </summary>
		public decimal? n_Value
		{
			set{ _n_value=value;}
			get{return _n_value;}
		}
		/// <summary>
		/// 备注信息
		/// </summary>
		public string s_Note
		{
			set{ _s_note=value;}
			get{return _s_note;}
		}
		/// <summary>
		/// 编辑日期
		/// </summary>
		public DateTime? dt_EditDate
		{
			set{ _dt_editdate=value;}
			get{return _dt_editdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_PayUnit
		{
			set{ _n_payunit=value;}
			get{return _n_payunit;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_IPRole
		{
			set{ _s_iprole=value;}
			get{return _s_iprole;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_FeeType
		{
			set{ _s_feetype=value;}
			get{return _s_feetype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_EndProcess
		{
			set{ _n_endprocess=value;}
			get{return _n_endprocess;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_BusinessType
		{
			set{ _s_businesstype=value;}
			get{return _s_businesstype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_PTCType
		{
			set{ _s_ptctype=value;}
			get{return _s_ptctype;}
		}
		#endregion Model

	}
}


/**  版本信息模板在安装目录下，可自行修改。
* TTCase_Goods.cs
*
* 功 能： N/A
* 类 名： TTCase_Goods
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:50:30   N/A    初版
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
	/// TTCase_Goods:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TTCase_Goods
	{
		public TTCase_Goods()
		{}
		#region Model
		private int _n_id;
		private int _n_caseid;
		private string _s_goodsname;
		private string _s_othername;
		private string _s_groupcode;
		private string _s_itemcode;
		private int? _n_sequence;
		private int? _n_trademarkclass;
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
		public string s_GoodsName
		{
			set{ _s_goodsname=value;}
			get{return _s_goodsname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_OtherName
		{
			set{ _s_othername=value;}
			get{return _s_othername;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_GroupCode
		{
			set{ _s_groupcode=value;}
			get{return _s_groupcode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_ItemCode
		{
			set{ _s_itemcode=value;}
			get{return _s_itemcode;}
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
		public int? n_TrademarkClass
		{
			set{ _n_trademarkclass=value;}
			get{return _n_trademarkclass;}
		}
		#endregion Model

	}
}


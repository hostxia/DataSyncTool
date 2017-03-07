/**  版本信息模板在安装目录下，可自行修改。
* TCode_CaseProcessItem.cs
*
* 功 能： N/A
* 类 名： TCode_CaseProcessItem
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:45:55   N/A    初版
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
	/// TCode_CaseProcessItem:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TCode_CaseProcessItem
	{
		public TCode_CaseProcessItem()
		{}
		#region Model
		private int _n_id;
		private int _n_masterid;
		private int _n_processnameid;
		private int? _n_patentid;
		private int? _n_ordernum;
		private string _s_autocreate;
		private string _s_allowrepeat;
		private decimal? _n_emintimevalue;
		private string _s_emintimeunit;
		private decimal? _n_emaxtimevalue;
		private string _s_emaxtimeunit;
		private string _s_note;
		private string _s_basedate;
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
		public int n_MasterID
		{
			set{ _n_masterid=value;}
			get{return _n_masterid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int n_ProcessNameID
		{
			set{ _n_processnameid=value;}
			get{return _n_processnameid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_PatentID
		{
			set{ _n_patentid=value;}
			get{return _n_patentid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_OrderNum
		{
			set{ _n_ordernum=value;}
			get{return _n_ordernum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_AutoCreate
		{
			set{ _s_autocreate=value;}
			get{return _s_autocreate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_AllowRepeat
		{
			set{ _s_allowrepeat=value;}
			get{return _s_allowrepeat;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? n_EMinTimeValue
		{
			set{ _n_emintimevalue=value;}
			get{return _n_emintimevalue;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_EMinTimeUnit
		{
			set{ _s_emintimeunit=value;}
			get{return _s_emintimeunit;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? n_EMaxTimeValue
		{
			set{ _n_emaxtimevalue=value;}
			get{return _n_emaxtimevalue;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_EMaxTimeUnit
		{
			set{ _s_emaxtimeunit=value;}
			get{return _s_emaxtimeunit;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_Note
		{
			set{ _s_note=value;}
			get{return _s_note;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_BaseDate
		{
			set{ _s_basedate=value;}
			get{return _s_basedate;}
		}
		#endregion Model

	}
}


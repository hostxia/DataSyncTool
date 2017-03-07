/**  版本信息模板在安装目录下，可自行修改。
* TCode_OftenDemand.cs
*
* 功 能： N/A
* 类 名： TCode_OftenDemand
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:46:40   N/A    初版
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
	/// TCode_OftenDemand:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TCode_OftenDemand
	{
		public TCode_OftenDemand()
		{}
		#region Model
		private int _n_id;
		private string _s_businesstype;
		private string _s_patenttype;
		private string _s_trademarktype;
		private string _s_applicationtype;
		private int _n_codedemandid;
		private string _s_casetype;
		private string _s_oftencreator;
		private string _s_ofteneditor;
		private DateTime? _dt_oftencreatedate;
		private DateTime? _dt_ofteneditdate;
		private string _s_process;
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
		public string s_BusinessType
		{
			set{ _s_businesstype=value;}
			get{return _s_businesstype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_PatentType
		{
			set{ _s_patenttype=value;}
			get{return _s_patenttype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_TrademarkType
		{
			set{ _s_trademarktype=value;}
			get{return _s_trademarktype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_ApplicationType
		{
			set{ _s_applicationtype=value;}
			get{return _s_applicationtype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int n_CodeDemandID
		{
			set{ _n_codedemandid=value;}
			get{return _n_codedemandid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_CaseType
		{
			set{ _s_casetype=value;}
			get{return _s_casetype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_OftenCreator
		{
			set{ _s_oftencreator=value;}
			get{return _s_oftencreator;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_OftenEditor
		{
			set{ _s_ofteneditor=value;}
			get{return _s_ofteneditor;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? dt_OftenCreateDate
		{
			set{ _dt_oftencreatedate=value;}
			get{return _dt_oftencreatedate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? dt_OftenEditDate
		{
			set{ _dt_ofteneditdate=value;}
			get{return _dt_ofteneditdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_Process
		{
			set{ _s_process=value;}
			get{return _s_process;}
		}
		#endregion Model

	}
}


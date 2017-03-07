/**  版本信息模板在安装目录下，可自行修改。
* TCode_Country.cs
*
* 功 能： N/A
* 类 名： TCode_Country
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:46:04   N/A    初版
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
	/// TCode_Country:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TCode_Country
	{
		public TCode_Country()
		{}
		#region Model
		private int _n_id;
		private string _s_countrycode;
		private string _s_name;
		private string _s_othername;
		private string _s_madridagreement;
		private string _s_madridprotocol;
		private string _s_pctcontract;
		private string _s_multiclass;
		private DateTime? _dt_createdate;
		private DateTime? _dt_editdate;
		private int? _n_frequentno;
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
		public string s_CountryCode
		{
			set{ _s_countrycode=value;}
			get{return _s_countrycode;}
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
		public string s_OtherName
		{
			set{ _s_othername=value;}
			get{return _s_othername;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_MadridAgreement
		{
			set{ _s_madridagreement=value;}
			get{return _s_madridagreement;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_MadridProtocol
		{
			set{ _s_madridprotocol=value;}
			get{return _s_madridprotocol;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_PCTContract
		{
			set{ _s_pctcontract=value;}
			get{return _s_pctcontract;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_MultiClass
		{
			set{ _s_multiclass=value;}
			get{return _s_multiclass;}
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
		public int? n_FrequentNo
		{
			set{ _n_frequentno=value;}
			get{return _n_frequentno;}
		}
		#endregion Model

	}
}


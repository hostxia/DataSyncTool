/**  版本信息模板在安装目录下，可自行修改。
* TCstmr_CommContact.cs
*
* 功 能： N/A
* 类 名： TCstmr_CommContact
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:47:52   N/A    初版
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
	/// TCstmr_CommContact:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TCstmr_CommContact
	{
		public TCstmr_CommContact()
		{}
		#region Model
		private int _n_contactid;
		private string _s_name;
		private int? _n_countryid;
		private string _s_province;
		private string _s_city;
		private string _s_tel;
		private string _s_fax;
		private string _s_email;
		private string _s_website;
		private string _s_zipcode;
		private string _s_addr;
		private string _s_note;
		private string _s_public;
		private DateTime? _dt_createdate;
		private string _s_creator;
		private DateTime? _dt_editdate;
		private string _s_editor;
		private string _s_lock;
		private string _s_locker;
		/// <summary>
		/// 
		/// </summary>
		public int n_ContactID
		{
			set{ _n_contactid=value;}
			get{return _n_contactid;}
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
		public int? n_CountryID
		{
			set{ _n_countryid=value;}
			get{return _n_countryid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_Province
		{
			set{ _s_province=value;}
			get{return _s_province;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_City
		{
			set{ _s_city=value;}
			get{return _s_city;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_Tel
		{
			set{ _s_tel=value;}
			get{return _s_tel;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_Fax
		{
			set{ _s_fax=value;}
			get{return _s_fax;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_Email
		{
			set{ _s_email=value;}
			get{return _s_email;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_WebSite
		{
			set{ _s_website=value;}
			get{return _s_website;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_ZipCode
		{
			set{ _s_zipcode=value;}
			get{return _s_zipcode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_Addr
		{
			set{ _s_addr=value;}
			get{return _s_addr;}
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
		public string s_Public
		{
			set{ _s_public=value;}
			get{return _s_public;}
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
		public string s_Creator
		{
			set{ _s_creator=value;}
			get{return _s_creator;}
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
		public string s_Editor
		{
			set{ _s_editor=value;}
			get{return _s_editor;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_Lock
		{
			set{ _s_lock=value;}
			get{return _s_lock;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_Locker
		{
			set{ _s_locker=value;}
			get{return _s_locker;}
		}
		#endregion Model

	}
}


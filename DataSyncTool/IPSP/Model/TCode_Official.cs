/**  版本信息模板在安装目录下，可自行修改。
* TCode_Official.cs
*
* 功 能： N/A
* 类 名： TCode_Official
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:46:39   N/A    初版
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
	/// TCode_Official:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TCode_Official
	{
		public TCode_Official()
		{}
		#region Model
		private int _n_id;
		private string _s_iptype;
		private string _s_officialcode;
		private string _s_name;
		private string _s_othername;
		private int? _n_language;
		private string _s_phone;
		private string _s_fax;
		private string _s_email;
		private string _s_website;
		private int? _n_country;
		private string _s_state;
		private string _s_city;
		private string _s_street;
		private string _s_zipcode;
		private string _s_notes;
		private DateTime? _dt_createdate;
		private DateTime? _dt_editdate;
		private string _s_iprole;
		private string _s_issystem;
		private string _s_charger;
		private string _s_chargerphone;
		private string _s_chargeremail;
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
		public string s_OfficialCode
		{
			set{ _s_officialcode=value;}
			get{return _s_officialcode;}
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
		public int? n_Language
		{
			set{ _n_language=value;}
			get{return _n_language;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_Phone
		{
			set{ _s_phone=value;}
			get{return _s_phone;}
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
		public string s_Website
		{
			set{ _s_website=value;}
			get{return _s_website;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_Country
		{
			set{ _n_country=value;}
			get{return _n_country;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_State
		{
			set{ _s_state=value;}
			get{return _s_state;}
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
		public string s_Street
		{
			set{ _s_street=value;}
			get{return _s_street;}
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
		public string s_IPRole
		{
			set{ _s_iprole=value;}
			get{return _s_iprole;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_IsSystem
		{
			set{ _s_issystem=value;}
			get{return _s_issystem;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_Charger
		{
			set{ _s_charger=value;}
			get{return _s_charger;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_ChargerPhone
		{
			set{ _s_chargerphone=value;}
			get{return _s_chargerphone;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_ChargerEmail
		{
			set{ _s_chargeremail=value;}
			get{return _s_chargeremail;}
		}
		#endregion Model

	}
}


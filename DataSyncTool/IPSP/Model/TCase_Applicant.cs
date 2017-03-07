/**  版本信息模板在安装目录下，可自行修改。
* TCase_Applicant.cs
*
* 功 能： N/A
* 类 名： TCase_Applicant
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:45:23   N/A    初版
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
	/// TCase_Applicant:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TCase_Applicant
	{
		public TCase_Applicant()
		{}
		#region Model
		private int _n_id;
		private int _n_caseid;
		private string _s_isdelegacy;
		private int? _n_sequence;
		private int? _n_applicantid;
		private string _s_name;
		private string _s_nativename;
		private string _s_othername;
		private string _s_phone;
		private string _s_mobile;
		private string _s_fax;
		private string _s_email;
		private int? _n_country;
		private string _s_state;
		private string _s_city;
		private string _s_street;
		private string _s_zipcode;
		private string _s_isapplicant;
		private string _s_isappinv;
		private string _s_isinventor;
		private string _s_forallcountries;
		private string _s_fornonus;
		private string _s_forus;
		private string _s_forspeccountries;
		private string _s_efilingapplicanttype;
		private string _s_applicanttypecontent;
		private string _s_otheraddress;
		private string _s_cardnumber;
		private string _s_elecpayer;
		private string _s_trustdeedno;
		private string _s_appserial;
		private string _n_isreceipt;
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
		public string s_IsDelegacy
		{
			set{ _s_isdelegacy=value;}
			get{return _s_isdelegacy;}
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
		public int? n_ApplicantID
		{
			set{ _n_applicantid=value;}
			get{return _n_applicantid;}
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
		public string s_NativeName
		{
			set{ _s_nativename=value;}
			get{return _s_nativename;}
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
		public string s_Phone
		{
			set{ _s_phone=value;}
			get{return _s_phone;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_Mobile
		{
			set{ _s_mobile=value;}
			get{return _s_mobile;}
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
		public string s_IsApplicant
		{
			set{ _s_isapplicant=value;}
			get{return _s_isapplicant;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_IsAppInv
		{
			set{ _s_isappinv=value;}
			get{return _s_isappinv;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_IsInventor
		{
			set{ _s_isinventor=value;}
			get{return _s_isinventor;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_ForAllCountries
		{
			set{ _s_forallcountries=value;}
			get{return _s_forallcountries;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_ForNonUS
		{
			set{ _s_fornonus=value;}
			get{return _s_fornonus;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_ForUS
		{
			set{ _s_forus=value;}
			get{return _s_forus;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_ForSpecCountries
		{
			set{ _s_forspeccountries=value;}
			get{return _s_forspeccountries;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_EFilingApplicantType
		{
			set{ _s_efilingapplicanttype=value;}
			get{return _s_efilingapplicanttype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_ApplicantTypeContent
		{
			set{ _s_applicanttypecontent=value;}
			get{return _s_applicanttypecontent;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_OtherAddress
		{
			set{ _s_otheraddress=value;}
			get{return _s_otheraddress;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_CardNumber
		{
			set{ _s_cardnumber=value;}
			get{return _s_cardnumber;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_ElecPayer
		{
			set{ _s_elecpayer=value;}
			get{return _s_elecpayer;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_TrustDeedNo
		{
			set{ _s_trustdeedno=value;}
			get{return _s_trustdeedno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_AppSerial
		{
			set{ _s_appserial=value;}
			get{return _s_appserial;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string n_IsReceipt
		{
			set{ _n_isreceipt=value;}
			get{return _n_isreceipt;}
		}
		#endregion Model

	}
}


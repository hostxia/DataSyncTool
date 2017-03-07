/**  版本信息模板在安装目录下，可自行修改。
* TCstmr_Applicant.cs
*
* 功 能： N/A
* 类 名： TCstmr_Applicant
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:47:35   N/A    初版
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
	/// TCstmr_Applicant:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TCstmr_Applicant
	{
		public TCstmr_Applicant()
		{}
		#region Model
		private int _n_appid;
		private int _n_clientid;
		private string _s_name;
		private string _s_nativename;
		private string _s_othername;
		private string _s_iptype;
		private string _s_apptype;
		private string _s_idname;
		private string _s_idnumber;
		private string _s_appcode;
		private string _s_hastrustdeed;
		private string _s_trustdeedno;
		private string _s_trustdeedpath;
		private string _s_corporation;
		private string _s_duty;
		private string _s_notes;
		private string _s_phone;
		private string _s_mobile;
		private string _s_fax;
		private string _s_email;
		private string _s_website;
		private string _s_imaddress;
		private string _s_facebook;
		private string _s_twitter;
		private DateTime? _dt_createdate;
		private DateTime? _dt_editdate;
		private int _objecttype;
		private string _s_lock;
		private string _s_locker;
		private string _s_creator;
		private string _s_editor;
		private string _s_area;
		private int? _n_patentcasecount;
		private int? _n_tmcasecount;
		private int? _n_copyrightcasecount;
		private int? _n_domaincasecount;
		private int? _n_othercasecount;
		private string _s_firstaddress;
		private DateTime? _dt_firstcasefromdate;
		private DateTime? _dt_lastcasefromdate;
		private string _s_addresses;
		private string _s_contactsfirstname;
		private string _s_contactslastname;
		private string _s_contactstel;
		private string _s_contactsfax;
		private string _s_contactsaddresses;
		private string _s_govname;
		private string _s_accountname;
		private string _s_bankname;
		private string _s_accountno;
		private string _s_accountcode;
		private string _s_taxcode;
		private string _s_regaddress;
		private string _s_regtel;
		private string _s_invoiceto;
		private int _n_securitylevelid;
		private string _s_payfeeperson;
		private bool _b_elecpayer;
		private int? _n_country;
		private string _s_feemitigationyear;
		private string _s_feemitigationnum;
		/// <summary>
		/// 申请人ID号
		/// </summary>
		public int n_AppID
		{
			set{ _n_appid=value;}
			get{return _n_appid;}
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
		/// 名称
		/// </summary>
		public string s_Name
		{
			set{ _s_name=value;}
			get{return _s_name;}
		}
		/// <summary>
		/// 本国名称
		/// </summary>
		public string s_NativeName
		{
			set{ _s_nativename=value;}
			get{return _s_nativename;}
		}
		/// <summary>
		/// 其它名称
		/// </summary>
		public string s_OtherName
		{
			set{ _s_othername=value;}
			get{return _s_othername;}
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
		/// 申请人类别（0：个人 1：单位/企业）
		/// </summary>
		public string s_AppType
		{
			set{ _s_apptype=value;}
			get{return _s_apptype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_IDName
		{
			set{ _s_idname=value;}
			get{return _s_idname;}
		}
		/// <summary>
		/// 企业代码或个人身份证号
		/// </summary>
		public string s_IDNumber
		{
			set{ _s_idnumber=value;}
			get{return _s_idnumber;}
		}
		/// <summary>
		/// 申请人编码（专利局）
		/// </summary>
		public string s_AppCode
		{
			set{ _s_appcode=value;}
			get{return _s_appcode;}
		}
		/// <summary>
		/// 是否有总委托书号（Y：有 N：无，缺省为无）
		/// </summary>
		public string s_HasTrustDeed
		{
			set{ _s_hastrustdeed=value;}
			get{return _s_hastrustdeed;}
		}
		/// <summary>
		/// 总委托书号
		/// </summary>
		public string s_TrustDeedNo
		{
			set{ _s_trustdeedno=value;}
			get{return _s_trustdeedno;}
		}
		/// <summary>
		/// 总委托书保存路径（PA设置的路径下）
		/// </summary>
		public string s_TrustDeedPath
		{
			set{ _s_trustdeedpath=value;}
			get{return _s_trustdeedpath;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_Corporation
		{
			set{ _s_corporation=value;}
			get{return _s_corporation;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_Duty
		{
			set{ _s_duty=value;}
			get{return _s_duty;}
		}
		/// <summary>
		/// 备注信息
		/// </summary>
		public string s_Notes
		{
			set{ _s_notes=value;}
			get{return _s_notes;}
		}
		/// <summary>
		/// 座机
		/// </summary>
		public string s_Phone
		{
			set{ _s_phone=value;}
			get{return _s_phone;}
		}
		/// <summary>
		/// 手机
		/// </summary>
		public string s_Mobile
		{
			set{ _s_mobile=value;}
			get{return _s_mobile;}
		}
		/// <summary>
		/// 传真
		/// </summary>
		public string s_Fax
		{
			set{ _s_fax=value;}
			get{return _s_fax;}
		}
		/// <summary>
		/// 邮箱，email
		/// </summary>
		public string s_Email
		{
			set{ _s_email=value;}
			get{return _s_email;}
		}
		/// <summary>
		/// 网址
		/// </summary>
		public string s_Website
		{
			set{ _s_website=value;}
			get{return _s_website;}
		}
		/// <summary>
		/// 及时通信工具
		/// </summary>
		public string s_IMAddress
		{
			set{ _s_imaddress=value;}
			get{return _s_imaddress;}
		}
		/// <summary>
		/// facebook
		/// </summary>
		public string s_Facebook
		{
			set{ _s_facebook=value;}
			get{return _s_facebook;}
		}
		/// <summary>
		/// twitter
		/// </summary>
		public string s_Twitter
		{
			set{ _s_twitter=value;}
			get{return _s_twitter;}
		}
		/// <summary>
		/// 创建日期
		/// </summary>
		public DateTime? dt_CreateDate
		{
			set{ _dt_createdate=value;}
			get{return _dt_createdate;}
		}
		/// <summary>
		/// 最后编辑日期
		/// </summary>
		public DateTime? dt_EditDate
		{
			set{ _dt_editdate=value;}
			get{return _dt_editdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int ObjectType
		{
			set{ _objecttype=value;}
			get{return _objecttype;}
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
		public string s_Area
		{
			set{ _s_area=value;}
			get{return _s_area;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_PatentCaseCount
		{
			set{ _n_patentcasecount=value;}
			get{return _n_patentcasecount;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_TMCaseCount
		{
			set{ _n_tmcasecount=value;}
			get{return _n_tmcasecount;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_CopyrightCaseCount
		{
			set{ _n_copyrightcasecount=value;}
			get{return _n_copyrightcasecount;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_DomainCaseCount
		{
			set{ _n_domaincasecount=value;}
			get{return _n_domaincasecount;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_OtherCaseCount
		{
			set{ _n_othercasecount=value;}
			get{return _n_othercasecount;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_FirstAddress
		{
			set{ _s_firstaddress=value;}
			get{return _s_firstaddress;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? dt_FirstCaseFromDate
		{
			set{ _dt_firstcasefromdate=value;}
			get{return _dt_firstcasefromdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? dt_LastCaseFromDate
		{
			set{ _dt_lastcasefromdate=value;}
			get{return _dt_lastcasefromdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_Addresses
		{
			set{ _s_addresses=value;}
			get{return _s_addresses;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_ContactsFirstName
		{
			set{ _s_contactsfirstname=value;}
			get{return _s_contactsfirstname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_ContactsLastName
		{
			set{ _s_contactslastname=value;}
			get{return _s_contactslastname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_ContactsTel
		{
			set{ _s_contactstel=value;}
			get{return _s_contactstel;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_ContactsFax
		{
			set{ _s_contactsfax=value;}
			get{return _s_contactsfax;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_ContactsAddresses
		{
			set{ _s_contactsaddresses=value;}
			get{return _s_contactsaddresses;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_GovName
		{
			set{ _s_govname=value;}
			get{return _s_govname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_AccountName
		{
			set{ _s_accountname=value;}
			get{return _s_accountname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_BankName
		{
			set{ _s_bankname=value;}
			get{return _s_bankname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_AccountNo
		{
			set{ _s_accountno=value;}
			get{return _s_accountno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_AccountCode
		{
			set{ _s_accountcode=value;}
			get{return _s_accountcode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_TaxCode
		{
			set{ _s_taxcode=value;}
			get{return _s_taxcode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_RegAddress
		{
			set{ _s_regaddress=value;}
			get{return _s_regaddress;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_RegTel
		{
			set{ _s_regtel=value;}
			get{return _s_regtel;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_InvoiceTo
		{
			set{ _s_invoiceto=value;}
			get{return _s_invoiceto;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int n_SecurityLevelID
		{
			set{ _n_securitylevelid=value;}
			get{return _n_securitylevelid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_PayFeePerson
		{
			set{ _s_payfeeperson=value;}
			get{return _s_payfeeperson;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool b_ElecPayer
		{
			set{ _b_elecpayer=value;}
			get{return _b_elecpayer;}
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
		public string s_FeeMitigationYear
		{
			set{ _s_feemitigationyear=value;}
			get{return _s_feemitigationyear;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_FeeMitigationNum
		{
			set{ _s_feemitigationnum=value;}
			get{return _s_feemitigationnum;}
		}
		#endregion Model

	}
}


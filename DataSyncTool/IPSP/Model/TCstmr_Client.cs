/**  版本信息模板在安装目录下，可自行修改。
* TCstmr_Client.cs
*
* 功 能： N/A
* 类 名： TCstmr_Client
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:47:39   N/A    初版
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
	/// TCstmr_Client:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TCstmr_Client
	{
		public TCstmr_Client()
		{}
		#region Model
		private int _n_clientid;
		private string _s_name;
		private string _s_nativename;
		private string _s_othername;
		private string _s_clientcode;
		private string _s_iptype;
		private string _s_type;
		private string _s_credit;
		private int? _n_applicantid;
		private int? _n_coopagencyid;
		private int? _n_introid;
		private string _s_notes;
		private int? _n_language;
		private DateTime? _dt_firstcasedate;
		private DateTime? _dt_lastcasedate;
		private string _s_phone;
		private string _s_mobile;
		private string _s_fax;
		private string _s_email;
		private string _s_website;
		private string _s_imaddress;
		private string _s_facebook;
		private string _s_twitter;
		private string _s_paymode;
		private DateTime? _dt_createdate;
		private DateTime? _dt_editdate;
		private int _objecttype;
		private string _s_iprole;
		private DateTime? _dt_firstcasedate34;
		private string _s_isactive;
		private string _s_isalluser;
		private decimal? _n_clientdeposit;
		private int? _n_clientdepositcurrency;
		private string _s_source;
		private int? _n_country;
		private string _s_state;
		private string _s_city;
		private string _s_area;
		private int? _n_patentchargerid;
		private int? _n_tmchargerid;
		private string _s_lock;
		private string _s_locker;
		private decimal? _n_clientdeposittransfer;
		private string _s_creator;
		private string _s_editor;
		private string _s_depositeditor;
		private DateTime? _dt_depositeditdate;
		private int? _n_flownum;
		private string _s_addresses;
		private string _s_zipcodes;
		private string _s_contactslastname;
		private string _s_contactsfirstname;
		private string _s_contactstel;
		private string _s_contactsaddresses;
		private string _s_contactszipcode;
		private int? _n_firstcontactid;
		private int? _n_patentcasecount;
		private int? _n_tmcasecount;
		private int? _n_copyrightcasecount;
		private int? _n_domaincasecount;
		private int? _n_othercasecount;
		private string _s_accountname;
		private string _s_bankname;
		private string _s_accountno;
		private string _s_accountcode;
		private string _s_taxcode;
		private string _s_regaddress;
		private string _s_regtel;
		private string _s_invoiceto;
		private int _n_securitylevelid;
		private int? _n_ppreferentialcombineid;
		private int? _n_tpreferentialcombineid;
		private int? _n_cpreferentialcombineid;
		private int? _n_dpreferentialcombineid;
		private int? _n_opreferentialcombineid;
		private string _s_notclaimmoney;
		private string _s_firstclientaddress;
		private string _s_pricedesc;
		/// <summary>
		/// 自增ID
		/// </summary>
		public int n_ClientID
		{
			set{ _n_clientid=value;}
			get{return _n_clientid;}
		}
		/// <summary>
		/// 客户名称
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
		/// 客户代码
		/// </summary>
		public string s_ClientCode
		{
			set{ _s_clientcode=value;}
			get{return _s_clientcode;}
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
		/// 客户类别（可选可输入:潜在客户、普通客户等）
		/// </summary>
		public string s_Type
		{
			set{ _s_type=value;}
			get{return _s_type;}
		}
		/// <summary>
		/// 信用级别
		/// </summary>
		public string s_Credit
		{
			set{ _s_credit=value;}
			get{return _s_credit;}
		}
		/// <summary>
		/// 申请人ID
		/// </summary>
		public int? n_ApplicantID
		{
			set{ _n_applicantid=value;}
			get{return _n_applicantid;}
		}
		/// <summary>
		/// 合作代理机构ID
		/// </summary>
		public int? n_CoopAgencyID
		{
			set{ _n_coopagencyid=value;}
			get{return _n_coopagencyid;}
		}
		/// <summary>
		/// 客户的介绍人ID号
		/// </summary>
		public int? n_IntroID
		{
			set{ _n_introid=value;}
			get{return _n_introid;}
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
		/// 通信语种
		/// </summary>
		public int? n_Language
		{
			set{ _n_language=value;}
			get{return _n_language;}
		}
		/// <summary>
		/// 首次来案日期
		/// </summary>
		public DateTime? dt_FirstCaseDate
		{
			set{ _dt_firstcasedate=value;}
			get{return _dt_firstcasedate;}
		}
		/// <summary>
		/// 最近来案日期
		/// </summary>
		public DateTime? dt_LastCaseDate
		{
			set{ _dt_lastcasedate=value;}
			get{return _dt_lastcasedate;}
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
		/// 缴费方式与确认方式
		/// </summary>
		public string s_PayMode
		{
			set{ _s_paymode=value;}
			get{return _s_paymode;}
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
		public string s_IPRole
		{
			set{ _s_iprole=value;}
			get{return _s_iprole;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? dt_FirstCaseDate34
		{
			set{ _dt_firstcasedate34=value;}
			get{return _dt_firstcasedate34;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_IsActive
		{
			set{ _s_isactive=value;}
			get{return _s_isactive;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_IsAllUser
		{
			set{ _s_isalluser=value;}
			get{return _s_isalluser;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? n_ClientDeposit
		{
			set{ _n_clientdeposit=value;}
			get{return _n_clientdeposit;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_ClientDepositCurrency
		{
			set{ _n_clientdepositcurrency=value;}
			get{return _n_clientdepositcurrency;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_Source
		{
			set{ _s_source=value;}
			get{return _s_source;}
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
		public string s_Area
		{
			set{ _s_area=value;}
			get{return _s_area;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_PatentChargerID
		{
			set{ _n_patentchargerid=value;}
			get{return _n_patentchargerid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_TMChargerID
		{
			set{ _n_tmchargerid=value;}
			get{return _n_tmchargerid;}
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
		public decimal? n_ClientDepositTransfer
		{
			set{ _n_clientdeposittransfer=value;}
			get{return _n_clientdeposittransfer;}
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
		public string s_DepositEditor
		{
			set{ _s_depositeditor=value;}
			get{return _s_depositeditor;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? dt_DepositEditDate
		{
			set{ _dt_depositeditdate=value;}
			get{return _dt_depositeditdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_FlowNum
		{
			set{ _n_flownum=value;}
			get{return _n_flownum;}
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
		public string s_ZipCodes
		{
			set{ _s_zipcodes=value;}
			get{return _s_zipcodes;}
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
		public string s_ContactsFirstName
		{
			set{ _s_contactsfirstname=value;}
			get{return _s_contactsfirstname;}
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
		public string s_ContactsAddresses
		{
			set{ _s_contactsaddresses=value;}
			get{return _s_contactsaddresses;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_ContactsZipCode
		{
			set{ _s_contactszipcode=value;}
			get{return _s_contactszipcode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_FirstContactID
		{
			set{ _n_firstcontactid=value;}
			get{return _n_firstcontactid;}
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
		public int? n_PPreferentialCombineID
		{
			set{ _n_ppreferentialcombineid=value;}
			get{return _n_ppreferentialcombineid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_TPreferentialCombineID
		{
			set{ _n_tpreferentialcombineid=value;}
			get{return _n_tpreferentialcombineid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_CPreferentialCombineID
		{
			set{ _n_cpreferentialcombineid=value;}
			get{return _n_cpreferentialcombineid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_DPreferentialCombineID
		{
			set{ _n_dpreferentialcombineid=value;}
			get{return _n_dpreferentialcombineid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_OPreferentialCombineID
		{
			set{ _n_opreferentialcombineid=value;}
			get{return _n_opreferentialcombineid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_NotClaimMoney
		{
			set{ _s_notclaimmoney=value;}
			get{return _s_notclaimmoney;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_FirstClientAddress
		{
			set{ _s_firstclientaddress=value;}
			get{return _s_firstclientaddress;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_PriceDesc
		{
			set{ _s_pricedesc=value;}
			get{return _s_pricedesc;}
		}
		#endregion Model

	}
}


/**  版本信息模板在安装目录下，可自行修改。
* TCstmr_CoopAgency.cs
*
* 功 能： N/A
* 类 名： TCstmr_CoopAgency
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:47:54   N/A    初版
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
	/// TCstmr_CoopAgency:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TCstmr_CoopAgency
	{
		public TCstmr_CoopAgency()
		{}
		#region Model
		private int _n_agencyid;
		private string _s_name;
		private string _s_nativename;
		private string _s_othername;
		private int? _n_language;
		private string _s_iptype;
		private string _s_credit;
		private string _s_notes;
		private int _n_clientid;
		private int? _n_paycurrency;
		private DateTime? _dt_firstcasefromdate;
		private DateTime? _dt_lastcasefromdate;
		private DateTime? _dt_firstcasetodate;
		private DateTime? _dt_lastcasetodate;
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
		private int? _s_language;
		private int? _s_payunit;
		private string _s_iprole;
		private int? _n_payunit;
		private string _s_lock;
		private string _s_locker;
		private string _s_creator;
		private string _s_editor;
		private string _s_addresses;
		private string _s_contactsfirstname;
		private string _s_contactslastname;
		private string _s_contactstel;
		private string _s_contactsfax;
		private string _s_contactsemail;
		private string _s_firstaddress;
		private int? _n_oaddresscountry;
		private int? _n_topatentcasecount;
		private int? _n_totmcasecount;
		private int? _n_tocopyrightcasecount;
		private int? _n_todomaincasecount;
		private int? _n_toothercasecount;
		private int _n_securitylevelid;
		private string _s_code;
		private string _s_beneficiarybankname;
		private string _s_beneficiarybankaddress;
		private string _s_beneficiaryname;
		private string _s_beneficiaryaddress;
		private string _s_beneficiaryaccountnumber;
		private string _s_iban;
		private string _s_swiftcode;
		private string _s_aba;
		/// <summary>
		/// 自增ID
		/// </summary>
		public int n_AgencyID
		{
			set{ _n_agencyid=value;}
			get{return _n_agencyid;}
		}
		/// <summary>
		/// 代理机构名称
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
		/// 使用语言
		/// </summary>
		public int? n_Language
		{
			set{ _n_language=value;}
			get{return _n_language;}
		}
		/// <summary>
		/// 类别标志，可输入可选择
		/// </summary>
		public string s_IPType
		{
			set{ _s_iptype=value;}
			get{return _s_iptype;}
		}
		/// <summary>
		/// 信用等级
		/// </summary>
		public string s_Credit
		{
			set{ _s_credit=value;}
			get{return _s_credit;}
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
		/// 对应的客户ID
		/// </summary>
		public int n_ClientID
		{
			set{ _n_clientid=value;}
			get{return _n_clientid;}
		}
		/// <summary>
		/// 付费币种
		/// </summary>
		public int? n_PayCurrency
		{
			set{ _n_paycurrency=value;}
			get{return _n_paycurrency;}
		}
		/// <summary>
		/// 首次来案日期
		/// </summary>
		public DateTime? dt_FirstCaseFromDate
		{
			set{ _dt_firstcasefromdate=value;}
			get{return _dt_firstcasefromdate;}
		}
		/// <summary>
		/// 最近来案日期
		/// </summary>
		public DateTime? dt_LastCaseFromDate
		{
			set{ _dt_lastcasefromdate=value;}
			get{return _dt_lastcasefromdate;}
		}
		/// <summary>
		/// 首次去案日期
		/// </summary>
		public DateTime? dt_FirstCaseToDate
		{
			set{ _dt_firstcasetodate=value;}
			get{return _dt_firstcasetodate;}
		}
		/// <summary>
		/// 最近去案日期
		/// </summary>
		public DateTime? dt_LastCaseToDate
		{
			set{ _dt_lastcasetodate=value;}
			get{return _dt_lastcasetodate;}
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
		public string s_WebSite
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
		public int? s_Language
		{
			set{ _s_language=value;}
			get{return _s_language;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? s_PayUnit
		{
			set{ _s_payunit=value;}
			get{return _s_payunit;}
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
		public int? n_PayUnit
		{
			set{ _n_payunit=value;}
			get{return _n_payunit;}
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
		public string s_ContactsEmail
		{
			set{ _s_contactsemail=value;}
			get{return _s_contactsemail;}
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
		public int? n_OAddressCountry
		{
			set{ _n_oaddresscountry=value;}
			get{return _n_oaddresscountry;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_ToPatentCaseCount
		{
			set{ _n_topatentcasecount=value;}
			get{return _n_topatentcasecount;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_ToTMCaseCount
		{
			set{ _n_totmcasecount=value;}
			get{return _n_totmcasecount;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_ToCopyrightCaseCount
		{
			set{ _n_tocopyrightcasecount=value;}
			get{return _n_tocopyrightcasecount;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_ToDomainCaseCount
		{
			set{ _n_todomaincasecount=value;}
			get{return _n_todomaincasecount;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_ToOtherCaseCount
		{
			set{ _n_toothercasecount=value;}
			get{return _n_toothercasecount;}
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
		public string s_Code
		{
			set{ _s_code=value;}
			get{return _s_code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_BeneficiaryBankName
		{
			set{ _s_beneficiarybankname=value;}
			get{return _s_beneficiarybankname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_BeneficiaryBankAddress
		{
			set{ _s_beneficiarybankaddress=value;}
			get{return _s_beneficiarybankaddress;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_BeneficiaryName
		{
			set{ _s_beneficiaryname=value;}
			get{return _s_beneficiaryname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_BeneficiaryAddress
		{
			set{ _s_beneficiaryaddress=value;}
			get{return _s_beneficiaryaddress;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_BeneficiaryAccountNumber
		{
			set{ _s_beneficiaryaccountnumber=value;}
			get{return _s_beneficiaryaccountnumber;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_IBAN
		{
			set{ _s_iban=value;}
			get{return _s_iban;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_SwiftCode
		{
			set{ _s_swiftcode=value;}
			get{return _s_swiftcode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_ABA
		{
			set{ _s_aba=value;}
			get{return _s_aba;}
		}
		#endregion Model

	}
}


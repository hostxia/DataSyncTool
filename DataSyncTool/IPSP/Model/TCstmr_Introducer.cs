/**  版本信息模板在安装目录下，可自行修改。
* TCstmr_Introducer.cs
*
* 功 能： N/A
* 类 名： TCstmr_Introducer
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:48:02   N/A    初版
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
	/// TCstmr_Introducer:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TCstmr_Introducer
	{
		public TCstmr_Introducer()
		{}
		#region Model
		private int _n_id;
		private string _s_lastname;
		private string _s_firstname;
		private string _s_initial;
		private string _s_prefix;
		private string _s_nativename;
		private string _s_introcode;
		private string _s_type;
		private string _s_jobtitle;
		private string _s_phone;
		private string _s_mobile;
		private string _s_fax;
		private string _s_email;
		private string _s_website;
		private string _s_imaddress;
		private string _s_facebook;
		private string _s_twitter;
		private string _s_notes;
		private DateTime? _dt_firstcasedate;
		private DateTime? _dt_lastcasedate;
		private DateTime? _dt_createdate;
		private DateTime? _dt_editdate;
		private string _s_iptype;
		private string _s_lock;
		private string _s_locker;
		private string _s_creator;
		private string _s_editor;
		private string _n_percent;
		private int? _n_patentcasecount;
		private int? _n_tmcasecount;
		private int? _n_copyrightcasecount;
		private int? _n_domaincasecount;
		private int? _n_othercasecount;
		private string _s_firstaddress;
		private string _s_addresses;
		private string _s_accountname;
		private string _s_bankname;
		private string _s_accountno;
		private string _s_accountcode;
		private string _s_taxcode;
		private string _s_regaddress;
		private string _s_regtel;
		private string _s_invoiceto;
		private int _n_securitylevelid;
		/// <summary>
		/// 自增ID
		/// </summary>
		public int n_ID
		{
			set{ _n_id=value;}
			get{return _n_id;}
		}
		/// <summary>
		/// 案源人姓
		/// </summary>
		public string s_LastName
		{
			set{ _s_lastname=value;}
			get{return _s_lastname;}
		}
		/// <summary>
		/// 案源人名
		/// </summary>
		public string s_FirstName
		{
			set{ _s_firstname=value;}
			get{return _s_firstname;}
		}
		/// <summary>
		/// 姓名简写
		/// </summary>
		public string s_Initial
		{
			set{ _s_initial=value;}
			get{return _s_initial;}
		}
		/// <summary>
		/// 称谓（先生，小姐；可选可输入）
		/// </summary>
		public string s_Prefix
		{
			set{ _s_prefix=value;}
			get{return _s_prefix;}
		}
		/// <summary>
		/// 案源人本国名称
		/// </summary>
		public string s_NativeName
		{
			set{ _s_nativename=value;}
			get{return _s_nativename;}
		}
		/// <summary>
		/// 案源人代码
		/// </summary>
		public string s_IntroCode
		{
			set{ _s_introcode=value;}
			get{return _s_introcode;}
		}
		/// <summary>
		/// 案源人类别标志（可输入可选择，用户定义的）
		/// </summary>
		public string s_Type
		{
			set{ _s_type=value;}
			get{return _s_type;}
		}
		/// <summary>
		/// 工作职位
		/// </summary>
		public string s_JobTitle
		{
			set{ _s_jobtitle=value;}
			get{return _s_jobtitle;}
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
		/// 备注
		/// </summary>
		public string s_Notes
		{
			set{ _s_notes=value;}
			get{return _s_notes;}
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
		public string s_IPType
		{
			set{ _s_iptype=value;}
			get{return _s_iptype;}
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
		public string n_Percent
		{
			set{ _n_percent=value;}
			get{return _n_percent;}
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
		public string s_Addresses
		{
			set{ _s_addresses=value;}
			get{return _s_addresses;}
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
		#endregion Model

	}
}


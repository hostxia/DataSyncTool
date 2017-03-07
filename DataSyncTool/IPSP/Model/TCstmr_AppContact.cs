/**  版本信息模板在安装目录下，可自行修改。
* TCstmr_AppContact.cs
*
* 功 能： N/A
* 类 名： TCstmr_AppContact
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:47:33   N/A    初版
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
	/// TCstmr_AppContact:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TCstmr_AppContact
	{
		public TCstmr_AppContact()
		{}
		#region Model
		private int _n_contactid;
		private int _n_appid;
		private string _s_firstname;
		private string _s_lastname;
		private string _s_nativename;
		private string _s_othername;
		private string _s_iptype;
		private int? _n_language;
		private string _s_jobtitle;
		private string _s_prefix;
		private string _s_phone;
		private string _s_mobile;
		private string _s_fax;
		private string _s_email;
		private string _s_website;
		private string _s_imaddress;
		private string _s_facebook;
		private string _s_twitter;
		private string _s_prefercontact;
		private string _s_notes;
		private int? _n_sequence;
		private DateTime? _dt_createdate;
		private DateTime? _dt_editdate;
		private string _s_identity;
		private string _s_department;
		/// <summary>
		/// 自增ID
		/// </summary>
		public int n_ContactID
		{
			set{ _n_contactid=value;}
			get{return _n_contactid;}
		}
		/// <summary>
		/// 申请人ID号
		/// </summary>
		public int n_AppID
		{
			set{ _n_appid=value;}
			get{return _n_appid;}
		}
		/// <summary>
		/// 名
		/// </summary>
		public string s_FirstName
		{
			set{ _s_firstname=value;}
			get{return _s_firstname;}
		}
		/// <summary>
		/// 姓
		/// </summary>
		public string s_LastName
		{
			set{ _s_lastname=value;}
			get{return _s_lastname;}
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
		/// 联系人角色（专、商等；可多选）
		/// </summary>
		public string s_IPType
		{
			set{ _s_iptype=value;}
			get{return _s_iptype;}
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
		/// 工作职位
		/// </summary>
		public string s_JobTitle
		{
			set{ _s_jobtitle=value;}
			get{return _s_jobtitle;}
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
		/// 首选联系方式
		/// </summary>
		public string s_PreferContact
		{
			set{ _s_prefercontact=value;}
			get{return _s_prefercontact;}
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
		/// 
		/// </summary>
		public int? n_Sequence
		{
			set{ _n_sequence=value;}
			get{return _n_sequence;}
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
		public string s_Identity
		{
			set{ _s_identity=value;}
			get{return _s_identity;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_Department
		{
			set{ _s_department=value;}
			get{return _s_department;}
		}
		#endregion Model

	}
}


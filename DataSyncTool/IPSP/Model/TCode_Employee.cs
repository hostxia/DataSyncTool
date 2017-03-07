/**  版本信息模板在安装目录下，可自行修改。
* TCode_Employee.cs
*
* 功 能： N/A
* 类 名： TCode_Employee
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:46:21   N/A    初版
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
	/// TCode_Employee:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TCode_Employee
	{
		public TCode_Employee()
		{}
		#region Model
		private int _n_id;
		private string _s_role;
		private string _s_iptype;
		private string _s_name;
		private string _s_othername;
		private string _s_internalcode;
		private string _s_certificateno;
		private string _s_phone;
		private string _s_mobile;
		private string _s_fax;
		private string _s_email;
		private string _s_imaddress;
		private string _s_facebook;
		private string _s_twitter;
		private string _s_notes;
		private decimal? _n_chargerate1;
		private int? _n_currency1;
		private decimal? _n_chargerate2;
		private int? _n_currency2;
		private DateTime? _dt_createdate;
		private DateTime? _dt_editdate;
		private string _s_username;
		private string _s_password;
		private string _s_emailname;
		private string _s_emailserver;
		private string _s_port;
		private string _s_emailuser;
		private string _s_emailpwd;
		private byte[] _s_signature;
		private decimal? _n_attorneyper;
		private string _s_dataright;
		private string _s_allowviewdepartdata;
		private string _s_cancc;
		private string _s_cc;
		private string _s_allowcaseconsolemydata;
		private string _s_allowcaseconsoledepartmentdata;
		private string _s_allowcaseconsolealldata;
		private bool _n_valid;
		private string _s_contact;
		private DateTime? _dt_modifypassword;
		private DateTime? _dt_lock;
		private int _n_securitylevelid;
		private byte[] _img_mainorigimg;
		private byte[] _img_mainthumbnail;
		private string _s_defaultiptype;
		private string _s_allowcustomemail;
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
		public string s_Role
		{
			set{ _s_role=value;}
			get{return _s_role;}
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
		public string s_InternalCode
		{
			set{ _s_internalcode=value;}
			get{return _s_internalcode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_CertificateNo
		{
			set{ _s_certificateno=value;}
			get{return _s_certificateno;}
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
		public string s_IMAddress
		{
			set{ _s_imaddress=value;}
			get{return _s_imaddress;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_Facebook
		{
			set{ _s_facebook=value;}
			get{return _s_facebook;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_Twitter
		{
			set{ _s_twitter=value;}
			get{return _s_twitter;}
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
		public decimal? n_ChargeRate1
		{
			set{ _n_chargerate1=value;}
			get{return _n_chargerate1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_Currency1
		{
			set{ _n_currency1=value;}
			get{return _n_currency1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? n_ChargeRate2
		{
			set{ _n_chargerate2=value;}
			get{return _n_chargerate2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_Currency2
		{
			set{ _n_currency2=value;}
			get{return _n_currency2;}
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
		public string s_UserName
		{
			set{ _s_username=value;}
			get{return _s_username;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_Password
		{
			set{ _s_password=value;}
			get{return _s_password;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_EmailName
		{
			set{ _s_emailname=value;}
			get{return _s_emailname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_EmailServer
		{
			set{ _s_emailserver=value;}
			get{return _s_emailserver;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_Port
		{
			set{ _s_port=value;}
			get{return _s_port;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_EmailUser
		{
			set{ _s_emailuser=value;}
			get{return _s_emailuser;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_EmailPwd
		{
			set{ _s_emailpwd=value;}
			get{return _s_emailpwd;}
		}
		/// <summary>
		/// 
		/// </summary>
		public byte[] s_Signature
		{
			set{ _s_signature=value;}
			get{return _s_signature;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? n_AttorneyPer
		{
			set{ _n_attorneyper=value;}
			get{return _n_attorneyper;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_DataRight
		{
			set{ _s_dataright=value;}
			get{return _s_dataright;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_AllowViewDepartData
		{
			set{ _s_allowviewdepartdata=value;}
			get{return _s_allowviewdepartdata;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_CanCC
		{
			set{ _s_cancc=value;}
			get{return _s_cancc;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_CC
		{
			set{ _s_cc=value;}
			get{return _s_cc;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_AllowCaseConsoleMyData
		{
			set{ _s_allowcaseconsolemydata=value;}
			get{return _s_allowcaseconsolemydata;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_AllowCaseConsoleDepartmentData
		{
			set{ _s_allowcaseconsoledepartmentdata=value;}
			get{return _s_allowcaseconsoledepartmentdata;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_AllowCaseConsoleAllData
		{
			set{ _s_allowcaseconsolealldata=value;}
			get{return _s_allowcaseconsolealldata;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool n_Valid
		{
			set{ _n_valid=value;}
			get{return _n_valid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_Contact
		{
			set{ _s_contact=value;}
			get{return _s_contact;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? dt_ModifyPassword
		{
			set{ _dt_modifypassword=value;}
			get{return _dt_modifypassword;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? dt_Lock
		{
			set{ _dt_lock=value;}
			get{return _dt_lock;}
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
		public byte[] img_MainOrigImg
		{
			set{ _img_mainorigimg=value;}
			get{return _img_mainorigimg;}
		}
		/// <summary>
		/// 
		/// </summary>
		public byte[] img_MainThumbnail
		{
			set{ _img_mainthumbnail=value;}
			get{return _img_mainthumbnail;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_DefaultIPType
		{
			set{ _s_defaultiptype=value;}
			get{return _s_defaultiptype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_AllowCustomEmail
		{
			set{ _s_allowcustomemail=value;}
			get{return _s_allowcustomemail;}
		}
		#endregion Model

	}
}


/**  版本信息模板在安装目录下，可自行修改。
* TCode_AgencyInfo.cs
*
* 功 能： N/A
* 类 名： TCode_AgencyInfo
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:45:44   N/A    初版
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
	/// TCode_AgencyInfo:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TCode_AgencyInfo
	{
		public TCode_AgencyInfo()
		{}
		#region Model
		private int _n_id;
		private string _s_name;
		private string _s_othername;
		private string _s_contact;
		private string _s_othercontact;
		private string _s_password;
		private string _s_agentcode;
		private string _s_tel;
		private string _s_fax;
		private int? _n_country;
		private string _s_state;
		private string _s_city;
		private string _s_street;
		private string _s_zipcode;
		private string _s_otheraddress;
		private string _s_notes;
		private string _s_emailname;
		private string _s_emailserver;
		private string _s_port;
		private string _s_emailuser;
		private string _s_emailpwd;
		private byte[] _s_signature;
		private DateTime? _dt_createdate;
		private DateTime? _dt_editdate;
		private int? _n_defaultcurr;
		private int? _n_defaultlan;
		private decimal? _n_gstagent;
		private decimal? _n_gstdisb;
		private string _s_gstfornativeclient;
		private string _s_tmothername;
		private string _s_clientcoderule;
		private int? _n_clientcodeflownumcount;
		private decimal? _n_taxcn;
		private string _s_nationaldefense;
		private string _s_unifiedsend;
		private string _s_weekendforecolor;
		private string _s_weekendbackcolor;
		private string _s_workweekendforecolor;
		private string _s_workweekendbackcolor;
		private string _s_corpid;
		private string _s_secret;
		private string _s_customizecode;
		private string _s_useholidayconfig;
		private string _s_useoldconsole;
		private byte[] _img_logo;
		private int? _n_annualfeenotificationday;
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
		public string s_Contact
		{
			set{ _s_contact=value;}
			get{return _s_contact;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_OtherContact
		{
			set{ _s_othercontact=value;}
			get{return _s_othercontact;}
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
		public string s_AgentCode
		{
			set{ _s_agentcode=value;}
			get{return _s_agentcode;}
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
		public string s_OtherAddress
		{
			set{ _s_otheraddress=value;}
			get{return _s_otheraddress;}
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
		public int? n_DefaultCurr
		{
			set{ _n_defaultcurr=value;}
			get{return _n_defaultcurr;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_DefaultLan
		{
			set{ _n_defaultlan=value;}
			get{return _n_defaultlan;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? n_GSTAgent
		{
			set{ _n_gstagent=value;}
			get{return _n_gstagent;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? n_GSTDisb
		{
			set{ _n_gstdisb=value;}
			get{return _n_gstdisb;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_GSTForNativeClient
		{
			set{ _s_gstfornativeclient=value;}
			get{return _s_gstfornativeclient;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_TmOtherName
		{
			set{ _s_tmothername=value;}
			get{return _s_tmothername;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_ClientCodeRule
		{
			set{ _s_clientcoderule=value;}
			get{return _s_clientcoderule;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_ClientCodeFlowNumCount
		{
			set{ _n_clientcodeflownumcount=value;}
			get{return _n_clientcodeflownumcount;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? n_TaxCN
		{
			set{ _n_taxcn=value;}
			get{return _n_taxcn;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_NationalDefense
		{
			set{ _s_nationaldefense=value;}
			get{return _s_nationaldefense;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_UnifiedSend
		{
			set{ _s_unifiedsend=value;}
			get{return _s_unifiedsend;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_WeekEndForeColor
		{
			set{ _s_weekendforecolor=value;}
			get{return _s_weekendforecolor;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_WeekEndBackColor
		{
			set{ _s_weekendbackcolor=value;}
			get{return _s_weekendbackcolor;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_WorkWeekEndForeColor
		{
			set{ _s_workweekendforecolor=value;}
			get{return _s_workweekendforecolor;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_WorkWeekEndBackColor
		{
			set{ _s_workweekendbackcolor=value;}
			get{return _s_workweekendbackcolor;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_CorpID
		{
			set{ _s_corpid=value;}
			get{return _s_corpid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_Secret
		{
			set{ _s_secret=value;}
			get{return _s_secret;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_CustomizeCode
		{
			set{ _s_customizecode=value;}
			get{return _s_customizecode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_UseHolidayConfig
		{
			set{ _s_useholidayconfig=value;}
			get{return _s_useholidayconfig;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_UseOldConsole
		{
			set{ _s_useoldconsole=value;}
			get{return _s_useoldconsole;}
		}
		/// <summary>
		/// 
		/// </summary>
		public byte[] img_Logo
		{
			set{ _img_logo=value;}
			get{return _img_logo;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_AnnualFeeNotificationDay
		{
			set{ _n_annualfeenotificationday=value;}
			get{return _n_annualfeenotificationday;}
		}
		#endregion Model

	}
}


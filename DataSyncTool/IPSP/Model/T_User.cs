/**  版本信息模板在安装目录下，可自行修改。
* T_User.cs
*
* 功 能： N/A
* 类 名： T_User
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:45:15   N/A    初版
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
	/// T_User:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class T_User
	{
		public T_User()
		{}
		#region Model
		private decimal _n_userid;
		private string _s_cname;
		private string _s_ename;
		private string _s_usercode;
		private string _s_telephone;
		private string _s_email;
		private string _s_isattorney;
		private string _s_mailserver;
		private string _s_mailserverport;
		private string _s_needauth;
		private string _s_mailaccount;
		private string _s_mailpassword;
		private string _s_valid;
		private string _s_loginname;
		private string _s_loginpassword;
		private DateTime _dt_editdate;
		private string _s_editor;
		private string _s_notes;
		private string _s_login;
		private string _s_lifespan;
		private decimal? _n_deptid;
		private string _s_ip;
		private decimal? _n_inventorid;
		private decimal? _n_agentloginid;
		private string _s_ifneedip;
		private string _s_loginip;
		/// <summary>
		/// 
		/// </summary>
		public decimal n_UserID
		{
			set{ _n_userid=value;}
			get{return _n_userid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_CName
		{
			set{ _s_cname=value;}
			get{return _s_cname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_EName
		{
			set{ _s_ename=value;}
			get{return _s_ename;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_UserCode
		{
			set{ _s_usercode=value;}
			get{return _s_usercode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_Telephone
		{
			set{ _s_telephone=value;}
			get{return _s_telephone;}
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
		public string s_IsAttorney
		{
			set{ _s_isattorney=value;}
			get{return _s_isattorney;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_MailServer
		{
			set{ _s_mailserver=value;}
			get{return _s_mailserver;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_MailServerPort
		{
			set{ _s_mailserverport=value;}
			get{return _s_mailserverport;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_NeedAuth
		{
			set{ _s_needauth=value;}
			get{return _s_needauth;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_MailAccount
		{
			set{ _s_mailaccount=value;}
			get{return _s_mailaccount;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_MailPassword
		{
			set{ _s_mailpassword=value;}
			get{return _s_mailpassword;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_Valid
		{
			set{ _s_valid=value;}
			get{return _s_valid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_LoginName
		{
			set{ _s_loginname=value;}
			get{return _s_loginname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_LoginPassword
		{
			set{ _s_loginpassword=value;}
			get{return _s_loginpassword;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime dt_EditDate
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
		public string s_Notes
		{
			set{ _s_notes=value;}
			get{return _s_notes;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_Login
		{
			set{ _s_login=value;}
			get{return _s_login;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_LifeSpan
		{
			set{ _s_lifespan=value;}
			get{return _s_lifespan;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? n_DeptID
		{
			set{ _n_deptid=value;}
			get{return _n_deptid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_IP
		{
			set{ _s_ip=value;}
			get{return _s_ip;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? n_InventorID
		{
			set{ _n_inventorid=value;}
			get{return _n_inventorid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? n_AgentLoginId
		{
			set{ _n_agentloginid=value;}
			get{return _n_agentloginid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_IfNeedIP
		{
			set{ _s_ifneedip=value;}
			get{return _s_ifneedip;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_LoginIP
		{
			set{ _s_loginip=value;}
			get{return _s_loginip;}
		}
		#endregion Model

	}
}


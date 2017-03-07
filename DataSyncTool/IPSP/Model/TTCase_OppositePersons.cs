/**  版本信息模板在安装目录下，可自行修改。
* TTCase_OppositePersons.cs
*
* 功 能： N/A
* 类 名： TTCase_OppositePersons
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:50:47   N/A    初版
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
	/// TTCase_OppositePersons:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TTCase_OppositePersons
	{
		public TTCase_OppositePersons()
		{}
		#region Model
		private int _n_id;
		private int _n_caseid;
		private string _s_role;
		private string _s_name;
		private string _s_othername;
		private string _s_addr;
		private string _s_otheraddr;
		private string _s_zipcode;
		private string _s_tel;
		private string _s_fax;
		private string _s_email;
		private string _s_lawdeputy;
		private string _s_contact;
		private string _s_isdelegacy;
		private int? _n_regcountry;
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
		public string s_Role
		{
			set{ _s_role=value;}
			get{return _s_role;}
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
		public string s_Addr
		{
			set{ _s_addr=value;}
			get{return _s_addr;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_OtherAddr
		{
			set{ _s_otheraddr=value;}
			get{return _s_otheraddr;}
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
		public string s_Email
		{
			set{ _s_email=value;}
			get{return _s_email;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_LawDeputy
		{
			set{ _s_lawdeputy=value;}
			get{return _s_lawdeputy;}
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
		public string s_IsDelegacy
		{
			set{ _s_isdelegacy=value;}
			get{return _s_isdelegacy;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_RegCountry
		{
			set{ _n_regcountry=value;}
			get{return _n_regcountry;}
		}
		#endregion Model

	}
}


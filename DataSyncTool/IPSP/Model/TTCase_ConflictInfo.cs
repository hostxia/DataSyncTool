/**  版本信息模板在安装目录下，可自行修改。
* TTCase_ConflictInfo.cs
*
* 功 能： N/A
* 类 名： TTCase_ConflictInfo
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:50:21   N/A    初版
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
	/// TTCase_ConflictInfo:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TTCase_ConflictInfo
	{
		public TTCase_ConflictInfo()
		{}
		#region Model
		private int _n_caseid;
		private string _s_name;
		private string _s_othername;
		private string _s_address;
		private string _s_otheraddress;
		private string _s_zipcode;
		private string _s_contact;
		private string _s_tel;
		private string _s_fax;
		private string _s_agent;
		private string _s_reason;
		private string _s_officeserial;
		private string _s_otherclass;
		private string _s_needproof;
		private string _s_citedtmname;
		private string _s_citedtmclass;
		private string _s_citedtmregno;
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
		public string s_Address
		{
			set{ _s_address=value;}
			get{return _s_address;}
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
		public string s_ZipCode
		{
			set{ _s_zipcode=value;}
			get{return _s_zipcode;}
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
		public string s_Agent
		{
			set{ _s_agent=value;}
			get{return _s_agent;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_Reason
		{
			set{ _s_reason=value;}
			get{return _s_reason;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_OfficeSerial
		{
			set{ _s_officeserial=value;}
			get{return _s_officeserial;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_OtherClass
		{
			set{ _s_otherclass=value;}
			get{return _s_otherclass;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_NeedProof
		{
			set{ _s_needproof=value;}
			get{return _s_needproof;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_CitedTMName
		{
			set{ _s_citedtmname=value;}
			get{return _s_citedtmname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_CitedTMClass
		{
			set{ _s_citedtmclass=value;}
			get{return _s_citedtmclass;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_CitedTMRegNO
		{
			set{ _s_citedtmregno=value;}
			get{return _s_citedtmregno;}
		}
		#endregion Model

	}
}


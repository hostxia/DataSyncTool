/**  版本信息模板在安装目录下，可自行修改。
* TCstmr_AgencyConAddress.cs
*
* 功 能： N/A
* 类 名： TCstmr_AgencyConAddress
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:47:24   N/A    初版
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
	/// TCstmr_AgencyConAddress:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TCstmr_AgencyConAddress
	{
		public TCstmr_AgencyConAddress()
		{}
		#region Model
		private int _n_id;
		private int _n_contactid;
		private int? _n_country;
		private string _s_state;
		private string _s_city;
		private string _s_street;
		private string _s_zipcode;
		private string _s_type;
		private string _s_country;
		private string _s_ismailingaddress;
		/// <summary>
		/// 
		/// </summary>
		public int n_ID
		{
			set{ _n_id=value;}
			get{return _n_id;}
		}
		/// <summary>
		/// 合作代理机构的联系人ID
		/// </summary>
		public int n_ContactID
		{
			set{ _n_contactid=value;}
			get{return _n_contactid;}
		}
		/// <summary>
		/// 国家，从国家配置表中取
		/// </summary>
		public int? n_Country
		{
			set{ _n_country=value;}
			get{return _n_country;}
		}
		/// <summary>
		/// 省洲郡
		/// </summary>
		public string s_State
		{
			set{ _s_state=value;}
			get{return _s_state;}
		}
		/// <summary>
		/// 市县
		/// </summary>
		public string s_City
		{
			set{ _s_city=value;}
			get{return _s_city;}
		}
		/// <summary>
		/// 通信地址
		/// </summary>
		public string s_Street
		{
			set{ _s_street=value;}
			get{return _s_street;}
		}
		/// <summary>
		/// 邮政编码
		/// </summary>
		public string s_ZipCode
		{
			set{ _s_zipcode=value;}
			get{return _s_zipcode;}
		}
		/// <summary>
		/// 类别。B：business address; R: residential address; O: other address
		/// </summary>
		public string s_Type
		{
			set{ _s_type=value;}
			get{return _s_type;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_Country
		{
			set{ _s_country=value;}
			get{return _s_country;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_IsMailingAddress
		{
			set{ _s_ismailingaddress=value;}
			get{return _s_ismailingaddress;}
		}
		#endregion Model

	}
}


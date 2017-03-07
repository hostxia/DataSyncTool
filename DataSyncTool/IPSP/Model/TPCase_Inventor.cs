/**  版本信息模板在安装目录下，可自行修改。
* TPCase_Inventor.cs
*
* 功 能： N/A
* 类 名： TPCase_Inventor
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:49:23   N/A    初版
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
	/// TPCase_Inventor:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TPCase_Inventor
	{
		public TPCase_Inventor()
		{}
		#region Model
		private int _n_id;
		private int _n_caseid;
		private int _n_sequence;
		private string _s_name;
		private string _s_nativename;
		private int? _n_country;
		private string _s_address;
		private string _s_nativeaddress;
		private string _s_idcard;
		private int _patent;
		private string _s_secretname;
		private string _s_othername;
		private string _s_otheraddr;
		private string _s_notes;
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
		public int n_Sequence
		{
			set{ _n_sequence=value;}
			get{return _n_sequence;}
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
		public string s_NativeName
		{
			set{ _s_nativename=value;}
			get{return _s_nativename;}
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
		public string s_Address
		{
			set{ _s_address=value;}
			get{return _s_address;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_NativeAddress
		{
			set{ _s_nativeaddress=value;}
			get{return _s_nativeaddress;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_IDCard
		{
			set{ _s_idcard=value;}
			get{return _s_idcard;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int Patent
		{
			set{ _patent=value;}
			get{return _patent;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_SecretName
		{
			set{ _s_secretname=value;}
			get{return _s_secretname;}
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
		public string s_OtherAddr
		{
			set{ _s_otheraddr=value;}
			get{return _s_otheraddr;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_Notes
		{
			set{ _s_notes=value;}
			get{return _s_notes;}
		}
		#endregion Model

	}
}


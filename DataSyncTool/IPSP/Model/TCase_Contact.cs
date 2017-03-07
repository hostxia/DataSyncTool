/**  版本信息模板在安装目录下，可自行修改。
* TCase_Contact.cs
*
* 功 能： N/A
* 类 名： TCase_Contact
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:45:32   N/A    初版
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
	/// TCase_Contact:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TCase_Contact
	{
		public TCase_Contact()
		{}
		#region Model
		private int _n_id;
		private int _n_caseid;
		private string _s_contacttype;
		private int? _n_contactid;
		private int? _n_sequence;
		private string _s_identity;
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
		public string s_ContactType
		{
			set{ _s_contacttype=value;}
			get{return _s_contacttype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_ContactID
		{
			set{ _n_contactid=value;}
			get{return _n_contactid;}
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
		/// 
		/// </summary>
		public string s_Identity
		{
			set{ _s_identity=value;}
			get{return _s_identity;}
		}
		#endregion Model

	}
}


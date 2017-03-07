/**  版本信息模板在安装目录下，可自行修改。
* TCode_UserSelectEmail.cs
*
* 功 能： N/A
* 类 名： TCode_UserSelectEmail
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:47:20   N/A    初版
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
	/// TCode_UserSelectEmail:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TCode_UserSelectEmail
	{
		public TCode_UserSelectEmail()
		{}
		#region Model
		private int _n_id;
		private string _s_email;
		private string _s_name;
		private int? _n_currentemployeeid;
		private int _n_codeemployeelid;
		private string _s_default;
		private int? _n_emailid;
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
		public string s_Email
		{
			set{ _s_email=value;}
			get{return _s_email;}
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
		public int? n_CurrentEmployeeID
		{
			set{ _n_currentemployeeid=value;}
			get{return _n_currentemployeeid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int n_CodeEmployeelID
		{
			set{ _n_codeemployeelid=value;}
			get{return _n_codeemployeelid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_Default
		{
			set{ _s_default=value;}
			get{return _s_default;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_EmailId
		{
			set{ _n_emailid=value;}
			get{return _n_emailid;}
		}
		#endregion Model

	}
}


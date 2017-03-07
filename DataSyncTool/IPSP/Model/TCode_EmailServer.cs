/**  版本信息模板在安装目录下，可自行修改。
* TCode_EmailServer.cs
*
* 功 能： N/A
* 类 名： TCode_EmailServer
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:46:18   N/A    初版
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
	/// TCode_EmailServer:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TCode_EmailServer
	{
		public TCode_EmailServer()
		{}
		#region Model
		private int _n_id;
		private string _s_server;
		private string _s_email;
		private int? _n_port;
		private string _s_username;
		private string _s_password;
		private string _s_default;
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
		public string s_Server
		{
			set{ _s_server=value;}
			get{return _s_server;}
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
		public int? n_Port
		{
			set{ _n_port=value;}
			get{return _n_port;}
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
		public string s_Default
		{
			set{ _s_default=value;}
			get{return _s_default;}
		}
		#endregion Model

	}
}


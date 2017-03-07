/**  版本信息模板在安装目录下，可自行修改。
* T_UserOnline.cs
*
* 功 能： N/A
* 类 名： T_UserOnline
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:45:18   N/A    初版
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
	/// T_UserOnline:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class T_UserOnline
	{
		public T_UserOnline()
		{}
		#region Model
		private decimal _n_id;
		private string _s_loginname;
		private string _s_pcname;
		private string _s_ip;
		private DateTime _dt_logintime;
		private string _s_softwarename;
		/// <summary>
		/// 
		/// </summary>
		public decimal n_ID
		{
			set{ _n_id=value;}
			get{return _n_id;}
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
		public string s_PCName
		{
			set{ _s_pcname=value;}
			get{return _s_pcname;}
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
		public DateTime dt_LoginTime
		{
			set{ _dt_logintime=value;}
			get{return _dt_logintime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_SoftwareName
		{
			set{ _s_softwarename=value;}
			get{return _s_softwarename;}
		}
		#endregion Model

	}
}


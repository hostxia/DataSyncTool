/**  版本信息模板在安装目录下，可自行修改。
* T_Log.cs
*
* 功 能： N/A
* 类 名： T_Log
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:44:54   N/A    初版
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
	/// T_Log:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class T_Log
	{
		public T_Log()
		{}
		#region Model
		private int _n_id;
		private string _s_module;
		private string _s_operator;
		private DateTime? _dt_date;
		private string _s_content;
		private string _s_type;
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
		public string s_Module
		{
			set{ _s_module=value;}
			get{return _s_module;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_Operator
		{
			set{ _s_operator=value;}
			get{return _s_operator;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? dt_Date
		{
			set{ _dt_date=value;}
			get{return _dt_date;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_Content
		{
			set{ _s_content=value;}
			get{return _s_content;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_Type
		{
			set{ _s_type=value;}
			get{return _s_type;}
		}
		#endregion Model

	}
}


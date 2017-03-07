/**  版本信息模板在安装目录下，可自行修改。
* T_SendRemind.cs
*
* 功 能： N/A
* 类 名： T_SendRemind
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:45:03   N/A    初版
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
	/// T_SendRemind:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class T_SendRemind
	{
		public T_SendRemind()
		{}
		#region Model
		private int _n_id;
		private int _n_employeeid;
		private string _s_remindtype;
		private int? _n_elementid;
		private string _s_sendtype;
		private bool _b_sendfail;
		private Guid _s_guid;
		private string _s_remainingdays;
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
		public int n_EmployeeID
		{
			set{ _n_employeeid=value;}
			get{return _n_employeeid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_RemindType
		{
			set{ _s_remindtype=value;}
			get{return _s_remindtype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_ElementID
		{
			set{ _n_elementid=value;}
			get{return _n_elementid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_SendType
		{
			set{ _s_sendtype=value;}
			get{return _s_sendtype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool b_SendFail
		{
			set{ _b_sendfail=value;}
			get{return _b_sendfail;}
		}
		/// <summary>
		/// 
		/// </summary>
		public Guid s_GuID
		{
			set{ _s_guid=value;}
			get{return _s_guid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_RemainingDays
		{
			set{ _s_remainingdays=value;}
			get{return _s_remainingdays;}
		}
		#endregion Model

	}
}


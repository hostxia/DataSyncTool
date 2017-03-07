/**  版本信息模板在安装目录下，可自行修改。
* TCode_CaseRoleAssignRule.cs
*
* 功 能： N/A
* 类 名： TCode_CaseRoleAssignRule
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:45:58   N/A    初版
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
	/// TCode_CaseRoleAssignRule:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TCode_CaseRoleAssignRule
	{
		public TCode_CaseRoleAssignRule()
		{}
		#region Model
		private int _n_id;
		private int _n_codecaseroleid;
		private string _s_assignrule;
		private int _n_employeeid;
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
		public int n_CodeCaseRoleID
		{
			set{ _n_codecaseroleid=value;}
			get{return _n_codecaseroleid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_AssignRule
		{
			set{ _s_assignrule=value;}
			get{return _s_assignrule;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int n_EmployeeID
		{
			set{ _n_employeeid=value;}
			get{return _n_employeeid;}
		}
		#endregion Model

	}
}


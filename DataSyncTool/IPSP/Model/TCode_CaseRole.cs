/**  版本信息模板在安装目录下，可自行修改。
* TCode_CaseRole.cs
*
* 功 能： N/A
* 类 名： TCode_CaseRole
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:45:57   N/A    初版
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
	/// TCode_CaseRole:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TCode_CaseRole
	{
		public TCode_CaseRole()
		{}
		#region Model
		private int _n_id;
		private string _s_name;
		private string _s_note;
		private string _s_assignruletype;
		private string _s_assignrulevalue;
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
		public string s_Name
		{
			set{ _s_name=value;}
			get{return _s_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_Note
		{
			set{ _s_note=value;}
			get{return _s_note;}
		}
		/// <summary>
		/// 分配规则：D按部门；L按尾号
		/// </summary>
		public string s_AssignRuleType
		{
			set{ _s_assignruletype=value;}
			get{return _s_assignruletype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_AssignRuleValue
		{
			set{ _s_assignrulevalue=value;}
			get{return _s_assignrulevalue;}
		}
		#endregion Model

	}
}


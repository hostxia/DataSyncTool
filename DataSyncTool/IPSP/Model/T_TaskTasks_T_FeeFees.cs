/**  版本信息模板在安装目录下，可自行修改。
* T_TaskTasks_T_FeeFees.cs
*
* 功 能： N/A
* 类 名： T_TaskTasks_T_FeeFees
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:45:09   N/A    初版
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
	/// T_TaskTasks_T_FeeFees:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class T_TaskTasks_T_FeeFees
	{
		public T_TaskTasks_T_FeeFees()
		{}
		#region Model
		private int _fees;
		private int _tasks;
		private int _oid;
		private int? _optimisticlockfield;
		/// <summary>
		/// 
		/// </summary>
		public int Fees
		{
			set{ _fees=value;}
			get{return _fees;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int Tasks
		{
			set{ _tasks=value;}
			get{return _tasks;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int OID
		{
			set{ _oid=value;}
			get{return _oid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? OptimisticLockField
		{
			set{ _optimisticlockfield=value;}
			get{return _optimisticlockfield;}
		}
		#endregion Model

	}
}


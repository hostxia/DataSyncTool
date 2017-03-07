/**  版本信息模板在安装目录下，可自行修改。
* T_TaskChecks.cs
*
* 功 能： N/A
* 类 名： T_TaskChecks
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:45:07   N/A    初版
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
	/// T_TaskChecks:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class T_TaskChecks
	{
		public T_TaskChecks()
		{}
		#region Model
		private int _n_id;
		private int _n_taskid;
		private int _n_checkflowid;
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
		public int n_TaskID
		{
			set{ _n_taskid=value;}
			get{return _n_taskid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int n_CheckFlowID
		{
			set{ _n_checkflowid=value;}
			get{return _n_checkflowid;}
		}
		#endregion Model

	}
}


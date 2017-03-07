/**  版本信息模板在安装目录下，可自行修改。
* TF_DemandTypeInTask.cs
*
* 功 能： N/A
* 类 名： TF_DemandTypeInTask
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:48:12   N/A    初版
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
	/// TF_DemandTypeInTask:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TF_DemandTypeInTask
	{
		public TF_DemandTypeInTask()
		{}
		#region Model
		private Guid _g_id;
		private Guid _g_taskid;
		private int _n_codedemandtypeid;
		/// <summary>
		/// 
		/// </summary>
		public Guid g_ID
		{
			set{ _g_id=value;}
			get{return _g_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public Guid g_TaskID
		{
			set{ _g_taskid=value;}
			get{return _g_taskid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int n_CodeDemandTypeID
		{
			set{ _n_codedemandtypeid=value;}
			get{return _n_codedemandtypeid;}
		}
		#endregion Model

	}
}


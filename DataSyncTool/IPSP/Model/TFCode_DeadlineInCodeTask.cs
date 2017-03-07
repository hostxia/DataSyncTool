/**  版本信息模板在安装目录下，可自行修改。
* TFCode_DeadlineInCodeTask.cs
*
* 功 能： N/A
* 类 名： TFCode_DeadlineInCodeTask
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:48:37   N/A    初版
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
	/// TFCode_DeadlineInCodeTask:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TFCode_DeadlineInCodeTask
	{
		public TFCode_DeadlineInCodeTask()
		{}
		#region Model
		private Guid _g_id;
		private Guid _g_codetaskguid;
		private Guid _g_codedeadlineid;
		private string _s_updatetime;
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
		public Guid g_CodeTaskGuid
		{
			set{ _g_codetaskguid=value;}
			get{return _g_codetaskguid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public Guid g_CodeDeadlineID
		{
			set{ _g_codedeadlineid=value;}
			get{return _g_codedeadlineid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_UpdateTime
		{
			set{ _s_updatetime=value;}
			get{return _s_updatetime;}
		}
		#endregion Model

	}
}


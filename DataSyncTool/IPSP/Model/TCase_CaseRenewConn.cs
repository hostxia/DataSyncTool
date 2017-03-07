/**  版本信息模板在安装目录下，可自行修改。
* TCase_CaseRenewConn.cs
*
* 功 能： N/A
* 类 名： TCase_CaseRenewConn
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:45:29   N/A    初版
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
	/// TCase_CaseRenewConn:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TCase_CaseRenewConn
	{
		public TCase_CaseRenewConn()
		{}
		#region Model
		private int _n_id;
		private int? _n_origcaseid;
		private int? _n_newcaseid;
		private Guid _g_taskguid;
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
		public int? n_OrigCaseID
		{
			set{ _n_origcaseid=value;}
			get{return _n_origcaseid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_NewCaseID
		{
			set{ _n_newcaseid=value;}
			get{return _n_newcaseid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public Guid g_TaskGuid
		{
			set{ _g_taskguid=value;}
			get{return _g_taskguid;}
		}
		#endregion Model

	}
}


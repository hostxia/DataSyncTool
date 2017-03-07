/**  版本信息模板在安装目录下，可自行修改。
* TF_Deadline.cs
*
* 功 能： N/A
* 类 名： TF_Deadline
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:48:11   N/A    初版
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
	/// TF_Deadline:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TF_Deadline
	{
		public TF_Deadline()
		{}
		#region Model
		private int _n_id;
		private Guid _g_codedeadlineid;
		private string _s_relatedobjecttype;
		private int? _n_relatedobjectid;
		private DateTime? _dt_deadline;
		private string _s_manualupdatedeadline;
		private string _s_allowedit;
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
		public Guid g_CodeDeadlineID
		{
			set{ _g_codedeadlineid=value;}
			get{return _g_codedeadlineid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_RelatedObjectType
		{
			set{ _s_relatedobjecttype=value;}
			get{return _s_relatedobjecttype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_RelatedObjectID
		{
			set{ _n_relatedobjectid=value;}
			get{return _n_relatedobjectid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? dt_Deadline
		{
			set{ _dt_deadline=value;}
			get{return _dt_deadline;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_ManualUpdateDeadline
		{
			set{ _s_manualupdatedeadline=value;}
			get{return _s_manualupdatedeadline;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_AllowEdit
		{
			set{ _s_allowedit=value;}
			get{return _s_allowedit;}
		}
		#endregion Model

	}
}


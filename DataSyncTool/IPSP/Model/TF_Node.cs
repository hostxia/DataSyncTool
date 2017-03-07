/**  版本信息模板在安装目录下，可自行修改。
* TF_Node.cs
*
* 功 能： N/A
* 类 名： TF_Node
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:48:14   N/A    初版
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
	/// TF_Node:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TF_Node
	{
		public TF_Node()
		{}
		#region Model
		private Guid _g_id;
		private string _s_codenodecode;
		private Guid _g_taskchainguid;
		private Guid _g_formernodeguid;
		private string _s_mode;
		private string _s_type;
		private Guid _g_owntaskchainguid;
		private Guid _g_owntaskguid;
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
		public string s_CodeNodeCode
		{
			set{ _s_codenodecode=value;}
			get{return _s_codenodecode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public Guid g_TaskChainGuid
		{
			set{ _g_taskchainguid=value;}
			get{return _g_taskchainguid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public Guid g_FormerNodeGuid
		{
			set{ _g_formernodeguid=value;}
			get{return _g_formernodeguid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_Mode
		{
			set{ _s_mode=value;}
			get{return _s_mode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_Type
		{
			set{ _s_type=value;}
			get{return _s_type;}
		}
		/// <summary>
		/// 
		/// </summary>
		public Guid g_OwnTaskChainGuid
		{
			set{ _g_owntaskchainguid=value;}
			get{return _g_owntaskchainguid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public Guid g_OwnTaskGuid
		{
			set{ _g_owntaskguid=value;}
			get{return _g_owntaskguid;}
		}
		#endregion Model

	}
}


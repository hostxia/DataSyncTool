/**  版本信息模板在安装目录下，可自行修改。
* TFCode_NodeRelation.cs
*
* 功 能： N/A
* 类 名： TFCode_NodeRelation
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:48:47   N/A    初版
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
	/// TFCode_NodeRelation:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TFCode_NodeRelation
	{
		public TFCode_NodeRelation()
		{}
		#region Model
		private Guid _g_id;
		private string _s_name;
		private string _s_description;
		private Guid _g_codetaskchainguid;
		private Guid _g_fromnodeguid;
		private Guid _g_tonodeguid;
		private string _s_condition;
		private string _s_reopen;
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
		public string s_Name
		{
			set{ _s_name=value;}
			get{return _s_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_Description
		{
			set{ _s_description=value;}
			get{return _s_description;}
		}
		/// <summary>
		/// 
		/// </summary>
		public Guid g_CodeTaskChainGuid
		{
			set{ _g_codetaskchainguid=value;}
			get{return _g_codetaskchainguid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public Guid g_FromNodeGuid
		{
			set{ _g_fromnodeguid=value;}
			get{return _g_fromnodeguid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public Guid g_ToNodeGuid
		{
			set{ _g_tonodeguid=value;}
			get{return _g_tonodeguid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_Condition
		{
			set{ _s_condition=value;}
			get{return _s_condition;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_Reopen
		{
			set{ _s_reopen=value;}
			get{return _s_reopen;}
		}
		#endregion Model

	}
}


/**  版本信息模板在安装目录下，可自行修改。
* TFCode_Node.cs
*
* 功 能： N/A
* 类 名： TFCode_Node
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:48:46   N/A    初版
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
	/// TFCode_Node:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TFCode_Node
	{
		public TFCode_Node()
		{}
		#region Model
		private Guid _g_id;
		private Guid _g_codetaskchainguid;
		private string _s_type;
		private Guid _g_owncodetaskchainguid;
		private Guid _g_owncodetaskguid;
		private string _s_pregenerate;
		private string _s_precondition;
		private string _s_code;
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
		public Guid g_CodeTaskChainGuid
		{
			set{ _g_codetaskchainguid=value;}
			get{return _g_codetaskchainguid;}
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
		public Guid g_OwnCodeTaskChainGuid
		{
			set{ _g_owncodetaskchainguid=value;}
			get{return _g_owncodetaskchainguid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public Guid g_OwnCodeTaskGuid
		{
			set{ _g_owncodetaskguid=value;}
			get{return _g_owncodetaskguid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_PreGenerate
		{
			set{ _s_pregenerate=value;}
			get{return _s_pregenerate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_PreCondition
		{
			set{ _s_precondition=value;}
			get{return _s_precondition;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_Code
		{
			set{ _s_code=value;}
			get{return _s_code;}
		}
		#endregion Model

	}
}


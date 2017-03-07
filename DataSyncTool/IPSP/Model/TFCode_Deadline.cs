/**  版本信息模板在安装目录下，可自行修改。
* TFCode_Deadline.cs
*
* 功 能： N/A
* 类 名： TFCode_Deadline
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:48:36   N/A    初版
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
	/// TFCode_Deadline:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TFCode_Deadline
	{
		public TFCode_Deadline()
		{}
		#region Model
		private Guid _g_id;
		private string _s_name;
		private string _s_type;
		private string _s_valuerule;
		private string _s_description;
		private string _s_classification;
		private string _s_allowedit;
		private string _s_storedprocedure;
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
		public string s_Type
		{
			set{ _s_type=value;}
			get{return _s_type;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_ValueRule
		{
			set{ _s_valuerule=value;}
			get{return _s_valuerule;}
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
		public string s_Classification
		{
			set{ _s_classification=value;}
			get{return _s_classification;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_AllowEdit
		{
			set{ _s_allowedit=value;}
			get{return _s_allowedit;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_StoredProcedure
		{
			set{ _s_storedprocedure=value;}
			get{return _s_storedprocedure;}
		}
		#endregion Model

	}
}


/**  版本信息模板在安装目录下，可自行修改。
* TFCode_CustomCondition.cs
*
* 功 能： N/A
* 类 名： TFCode_CustomCondition
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:48:34   N/A    初版
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
	/// TFCode_CustomCondition:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TFCode_CustomCondition
	{
		public TFCode_CustomCondition()
		{}
		#region Model
		private int _n_id;
		private string _s_code;
		private string _s_name;
		private string _s_values;
		private string _s_multiselect;
		private string _s_description;
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
		public string s_Code
		{
			set{ _s_code=value;}
			get{return _s_code;}
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
		public string s_Values
		{
			set{ _s_values=value;}
			get{return _s_values;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_MultiSelect
		{
			set{ _s_multiselect=value;}
			get{return _s_multiselect;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_Description
		{
			set{ _s_description=value;}
			get{return _s_description;}
		}
		#endregion Model

	}
}


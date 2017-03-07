/**  版本信息模板在安装目录下，可自行修改。
* T_FTPConfig.cs
*
* 功 能： N/A
* 类 名： T_FTPConfig
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:44:50   N/A    初版
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
	/// T_FTPConfig:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class T_FTPConfig
	{
		public T_FTPConfig()
		{}
		#region Model
		private string _s_item;
		private string _s_value;
		/// <summary>
		/// 
		/// </summary>
		public string s_Item
		{
			set{ _s_item=value;}
			get{return _s_item;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_Value
		{
			set{ _s_value=value;}
			get{return _s_value;}
		}
		#endregion Model

	}
}


﻿/**  版本信息模板在安装目录下，可自行修改。
* TCode_CheckActions.cs
*
* 功 能： N/A
* 类 名： TCode_CheckActions
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:45:59   N/A    初版
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
	/// TCode_CheckActions:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TCode_CheckActions
	{
		public TCode_CheckActions()
		{}
		#region Model
		private int _n_id;
		private string _s_module;
		private string _s_actionname;
		private string _s_controlcode;
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
		public string s_Module
		{
			set{ _s_module=value;}
			get{return _s_module;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_ActionName
		{
			set{ _s_actionname=value;}
			get{return _s_actionname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_ControlCode
		{
			set{ _s_controlcode=value;}
			get{return _s_controlcode;}
		}
		#endregion Model

	}
}


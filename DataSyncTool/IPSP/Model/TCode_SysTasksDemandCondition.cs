/**  版本信息模板在安装目录下，可自行修改。
* TCode_SysTasksDemandCondition.cs
*
* 功 能： N/A
* 类 名： TCode_SysTasksDemandCondition
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:47:11   N/A    初版
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
	/// TCode_SysTasksDemandCondition:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TCode_SysTasksDemandCondition
	{
		public TCode_SysTasksDemandCondition()
		{}
		#region Model
		private int _n_id;
		private int _n_systaskcodeid;
		private int _n_codedemandid;
		private bool _b_exist;
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
		public int n_SysTaskCodeID
		{
			set{ _n_systaskcodeid=value;}
			get{return _n_systaskcodeid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int n_CodeDemandID
		{
			set{ _n_codedemandid=value;}
			get{return _n_codedemandid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool b_Exist
		{
			set{ _b_exist=value;}
			get{return _b_exist;}
		}
		#endregion Model

	}
}


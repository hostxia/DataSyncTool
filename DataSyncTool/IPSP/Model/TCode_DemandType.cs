/**  版本信息模板在安装目录下，可自行修改。
* TCode_DemandType.cs
*
* 功 能： N/A
* 类 名： TCode_DemandType
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:46:13   N/A    初版
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
	/// TCode_DemandType:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TCode_DemandType
	{
		public TCode_DemandType()
		{}
		#region Model
		private int _n_id;
		private string _s_codedemandtype;
		private string _s_codedemandposition;
		private string _s_creator;
		private DateTime? _dt_createdate;
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
		public string s_CodeDemandType
		{
			set{ _s_codedemandtype=value;}
			get{return _s_codedemandtype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_CodeDemandPosition
		{
			set{ _s_codedemandposition=value;}
			get{return _s_codedemandposition;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_Creator
		{
			set{ _s_creator=value;}
			get{return _s_creator;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? dt_CreateDate
		{
			set{ _dt_createdate=value;}
			get{return _dt_createdate;}
		}
		#endregion Model

	}
}


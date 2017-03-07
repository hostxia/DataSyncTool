/**  版本信息模板在安装目录下，可自行修改。
* TCode_State.cs
*
* 功 能： N/A
* 类 名： TCode_State
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:47:04   N/A    初版
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
	/// TCode_State:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TCode_State
	{
		public TCode_State()
		{}
		#region Model
		private int _n_stateid;
		private int _n_country;
		private string _s_statename;
		private string _s_ostatename;
		private string _s_regioncode;
		/// <summary>
		/// 
		/// </summary>
		public int n_StateID
		{
			set{ _n_stateid=value;}
			get{return _n_stateid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int n_Country
		{
			set{ _n_country=value;}
			get{return _n_country;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_StateName
		{
			set{ _s_statename=value;}
			get{return _s_statename;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_OStateName
		{
			set{ _s_ostatename=value;}
			get{return _s_ostatename;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_RegionCode
		{
			set{ _s_regioncode=value;}
			get{return _s_regioncode;}
		}
		#endregion Model

	}
}


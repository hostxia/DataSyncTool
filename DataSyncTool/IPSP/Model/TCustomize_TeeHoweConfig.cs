﻿/**  版本信息模板在安装目录下，可自行修改。
* TCustomize_TeeHoweConfig.cs
*
* 功 能： N/A
* 类 名： TCustomize_TeeHoweConfig
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:48:05   N/A    初版
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
	/// TCustomize_TeeHoweConfig:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TCustomize_TeeHoweConfig
	{
		public TCustomize_TeeHoweConfig()
		{}
		#region Model
		private int _n_id;
		private string _s_positiontype;
		private string _s_matchvaule;
		private string _s_resulttype;
		private string _s_resultvalue1;
		private string _s_resultvalue2;
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
		public string s_PositionType
		{
			set{ _s_positiontype=value;}
			get{return _s_positiontype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_MatchVaule
		{
			set{ _s_matchvaule=value;}
			get{return _s_matchvaule;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_ResultType
		{
			set{ _s_resulttype=value;}
			get{return _s_resulttype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_ResultValue1
		{
			set{ _s_resultvalue1=value;}
			get{return _s_resultvalue1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_ResultValue2
		{
			set{ _s_resultvalue2=value;}
			get{return _s_resultvalue2;}
		}
		#endregion Model

	}
}


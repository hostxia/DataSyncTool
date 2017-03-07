/**  版本信息模板在安装目录下，可自行修改。
* TCstmr_FeePreferentialCombine.cs
*
* 功 能： N/A
* 类 名： TCstmr_FeePreferentialCombine
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:47:55   N/A    初版
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
	/// TCstmr_FeePreferentialCombine:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TCstmr_FeePreferentialCombine
	{
		public TCstmr_FeePreferentialCombine()
		{}
		#region Model
		private int _n_id;
		private int _n_clientid;
		private int _n_appid;
		private string _s_iptype;
		private int? _n_combineid;
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
		public int n_ClientID
		{
			set{ _n_clientid=value;}
			get{return _n_clientid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int n_AppID
		{
			set{ _n_appid=value;}
			get{return _n_appid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_IPType
		{
			set{ _s_iptype=value;}
			get{return _s_iptype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_CombineID
		{
			set{ _n_combineid=value;}
			get{return _n_combineid;}
		}
		#endregion Model

	}
}


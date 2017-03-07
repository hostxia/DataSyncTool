/**  版本信息模板在安装目录下，可自行修改。
* TCstmr_AppTransLatedName.cs
*
* 功 能： N/A
* 类 名： TCstmr_AppTransLatedName
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:47:38   N/A    初版
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
	/// TCstmr_AppTransLatedName:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TCstmr_AppTransLatedName
	{
		public TCstmr_AppTransLatedName()
		{}
		#region Model
		private int _n_id;
		private string _s_apptranslatedname;
		private string _s_trustdeednum;
		private string _s_apptranslatednameuse;
		private int _n_appid;
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
		public string s_AppTransLatedName
		{
			set{ _s_apptranslatedname=value;}
			get{return _s_apptranslatedname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_TrustdeedNum
		{
			set{ _s_trustdeednum=value;}
			get{return _s_trustdeednum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_AppTransLatedNameUse
		{
			set{ _s_apptranslatednameuse=value;}
			get{return _s_apptranslatednameuse;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int n_AppID
		{
			set{ _n_appid=value;}
			get{return _n_appid;}
		}
		#endregion Model

	}
}


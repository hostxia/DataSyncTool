/**  版本信息模板在安装目录下，可自行修改。
* TTCase_CountermandInfo.cs
*
* 功 能： N/A
* 类 名： TTCase_CountermandInfo
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:50:26   N/A    初版
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
	/// TTCase_CountermandInfo:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TTCase_CountermandInfo
	{
		public TTCase_CountermandInfo()
		{}
		#region Model
		private int _n_id;
		private int _n_caseid;
		private string _s_countermandtype;
		private string _s_reason;
		private string _s_applyinfo;
		private string _s_checknum;
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
		public int n_CaseID
		{
			set{ _n_caseid=value;}
			get{return _n_caseid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_CountermandType
		{
			set{ _s_countermandtype=value;}
			get{return _s_countermandtype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_Reason
		{
			set{ _s_reason=value;}
			get{return _s_reason;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_ApplyInfo
		{
			set{ _s_applyinfo=value;}
			get{return _s_applyinfo;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_CheckNum
		{
			set{ _s_checknum=value;}
			get{return _s_checknum;}
		}
		#endregion Model

	}
}


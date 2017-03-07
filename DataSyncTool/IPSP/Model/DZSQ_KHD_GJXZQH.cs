/**  版本信息模板在安装目录下，可自行修改。
* DZSQ_KHD_GJXZQH.cs
*
* 功 能： N/A
* 类 名： DZSQ_KHD_GJXZQH
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:44:27   N/A    初版
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
	/// DZSQ_KHD_GJXZQH:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class DZSQ_KHD_GJXZQH
	{
		public DZSQ_KHD_GJXZQH()
		{}
		#region Model
		private string _gjxzqh_id;
		private string _gjxzqhdm;
		private string _gjxzqhmc;
		private string _gjxzqhsj;
		private string _gjxzqhyzbm;
		private string _zhuantai;
		/// <summary>
		/// 
		/// </summary>
		public string GJXZQH_ID
		{
			set{ _gjxzqh_id=value;}
			get{return _gjxzqh_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GJXZQHDM
		{
			set{ _gjxzqhdm=value;}
			get{return _gjxzqhdm;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GJXZQHMC
		{
			set{ _gjxzqhmc=value;}
			get{return _gjxzqhmc;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GJXZQHSJ
		{
			set{ _gjxzqhsj=value;}
			get{return _gjxzqhsj;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GJXZQHYZBM
		{
			set{ _gjxzqhyzbm=value;}
			get{return _gjxzqhyzbm;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ZHUANTAI
		{
			set{ _zhuantai=value;}
			get{return _zhuantai;}
		}
		#endregion Model

	}
}


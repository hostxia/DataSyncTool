/**  版本信息模板在安装目录下，可自行修改。
* DZSQ_KHD_GJDQPZB.cs
*
* 功 能： N/A
* 类 名： DZSQ_KHD_GJDQPZB
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:44:26   N/A    初版
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
	/// DZSQ_KHD_GJDQPZB:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class DZSQ_KHD_GJDQPZB
	{
		public DZSQ_KHD_GJDQPZB()
		{}
		#region Model
		private string _guojiadqid;
		private string _guojiadqdm;
		private string _guojiadqmc;
		/// <summary>
		/// 
		/// </summary>
		public string GUOJIADQID
		{
			set{ _guojiadqid=value;}
			get{return _guojiadqid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GUOJIADQDM
		{
			set{ _guojiadqdm=value;}
			get{return _guojiadqdm;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GUOJIADQMC
		{
			set{ _guojiadqmc=value;}
			get{return _guojiadqmc;}
		}
		#endregion Model

	}
}


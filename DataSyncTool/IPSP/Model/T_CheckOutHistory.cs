/**  版本信息模板在安装目录下，可自行修改。
* T_CheckOutHistory.cs
*
* 功 能： N/A
* 类 名： T_CheckOutHistory
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:44:35   N/A    初版
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
	/// T_CheckOutHistory:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class T_CheckOutHistory
	{
		public T_CheckOutHistory()
		{}
		#region Model
		private decimal _n_id;
		private decimal? _n_fileid;
		private decimal? _n_mainfileid;
		private string _s_checkoutuser;
		private DateTime? _dt_checkout;
		private string _s_action;
		/// <summary>
		/// 
		/// </summary>
		public decimal n_ID
		{
			set{ _n_id=value;}
			get{return _n_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? n_FileID
		{
			set{ _n_fileid=value;}
			get{return _n_fileid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? n_MainFileID
		{
			set{ _n_mainfileid=value;}
			get{return _n_mainfileid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_CheckOutUser
		{
			set{ _s_checkoutuser=value;}
			get{return _s_checkoutuser;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? dt_CheckOut
		{
			set{ _dt_checkout=value;}
			get{return _dt_checkout;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_Action
		{
			set{ _s_action=value;}
			get{return _s_action;}
		}
		#endregion Model

	}
}


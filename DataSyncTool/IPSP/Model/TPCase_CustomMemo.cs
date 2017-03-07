/**  版本信息模板在安装目录下，可自行修改。
* TPCase_CustomMemo.cs
*
* 功 能： N/A
* 类 名： TPCase_CustomMemo
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:49:18   N/A    初版
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
	/// TPCase_CustomMemo:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TPCase_CustomMemo
	{
		public TPCase_CustomMemo()
		{}
		#region Model
		private int _n_caseid;
		private string _s_name;
		private string _s_licensenum;
		private DateTime? _dt_expireddate;
		private string _s_note;
		private string _s_attachedfiles;
		private string _s_otherclaim;
		private string _s_appnum;
		private DateTime? _dt_receivedate;
		private string _s_memoname;
		private DateTime? _dt_checkdate;
		private DateTime? _dt_confirmdate;
		private string _s_memonum;
		private DateTime? _dt_memoexpiredate;
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
		public string s_Name
		{
			set{ _s_name=value;}
			get{return _s_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_LicenseNum
		{
			set{ _s_licensenum=value;}
			get{return _s_licensenum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? dt_ExpiredDate
		{
			set{ _dt_expireddate=value;}
			get{return _dt_expireddate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_Note
		{
			set{ _s_note=value;}
			get{return _s_note;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_AttachedFiles
		{
			set{ _s_attachedfiles=value;}
			get{return _s_attachedfiles;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_OtherClaim
		{
			set{ _s_otherclaim=value;}
			get{return _s_otherclaim;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_AppNum
		{
			set{ _s_appnum=value;}
			get{return _s_appnum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? dt_ReceiveDate
		{
			set{ _dt_receivedate=value;}
			get{return _dt_receivedate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_MemoName
		{
			set{ _s_memoname=value;}
			get{return _s_memoname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? dt_CheckDate
		{
			set{ _dt_checkdate=value;}
			get{return _dt_checkdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? dt_ConfirmDate
		{
			set{ _dt_confirmdate=value;}
			get{return _dt_confirmdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_MemoNum
		{
			set{ _s_memonum=value;}
			get{return _s_memonum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? dt_MemoExpireDate
		{
			set{ _dt_memoexpiredate=value;}
			get{return _dt_memoexpiredate;}
		}
		#endregion Model

	}
}


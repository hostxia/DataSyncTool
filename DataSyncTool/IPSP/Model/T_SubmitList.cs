/**  版本信息模板在安装目录下，可自行修改。
* T_SubmitList.cs
*
* 功 能： N/A
* 类 名： T_SubmitList
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:45:04   N/A    初版
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
	/// T_SubmitList:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class T_SubmitList
	{
		public T_SubmitList()
		{}
		#region Model
		private string _s_listserial;
		private int? _n_flownum;
		private string _s_listclass;
		private string _s_isregonline;
		private decimal? _n_currbalance;
		private int? _n_writerid;
		private int? _n_submiterid;
		private int _n_fileid;
		private string _s_receivefilepathname;
		/// <summary>
		/// 
		/// </summary>
		public string s_ListSerial
		{
			set{ _s_listserial=value;}
			get{return _s_listserial;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_FlowNum
		{
			set{ _n_flownum=value;}
			get{return _n_flownum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_ListClass
		{
			set{ _s_listclass=value;}
			get{return _s_listclass;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_IsRegOnline
		{
			set{ _s_isregonline=value;}
			get{return _s_isregonline;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? n_CurrBalance
		{
			set{ _n_currbalance=value;}
			get{return _n_currbalance;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_WriterID
		{
			set{ _n_writerid=value;}
			get{return _n_writerid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_SubmiterID
		{
			set{ _n_submiterid=value;}
			get{return _n_submiterid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int n_FileID
		{
			set{ _n_fileid=value;}
			get{return _n_fileid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_ReceiveFilePathName
		{
			set{ _s_receivefilepathname=value;}
			get{return _s_receivefilepathname;}
		}
		#endregion Model

	}
}


/**  版本信息模板在安装目录下，可自行修改。
* TCode_CaseProcess.cs
*
* 功 能： N/A
* 类 名： TCode_CaseProcess
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:45:54   N/A    初版
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
	/// TCode_CaseProcess:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TCode_CaseProcess
	{
		public TCode_CaseProcess()
		{}
		#region Model
		private int _n_id;
		private int? _n_biztypeid;
		private string _s_ptctype;
		private int? _n_country;
		private string _s_isdefault;
		private string _s_notes;
		private string _s_iptype;
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
		public int? n_BizTypeID
		{
			set{ _n_biztypeid=value;}
			get{return _n_biztypeid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_PTCType
		{
			set{ _s_ptctype=value;}
			get{return _s_ptctype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_Country
		{
			set{ _n_country=value;}
			get{return _n_country;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_IsDefault
		{
			set{ _s_isdefault=value;}
			get{return _s_isdefault;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_Notes
		{
			set{ _s_notes=value;}
			get{return _s_notes;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_IPType
		{
			set{ _s_iptype=value;}
			get{return _s_iptype;}
		}
		#endregion Model

	}
}


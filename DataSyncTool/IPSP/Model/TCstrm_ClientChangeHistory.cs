/**  版本信息模板在安装目录下，可自行修改。
* TCstrm_ClientChangeHistory.cs
*
* 功 能： N/A
* 类 名： TCstrm_ClientChangeHistory
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:48:03   N/A    初版
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
	/// TCstrm_ClientChangeHistory:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TCstrm_ClientChangeHistory
	{
		public TCstrm_ClientChangeHistory()
		{}
		#region Model
		private int _n_id;
		private int? _n_clientid;
		private string _s_changeproject;
		private string _s_changefrom;
		private string _s_changeto;
		private DateTime? _dt_changedate;
		private string _s_notes;
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
		public int? n_ClientID
		{
			set{ _n_clientid=value;}
			get{return _n_clientid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_ChangeProject
		{
			set{ _s_changeproject=value;}
			get{return _s_changeproject;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_ChangeFrom
		{
			set{ _s_changefrom=value;}
			get{return _s_changefrom;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_ChangeTo
		{
			set{ _s_changeto=value;}
			get{return _s_changeto;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? dt_ChangeDate
		{
			set{ _dt_changedate=value;}
			get{return _dt_changedate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_Notes
		{
			set{ _s_notes=value;}
			get{return _s_notes;}
		}
		#endregion Model

	}
}


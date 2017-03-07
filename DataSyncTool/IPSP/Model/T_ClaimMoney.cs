/**  版本信息模板在安装目录下，可自行修改。
* T_ClaimMoney.cs
*
* 功 能： N/A
* 类 名： T_ClaimMoney
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
	/// T_ClaimMoney:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class T_ClaimMoney
	{
		public T_ClaimMoney()
		{}
		#region Model
		private int _n_id;
		private int _n_clientid;
		private int? _n_claimcount;
		private int? _n_lettertemplateid;
		private int? _n_emailtemplateid;
		private int _n_outfileid;
		private string _s_note;
		private string _s_editor;
		private DateTime? _dt_edittime;
		private int _n_emailoutfileid;
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
		public int? n_ClaimCount
		{
			set{ _n_claimcount=value;}
			get{return _n_claimcount;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_LetterTemplateID
		{
			set{ _n_lettertemplateid=value;}
			get{return _n_lettertemplateid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_EmailTemplateID
		{
			set{ _n_emailtemplateid=value;}
			get{return _n_emailtemplateid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int n_OutFileID
		{
			set{ _n_outfileid=value;}
			get{return _n_outfileid;}
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
		public string s_Editor
		{
			set{ _s_editor=value;}
			get{return _s_editor;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? dt_EditTime
		{
			set{ _dt_edittime=value;}
			get{return _dt_edittime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int n_EmailOutFileID
		{
			set{ _n_emailoutfileid=value;}
			get{return _n_emailoutfileid;}
		}
		#endregion Model

	}
}


/**  版本信息模板在安装目录下，可自行修改。
* T_FeeTranslator.cs
*
* 功 能： N/A
* 类 名： T_FeeTranslator
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:44:46   N/A    初版
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
	/// T_FeeTranslator:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class T_FeeTranslator
	{
		public T_FeeTranslator()
		{}
		#region Model
		private int _n_id;
		private int? _n_translatecount;
		private int _n_feeid;
		private int? _n_selecttranslatorid;
		private int? _n_feeworktypeid;
		private string _s_translator;
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
		public int? n_TransLateCount
		{
			set{ _n_translatecount=value;}
			get{return _n_translatecount;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int n_FeeID
		{
			set{ _n_feeid=value;}
			get{return _n_feeid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_SelectTranslatorID
		{
			set{ _n_selecttranslatorid=value;}
			get{return _n_selecttranslatorid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_FeeWorkTypeID
		{
			set{ _n_feeworktypeid=value;}
			get{return _n_feeworktypeid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_Translator
		{
			set{ _s_translator=value;}
			get{return _s_translator;}
		}
		#endregion Model

	}
}


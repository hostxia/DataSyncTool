/**  版本信息模板在安装目录下，可自行修改。
* TCode_AutoDemandParams.cs
*
* 功 能： N/A
* 类 名： TCode_AutoDemandParams
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:45:48   N/A    初版
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
	/// TCode_AutoDemandParams:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TCode_AutoDemandParams
	{
		public TCode_AutoDemandParams()
		{}
		#region Model
		private Guid _g_id;
		private Guid _g_codeautodemandid;
		private string _s_datatype;
		private string _s_ruleregex;
		private string _s_description;
		private int _n_sequence;
		/// <summary>
		/// 
		/// </summary>
		public Guid g_ID
		{
			set{ _g_id=value;}
			get{return _g_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public Guid g_CodeAutoDemandID
		{
			set{ _g_codeautodemandid=value;}
			get{return _g_codeautodemandid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_DataType
		{
			set{ _s_datatype=value;}
			get{return _s_datatype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_RuleRegex
		{
			set{ _s_ruleregex=value;}
			get{return _s_ruleregex;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_Description
		{
			set{ _s_description=value;}
			get{return _s_description;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int n_Sequence
		{
			set{ _n_sequence=value;}
			get{return _n_sequence;}
		}
		#endregion Model

	}
}


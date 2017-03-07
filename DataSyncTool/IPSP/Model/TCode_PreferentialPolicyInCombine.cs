/**  版本信息模板在安装目录下，可自行修改。
* TCode_PreferentialPolicyInCombine.cs
*
* 功 能： N/A
* 类 名： TCode_PreferentialPolicyInCombine
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:46:45   N/A    初版
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
	/// TCode_PreferentialPolicyInCombine:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TCode_PreferentialPolicyInCombine
	{
		public TCode_PreferentialPolicyInCombine()
		{}
		#region Model
		private int _n_id;
		private int? _n_sequence;
		private int _n_codepreferentialcombineid;
		private int? _n_preferentialpolicyid;
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
		public int? n_Sequence
		{
			set{ _n_sequence=value;}
			get{return _n_sequence;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int n_CodePreferentialCombineID
		{
			set{ _n_codepreferentialcombineid=value;}
			get{return _n_codepreferentialcombineid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_PreferentialPolicyID
		{
			set{ _n_preferentialpolicyid=value;}
			get{return _n_preferentialpolicyid;}
		}
		#endregion Model

	}
}


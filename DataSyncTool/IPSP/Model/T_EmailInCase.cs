/**  版本信息模板在安装目录下，可自行修改。
* T_EmailInCase.cs
*
* 功 能： N/A
* 类 名： T_EmailInCase
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:44:41   N/A    初版
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
	/// T_EmailInCase:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class T_EmailInCase
	{
		public T_EmailInCase()
		{}
		#region Model
		private int _n_id;
		private int _n_emailid;
		private int _n_caseid;
		private int _n_processid;
		private string _s_ismaincase;
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
		public int n_EmailID
		{
			set{ _n_emailid=value;}
			get{return _n_emailid;}
		}
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
		public int n_ProcessID
		{
			set{ _n_processid=value;}
			get{return _n_processid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_IsMainCase
		{
			set{ _s_ismaincase=value;}
			get{return _s_ismaincase;}
		}
		#endregion Model

	}
}


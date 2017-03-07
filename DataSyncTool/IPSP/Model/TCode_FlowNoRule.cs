/**  版本信息模板在安装目录下，可自行修改。
* TCode_FlowNoRule.cs
*
* 功 能： N/A
* 类 名： TCode_FlowNoRule
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2017/2/28 17:46:27   N/A    初版
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
	/// TCode_FlowNoRule:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TCode_FlowNoRule
	{
		public TCode_FlowNoRule()
		{}
		#region Model
		private int _n_id;
		private string _s_iptype;
		private string _s_flownorelate1;
		private string _s_flownorelate2;
		private string _s_flownorule;
		private string _s_flownotype;
		private int? _n_maxno;
		private string _s_reseteachyear;
		private int? _n_flownocount;
		private string _s_onetrademarkoneflow;
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
		public string s_IPType
		{
			set{ _s_iptype=value;}
			get{return _s_iptype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_FlowNoRelate1
		{
			set{ _s_flownorelate1=value;}
			get{return _s_flownorelate1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_FlowNoRelate2
		{
			set{ _s_flownorelate2=value;}
			get{return _s_flownorelate2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_FlowNoRule
		{
			set{ _s_flownorule=value;}
			get{return _s_flownorule;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_FlowNoType
		{
			set{ _s_flownotype=value;}
			get{return _s_flownotype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_MaxNo
		{
			set{ _n_maxno=value;}
			get{return _n_maxno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_ResetEachYear
		{
			set{ _s_reseteachyear=value;}
			get{return _s_reseteachyear;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? n_FlowNoCount
		{
			set{ _n_flownocount=value;}
			get{return _n_flownocount;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string s_OneTrademarkOneFlow
		{
			set{ _s_onetrademarkoneflow=value;}
			get{return _s_onetrademarkoneflow;}
		}
		#endregion Model

	}
}

